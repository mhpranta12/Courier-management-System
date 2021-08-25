using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Model;
using System.Collections;
using System.Data.SqlClient;

namespace Project.Model
{
    class Shipments
    {
        
        public static bool InsertShipment(string customer_name, string product_name, string address, string mobile_no, string delivery_place, string delivery_time,string delivery_placement_date, string final_date, string status)
        {
            var conn = DB.ConnectDB();
            conn.Open();
            string query = String.Format("Insert Into shipment Values ('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')","",customer_name, product_name, address, mobile_no, delivery_place, delivery_time, delivery_placement_date, final_date, status);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static ArrayList ReadAllShipments()
        {

            var conn = DB.ConnectDB();
            conn.Open();
            string query = "Select * from shipment";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList shipments = new ArrayList();
            while (reader.Read())
            {
                Shipment shipment = new Shipment();
                shipment.ConsignmentNo = reader.GetInt32(reader.GetOrdinal("consignment_no"));
                shipment.CustomerName = reader.GetString(reader.GetOrdinal("customer_name"));
                shipment.ProductName = reader.GetString(reader.GetOrdinal("product_name"));
                shipment.Address = reader.GetString(reader.GetOrdinal("address"));
                shipment.MobileNo = reader.GetString(reader.GetOrdinal("mobile_no"));
                shipment.DeliveryPlace = reader.GetString(reader.GetOrdinal("delivery_place"));
                shipment.DeliveryTime = reader.GetString(reader.GetOrdinal("delivery_time"));
                shipment.DeliveryPlacementDate = reader.GetString(reader.GetOrdinal("delivery_placement_date"));
                shipment.FinalDate = reader.GetString(reader.GetOrdinal("final_date"));
                shipment.Status = reader.GetString(reader.GetOrdinal("status"));

                shipments.Add(shipment);

            }
            conn.Close();
            return shipments;
        }


        public static ArrayList FindShipmentAdmin(int consignment_no)
        {

            var conn = DB.ConnectDB();
            conn.Open();
            string query = String.Format("SELECT * FROM shipment WHERE consignment_no='{0}'", consignment_no);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList shipments = new ArrayList();
            Shipment shipment = new Shipment();
            while (reader.Read())
            {

                shipment.ConsignmentNo = reader.GetInt32(reader.GetOrdinal("consignment_no"));
                shipment.CustomerName = reader.GetString(reader.GetOrdinal("customer_name"));
                shipment.ProductName = reader.GetString(reader.GetOrdinal("product_name"));
                shipment.Address = reader.GetString(reader.GetOrdinal("address"));
                shipment.MobileNo = reader.GetString(reader.GetOrdinal("mobile_no"));
                shipment.DeliveryPlace = reader.GetString(reader.GetOrdinal("delivery_place"));
                shipment.DeliveryTime = reader.GetString(reader.GetOrdinal("delivery_time"));
                shipment.DeliveryPlacementDate = reader.GetString(reader.GetOrdinal("delivery_placement_date"));
                shipment.FinalDate = reader.GetString(reader.GetOrdinal("final_date"));
                shipment.Status = reader.GetString(reader.GetOrdinal("status"));


                shipments.Add(shipment);

            }
            conn.Close();

            return shipments;

        }



        public static ArrayList FindShipmentUser(int consignment_no)
        {

            var conn = DB.ConnectDB();
            conn.Open();
            string query = String.Format("SELECT * FROM shipment WHERE consignment_no='{0}'", consignment_no);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ArrayList shipments = new ArrayList();
            Shipment shipment = new Shipment();
            while (reader.Read())
            {

                shipment.ConsignmentNo = reader.GetInt32(reader.GetOrdinal("consignment_no"));
                shipment.CustomerName = reader.GetString(reader.GetOrdinal("customer_name"));
                shipment.ProductName = reader.GetString(reader.GetOrdinal("product_name"));
                shipment.FinalDate = reader.GetString(reader.GetOrdinal("final_date"));
                shipment.Status = reader.GetString(reader.GetOrdinal("status"));


                shipments.Add(shipment);

            }
            conn.Close();

            return shipments;

        }

        public static bool UpdateShipment(int consignment_no , string customer_name, string product_name, string address, string mobile_no, string delivery_place, string delivery_time, string delivery_placement_date, string final_date, string status)
        {
            var conn = DB.ConnectDB();
            conn.Open();
            string query = String.Format("Update  shipment Set customer_name ='{0}',product_name ='{1}' ,address ='{2}' ,mobile_no ='{3}' ,delivery_place ='{4}' ,delivery_time ='{5}' ,delivery_placement_date ='{6}',final_date ='{7}' ,status ='{8}'  Where consignment_no ='{9}'",
                customer_name, product_name, address , mobile_no ,
                delivery_place , delivery_time , delivery_placement_date , final_date , status ,
                consignment_no);
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static bool CompleteShipment(int consignment_no)
        {
            var conn = DB.ConnectDB();
            conn.Open();
            string query = String.Format("Update  shipment Set status ='{0}'  Where consignment_no ='{1}'",
               
               "delivered", consignment_no);
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0)
            {
                return true;
            }
            else
                return false;
        }



        public static bool DeleteShipment(int consignment_no)
        {
            var conn = DB.ConnectDB();
            conn.Open();
            string query = string.Format("Delete From shipment Where consignment_no =('{0}')", consignment_no);
            SqlCommand cmd = new SqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            conn.Close();
            if (a > 0)
            {
                return true;
            }
            else
                return false;
        }

    }
}
