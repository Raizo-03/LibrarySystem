using Microsoft.VisualBasic.ApplicationServices;
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


        // Add properties for user detail
        public string UserName { get; private set; }
        public string UserID { get; private set; }
        public string UserDepartment { get; private set; }
        public string availability { get; private set; }

        private List<Book> books = new List<Book>();
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

    public class Book
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; }

    }
}
