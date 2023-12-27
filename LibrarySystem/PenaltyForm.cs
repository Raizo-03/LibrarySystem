using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class PenaltyForm : Form
    {
        private List<System.Windows.Forms.CheckBox> checkBoxes = new List<System.Windows.Forms.CheckBox>();
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        private double amountPaid = 0;
        private double change = 0;
        public PenaltyForm()
        {
            InitializeComponent();


        }

        private void AddBorrowerCheckBox(int borrowerId, string borrowerName, decimal penaltyAmount, bool paid)
        {
            int topOffset = 20; // Adjust the initial vertical position as needed

            System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
            checkBox.Text = borrowerName + " - " + penaltyAmount.ToString("C");
            checkBox.Tag = borrowerId; // Use Tag property to store borrowerId
            checkBox.CheckedChanged += BorrowerCheckBox_CheckedChanged;

            // Adjust the width based on the length of the text
            checkBox.Width = TextRenderer.MeasureText(checkBox.Text, checkBox.Font).Width + 100;
            checkBox.Location = new Point(440, 100);
            checkBox.Top = topOffset;
            topOffset += 25; // Adjust the vertical spacing as needed

            checkBoxes.Add(checkBox); // Add the checkbox to the list
            Controls.Add(checkBox);

            // Set the Tag property for the borrowerLabel
            borrowerLabel.Tag = borrowerId;
        }

        private void BorrowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox checkBox = sender as System.Windows.Forms.CheckBox;

            if (checkBox != null)
            {
                // Ensure the event is triggered only when the checkbox is checked
                if (checkBox.Checked)
                {
                    int borrowerId = (int)checkBox.Tag; // Retrieve borrowerId from Tag property
                    string borrowerName = checkBox.Text.Split('-')[0].Trim(); // Extract borrowerName from checkbox text
                    string penaltyAmountText = checkBox.Text.Split('-')[1].Trim();

                    // Try to parse the penalty amount from the checkbox text
                    if (decimal.TryParse(penaltyAmountText, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal penaltyAmount))
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
            FetchUnpaidPenalties();

        }
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

        private void payBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to continue with the paying process?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check user's choice
            if (result == DialogResult.No)
            {
                // User chose not to continue, so return without executing the borrowing process
                return;
            }
            if (int.TryParse(borrowerLabel.Tag?.ToString(), out int borrowerId))
            {
                string borrowerName = borrowerLabel.Text;
                decimal amountPaid = decimal.TryParse(amountpaidTb.Text, out decimal paidAmount) ? paidAmount : 0;
                decimal change = decimal.TryParse(cLabel.Text.Replace("₱", ""), out decimal changeAmount) ? changeAmount : 0;
                decimal balance = decimal.TryParse(bLabel.Text.Replace("₱", ""), out decimal balanceAmount) ? balanceAmount : 0;

                // Perform the payment update in the database (you may need to implement this)
                bool paymentSuccessful = UpdatePaymentInDatabase(borrowerId, amountPaid);

                // Show a message box based on the payment result
                ShowPaymentResultMessage(paymentSuccessful, borrowerName, borrowerId, amountPaid, change, balance);
                if (paymentSuccessful)
                {
                    // Refresh the form or update UI as needed
                    // For example, you may want to clear checkboxes and labels after successful payment
                    ClearPaymentDetails();

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
                MessageBox.Show("Invalid borrower ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdatePaymentInDatabase(int borrowerId, decimal amountPaid)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Implement your database update logic here
                    string updateQuery = "UPDATE penalties SET paid = 1 WHERE borrower_id = @BorrowerId";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowerId", borrowerId);

                        // Execute the update query
                        int rowsAffected = command.ExecuteNonQuery();

                        // If the update was successful (at least one row affected), call UpdatePenaltyTable
                        if (rowsAffected > 0)
                        {
                            // Fetch penalty amount from the database or use a stored value
                            decimal penaltyAmount = FetchPenaltyAmountFromDatabase(borrowerId);

                            // Call UpdatePenaltyTable with the fetched penalty amount
                            UpdatePenaltyTable(borrowerId, penaltyAmount, amountPaid);
                        }

                        // Return true if the update was successful
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it according to your application's requirements
                Console.WriteLine($"Error updating payment in the database: {ex.Message}");
                return false;
            }
        }

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
                bLabel.Text = balanceText; // Update balanceLabel
            }
            else
            {
                // Handle the case where the conversion fails
                cLabel.Text = "Invalid input";
                bLabel.Text = "Invalid input"; // Update balanceLabel accordingly
            }
        }
        private void ShowPaymentResultMessage(bool paymentSuccessful, string borrowerName, int borrowerId, decimal amountPaid, decimal change, decimal balance)
        {
            string resultMessage;

            if (paymentSuccessful)
            {
                resultMessage = $"Payment Successful!\n\nName: {borrowerName}\nBorrower ID: {borrowerId}\nAmount Paid: ₱{amountPaid:N2}\nChange: ₱{change:N2}\nBalance: ₱{balance:N2}";
            }
            else
            {
                resultMessage = $"Payment Unsuccessful!\n\nName: {borrowerName}\nBorrower ID: {borrowerId}\nAmount Paid: ₱{amountPaid:N2}\nChange: ₱{change:N2}\nBalance: ₱{balance:N2}";
            }

            MessageBox.Show(resultMessage, paymentSuccessful ? "Success" : "Warning", MessageBoxButtons.OK, paymentSuccessful ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }
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

                    // Implement your database deletion logic only if fully paid
                    if (isFullyPaid)
                    {
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




    }
}
