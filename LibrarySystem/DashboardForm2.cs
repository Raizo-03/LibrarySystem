using Guna.UI2.WinForms;
using LiveCharts.Wpf;
using LiveCharts;
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
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.Integration;



namespace LibrarySystem
{
    public partial class DashboardForm2 : Form
    {
        private string identifier, name, id;

        //This method is for the database
        //Note: This will change according to the Uid and the Pwd on your XAMPP configuration
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        public DashboardForm2(string Identifier, string Name, string Id)
        {
            InitializeComponent();
            this.identifier = Identifier;
            this.Name = Name;
            this.id = Id;

            //Calls the function to make the buttons round
            ApplyRoundedButtonStyle(availbooksPanel);
            ApplyRoundedButtonStyle(borrowedPanel);
            ApplyRoundedButtonStyle(reservedPanel);
            ApplyRoundedButtonStyle(userPanel);
            ApplyRoundedButtonStyle(usersPanel);


            //Added properties to the datagridview of the form
            analyticsDG.ReadOnly = true;
            analyticsDG.AlternatingRowsDefaultCellStyle = null;
            analyticsDG.RowHeadersVisible = false;
            analyticsDG.ScrollBars = ScrollBars.Vertical;

            //This method updates the bargraph chart on the lower part of the form
            UpdateChart();
            
            //This is the default method to fetch the available books on the database to load on the datagridview
            ActivateAvailbooks();

            //This method updates the piechart on the lower right part of the form
            UpdatePieChart();


           
        }

