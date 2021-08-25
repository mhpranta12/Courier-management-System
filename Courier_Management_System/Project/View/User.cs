using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using Project.Controller;

namespace Project.View
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searchButtonClk(object sender, EventArgs e)
        {

            string cons_no = consignment_noTextBox.Text;
            string caption = "Empty Input";
            string msg = "Please Enter Consignment Number";
            if (cons_no == "")
            {
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int consignment_no = Int32.Parse(consignment_noTextBox.Text);
                ArrayList y = new ArrayList();
                y = ShipmentController.SearchShipmentUser(consignment_no);
                foundListGridview.DataSource = y;
            }
          
        }

        private void homeClk(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home x = new Home();
            x.ShowDialog();
        }
    }
}
