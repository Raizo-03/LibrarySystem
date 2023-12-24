using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
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
    public partial class PenaltyForm : Form
    {
        private List<System.Windows.Forms.CheckBox> checkBoxes = new List<System.Windows.Forms.CheckBox>();
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";
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
                    decimal penaltyAmount;

                    // Try to parse the penalty amount from the checkbox text
                    if (decimal.TryParse(checkBox.Text.Split('-')[1].Trim(), out penaltyAmount))
                    {
                        // Update labels with fetched details
                        borrowerLabel.Text = borrowerName;
                        amountDueLabel.Text = penaltyAmount.ToString("C");
                    }
                }
            }
        }
        private void PenaltyForm_Load(object sender, EventArgs e)
        {
            FetchAllPenalties();

        }
        private void FetchAllPenalties()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT P.borrower_id, B.name, P.amount, P.paid " +
                               "FROM penalties P " +
                               "JOIN borrowers B ON P.borrower_id = B.user_id";

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
  
        }
    

       



    }
}
