/* Class: Users.cs
 * @Authors Rob Duff, Luis Jimenez
 * 
 * Description: Object class holding information for the current user logged into the application
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace WWOC_Desktop_App
{
    class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public int accessLevel { get; set; }
        public int lockedOut { get; set; }
        public int counter { get; set; }

        private SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117");

        public User()
        {

        }

        public User(int userID)
        {
            this.userID = userID;
            GetUsername();
        }

        public User(string name, string username, string password, int accessLevel)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.accessLevel = accessLevel;
            AddUser();
        }

        /*Updates the database in the event that the accessLevel,lockedout, or counter is changed during runtime.
         * Edit stored procedure "UpdateUsers" if more features should be added.
         * Returns: nothing
         */
        public void updateDatabase()
        {
            using (cnn)
            {
                cnn.Open();
                SqlCommand sqlComm = new SqlCommand(("EXEC UpdateUsers @UserId =" + userID + ", @AccessLevel =" + accessLevel + ", @LockedOut =" + lockedOut + ", @Counter =" + counter + ";"), cnn);
                sqlComm.ExecuteNonQuery();
                cnn.Close();
            }
        }//end updateDatabase


        private void AddUser()
        {
            cnn.Open();
            SqlCommand addUser = new SqlCommand("INSERT INTO Users (username, password, name, accessLevel, lockedOut) VALUES (@username, @pass, @name, @access, @lockedOut)", cnn);
            addUser.Parameters.AddWithValue("@username", username);
            addUser.Parameters.AddWithValue("@pass", password);
            addUser.Parameters.AddWithValue("@name", name);
            addUser.Parameters.AddWithValue("@access", accessLevel);
            addUser.Parameters.AddWithValue("@lockedOut", 0);
            addUser.ExecuteNonQuery();

            SqlCommand getID = new SqlCommand("SELECT MAX(userID) AS maxID FROM Users", cnn);
            SqlDataReader reader = getID.ExecuteReader(); reader.Read();
            userID = Convert.ToInt32(reader["maxID"]); reader.Close();
            cnn.Close();
        }

        private void GetUsername()
        {
            cnn.Open();
            SqlCommand getUsername = new SqlCommand("SELECT username FROM Users WHERE userID=" + userID + ";", cnn);
            SqlDataReader reader = getUsername.ExecuteReader(); reader.Read();
            username = reader["username"].ToString();
            cnn.Close();
        }


    }//end user
}
