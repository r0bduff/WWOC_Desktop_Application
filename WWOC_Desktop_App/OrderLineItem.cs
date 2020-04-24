using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWOC_Desktop_App
{
    class OrderLineItem
    {
        public int partID { get; set; }
        public int orderID { get; set; }
        public int qty { get; set; }
        public float unitPrice { get; set; }
        public string itemDesc { get; set; }
        public int qtyOH { get; set; }
        public int vendorID { get; set; }



        /* Description: 
        * Req: 
        * Returns: 
        */
        private void GetPartID(string partDesc, SqlConnection cnn)
        {
            SqlCommand getPart = new SqlCommand("SELECT partID FROM Parts WHERE itemDesc ='" + partDesc + "'", cnn);
            SqlDataReader reader = getPart.ExecuteReader(); reader.Read();
            partID = Convert.ToInt32(reader["partID"]); reader.Close();
        }

        /* Description: 
        * Req: 
        * Returns: 
        */
        public void FillPartInfo(string partDesc, SqlConnection cnn)
        {
            GetPartID(partDesc, cnn);
            SqlCommand getInfo = new SqlCommand("SELECT * FROM Parts WHERE partID ='" + partID + "'", cnn);
            SqlDataReader reader = getInfo.ExecuteReader(); reader.Read();
            itemDesc = partDesc;
            unitPrice = Convert.ToInt32(reader["costUSD"]);
            vendorID = Convert.ToInt32(reader["vendorID"]);
            qtyOH = Convert.ToInt32(reader["qty"]);
            reader.Close();
        }

        /* Description: 
         * Req: 
         * Returns: 
         */
        public string ReturnVendorName(SqlConnection cnn)
        {
            SqlCommand getVendor = new SqlCommand("SELECT vendorName FROM Vendors WHERE vendorID='" + vendorID + "'", cnn);
            SqlDataReader reader = getVendor.ExecuteReader(); reader.Read();
            string name = reader["vendorName"].ToString();
            reader.Close();
            return name;
        }

        /* Description: 
         * Req: 
         * Returns: 
         */
        public void AddOrderLineItem(SqlConnection cnn)
        {
            SqlCommand addLineItem = new SqlCommand("INSERT INTO Order_Line_Item (Order_Line_Item.partID, Order_Line_Item.orderID, qty, unitPrice) VALUES ('"
                                                    + partID + "','" + orderID + "','" + qty + "','" + unitPrice + "')", cnn);
            addLineItem.ExecuteNonQuery();
        }

       
    }//end class
}//end namespace
