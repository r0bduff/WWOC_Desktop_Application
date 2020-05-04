/* Class: Orders.cs
 * @Authors Rob Duff
 * 
 * Description: Object class that stores and handles critical information about an order. 
 * 
 * Things to do: Calculate estimated shipping time
 * 
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWOC_Desktop_App
{
    class Order 
    {
       
        public int orderID { get; set; }
        public int userID { get; set; }
        public DateTime poDate { get; set; }
        public string shippingTime { get; set; }
        public string terms { get; set; }
        public double subtotal { get; set; }
        public double salesTax { get; set; }
        public double shippingHandling { get; set; }
        public double totalPrice { get; set; }
        public List<OrderLineItem> cart { get; set; }
        public Boolean approved { get; set; }
        public Boolean received { get; set; }


        /* Description: 
         * Req: 
         * Returns: 
         */

        /* Description: Constructor class so that there is a place for things to go when we wanna update the database
         *    Instanciates the cart list so things can be added to it. also holds who is making the order.
         *    shh dont tell anyone im realizing its possible for it to not track exactly who made the order in 
         *    one rare instance im not going to handle that yet
         * Req: int currentUserID, SqlConnection cnn
         * Returns: nothing, we are making the new object
         */
        public Order(int currentUserID, SqlConnection cnn)
        {
            cart = new List<OrderLineItem>();
            userID = currentUserID;
            CreateDatabaseColumn(cnn);
            CreateDatabaseColumn(cnn);
        }

        public Order(int orderID, int userID, SqlConnection cnn)
        {
            GetFullOrder(orderID, cnn);
        }

        /* Description: Adds a given part to the cart list
         * Req: OrderLineItem part
         * Returns: nothing
         */
        public void AddPartToOrder(OrderLineItem part)
        {
            cart.Add(part);
        }

        /* Description: Removes a given part from the cart list.
        * Req: string itemName, SqlConnection cnn, out int index
        * Returns: the index in an out statement. Used to update the index for somethin
        */
        public void RemovePartFromOrder(string itemName, out int index)
        {
            index = 0;
            OrderLineItem[] arrCart = cart.ToArray();
            for (int i = 0; i < arrCart.Length; i++)
            {
                if(arrCart[i].itemDesc == itemName)
                {
                    cart.RemoveAt(i);
                    index = i;
                }
            }    
        }
        

        /* Description: Creates a new database column only if the most recent order has been placed and filled. 
         *      checks based on if the total price is set to 0 or not. I am assuming that you would not order something
         *      that is somehow worth $0.
         * Req: SqlConnection cnn
         * Returns: nothing, updates the DB
         */
        public void CreateDatabaseColumn(SqlConnection cnn)
        {
            try
            {
                SqlCommand getHighestID = new SqlCommand("SELECT MAX(orderID) AS maxID FROM Orders", cnn);
                SqlDataReader reader = getHighestID.ExecuteReader(); reader.Read();
                int getMaxID = Convert.ToInt32(reader["maxID"]); reader.Close();

                SqlCommand checkOrder = new SqlCommand("SELECT totalPrice FROM Orders WHERE orderID= '" + getMaxID + "'", cnn);
                reader = checkOrder.ExecuteReader(); reader.Read();
                double totalPrice = Convert.ToDouble(reader["totalPrice"]); reader.Close();

                if (totalPrice != 0)
                {
                    SqlCommand create = new SqlCommand("INSERT INTO Orders (userID, totalPrice, received) VALUES ('" + userID + "', '0', 'False')", cnn);
                    create.ExecuteNonQuery();
                }
                else
                {
                    orderID = getMaxID;
                    SqlCommand pullOrderItems = new SqlCommand("DELETE FROM Order_Line_Item WHERE orderID = " + orderID + ";", cnn);
                    pullOrderItems.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        /* Description: Calculates all the stuff in the final costs groupbox.
         * Req: nothing
         * Returns: nothing, just updates the class so things can be pulled to MainMenu.cs
         */
        public void CalculateFinalCosts()
        {
            OrderLineItem[] arrCart = cart.ToArray();
            for(int i = 0; i < arrCart.Length; i++)
            {
                subtotal += arrCart[i].qty * arrCart[i].unitPrice;
            }
            shippingHandling = subtotal * 0.05;
            salesTax = subtotal * 0.0868;
            totalPrice = subtotal + shippingHandling + salesTax;
        }


        /* Description: this updates the database with what is currently stored in the class.
         * Req: SqlConnection cnn
         * Returns: nothin
         */
        public void UpdateDatabase(SqlConnection cnn)
        {
            
            try
            {
                SqlCommand AddOrder = new SqlCommand("UPDATE Orders SET poDate ='" + poDate + "', terms ='" + terms + "', subtotal=" + subtotal + ", salesTax=" + salesTax
                                                               + ", shippingHandling=" + shippingHandling + ", totalPrice=" + totalPrice + ", approved='" + approved + "', received='" + received +"' " +
                                                               "WHERE orderID =" + orderID + ";", cnn);
                AddOrder.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /* Description: gets the order details from a pervious order that has been stored at some point.
         * Req: int orderID, SqlConnection cnn
         * Returns: fills the class with all the stored variables.
         */
        public void GetFullOrder(int orderID, SqlConnection cnn)
        {
            try
            {
                SqlCommand getitall = new SqlCommand("SELECT * FROM ORDERS WHERE orderID =" + orderID, cnn);
                SqlDataReader reader = getitall.ExecuteReader(); reader.Read();
                this.orderID = Convert.ToInt32(reader["orderID"]);
                userID = Convert.ToInt32(reader["userID"]);
                poDate = Convert.ToDateTime(reader["poDate"]);
                shippingTime = reader["shippingTime"].ToString();
                terms = reader["terms"].ToString();
                subtotal = Convert.ToDouble(reader["subtotal"]);
                salesTax = Convert.ToDouble(reader["salesTax"]);
                shippingHandling = Convert.ToDouble(reader["shippingHandling"]);
                totalPrice = Convert.ToDouble(reader["totalPrice"]);
                approved = Convert.ToBoolean(reader["approved"]);
                received = Convert.ToBoolean(reader["received"]);
                reader.Close();
                GetCartForOrder(cnn);//fills the cart see desc for more info
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /* Description: adds parts to the cart from a previous order that has been stored for approval.
         *              Calls a biffed new method in orderlineitem cause i didnt make it right
         * Req: SqlConnection cnn
         * Returns: populates the cart list with the stuffs
         */
        private void GetCartForOrder(SqlConnection cnn)
        {
            try
            {
                cart = new List<OrderLineItem>();
                SqlCommand getItems = new SqlCommand("SELECT * FROM Order_Line_Item WHERE Order_Line_Item.orderID=" + orderID, cnn);
                SqlDataReader reader = getItems.ExecuteReader();
                while (reader.Read())
                {
                    OrderLineItem item = new OrderLineItem();
                    item.orderID = Convert.ToInt32(reader["orderID"]);
                    item.partID = Convert.ToInt32(reader["partID"]);
                    item.qty = Convert.ToInt32(reader["qty"]);
                    item.unitPrice = Convert.ToInt32(reader["unitPrice"]);
                    cart.Add(item);
                }
                reader.Close();

                OrderLineItem[] arrCart = cart.ToArray();
                for (int i = 0; i < arrCart.Length; i++)
                {
                    arrCart[i].FillPartInfo2(arrCart[i].partID, cnn);
                }
                cart = arrCart.ToList<OrderLineItem>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /* Description: Removes this order from the DB permenatnly. Also removes associated order_Line_items
         * Req: SqlConnection cnn
         * Returns: nothin
         */
        public void RemoveOrderDB(SqlConnection cnn)
        {
            try
            {
                SqlCommand remove = new SqlCommand("DELETE FROM Orders WHERE Orders.orderID=" + orderID, cnn);
                SqlCommand remove2 = new SqlCommand("DELETE FROM Order_Line_Item WHERE Order_Line_Item.orderID =" + orderID, cnn);
                remove2.ExecuteNonQuery();
                remove.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /* Description: approves this order in the DB. updates local variable to match
         * Req: SqlConnection cnn
         * Returns: nothin
         */
        public void ApproveOrderDB(SqlConnection cnn)
        {
            try
            {
                approved = true;
                SqlCommand approve = new SqlCommand("UPDATE Orders SET approved='true' WHERE Orders.orderID=" + orderID, cnn);
                approve.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }         
        }

        public void ConfirmOrderReceived(SqlConnection cnn)
        {
            try
            {
                received = true;
                SqlCommand receivedOrder = new SqlCommand("UPDATE Orders SET received='true' WHERE Orders.orderID=" + orderID, cnn);
                receivedOrder.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
