using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibrarySystem
{
    public partial class DashboardForm2 : Form
    {
        private string identifier, name, id;

        // FOR DATABASE
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        public DashboardForm2(string Identifier, string Name, string Id)
        {
            InitializeComponent();
            this.identifier = Identifier;
            this.Name = Name;
            this.id = Id;

            ApplyRoundedButtonStyle(availbooksPanel);
            ApplyRoundedButtonStyle(borrowedPanel);
            ApplyRoundedButtonStyle(reservedPanel);
            ApplyRoundedButtonStyle(userPanel);

            analyticsDG.ReadOnly = true;
            analyticsDG.AlternatingRowsDefaultCellStyle = null;

        }


        private void ApplyRoundedButtonStyle(Guna2GradientPanel panel)
        {

            // Set the border radius to make the button rounded
            panel.BorderRadius = 12; // Adjust the radius to control the roundness
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void availableLabel_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch available books from the database
                List<Book> availableBooks = GetAvailableBooks();

                // Display debugging information
                MessageBox.Show($"Total available books: {availableBooks.Count}");

                // Bind the list to the GunaDataGridView
                analyticsDG.DataSource = availableBooks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private List<Book> GetAvailableBooks()
        {
            List<Book> availableBooks = new List<Book>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get available books with only 'Title' and 'Availability'
                    string query = "SELECT title, availability FROM books WHERE availability = 'AVAILABLE'";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a Book object and populate its properties
                                Book book = new Book
                                {
                                    Title = reader["title"].ToString(),
                                    Availability = reader["availability"].ToString()
                                };

                                // Add the book to the list
                                availableBooks.Add(book);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching available books: {ex.Message}");
            }

            return availableBooks;
        }


        private void availbooksB_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing columns in the DataGridView
                analyticsDG.Columns.Clear();

                // Fetch available books from the database
                List<Book> availableBooks = GetAvailableBooks();

                // Add columns to the DataGridView
                analyticsDG.Columns.Add("Title", "Title");
                analyticsDG.Columns.Add("Availability", "Availability");

                // Set font size and apply modern style
                analyticsDG.DefaultCellStyle.Font = new Font("Segoe UI", 10); // Adjust font and size
                analyticsDG.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Adjust font, size, and style
                analyticsDG.EnableHeadersVisualStyles = false;
                analyticsDG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38); // Header background color
                analyticsDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Header text color

                // Set column widths
                analyticsDG.Columns["Title"].Width = 350; // Adjust width as needed
                analyticsDG.Columns["Availability"].Width = 350; // Adjust width as needed

                // Disable user resizing of rows and columns
                analyticsDG.AllowUserToResizeRows = false;
                analyticsDG.AllowUserToResizeColumns = false;

        

                // Disable row headers resizing and visibility
                analyticsDG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
               

                // Bind the list to the DataGridView
                foreach (Book book in availableBooks)
                {
                    int rowIndex = analyticsDG.Rows.Add();
                    analyticsDG.Rows[rowIndex].Cells["Title"].Value = book.Title;
                    analyticsDG.Rows[rowIndex].Cells["Availability"].Value = book.Availability;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void borrowedB_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing columns in the DataGridView
                analyticsDG.Columns.Clear();

                // Fetch borrowing information from the database
                List<BorrowingInfo> borrowings = GetBorrowingsInfo();

                // Add columns to the DataGridView
                analyticsDG.Columns.Add("BookTitle", "BOOK TITLE");
                analyticsDG.Columns.Add("BorrowerName", "BORROWER'S NAME");
                analyticsDG.Columns.Add("BorrowDate", "BORROW DATE");
                analyticsDG.Columns.Add("DueDate", "DUE DATE");

                // Set font size and apply modern style
                analyticsDG.DefaultCellStyle.Font = new Font("Segoe UI", 10); // Adjust font and size
                analyticsDG.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Adjust font, size, and style
                analyticsDG.EnableHeadersVisualStyles = false;
                analyticsDG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38); // Header background color
                analyticsDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Header text color

                // Set column widths
                analyticsDG.Columns["BookTitle"].Width = 200; // Adjust width as needed
                analyticsDG.Columns["BorrowerName"].Width = 200; // Adjust width as needed
                analyticsDG.Columns["BorrowDate"].Width = 150; // Adjust width as needed
                analyticsDG.Columns["DueDate"].Width = 150; // Adjust width as needed

                // Disable user resizing of rows and columns
                analyticsDG.AllowUserToResizeRows = false;
                analyticsDG.AllowUserToResizeColumns = false;

                // Disable row headers resizing and visibility
                analyticsDG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Bind the list to the DataGridView
                foreach (BorrowingInfo borrowing in borrowings)
                {
                    int rowIndex = analyticsDG.Rows.Add();
                    analyticsDG.Rows[rowIndex].Cells["BookTitle"].Value = borrowing.BookTitle;
                    analyticsDG.Rows[rowIndex].Cells["BorrowerName"].Value = borrowing.BorrowerName;
                    analyticsDG.Rows[rowIndex].Cells["BorrowDate"].Value = borrowing.BorrowDate;
                    analyticsDG.Rows[rowIndex].Cells["DueDate"].Value = borrowing.DueDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DashboardForm2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); // CUSTOM BG COLORS #FDF7E4
            nameLabel.Text = "ADMIN";

            int totalAvailableBooks = GetTotalAvailableBooks();
            availableLabel.Text = $"{totalAvailableBooks}";

            //FONTS 
            // TITLES
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            //privateFonts.AddFontFile("C://Users//USER//source//repos//LibrarySystem//fonts//titles//playfair-display-font//PlayfairDisplayBold-nRv8g.ttf");

            // Create a Font object
            //Font customFont = new Font(privateFonts.Families[0], 33); // Use the appropriate size

            // Set the label's font
            //nameLabel.Font = customFont;
            //hellolabel.Font = customFont;



        }

        private void reservedB_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing columns in the DataGridView
                analyticsDG.Columns.Clear();

                // Fetch reservation information from the database
                List<ReservationInfo> reservations = GetReservationsInfo();

                // Add columns to the DataGridView
                analyticsDG.Columns.Add("BookTitle", "BOOK TITLE");
                analyticsDG.Columns.Add("BorrowerName", "BORROWER'S NAME");
                analyticsDG.Columns.Add("ReservationDate", "RESERVATION DATE");

                // Set font size and apply modern style
                analyticsDG.DefaultCellStyle.Font = new Font("Segoe UI", 10); // Adjust font and size
                analyticsDG.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Adjust font, size, and style
                analyticsDG.EnableHeadersVisualStyles = false;
                analyticsDG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38); // Header background color
                analyticsDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Header text color

                // Set column widths
                analyticsDG.Columns["BookTitle"].Width = 200; // Adjust width as needed
                analyticsDG.Columns["BorrowerName"].Width = 200; // Adjust width as needed
                analyticsDG.Columns["ReservationDate"].Width = 150; // Adjust width as needed

                // Disable user resizing of rows and columns
                analyticsDG.AllowUserToResizeRows = false;
                analyticsDG.AllowUserToResizeColumns = false;

                // Disable row headers resizing and visibility
                analyticsDG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Bind the list to the DataGridView
                foreach (ReservationInfo reservation in reservations)
                {
                    int rowIndex = analyticsDG.Rows.Add();
                    analyticsDG.Rows[rowIndex].Cells["BookTitle"].Value = reservation.BookTitle;
                    analyticsDG.Rows[rowIndex].Cells["BorrowerName"].Value = reservation.BorrowerName;
                    analyticsDG.Rows[rowIndex].Cells["ReservationDate"].Value = reservation.ReservationDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int GetTotalAvailableBooks()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to get the total number of available books
                string query = "SELECT COUNT(*) FROM books WHERE availability = 'AVAILABLE'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // ExecuteScalar is used to get a single value from the query result
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
        private List<BorrowingInfo> GetBorrowingsInfo()
        {
            List<BorrowingInfo> borrowings = new List<BorrowingInfo>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get borrowing information with DATE_FORMAT to remove time
                    string query = "SELECT borrowings.book_title AS BookTitle, borrowers.name AS BorrowerName, " +
                                   "DATE_FORMAT(borrowings.borrow_date, '%Y-%m-%d') AS BorrowDate, " +
                                   "DATE_FORMAT(borrowings.due_date, '%Y-%m-%d') AS DueDate " +
                                   "FROM borrowings " +
                                   "INNER JOIN borrowers ON borrowings.user_id = borrowers.user_id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a BorrowingInfo object and populate its properties
                                BorrowingInfo borrowing = new BorrowingInfo
                                {
                                    BookTitle = reader["BookTitle"].ToString(),
                                    BorrowerName = reader["BorrowerName"].ToString(),
                                    BorrowDate = reader["BorrowDate"].ToString(),
                                    DueDate = reader["DueDate"].ToString()
                                };

                                // Add the borrowing information to the list
                                borrowings.Add(borrowing);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching borrowing information: {ex.Message}");
            }

            return borrowings;
        }
        private List<ReservationInfo> GetReservationsInfo()
        {
            List<ReservationInfo> reservations = new List<ReservationInfo>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get reservation information with DATE_FORMAT to remove time
                    string query = "SELECT reservations.book_id, books.title AS BookTitle, borrowers.name AS BorrowerName, " +
                                   "DATE_FORMAT(reservations.reservation_date, '%Y-%m-%d') AS ReservationDate " +
                                   "FROM reservations " +
                                   "INNER JOIN books ON reservations.book_id = books.book_id " +
                                   "INNER JOIN borrowers ON reservations.borrower_id = borrowers.user_id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a ReservationInfo object and populate its properties
                                ReservationInfo reservation = new ReservationInfo
                                {
                                    BookTitle = reader["BookTitle"].ToString(),
                                    BorrowerName = reader["BorrowerName"].ToString(),
                                    ReservationDate = reader["ReservationDate"].ToString()
                                };

                                // Add the reservation information to the list
                                reservations.Add(reservation);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching reservation information: {ex.Message}");
            }

            return reservations;
        }
    }
    public class BorrowingInfo
    {
        public string BookTitle { get; set; }
        public string BorrowerName { get; set; }
        public string BorrowDate { get; set; }
        public string DueDate { get; set; }
    }
    public class ReservationInfo
    {
        public string BookTitle { get; set; }
        public string BorrowerName { get; set; }
        public string ReservationDate { get; set; }
    }
}