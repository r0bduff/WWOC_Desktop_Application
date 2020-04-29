/* Class: Location.cs
 * @Authors Rob Duff, Luis Jimenez
 * 
 * Description: Object class holding information about a location 
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
    class Location
    {
        public int locationID { get; set; }
        public string name { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string type { get; set; }

        private SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117");

        public Location() { }

        public Location(string name)
        {
            this.name = name;
            fillLocInfo();
        }

        public Location(string name, string street, string city, string state, string zip, string type)
        {
            this.name = name;
            this.street = street;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.type = type;
            AddLocationToDB();
        }

        private void AddLocationToDB()
        {
            cnn.Open();
            SqlCommand addLoc = new SqlCommand("INSERT INTO Location (name, type, Street, City, State, ZIP) VALUES (@name, @type, @st, @city, @state, @zip)", cnn);
            addLoc.Parameters.AddWithValue("@name", name);
            addLoc.Parameters.AddWithValue("@type", type);
            addLoc.Parameters.AddWithValue("@st", street);
            addLoc.Parameters.AddWithValue("@city", city);
            addLoc.Parameters.AddWithValue("@state", state);
            addLoc.Parameters.AddWithValue("@zip", zip);
            addLoc.ExecuteNonQuery();

            SqlCommand getID = new SqlCommand("SELECT MAX(locationID) AS maxID FROM Location", cnn);
            SqlDataReader reader = getID.ExecuteReader(); reader.Read();
            locationID = Convert.ToInt32(reader["maxID"]); reader.Close();
            cnn.Close();
        }

        private void fillLocInfo()
        {
            cnn.Open();
            SqlCommand getInfo = new SqlCommand("SELECT * FROM Location WHERE name='" + name + "';", cnn);
            SqlDataReader reader = getInfo.ExecuteReader(); reader.Read();
            locationID = Convert.ToInt32(reader["locationID"]);
            reader.Close(); cnn.Close();
        }
    }
}
