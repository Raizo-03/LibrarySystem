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
using static LibrarySystem.FirstForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace LibrarySystem
{
    public partial class Dashboard : Form
    {
        DashboardForm2 dashboard2;
        BooklistForm booklist;
        BorrowForm borrow;
        ReturnForm returnForm;
        ReserveForm reserve;
        AboutForm about;
        BorrowerList borrowerList;
        // Fields to store user information
        private string USERName;
        private string USERID;
        private string DEPARTMENT;
        private int BOOKLIMIT;

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

        public Dashboard(string userName, string userId, string department, int bookLimit)
        {
            InitializeComponent();
            
            //make the edges more round
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.BOOKLIMIT = bookLimit;
            /*
            userName = USERName;
            userId = USERID;
            */
            // Use this information as needed in the Dashboard form
            // For example, update labels or perform other actions
            userNameLabel.Text = $"{userName}";
            userIDLabel.Text = $"{userId}";
            departmentLabel.Text = $"{department}";
            //bookLimitLabel.Text = $"Book Limit: {bookLimit}";
            //bookLimit = bookLimit;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4
            //upperPanel.BackColor = Color.FromArgb(176, 146, 106, 106); // CUSTOM UPPER PANEL #B0926A

            //UPPER PANEL COLOR
            upperPanel.BackColor = Color.FromArgb(0xB1, 0x92, 0x6A);  // Make the upper panel transparent
            // Attach the Paint event to handle custom painting for the upper panel
            //upperPanel.Paint += UpperPanel_Paint;

            //Disable the maximize/Minimize button
            dashboardControlbx.EnableMaximizeButton = false;

            //SIDE PANEL COLOR
            dashboardFlowPnl.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            //dashboardFlowPnl.Paint += dashboardFlowPnl_Paint;

            //PANEL BUTTONS
            dashboardBtn.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            reserveBtn2.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            aboutBtn.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            aboutBtn2.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
           

            
            dashboardbackPnl.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            booklistBtn.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            booklistBtn2.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            borrowBtn.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            borrowBtn2.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            returnBtn.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            returnBtn2.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            reserveBtn.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            reserveBtn2.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            borrowerlistBtn.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            borrowerlistBtn2.BackColor = Color.FromArgb(0xF5, 0xE3, 0xB5);
            logoutBtn.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);
            logoutBtn2.BackColor = Color.FromArgb(0xF1, 0xD6, 0xAB);

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
            dashboardTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {

        }

        private void dashboardTransition_Tick(object sender, EventArgs e)
        {

        }

        private void booklistBtn_Click(object sender, EventArgs e)
        {

        }
        //RESERVE BUTTON
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (reserve == null)
            {
                reserve = new ReserveForm();
                reserve.FormClosed += reserve_FormClosed;
                reserve.MdiParent = this;
                reserve.Dock = DockStyle.Fill;
                reserve.Show();
            }
            else
            {
                reserve.Activate();
            }
        }
        private void reserve_FormClosed(object sender, FormClosedEventArgs e)
        {
            returnForm = null;
        }

        //RETURN BUTTON
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (returnForm == null)
            {
                returnForm = new ReturnForm();
                returnForm.FormClosed += return_FormClosed;
                returnForm.MdiParent = this;
                returnForm.Dock = DockStyle.Fill;
                returnForm.Show();
            }
            else
            {
                returnForm.Activate();
            }
        }
        private void return_FormClosed(object sender, FormClosedEventArgs e)
        {
            returnForm = null;
        }

        //BURGER TRANSITION
        bool dashboardExpand = false;
        private void burgerTransition_Tick(object sender, EventArgs e)
        {
            const int targetExpandedWidth = 220;
            const int targetCollapsedWidth = 71;
            const int step = 20;

            if (!dashboardExpand)
            {
                // Expanding
                dashboardFlowPnl.Width += step;
                if (dashboardFlowPnl.Width >= targetExpandedWidth)
                {
                    dashboardFlowPnl.Width = targetExpandedWidth;
                    burgerTransition.Stop();
                    dashboardExpand = true;
                }
            }
            else
            {
                // Collapsing
                dashboardFlowPnl.Width -= step;
                if (dashboardFlowPnl.Width <= targetCollapsedWidth)
                {
                    dashboardFlowPnl.Width = targetCollapsedWidth;
                    burgerTransition.Stop();
                    dashboardExpand = false;
                }
            }
        }

        //DASHBOARD BUTTON
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardTransition.Start();
            if (dashboard2 == null)
            {
                dashboard2 = new DashboardForm2();
                dashboard2.FormClosed += dashboard2_FormClosed;
                dashboard2.MdiParent = this;
                dashboard2.Dock = DockStyle.Fill;
                dashboard2.Show();
            }
            else
            {
                dashboard2.Activate();
            }


        }

        private void dashboard2_FormClosed(object sender, EventArgs e)
        {
            dashboard2 = null;
        }



        //DASHBOARD TRANSITION
        bool menuExpand = false;
        private void dashboardTransition_Tick_1(object sender, EventArgs e)
        {
            const int targetExpandedHeight = 420;
            const int targetCollapsedHeight = 65;
            const int step = 200;

            if (!menuExpand)
            {
                // Expanding
                dashboardbackPnl.Height += step;
                if (dashboardbackPnl.Height >= targetExpandedHeight)
                {
                    dashboardbackPnl.Height = targetExpandedHeight;
                    dashboardTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                // Collapsing
                dashboardbackPnl.Height -= step;
                if (dashboardbackPnl.Height <= targetCollapsedHeight)
                {
                    dashboardbackPnl.Height = targetCollapsedHeight;
                    dashboardTransition.Stop();
                    menuExpand = false;
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            burgerTransition.Start();
        }

        //BOOK LIST BUTTON
        private void booklistBtn_Click_1(object sender, EventArgs e)
        {
            if(booklist == null)
            {
                booklist = new BooklistForm(USERName, USERID, DEPARTMENT);
                booklist.FormClosed += booklist_FormClosed;
                booklist.MdiParent = this;
                booklist.Dock = DockStyle.Fill;
                booklist.Show();
            }
            else
            {
                booklist.Activate();
            }
        }

        private void booklist_FormClosed(object sender, FormClosedEventArgs e)
        {
            booklist = null;
        }

        //BORROW BUTTON
        private void borrowBtn_Click(object sender, EventArgs e)
        {
            int limit = BOOKLIMIT;
            if (borrow == null)
            {
                borrow = new BorrowForm(limit);
                borrow.FormClosed += borrow_FormClosed;
                borrow.MdiParent = this;
                borrow.Dock = DockStyle.Fill;
                borrow.Show();
            }
            else
            {
                borrow.Activate();
            }
        }
        private void borrow_FormClosed(object sender, FormClosedEventArgs e)
        {
            booklist = null;
        }

        private void aboutBtn_Click_1(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new AboutForm();
                about.FormClosed += about_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }
        private void about_FormClosed(object sender, FormClosedEventArgs e)
        {
            booklist = null;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dashboardbackPnl_Paint(object sender, PaintEventArgs e)
        {

        }


        private void borrowerlistBtn_Click(object sender, EventArgs e)
        {
            if (borrowerList == null)
            {
                borrowerList = new BorrowerList();
                borrowerList.FormClosed += borrowerList_FormClosed;
                borrowerList.MdiParent = this;
                borrowerList.Dock = DockStyle.Fill;
                borrowerList.Show();
            }
            else
            {
                borrowerList.Activate();
            }
        }
        private void borrowerList_FormClosed(object sender, FormClosedEventArgs e)
        {
            borrowerList = null;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            String name = userNameLabel.Text;
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show($"Are you sure you want to log out {name}?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                // Perform logout actions
                // For example, close the current form and show the login form
                this.Close();

                // Assuming LoginForm is the name of your login form
                FirstForm loginForm = new FirstForm();
                loginForm.Show();
            }
            // If the user clicks "No", do nothing and keep the user in the current state
        }
    }
}
