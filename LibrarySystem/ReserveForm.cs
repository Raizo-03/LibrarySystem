using Guna.UI2.WinForms;
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
        //FOR DATABASE CONNECTION
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        public ReserveForm()
        {
            InitializeComponent();

            // Fetch available books from the database
            List<Book> availableBooks = GetAvailableBooksFromDatabase();

            // Populate your UI with checkboxes for available books
            PopulateBookCheckBoxes(availableBooks);

            //Sets the properties for the datagridview
            reservedbooksDG.Visible = true;
            reservedbooksDG.ReadOnly = true;
            reservedbooksDG.CellClick += reservedbooksDG_CellContentClick;
            reservedbooksDG.ReadOnly = true;
            reservedbooksDG.BackgroundColor = Color.FromArgb(255, 253, 247, 228);
            reservedbooksDG.ScrollBars = ScrollBars.Vertical;


            //Calls the method to make the button round
            ApplyRoundedButtonStyle(calendarBtn);

            //Calls the method to fetch the reservation and bind it to the datagridview
            FetchReservationsAndBindDataGridView();
        }


        //Method the makes the button round
        private void ApplyRoundedButtonStyle(Guna2GradientButton button)
        {

            // Set the border radius to make the button rounded
            button.BorderRadius = 12; // Adjust the radius to control the roundness

        }

        //Method that fetches the user if it has unpaid penalies using their borrower id and returns as boolean value
        private bool HasUnpaidPenalties(int borrowerId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to check if the borrower has unpaid penalties
                string query = "SELECT COUNT(*) FROM penalties WHERE borrower_id = @borrowerId AND paid = 0";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);

                    int unpaidPenaltiesCount = Convert.ToInt32(command.ExecuteScalar());

                    return unpaidPenaltiesCount > 0;
                }
            }
        }

        //Method the validates if the user can reserve using their borrower id and returns a boolean value 
        //Calls other method such as getting the total borrowed books, checks if the borrower is teacher, max reservation limit, and number of reservation
        private bool CanBorrowerReserve(int borrowerId)
        {
            string borrowerName = GetBorrowerNameFromDatabase(borrowerId);

            // Fetch the number of books already borrowed by the borrower
            int borrowedBooksCount = GetBorrowedBooksCount(borrowerId);

            // Check if the borrower is a teacher
            bool isTeacher = IsTeacher(borrowerId);

            // Get the maximum reservation limit based on the borrower's borrowing history
            int maxReservationLimit = GetMaxReservationLimit(borrowerId, isTeacher);

            // Fetch the number of reservations made by the borrower
            int reservationCount = GetBorrowerReservationCount(borrowerId);

            // Check if the remaining reservation limit is greater than 0
            if (reservationCount < maxReservationLimit)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"Borrower {borrowerName} has already reached the maximum reserving limit. Cannot reserve more books.\n\nTeachers can only borrow and reserve a maximum of 5 books.\nStudents can only borrow and reserve a maximum of 2 books.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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

        //Method that fetches the total number of borrower that have reserve and returns an int value
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

        //Method that fetches the total number of books that have borrowed and returns an int value
        private int GetBorrowedBooksCount(int borrowerId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to count the number of books borrowed by the borrower
                string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = @borrowerId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        //Method for getting the maximum reservation limit and returns an int value
        private int GetMaxReservationLimit(int borrowerId, bool isTeacher, int borrowedBooksCount)
        {
            // Define the reservation limits based on the borrower type (student or teacher)
            int[] studentLimits = { 2, 1, 0 };
            int[] teacherLimits = { 5, 4, 3, 2, 1, 0 };

            // Determine the applicable limits based on the borrower type
            int[] applicableLimits = isTeacher ? teacherLimits : studentLimits;

            // Ensure the borrowedBooksCount is within the valid range
            int adjustedBorrowedBooksCount = Math.Max(0, Math.Min(borrowedBooksCount, applicableLimits.Length - 1));

            // Return the maximum reservation limit based on the borrowedBooksCount
            return applicableLimits[adjustedBorrowedBooksCount];
        }

        //Method the fetches the borrowers that has unpaid penalties in the penalties table from the database
        private List<Borrower> FetchPaidBorrowers()
        {
            List<Borrower> paidBorrowers = new List<Borrower>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to fetch paid borrowers
                string query = "SELECT user_id, name, identifier FROM borrowers WHERE paid = 1";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int borrowerId = reader.GetInt32("user_id");
                            string borrowerName = reader.GetString("name");
                            string identifier = reader.GetString("identifier");
                            int paid = reader.GetInt32("paid");

                            paidBorrowers.Add(new Borrower
                            {
                                BorrowerId = borrowerId,
                                BorrowerName = borrowerName,
                                Identifier = identifier,
                                Paid = paid
                            });
                        }
                    }
                }
            }

            return paidBorrowers;
        }

        private void ReserveForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4
            FetchReservationsAndBindDataGridView();
            upperlabelTransition.Start();


        }

        //Method that populates the checkboxes 
        //Also sets the properties of the checkboxes
        private void PopulateBookCheckBoxes(List<Book> books)
        {
            int topOffset = 120; // Adjust the initial vertical position to 120

            foreach (var book in books)
            {
                // Check if the book genre is "NORMAL"
                if (book.Genre == "NORMAL")
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = book.Title;
                    checkBox.Tag = book.BookId;

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
        }

        //Method that gets the value of the checkbox that was checked by the user
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    // Book is selected, update titleLabel.Text
                    titleLabel.Text = checkBox.Text;

                    // Additional actions if needed
                    int bookId = Convert.ToInt32(checkBox.Tag);
                    MessageBox.Show($"Book '{checkBox.Text}' is selected.");
                }
                else
                {
                    // Book is unchecked, clear titleLabel.Text
                    titleLabel.Text = string.Empty;
                }
            }
        }

        //Method that fetches all the books that has status available and genre normal from the database
        private List<Book> GetAvailableBooksFromDatabase()
        {
            List<Book> availableBooks = new List<Book>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to fetch available books with genre "NORMAL"
                string query = "SELECT book_id, title, genre FROM books WHERE availability = 'AVAILABLE' AND genre = 'NORMAL'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookId = reader.GetInt32("book_id");
                            string title = reader.GetString("title");
                            string genre = reader.GetString("genre");

                            availableBooks.Add(new Book { BookId = bookId, Title = title, Genre = genre });
                        }
                    }
                }
            }

            return availableBooks;
        }

        //Method for the datetimepicker component if the user clicked it
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            reserveddateTb.Text = reservedatepicker.Value.ToString("MM/dd/yyyy");
        }


        //Method that fetches the borrowers reservation count and returns an int value
        private int GetBorrowerReservationCount(int borrowerId, string borrowerIdentifier)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM reservations r " +
                               "INNER JOIN borrowers b ON r.borrower_id = b.user_id " +
                               "WHERE r.borrower_id = @borrowerId AND b.identifier = @borrowerIdentifier";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);
                    command.Parameters.AddWithValue("@borrowerIdentifier", borrowerIdentifier);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private Borrower GetPaidBorrowerByName(string borrowerName)
        {
            List<Borrower> paidBorrowers = FetchPaidBorrowers();

            // Search for the borrower in the list
            return paidBorrowers.FirstOrDefault(b => b.BorrowerName == borrowerName);
        }

        //Method for the reserve button
        private void reserveBtn_Click(object sender, EventArgs e)
        {
            //Validates if the user really wants to reserve the book
            DialogResult result = MessageBox.Show("Are you sure you want to continue with the reserving process?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the returndateTb textbox is empty
            if (string.IsNullOrWhiteSpace(reserveddateTb.Text))
            {
                MessageBox.Show("Input Necessary Details. Please enter the return date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further processing if the textbox is empty
            }

            // Check user's choice
            if (result == DialogResult.No)
            {
                // User chose not to continue, so return without executing the borrowing process
                return;
            }

            // Check if a book is selected
            if (!string.IsNullOrEmpty(titleLabel.Text))
            {
                // Get book information
                int bookId = GetBookIdByTitle(titleLabel.Text);

                // Check if a borrower is entered
                if (!string.IsNullOrEmpty(borrowernameTb.Text))
                {
                    // Get borrower information
                    string borrowerName = borrowernameTb.Text;

                    // Check if the borrower has unpaid penalties
                    int borrowerId = GetBorrowerIdByName(borrowerName);

                    if (borrowerId != -1 && !HasUnpaidPenalties(borrowerId))
                    {
                        // Continue with the reservation process

                        // Get borrower information
                        Borrower borrower = GetBorrowerByName(borrowerName);

                        if (borrower != null)
                        {
                            // Check if the borrower can reserve based on penalties and borrowed books
                            if (CanBorrowerReserve(borrower.BorrowerId))
                            {
                                // Check the maximum reservation limit based on the borrower's identifier
                                int maxReservationLimit = GetMaxReservationLimit(borrower.Identifier);

                                // Check if the borrower has exceeded the reservation limit
                                if (GetBorrowerReservationCount(borrower.BorrowerId, borrower.Identifier) < maxReservationLimit)
                                {
                                    // Get reservation date
                                    DateTime reservationDate = reservedatepicker.Value;

                                    // Insert reservation into the reservations table
                                    InsertReservation(bookId, borrower.BorrowerId, reservationDate);

                                    // Update book availability to "RESERVED"
                                    UpdateBookAvailability(bookId, "RESERVED");

                                    // Display success message
                                    MessageBox.Show("Reservation successful!");

                                    // Clear selected book and borrower
                                    titleLabel.Text = string.Empty;
                                    borrowernameTb.Text = string.Empty;

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
                                    MessageBox.Show($"Sorry! You have exceeded the number of books to be reserve. The borrower '{borrowerName}' has reached the maximum reservation limit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                            }
                        }
                        else
                        {
                            MessageBox.Show("Borrower not found. Reservation not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Borrower has unpaid penalties or not found. Reservation not allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Input Necessary Details. Please enter a borrower name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Input Necessary Details. Please select a book.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Method that fetches the borrower id using their borrower name and returns it as an int value
        private int GetBorrowerIdByName(string borrowerName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT user_id FROM borrowers WHERE name = @borrowerName";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerName", borrowerName);

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        //Method that sets the maximum reservation limit and returns the value of int of teacher
        private int GetMaxReservationLimit(int borrowerId, bool isTeacher)
        {
            // Default maximum reservation limit
            int defaultMaxReservationLimit = isTeacher ? 5 : 2; // Default for students is 2, for teachers is 5

            // Check the number of books already borrowed by the borrower
            int borrowedBooksCount = GetBorrowedBooksCount(borrowerId);

            // Calculate the adjusted maximum reservation limit based on the number of borrowed books
            int adjustedMaxReservationLimit = isTeacher
                ? Math.Max(0, 5 - borrowedBooksCount)
                : Math.Max(0, 2 - borrowedBooksCount);

            // Return the maximum reservation limit
            return Math.Min(defaultMaxReservationLimit, adjustedMaxReservationLimit);
        }

        //Method that sets the maximum reservation limit using the identifier of the borrower
        private int GetMaxReservationLimit(string identifier)
        {
            // Default maximum reservation limit
            int defaultMaxReservationLimit = 2; // Default for students

            // Check if the borrower is a teacher
            bool isTeacher = identifier.Contains("TEACHER");

            // If the borrower is a teacher, set the maximum reservation limit to 5
            if (isTeacher)
            {
                defaultMaxReservationLimit = 5;
            }

            return defaultMaxReservationLimit;
        }

        //Method that fetches the book id using their book title and returns an int value
        private int GetBookIdByTitle(string title)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT book_id FROM books WHERE title = @title";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@title", title);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        //Method that inserts the column if the reservation is succesful
        private void InsertReservation(int bookId, int borrowerId, DateTime reservationDate)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO reservations (book_id, borrower_id, reservation_date) " +
                               "VALUES (@bookId, @borrowerId, @reservationDate)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookId", bookId);
                    command.Parameters.AddWithValue("@borrowerId", borrowerId);
                    command.Parameters.AddWithValue("@reservationDate", reservationDate);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Method that fetches the borrower by its name 
        private Borrower GetBorrowerByName(string borrowerName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT user_id, identifier FROM borrowers WHERE name = @borrowerName";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@borrowerName", borrowerName);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int borrowerId = reader.GetInt32("user_id");
                            string identifier = reader.GetString("identifier");

                            return new Borrower
                            {
                                BorrowerId = borrowerId,
                                BorrowerName = borrowerName,
                                Identifier = identifier
                            };
                        }
                    }
                }

                return null;
            }
        }

        //Method that updates the status of the whenever the reservation is succesful, the book chosen'status is set to RESERVE
        private void UpdateBookAvailability(int bookId, string availability)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE books SET availability = @availability WHERE book_id = @bookId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@availability", availability);
                    command.Parameters.AddWithValue("@bookId", bookId);

                    command.ExecuteNonQuery();
                }
            }
        }

        //Method that fetches the reserve books from the reservations table
        private void rbooksBtn_Click(object sender, EventArgs e)
        {
            reservedbooksDG.Visible = true;
            FetchReservationsAndBindDataGridView();
        }

        //Method that fetches the reservation and bind it in the datagridview
        //Also sets the properties of the datagridview
        private void FetchReservationsAndBindDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch reservations with borrower's name and book title
                    string query = "SELECT r.reservation_id, bk.title AS book_title, b.name AS borrower_name, r.reservation_date " +
                                   "FROM reservations r " +
                                   "INNER JOIN borrowers b ON r.borrower_id = b.user_id " +
                                   "INNER JOIN books bk ON r.book_id = bk.book_id";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable reservationsDataTable = new DataTable();
                            adapter.Fill(reservationsDataTable);

                            // Bind the DataTable to the DataGridView
                            reservedbooksDG.DataSource = reservationsDataTable;
                            // Set font size and apply modern style
                            reservedbooksDG.DefaultCellStyle.Font = new Font("Bookman Old Style", 10); // Adjust font and size
                            reservedbooksDG.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 10, FontStyle.Bold); // Adjust font, size, and style
                            reservedbooksDG.EnableHeadersVisualStyles = false;
                            reservedbooksDG.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate; // Header background color
                            reservedbooksDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Header text color

                            // Disable user resizing of rows and columns
                            reservedbooksDG.AllowUserToResizeRows = false;
                            reservedbooksDG.AllowUserToResizeColumns = false;

                            // Disable row headers resizing and visibility
                            reservedbooksDG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                            // Set column widths
                            reservedbooksDG.Columns["reservation_id"].Width = 80; // Adjust width as needed
                            reservedbooksDG.Columns["book_title"].Width = 180; // Adjust width as needed
                            reservedbooksDG.Columns["borrower_name"].Width = 150; // Adjust width as needed
                            reservedbooksDG.Columns["reservation_date"].Width = 120; // Adjust width as needed

                            // Set column headers
                            reservedbooksDG.Columns["reservation_id"].HeaderText = "ID";
                            reservedbooksDG.Columns["book_title"].HeaderText = "Title";
                            reservedbooksDG.Columns["borrower_name"].HeaderText = "Borrower Name";
                            reservedbooksDG.Columns["reservation_date"].HeaderText = "Reservation Date";


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching reservations: {ex.Message}");
            }
        }


        //Method for the managebutton if the user wants to delete the reservation
        // Calls the transition method to start
        private void editBtn_Click(object sender, EventArgs e)
        {
            manageTransition.Start();
        }

        //Method that deletes the row of the reservation whenever the button is clicked
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            // Check if any row is selected in the DataGridView
            if (reservedbooksDG.SelectedRows.Count > 0)
            {
                // Get the selected reservation_id
                int reservationId = Convert.ToInt32(reservedbooksDG.SelectedRows[0].Cells["reservation_id"].Value);

                // Ask for confirmation before deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the reservation from the DataGridView
                    DeleteReservationFromDataGridView(reservationId);

                    // Delete the reservation from the database
                    DeleteReservationFromDatabase(reservationId);

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
            }
            else
            {
                MessageBox.Show("Input Necessary Details. Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Method that delete the reservation from the datagridview
        private void DeleteReservationFromDataGridView(int reservationId)
        {
            // Find the row with the specified reservation_id
            DataGridViewRow rowToDelete = null;

            foreach (DataGridViewRow row in reservedbooksDG.Rows)
            {
                if (Convert.ToInt32(row.Cells["reservation_id"].Value) == reservationId)
                {
                    rowToDelete = row;
                    break;
                }
            }

            // Remove the row from the DataGridView
            if (rowToDelete != null)
            {
                reservedbooksDG.Rows.Remove(rowToDelete);
            }
        }

        //Method that delete the reservation from the database
        private void DeleteReservationFromDatabase(int reservationId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Get book_id from the reservation
                    int bookId = GetBookIdFromReservation(reservationId);

                    // Query to update book availability to "Available"
                    string updateBookAvailabilityQuery = "UPDATE books SET availability = 'Available' WHERE book_id = @bookId";

                    using (MySqlCommand updateBookAvailabilityCommand = new MySqlCommand(updateBookAvailabilityQuery, connection))
                    {
                        updateBookAvailabilityCommand.Parameters.AddWithValue("@bookId", bookId);
                        updateBookAvailabilityCommand.ExecuteNonQuery();
                    }

                    // Query to delete the reservation from the database
                    string deleteReservationQuery = "DELETE FROM reservations WHERE reservation_id = @reservationId";

                    using (MySqlCommand command = new MySqlCommand(deleteReservationQuery, connection))
                    {
                        command.Parameters.AddWithValue("@reservationId", reservationId);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Reservation deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting reservation: {ex.Message}");
            }
        }

        //Method that fetches the book id from the reservation using the reservation ID and returns an int value
        private int GetBookIdFromReservation(int reservationId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Query to get book_id from the reservation
                string query = "SELECT book_id FROM reservations WHERE reservation_id = @reservationId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@reservationId", reservationId);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        //Method that shows the messagebox when a cell of the datagridview is clicked
        private void reservedbooksDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if a valid row index and column index are clicked
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = reservedbooksDG.Rows[e.RowIndex];

                    // Get the values from the selected row
                    string reservationId = selectedRow.Cells["reservation_id"].Value.ToString();
                    string bookTitle = selectedRow.Cells["book_title"].Value.ToString();
                    string borrowerName = selectedRow.Cells["borrower_name"].Value.ToString();
                    string reservationDate = ((DateTime)selectedRow.Cells["reservation_date"].Value).ToString("MM/dd/yyyy");



                    MessageBox.Show(
                        $"Reservation ID: {reservationId}\nBook Title: {bookTitle}\nBorrower Name: {borrowerName}\nReservation Date: {reservationDate:MM/dd/yyyy}",
                        "Reservation Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }catch(Exception ex) {
                MessageBox.Show($"Error! Row must have a reservation in order to edit it : {ex.Message}" );
            }
        }

        //Manage button transition for expanding and collapsing
        bool manageCurtain = false;
        private void manageTransition_Tick(object sender, EventArgs e)
        {
            const int targetExpandedHeight = 107;
            const int targetCollapsedHeight = 62;
            const int step = 45;

            if (!manageCurtain)
            {
                // Expanding
                manageFlowPanel.Height += step;
                if (manageFlowPanel.Height >= targetExpandedHeight)
                {
                    manageFlowPanel.Height = targetExpandedHeight;
                    manageTransition.Stop();
                    manageCurtain = true;
                }
            }
            else
            {
                // Collapsing
                manageFlowPanel.Height -= step;
                if (manageFlowPanel.Height <= targetCollapsedHeight)
                {
                    manageFlowPanel.Height = targetCollapsedHeight;
                    manageTransition.Stop();
                    manageCurtain = false;
                }
            }
        }
        //Method that checks if the borrower is a teacher using the borrower id and returns a boolean value
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

        //Method that gets the maximum reservation limit using the borrower id and returns an int value
        private int GetMaxReservationLimit(int borrowerId)
        {
            // Default maximum reservation limit
            int defaultMaxReservationLimit = 2; // Default for students

            // Check if the borrower is a teacher
            bool isTeacher = IsTeacher(borrowerId);

            // If the borrower is a teacher, set the maximum reservation limit to 5
            if (isTeacher)
            {
                defaultMaxReservationLimit = 5;
            }

            return defaultMaxReservationLimit;
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
    //Class borrower for the list structure and their getters and setters
    public class Borrower
    {
        public int BorrowerId { get; set; }
        public string BorrowerName { get; set; }
        public string Identifier { get; set; }
        public int Id { get; set; }
        public int Paid { get; set; }
    }

}
