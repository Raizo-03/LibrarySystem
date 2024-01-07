using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BorrowerList : Form
    {
        //Declaring a list structure for user
        private List<User> users;  

        //For database connection
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        public BorrowerList()
        {
            InitializeComponent();


        }

        private void BorrowerList_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4
            upperlabelTransition.Start();

            //STUDENTS

            //BORROWINGS
            //Calls individual borrowers and their total borrowings and reservings and sets them into corresponding variables to be used in certain labels
            int beringuelBorrowed = GetTotalBorrowingsBeringuel();
            beringuelborrowLabel.Text = beringuelBorrowed.ToString();
            int villenaBorrowed = GetTotalBorrowingsVillena();
            villenaborrowedLabel.Text = villenaBorrowed.ToString();
            int balaoroBorrowed = GetTotalBorrowingsBalaoro();
            balaoroborrowedLabel.Text = balaoroBorrowed.ToString();
            int hingcoBorrowed =GetTotalBorrowingsHingco();
            hingcoborrowedLabel.Text = hingcoBorrowed.ToString();
            int faustinoBorrowed = GetTotalBorrowingsFaustino();
            faustinoborrowedLabel.Text = faustinoBorrowed.ToString();
            int ortegaBorrowed = GetTotalBorrowingsOrtega();
            ortegaborrowedLabel.Text = ortegaBorrowed.ToString();   
            int fernandezBorrowed = GetTotalBorrowingsFernandez();
            fernandezborrowedLabel.Text = fernandezBorrowed.ToString();
            int sicatBorrowed = GetTotalBorrowingsSicat();
            sicatborrowedLabel.Text = sicatBorrowed.ToString();
            int colarinaBorrowed = GetTotalReservationsColarina();
            colarinaborrowedLabel.Text = colarinaBorrowed.ToString();
            int caasiBorrowed = GetTotalReservationsCassi();
            caasiborrowedLabel.Text =caasiBorrowed.ToString();





            //RESERVE
            //Calls individual borrowers and their total borrowings and reservings and sets them into corresponding variables to be used in certain labels
            int beringuelReserve = GetTotalReservationsBeringuel();
            beringuelreservedLabel.Text = beringuelReserve.ToString();
            int villenaReserve = GetTotalReservationsVillena();
            villenareserveLabel.Text = villenaReserve.ToString();
            int balaoroReserve = GetTotalReservationsBalaoro();
            balaororeserveLabel.Text = balaoroReserve.ToString();
            int hingcoReserve = GetTotalReservationsHingco();
            hingcoreserveLabel.Text =hingcoReserve.ToString();
            int faustinoReserve = GetTotalReservationsFaustino();
            faustinoreserveLabel.Text =faustinoReserve.ToString();
            int ortegaReserve = GetTotalReservationsOrtega();
            ortegareserveLabel.Text = ortegaReserve.ToString();
            int fernandezReserve = GetTotalReservationsFernandez();
            fernandezreserveLabel.Text = fernandezReserve.ToString();
            int sicatReserve = GetTotalReservationsSicat();
            sicatreserveLabel.Text = sicatReserve.ToString();
            int colarinaReserve = GetTotalReservationsColarina();
            colarinareserveLabel.Text = colarinaReserve.ToString(); 
            int caasiReserve = GetTotalReservationsCassi();
            caasireserveLabel.Text = caasiReserve.ToString();


            //TEACHERS
            //BORROWED
            int planBorrowed = GetTotalBorrowingsPlan();
            planborrowedLabel.Text = planBorrowed.ToString();
            int diampocBorrowed = GetTotalBorrowingsDiampoc();
            diampocborrowedLabel.Text = diampocBorrowed.ToString();
            int dellosaBorrowed = GetTotalBorrowingsDellosa();
            dellosaborrowedLabel.Text= dellosaBorrowed.ToString();

            //RESERVE
            int planReserve = GetTotalReservationsPlan();
            planreserveLabel.Text = planReserve.ToString();
            int diampocReserve = GetTotalReservationsDiampoc();
            diampocreserveLabel.Text= diampocReserve.ToString();
            int dellosaReserve = GetTotalReservationsDellosa();
            dellosareserveLabel.Text = dellosaReserve.ToString();

        }




        //METHOD FOR FETCHING VALUES FOR EACH BORROWERS


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
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12043456";

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
        private int GetTotalBorrowingsBalaoro()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12042342";

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
        private int GetTotalBorrowingsHingco()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12042345";

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
        private int GetTotalBorrowingsFaustino()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12021321";

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
        private int GetTotalBorrowingsOrtega()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12021327";

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

        private int GetTotalBorrowingsFernandez()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12042649";

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
        private int GetTotalBorrowingsSicat()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12032131";

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
        private int GetTotalBorrowingsColarina()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12042346";

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
        private int GetTotalBorrowingsCaasi()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12043567";

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
        private int GetTotalReservationsVillena()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12043456";

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
        private int GetTotalReservationsBalaoro()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12042342";

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
        private int GetTotalReservationsHingco()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12042345";

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
        private int GetTotalReservationsFaustino()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12021321";

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
        private int GetTotalReservationsOrtega()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12021327";

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
        private int GetTotalReservationsFernandez()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12042649";

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
        private int GetTotalReservationsSicat()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12032131";

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
        private int GetTotalReservationsColarina()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12042346";

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
        private int GetTotalReservationsCassi()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12043567";

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


        //TEACHERS
        //BORROWINGS
        private int GetTotalBorrowingsPlan()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12052345";

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
        private int GetTotalBorrowingsDiampoc()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12052385";

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
        private int GetTotalBorrowingsDellosa()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of borrowings
                    string query = "SELECT COUNT(*) FROM borrowings WHERE user_id = 12048547";

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
        private int GetTotalReservationsPlan()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12052345";

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
        private int GetTotalReservationsDiampoc()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to get the total number of reservations
                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12052385";

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
        private int GetTotalReservationsDellosa()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM reservations WHERE borrower_id = 12048547";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
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

        bool upperlabelExpand = false;
        private void upperlabelTransition_Tick(object sender, EventArgs e)
        {
            const int targetExpandedWidth = 418;
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

        private void borrowerLabel_Click(object sender, EventArgs e)
        {
            //BORROWINGS
            //Calls individual borrowers and their total borrowings and reservings and sets them into corresponding variables to be used in certain labels
            int beringuelBorrowed = GetTotalBorrowingsBeringuel();
            beringuelborrowLabel.Text = beringuelBorrowed.ToString();
            int villenaBorrowed = GetTotalBorrowingsVillena();
            villenaborrowedLabel.Text = villenaBorrowed.ToString();
            int balaoroBorrowed = GetTotalBorrowingsBalaoro();
            balaoroborrowedLabel.Text = balaoroBorrowed.ToString();
            int hingcoBorrowed = GetTotalBorrowingsHingco();
            hingcoborrowedLabel.Text = hingcoBorrowed.ToString();
            int faustinoBorrowed = GetTotalBorrowingsFaustino();
            faustinoborrowedLabel.Text = faustinoBorrowed.ToString();
            int ortegaBorrowed = GetTotalBorrowingsOrtega();
            ortegaborrowedLabel.Text = ortegaBorrowed.ToString();
            int fernandezBorrowed = GetTotalBorrowingsFernandez();
            fernandezborrowedLabel.Text = fernandezBorrowed.ToString();
            int sicatBorrowed = GetTotalBorrowingsSicat();
            sicatborrowedLabel.Text = sicatBorrowed.ToString();
            int colarinaBorrowed = GetTotalReservationsColarina();
            colarinaborrowedLabel.Text = colarinaBorrowed.ToString();
            int caasiBorrowed = GetTotalReservationsCassi();
            caasiborrowedLabel.Text = caasiBorrowed.ToString();





            //RESERVE
            //Calls individual borrowers and their total borrowings and reservings and sets them into corresponding variables to be used in certain labels
            int beringuelReserve = GetTotalReservationsBeringuel();
            beringuelreservedLabel.Text = beringuelReserve.ToString();
            int villenaReserve = GetTotalReservationsVillena();
            villenareserveLabel.Text = villenaReserve.ToString();
            int balaoroReserve = GetTotalReservationsBalaoro();
            balaororeserveLabel.Text = balaoroReserve.ToString();
            int hingcoReserve = GetTotalReservationsHingco();
            hingcoreserveLabel.Text = hingcoReserve.ToString();
            int faustinoReserve = GetTotalReservationsFaustino();
            faustinoreserveLabel.Text = faustinoReserve.ToString();
            int ortegaReserve = GetTotalReservationsOrtega();
            ortegareserveLabel.Text = ortegaReserve.ToString();
            int fernandezReserve = GetTotalReservationsFernandez();
            fernandezreserveLabel.Text = fernandezReserve.ToString();
            int sicatReserve = GetTotalReservationsSicat();
            sicatreserveLabel.Text = sicatReserve.ToString();
            int colarinaReserve = GetTotalReservationsColarina();
            colarinareserveLabel.Text = colarinaReserve.ToString();
            int caasiReserve = GetTotalReservationsCassi();
            caasireserveLabel.Text = caasiReserve.ToString();


            //TEACHERS
            //BORROWED
            int planBorrowed = GetTotalBorrowingsPlan();
            planborrowedLabel.Text = planBorrowed.ToString();
            int diampocBorrowed = GetTotalBorrowingsDiampoc();
            diampocborrowedLabel.Text = diampocBorrowed.ToString();
            int dellosaBorrowed = GetTotalBorrowingsDellosa();
            dellosaborrowedLabel.Text = dellosaBorrowed.ToString();

            //RESERVE
            int planReserve = GetTotalReservationsPlan();
            planreserveLabel.Text = planReserve.ToString();
            int diampocReserve = GetTotalReservationsDiampoc();
            diampocreserveLabel.Text = diampocReserve.ToString();
            int dellosaReserve = GetTotalReservationsDellosa();
            dellosareserveLabel.Text = dellosaReserve.ToString();
        }
    }
}
