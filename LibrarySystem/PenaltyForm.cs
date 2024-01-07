using Google.Protobuf.WellKnownTypes;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class PenaltyForm : Form
    {
        //DECLARES CHECKBOX GLOBALLY TO BE USED IN ALL THE METHODS 
        private List<System.Windows.Forms.CheckBox> checkBoxes = new List<System.Windows.Forms.CheckBox>();
        System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();

        //For database connection
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        //Global variables for the amount paid and change = set to 0
        private double amountPaid = 0;
        private double change = 0;


        public PenaltyForm()
        {
            InitializeComponent();

            //Sets the properties of the datagridview
            penaltyDG.ReadOnly = true;
            penaltyDG.AlternatingRowsDefaultCellStyle = null;
            penaltyDG.RowHeadersVisible = false;
            penaltyDG.ScrollBars = ScrollBars.Vertical;
            penaltyDG.BackgroundColor = Color.FromArgb(255, 253, 247, 228);



        }

        //Method that adds the fetched penalties and populates it into the checkboxes
        private void AddBorrowerCheckBox(int borrowerId, string borrowerName, decimal penaltyAmount, bool paid)
        {
            // Adjust the initial vertical position
            int topOffset = 120 + checkBoxes.Count * 25;

            System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
            checkBox.Text = borrowerName + " - " + penaltyAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-PH"));
            checkBox.Tag = borrowerId;
            checkBox.CheckedChanged += BorrowerCheckBox_CheckedChanged;
            checkBox.Width = TextRenderer.MeasureText(checkBox.Text, checkBox.Font).Width + 250;
            checkBox.Location = new Point(609, topOffset);
            topOffset += 25;
            checkBox.Font = new Font("Bookman Old Style", 13);

            checkBoxes.Add(checkBox);
            Controls.Add(checkBox);

            borrowerLabel.Tag = borrowerId; // Set the Tag property for the borrowerLabel
        }





        //Method that gets the values of the penalties and sets it to the labels when the checkbox is clicked
        private void BorrowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox clickedCheckBox = sender as System.Windows.Forms.CheckBox;

            if (clickedCheckBox != null)
            {
                // Ensure the event is triggered only when the checkbox is checked
                if (clickedCheckBox.Checked)
                {
                    int borrowerId = (int)clickedCheckBox.Tag; // Retrieve borrowerId from Tag property
                    string borrowerName = clickedCheckBox.Text.Split('-')[0].Trim(); // Extract borrowerName from checkbox text
                    string penaltyAmountText = clickedCheckBox.Text.Split('-')[1].Trim();

                    // Try to parse the penalty amount from the checkbox text
                    if (decimal.TryParse(penaltyAmountText, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-PH"), out decimal penaltyAmount))
                    {
                        // Show a message box for debugging
                        MessageBox.Show($"Borrower ID: {borrowerId}\nBorrower Name: {borrowerName}\nPenalty Amount: {penaltyAmount}");

                        // Update labels with fetched details
                        borrowerLabel.Text = borrowerName;
                        amountDueLabel.Text = $"₱{penaltyAmount:N2}";
                    }
                    else
                    {
                        MessageBox.Show("Failed to parse penalty amount.");
                    }

                    // Update the global checkBox variable
                    checkBox = clickedCheckBox;
                }
                else
                {
                    // If the checkbox is unchecked, clear the labels
                    borrowerLabel.Text = string.Empty;
                    amountDueLabel.Text = string.Empty;
                }
            }
        }


        private void PenaltyForm_Load(object sender, EventArgs e)
        {
            //Calls the method for fetching the unpaid penalties
            FetchUnpaidPenalties();
            upperlabelTransition.Start();

            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4

            //Calls the method for fetching the unpaid penalties and storing it in the tables
            activateFetching();

        }

        //Method that fetches the unpaid penalties from the penalties table in the database
        private void FetchUnpaidPenalties()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT P.borrower_id, B.name, P.amount, P.paid " +
                               "FROM penalties P " +
                               "JOIN borrowers B ON P.borrower_id = B.user_id " +
                               "WHERE P.paid = 0";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int borrowerId = reader.GetInt32("borrower_id");
                            string borrowerName = reader.GetString("name");
                            decimal penaltyAmount = reader.GetDecimal("amount");
                            bool paid = reader.GetBoolean("paid");

                            // Add checkboxes directly to the form's controls
                            AddBorrowerCheckBox(borrowerId, borrowerName, penaltyAmount, paid);
                        }
                    }
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Method for the pay button
        private void payBtn_Click(object sender, EventArgs e)
        {
            // Validates if the user really wants to proceed with the payment process
            DialogResult result = MessageBox.Show("Are you sure you want to continue with the paying process?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check user's choice
            if (result == DialogResult.No)
            {
                // User chose not to continue, so return without executing the payment process
                return;
            }
            int checkedCount = checkBoxes.Count(cb => cb.Checked);
            if (checkedCount != 1)
            {
                MessageBox.Show("Cannot borrow multiple books at once. Please select only one book at a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the amount paid textbox is empty/null or if it's not a numeric value; if these criteria are met, the payment will not proceed, and an error message is shown
            if (string.IsNullOrEmpty(amountpaidTb.Text) || !decimal.TryParse(amountpaidTb.Text, out decimal amountPaid))
            {
                MessageBox.Show("Invalid Amount! Please enter a valid amount (numbers only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the checked checkbox from the list
            System.Windows.Forms.CheckBox checkedCheckBox = checkBoxes.FirstOrDefault(cb => cb.Checked);

            if (checkedCheckBox != null)
            {
                // Process payment for the checked checkbox
                int borrowerId = (int)checkedCheckBox.Tag; // Retrieve borrowerId from Tag property
                string borrowerName = checkedCheckBox.Text.Split('-')[0].Trim(); // Extract borrowerName from checkbox text
                string penaltyAmountText = checkedCheckBox.Text.Split('-')[1].Trim();

                // Try to parse the penalty amount from the checkbox text
                if (decimal.TryParse(penaltyAmountText, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-PH"), out decimal penaltyAmount))
                {
                    // Update labels with fetched details
                    borrowerLabel.Text = borrowerName;
                    amountDueLabel.Text = $"₱{penaltyAmount:N2}";
                  

                    // Continue with the payment processing logic (update database, show payment result, etc.)
                    bool paymentSuccessful = UpdatePaymentInDatabase(borrowerId, amountPaid, penaltyAmount, out decimal change, out decimal balance);

                    // Show a message box based on the payment result
                    ShowPaymentResultMessage(paymentSuccessful, borrowerName, borrowerId, amountPaid, change, balance);

                    if (paymentSuccessful)
                    {
                        // Clear the checkbox after processing payment
                        checkedCheckBox.Checked = false;

                        // Refresh the form or update UI as needed
                        // For example, you may want to clear checkboxes and labels after successful payment
                        ClearPaymentDetails();
                        RefreshCheckboxes();
                        activateFetching();
                   
                    }
                }
                else
                {
                    MessageBox.Show("Failed to parse penalty amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a borrower before proceeding with the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Method that updates penalty row if the borrower paid not exact amount on the supposed amount that needs to be paid
        private bool UpdatePaymentInDatabase(int borrowerId, decimal amountPaid, decimal penaltyAmount, out decimal change, out decimal balance)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch penalty amount from the database
                    decimal fetchedPenaltyAmount = FetchPenaltyAmountFromDatabase(borrowerId);

                    // Calculate change and balance
                    change = amountPaid - fetchedPenaltyAmount;
                    balance = fetchedPenaltyAmount - amountPaid;

                    if (balance <= 0)
                    {
                        balance = 0;
                        // If the balance is zero, delete the entire row
                        DeletePenaltyFromDatabase1(borrowerId);
                    }
                    else
                    {
                        // If the balance is not zero, update the penalty table
                        UpdatePenaltyTable(borrowerId, fetchedPenaltyAmount, amountPaid);
                    }

                    // Return true to indicate success
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it according to your application's requirements
                Console.WriteLine($"Error updating payment in the database: {ex.Message}");

                // Set change and balance to zero in case of an exception
                change = 0;
                balance = 0;

                return false;
            }
        }

        private void DeletePenaltyFromDatabase1(int borrowerId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                        // If fully paid, delete the row from the penalties table
                        string deleteQuery = "DELETE FROM penalties WHERE borrower_id = @BorrowerId";

                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@BorrowerId", borrowerId);

                            // Execute the delete query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine($"Penalty for borrower ID {borrowerId} deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine($"Penalty for borrower ID {borrowerId} not found in the database.");
                            }
                        }
          
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it according to your application's requirements
                Console.WriteLine($"Error deleting/updating penalty from the database: {ex.Message}");
            }
        }


        //Method that fetches the penalty amount of the user base on the borrower id and returns a value of decimal
        private decimal FetchPenaltyAmountFromDatabase(int borrowerId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT amount FROM penalties WHERE borrower_id = @BorrowerId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowerId", borrowerId);

                        // Execute the query to fetch the penalty amount
                        object result = command.ExecuteScalar();

                        // Check if the result is not null and convert it to decimal
                        if (result != null && decimal.TryParse(result.ToString(), out decimal penaltyAmount))
                        {
                            return penaltyAmount;
                        }
                        else
                        {
                            // Handle the case where the penalty amount cannot be fetched
                            Console.WriteLine("Error fetching penalty amount from the database.");
                            return 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it according to your application's requirements
                Console.WriteLine($"Error fetching penalty amount from the database: {ex.Message}");
                return 0;
            }
        }


        //Method the updates the penalty table if the user paid the exact amount of the supposed penalty amound that needs to be paid
        private void UpdatePenaltyTable(int borrowerId, decimal penaltyAmount, decimal amountPaid)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Calculate the remaining penalty amount after payment
                decimal remainingPenalty = penaltyAmount - amountPaid;

                // Determine if the penalty is fully paid or not
                bool isFullyPaid = remainingPenalty <= 0;

                // Update the penalties table with payment information
                string updateQuery;

                if (isFullyPaid)
                {
                    // If fully paid, update both 'amount' and 'paid' columns
                    updateQuery = "UPDATE penalties SET paid = @isFullyPaid, amount = @remainingPenalty WHERE borrower_id = @borrowerId";
                }
                else
                {
                    // If still balance, update only the 'amount' column
                    updateQuery = "UPDATE penalties SET amount = @remainingPenalty WHERE borrower_id = @borrowerId";
                }

                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@isFullyPaid", isFullyPaid);
                    updateCommand.Parameters.AddWithValue("@remainingPenalty", remainingPenalty < 0 ? 0 : remainingPenalty); // Ensure remaining penalty is not negative
                    updateCommand.Parameters.AddWithValue("@borrowerId", borrowerId);

                    updateCommand.ExecuteNonQuery();
                }
            }
        }


        //Method for the amountpaid textbox, if the user inputted numeric value, it will automatically calculate the change and the balance depending on the penalty amount
        private void amountpaidTb_TextChanged(object sender, EventArgs e)
        {
            // Remove the peso sign from amountDueLabel.Text before parsing
            string amountDueText = amountDueLabel.Text.Replace("₱", "");

            if (double.TryParse(amountDueText, out double amountDueValue) &&
                double.TryParse(amountpaidTb.Text, out double amountPaidValue))
            {
                double change = amountPaidValue - amountDueValue;

                // Ensure the change is not negative
                if (change < 0)
                {
                    // If overpaid, set the change to 0
                    change = 0;
                }

                double balance = amountDueValue - amountPaidValue;

                // Ensure the balance is not negative
                if (balance < 0)
                {
                    // If overpaid, set the balance to 0
                    balance = 0;
                }

                // Format the change and balance as needed with the peso sign
                string changeText = change.ToString("C2", CultureInfo.CreateSpecificCulture("en-PH")); // C2 format specifier for currency with two decimal places, using Philippines culture
                string balanceText = balance.ToString("C2", CultureInfo.CreateSpecificCulture("en-PH")); // C2 format specifier for currency with two decimal places, using Philippines culture

                cLabel.Text = changeText; // Update cLabel
                bLabel.Text = balanceText; // Update balanceLabe
            }
            else
            {
                // Handle the case where the conversion fails
                cLabel.Text = "Invalid input";
                bLabel.Text = "Invalid input"; // Update balanceLabel accordingly
            }
        }

        //Method to show if the payment is succesful, it will show, borrower name, borrower id, amount paid, balance, and the change of borrower
        // Method to show if the payment is successful
        private void ShowPaymentResultMessage(bool paymentSuccessful, string borrowerName, int borrowerId, decimal amountPaid, decimal change, decimal balance)
        {
            string resultMessage;

            if (paymentSuccessful)
            {
                if (balance <= 0)
                {
                    resultMessage = $"Payment Successful!\n\nName: {borrowerName}\nBorrower ID: {borrowerId}\nAmount Paid: ₱{amountPaid:N2}\nChange: ₱{change:N2}\nBalance: ₱ 0.00";
                }
                else if(change <= 0)
                {
                    resultMessage = $"Payment Successful!\n\nName: {borrowerName}\nBorrower ID: {borrowerId}\nAmount Paid: ₱{amountPaid:N2}\nChange:  ₱ 0.00 \nBalance: ₱{balance:N2}";

                }
                else
                {
                    resultMessage = $"Payment Successful!\n\nName: {borrowerName}\nBorrower ID: {borrowerId}\nAmount Paid: ₱{amountPaid:N2}\nChange: ₱{change:N2}\nBalance: ₱{balance:N2}";
                }
            }
            else
            {
                resultMessage = $"Payment Unsuccessful!\n\nName: {borrowerName}\nBorrower ID: {borrowerId}\nAmount Paid: ₱{amountPaid:N2}\nChange: ₱{change:N2}\nBalance: ₱{balance:N2}";
            }

            MessageBox.Show(resultMessage, paymentSuccessful ? "Success" : "Warning", MessageBoxButtons.OK, paymentSuccessful ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }


        //Method to remove the checkbox and the labels for the borrower if paid the exact amount
        private void ClearPaymentDetails()
        {
            int borrowerIdToRemove = int.Parse(borrowerLabel.Tag.ToString());

            // Find and remove the checkbox associated with the paid borrower ID
            System.Windows.Forms.CheckBox checkBoxToRemove = checkBoxes.FirstOrDefault(cb => (int)cb.Tag == borrowerIdToRemove);
            if (checkBoxToRemove != null)
            {
                Controls.Remove(checkBoxToRemove);
                checkBoxes.Remove(checkBoxToRemove);

                // Delete the corresponding penalty from the database
                DeletePenaltyFromDatabase(borrowerIdToRemove);
            }

            borrowerLabel.Text = string.Empty;
            amountDueLabel.Text = string.Empty;
            amountpaidTb.Text = string.Empty;
            cLabel.Text = "₱0.00";
            bLabel.Text = "₱0.00";
            // Clear any other UI elements as needed
        }

        //Method that deletes entirely the row of the borrower if paid the exact amount
        private void DeletePenaltyFromDatabase(int borrowerId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch penalty amount from the database
                    decimal penaltyAmount = FetchPenaltyAmountFromDatabase(borrowerId);

                    // Determine if the penalty is fully paid or not
                    bool isFullyPaid = penaltyAmount <= 0;

                    if (isFullyPaid)
                    {
                        // If fully paid, delete the row from the penalties table
                        string deleteQuery = "DELETE FROM penalties WHERE borrower_id = @BorrowerId";

                        using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@BorrowerId", borrowerId);

                            // Execute the delete query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine($"Penalty for borrower ID {borrowerId} deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine($"Penalty for borrower ID {borrowerId} not found in the database.");
                            }
                        }
                    }
                    else
                    {
                        // If there is still a balance, update the 'paid' column to unpaid (BIT = 0)
                        string updatePaidQuery = "UPDATE penalties SET paid = 0 WHERE borrower_id = @BorrowerId";

                        using (MySqlCommand updateCommand = new MySqlCommand(updatePaidQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@BorrowerId", borrowerId);

                            updateCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it according to your application's requirements
                Console.WriteLine($"Error deleting/updating penalty from the database: {ex.Message}");
            }
        }


        //Method that activates the fetching of the penalties and sets it to the datagridview
        //It also sets the properties of the datagridview
        private void activateFetching()
        {
            try
            {
                // Clear existing columns in the DataGridView
                penaltyDG.Columns.Clear();

                // Fetch penalty information from the database
                List<PenaltyInfo> penalties = GetPenaltiesInfo();

                // Add columns to the DataGridView
                penaltyDG.Columns.Add("PenaltyID", "PENALTY ID");
                penaltyDG.Columns.Add("BorrowerName", "BORROWER'S NAME");
                penaltyDG.Columns.Add("Amount", "AMOUNT");


                // Set font size and apply modern style
                penaltyDG.DefaultCellStyle.Font = new Font("Bookman Old Style", 10); // Adjust font and size
                penaltyDG.ColumnHeadersDefaultCellStyle.Font = new Font("Book Antiqua", 10, FontStyle.Bold); // Adjust font, size, and style
                penaltyDG.EnableHeadersVisualStyles = false;
                penaltyDG.ColumnHeadersDefaultCellStyle.BackColor = Color.Chocolate; // Header background color
                penaltyDG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Header text color

                // Set column widths
                penaltyDG.Columns["PenaltyID"].Width = 120; // Adjust width as needed
                penaltyDG.Columns["BorrowerName"].Width = 325; // Adjust width as needed
                penaltyDG.Columns["Amount"].Width = 275; // Adjust width as needed

                // Disable user resizing of rows and columns
                penaltyDG.AllowUserToResizeRows = false;
                penaltyDG.AllowUserToResizeColumns = false;

                // Disable row headers resizing and visibility
                penaltyDG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

                // Bind the list to the DataGridView
                foreach (PenaltyInfo penalty in penalties)
                {
                    int rowIndex = penaltyDG.Rows.Add();
                    penaltyDG.Rows[rowIndex].Cells["PenaltyID"].Value = penalty.PenaltyID;
                    penaltyDG.Rows[rowIndex].Cells["BorrowerName"].Value = penalty.BorrowerName;
                    penaltyDG.Rows[rowIndex].Cells["Amount"].Value = penalty.Amount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //Method for the penalty button
        private void penaltyBtn_Click(object sender, EventArgs e)
        {
            activateFetching();
            RefreshCheckboxes();

        }

        //Method that fetches the penalties in the penalties table and store it in a list data structure
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

        private void penaltyDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshCheckboxes()
        {
            // Clear existing checkboxes
            foreach (var checkBox in checkBoxes)
            {
                Controls.Remove(checkBox);
            }

            checkBoxes.Clear();

            // Fetch updated penalties and recreate checkboxes
            FetchUnpaidPenalties();
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
     