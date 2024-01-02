using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            updateTimer.Interval = 60000;
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();

            // List of book titles
            List<string> bookTitles = new List<string>
            {
                 "To Kill a Mockingbird",
                 "1984",
                 "Pride and Prejudice",
                 "The Great Gatsby",
                 "One Hundred Years of Solitude",
                 "Sapiens: A Brief History of Humankind",
                 "The Immortal Life of Henrietta Lacks",
                 "Educated",
                 "The Diary of a Young Girl",
                 "Thinking, Fast and Slow"
             };

            // Fetch information for each book title
            foreach (string bookTitle in bookTitles)
            {
                FetchBookInformation(bookTitle);
            }

            //default visibility for bookinfoflowpanel
            bookinfoflowPanel.Visible = false;


            // Load custom font
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            //privateFonts.AddFontFile("C://Users//USER//source//repos//LibrarySystem//fonts//titles//playfair-display-font//PlayfairDisplayBold-nRv8g.ttf");

            // Create a Font object
            //Font customFont = new Font(privateFonts.Families[0], 33); // Use the appropriate size

            // Set the label's font
            //booklistLabel.Font = customFont;
            

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
            }
            else if (title.Trim().Equals("1984", StringComparison.OrdinalIgnoreCase))
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
            else if (title.Trim().Equals("Pride and Prejudice", StringComparison.OrdinalIgnoreCase))
            {
                pridestatsLbl.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    pridestatsLbl.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    pridestatsLbl.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    pridestatsLbl.ForeColor = Color.DodgerBlue;
                    pridestatsLbl.Text = availability.ToUpper();

                }
            }
            else if (title.Trim().Equals("The Great Gatsby", StringComparison.OrdinalIgnoreCase))
            {
                gatsbystatsLbl.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    gatsbystatsLbl.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    gatsbystatsLbl.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    gatsbystatsLbl.ForeColor = Color.DodgerBlue;
                    gatsbystatsLbl.Text = availability.ToUpper();

                }
            }
            else if (title.Trim().Equals("One Hundred Years of Solitude", StringComparison.OrdinalIgnoreCase))
            {
                solitudestatsLbl.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    solitudestatsLbl.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    solitudestatsLbl.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    solitudestatsLbl.ForeColor = Color.DodgerBlue;
                    solitudestatsLbl.Text = availability.ToUpper();

                }
            }
            else if (title.Trim().Equals("Sapiens: A Brief History of Humankind", StringComparison.OrdinalIgnoreCase))
            {
                sapiensstatsLabel.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    sapiensstatsLabel.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    sapiensstatsLabel.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    sapiensstatsLabel.ForeColor = Color.DodgerBlue;
                    sapiensstatsLabel.Text = availability.ToUpper();

                }
            }
            else if (title.Trim().Equals("The Immortal Life of Henrietta Lacks", StringComparison.OrdinalIgnoreCase))
            {
                immortalstatsLabel.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    immortalstatsLabel.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    immortalstatsLabel.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    immortalstatsLabel.ForeColor = Color.DodgerBlue;
                    immortalstatsLabel.Text = availability.ToUpper();

                }
            }
            else if (title.Trim().Equals("Educated", StringComparison.OrdinalIgnoreCase))
            {
                educatedstatsLbl.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    educatedstatsLbl.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    educatedstatsLbl.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    educatedstatsLbl.ForeColor = Color.DodgerBlue;
                    educatedstatsLbl.Text = availability.ToUpper();

                }
            }
            else if (title.Trim().Equals("The Diary of a Young Girl", StringComparison.OrdinalIgnoreCase))
            {
                diarystatsLabel.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    diarystatsLabel.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    diarystatsLabel.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    diarystatsLabel.ForeColor = Color.DodgerBlue;
                    diarystatsLabel.Text = availability.ToUpper();
                }
            }
            else if (title.Trim().Equals("Thinking, Fast and Slow", StringComparison.OrdinalIgnoreCase))
            {
                thinkingstatsLabel.Text = availability;

                // Set ForeColor based on availability
                if (availability.Equals("BORROWED", StringComparison.OrdinalIgnoreCase))
                {
                    thinkingstatsLabel.ForeColor = Color.DarkGreen;
                }
                else if (availability.Equals("RESERVED", StringComparison.OrdinalIgnoreCase))
                {
                    thinkingstatsLabel.ForeColor = Color.Brown;
                }
                else if (availability.Equals("AVAILABLE", StringComparison.OrdinalIgnoreCase))
                {
                    thinkingstatsLabel.ForeColor = Color.DodgerBlue;
                    thinkingstatsLabel.Text = availability.ToUpper();
                }
            }
            else
                    {
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
            fictionPanel.Location = new Point(36, 106);
            nonfictionPanel.Location = new Point(36, 359);
            academicPanel.Location = new Point(36, 614);
            fictionTransition2.Start();
            nonficTransition.Start();
            acadTransition.Start();
            bookinfoflowPanel.Visible = false;
          
        }

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
            nonfictionPanel.Location = new Point(36, 106);
            academicPanel.Location = new Point(36, 359);
            fictionPanel.Location = new Point(36, 614);
            fictionTransition.Start();
            nonficTransition2.Start();
            acadTransition.Start();
            bookinfoflowPanel.Visible = false;
            
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
            academicPanel.Location = new Point(36, 106);
            fictionPanel.Location = new Point(36, 359);
            nonfictionPanel.Location = new Point(36, 614);
            fictionTransition.Start();
            nonficTransition.Start();
            acadTransition2.Start();
            bookinfoflowPanel.Visible = false;
         
        }

        //BOOKINFO TRANSITION
        bool bookinfoCurtain = false;
        private void bookinfoTransition_Tick(object sender, EventArgs e)
        {
            const int targetExpandedHeight = 352;
            const int targetCollapsedHeight = 10;
            const int step = 200;

            if (!bookinfoCurtain)
            {
                // Expanding
                bookinfoflowPanel.Height += step;
                if (bookinfoflowPanel.Height >= targetExpandedHeight)
                {
                    bookinfoflowPanel.Height = targetExpandedHeight;
                    bookinfoTransition.Stop();
                    bookinfoCurtain = true;
                }
            }
            else
            {
                // Collapsing
                bookinfoflowPanel.Height -= step;
                if (bookinfoflowPanel.Height <= targetCollapsedHeight)
                {
                    bookinfoflowPanel.Height = targetCollapsedHeight;
                    bookinfoTransition.Stop();
                    bookinfoCurtain = false;
                    bookinfoflowPanel.Visible = false;
                }
            }
        }
        
        //FICTION BOOK BUTTONS
        private void mockingbirdBtn_Click_1(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;


            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//mockingbirdbookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users//USER//source//repos//LibrarySystem//images//mockingRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "To Kill a Mocking Bird\r\n\r\nTo Kill a Mockingbird is a novel by the American author Harper Lee. It was published in 1960 and was instantly successful. In the United States, it is widely read in high schools and middle schools. To Kill a Mockingbird has become a classic of modern American literature; a year after its release, it won the Pulitzer Prize. ";
        }

        private void prideBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//pridebookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users//USER//source//repos//LibrarySystem//images//prideRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "Pride and Prejudice \r\n\r\nPride and Prejudice is the second novel by English author Jane Austen, published in 1813. A novel of manners, it follows the character development of Elizabeth Bennet, the protagonist of the book.";
        }

        private void Btn1984_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//1984bookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users//USER//source//repos//LibrarySystem//images//1984Rating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "Nineteen Eighty-Four\r\n\r\nNineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation.";
        }

        private void gatsbyBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//gatsbybookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//gatsbyRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "The Great Gatsby\r\n\r\nThe Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan. ";

        }

        private void solitudeBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//solitudebookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//solitudeRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "One Hundred Years of Solitude\r\n\r\nOne Hundred Years of Solitude is a 1967 novel by Colombian author Gabriel García Márquez that tells the multi-generational story of the Buendía family, whose patriarch, José Arcadio Buendía, founded the fictitious town of Macondo. The novel is often cited as one of the supreme achievements in world literature.";
        }

        //NON FICTION BOOK BUTTONS
        private void sapiensBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//sapiensbookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//sapiensRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "A Brief History of Humankind\r\n\r\nSapiens: A Brief History of Humankind is a book by Yuval Noah Harari, first published in Hebrew in Israel in 2011 based on a series of lectures Harari taught at The Hebrew University of Jerusalem, and in English in 2014.";
        }

        private void immortalBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//immortalbookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//immortalRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "The Immortal Life of Henrietta Lacks\r\n\r\n The Immortal Life of Henrietta Lacks (2010) is a non-fiction book by American author Rebecca Skloot. It was the 2011 winner of the National Academies Communication Award for best creative work that helps the public understanding of topics in science, engineering or medicine.";
       
        }

        private void diaryBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//diarybookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//diaryRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "The Diary of a Young Girl\r\n\r\n\r\n The Diary of a Young Girl, often referred to as The Diary of Anne Frank, is a book of the writings from the Dutch-language diary kept by Anne Frank while she was in hiding for two years with her family during the Nazi occupation of the Netherlands. The family was apprehended in 1944, and Anne Frank died of typhus in the Bergen-Belsen concentration camp in 1945.";
        }


        private void thinkingBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//thinkingbookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//thinkingRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "Thinking, Fast and Slow\r\n\r\n\r\n Thinking, Fast and Slow is a 2011 popular science book by psychologist Daniel Kahneman. The book's main thesis is a differentiation between two modes of thought: \"System 1\" is fast, instinctive and emotional; \"System 2\" is slower, more deliberative, and more logical.";
        }

        private void educatedBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//educatedbookInfo.png";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//educatedRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "Educated\r\n\r\n\r\n Educated (2018) is a memoir by the American author Tara Westover. Westover recounts overcoming her survivalist Mormon family in order to go to college, and emphasizes the importance of education in enlarging her world.";
        }

        //ACADEMIC BOOK BUTTONS
        private void briefBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//briefbookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//briefRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "A Brief History of Time: From the Big Bang to Black Holes\r\n\r\n\r\n It is a book on theoretical cosmology by English physicist Stephen Hawking. It was first published in 1988. Hawking wrote the book for readers who had no prior knowledge of physics.\r\n\r\nIn A Brief History of Time, Hawking writes in non-technical terms about the structure, origin, development and eventual fate of the Universe, which is the object of study of astronomy and modern physics. He talks about basic concepts like space and time, basic building blocks that make up the Universe (such as quarks) and the fundamental forces that govern it (such as gravity). ";
       
        }

        private void elementsBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//elementsbookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//briefRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "The Elements Of Style\r\n\r\n\r\n The Elements of Style is a style guide to writing American English, published in numerous editions. The original was written by William Strunk Jr. in 1918, and published by Harcourt in 1920, comprising eight \"elementary rules of usage,\" ten \"elementary principles of composition,\" \"a few matters of form,\" a list of 49 \"words and expressions commonly misused,\" and a list of 57 \"words often misspelled.\" Writer and editor E. B. White greatly enlarged and revised the book for publication by Macmillan in 1959. That was the first edition of the so-called Strunk & White, which Time recognized in 2011 as one of the 100 best and most influential books written in English since 1923";
       
        }

        private void principiaBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//principiabookInfo.png";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//principiaRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "Principia Mathematica\r\n\r\n\r\n Philosophiæ Naturalis Principia Mathematica (English: The Mathematical Principles of Natural Philosophy) often referred to as simply the Principia, is a book by Isaac Newton that expounds Newton's laws of motion and his law of universal gravitation. The Principia is written in Latin and comprises three volumes, and was first published on 5 July 1687.The Principia is considered one of the most important works in the history of science.The French mathematical physicist Alexis Clairaut assessed it in 1747: \"The famous book of Mathematical Principles of Natural Philosophy marked the epoch of a great revolution in physics.";
       
        }

        private void structureBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//structurebookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//structuresRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "The Structure of Scientific Revolutions\r\n\r\n\r\n The Structure of Scientific Revolutions is a book about the history of science by philosopher Thomas S. Kuhn. Its publication was a landmark event in the history, philosophy, and sociology of science. Kuhn challenged the then prevailing view of progress in science in which scientific progress was viewed as \"development-by-accumulation\" of accepted facts and theories. Kuhn argued for an episodic model in which periods of conceptual continuity where there is cumulative progress, which Kuhn referred to as periods of \"normal science\", were interrupted by periods of revolutionary science.";
       
        }

        private void originBtn_Click(object sender, EventArgs e)
        {
            bookinfoTransition.Start();
            bookinfoflowPanel.Visible = true;

            //FOR THE BOOK COVER
            string imagePath1 = "C://Users//USER//source//repos//LibrarySystem//images//originbookInfo.jpg";
            try
            {
                bookinfoImage.Image = new System.Drawing.Bitmap(imagePath1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // FOR THE RATING
            string imagePath2 = "C://Users/USER//source//repos//LibrarySystem//images//structuresRating.png";
            try
            {
                bookinfoLabel.Image = Image.FromFile(imagePath2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Image Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Text for the label
            bookinfoLabel.Text = "On the Origin of Species \r\n\r\n On the Origin of Species (or, more completely, On the Origin of Species by Means of Natural Selection, or the Preservation of Favoured Races in the Struggle for Life) is a work of scientific literature by Charles Darwin that is considered to be the foundation of evolutionary biology; it was published on 24 November 1859. Darwin's book introduced the scientific theory that populations evolve over the course of generations through a process of natural selection. The book presented a body of evidence that the diversity of life arose by common descent through a branching pattern of evolution. ";
        }

        private void bookinfoflowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void booklistLabel_Click(object sender, EventArgs e)
        {
            fictionPanel.Location = new Point(36, 106);
            nonfictionPanel.Location = new Point(36, 359);
            academicPanel.Location = new Point(36, 614);
            fictionTransition2.Start();
            nonficTransition2.Start();
            acadTransition2.Start();
            bookinfoflowPanel.Visible = false;

        }
    }


}
