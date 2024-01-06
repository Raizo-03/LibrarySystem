using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ReturnForm : Form
    {
        //For database connection
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        //Declares new checkbox globally to be used in different methods
        CheckBox checkBox = new CheckBox();

        //Declares new list structure globally for the borrowedbooks
        List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

        public ReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); // Custom background color
            upperlabelTransition.Start();

            // Populate borrowed books checkboxes
            PopulateBookCheckBoxes();

            //Function for the return date when the return date is clicked
            returndatePicker.ValueChanged += dateTimePicker1_ValueChanged;

            //Properties for the datagridview
            borrowDG.RowHeadersVisible = false;
            borrowDG.ReadOnly = true;
            borrowDG.BackgroundColor = Color.FromArgb(255, 253, 247, 228);
            borrowDG.ScrollBars = ScrollBars.Vertical;
            
            //Calls the function for the fetching of the borrowed books
            activateFetching();

            //Calls the function to make the buttons round
            ApplyRoundedButtonStyle(calendarBtn);
        }

        //Method to make the buttons round
        private void ApplyRoundedButtonStyle(Guna2GradientButton button)
        {

            // Set the border radius to make the button rounded
            button.BorderRadius = 12; // Adjust the radius to control the roundness
        }


        //Method that populates the checkboxes with list structure and the method that fetches all the borrowed books from the database
        //Sets the properties of the checkboxes as well
        private void PopulateBookCheckBoxes()
        {
            // Fetch borrowed book data from the database
            borrowedBooks = GetBorrowedBooksFromDatabase();

            int topOffset = 120; // Adjust the initial vertical position to 120

            foreach (var borrowedBook in borrowedBooks)
            {
                checkBox = new CheckBox();
                checkBox.Text = $"{borrowedBook.Book.Title}";
                checkBox.Tag = borrowedBook.Book.BookId;

                // Adjust the width based on the length of the text
                checkBox.Width = TextRenderer.MeasureText(checkBox.Text, checkBox.Font).Width + 250;
                checkBox.Location = new Point(609, topOffset); // Set the location with the adjusted topOffset
                topOffset += 25; // Adjust the vertical spacing as needed
                checkBox.Font = new Font("Bookman Old Style", 13); // Set the font

                // Add the event handler for the CheckedChanged event
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                Controls.Add(checkBox);
            }
        }

        //Declares a list structure for the selected books title in the checkboxes
        private List<string> selectedBookTitles = new List<string>();


        //Method for the checkboxes when the user click a checkboxes, it will add it on the selectedbooktitle list structure
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

                    // Show borrower's name, due date, and set book title
                    DisplayBorrowedBookInfo(bookTitle);
                }
                else if (!checkBox.Checked && selectedBookTitles.Contains(bookTitle))
                {
                    // Checkbox is unchecked and in the list, remove it
                    selectedBookTitles.Remove(bookTitle);

                    // Clear borrower's name, due date, and book title when checkbox is unchecked
                    ClearBorrowedBookInfo();
                }
            }
        }

        //Method that displays the borrowed book info using the lables for: borrower name, book title, and due date 
        private void DisplayBorrowedBookInfo(string bookTitle)
        {
            // Find the corresponding BorrowedBook
            var borrowedBook = borrowedBooks.Find(b => b.Book.Title == bookTitle);

            if (borrowedBook != null)
            {
                // Display borrower's name and due date
                bName.Text = $"{borrowedBook.BorrowerName}";
                dueDateLabel.Text = $"{borrowedBook.DueDate.ToShortDateString()}";
                titleLabel.Text = $"{bookTitle}";
            }
        }

        //Method that clears the labels when the checkboxes are not clicked
        private void ClearBorrowedBookInfo()
        {
            // Clear borrower's name and due date
            bName.Text = string.Empty;
            titleLabel.Text = string.Empty;

        }


        private void DisplayBorrowerName(string bookTitle)
        {
            // Find the corresponding BorrowedBook
            var borrowedBook = borrowedBooks.Find(b => b.Book.Title == bookTitle);

            if (borrowedBook != null)
            {
                // Display borrower's name
                bName.Text = $"{borrowedBook.BorrowerName}";
            }
        }

        private void ClearBorrowerName()
        {
            // Clear borrower's name
            base.Text = string.Empty;
        }

        //Class for borrowedbooks with getters and setters
        private class BorrowedBook
        {

            public Book Book { get; set; }
            public string BorrowerName { get; set; }
            public DateTime DueDate { get; set; }

        }

        // Method that fetches borrowed books from the borrowings table in the database infos include: book id, book title, user id, and due date
        private List<BorrowedBook> GetBorrowedBooksFromDatabase()
        {
            List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Modify the SQL query to fetch both book information, borrower name, and due date
                string query = "SELECT B.book_id, B.title, Br.user_id, Br.due_date " +
                                "FROM books B " +
                                "JOIN borrowings Br ON B.title = Br.book_title " +
                                "WHERE B.availability = 'BORROWED'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookId = reader.GetInt32("book_id");
                            string title = reader.GetString("title");
                            int userId = reader.GetInt32("user_id");
                            DateTime dueDate = reader.GetDateTime("due_date");

                            // Fetch the borrower's name based on the user_id
                            string borrowerName = GetBorrowerName(userId);

                            borrowedBooks.Add(new BorrowedBook
                            {
                                Book = new Book { BookId = bookId, Title = title },
                                BorrowerName = borrowerName,
                                DueDate = dueDate
                            });
                        }
                    }
                }
            }

            return borrowedBooks;
        }


        //Method that fetches the borrower name from the database using their userID and returns it as a string value
        private string GetBorrowerName(int userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT name FROM borrowers WHERE user_id = @userId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    var result = command.ExecuteScalar();
                    return result != null ? result.ToString() : "Unknown Borrower"; // Default value if not found
                }
            }
        }

        //Method that shows the return date when the datetimepicker is clicked
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            returndateTb.Text = returndatePicker.Value.ToString("MM/dd/yyyy");

        }

        //Method that calculates the penalty depending on the returndate from the returndate textbox
        private void CalculatePenalty()
        {
            if (dueDateLabel.Text != string.Empty && returndateTb.Text != string.Empty)
            {
                DateTime dueDate = DateTime.Parse(dueDateLabel.Text);
                DateTime returnedDate = returndatePicker.Value;

                // Check if the due date and the returned date are aligned
                if (dueDate == returnedDate)
                {
                    // No penalty for aligned dates
                    MessageBox.Show("Returned on time. No penalty applied.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Calculate the difference in days
                int daysDifference = (int)(returnedDate - dueDate).TotalDays;

                if (daysDifference > 0)
                {
                    decimal penaltyAmount = daysDifference * 20.0m; // 20 pesos per day
                    int borrowerId = GetBorrowerId(titleLabel.Text);

                    // Insert the penalty into the penalties table
                    InsertPenalty(borrowerId, penaltyAmount);
                }
            }
        }

        //Method the fetches the penalty amount from the penalties table according to the borrower id, and penalty amount
        private void InsertPenalty(int borrowerId, decimal penaltyAmount)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO penalties (borrower_id, amount, paid) VALUES (@borrowerId, @penaltyAmount, 0)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);
                    command.Parameters.AddWithValue("@penaltyAmount", penaltyAmount);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Method the fetches the borrower id using the booktitle and returns an int value
        private int GetBorrowerId(string bookTitle)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Br.user_id " +
                               "FROM borrowings Br " +
                               "JOIN books B ON B.title = Br.book_title " +
                               "WHERE B.title = @bookTitle";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookTitle", bookTitle);

                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1; // Default value if not found
                }
            }
        }

        //Method for the return button
        private void returnBtn_Click(object sender, EventArgs e)
        {
            //Validates if the user really wants to return the book
            DialogResult result = MessageBox.Show("Are you sure you want to continue with the returning process?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check user's choice
            if (result == DialogResult.No)
            {
                // User chose not to continue, so return without executing the borrowing process
                return;
            }

            // Check if the returndateTb textbox is empty
            if (string.IsNullOrWhiteSpace(returndateTb.Text))
            {
                MessageBox.Show("Input Necessary Details. Please enter the return date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing if the textbox is empty
            }

            // Calculate penalty before returning
            CalculatePenalty();

            // Check if there is a penalty
            bool hasPenalty = CheckPenalty();

            // Update book availability to "AVAILABLE" and remove from borrowings
            if (selectedBookTitles.Count > 0)
            {
                foreach (var bookTitle in selectedBookTitles)
                {
                    // Update book availability to "Available"
                    UpdateBookAvailability(bookTitle, "Available");

                    // Remove entry from borrowings table
                    RemoveFromBorrowings(bookTitle);
                }

                string successMessage = "Book(s) returned successfully. Availability updated.";
                if (hasPenalty)
                {
                    successMessage += "\nPlease note that there is a penalty for the returned book(s).";
                }

                MessageBox.Show(successMessage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear selected book titles
                selectedBookTitles.Clear();

                // Clear borrower's information
                ClearBorrowedBookInfo();
                // Close the current form and open the Dashboard form
                Form mdiParent = this.MdiParent;
                if (mdiParent != null)
                {
                    mdiParent.Close();
                }
                string identifier = " ";
                string name = "ADMIN 1";
                string id = " ";
                int limit = 0;
                Dashboard dashboardForm = new Dashboard(identifier, name, id, limit);
                dashboardForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select at least one book to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Check if there is a penalty for the selected book titles
        private bool CheckPenalty()
        {
            foreach (var bookTitle in selectedBookTitles)
            {
                int borrowerId = GetBorrowerId(bookTitle);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM penalties WHERE borrower_id = @borrowerId AND paid = 0";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@borrowerId", borrowerId);

                        int penaltyCount = Convert.ToInt32(command.ExecuteScalar());

                        if (penaltyCount > 0)
                        {
                            return true; // There is an unpaid penalty
                        }
                    }
                }
            }

            return false; // No penalty found
        }

        //Method the updates the availability of the book whenever the book is return succesfully
        private void UpdateBookAvailability(string bookTitle, string availability)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE books SET availability = @availability WHERE title = @bookTitle";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@availability", availability);
                    command.Parameters.AddWithValue("@bookTitle", bookTitle);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Method that removes the entire row of the borrower if succesfully returned the book
        private void RemoveFromBorrowings(string bookTitle)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM borrowings WHERE book_title = @bookTitle";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookTitle", bookTitle);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Method for the borrow button that calls the method for fetching the borrowed books in the borrowings table from the database
        private void borrowedBtn_Click(object sender, EventArgs e)
        {
            activateFetching();
        }

        //Method that fetches the borrowed books from the borrowings info; infos include: book title, borrower name, borrow date, and due date
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

        //Method that fetches the borrowings from the database and stores it in a list structure
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

        //Method that fetches the borrower name from the database using their user id and returns a string value
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
    }
}
