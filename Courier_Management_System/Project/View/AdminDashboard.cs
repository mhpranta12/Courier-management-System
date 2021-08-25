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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void addshipmentClk(object sender, EventArgs e)
        {
            AddShipment x = new AddShipment();
            x.ShowDialog();
        }

        private void viewallshipmentsClk(object sender, EventArgs e)
        {
            ViewAllShipment x = new ViewAllShipment();
            x.ShowDialog();
        }

        private void deleteShipmentButtonClk(object sender, EventArgs e)
        {
            DeleteShipment x = new DeleteShipment();
            x.ShowDialog();
        }

        private void editShipmentButtonClk(object sender, EventArgs e)
        {
            UpdateShipment x = new UpdateShipment();
            x.ShowDialog();
        }

        private void logoutButtonClick(object sender, EventArgs e)
        {
            AdminLogin x = new AdminLogin();
            x.ShowDialog();
        }

        private void completeshipmentButtonClk(object sender, EventArgs e)
        {
            CompleteDelivery x = new CompleteDelivery();
            x.ShowDialog();
        }
    }
}
