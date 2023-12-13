using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static LibrarySystem.FirstForm;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.ApplicationServices;

namespace LibrarySystem
{
    public partial class FirstForm : Form
    {
        //LIST OF 10 STUDENT USERS
        private List<Stud> studentUsers = new List<Stud>
        {
            new Stud("K12043456", "1234", "Eduardo Buscato", "Second Year", "ACSAD")

            };
        //LIST OF 3 TEACHER USERS

        private List<Prof> profUsers = new List<Prof>
        {
            new Prof("K12043710", "1234", "Krissa Beringuel", "CCIS")
          };
        public class Stud
        {
            public Stud(string studentId, string password, string name, string yearLevel, string section)
            {
                Username = studentId;  // Set Username to StudentId
                Password = password;
                StudentId = studentId;
                Name = name;
                YearLevel = yearLevel;
                Section = section;
            }

            public string Username { get; set; }
            public string Password { get; set; }
            public string StudentId { get; set; }
            public string Name { get; set; }
            public string YearLevel { get; set; }
            public string Section { get; set; }
        }
        public class Prof
        {
            public Prof(string employeeId, string password, string name, string department)
            {
                Username = employeeId;  // Set Username to EmployeeId
                Password = password;
                EmployeeId = employeeId;
                Name = name;
                Department = department;
            }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string EmployeeId { get; set; }
            public string Department { get; set; }
        }

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

        public FirstForm()
        {
            InitializeComponent();

            //TO MAKE THE FORM ROUNDED ON EACH SIDE

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM COLORS #FDF7E4

        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

            // Disable the maximize/Minimize button
            nightControlBox1.EnableMaximizeButton = false;
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        /*
        private void proceedBtn_Click(object sender, EventArgs e)
        {
            proceedBtn.BackColor = Color.White;

            //CLOSES THE FIRST FORM
            FirstForm first = new FirstForm();

            // Assuming FirstFormInstance is an instance of the form you want to close
            this.Hide();
            // Open the second form
            Dashboard secondForm = new Dashboard();
            secondForm.Show();
            this.WindowState = FormWindowState.Normal;
        }
        */
        private void proceedBtn_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string enteredUsername = usernameBx.Text;
            string enteredPassword = passwordBx.Text;

            // Check if the entered credentials match a student user
            Stud studentUser = studentUsers.FirstOrDefault(user => user.Username == enteredUsername && user.Password == enteredPassword);

            // If the entered credentials match a student user, proceed
            if (studentUser != null)
            {
                // Do something specific for student authentication
                // For example, you might want to pass the user information to the Dashboard form
                Dashboard secondForm = new Dashboard(studentUser);
                secondForm.Show();
                this.Hide();
                this.WindowState = FormWindowState.Normal;
                return;
            }

            // Check if the entered credentials match a professor user
            Prof professorUser = profUsers.FirstOrDefault(user => user.Username == enteredUsername && user.Password == enteredPassword);

            // If the entered credentials match a professor user, proceed
            if (professorUser != null)
            {
                // Do something specific for professor authentication
                // For example, you might want to pass the user information to the Dashboard form
                Dashboard secondForm = new Dashboard(professorUser);
                secondForm.Show();
                this.Hide();
                this.WindowState = FormWindowState.Normal;
                return;
            }

            // If no matching user is found, show an error message or take appropriate action
            MessageBox.Show("Invalid username or password. Please try again.");
        }

    }
}
