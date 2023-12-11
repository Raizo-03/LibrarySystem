using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using ReaLTaiizor.Controls;


namespace LibrarySystem
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
    );

        public Dashboard()
        {
            InitializeComponent();

            //make the edges more round
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4
            //upperPanel.BackColor = Color.FromArgb(176, 146, 106, 106); // CUSTOM UPPER PANEL #B0926A

            //UPPER PANEL COLOR
            upperPanel.BackColor = Color.Transparent; // Make the upper panel transparent
            // Attach the Paint event to handle custom painting for the upper panel
            upperPanel.Paint += UpperPanel_Paint;

            //Disable the maximize/Minimize button
            dashboardControlbx.EnableMaximizeButton = false;

            //SIDE PANEL COLOR
            dashboardFlowPnl.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            //dashboardFlowPnl.Paint += dashboardFlowPnl_Paint;

            //PANEL BUTTONS
            dashboardBtn.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            dashboardBtn2.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            aboutBtn.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            aboutBtn2.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            exitBtn.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            exitBtn2.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            dashboardbackPnl.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            booklistBtn.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            booklistBtn2.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            borrowBtn.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            borrowBtn2.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            returnBtn.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            returnBtn2.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            reserveBtn.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            reserveBtn2.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);

        }

        //GRADIENT FOR UPPERPANEL
        private void UpperPanel_Paint(object sender, PaintEventArgs e)
        {
            // Create a LinearGradientBrush for the upper panel
            using (LinearGradientBrush brush = new LinearGradientBrush(
                upperPanel.ClientRectangle,
                Color.FromArgb(0xB0, 0x92, 0x6A),
                Color.Transparent, // Use Transparent to allow the form's background to show through
                LinearGradientMode.Vertical))
            {
                // Paint the upper panel with the gradient background
                e.Graphics.FillRectangle(brush, upperPanel.ClientRectangle);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nightControlBox1_Click_1(object sender, EventArgs e)
        {
          System.Windows.Forms.Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
