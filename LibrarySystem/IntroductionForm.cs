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
        private List<User> users;  // Assuming User, Student, and Teacher classes are defined as in the previous example

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

            // Initialize the user list with predefined students and teachers
            users = new List<User>
            {
                new Student("Student1", 1, 1, "SectionA"),
                new Student("Student2", 2, 2, "SectionB"),
                // Add more students as needed

                new Teacher("Teacher1", 101, 1001, "Math"),
                new Teacher("Teacher2", 102, 1002, "Science"),
                // Add more teachers as needed
            };
        }

        //GETTERS AND SETTERS FOR LOG IN
        public class User
        {
            public string Name { get; set; }
            public int UserId { get; set; }
            public string Password { get; set; }

            public User(string name, int userId, string password)
            {
                Name = name;
                UserId = userId;
                Password = password;
            }
        }

        //GETTERS AND SETTERS FOR USERS
        public class Student : User
        {
            public int YearLevel { get; set; }
            public string Section { get; set; }

            public Student(string name, int userId, int yearLevel, string section)
                : base(name, userId, $"Student{userId}Password")  // Password generated based on user ID for simplicity
            {
                YearLevel = yearLevel;
                Section = section;
            }
        }

        //GETTERS AND SETTERS FOR TEACHERS
        public class Teacher : User
        {
            public int EmployeeId { get; set; }
            public string Department { get; set; }

            public Teacher(string name, int userId, int employeeId, string department)
                : base(name, userId, $"Teacher{userId}Password")  // Password generated based on user ID for simplicity
            {
                EmployeeId = employeeId;
                Department = department;
            }
        }

        //AUTH
        private User AuthenticateUser(string username, string password)
        {
            // Simple authentication logic (check if username and password match any user)
            return users.FirstOrDefault(user => user.Name == username && user.Password == password);
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

        private void proceedBtn_Click(object sender, EventArgs e)
        {
            proceedBtn.BackColor = Color.White;

            // Get entered username and password
            string username = usernameBx.Text;
            string password = passwordBx.Text;

            // Authenticate user
            User authenticatedUser = AuthenticateUser(username, password);

            if (authenticatedUser != null)
            {
                MessageBox.Show($"Welcome, {authenticatedUser.Name}!");
                //CLOSES THE FIRST FORM
                FirstForm first = new FirstForm();

                // Assuming FirstFormInstance is an instance of the form you want to close
                this.Hide();
                // Open the second form
                Dashboard secondForm = new Dashboard();
                secondForm.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }



        }

    }
}
