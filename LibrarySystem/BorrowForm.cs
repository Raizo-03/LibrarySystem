﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    public partial class BorrowForm : Form
    {

        // Dictionary to store selected values for each checkbox
        private Dictionary<CheckBox, string> selectedValuesDictionary = new Dictionary<CheckBox, string>();

        private int bookLimit; // Set the limit to 5 books
        private String userNAME;
        private String Identifier;
        private String ID;

        //FOR DATABASE
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";
        private DateTime currentDate;  // Change to DateTime
        private DateTime futureDate;  // Change to DateTime

        private int selectedBookId; // Class-level variable to store the selected book ID
        private List<int> selectedBookIds = new List<int>();
        private string Booktitle;
        CheckBox checkBox = new CheckBox();

        public BorrowForm(String identifier, string username, string id, int booklimit)
        {
            InitializeComponent();
            this.Identifier = identifier;
            this.ID = id;
            this.bookLimit = booklimit;
            this.userNAME = username;

            //BORROWING DATES
            currentDate = DateTime.Now;
            futureDate = currentDate.AddDays(3);

            borrowDate.Text = currentDate.ToString("MM/dd/yyyy");

            PopulateBookCheckBoxes();
            borrowDG.ReadOnly = true;
            borrowDG.AlternatingRowsDefaultCellStyle = null;
            borrowDG.RowHeadersVisible = false;
            borrowDG.ScrollBars = ScrollBars.Vertical;

            activateFetching();
     
            ApplyRoundedButtonStyle(calendarBtn);
        }
        private void ApplyRoundedButtonStyle(Guna2GradientButton button)
        {

            // Set the border radius to make the button rounded
            button.BorderRadius = 12; // Adjust the radius to control the roundness
        }

        private int GetReservedBooksCount(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void borrowedDatepicker_ValueChanged(object sender, EventArgs e)
        {
            // Update borrowDate TextBox with the selected date
            borrowDate.Text = borrowedDatepicker.Value.ToString("MM/dd/yyyy");

            // Calculate the future date by adding 3 days to the selected date
            futureDate = borrowedDatepicker.Value.AddDays(3);

            string userIdentifier = GetIdentifierFromDatabase();
            if (userIdentifier == "TEACHER")
            {
                dueDate.Text = "NO DUE DATE";
            }
            else
            {
                dueDate.Text = futureDate.ToString("MM/dd/yyyy");
            }

        }
        private void BorrowForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4
            borrowDG.BackgroundColor = Color.FromArgb(255, 253, 247, 228);

            activateFetching();
            borrowerName.Text = userNAME;
        }

        //POPULATE THE CHECKBOXES
        private void PopulateBookCheckBoxes()
        {
            // Fetch book data from the database
            List<Book> books = GetBooksFromDatabase();

            int topOffset = 120; // Adjust the initial vertical position to 120

            foreach (var book in books)
            {
                checkBox = new CheckBox();
                checkBox.Text = book.Title;
                checkBox.Tag = book.BookId;

                // Adjust the width based on the length of the text
                checkBox.Width = TextRenderer.MeasureText(checkBox.Text, checkBox.Font).Width + 250;
                checkBox.Location = new Point(609, topOffset); // Set the location with the adjusted topOffset
                topOffset += 25; // Adjust the vertical spacing as needed
                checkBox.Font = new Font("Arial Rounded MT Bold", 13); // Set the font

                // Get the book availability from the database
                string availability = GetBookAvailabilityFromDatabase(book.Title);

                // Disable the checkbox if the book is already borrowed
                if (availability == "BORROWED")
                {
                    checkBox.Enabled = false;
                }

                // Add the event handler for the CheckedChanged event
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                Controls.Add(checkBox);
            }
        }


        // GETS THE BOOKID
        private List<string> selectedBookTitles = new List<string>();

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                string bookTitle = checkBox.Text;

                if (checkBox.Checked && !selectedBookTitles.Contains(bookTitle))
                {
                    // Checkbox is checked and not already in the list, add it
                    selectedBookTitles.Add(bookTitle);
                }
                else if (!checkBox.Checked && selectedBookTitles.Contains(bookTitle))
                {
                    // Checkbox is unchecked and in the list, remove it
                    selectedBookTitles.Remove(bookTitle);
                }
            }
        }
        public void UpdateBookAvailability(string title, string availability)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Update the book availability based on the book title
                string query = "UPDATE books SET availability = @availability WHERE title = @title";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@availability", availability);

                    // Execute the update query
                    command.ExecuteNonQuery();
                }
            }
        }


        private string GetBookAvailabilityFromDatabase(string bookTitle)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT availability FROM books WHERE title = @bookTitle";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookTitle", bookTitle);

                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null; // Default value if not found
                }
            }
        }

        //GETS THE BOOKS FROM THE DATABASE
        private List<Book> GetBooksFromDatabase()
        {
            List<Book> books = new List<Book>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT book_id, title FROM books WHERE availability = 'AVAILABLE'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookId = reader.GetInt32("book_id");
                            string title = reader.GetString("title");

                            books.Add(new Book { BookId = bookId, Title = title });
                        }
                    }
                }
            }

            return books;
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to continue with the borrowing process?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check user's choice
            if (result == DialogResult.No)
            {
                // User chose not to continue, so return without executing the borrowing process
                return;
            }

            // Check for unpaid penalties
            if (HasUnpaidPenalties())
            {
                MessageBox.Show("You have unpaid penalties. Please clear them before borrowing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LibraryDataAccess library = new LibraryDataAccess();
            int borrowerId = GetBorrowerUserId();
            string identifier = GetIdentifierFromDatabase();

            // Check if the borrowerId is valid
            if (borrowerId == -1)
            {
                MessageBox.Show("Invalid Input. Please enter a valid borrower's name.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fetch the number of books reserved by the user
            int reservedBooksCount = GetReservedBooksCount(borrowerId);

            // Check if the borrower is a student and has already borrowed 2 books
            if (identifier == "STUDENT" && CountBorrowedBooks(borrowerId) + selectedBookTitles.Count > 2)
            {
                MessageBox.Show("Students can only borrow up to 2 books.");
                return;
            }
            else if (identifier == "TEACHER" && CountBorrowedBooks(borrowerId) + selectedBookTitles.Count > 5)
            {
                MessageBox.Show("Teachers can only borrow up to 5 books.");
                return;
            }
            if (!CanBorrowerBorrow(borrowerId))
            {
                return;
            }

            // Check if any checkboxes are selected
            if (selectedBookTitles.Count == 0)
            {
                MessageBox.Show("Invalid Input. Please select at least one book.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

  
            // Check if any selected book is of the "ACADEMIC" genre
            foreach (string bookTitle in selectedBookTitles)
            {
                string genre = GetBookGenreFromDatabase(bookTitle);
                if (genre == "ACADEMIC")
                {
                    MessageBox.Show("Academic Books are only allowed inside the library.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Continue with the borrowing process for non-academic books

            foreach (string bookTitle in selectedBookTitles)
            {
                // Get the book availability from the database
                string availability = GetBookAvailabilityFromDatabase(bookTitle);

                // Check if the book is already borrowed
                if (availability == "BORROWED")
                {
                    MessageBox.Show($"The book '{bookTitle}' is already borrowed and cannot be borrowed again.");
                    continue; // Skip to the next book
                }

                // Parse borrowDate and dueDate TextBox values to DateTime
                if (DateTime.TryParse(borrowDate.Text, out DateTime borrowDateTime))
                {
                    if (!string.IsNullOrEmpty(dueDate.Text))  // Check if dueDate.Text is not null or empty
                    {
                        if (dueDate.Text.Equals("NO DUE DATE"))
                        {
                            // Use the selected book title, borrow date, and no due date in the BorrowBook method
                            library.BorrowBook(bookTitle, borrowerId, borrowDateTime, DateTime.MaxValue); // Use DateTime.MaxValue as a placeholder
                        }
                        else if (DateTime.TryParse(dueDate.Text, out DateTime dueDateTime))
                        {
                            // Use the selected book title, borrow date, and due date in the BorrowBook method
                            library.BorrowBook(bookTitle, borrowerId, borrowDateTime, dueDateTime);
                        }
                        else
                        {
                            MessageBox.Show("Invalid due date format. Please enter a valid due date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Update the book availability to 'BORROWED' in the database
                        UpdateBookAvailability(bookTitle, "BORROWED");
                    }
                    else
                    {
                        MessageBox.Show("Input Necessary Details. Please enter a valid due date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid borrow date format.");
                    return;
                }
            }

            MessageBox.Show("Borrowing successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the list of available books after borrowing
            PopulateBookCheckBoxes();

            // Close the current form and open the Dashboard form
            Form mdiParent = this.MdiParent;
            if (mdiParent != null)
            {
                mdiParent.Close();
            }
            string name = "ADMIN 1";
            string id = " ";
            int limit = 0;
            Dashboard dashboardForm = new Dashboard(identifier, name, id, limit);
            dashboardForm.Show();
            this.Close();
        }

        private bool HasUnpaidPenalties()
        {
            int borrowerId = GetBorrowerUserId();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM penalties WHERE borrower_id = @borrowerId AND paid = 0";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        private string GetBookGenreFromDatabase(string bookTitle)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT genre FROM books WHERE title = @bookTitle";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookTitle", bookTitle);

                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null; // Default value if not found
                }
            }
        }




        // Additional method to count the number of books borrowed by a user
        private int CountBorrowedBooks(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Count all rows for the user in the borrowings table
                string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }




        //GETTING USER INFO FROM DATABASE
        private int GetBorrowerUserId()
        {
            // Get the borrower's name from your textbox
            string borrowerNames = borrowerName.Text.Trim(); // Replace with your actual textbox name

            // Query the database to get the user ID based on the borrower's name
            int userId = GetUserFromDatabase(borrowerNames);

            // Return the user ID
            return userId;
        }
        private int GetUserFromDatabase(string borrowerName)
        {
            // Use your data access layer to query the database and retrieve the user ID
            // This is a simplified example, and you need to replace it with your actual database access code

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT user_id FROM borrowers WHERE name = @borrowerName";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerName", borrowerName);

                    // Execute the query and return the user ID
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // Default value if not found
                }
            }
        }
        private string GetIdentifierFromDatabase()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT identifier FROM borrowers WHERE name = @borrowerName";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@borrowerName", borrowerName.Text.Trim());

                        var result = command.ExecuteScalar();
                        return result != null ? result.ToString() : null; // Default value if not found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching identifier: {ex.Message}");
                return null;
            }
        }


        private void borrowerName_TextChanged(object sender, EventArgs e)
        {
            string identifier = GetIdentifierFromDatabase();

        }

        private void borrowDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dueDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void activateFetching()
        {
            try
            {
                // Clear existing columns in the DataGridView
                borrowDG.Columns.Clear();

                // Fetch borrowing information from the database
                List<Borrowing> borrowings = GetBorrowingsFromDatabase();

                // Add columns to the DataGridView
                borrowDG.Columns.Add("BookTitle", "BOOK TITLE");
                borrowDG.Columns.Add("BorrowerName", "BORROWER'S NAME");
                borrowDG.Columns.Add("BorrowDate", "BORROW DATE");
                borrowDG.Columns.Add("DueDate", "DUE DATE");

                // Set font size and apply modern style
                borrowDG.DefaultCellStyle.Font = new Font("Segoe UI", 8); // Adjust font and size
                borrowDG.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 10, FontStyle.Regular); // Adjust font, size, and style
                borrowDG.EnableHeadersVisualStyles = false;
                borrowDG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38); // Header background color
                borrowDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Header text color

                // Set column widths
                borrowDG.Columns["BookTitle"].Width = 180; // Adjust width as needed
                borrowDG.Columns["BorrowerName"].Width = 170; // Adjust width as needed
                borrowDG.Columns["BorrowDate"].Width = 110; // Adjust width as needed
                borrowDG.Columns["DueDate"].Width = 110; // Adjust width as needed

                // Disable user resizing of rows and columns
                borrowDG.AllowUserToResizeRows = false;
                borrowDG.AllowUserToResizeColumns = false;

                // Disable row headers resizing and visibility
                borrowDG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Bind the list to the DataGridView
                foreach (Borrowing borrowing in borrowings)
                {
                    int rowIndex = borrowDG.Rows.Add();
                    borrowDG.Rows[rowIndex].Cells["BookTitle"].Value = borrowing.BookTitle;
                    borrowDG.Rows[rowIndex].Cells["BorrowerName"].Value = GetBorrowerNameFromDatabase(borrowing.UserId);
                    borrowDG.Rows[rowIndex].Cells["BorrowDate"].Value = borrowing.BorrowDate.ToString("MM/dd/yyyy");
                    borrowDG.Rows[rowIndex].Cells["DueDate"].Value = borrowing.DueDate.ToString("MM/dd/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void borrowedBtn_Click(object sender, EventArgs e)
        {
            activateFetching();
        }

        private List<Borrowing> GetBorrowingsFromDatabase()
        {
            List<Borrowing> borrowings = new List<Borrowing>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT borrowing_id, book_title, user_id, borrow_date, due_date FROM borrowings";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int borrowingId = reader.GetInt32("borrowing_id");
                            string bookTitle = reader.GetString("book_title");
                            int userId = reader.GetInt32("user_id");
                            DateTime borrowDate = reader.GetDateTime("borrow_date");
                            DateTime dueDate = reader.GetDateTime("due_date");

                            borrowings.Add(new Borrowing { BorrowingId = borrowingId, BookTitle = bookTitle, UserId = userId, BorrowDate = borrowDate, DueDate = dueDate });
                        }
                    }
                }
            }

            return borrowings;
        }


        private string GetBorrowerNameFromDatabase(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name FROM borrowers WHERE user_id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null; // Default value if not found
                }
            }
        }
        private bool CanBorrowerBorrow(int borrowerId)
        {
            // Fetch the number of books already borrowed by the borrower
            int borrowedBooksCount = CountBorrowedBooks(borrowerId);

            // Check if the borrower is a teacher
            bool isTeacher = IsTeacher(borrowerId);

            // Get the maximum reservation limit based on the borrower's borrowing history
            int maxReservationLimit = GetMaxBorrowingLimit(borrowerId, isTeacher);

            // Fetch the number of reservations made by the borrower
            int reservationCount = GetBorrowerReservationCount(borrowerId);

            // Check if the remaining reservation limit is greater than 0
            if (reservationCount < maxReservationLimit)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Borrower has already reached the maximum borrowing limit. Cannot borrow more books.\n\nTeachers can only borrow and reserve a maximum of 5 books.\nStudents can only borrow and reserve a maximum of 2 books.");
                return false;
            }
        }
        private int GetBorrowerReservationCount(int borrowerId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = @borrowerId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private int GetMaxBorrowingLimit(int borrowerId, bool isTeacher)
        {
            // Default maximum borrowing limit
            int defaultMaxBorrowingLimit = isTeacher ? 5 : 2; // Default for students is 2, for teachers is 5

            // Check the number of books already borrowed by the borrower
            int borrowedBooksCount = CountBorrowedBooks(borrowerId);

            // Calculate the adjusted maximum borrowing limit based on the number of borrowed books
            int adjustedMaxBorrowingLimit = isTeacher
                ? Math.Max(0, 5 - borrowedBooksCount)
                : Math.Max(0, 2 - borrowedBooksCount);

            // Return the maximum borrowing limit
            return Math.Min(defaultMaxBorrowingLimit, adjustedMaxBorrowingLimit);
        }

        private bool IsTeacher(int borrowerId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to check if the borrower is a teacher
                string query = "SELECT COUNT(*) FROM borrowers WHERE user_id = @borrowerId AND identifier = 'TEACHER'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void borrowedDatepicker_CloseUp(object sender, EventArgs e)
        {
            
        }

        private void borrowDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
    }
    public class Borrowing
    {
        public int BorrowingId { get; set; }
        public string BookTitle { get; set; }
        public int UserId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
    }
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Availability {  get; set; }   
    }
}