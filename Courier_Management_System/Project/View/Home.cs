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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void adminloginClk(object sender, EventArgs e)
        {
            AdminLogin x = new AdminLogin();
            x.ShowDialog();
        }

        private void userLoginButtonClk(object sender, EventArgs e)
        {
            User x = new User();
            x.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
