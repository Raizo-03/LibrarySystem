using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibrarySystem
{
    public partial class DashboardForm2 : Form
    {
        private string identifier, name, id;

        // FOR DATABASE
        private string connectionString = "Server=localhost;Database=librarysystem;Uid=root;Pwd='';";

        public DashboardForm2(string Identifier, string Name, string Id)
        {
            InitializeComponent();
            this.identifier = Identifier;
            this.Name = Name;
            this.id = Id;
        }

        private void DashboardForm2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); // CUSTOM BG COLORS #FDF7E4
            nameLabel.Text = "ADMIN";

            int totalAvailableBooks = GetTotalAvailableBooks();
            availableLabel.Text = $"{totalAvailableBooks}";



            //FONTS 
            // TITLES
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("C://Users//USER//source//repos//LibrarySystem//fonts//titles//playfair-display-font//PlayfairDisplayBold-nRv8g.ttf");

            // Create a Font object
            Font customFont = new Font(privateFonts.Families[0], 33); // Use the appropriate size

            // Set the label's font
            nameLabel.Font = customFont;
            hellolabel.Font = customFont;



        }

       

        private int GetTotalAvailableBooks()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to get the total number of available books
                string query = "SELECT COUNT(*) FROM books WHERE availability = 'AVAILABLE'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // ExecuteScalar is used to get a single value from the query result
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
    }
}