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
    public partial class CompleteDelivery : Form
    {
        public CompleteDelivery()
        {
            InitializeComponent();
        }

        private void completeShipmentButtonCLk(object sender, EventArgs e)
        {
            int consignment_no = Int32.Parse(consignment_noTextBox.Text);
            bool result = Controller.ShipmentController.CompleteShipment(consignment_no);
            if (result.Equals(true))
            {
                MessageBox.Show("Shipment Completed !!!");
            }
            else
                MessageBox.Show("There was an error to Completed . . . ");
        }
    }
}
