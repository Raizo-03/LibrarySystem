using Google.Protobuf.WellKnownTypes;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private void AddBorrowerCheckBox(int borrowerId, string borrowerName, decimal penaltyAmount, bool paid, int penaltyId)
        {
            // Adjust the initial vertical position
            int topOffset = 120 + checkBoxes.Count * 25;

            System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
            checkBox.Text = borrowerName + " - " + penaltyAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-PH"));
            checkBox.Tag = new Tuple<int, int>(borrowerId, penaltyId); // Use Tuple to store both borrowerId and penaltyId
            checkBox.CheckedChanged += BorrowerCheckBox_CheckedChanged;
            checkBox.Width = TextRenderer.MeasureText(checkBox.Text, checkBox.Font).Width + 250;
            checkBox.Location = new Point(609, topOffset);
            topOffset += 25;
            checkBox.Font = new Font("Bookman Old Style", 13);

            checkBoxes.Add(checkBox);
            Controls.Add(checkBox);

            borrowerLabel.Tag = borrowerId; // Set the Tag property for the borrowerLabel
        }
        private void refreshInfo()
        {
            if (borrowerLabel.Text.Equals("Krissa Beringuel"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentGirl.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Krissa Beringuel";
                bID.Text = "K12043710";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Lans Villena"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Lans Villena";
                bID.Text = "K12043456";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Rod Balaoro"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Rod Balaoro";
                bID.Text = "K12042342";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Harvey Hingco"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Harvey Hingco";
                bID.Text = "K12042345";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("April Faustino"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentGirl.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "April Faustino";
                bID.Text = "K12021321";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Rhycell Ortega"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Rhycell Ortega";
                bID.Text = "K12021327";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Joshua Fernandez"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Joshua Fernandez";
                bID.Text = "K12042469";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Sean Sicat"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Sean Sicat";
                bID.Text = "K12032131";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Ricardo Colarina"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Ricardo Colarina";
                bID.Text = "K12042346";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Asilito Caasi"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/studentBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Asilito Caasi";
                bID.Text = "K12043567";
                category.Text = "STUDENT";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Jomariss Plan"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/teacherGirl.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Jomariss Plan";
                label4.Text = "Employee ID";
                bID.Text = "K12052345";
                category.Text = "TEACHER";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Lester Diampoc"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/teacherBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Lester Diampoc";
                label4.Text = "Employee ID";
                bID.Text = "K12052385";
                category.Text = "TEACHER";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else if (borrowerLabel.Text.Equals("Daniel Dellosa"))
            {
                string imagePath = "C:/Users/USER/source/repos/LibrarySystem/images/teacherBoy.png";
                profilePic.Image = Image.FromFile(imagePath);
                bnameInfo.Text = "Daniel Dellosa";
                label4.Text = "Employee ID";
                bID.Text = "K12048547";
                category.Text = "TEACHER";
                profilePic.Visible = true; // Make sure to set the visibility to true
            }
            else
            {
                profilePic.Visible = false; // Make sure to set the visibility to true
                bnameInfo.Text = "Not Found";
                bID.Text = "Not Found";
                category.Text = "Not Found";

            }

            //For penalty days
            string amountDue = amountDueLabel.Text;

            // Remove non-numeric characters (leaving only digits and decimal point)
            amountDue = new string(amountDue.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(amountDue))
            {
                if (double.TryParse(amountDue, out double aVal))
                {
                    double days = aVal / 2000; // Adjust the division to get the correct value
                    pDays.Text = days.ToString();
                }
                else
                {
                    pDays.Text = "Invalid input";
                }
            }
            else
            {
                pDays.Text = "Empty input";
            }

        }

        private void clearInfo()
        {
            profilePic.Visible = false; // Make sure to set the visibility to true
            bnameInfo.Text = "";
            bID.Text = "";
            category.Text = "";
        }




        //Method that gets the values of the penalties and sets it to the labels when the checkbox is clicked
        private void BorrowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox clickedCheckBox = sender as System.Windows.Forms.CheckBox;

            if (clickedCheckBox != null && clickedCheckBox.Checked)
            {
                Tuple<int, int> tagTuple = clickedCheckBox.Tag as Tuple<int, int>;

                if (tagTuple != null)
                {
                    int borrowerId = tagTuple.Item1;
                    int penaltyId = tagTuple.Item2;
                    string borrowerName = clickedCheckBox.Text.Split('-')[0].Trim();
                    string penaltyAmountText = clickedCheckBox.Text.Split('-')[1].Trim();

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
                }
                else
                {
                    MessageBox.Show("Invalid Tag format.");
                }
            }
            else if (clickedCheckBox != null && !clickedCheckBox.Checked)
            {
                // If the checkbox is unchecked, clear the labels
                borrowerLabel.Text = string.Empty;
                amountDueLabel.Text = string.Empty;
            }
            refreshInfo();
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

                string query = "SELECT P.penalty_id, P.borrower_id, B.name, P.amount, P.paid " +
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
                            int penaltyId = reader.GetInt32("penalty_id"); // Fetch the penalty ID from the database

                            // Add checkboxes directly to the form's controls
                            AddBorrowerCheckBox(borrowerId, borrowerName, penaltyAmount, paid, penaltyId);
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
            // Count the number of selected checkboxes
            int selectedCheckboxCount = checkBoxes.Count(cb => cb.Checked);

            if (selectedCheckboxCount != 1)
            {
                // Show an error message if more than one checkbox is selected
                MessageBox.Show("Cannot pay multiple penalties at once. Please select only one penalty at a time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            System.Windows.Forms.CheckBox checkedCheckBox = checkBoxes.FirstOrDefault(cb => cb.Checked);

            if (checkedCheckBox != null)
            {
                Tuple<int, int> tagTuple = checkedCheckBox.Tag as Tuple<int, int>;

                if (tagTuple != null)
                {
                    int borrowerId = tagTuple.Item1;
                    int penaltyId = tagTuple.Item2;

                    // Check if the amount paid textbox is empty/null or if it's not a numeric value; if these criteria are met, the payment will not proceed, and an error message is shown
                    if (string.IsNullOrEmpty(amountpaidTb.Text) || !decimal.TryParse(amountpaidTb.Text, out decimal amountPaid))
                    {
                        MessageBox.Show("Invalid Amount! Please enter a valid amount (numbers only).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Fetch penalty amount from the database
                    decimal penaltyAmount = FetchPenaltyAmountFromDatabase(borrowerId, penaltyId);

                    // Continue with the payment processing logic (update database, show payment result, etc.)
                    bool paymentSuccessful = UpdatePaymentInDatabase(borrowerId, penaltyId, amountPaid, penaltyAmount, out decimal change, out decimal balance);

                    // Show a message box based on the payment result
                    ShowPaymentResultMessage(paymentSuccessful, checkedCheckBox.Text, borrowerId, amountPaid, change, balance);

                    if (paymentSuccessful)
                    {
                        // Clear the checkbox after processing payment
                        checkedCheckBox.Checked = false;

                        // Refresh the form or update UI as needed
                        // For example, you may want to clear checkboxes and labels after successful payment
                        ClearPaymentDetails();
                        RefreshCheckboxes();
                        activateFetching();
                        clearInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Tag format.");
                }
            }
            else
            {
                MessageBox.Show("Please select a borrower before proceeding with the payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method that updates penalty row if the borrower paid not the exact amount on the supposed amount that needs to be paid
        private bool UpdatePaymentInDatabase(int borrowerId, int penaltyId, decimal amountPaid, decimal penaltyAmount, out decimal change, out decimal balance)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Fetch penalty amount from the database
                    decimal fetchedPenaltyAmount = FetchPenaltyAmountFromDatabase(borrowerId, penaltyId);

                    // Calculate change and balance
                    change = amountPaid - fetchedPenaltyAmount;
                    balance = fetchedPenaltyAmount - amountPaid;

                    if (balance <= 0)
                    {
                        balance = 0;
                        // If the balance is zero, delete the entire row
                        DeletePenaltyFromDatabase1(borrowerId, penaltyId);
                    }
                    else
                    {
                        // If the balance is not zero, update the penalty table
                        UpdatePenaltyTable(borrowerId, penaltyId, fetchedPenaltyAmount, amountPaid);
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

        private void DeletePenaltyFromDatabase1(int borrowerId, int penaltyId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // If fully paid, delete the row from the penalties table
                    string deleteQuery = "DELETE FROM penalties WHERE borrower_id = @BorrowerId AND penalty_id = @PenaltyId";

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowerId", borrowerId);
                        command.Parameters.AddWithValue("@PenaltyId", penaltyId);

                        // Execute the delete query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Penalty for borrower ID {borrowerId} and Penalty ID {penaltyId} deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"Penalty for borrower ID {borrowerId} and Penalty ID {penaltyId} not found in the database.");
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
        private decimal FetchPenaltyAmountFromDatabase(int borrowerId, int penaltyId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT amount FROM penalties WHERE borrower_id = @BorrowerId AND penalty_id = @PenaltyId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowerId", borrowerId);
                        command.Parameters.AddWithValue("@PenaltyId", penaltyId);

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
        private void UpdatePenaltyTable(int borrowerId, int penaltyId, decimal penaltyAmount, decimal amountPaid)
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
                    updateQuery = "UPDATE penalties SET paid = @isFullyPaid, amount = @remainingPenalty WHERE borrower_id = @borrowerId AND penalty_id = @penaltyId";
                }
                else
                {
                    // If still balance, update only the 'amount' column
                    updateQuery = "UPDATE penalties SET amount = @remainingPenalty WHERE borrower_id = @borrowerId AND penalty_id = @penaltyId";
                }

                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@isFullyPaid", isFullyPaid);
                    updateCommand.Parameters.AddWithValue("@remainingPenalty", remainingPenalty < 0 ? 0 : remainingPenalty); // Ensure remaining penalty is not negative
                    updateCommand.Parameters.AddWithValue("@borrowerId", borrowerId);
                    updateCommand.Parameters.AddWithValue("@penaltyId", penaltyId);

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
                else if (change <= 0)
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
            if (borrowerLabel.Tag != null && int.TryParse(borrowerLabel.Tag.ToString(), out int borrowerIdToRemove))
            {
                ClearDetailsWithoutCapturing(borrowerIdToRemove);

                // Find and remove the checkbox associated with the paid borrower ID
                System.Windows.Forms.CheckBox checkBoxToRemove = checkBoxes.FirstOrDefault(cb => cb.Tag is Tuple<int, int> tuple && tuple.Item1 == borrowerIdToRemove);

                if (checkBoxToRemove != null)
                {
                    Controls.Remove(checkBoxToRemove);
                    checkBoxes.Remove(checkBoxToRemove);

                    // Delete the corresponding penalty from the database
                    //DeletePenaltyFromDatabase(borrowerIdToRemove);
                }
            }

            borrowerLabel.Text = string.Empty;
            amountDueLabel.Text = string.Empty;
            amountpaidTb.Text = string.Empty;
            cLabel.Text = "₱0.00";
            bLabel.Text = "₱0.00";
            // Clear any other UI elements as needed
        }
        private void ClearDetailsWithoutCapturing(int borrowerIdToRemove)
        {
            // Find and remove the checkbox associated with the paid borrower ID
            System.Windows.Forms.CheckBox checkBoxToRemove = checkBoxes.FirstOrDefault(cb => cb.Tag is Tuple<int, int> tuple && tuple.Item1 == borrowerIdToRemove);

            if (checkBoxToRemove != null)
            {
                Controls.Remove(checkBoxToRemove);
                checkBoxes.Remove(checkBoxToRemove);

                // Delete the corresponding penalty from the database
                //DeletePenaltyFromDatabase(borrowerIdToRemove);
            }
        }

        //Method that deletes entirely the row of the borrower if paid the exact amount
        private void DeletePenaltyFromDatabase(int borrowerId, int penaltyId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // If fully paid, delete the row from the penalties table
                    string deleteQuery = "DELETE FROM penalties WHERE borrower_id = @BorrowerId AND penalty_id = @PenaltyId";

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BorrowerId", borrowerId);
                        command.Parameters.AddWithValue("@PenaltyId", penaltyId);

                        // Execute the delete query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"Penalty for borrower ID {borrowerId} and Penalty ID {penaltyId} deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"Penalty for borrower ID {borrowerId} and Penalty ID {penaltyId} not found in the database.");
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

        private void timeBtn_Click(object sender, EventArgs e)
        {
            // Record the start time for the entire process
            Stopwatch stopwatch = Stopwatch.StartNew();

            // Fetch unpaid penalties and measure time
            DateTime startTimeFetchUnpaidPenalties = DateTime.Now;
            FetchUnpaidPenalties();
            double millisecondsFetchUnpaidPenalties = stopwatch.Elapsed.TotalMilliseconds;

            // Fetch additional data if needed, and measure time
            DateTime startTimeAdditionalFetch = DateTime.Now;
            // Perform additional fetch operations here
            double millisecondsAdditionalFetch = stopwatch.Elapsed.TotalMilliseconds;

            // Perform the reservation and measure time
            DateTime startTimeReservationProcess = DateTime.Now;
            // Perform the actual reservation process here
            double millisecondsReservationProcess = stopwatch.Elapsed.TotalMilliseconds;

            // Display the total time taken for the entire process
            double millisecondsTotalProcess = stopwatch.Elapsed.TotalMilliseconds;

            // Combine all the information into a single message
            string message = $"Time taken for fetching unpaid penalties: {millisecondsFetchUnpaidPenalties} milliseconds\n" +
                             $"Time taken for additional fetch operations: {millisecondsAdditionalFetch} milliseconds\n" +
                             $"Time taken for the entire paying process: {millisecondsReservationProcess} milliseconds\n" +
                             $"Total time taken for the entire process: {millisecondsTotalProcess} milliseconds";

            // Show the combined message in a single message box
            MessageBox.Show(message, "Time Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            string guidelines =
                      "Only 1 penalty/checkbox is allowed per paying process.\n" +
                      "Penalties accumulate at a rate of 20 per day after the due date has passed.\n" +
                      "If a student does not pay the exact amount, there will still be a balance, and the student cannot borrow as long as they have a record of penalty.";

            MessageBox.Show(guidelines, "Penalty Paying Guidelines", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}
