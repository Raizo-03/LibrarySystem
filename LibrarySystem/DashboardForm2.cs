﻿using System;
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
    public partial class DashboardForm2 : Form
    {
        private string identifier;
        private string name;
        private string ID;
        private string book1, book2, book3, book4, book5;
        private int booklimit;

        public DashboardForm2(string Identifier, string Name, string iD, int Booklimit, String BOOK1, String BOOK2, String BOOK3, String BOOK4, String BOOK5)
        {
            InitializeComponent();
            this.identifier = Identifier;
            this.name = Name;
            this.ID = iD;
            this.booklimit = Booklimit;
            this.book1 = BOOK1;
            this.book2 = BOOK2;
            this.book3 = BOOK3;
            this.book4 = BOOK4;
            this.book5 = BOOK5;

            nameLabel.Text = Name;
            idLabel.Text = iD;
            identifierLabel.Text = Identifier;


            borrowedlabel1.Text = book1;
            borrowedLabel2.Text = book2;
            borrowedLabel3.Text = book3;
            borrowedLabel4.Text = book4;
            borrowedLabel5.Text = book5;

            int integerValue1 = int.Parse(availableLabel.Text);

            if (borrowedlabel1.Text != null)
            {
                // Pre-decrement the value
                int newvalue = --integerValue1;

                // Convert the decremented integer to a string
                string newavailnum1 = newvalue.ToString();

                // Update the availableLabel.Text with the new value
                availableLabel.Text = newavailnum1;
            }


        }

        private void DashboardForm2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
