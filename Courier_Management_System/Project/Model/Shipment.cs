using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    class Shipment
    {
        private int consignment_no;
        public int ConsignmentNo
        {
            get { return consignment_no; }
            set { consignment_no = value; }
        }
        private string customer_name;
        public string CustomerName
        {
            get { return customer_name; }
            set { customer_name = value; }
        }
        private string product_name;
        public string ProductName
        {
            get { return product_name; }
            set { product_name = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string mobile_no;
        public string MobileNo
        {
            get { return mobile_no; }
            set { mobile_no = value; }
        }
        private string delivery_place;
        public string DeliveryPlace
        {
            get { return delivery_place; }
            set { delivery_place = value; }
        }
        private string delivery_time;
        public string DeliveryTime
        {
            get { return delivery_time; }
            set { delivery_time = value; }
        }
        private string delivery_placement_date;
        public string DeliveryPlacementDate
        {
            get { return delivery_placement_date; }
            set { delivery_placement_date = value; }
        }
        private string final_date;
        public string FinalDate
        {
            get { return final_date; }
            set { final_date = value; }
        }
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
