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
    public partial class AddShipment : Form
    {
        public AddShipment()
        {
            InitializeComponent();
        }

        private void insertButton(object sender, EventArgs e)
        {
            string customer_name = customer_nameTextBox.Text;  // inputting all of the textbox . . . . 
            string product_name = product_nameTextBox.Text;
            string address = addressTextBox.Text;
            string mobileno = mobileTextBox.Text;
            string delivery_place= delivery_placeTextBox.Text;
            string delivery_time = delivery_timeTextBox.Text;
            string date_of_placement = date_of_placementTextBox.Text;
            string final_date = final_dateTextBox.Text;
            string status = statuscomboBox.Text;

            string caption = "Empty Input";             // caption of the message box
            string msg = "Please Fill Up All Inputs";   // Text To display in messagesbox's alert 
            string caption_scs = "Success  ";
            string msg_scs = " Shipment Added !!!";
            if (customer_name.Equals("") || product_name.Equals("") ||      //Here the validation was occured. . . . 
                address.Equals("") || mobileno.Equals("") ||
                delivery_place.Equals("") || delivery_time.Equals("") ||
                date_of_placement.Equals("") || final_date.Equals("") ||
                status.Equals(""))

            {
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool result = Controller.ShipmentController.AddShipment(customer_name, product_name, address, mobileno, delivery_place, delivery_time, date_of_placement, final_date, status);
                if (result.Equals(true))
                {
                    MessageBox.Show(msg_scs,caption_scs ,MessageBoxButtons.OK ,MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("There was an error . . . ");


            }

        }
    }
}
