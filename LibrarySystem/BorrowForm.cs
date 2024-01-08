using System;
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

        //FOR DATABASE Connection
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";
        private DateTime currentDate;  // Change to DateTime
        private DateTime futureDate;  // Change to DateTime


        private int selectedBookId; // Class-level variable to store the selected book ID
        private List<int> selectedBookIds = new List<int>();
        private string Booktitle;

        //Declares new checkboxes globally to be used in different method
        CheckBox checkBox = new CheckBox();

        public BorrowForm(String identifier, string username, string id, int booklimit)
        {
            InitializeComponent();
            this.Identifier = identifier;
            this.ID = id;
            this.bookLimit = booklimit;
            this.userNAME = username;

            //BORROWING DATES FOR THE BORROWING DATE TEXBOX
            //This also automatically adds 3 days if the user is STUDENT
            currentDate = DateTime.Now;
            futureDate = currentDate.AddDays(3);

            //Reformant borrowdate to month, day, year and removes time
            borrowDate.Text = currentDate.ToString("MM/dd/yyyy");

            //calls the method that populates the checkboxes
            PopulateBookCheckBoxes();

            //Properties for the datagridview
            borrowDG.ReadOnly = true;
            borrowDG.AlternatingRowsDefaultCellStyle = null;
            borrowDG.RowHeadersVisible = false;
            borrowDG.ScrollBars = ScrollBars.Vertical;

            //Calls the method to load the datagridview with the borrowed books
            activateFetching();
     
            //Calls the method to apply the round button
            ApplyRoundedButtonStyle(calendarBtn);
        }

        //Method used for calculating the time

        private double GetElapsedMilliseconds(DateTime startTime)
        {
            // Record the end time
            DateTime endTime = DateTime.Now;

            // Calculate the elapsed time
            TimeSpan elapsedTime = endTime - startTime;

            // Return the elapsed time in milliseconds
            return elapsedTime.TotalMilliseconds;
        }


        //Method that makes the button round by changing border radius
        private void ApplyRoundedButtonStyle(Guna2GradientButton button)
        {

            // Set the border radius to make the button rounded
            button.BorderRadius = 12; // Adjust the radius to control the roundness
        }

        //Method that fetches the total reserve count of the borrower and returns a value in int 
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

        //Method that is used when the DateTimePicker component is changed, it will automatically sets the borrow date and return date
        private void borrowedDatepicker_ValueChanged(object sender, EventArgs e)
        {
            // Update borrowDate TextBox with the selected date
            borrowDate.Text = borrowedDatepicker.Value.ToString("MM/dd/yyyy");

            // Calculate the future date by adding 3 days to the selected date if the user is STUDENT
            futureDate = borrowedDatepicker.Value.AddDays(3);

            //control structure to set the due date to NO DUE DATE if the user is a TEACHER
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

        private void refreshInfo()
        {
            if (borrowerName.Text.Equals("Krissa Beringuel"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentGirl.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Krissa Beringuel";
                bID.Text = "K12043710";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }else if (borrowerName.Text.Equals("Lans Villena"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Lans Villena";
                bID.Text = "K12043456";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }else if(borrowerName.Text.Equals("Rod Balaoro"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Rod Balaoro";
                bID.Text = "K12042342";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            } else if (borrowerName.Text.Equals("Harvey Hingco"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Harvey Hingco";
                bID.Text = "K12042345";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }else if (borrowerName.Text.Equals("April Faustino"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentGirl.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "April Faustino";
                bID.Text = "K12021321";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }else if (borrowerName.Text.Equals("Rhycell Ortega"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Rhycell Ortega";
                bID.Text = "K12021327";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerName.Text.Equals("Joshua Fernandez"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Joshua Fernandez";
                bID.Text = "K12042469";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerName.Text.Equals("Sean Sicat"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Sean Sicat";
                bID.Text = "K12032131";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerName.Text.Equals("Ricardo Colarina"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Ricardo Colarina";
                bID.Text = "K12042346";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerName.Text.Equals("Asilito Caasi"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Asilito Caasi";
                bID.Text = "K12043567";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }else if (borrowerName.Text.Equals("Jomariss Plan"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/teacherGirl.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Jomariss Plan";
                label4.Text = "Employee ID";
                bID.Text = "K12052345";
                category.Text = "TEACHER";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerName.Text.Equals("Lester Diampoc"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/teacherBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Lester Diampoc";
                label4.Text = "Employee ID";
                bID.Text = "K12052385";
                category.Text = "TEACHER";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerName.Text.Equals("Daniel Dellosa"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/teacherBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Daniel Dellosa";
                label4.Text = "Employee ID";
                bID.Text = "K12048547";
                category.Text = "TEACHER";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else
            {
                profilePic.Visible = false; // Make sure to set the visibility to true
                bnameInfo.Text = "Not Found";
                bID.Text = "Not Found";
                category.Text = "Not Found";

            }

        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4
            borrowDG.BackgroundColor = Color.FromArgb(255, 253, 247, 228);
            upperlabelTransition.Start();

            //Calls the method that fetches the borrowed books
            activateFetching();
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
                checkBox.Font = new Font("Bookman Old Style", 13); // Set the font
           

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


        // GETS THE BOOK TITLE WHEN THE CHECKBOX IS CLICKED
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

        //Method that updates the availability of the book being borrowed to "Borrowed"
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


        //Gets the book availability of the book from the choses books using the booktitle
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

        //GETS THE BOOKS FROM THE DATABASE that has status available and stores it in the list data structure
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

        //This method is used for the borrow button 
        private void borrowBtn_Click(object sender, EventArgs e)
        {

            //Declares librarydataccess
            LibraryDataAccess library = new LibraryDataAccess();

            //Gets the borrower userID and Identifier and sets them into variables
            int borrowerId = GetBorrowerUserId();
            string identifier = GetIdentifierFromDatabase();

            //Validates if the user really wants to borrow
            DialogResult result = MessageBox.Show("Are you sure you want to continue with the borrowing process?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check user's choice
            if (result == DialogResult.No)
            {
                // User chose not to continue, so return without executing the borrowing process
                return;
            }

            string borrowerName = GetBorrowerNameFromDatabase(borrowerId);
            // Check for unpaid penalties; If Yes, the borrowing is not allowed, if No, borrowing proceeds
            if (HasUnpaidPenalties())
            {
                MessageBox.Show($"{borrowerName} have unpaid penalties. Please clear them before borrowing.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
 
            // Check if the borrowerId is valid
            if (borrowerId == -1)
            {
                MessageBox.Show("Invalid Input. Please enter a valid borrower's name.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Limits the user to only borrow one book at a time
            if (selectedBookTitles.Count > 1)
            {
                MessageBox.Show("Cannot borrow multiple books at once. Please select only one book at a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fetch the number of books reserved by the user and sets them into a variable
            int reservedBooksCount = GetReservedBooksCount(borrowerId);

            // Check if the borrower is a student and has already borrowed 2 books
            if (identifier == "STUDENT" && CountBorrowedBooks(borrowerId) + selectedBookTitles.Count + reservedBooksCount> 2)
            {
                MessageBox.Show($"Sorry! {borrowerName} have exceeded the number of books to be borrowed. Students can only borrow up to 2 books.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (identifier == "TEACHER" && CountBorrowedBooks(borrowerId) + selectedBookTitles.Count + reservedBooksCount > 5)
            {
                MessageBox.Show($"Sorry! {borrowerName} have exceeded the number of books to be borrowed. Teachers can only borrow up to 5 books.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if any checkboxes are selected, if users proceed to click the borrow button and no checkbox is clicked, it will show a warning error
            if (selectedBookTitles.Count == 0)
            {
                MessageBox.Show("Invalid Input. Please select at least one book.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

  
            // Check if any selected book is of the "ACADEMIC" genre, shows warning message when the academic books are being borrowed
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
            //Loops to get the selected books from the checkboxes
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
                    MessageBox.Show("Invalid borrow date format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Borrowing successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the list of available books after borrowing
            refreshFunction();
        }

        //Method to fetch if the borrower has unpaid penalties and returns a bool value 
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


        //Method to fetch the genre of the books 
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



        //GETTING USER INFO FROM DATABASE USING THEIR USER ID AND RETURNS IT IN AN INT VALUE
        private int GetBorrowerUserId()
        {
            // Get the borrower's name from your textbox
            string borrowerNames = borrowerName.Text.Trim(); // Replace with your actual textbox name

            // Query the database to get the user ID based on the borrower's name
            int userId = GetUserFromDatabase(borrowerNames);

            // Return the user ID
            return userId;
        }

        //Method the fetches the borrower using variable borrowerName, and returns an int value for the user_id
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

        //Method that fetches the identifier of the user and returns it in a string value
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

        //Method for the borrower Name
        private void borrowerName_TextChanged(object sender, EventArgs e)
        {
            string identifier = GetIdentifierFromDatabase();


            bool hasString = !string.IsNullOrEmpty(borrowerName.Text);

            // Now, 'hasString' will be true if there is a string in the TextBox, otherwise false.

            if (hasString)
            {
                refreshInfo();
            }
            else
            {
                // No string in the TextBox
                profilePic.Visible = false;
                bnameInfo.Text = "";
                bID.Text = "";
                category.Text = "";
            }
        }

        private void borrowDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dueDate_TextChanged(object sender, EventArgs e)
        {

        }

        //Method that fetches the borrowing info from the borrowings table and sets them in the borrowDG datagridview 
        //This method also sets the properties of the datagridview
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
                borrowDG.DefaultCellStyle.Font = new Font("Bookman Old Style", 10); // Adjust font and size
                borrowDG.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 10, FontStyle.Bold); // Adjust font, size, and style
                borrowDG.EnableHeadersVisualStyles = false;
                borrowDG.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate; // Header background color
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

        //Method for the borrow borrowed books button to call the method that fetches the borrowings from the borrowings table
        private void borrowedBtn_Click(object sender, EventArgs e)
        {
            activateFetching();
            refreshFunction();
        }

        //Method that fetches the borrowings from the borrowings table in the database; Informations including; borrowing ID, book title, borrow date, and due date and stores them into a list structure
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

        //Method that fetches the borrower name in the borrowers table using the userID and returns a string value
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

        //Method the calls the method for validate the total borrowed and reserved books using their userID
        private bool CanBorrowerBorrow(int borrowerId)
        {
            // Fetches the name of the borrower
            string borrowerName = GetBorrowerNameFromDatabase(borrowerId);

            // Fetch the number of books already borrowed by the borrower
            int borrowedBooksCount = CountBorrowedBooks(borrowerId);

            // Check if the borrower is a teacher
            bool isTeacher = IsTeacher(borrowerId);

            // Get the maximum borrowing limit based on the borrower's borrowing history
            int maxBorrowingLimit = GetMaxBorrowingLimit(borrowerId, isTeacher);

            // Fetch the number of reservations made by the borrower
            int reservationCount = GetBorrowerReservationCount(borrowerId);

            // Calculate the total number of books including the selected books for borrowing
            int totalBooksCount = borrowedBooksCount + reservationCount;

            MessageBox.Show($"max borrowing limit = {maxBorrowingLimit}, reservation count: {reservationCount}, total books count: {totalBooksCount}");

            // Check if the remaining borrowing limit is greater than or equal to the selected books count
            if (totalBooksCount <= maxBorrowingLimit)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Borrower {borrowerName} has already reached the maximum borrowing limit. Cannot borrow more books.\n\nTeachers can only borrow a maximum of 5 books.\nStudents can only borrow a maximum of 2 books.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        //Method that fetches the total reservation count of the borrower using their borrower_id
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

        //Method that gets the borrowing limit and returns it as an int value
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


        //Method that checks if the user is a teacher using their user ID and returns a boolean value if true or not
        private bool IsTeacher(int borrowerId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to check if the borrower is a teacher
                string query = "SELECT identifier FROM borrowers WHERE user_id = @borrowerId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);

                    var result = command.ExecuteScalar();

                    // Check if the result is not null and equals "TEACHER"
                    return result != null && result.ToString() == "TEACHER";
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
                try
                {
                    // Check if a valid row index and column index are clicked
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        // Get the selected row
                        DataGridViewRow selectedRow = borrowDG.Rows[e.RowIndex];

                        // Use the exact names of columns
                        string bookTitle = Convert.ToString(selectedRow.Cells["BookTitle"].Value);
                        string borrowerName = Convert.ToString(selectedRow.Cells["BorrowerName"].Value);
                        DateTime borrowDate = Convert.ToDateTime(selectedRow.Cells["BorrowDate"].Value);
                        DateTime dueDate = Convert.ToDateTime(selectedRow.Cells["DueDate"].Value);

                        MessageBox.Show(
                            $"Book Title: {bookTitle}\nBorrower Name: {borrowerName}\nBorrow Date: {borrowDate:MM/dd/yyyy}\nDue Date: {dueDate:MM/dd/yyyy}",
                            "Borrowing Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error! {ex.Message}");
                }
        }

        bool upperlabelExpand = false;
        private void upperlabelTransition_Tick(object sender, EventArgs e)
        {
            const int targetExpandedWidth = 247;
            const int step = 60;

            // Expanding
            upperlabelPanel.Width += step;
            if (upperlabelPanel.Width >= targetExpandedWidth)
            {
                upperlabelPanel.Width = targetExpandedWidth;
                upperlabelTransition.Stop();
                upperlabelExpand = true;
            }
        }

        private void timeBtn_Click(object sender, EventArgs e)
        {
            // Record the start time for the entire borrowing process
            DateTime startTimeBorrowingProcess = DateTime.Now;

            // Fetch available books and measure time
            DateTime startTimeAvailableBooks = DateTime.Now;
            List<Book> availableBooks = GetBooksFromDatabase();
            double millisecondsAvailableBooks = GetElapsedMilliseconds(startTimeAvailableBooks);

            // Fetch borrowings and measure time
            DateTime startTimeBorrowings = DateTime.Now;
            List<Borrowing> borrowings = GetBorrowingsFromDatabase();
            double millisecondsBorrowings = GetElapsedMilliseconds(startTimeBorrowings);

            // Display the total time taken for the entire borrowing process
            double millisecondsBorrowingProcess = GetElapsedMilliseconds(startTimeBorrowingProcess);

            // Combine all the information into a single message
            string message = $"Time taken for fetching available books: {millisecondsAvailableBooks} milliseconds\n" +
                             $"Time taken for fetching borrowings: {millisecondsBorrowings} milliseconds\n" +
                             $"Total time taken for the entire borrowing process: {millisecondsBorrowingProcess} milliseconds";

            // Show the combined message in a single message box
            MessageBox.Show(message, "Time Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ClearBookCheckBoxes()
        {
            // Remove existing checkboxes from the form
            foreach (Control control in Controls.OfType<CheckBox>().ToList())
            {
                Controls.Remove(control);
                control.Dispose();
            }
        }

        private void refreshFunction()
        {
            selectedBookTitles.Clear();
            borrowerName.Text = string.Empty;
            borrowDate.Text = string.Empty;
            dueDate.Text = string.Empty;
            ClearBookCheckBoxes();
            PopulateBookCheckBoxes();
            activateFetching();
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            string guidelines =    "Students can both borrow and reserve a maximum of 2 books only.\n" +
                                   "Teachers can both borrow and reserve a maximum of 5 books only.\n" +
                                   "Academic books are only allowed inside the library.\n" +
                                   "Only 1 book/checkbox per borrowing process.";

            MessageBox.Show(guidelines, "Borrowing Guidelines", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    //Class for the borrowing info that is used in the list structures as well as their getters and setters
    public class Borrowing
    {
        public int BorrowingId { get; set; }
        public string BookTitle { get; set; }
        public int UserId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
    }
    //Class for the book info that is used in the list structures as well as their getters and setters

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Availability {  get; set; }   
    }
}