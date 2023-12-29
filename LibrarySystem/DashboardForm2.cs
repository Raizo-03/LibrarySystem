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
    }
}