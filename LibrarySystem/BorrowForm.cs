using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BorrowForm : Form
    {
        // Dictionary to store selected values for each checkbox
        private Dictionary<CheckBox, string> selectedValuesDictionary = new Dictionary<CheckBox, string>();
        private int bookLimit; // Set the limit to 5 books
        private String userNAME;
        private String Identifier;
        public BorrowForm(String identifier, int booklimit, string username)
        {
            InitializeComponent();
            this.Identifier = identifier;   
            this.bookLimit = booklimit;
            this.userNAME = username;
            label6.Text = booklimit.ToString();
            borrower.Text = username;

            //BORROWING DATES
            DateTime currentDate = DateTime.Now;
            borrowdate.Text = currentDate.ToString();

            if (identifier.Equals("stud"))
            {
                DateTime futureDate = currentDate.AddDays(3);
                duedate.Text = futureDate.ToString();
            }
            else if (identifier.Equals("prof"))
            {
                duedate.Text = "NO DUE DATE";
            }

            // Add event handlers for CheckedChanged event of CheckBox controls

            // FICTION CONTROLBOX
            foreach (Control control in fictiongroupBx.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.CheckedChanged += Group_CheckedChanged;
                    selectedValuesDictionary.Add(checkBox, string.Empty);
                }
            }

            // NONFICTION CONTROLBOX
            foreach (Control control in nonficgroupBx.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.CheckedChanged += Group_CheckedChanged;
                    selectedValuesDictionary.Add(checkBox, string.Empty);
                }
            }
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4
        }

        private void Group_CheckedChanged(object sender, EventArgs e)
        {
            // Handle the CheckedChanged event for both group boxes

            // Update the selected value for the current checkbox
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    // Check if the book limit has been reached
                    if (CountSelectedBooks() >= bookLimit)
                    {
                        checkBox.Checked = false; // Uncheck the checkbox
                        MessageBox.Show($"You can only borrow up to {bookLimit} books.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        selectedValuesDictionary[checkBox] = checkBox.Text;
                    }
                }
                else
                {
                    selectedValuesDictionary[checkBox] = string.Empty;
                }
            }

            // Update labels with all selected values
            UpdateLabels();
        }

        private int CountSelectedBooks()
        {
            // Count the number of selected books
            int count = 0;
            foreach (var checkBox in selectedValuesDictionary.Keys)
            {
                if (!string.IsNullOrEmpty(selectedValuesDictionary[checkBox]) && checkBox.Checked)
                {
                    count++;
                }
            }
            return count;
        }

        private void UpdateLabels()
        {
            // Display each selected value in its corresponding label
            Label[] labels = { label1, label2, label3, label4, label5 };

            // Clear all labels
            foreach (var label in labels)
            {
                label.Text = string.Empty;
            }

            // Iterate through checkboxes and update labels
            int index = 0;
            foreach (var checkBox in selectedValuesDictionary.Keys)
            {
                if (index >= labels.Length)
                    break;

                if (!string.IsNullOrEmpty(selectedValuesDictionary[checkBox]) && checkBox.Checked)
                {
                    labels[index].Text = selectedValuesDictionary[checkBox];
                    index++;
                }
            }
        }

        private void fictiongroupBx_Enter(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void nonficgroupBx_Enter(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
