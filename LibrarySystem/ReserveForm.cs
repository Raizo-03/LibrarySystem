using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ReserveForm : Form
    {
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";


        public ReserveForm()
        {
            InitializeComponent();

            // Fetch available books from the database
            List<Book> availableBooks = GetAvailableBooksFromDatabase();

            // Populate your UI with checkboxes for available books
            PopulateBookCheckBoxes(availableBooks);
        }

        private void ReserveForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4

        }
        private void PopulateBookCheckBoxes(List<Book> books)
        {
            int topOffset = 20; // Adjust the initial vertical position as needed

            foreach (var book in books)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = book.Title;
                checkBox.Tag = book.BookId;

                // Adjust the width based on the length of the text
                checkBox.Width = TextRenderer.MeasureText(checkBox.Text, checkBox.Font).Width + 100;
                checkBox.Location = new Point(50, topOffset);
                checkBox.Top = topOffset;
                topOffset += 25; // Adjust the vertical spacing as needed

                // Add the event handler for the CheckedChanged event
                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                Controls.Add(checkBox);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                string bookTitle = checkBox.Text;

                if (checkBox.Checked)
                {
                    // Book is selected, you can perform additional actions if needed
                    int bookId = Convert.ToInt32(checkBox.Tag);
                    MessageBox.Show($"Book '{bookTitle}' (ID: {bookId}) selected.");
                }
            }
        }

        private List<Book> GetAvailableBooksFromDatabase()
        {
            List<Book> availableBooks = new List<Book>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to fetch available books
                string query = "SELECT book_id, title FROM books WHERE availability = 'AVAILABLE'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookId = reader.GetInt32("book_id");
                            string title = reader.GetString("title");

                            availableBooks.Add(new Book { BookId = bookId, Title = title });
                        }
                    }
                }
            }

            return availableBooks;
        }
    }


}
