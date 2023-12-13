using Microsoft.VisualBasic.ApplicationServices;
using System;
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
    public partial class BorrowerList : Form
    {
        private List<User> users;  // Assuming User, Student, and Teacher classes are defined as in the previous example

        public BorrowerList()
        {
            InitializeComponent();


        }

        private void BorrowerList_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4

        }

        //DISPLAYS THE INFO: 
        /*
        private void DisplayUserInformation()
        {
            // Assuming you have a ListBox named userListListBox in your form
            userListListBox.Items.Clear();

            foreach (var user in users)
            {
                if (user is Student student)
                {
                    userListListBox.Items.Add($"Student: {student.Name}, ID: {student.UserId}, Year: {student.YearLevel}, Section: {student.Section}");
                }
                else if (user is Teacher teacher)
                {
                    userListListBox.Items.Add($"Teacher: {teacher.Name}, ID: {teacher.UserId}, Employee ID: {teacher.EmployeeId}, Department: {teacher.Department}");
                }
            }
        }
        */
    }
}
