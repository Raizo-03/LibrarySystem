using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class BorrowerList : Form
    {
        private List<User> users;  // Assuming User, Student, and Teacher classes are defined as in the previous example
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        public BorrowerList()
        {
            InitializeComponent();


        }

        private void BorrowerList_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4

            //STUDENTS

            //BORROWINGS
            int beringuelBorrowed = GetTotalBorrowingsBeringuel();
            beringuelborrowLabel.Text = beringuelBorrowed.ToString();


            //RESERVE
            int beringuelReserve = GetTotalReservationsBeringuel();
            beringuelreservedLabel.Text = beringuelReserve.ToString();   

        }

        //METHOD FOR FETCHING

        //STUDENTS

        //BORROWINGS
        private int GetTotalBorrowingsBeringuel()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12043710";

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
        private int GetTotalBorrowingsVillena()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12043710";

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




        //RESERVE
        private int GetTotalReservationsBeringuel()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12043710";

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
    }
}
