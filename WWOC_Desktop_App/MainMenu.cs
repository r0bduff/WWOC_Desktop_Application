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
            // TODO: This line of code loads data into the 'gROUP4DataSet2.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter1.Fill(this.gROUP4DataSet2.Vendors);
            // TODO: This line of code loads data into the 'gROUP4DataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.gROUP4DataSet.Location);
            // TODO: This line of code loads data into the 'gROUP4DataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.gROUP4DataSet.Vendors);
            // TODO: This line of code loads data into the 'gROUP4DataSetParts.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.gROUP4DataSetParts.Parts);

            SqlConnection cnn = null;
            SqlDataReader reader = null;
            SqlDataReader reader1 = null;
            cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117");

            cnn.Open();

            SqlCommand ven = new SqlCommand("SELECT DISTINCT vendorName FROM Vendors", cnn);
            SqlCommand location = new SqlCommand("SELECT DISTINCT locationID FROM Location", cnn);

            reader = ven.ExecuteReader();

            DataSet dsvendor = new DataSet();

            DataTable dtvendor = new DataTable("Table1");

            dsvendor.Tables.Add(dtvendor);

            dsvendor.Load(reader, LoadOption.PreserveChanges, dsvendor.Tables[0]);

            vendorNameComboBox.ValueMember = "vendorName";
            vendorNameComboBox.DisplayMember = "vendorName";
            vendorNameComboBox.DataSource = dsvendor.Tables[0];
            vendorNameComboBox.SelectedIndex = 0;
            vendorNameComboBox.SelectedValue = 0;

            reader1 = location.ExecuteReader();

            DataSet dslocation = new DataSet();

            DataTable dtlocation = new DataTable("Table2");


            dslocation.Tables.Add(dtlocation);

            dslocation.Load(reader1, LoadOption.PreserveChanges, dslocation.Tables[0]);


            locationIDComboBox.ValueMember = "locationID";
            locationIDComboBox.DisplayMember = "locationID";
            locationIDComboBox.DataSource = dslocation.Tables[0];
            locationIDComboBox.SelectedIndex = 0;
            locationIDComboBox.SelectedValue = 0;


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
        { }


            

        private void button2_Click(object sender, EventArgs e)
        {
            int vendorNumber;
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                //string addPart = "INSERT INTO Parts VALUES (" + partID + ", " + itemDesc + ", " + Cost + ", " + vendor + ", " + quanit + ", " + reorderPoint + ", " + expectLife + ", " + shipmentTime + ", " + locationID + ")";

                string vID = "SELECT vendorID FROM Vendors WHERE vendorName = (@name)";
                using(SqlCommand comm = new SqlCommand(vID, cnn))
                {
                    comm.Parameters.AddWithValue("@name", vendorNameComboBox.SelectedValue.ToString());

                    cnn.Open();
                    vendorNumber = (int)comm.ExecuteScalar();
                    cnn.Close();
                }

                string add = "INSERT INTO Parts (partID, itemDesc, costUSD, vendorID, qty, reorderPoint, exptdLife, shipmentTime, locationID) VALUES (@partID, @itemDesc, @Cost, @vendor, @quanit, @reorderPoint, @exptdLife, @shipmentTime, @location)";
                using (SqlCommand cmd = new SqlCommand(add, cnn))
                {

                    //find out new part id
                    cmd.Parameters.AddWithValue("@partID", "65432");
                    cmd.Parameters.AddWithValue("@itemDesc", itemDesc.Text);
                    cmd.Parameters.AddWithValue("@Cost", Cost.Text);
                    cmd.Parameters.AddWithValue("@vendor", vendorNumber);
                    cmd.Parameters.AddWithValue("@quanit", quanit.Text);
                    cmd.Parameters.AddWithValue("@reorderPoint", reorderPoint.Text);
                    cmd.Parameters.AddWithValue("@exptdLife", exptdLife.Text);
                    cmd.Parameters.AddWithValue("@shipmentTime", shipmentTime.Text);
                    cmd.Parameters.AddWithValue("@location", locationIDComboBox.SelectedValue);
                    //test 
                    
                    
                    try
                    {
                        cnn.Open();
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show("Part Added!");
                    }
                    catch (Exception eff)
                    {
                        MessageBox.Show("Part unable to be added.");
                    }

                }


            }
        }

        private void vendorNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void locationIDNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void exptdLife_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
