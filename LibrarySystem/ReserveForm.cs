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

        private bool CanBorrowerReserve(int borrowerId)
        {
            // Check if the borrower has unpaid penalties
            if (HasUnpaidPenalties(borrowerId))
            {
                MessageBox.Show("Borrower has unpaid penalties. Cannot reserve a book.");
                return false;
            }

            return true;
        }

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
        }

        private void PopulateBookCheckBoxes(List<Book> books)
        {
            int topOffset = 20; // Adjust the initial vertical position as needed

            foreach (var book in books)
            {
                // Check if the book genre is "NORMAL"
                if (book.Genre == "NORMAL")
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
        }

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            reserveddateTb.Text = reservedatepicker.Value.ToString("MM/dd/yyyy");
        }

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

        private void reserveBtn_Click(object sender, EventArgs e)
        {
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
                            // Check if the borrower can reserve based on penalties
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
                                    MessageBox.Show($"The borrower '{borrowerName}' has reached the maximum reservation limit.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid or unpaid borrower name.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Borrower not found or has unpaid penalties. Reservation not allowed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Borrower has unpaid penalties or not found. Reservation not allowed.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a borrower name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a book.");
            }
        }

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

        private int GetMaxReservationLimit(string identifier)
        {
            // Set default maximum reservation limit
            int maxReservationLimit = 3;

            // Check borrower identifier and set the appropriate limit
            if (identifier.Contains("STUDENT"))
            {
                maxReservationLimit = 2;
            }
            else if (identifier.Contains("TEACHER"))
            {
                maxReservationLimit = 5;
            }

            return maxReservationLimit;
        }

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
    }

    public class Borrower
    {
        public int BorrowerId { get; set; }
        public string BorrowerName { get; set; }
        public string Identifier { get; set; }
        public int Id { get; set; }
        public int Paid { get; set; }
    }

}