        //This method updates the piechart in the form
        private void UpdatePieChart()
        {
            try
            {
                pieChart1.Series.Clear();
                pieChart1.Text = "Library Analytics";

                //Gets the values of the avail books, borrowings, reservations, and penalties and sets them into vars
                int totalAvailableBooks = GetTotalAvailableBooks();
                int totalBorrowings = GetTotalBorrowings();
                int totalReservations = GetTotalReservations();
                int totalPenalties = GetTotalPenalties();

                //Adds the values on specific parts of the chart
                pieChart1.Series.Add(new PieSeries
                {
                    Title = "Available Books",
                    Values = new ChartValues<double> { totalAvailableBooks },
                    DataLabels = true
                });

                pieChart1.Series.Add(new PieSeries
                {
                    Title = "Borrowings",
                    Values = new ChartValues<double> { totalBorrowings },
                    DataLabels = true
                });

                pieChart1.Series.Add(new PieSeries
                {
                    Title = "Reservations",
                    Values = new ChartValues<double> { totalReservations },
                    DataLabels = true
                });

                pieChart1.Series.Add(new PieSeries
                {
                    Title = "Penalties",
                    Values = new ChartValues<double> { totalPenalties },
                    DataLabels = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating PieChart: {ex.Message}", "PieChart Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method updates the bar graph
        private void UpdateChart()
        {
            try
            {
                // Clear existing series data
                cartesianChart1.Series = new LiveCharts.SeriesCollection();
                cartesianChart1.Text = "Library Analytics";

                // Fetch updated information
                int totalAvailableBooks = GetTotalAvailableBooks();
                int totalBorrowings = GetTotalBorrowings();
                int totalReservations = GetTotalReservations();
                int totalPenalties = GetTotalPenalties();

                // Create series and add data
                cartesianChart1.Series.Add(new RowSeries
                {
                    Title = "Available Books",
                    Values = new ChartValues<double> { totalAvailableBooks },
                    DataLabels = true
                });

                cartesianChart1.Series.Add(new RowSeries
                {
                    Title = "Borrowings",
                    Values = new ChartValues<double> { totalBorrowings },
                    DataLabels = true
                });

                cartesianChart1.Series.Add(new RowSeries
                {
                    Title = "Reservations",
                    Values = new ChartValues<double> { totalReservations },
                    DataLabels = true
                });

                cartesianChart1.Series.Add(new RowSeries
                {
                    Title = "Penalties",
                    Values = new ChartValues<double> { totalPenalties },
                    DataLabels = true
                });

                // Ensure the chart is redrawn
                cartesianChart1.Update(true, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating chart: {ex.Message}", "Chart Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method is used to make the buttons round
        private void ApplyRoundedButtonStyle(Guna2GradientPanel panel)
        {

            // Set the border radius to make the button rounded
            panel.BorderRadius = 12; // Adjust the radius to control the roundness
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //This method fetches the books in the database with status "Available" and puts them into a messagebox
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

        //This method is used to fetch all the books in the database that have status "Available" and stores them in a list data structure named Book
        private List<Book> GetAvailableBooks()
        {
            //Calls the list structure
            List<Book> availableBooks = new List<Book>();
            // Record the start time
            DateTime startTime = DateTime.Now;
            try
            {
                //Query for fetching in the database
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

        //Method that calculates fetching of available books
        // Separate method to get the elapsed time in milliseconds
        private double GetElapsedMilliseconds(DateTime startTime)
        {
            // Record the end time
            DateTime endTime = DateTime.Now;

            // Calculate the elapsed time
            TimeSpan elapsedTime = endTime - startTime;

            // Return the elapsed time in milliseconds
            return elapsedTime.TotalMilliseconds;
        }


        //This method calls the list structure that has books with status of available and stores them into the analyticsDG datagridview
        private void ActivateAvailbooks()
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
                analyticsDG.DefaultCellStyle.Font = new Font("Bookman Old Style", 10); // Adjust font and size
                analyticsDG.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 10, FontStyle.Bold); // Adjust font, size, and style
                analyticsDG.EnableHeadersVisualStyles = false;
                analyticsDG.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate; // Header background color
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

        //This method calls the method that fetches the available books when the button is clicked
        private void availbooksB_Click(object sender, EventArgs e)
        {
            ActivateAvailbooks();
            int totalAvailableBooks = GetTotalAvailableBooks();
            availableLabel.Text = totalAvailableBooks.ToString();
        }


        //This method calls the list structure that has books with status of borrowed and stores them into the analyticsDG datagridview

        private void borrowedB_Click(object sender, EventArgs e)
        {
            int totalBorrowings = GetTotalBorrowings();
            borrowinglabel.Text = totalBorrowings.ToString();
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
                analyticsDG.DefaultCellStyle.Font = new Font("Bookman Old Style", 10); // Adjust font and size
                analyticsDG.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 10, FontStyle.Bold); // Adjust font, size, and style
                analyticsDG.EnableHeadersVisualStyles = false;
                analyticsDG.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate; // Header background color
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
            analyticsDG.BackgroundColor = Color.FromArgb(255, 253, 247, 228); // CUSTOM BG COLORS #FDF7E4
            nameLabel.Text = "ADMIN";

            //Calls the method to get the total available books and store it in a variable to be set using a label in the form
            int totalAvailableBooks = GetTotalAvailableBooks();
            availableLabel.Text = $"{totalAvailableBooks}";

            //Calls the method to get the total borrowings and store it in a variable to be set using a label in the form
            int totalBorrowings = GetTotalBorrowings();
            borrowinglabel.Text = $"{totalBorrowings}";

            //Calls the method to get the total reservations and store it in a variable to be set using a label in the form

            int totalReservations = GetTotalReservations();
            reservinglabel.Text = $"{totalReservations}";

            //Calls the method to get the total penalties and store it in a variable to be set using a label in the form

            int totalPenalties = GetTotalPenalties();
            penaltieslabel.Text = $"{totalPenalties}";

        }

        //This method is the function for the reserve button where it uses the list structure that has reserve books and transfer it to the analyticsDG datagridview
        private void reservedB_Click(object sender, EventArgs e)
        {
            int totalReservations = GetTotalReservations();
            reservinglabel.Text = totalReservations.ToString();

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
                analyticsDG.DefaultCellStyle.Font = new Font("Bookman Old Style", 10); // Adjust font and size
                analyticsDG.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 10, FontStyle.Bold); // Adjust font, size, and style
                analyticsDG.EnableHeadersVisualStyles = false;
                analyticsDG.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate; // Header background color
                analyticsDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Header text color

                // Set column widths
                analyticsDG.Columns["BookTitle"].Width = 200; // Adjust width as needed
                analyticsDG.Columns["BorrowerName"].Width = 200; // Adjust width as needed
                analyticsDG.Columns["ReservationDate"].Width = 300; // Adjust width as needed

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

        //This method fetches the total number of borrowings in the database
        private int GetTotalBorrowings()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // ExecuteScalar is used to get a single value from the query result
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching total borrowings: {ex.Message}");
                return 0;
            }
        }

        //This method fetches the total available books from the database
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

        //This method fetches the total reserve books from the database

        private int GetTotalReservations()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // ExecuteScalar is used to get a single value from the query result
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching total reservations: {ex.Message}");
                return 0;
            }
        }

        //This method fetches the total penalties from the database
        private int GetTotalPenalties()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of penalties
                    string query = "SELECT COUNT(*) FROM penalties";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // ExecuteScalar is used to get a single value from the query result
                        return Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching total penalties: {ex.Message}");
                return 0;
            }
        }

        //This method is used for the penalties button to get the penalties from the list structure that contains the penalties and set it to the analyticsDG datagridview
        private void penaltiesB_Click(object sender, EventArgs e)
        {
            int totalPenalties = GetTotalPenalties();
            penaltieslabel.Text = totalPenalties.ToString();

            try
            {
                // Clear existing columns in the DataGridView
                analyticsDG.Columns.Clear();

                // Fetch penalty information from the database
                List<PenaltyInfo> penalties = GetPenaltiesInfo();

                // Add columns to the DataGridView
                analyticsDG.Columns.Add("PenaltyID", "PENALTY ID");
                analyticsDG.Columns.Add("BorrowerName", "BORROWER'S NAME");
                analyticsDG.Columns.Add("Amount", "AMOUNT");

                // Set font size and apply modern style
                analyticsDG.DefaultCellStyle.Font = new Font("Bookman Old Style", 10); // Adjust font and size
                analyticsDG.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 10, FontStyle.Bold); // Adjust font, size, and style
                analyticsDG.EnableHeadersVisualStyles = false;
                analyticsDG.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate; // Header background color
                analyticsDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Header text color

                // Set column widths
                analyticsDG.Columns["PenaltyID"].Width = 200; // Adjust width as needed
                analyticsDG.Columns["BorrowerName"].Width = 300; // Adjust width as needed
                analyticsDG.Columns["Amount"].Width = 200; // Adjust width as needed

                // Disable user resizing of rows and columns
                analyticsDG.AllowUserToResizeRows = false;
                analyticsDG.AllowUserToResizeColumns = false;

                // Disable row headers resizing and visibility
                analyticsDG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Bind the list to the DataGridView
                foreach (PenaltyInfo penalty in penalties)
                {
                    int rowIndex = analyticsDG.Rows.Add();
                    analyticsDG.Rows[rowIndex].Cells["PenaltyID"].Value = penalty.PenaltyID;
                    analyticsDG.Rows[rowIndex].Cells["BorrowerName"].Value = penalty.BorrowerName;
                    analyticsDG.Rows[rowIndex].Cells["Amount"].Value = penalty.Amount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //This method fetches the borrowing info from the borrowing table and stores it in a list structure; infos including: booktitle, borrowerName, borrowDate, dueDate
        //This method also remove the time of the borrowDate and dueDate to reformat it to (mm-dd--YYY)
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

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            StringBuilder messageBuilder = new StringBuilder();

            // Record the start time for fetching available books
            DateTime startTimeAvailableBooks = DateTime.Now;
            List<Book> availableBooks = GetAvailableBooks();
            double millisecondsAvailableBooks = GetElapsedMilliseconds(startTimeAvailableBooks);
            messageBuilder.AppendLine($"Time taken for fetching available books: {millisecondsAvailableBooks} milliseconds");

            // Record the start time for fetching borrowings
            DateTime startTimeBorrowings = DateTime.Now;
            List<BorrowingInfo> borrowings = GetBorrowingsInfo();
            double millisecondsBorrowings = GetElapsedMilliseconds(startTimeBorrowings);
            messageBuilder.AppendLine($"Time taken for fetching borrowings: {millisecondsBorrowings} milliseconds");

            // Record the start time for fetching reservations
            DateTime startTimeReservations = DateTime.Now;
            List<ReservationInfo> reservations = GetReservationsInfo();
            double millisecondsReservations = GetElapsedMilliseconds(startTimeReservations);
            messageBuilder.AppendLine($"Time taken for fetching reservations: {millisecondsReservations} milliseconds");

            // Record the start time for fetching penalties
            DateTime startTimePenalties = DateTime.Now;
            List<PenaltyInfo> penalties = GetPenaltiesInfo();
            double millisecondsPenalties = GetElapsedMilliseconds(startTimePenalties);
            messageBuilder.AppendLine($"Time taken for fetching penalties: {millisecondsPenalties} milliseconds");

            // Display the accumulated information in a single message box
            MessageBox.Show(messageBuilder.ToString(), "Time Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            int totalAvailableBooks = GetTotalAvailableBooks();
            int totalBorrowings = GetTotalBorrowings();
            int totalReservations = GetTotalReservations();
            int totalPenalties = GetTotalPenalties();
            availableLabel.Text = totalAvailableBooks.ToString();
            borrowinglabel.Text = totalBorrowings.ToString();
            reservinglabel.Text = totalReservations.ToString();
            penaltieslabel.Text = totalPenalties.ToString();
            UpdateChart();
            UpdatePieChart();
            ActivateAvailbooks();
        }


        //This method fetches the reservation info from the database; reservations table and store it in a list datastructure: informations such as: bookTitle, borrowerName, reservationDate 
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

        //This method fetches the penalties info from the database; penalties table and store it in a list datastructure: informations such as: penaltyID, borrowerName, amount
        //This method also gets the penalty amount and concatenante it to make it in Peso 

        private List<PenaltyInfo> GetPenaltiesInfo()
        {
            List<PenaltyInfo> penalties = new List<PenaltyInfo>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get penalty information
                    string query = "SELECT penalty_id, borrowers.name AS BorrowerName, CONCAT('₱', penalties.amount) AS Amount " +
                                   "FROM penalties " +
                                   "INNER JOIN borrowers ON penalties.borrower_id = borrowers.user_id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a PenaltyInfo object and populate its properties
                                PenaltyInfo penalty = new PenaltyInfo
                                {
                                    PenaltyID = reader["penalty_id"].ToString(),
                                    BorrowerName = reader["BorrowerName"].ToString(),
                                    Amount = reader["Amount"].ToString()
                                };

                                // Add the penalty information to the list
                                penalties.Add(penalty);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching penalty information: {ex.Message}");
            }

            return penalties;
        }
    }

    //Class for borrowing info as well as their getters and setters to be used in different forms and list structure
    public class BorrowingInfo
    {
        public string BookTitle { get; set; }
        public string BorrowerName { get; set; }
        public string BorrowDate { get; set; }
        public string DueDate { get; set; }
    }
    //Class for reservation info as well as their getters and setters to be used in different forms and list structure

    public class ReservationInfo
    {
        public string BookTitle { get; set; }
        public string BorrowerName { get; set; }
        public string ReservationDate { get; set; }
    }
    //Class for penalty info as well as their getters and setters to be used in different forms and list structure

    public class PenaltyInfo
    {
        public string PenaltyID { get; set; }
        public string BorrowerName { get; set; }
        public string Amount { get; set; }
    }
}