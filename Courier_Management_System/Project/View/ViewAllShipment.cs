using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Project.Controller;

namespace Project.View
{
    public partial class ViewAllShipment : Form
    {
        public ViewAllShipment()
        {
            InitializeComponent();
            ArrayList y = new ArrayList();

            y = ShipmentController.ShowAllShipments();
            shipmentlistdataGridView.DataSource = y;
           
        }

        private void serachButtonCLk(object sender, EventArgs e)
        {
            string cons_no = consignment_noTextBox.Text;
            string caption = "Empty Input";
            string msg = "Please Enter Consignment Number";
            if (cons_no == "")
            {
                MessageBox.Show(msg,caption,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int consignment_no = Int32.Parse(consignment_noTextBox.Text);
                ArrayList y = new ArrayList();
                y = ShipmentController.SearchShipmentAdmin(consignment_no);
                shipmentlistdataGridView.DataSource = y;
            }
           

        }

        private void viewAllButtonClk(object sender, EventArgs e)
        {
            ArrayList y = new ArrayList();

            y = ShipmentController.ShowAllShipments();
            shipmentlistdataGridView.DataSource = y;
        }

        private void mouseClk(object sender, MouseEventArgs e)
        {

        }

        private void viewListButtonCLk(object sender, EventArgs e)
        {
            ArrayList y = new ArrayList();

            y = ShipmentController.ShowAllShipments();
            shipmentlistdataGridView.DataSource = y;
        }
    }
}
