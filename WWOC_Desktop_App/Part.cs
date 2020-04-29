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

        public Part() { }

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
       
    }
}
