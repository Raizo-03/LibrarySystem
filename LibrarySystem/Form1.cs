using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace LibrarySystem
{
    public partial class FirstForm : Form
    {
 
        public FirstForm()
        {
            InitializeComponent();
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM COLORS #FDF7E4
            

            // Handle the button click event

        }

      


        private void nightControlBox1_Click(object sender, EventArgs e)
        {

            // Disable the maximize/Minimize button
            nightControlBox1.EnableMaximizeButton = false;

            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {


        }

    }
}
