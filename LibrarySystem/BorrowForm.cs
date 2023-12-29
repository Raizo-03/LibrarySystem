using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
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

            borrowerName.Text = userNAME;

        }

        //POPULATE THE CHECKBOXES
        private void PopulateBookCheckBoxes()
        {
            // Fetch book data from the database
            List<Book> books = GetBooksFromDatabase();

            int topOffset = 20; // Adjust the initial vertical position as needed

            foreach (var book in books)
            {
                checkBox = new CheckBox();
                checkBox.Text = book.Title;
                checkBox.Tag = book.BookId;

                // Adjust the width based on the length of the text
                checkBox.Width = TextRenderer.MeasureText(checkBox.Text, checkBox.Font).Width + 100;
                checkBox.Location = new Point(440, 100);
                checkBox.Top = topOffset;
                topOffset += 25; // Adjust the vertical spacing as needed

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

                string query = "SELECT book_id, title FROM books";

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
                            MessageBox.Show("Invalid due date format.");
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

                // Consider only the borrowings where the book has not been returned
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
    }
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Availability {  get; set; }   
    }
}