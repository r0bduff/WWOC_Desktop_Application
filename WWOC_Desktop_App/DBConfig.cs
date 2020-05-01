/* Class: Users.cs
 * @Authors Rob Duff, Dr.Chilton
 * 
 * Description: Due to increading pressure to add this class it has been developed.
 *              Cheers erupt through zoom call from Chiltons dining room table.
 *              
 *              UPDATE: Nvm this isnt doing anything right now it kinda broke.
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
    class DBConfig
    {
        private static string DATABASE_IP = "10.135.85.184";
        private static string USERNAME = "Group4";
        private static string PASSWORD = "Grp4s2117";
        private static string CATALOG = "GROUP4";
        private static SqlConnection cnn;

        public static SqlConnection getConnection()
        {
            try
            {
                cnn = new SqlConnection("Data Source =" + DATABASE_IP + ";Initial Catalog=" + CATALOG + ";User ID =" + USERNAME + ";Password=" + PASSWORD);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cnn;
        }
    }
}
