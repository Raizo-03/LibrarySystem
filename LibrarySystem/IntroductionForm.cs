﻿using System;
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
            new Stud("K12043456", "1234", "Eduardo Buscato", "Second Year", "ACSAD",2)

            };
        //LIST OF 3 TEACHER USERS

        private List<Prof> profUsers = new List<Prof>
        {
            new Prof("K12043710", "1234", "Krissa Beringuel", "CCIS",5 )
          };
        public class Stud
        {
            public Stud(string studentId, string password, string name, string yearLevel, string section, int bookLimit)
            {
                Username = studentId;  // Set Username to StudentId
                Password = password;
                StudentId = studentId;
                Name = name;
                YearLevel = yearLevel;
                Section = section;
                BookLimit = bookLimit;
            }

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
            public Prof(string employeeId, string password, string name, string department, int bookLimit)
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
            public int BookLimit { get; set; }

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
            string enteredUsername = usernameBx.Texts;
            string enteredPassword = passwordBx.Texts;

            // Check if the entered username matches a student user, then proceed to pass check
            Stud studentUser = studentUsers.FirstOrDefault(user => user.Username == enteredUsername);

            // If the entered username matches a student user, check the password
            if (studentUser != null)
            {
                if (studentUser.Password == enteredPassword)
                {
                    // Open the Dashboard form with the authenticated student user information
                    Dashboard secondForm = new Dashboard(studentUser.Name, studentUser.StudentId, studentUser.Section, studentUser.BookLimit);
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
                    Dashboard secondForm = new Dashboard(professorUser.Name, professorUser.EmployeeId, professorUser.Department, professorUser.BookLimit);
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

    }
}
