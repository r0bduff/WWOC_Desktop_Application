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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP4DataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.gROUP4DataSet.Vendors);
            // TODO: This line of code loads data into the 'gROUP4DataSetParts.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.gROUP4DataSetParts.Parts);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Metrics = new Metrics();
            Metrics.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                string addPart = "INSERT INTO Parts VALUES (" + partID + ", " + itemDesc + ", " + Cost + ", " + vendor + ", " + quanit + ", " + reorderPoint + ", " + expectLife + ", " + shipmentTime + ", " + locationID + ")";

                string add = "INSERT INTO Parts VALUES (@partID, @itemDesc, @Cost, @vendor, @quanit, @reorderPoint, @expectLife, @shipmentTime, @location)";
                using (SqlCommand cmd = new SqlCommand(addPart, cnn))
                {
                    cmd.Parameters.AddWithValue("@partID", partID.Text);
                    cmd.Parameters.AddWithValue("@itemDesc", itemDesc.Text);
                    cmd.Parameters.AddWithValue("@Cost", Cost.Text);
                    cmd.Parameters.AddWithValue("@vendor", vendor.Text);
                    cmd.Parameters.AddWithValue("@quanit", quanit.Text);
                    cmd.Parameters.AddWithValue("@reorderPoint", reorderPoint.Text);
                    cmd.Parameters.AddWithValue("@expectLife", expectLife.Text);
                    cmd.Parameters.AddWithValue("@shipmentTime", shipmentTime.Text);
                    cmd.Parameters.AddWithValue("@location", locationIDPart.Text);
                    
                    
                    cnn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if(result< 0)
                    {
                        MessageBox.Show("There was a problem adding part");
                    }
                    cnn.Close();
                }


            }







            /*OleDbDataReader readerReturnValue = cmdNotReturned.ExecuteReader(CommandBehavior.CloseConnection);

            cnn.Open();

            cmd = new SqlCommand(addPart, cnn);
            

            MessageBox.Show("Added " + itemDesc);
*/



            
    }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                //string addPart = "INSERT INTO Parts VALUES (" + partID + ", " + itemDesc + ", " + Cost + ", " + vendor + ", " + quanit + ", " + reorderPoint + ", " + expectLife + ", " + shipmentTime + ", " + locationID + ")";

                string add = "INSERT INTO Parts VALUES (@partID, @itemDesc, @Cost, @vendor, @quanit, @reorderPoint, @expectLife, @shipmentTime, @location)";
                using (SqlCommand cmd = new SqlCommand(add, cnn))
                {
                    cmd.Parameters.AddWithValue("@partID", partID.Text);
                    cmd.Parameters.AddWithValue("@itemDesc", itemDesc.Text);
                    cmd.Parameters.AddWithValue("@Cost", Cost.Text);
                    cmd.Parameters.AddWithValue("@vendor", vendor.Text);
                    cmd.Parameters.AddWithValue("@quanit", quanit.Text);
                    cmd.Parameters.AddWithValue("@reorderPoint", reorderPoint.Text);
                    cmd.Parameters.AddWithValue("@expectLife", expectLife.Text);
                    cmd.Parameters.AddWithValue("@shipmentTime", shipmentTime.Text);
                    cmd.Parameters.AddWithValue("@location", locationIDPart.Text);
                    //test 

                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    /*if (result < 0)
                    {
                        MessageBox.Show("There was a problem adding part");
                    }*/
                    cnn.Close();
                }


            }
        }
    }
}
