/* Class: Vendor.cs
 * @Authors Rob Duff, Luis Jimenez
 * 
 * Description: Object class that stores and handles critical information about a vendor. 
 * 
 * Things to do: 
 * 
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWOC_Desktop_App
{
    class Vendor
    {
        public int vendorID { get; set; }
        public string vendorName { get; set; }
        public string vendorEmail { get; set; }

        private SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117");

        /* Description: Constructor class if no info to be pushed
         * Req: -
         * Returns: -
         */
        public Vendor()
        {

        }

        public Vendor(int id)
        {
            vendorID = id;
            GetVendor();
        }

        /* Description: Constructior class for instance when vendor is in the DB
         * Req: int ID
         * Returns: fills rest of the info
         */
        public Vendor(string name)
        {
            vendorName = name;
            fillVendorInfo();
        }

        /* Description: Constructor class for instance when 
         * Req: 
         * Returns: 
         */
        public Vendor(string name, string email)
        {
            vendorName = name;
            vendorEmail = email;
            AddVendor();
        }

        /* Description: Considering the ID has been given then the rest of the info is found
         * Req: vendorID != null
         * Returns: vendorName, vendorEmail
         */
        private void fillVendorInfo()
        {
            cnn.Open();
            SqlCommand getInfo = new SqlCommand("SELECT * FROM Vendors WHERE vendorName ='" + vendorName + "';", cnn);
            SqlDataReader reader = getInfo.ExecuteReader(); reader.Read();
            vendorID = Convert.ToInt32(reader["vendorID"]);
            vendorEmail = reader["vendorEmail"].ToString();
            reader.Close(); cnn.Close();
        }

        /* Description: Adds new vendor info to the DB updates vendorID with the db given ID
         * Req: vendorName, vendorEmail
         * Returns: vendorID, updates DB
         */
        public void AddVendor()
        {
            cnn.Open();
            SqlCommand addVendor = new SqlCommand("INSERT INTO Vendors (vendorName, vendoremail) VALUES (@vendor, @email)", cnn);
            addVendor.Parameters.AddWithValue("@vendor", vendorName);
            addVendor.Parameters.AddWithValue("@email", vendorEmail);
            addVendor.ExecuteNonQuery();

            SqlCommand getID = new SqlCommand("SELECT MAX(vendorID) AS maxID FROM Vendors", cnn);
            SqlDataReader reader = getID.ExecuteReader(); reader.Read();
            vendorID = Convert.ToInt32(reader["maxID"]); reader.Close();
            cnn.Close();
        }

        private void GetVendor()
        {
            cnn.Open();
            SqlCommand getInfo = new SqlCommand("SELECT * FROM Vendors WHERE vendorID =" + vendorID , cnn);
            SqlDataReader reader = getInfo.ExecuteReader(); reader.Read();
            vendorName = reader["vendorName"].ToString();
            vendorEmail = reader["vendorEmail"].ToString();
            reader.Close(); cnn.Close();
        }

       
    }
}
