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

        /* Description: blank constructor class
         * Req: -
         * Returns: -
         */
        public Location() { }

        /* Description: not as blank constructor class for when trying to get an existing locations information
         * Req: string name - name of the location
         * Returns: fills the rest of the information
         */
        public Location(string name)
        {
            this.name = name;
            fillLocInfo();
        }

        /* Description: Constructor class for when making a new location to go to the db
         * Req: string name, string street, string city, string state, string zip, string type
         * Returns: updates the db, assigns a locationID
         */
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

        /* Description: Given that the locations details have been assigned this updates the DB 
        * Req: class values not null except locationID
        * Returns: updates the db 
        */
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

        /* Description: given the location name retrieves the location id, should fill the rest of the stuff but i was lazy
        * Req: class value name != null
        * Returns: locationID
        */
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
