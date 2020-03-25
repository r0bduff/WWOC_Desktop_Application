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
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                cnn.Open();
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                if(isUsername(username, cnn) == true)
                {
                    int counter = pullCounter(username, cnn);
                    if (isLocked(username, counter, cnn) == false)
                    {
                        int userId;
                        if(isPassword(username, password, cnn, out userId) == true)
                        {
                            //login successful
                            user user = getUser(userId, cnn);
                            pushCounter(user.username, 0, cnn);
                            Form mainmenu = new MainMenu();
                            mainmenu.Show();
                        }
                        else
                        {
                            counter++;
                            if(isLocked(username, counter, cnn) == true)
                            {
                                pushCounter(username, counter, cnn);
                                MessageBox.Show("Account is locked please contact an admin");
                            }
                            else
                            {
                                pushCounter(username, counter, cnn);
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


                cnn.Close();
            }//end using
        }//end button click

        /* Method checks to see if the user is locked out of their account, will update lockedout if found that user is locked out.
         * Req: string username - username of the user
         *      int counter - counter of attempts user has made
         *      SqlConnection cnn - SqlConnection to the database with user information
         * Returns: Boolean true if the account is locked
         *          False if the account is not locked
         */
        private static Boolean isLocked(string username, int counter, SqlConnection cnn)
        {
            try
            {
                SqlCommand commLocked = new SqlCommand("EXEC isLocked @Username =" + username + ";", cnn);
                SqlDataReader reader = commLocked.ExecuteReader(); reader.Read();
                Boolean test = Convert.ToBoolean(reader["lockedOut"]); reader.Close();
                reader.Close();

                if(test == true)
                {
                    return true;
                }
                else
                {
                    if (counter >= 3)
                    {
                        commLocked = new SqlCommand("EXEC lockUser @Username =" + username + ";", cnn);
                        commLocked.ExecuteNonQuery();
                        return true;
                    }
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("isLocked broke : " + ex);
            }
            return false;
        }

        /* Method checks to see if the username exists in the database
         * Req: string username - username of the user
         *      SqlConnection cnn - SqlConnection to the database with user information
         * Returns: Boolean true if the account exists
         *          False if the account does not exist
         */
        private static Boolean isUsername(string username, SqlConnection cnn)
        {
            try
            {
                SqlCommand commUsername = new SqlCommand("EXEC isUsername @Username =" + username + ";", cnn);
                SqlDataReader reader = commUsername.ExecuteReader(); reader.Read();
                
                if (reader.HasRows == true)
                {
                    reader.Close();
                    return true;
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("isUsername broke : " + ex);
            }
            return false;
        }

        /* Method checks to see if the password matches the username
        * Req: string username - username given by the user
        *      string password - password given by the user
        *      SqlConnection cnn - SqlConnection to the database with user information
        *      int userId - blank int variable to be filled with the userId of the given username
        * Returns: Boolean true if the password is right
        *          False if the password is not right
        *          userId = the matching userID
        *          userId = 0 if the password didnt match
        */
        private static Boolean isPassword(string username, string password, SqlConnection cnn, out int userId)
        {
            try
            {
                SqlCommand commPassword = new SqlCommand("EXEC checkUsername @Username =" + username + ", @Password =" + password + ";", cnn);
                SqlDataReader reader = commPassword.ExecuteReader(); reader.Read();
                if (reader.HasRows == true)
                {
                    userId = Convert.ToInt32(reader["userId"]);
                    reader.Close();
                    return true;
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("isPassword broke : " + ex);
            }
            userId = 0;
            return false;
        }

        /* Method that populates a new user object when given a userId
         * Req: int userId - userId matching a user in the database
         * Returns: user object containg information from the database matching the given userId
         */
        private static user getUser(int userId, SqlConnection cnn)
        {
            user user = new user();
            try
            {
                SqlCommand commUser = new SqlCommand("EXEC PullUser @UserId =" + userId + ";", cnn);
                SqlDataReader reader = commUser.ExecuteReader(); reader.Read();

                user.UserID = userId;
                user.username = reader["username"].ToString();
                user.password = reader["password"].ToString();
                user.name = reader["name"].ToString();
                user.accessLevel = Convert.ToInt32(reader["accesslevel"]);
                user.lockedOut = Convert.ToInt32(reader["lockedOut"]);
                user.counter = 0;

                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("getUser Broke : " + ex);
            }

            return user;
        }


        /* Method that pulls the counter for a username
         * Req: string username - username given by the user
         *      SqlConnection cnn - SqlConnection to the database with user information
         * Returns: int containing the current value of the counter
         */
        private static int pullCounter(string username, SqlConnection cnn)
        {
            int counter = -1;
            try
            {
                string pullCounter = "EXEC pullCounter @Username =" + username + ";";
                SqlCommand commCounter = new SqlCommand(pullCounter, cnn);
                SqlDataReader reader = commCounter.ExecuteReader(); reader.Read();
                counter = Convert.ToInt32(reader["counter"]);
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("pullCounter Broke : " + ex);
            }
            return counter;
        }


        /* Methos that updates the counter for a given username.
         * Req: string username - username given by the user
         *      int counter - current value of the counter
         *      SqlConnection cnn - SqlConnection to the database with user information
         * Returns: nothing
         */
        private void pushCounter(string username, int counter, SqlConnection cnn)
        {
            try
            {
                string pushCounter = "EXEC incrementCounter @Username =" + username + ", @Counter =" + counter + ";";
                SqlCommand commCounter2 = new SqlCommand(pushCounter, cnn);
                commCounter2.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("incemenetCounter Broke : " + ex);
            }
        }


        
    }//end login class
}
