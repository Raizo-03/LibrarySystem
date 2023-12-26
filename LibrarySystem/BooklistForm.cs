﻿using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using static LibrarySystem.FirstForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibrarySystem
{
    
    public partial class BooklistForm : Form
    {
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";
        private Timer updateTimer;

        // Add properties for user detail
        public string UserName { get; private set; }
        public string UserID { get; private set; }
        public string UserDepartment { get; private set; }
        public string availability { get; private set; }

        private string username;
        private string identifier;
        private int limit;

        

        public BooklistForm(string IDENTIFIER, string NAME, string ID, int LIMIT)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 253, 247, 228); // CUSTOM BG COLOR #FDF7E4

            this.identifier = IDENTIFIER;
            this.username = NAME;
    

            fictionTransition2.Start();
            nonficTransition2.Start();
            acadTransition2.Start();

            // Initialize and start the update timer
            updateTimer = new Timer();
            updateTimer.Interval = 60000; // Update every 60 seconds (adjust as needed)
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();

            // Example: Fetch book information and update label
            string bookTitle = "To Kill a Mockingbird".Trim();
            FetchBookInformation(bookTitle);


        }

        //FETCHES BOOK TITLES
        private void FetchBookInformation(string bookTitle)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch title and availability from the books table
                    string query = "SELECT title, availability FROM books WHERE title = @bookTitle";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@bookTitle", bookTitle);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Fetch title and availability from the database
                                string fetchedTitle = reader.GetString("title");
                                string fetchedAvailability = reader.GetString("availability");

                                // Now you can use these values as needed
                                UpdateStatusLabel(fetchedTitle, fetchedAvailability);
                            }
                            else
                            {
                                // Handle the case where the book with the specified title is not found
                                MessageBox.Show($"Book with title '{bookTitle}' not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching book information: {ex.Message}");
            }
        }

        private void UpdateStatusLabel(string title, string availability)
        {

            if (title.Trim().Equals("To Kill a Mockingbird", StringComparison.OrdinalIgnoreCase))
            {
                mockingstatsLbl.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    mockingstatsLbl.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    mockingstatsLbl.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    mockingstatsLbl.ForeColor = Color.DodgerBlue;
                    mockingstatsLbl.Text = availability.ToUpper();

                }
            } else if(title.Trim().Equals("1984", StringComparison.OrdinalIgnoreCase))
            {
                stats1984Lbl.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    stats1984Lbl.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    stats1984Lbl.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    stats1984Lbl.ForeColor = Color.DodgerBlue;
                    stats1984Lbl.Text = availability.ToUpper();

                }
            }
            else
            {
                mockingstatsLbl.Text = "UNKNOWN TITLE";
            }
        }


        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            
        }

        // Add a method to populate the DataGridView with books
        private void BooklistForm_Load(object sender, EventArgs e)
        {
           
        }

        private void fictionButton_Click(object sender, EventArgs e)
        {
            fictionPanel.Location = new Point(47, 115);
            nonfictionPanel.Location = new Point(47, 368);
            academicPanel.Location = new Point(47, 623);
            fictionTransition2.Start();
            nonficTransition.Start();
            acadTransition.Start();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Optional: You can implement logic for handling the rjButton1 click event.
        }



    
        // Event handler for the SortCompare event to customize sorting for Genre column
  


     

        private void label4_Click(object sender, EventArgs e)
        {

        }

        bool fictionExpand = false;
        //FICTION

        //COLLAPSE
        private void fictionTransition_Tick(object sender, EventArgs e)
        {
            const int targetCollapsedWidth = 1;
            const int step = 200;


            // Collapsing
            fictionPanel.Width -= step;
            if (fictionPanel.Width <= targetCollapsedWidth)
            {
                fictionPanel.Width = targetCollapsedWidth;
                fictionTransition.Stop();
                fictionExpand = false;
            }
        }
        //EXPAND
        private void fictionTransition2_Tick(object sender, EventArgs e)
        {
            const int targetExpandedWidth = 856;
            const int step = 200;
            fictionPanel.Width += step;

            if (fictionPanel.Width >= targetExpandedWidth)
            {
                fictionPanel.Width = targetExpandedWidth;
                fictionTransition2.Stop();
                fictionExpand = true;
            }
        }

        private void nonfictionBtn_Click(object sender, EventArgs e)
        {
            nonfictionPanel.Location = new Point(47, 115);
            academicPanel.Location = new Point(47, 368);
            fictionPanel.Location = new Point(47, 623);
            fictionTransition.Start();
            nonficTransition2.Start();
            acadTransition.Start();
        }
        //NONFICTION
        //COLLAPSE

        bool nonfictionExpand = false;

        private void nonficTransition_Tick_1(object sender, EventArgs e)
        {
            const int targetCollapsedWidth = 1;
            const int step = 200;


            // Collapsing
            nonfictionPanel.Width -= step;
            if (nonfictionPanel.Width <= targetCollapsedWidth)
            {
                nonfictionPanel.Width = targetCollapsedWidth;
                nonficTransition.Stop();
                nonfictionExpand = false;
            }
        }
        //EXPAND

        private void nonficTransition2_Tick_1(object sender, EventArgs e)
        {
            const int targetExpandedWidth = 856;
            const int step = 200;
            nonfictionPanel.Width += step;

            if (nonfictionPanel.Width >= targetExpandedWidth)
            {
                nonfictionPanel.Width = targetExpandedWidth;
                nonficTransition2.Stop();
                nonfictionExpand = true;
            }
        }

        private void booklistLlbl_Click(object sender, EventArgs e)
        {
            fictionPanel.Location = new Point(47, 115);
            nonfictionPanel.Location = new Point(47, 368);
            academicPanel.Location = new Point(47, 623);
            fictionTransition2.Start();
            nonficTransition2.Start();
            acadTransition2.Start();
            
        }

        //ACADEMIC
        bool acadExpand = false;
        //COLLAPSE
        private void acadTransition_Tick(object sender, EventArgs e)
        {
            const int targetCollapsedWidth = 1;
            const int step = 200;


            // Collapsing
            academicPanel.Width -= step;
            if (academicPanel.Width <= targetCollapsedWidth)
            {
                academicPanel.Width = targetCollapsedWidth;
                acadTransition.Stop();
                acadExpand = false;
            }
        }

        private void acadTransition2_Tick(object sender, EventArgs e)
        {
            const int targetExpandedWidth = 856;
            const int step = 200;
            academicPanel.Width += step;

            if (academicPanel.Width >= targetExpandedWidth)
            {
                academicPanel.Width = targetExpandedWidth;
                acadTransition2.Stop();
                acadExpand = true;
            }
        }

        private void acadBtn_Click(object sender, EventArgs e)
        {
            academicPanel.Location = new Point(47, 115);
            fictionPanel.Location = new Point(47, 368);
            nonfictionPanel.Location = new Point(47, 623);
            fictionTransition.Start();
            nonficTransition.Start();
            acadTransition2.Start();
        }

   
    }


    //FICTION TRANSITION

    /*
    bool menuExpand = false;
    private void fictionTransition_Tick_1(object sender, EventArgs e)
    {
        const int targetExpandedWidth = 851;
        const int targetCollapsedWidth = 26;
        const int step = 200;

        if (!fictionExpand)
        {
            // Expanding
            fictionPanel.Width += step;
            if (fictionPanel.Height >= targetExpandedWidth)
            {
                fictionPanel.Height = targetExpandedWidth;
                fictionTransition.Stop();
                fictionExpand = true;
            }
        }
        else
        {
            // Collapsing
            fictionPanel.Height -= step;
            if (fictionPanel.Height <= targetCollapsedWidth)
            {
                fictionPanel.Height = targetCollapsedWidth;
                fictionTransition.Stop();
                fictionExpand = false;
            }
        }
    }

    */

 
}
