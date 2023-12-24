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
        Label borrowerLabel = new Label(); // Add Label for displaying borrower's name

        public ReturnForm()
        {
            InitializeComponent();
        }

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); // Custom background color

            // Populate borrowed books checkboxes
            PopulateBookCheckBoxes();

          
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

                    // Show borrower's name
                    DisplayBorrowerName(bookTitle);
                }
                else if (!checkBox.Checked && selectedBookTitles.Contains(bookTitle))
                {
                    // Checkbox is unchecked and in the list, remove it
                    selectedBookTitles.Remove(bookTitle);

                    // Clear borrower's name when checkbox is unchecked
                    ClearBorrowerName();
                }
            }
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
            borrowerLabel.Text = string.Empty;
        }

        private class BorrowedBook
        {
            public Book Book { get; set; }
            public string BorrowerName { get; set; }
        }

        // Gets borrowed books from the database
        private List<BorrowedBook> GetBorrowedBooksFromDatabase()
        {
            List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Modify the SQL query to fetch both book information and borrower name
                string query = "SELECT B.book_id, B.title, Br.user_id " +
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

                            // Fetch the borrower's name based on the user_id
                            string borrowerName = GetBorrowerName(userId);

                            borrowedBooks.Add(new BorrowedBook
                            {
                                Book = new Book { BookId = bookId, Title = title },
                                BorrowerName = borrowerName
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
    }
}
