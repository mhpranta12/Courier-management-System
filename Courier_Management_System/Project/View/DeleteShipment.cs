using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Controller;

namespace Project.View
{
    public partial class DeleteShipment : Form
    {
        public DeleteShipment()
        {
            InitializeComponent();
        }

        private void removeShipmentButtonClk(object sender, EventArgs e)
        {
            int consignment_no = Int32.Parse(consignment_noTextBox.Text);
            bool result = ShipmentController.RemoveShipment(consignment_no);
            if (result.Equals(true))
            {
                MessageBox.Show("Shipment Removed !!!");
            }
            else
                MessageBox.Show("There was an error to Remove that shipment . . . ");
        }
    }
}
