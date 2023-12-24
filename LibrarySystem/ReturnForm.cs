using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ReturnForm : Form
    {
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";
        CheckBox checkBox = new CheckBox();
        List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

        public ReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); // Custom background color

            // Populate borrowed books checkboxes
            PopulateBookCheckBoxes();

            returndatePicker.ValueChanged += dateTimePicker1_ValueChanged;


        }

        private void PopulateBookCheckBoxes()
        {
            // Fetch borrowed book data from the database
            borrowedBooks = GetBorrowedBooksFromDatabase();

            int topOffset = 20; // Adjust the initial vertical position as needed

            foreach (var borrowedBook in borrowedBooks)
            {
                checkBox = new CheckBox();
                checkBox.Text = $"{borrowedBook.Book.Title}";
                checkBox.Tag = borrowedBook.Book.BookId;

                // Adjust the width based on the length of the text
                checkBox.Width = TextRenderer.MeasureText(checkBox.Text, checkBox.Font).Width + 100;
                checkBox.Location = new Point(440, 100);
                checkBox.Top = topOffset;
                topOffset += 25; // Adjust the vertical spacing as needed

                // Add the event handler for the CheckedChanged event
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                Controls.Add(checkBox);
            }
        }

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

        private class BorrowedBook
        {

            public Book Book { get; set; }
            public string BorrowerName { get; set; }
            public DateTime DueDate { get; set; }

        }

        // Gets borrowed books from the database
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            returndateTb.Text = returndatePicker.Value.ToString("MM/dd/yyyy");

        }
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

        private void returnBtn_Click(object sender, EventArgs e)
        {
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
                string name = " ";
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
    }
}
