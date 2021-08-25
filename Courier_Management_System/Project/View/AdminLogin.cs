using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.View
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginClk(object sender, EventArgs e)
        {
            string msg = "Credential Error ";
            string cap = "Error";
            if (nameTextBox.Text.Equals("admin") && passwordTextBox.Text.Equals("1234"))
            {
                AdminDashboard x = new AdminDashboard();
                x.ShowDialog();
            }
            else
                MessageBox.Show(msg, cap,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void homeClk(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home x = new Home();
            x.ShowDialog();
        }
    }
}
