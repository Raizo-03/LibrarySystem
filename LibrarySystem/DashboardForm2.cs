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
    public partial class DashboardForm2 : Form
    {
        private string identifier, name, id;
    

        public DashboardForm2(string Identifier, string Name, string Id)
        {
            InitializeComponent();
            this.identifier = Identifier;   
            this.Name = Name;
            this.id = Id;
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
