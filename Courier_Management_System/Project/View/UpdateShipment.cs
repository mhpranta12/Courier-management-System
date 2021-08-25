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
    public partial class UpdateShipment : Form
    {
        public UpdateShipment()
        {
            InitializeComponent();
        }

        private void update_ShipmentButtonClk(object sender, EventArgs e)
        {
            string msg_done = "Shipment Updated !!!";
            string cap_done = "Succes !";
            string cons_no = consignment_noTextBox.Text;
            string customer_name = customer_nameTextBox.Text;
            string product_name = product_nameTextBox.Text;
            string address = addressTextBox.Text;
            string mobile_no = mobileTextBox.Text;
            string delivery_place = delivery_placeTextBox.Text;
            string delivery_time = delivery_timeTextBox.Text;
            string delivery_placement_date = date_of_placementTextBox.Text;
            string final_date = final_dateTextBox.Text;
            string status = statuscomboBox.Text;
            string caption = "Empty Input";
            string msg = "Please Fill Up All Inputs";
            if (cons_no == "" || customer_name.Equals("") || product_name.Equals("") ||
                address.Equals("") || mobile_no.Equals("") ||
                delivery_place.Equals("") || delivery_time.Equals("") ||
                delivery_placement_date.Equals("") || final_date.Equals("") ||
                status.Equals(""))
                
            {
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int consignment_no = Int32.Parse(consignment_noTextBox.Text);
                 customer_name = customer_nameTextBox.Text;
                 product_name = product_nameTextBox.Text;
                 address = addressTextBox.Text;
                 mobile_no = mobileTextBox.Text;
                 delivery_place = delivery_placeTextBox.Text;
                 delivery_time = delivery_timeTextBox.Text;
                 delivery_placement_date = date_of_placementTextBox.Text;
                 final_date = final_dateTextBox.Text;
                 status = statuscomboBox.Text;
                bool result = Controller.ShipmentController.EditShipment(consignment_no, customer_name, product_name, address, mobile_no, delivery_place, delivery_time, delivery_placement_date, final_date, status);
                if (result.Equals(true))
                {
                    MessageBox.Show(msg_done,cap_done,MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("There was an error to Update . . . ");
            }
           
        }
    }
}
