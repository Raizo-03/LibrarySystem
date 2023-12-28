using Microsoft.VisualBasic.ApplicationServices;
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
            fictionPanel.Location = new Point(47, 115);
            nonfictionPanel.Location = new Point(47, 368);
            academicPanel.Location = new Point(47, 623);
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
            nonfictionPanel.Location = new Point(47, 115);
            academicPanel.Location = new Point(47, 368);
            fictionPanel.Location = new Point(47, 623);
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

        private void booklistLlbl_Click(object sender, EventArgs e)
        {
            fictionPanel.Location = new Point(47, 115);
            nonfictionPanel.Location = new Point(47, 368);
            academicPanel.Location = new Point(47, 623);
            fictionTransition2.Start();
            nonficTransition2.Start();
            acadTransition2.Start();
            bookinfoflowPanel.Visible = false;
            
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
            bookinfoLabel.Text = "To Kill a Mocking Bird\r\n\r\nTo Kill a Mockingbird is a novel by the American author Harper Lee. It was published in 1960 and was instantly successful. In the United States, it is widely read in high schools and middle schools. To Kill a Mockingbird has become a classic of modern American literature; a year after its release, it won the Pulitzer Prize. The plot and characters are loosely based on Lee's observations of her family, her neighbors and an event that occurred near her hometown of Monroeville, Alabama, in 1936, when she was ten.";

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
            bookinfoLabel.Text = "Pride and Prejudice \r\n\r\nPride and Prejudice is the second novel by English author Jane Austen, published in 1813. A novel of manners, it follows the character development of Elizabeth Bennet, the protagonist of the book, who learns about the repercussions of hasty judgments and comes to appreciate the difference between superficial goodness and actual goodness.";


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
            bookinfoLabel.Text = "Nineteen Eighty-Four\r\n\r\nNineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany. More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.";

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
            bookinfoLabel.Text = "The Great Gatsby\r\n\r\nThe Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan.\r\n\r\nThe novel was inspired by a youthful romance Fitzgerald had with socialite Ginevra King, and the riotous parties he attended on Long Island's North Shore in 1922. Following a move to the French Riviera, Fitzgerald completed a rough draft of the novel in 1924. He submitted it to editor Maxwell Perkins, who persuaded Fitzgerald to revise the work over the following winter.";


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
            bookinfoLabel.Text = "One Hundred Years of Solitude\r\n\r\nOne Hundred Years of Solitude is a 1967 novel by Colombian author Gabriel García Márquez that tells the multi-generational story of the Buendía family, whose patriarch, José Arcadio Buendía, founded the fictitious town of Macondo. The novel is often cited as one of the supreme achievements in world literature.\r\n\r\nThe magical realist style and thematic substance of One Hundred Years of Solitude established it as an important representative novel of the literary Latin American Boom of the 1960s and 1970s, which was stylistically influenced by Modernism (European and North American) and the Cuban Vanguardia (Avant-Garde) literary movement.";

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
            bookinfoLabel.Text = "A Brief History of Humankind\r\n\r\nSapiens: A Brief History of Humankind is a book by Yuval Noah Harari, first published in Hebrew in Israel in 2011 based on a series of lectures Harari taught at The Hebrew University of Jerusalem, and in English in 2014.The book, focusing on Homo sapiens, surveys the history of humankind, starting from the Stone Age and going up to the twenty-first century. The account is situated within a framework that intersects the natural sciences with the social sciences.";
        
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
            bookinfoLabel.Text = "The Immortal Life of Henrietta Lacks\r\n\r\n The Immortal Life of Henrietta Lacks (2010) is a non-fiction book by American author Rebecca Skloot. It was the 2011 winner of the National Academies Communication Award for best creative work that helps the public understanding of topics in science, engineering or medicine.The book is about Henrietta Lacks and the immortal cell line, known as HeLa, that came from Lacks's cervical cancer cells in 1951. Skloot became interested in Lacks after a biology teacher referenced her but knew little about her. Skloot began conducting extensive research on her and worked with Lacks' family to create the book.";
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
            bookinfoLabel.Text = "The Diary of a Young Girl\r\n\r\n\r\n The Diary of a Young Girl, often referred to as The Diary of Anne Frank, is a book of the writings from the Dutch-language diary kept by Anne Frank while she was in hiding for two years with her family during the Nazi occupation of the Netherlands. The family was apprehended in 1944, and Anne Frank died of typhus in the Bergen-Belsen concentration camp in 1945. Anne's diaries were retrieved by Miep Gies and Bep Voskuijl. Miep gave them to Anne's father, Otto Frank, the family's only survivor, just after the Second World War was over.";
       
        }


        private void thinkingBtn_Click(object sender, EventArgs e)
        {

        }

        private void educatedBtn_Click(object sender, EventArgs e)
        {

        }

        //ACADEMIC BOOK BUTTONS
        private void briefBtn_Click(object sender, EventArgs e)
        {

        }

        private void elementsBtn_Click(object sender, EventArgs e)
        {

        }

        private void principiaBtn_Click(object sender, EventArgs e)
        {

        }

        private void structureBtn_Click(object sender, EventArgs e)
        {

        }

        private void originBtn_Click(object sender, EventArgs e)
        {

        }

        private void bookinfoflowPanel_Paint(object sender, PaintEventArgs e)
        {

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
