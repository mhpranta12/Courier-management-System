using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Project.Model;

namespace Project.Controller
{
    class ShipmentController
    {
        public static bool AddShipment(string customer_name, string product_name, string address, string mobileno, string delivery_place, string delivery_time, string date_of_placement, string final_date, string status)
        {

            bool result = Shipments.InsertShipment(customer_name, product_name, address, mobileno, delivery_place, delivery_time , date_of_placement, final_date, status);
            return result;
        }
        public static bool EditShipment(int consignment_no , string customer_name, string product_name, string address, string mobileno, string delivery_place, string delivery_time, string date_of_placement, string final_date, string status)
        {

            bool result = Shipments.UpdateShipment(consignment_no,customer_name, product_name, address, mobileno, delivery_place, delivery_time, date_of_placement, final_date, status);
            return result;
        }
        public static bool CompleteShipment(int consignment_no)
        {

            bool result = Shipments.CompleteShipment(consignment_no);
            return result;
        }
        public static bool RemoveShipment(int consignment_no)
        {

            bool result = Shipments.DeleteShipment(consignment_no);
            return result;
        }
        public static ArrayList ShowAllShipments()
        {
            ArrayList x = new ArrayList();
            x = Shipments.ReadAllShipments();
            return x;

        }
       public static ArrayList SearchShipmentAdmin(int consignment_no)
        {
            ArrayList x = new ArrayList();
            x = Shipments.FindShipmentAdmin(consignment_no);
            return x;

        }
        public static ArrayList SearchShipmentUser(int consignment_no)
        {
            ArrayList x = new ArrayList();
            x = Shipments.FindShipmentUser(consignment_no);
            return x;

        }
    }
}
