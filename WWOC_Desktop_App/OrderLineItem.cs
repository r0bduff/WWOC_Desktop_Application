/* Class: OrderLineItem.cs
 * @Authors Rob Duff
 * 
 * Description: Object class that handles the things shared by both a part and order. 
 * 
 */
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


        /* Description: Finds the partid for a given part from the database
        * Req: string partDesc, SqlConnection cnn (open)
        * Returns: nothing, updates the class
        */
        private void GetPartID(string partDesc, SqlConnection cnn)
        {
            SqlCommand getPart = new SqlCommand("SELECT partID FROM Parts WHERE itemDesc ='" + partDesc + "'", cnn);
            SqlDataReader reader = getPart.ExecuteReader(); reader.Read();
            partID = Convert.ToInt32(reader["partID"]); reader.Close();
        }

        /* Description: Fills in all the part info from what is stored in the database.
        * Req: string partDesc, SqlConnection cnn (open)
        * Returns: nothing, updates the class
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

      /* Description: Fills in all the part info from what is stored in the database. 
       *              I REALLY COULDA DONE THIS BETTER THE FIRST TIME.
       * Req: string partID, SqlConnection cnn (open)
       * Returns: nothing, updates the class
       */
        public void FillPartInfo2(int partID, SqlConnection cnn)
        {
            SqlCommand getInfo = new SqlCommand("SELECT * FROM Parts WHERE partID ='" + partID + "'", cnn);
            SqlDataReader reader = getInfo.ExecuteReader(); reader.Read();
            itemDesc = reader["itemDesc"].ToString();
            unitPrice = Convert.ToInt32(reader["costUSD"]);
            vendorID = Convert.ToInt32(reader["vendorID"]);
            qtyOH = Convert.ToInt32(reader["qty"]);
            reader.Close();
        }

        /* Description: translates a vendor ID into a vendor name for better front end readability.
         * Req: SqlConnection cnn (open)
         * Returns: name; string containting name of the vendor 
         */
        public string ReturnVendorName(SqlConnection cnn)
        {
            SqlCommand getVendor = new SqlCommand("SELECT vendorName FROM Vendors WHERE vendorID='" + vendorID + "'", cnn);
            SqlDataReader reader = getVendor.ExecuteReader(); reader.Read();
            string name = reader["vendorName"].ToString();
            reader.Close();
            return name;        
        }

        /* Description: Adds an Item to the database. 
         * Req: SqlConnection cnn (open)
         * Returns: nothing, updates database
         */
        public void AddOrderLineItem(SqlConnection cnn)
        {
            SqlCommand addLineItem = new SqlCommand("INSERT INTO Order_Line_Item (Order_Line_Item.partID, Order_Line_Item.orderID, qty, unitPrice) VALUES ('"
                                                    + partID + "','" + orderID + "','" + qty + "','" + unitPrice + "')", cnn);
            addLineItem.ExecuteNonQuery();
        }

       
    }//end class
}//end namespace
