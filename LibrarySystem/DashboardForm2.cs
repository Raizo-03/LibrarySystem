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
        private string identifier;
        private string name;
        private string ID;
        public DashboardForm2(string Identifier, string Name, string iD)
        {
            InitializeComponent();
            this.identifier = Identifier;
            this.name = Name;
            this.ID = iD;

            nameLabel.Text = Name;
            idLabel.Text = iD;
            identifierLabel.Text = Identifier;
        }

        private void DashboardForm2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 253, 247, 228); //CUSTOM BG COLORS #FDF7E4

        }
    }
}
