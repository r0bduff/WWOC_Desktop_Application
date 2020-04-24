/* Class: Orders.cs
 * @Authors Rob Duff
 * 
 * Description: Object class that stores and handles critical information about an order. 
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
    class Order
    {
        public int orderID { get; set; }
        public int userID { get; set; }
        public DateTime poDate { get; set; }
        public string shippingTime { get; set; }
        public string reasonForOrder { get; set; }
        public string terms { get; set; }
        public float subtotal { get; set; }
        public float salesTax { get; set; }
        public float shippingHandling { get; set; }
        public float otherCharges { get; set; }
        public float totalPrice { get; set; }
        public List<OrderLineItem> cart { get; set; }
        public Boolean approved { get; set; }

        /* Description: 
         * Req: 
         * Returns: 
         */

        /* Description: 
         * Req: 
         * Returns: 
         */
        public Order(int currentUserID, SqlConnection cnn)
        {
            cart = new List<OrderLineItem>();
            userID = currentUserID;
            CreateDatabaseColumn(cnn);
        }

        /* Description: 
         * Req: 
         * Returns: 
         
        public string AddPartToOrder(string partDesc, SqlConnection cnn)
        {
            OrderLineItem newItem = new OrderLineItem();
            newItem.GetPartID(partDesc, cnn);
            newItem.FillPartInfo(cnn);
            cart.Add(newItem);
            return newItem.ReturnVendorName(cnn);
        }
        */

        /* Description: 
         * Req: 
         * Returns: 
         */
        public void CreateDatabaseColumn(SqlConnection cnn)
        {
            SqlCommand getHighestID = new SqlCommand("SELECT MAX(orderID) AS maxID FROM Orders", cnn);
            SqlDataReader reader = getHighestID.ExecuteReader(); reader.Read();
            int getMaxID = Convert.ToInt32(reader["maxID"]); reader.Close();

            SqlCommand checkOrder = new SqlCommand("SELECT totalPrice FROM Orders WHERE orderID= '" + getMaxID + "'", cnn);
            reader = checkOrder.ExecuteReader(); reader.Read();
            double totalPrice = Convert.ToDouble(reader["totalPrice"]); reader.Close();

           if(totalPrice != 0)
            {
                SqlCommand create = new SqlCommand("INSERT INTO Orders (userID, totalPrice) VALUES ('" + userID + "', '0')", cnn);
                create.ExecuteNonQuery();
            }
            else
            {
                orderID = getMaxID;
            }
        }

        /* Description: 
         * Req: 
         * Returns: 
         */
        public void UpdateDatabase()
        {

        }
    }
}
