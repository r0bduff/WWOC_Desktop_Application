/* Class: Login.cs
 * @Authors Rob Duff
 * 
 * Description: Handles logic of confirming a user to login into the application
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WWOC_Desktop_App
{
    //to use panels or tab control for multiple form selection. 
    public partial class Login : Form
    {
        private SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117");

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            int accessLevel = 0;

            if (isUsername(username) == true)
            {
                int counter = pullCounter(username);
                if (isLocked(username, counter) == false)
                {
                    int userId;
                    if (isPassword(username, password, out userId) == true)
                    {
                        //login successful
                        User user = new User(userId);
                        pushCounter(user.username, 0);
                        accessLevel = user.getAccessLevel();
                        Form mainmenu = new MainMenu(userId, accessLevel);
                        this.Hide();
                        mainmenu.Show(); 
                    }
                    else
                    {
                        counter++;
                        if (isLocked(username, counter) == true)
                        {
                            pushCounter(username, counter);
                            MessageBox.Show("Account is locked please contact an admin");
                        }
                        else
                        {
                            pushCounter(username, counter);
                            MessageBox.Show("Login Failed (password)");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Account is locked please contact an admin");
                }
            }
            else
            {
                MessageBox.Show("Login Failed (no username)");
            }
            
        }//end button click

        /* Description: Method checks to see if the user is locked out of their account, will update lockedout if found that user is locked out.
         * Req: string username - username of the user
         *      int counter - counter of attempts user has made
         *      SqlConnection cnn - SqlConnection to the database with user information
         * Returns: Boolean true if the account is locked
         *          False if the account is not locked
         */
        private Boolean isLocked(string username, int counter)
        {

            cnn.Open();
            SqlCommand commLocked = new SqlCommand("EXEC isLocked @Username =" + username + ";", cnn);
            SqlDataReader reader = commLocked.ExecuteReader(); reader.Read();
            Boolean test = Convert.ToBoolean(reader["lockedOut"]); reader.Close();
            reader.Close();
            cnn.Close();
            if (test == true)
            {
                return true;
            }
            else
            {
                if (counter >= 3)
                {
                    cnn.Open();
                    commLocked = new SqlCommand("EXEC lockUser @Username =" + username + ";", cnn);
                    commLocked.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
                return false;
            }
        }

        /* Description: Method checks to see if the username exists in the database
         * Req: string username - username of the user
         *      SqlConnection cnn - SqlConnection to the database with user information
         * Returns: Boolean true if the account exists
         *          False if the account does not exist
         */
        private Boolean isUsername(string username)
        {
            cnn.Open();
            SqlCommand commUsername = new SqlCommand("EXEC isUsername @Username =" + username + ";", cnn);
            SqlDataReader reader = commUsername.ExecuteReader(); reader.Read();

            if (reader.HasRows == true)
            {
                reader.Close();
                cnn.Close();
                return true;
            }
            reader.Close();
            cnn.Close();

            return false;
        }

        /* Description: Method checks to see if the password matches the username
        * Req: string username - username given by the user
        *      string password - password given by the user
        *      SqlConnection cnn - SqlConnection to the database with user information
        *      int userId - blank int variable to be filled with the userId of the given username
        * Returns: Boolean true if the password is right
        *          False if the password is not right
        *          userId = the matching userID
        *          userId = 0 if the password didnt match
        */
        private Boolean isPassword(string username, string password, out int userId)
        {
            cnn.Open();
            SqlCommand commPassword = new SqlCommand("EXEC checkUsername @Username =" + username + ", @Password =" + password + ";", cnn);
            SqlDataReader reader = commPassword.ExecuteReader(); reader.Read();
            if (reader.HasRows == true)
            {
                userId = Convert.ToInt32(reader["userId"]);
                reader.Close();
                cnn.Close();
                return true;
            }
            reader.Close();
            cnn.Close();
            userId = 0;
            return false;
        }

        /* Description: Method that pulls the counter for a username
         * Req: string username - username given by the user
         *      SqlConnection cnn - SqlConnection to the database with user information
         * Returns: int containing the current value of the counter
         */
        private int pullCounter(string username)
        {
            int counter = -1;
            cnn.Open();
            string pullCounter = "EXEC pullCounter @Username =" + username + ";";
            SqlCommand commCounter = new SqlCommand(pullCounter, cnn);
            SqlDataReader reader = commCounter.ExecuteReader(); reader.Read();
            counter = Convert.ToInt32(reader["counter"]);
            reader.Close();
            cnn.Close();
            return counter;
        }


        /* Description: Method that updates the counter for a given username.
         * Req: string username - username given by the user
         *      int counter - current value of the counter
         *      SqlConnection cnn - SqlConnection to the database with user information
         * Returns: nothing
         */
        private void pushCounter(string username, int counter)
        {
            cnn.Open();
            string pushCounter = "EXEC incrementCounter @Username =" + username + ", @Counter =" + counter + ";";
            SqlCommand commCounter2 = new SqlCommand(pushCounter, cnn);
            commCounter2.ExecuteNonQuery();
            cnn.Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Form mainmenu = new MainMenu(1,2);
            mainmenu.Show();
        }

    }//end login class
}
