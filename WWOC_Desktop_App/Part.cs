/* Class: Location.cs
 * @Authors Rob Duff, Luis Jimenez
 * 
 * Description: Object class holding information about a Part
 * 
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace WWOC_Desktop_App
{
    class Part
    {
        public int partID { get; set; }
        public string itemDesc { get; set; }
        public double costUSD { get; set; }
        public int vendorID { get; set; }
        public int qtyOH { get; set; }
        public int reorderPoint { get; set; }
        public int exptdLife { get; set; }
        public string shipmentTime { get; set; }
        public int locationID { get; set; }

        private SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117");

        /* Description: do not use this, but if you want to its here
         * Req: nothing
         * Returns: nothing
         */
        public Part() { }

        /* Description: Constructor method for when using an existing part
         * Req: int partID
         * Returns: fills the object with matching info
         */
        public Part(int partID)
        {
            this.partID = partID;
            getPartFromDB();
        }

        public Part(string itemDesc)
        {
            this.itemDesc = itemDesc;
            getPartId();
            getPartFromDB();
        }

        /* Description: Constructor method in the event that a new part is being made
         * Req: string itemDesc, double costUSD, int vendorID, int qtyOH, int reorderPoint, int exptdLife, string shipmentTime, int locationID
         * Returns: nothing
         */
        public Part(string itemDesc, double costUSD, int vendorID, int qtyOH, int reorderPoint, int exptdLife, string shipmentTime, int locationID)
        {
            this.itemDesc = itemDesc;
            this.costUSD = costUSD;
            this.vendorID = vendorID;
            this.qtyOH = qtyOH;
            this.reorderPoint = reorderPoint;
            this.exptdLife = exptdLife;
            this.shipmentTime = shipmentTime;
            this.locationID = locationID;
            addPartDB();
        }

        /* Description: Adds a new part to the db
         * Req: all paramaters to be filled in
         * Returns: the assigned partID
         */
        private void addPartDB()
        {
            cnn.Open();
            SqlCommand addPart = new SqlCommand("INSERT INTO Parts (itemDesc, costUSD, vendorID, qty, reorderPoint, exptdLife, shipmentTime, locationID) VALUES (@itemDesc, @Cost, @vendor, @quanit, @reorderPoint, @exptdLife, @shipmentTime, @location)", cnn);
            addPart.Parameters.AddWithValue("@itemDesc", itemDesc);
            addPart.Parameters.AddWithValue("@Cost", costUSD);
            addPart.Parameters.AddWithValue("@vendor", vendorID);
            addPart.Parameters.AddWithValue("@quanit", qtyOH);
            addPart.Parameters.AddWithValue("@reorderPoint", reorderPoint);
            addPart.Parameters.AddWithValue("@exptdLife", exptdLife);
            addPart.Parameters.AddWithValue("@shipmentTime", shipmentTime);
            addPart.Parameters.AddWithValue("@location", locationID);
            addPart.ExecuteNonQuery();

            SqlCommand getID = new SqlCommand("SELECT MAX(locationID) AS maxID FROM Location", cnn);
            SqlDataReader reader = getID.ExecuteReader(); reader.Read();
            locationID = Convert.ToInt32(reader["maxID"]); reader.Close();
            cnn.Close();
        }

        /* Description: Retrieves the information about a part from the DB 
         * Req: partID to be filled in
         * Returns: everything
         */
        public void getPartFromDB()
        {
            cnn.Open();
            SqlCommand getPart = new SqlCommand("SELECT * FROM Parts WHERE partID=" + partID, cnn);
            SqlDataReader reader = getPart.ExecuteReader(); reader.Read();
            itemDesc = reader["itemDesc"].ToString();
            costUSD = Convert.ToDouble(reader["costUSD"]);
            vendorID = Convert.ToInt32(reader["vendorID"]);
            qtyOH = Convert.ToInt32(reader["qty"]);
            reorderPoint = Convert.ToInt32(reader["reorderPoint"]);
            exptdLife = Convert.ToInt32(reader["exptdLife"]);
            shipmentTime = (reader["shipmentTime"]).ToString();
            locationID = Convert.ToInt32(reader["locationID"]);
            reader.Close();
            cnn.Close();
        }

        /* Description: in the instance that only the itemDesc is given we can find the itemId
         * Req: itemDesc
         * Returns: itemId
         */
        private void getPartId()
        {
            cnn.Open();
            SqlCommand getId = new SqlCommand("Select partID FROM Parts WHERE itemDesc='" + itemDesc + "'", cnn);
            SqlDataReader reader = getId.ExecuteReader(); reader.Read();
            partID = Convert.ToInt32(reader["partID"]); reader.Close();
            cnn.Close();
        }

        /* Description: Updates the DB with whatever info is currently stored in the instance of the object
         * Req: -
         * Returns: updates db
         */
        public void updateDB()
        {
            cnn.Open();
            SqlCommand updateDB = new SqlCommand("UPDATE Parts SET itemDesc='" + itemDesc + "', costUSD=" + costUSD +", vendorID=" + vendorID +", qty=" + qtyOH +", reorderPoint=" + reorderPoint +
                                                                    ", exptdLife=" + exptdLife +", shipmentTime='" + shipmentTime +"', locationID=" + locationID +"WHERE partID=" + partID, cnn);
            
            updateDB.ExecuteNonQuery();
            cnn.Close();
        }

        /* Description: removes the given amount of a part from the inventory
         * Req: int qty(taken)
         * Returns: updates the db
         */
        public void checkOutPart(int qty)
        {
            qtyOH -= qty;
            updateDB();
        }

        /* Description: Checks and orders more of a part if the reorder point is reached
         * Req: part class filled
         * Returns: adds new order
         */
        public void autoOrder()
        {
            if(qtyOH <= reorderPoint)
            {
                cnn.Open();
                {
                    Order partOrder = new Order(14, cnn);
                    OrderLineItem partNew = new OrderLineItem();
                    {
                        partNew.partID = partID;
                        partNew.orderID = partOrder.orderID;
                        partNew.qty = calculateReorderAmount();
                        partNew.unitPrice = (float)Convert.ToDouble(costUSD);
                        partNew.AddOrderLineItem(cnn);
                    }
                    partOrder.AddPartToOrder(partNew);
                    partOrder.CalculateFinalCosts();
                    partOrder.poDate = DateTime.Now;
                    if(partOrder.totalPrice >= 25000)
                    {
                        partOrder.approved = false;
                    }
                    else
                    {
                        partOrder.approved = true;
                        Email newEmail = new Email(partOrder);
                        newEmail.SendOrderEmails();
                    }
                    partOrder.UpdateDatabase(cnn);
                }
                cnn.Close();
            }
        }

        /* Description: Calculates how much of the part should be reordered based on some very specific calculations
         * Req: part class filled
         * Returns: int holding the qty to order
         */
        private int calculateReorderAmount()
        {
            if(exptdLife <= 7)
            {
                return exptdLife * 7;//if the part is used frequently (more than once a week) then a multiple of 7 is ordered.
            }
            else if(exptdLife > 7 && exptdLife <= 28)
            {
                return reorderPoint * 2; //parts lasting 1-4 weeks are ordered at double the minimum amount
            }
            else if(exptdLife > 28)
            {
                return reorderPoint; //parts lasting longer than 4 weeks are ordered at the threshold (doubling it)
            }
            else
            {
                return 1;
            }
        }

       
    }
}
