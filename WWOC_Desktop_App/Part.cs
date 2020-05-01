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

       
    }
}
