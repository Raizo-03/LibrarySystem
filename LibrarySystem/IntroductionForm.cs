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
using System.Runtime.CompilerServices;

namespace LibrarySystem
{
    public partial class FirstForm : Form
    {

        //LIST OF 2 ADMINS FOR LOG INS
        private List<Stud> studentUsers = new List<Stud>
        {
            new Stud("STUDENT", "ADMIN1", "1234", "Admin 1", "Second Year", "ACSAD",2)
           
            };
        private List<Prof> profUsers = new List<Prof>
        {
            new Prof("TEACHER", "ADMIN2", "1234", "Admin 2", "CCIS", 5)
         
          };

        //CLASSES FOR USERS
        //Note: These classes are not used in the overall process.
        public class Stud
        {
            public Stud(string identifier, string studentId, string password, string name, string yearLevel, string section, int bookLimit)
            {
                Identifier = identifier; //Set Identifier for student
                Username = studentId;  // Set Username to StudentId
                Password = password;   //Set password
                StudentId = studentId; // Set student ID
                Name = name; // Set the name for the student user
                YearLevel = yearLevel; // Set the year level for the user
                Section = section;//Set the section for the user
                BookLimit = bookLimit; // Set the booklimit
            }

            //GETTERS AND SETTERS
            public string Identifier { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string StudentId { get; set; }
            public string Name { get; set; }
            public string YearLevel { get; set; }
            public string Section { get; set; }
            public int BookLimit { get; set; }
        }
        public class Prof
        {
            public Prof(string identifier, string employeeId, string password, string name, string department, int bookLimit)
            {
                Identifier = identifier; //Set the identifier to the teachers
                Username = employeeId;  // Set Username to EmployeeId
                Password = password; // Set the password for the teachers 
                EmployeeId = employeeId; // Set the employee ID for the teachers
                Name = name; //Set the name
                Department = department; //Set the department
                BookLimit = bookLimit; //Set the booklimit

            }

            //GETTERS AND SETTERS
            public string Identifier { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string EmployeeId { get; set; }
            public string Department { get; set; }
            public int BookLimit { get; set; }

        }

        //MAKES THE FORM ACQUIRE ROUND EDGES
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

            //Sets the password of the textbox to set to dot
            passwordBx.UseSystemPasswordChar = true;

        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

            // Disable the maximize/Minimize button
            nightControlBox1.EnableMaximizeButton = false;
            
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            // Get the entered username and password
            string enteredUsername = usernameBx.Texts;
            string enteredPassword = passwordBx.Text;

            // Check if the entered username matches a student user, then proceed to pass check
            Stud studentUser = studentUsers.FirstOrDefault(user => user.Username == enteredUsername);

            // If the entered username matches a student user, check the password
            if (studentUser != null)
            {
                if (studentUser.Password == enteredPassword)
                {
                    // Open the Dashboard form with the authenticated student user information
                    Dashboard secondForm = new Dashboard(studentUser.Identifier, studentUser.Name, studentUser.StudentId, studentUser.BookLimit); 
                    secondForm.Show();
                    this.Hide();
                    this.WindowState = FormWindowState.Normal;
                    return;
                }
                else
                {
                    // Show error message for invalid password
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Incorrect password or username. Please try again.";
                    return;
                }
            }

            // Check if the entered username matches a professor user,, proceed to check pass
            Prof professorUser = profUsers.FirstOrDefault(user => user.Username == enteredUsername);

            // If the entered username matches a professor user, check password
            if (professorUser != null)
            {
                if (professorUser.Password == enteredPassword)
                {
                    // Open the Dashboard form with the authenticated professor user information
                    Dashboard secondForm = new Dashboard(professorUser.Identifier, professorUser.Name, professorUser.EmployeeId, professorUser.BookLimit);
                    secondForm.Show();
                    this.Hide();
                    this.WindowState = FormWindowState.Normal;
                    return;
                }
                else
                {
                    // Show error message for invalid password
                    lblMessage.ForeColor = Color.Red;
                    lblMessage.Text = "Incorrect password or username. Please try again.";
                    return;
                }
            }

            // If no matching username is found, show error message for invalid username
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = "Incorrect password or username. Please try again.";
        }

        //This method is used for the lock icon to unhide the password
        private void passIcon_Click(object sender, EventArgs e)
        {
            passwordBx.UseSystemPasswordChar = !passwordBx.UseSystemPasswordChar;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            passwordBx.UseSystemPasswordChar = true;
        }
    }

}
