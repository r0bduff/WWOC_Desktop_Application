using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /* MAIN MENU NAVIGATION
         * opens the metrics form on button click
         */
        private void btnMetrics_Click(object sender, EventArgs e)
        {
            Form Metrics = new Metrics();
            Metrics.Show();
        }
        /* MAIN MENU NAVIGATION
         * logs the user out of the main menu and back to the login window
         */
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Hide();
        }

        /* ORDER REQUEST TAB
         * When a part is selected the information is updated. This handle the primary updates for the page
         */
        private void cBoxPartDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxPartDescription.Text != "")
            {
                using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
                {
                    cnn.Open();
                    Order order = new Order();
                    order.partID = GetPartID(cnn);
                    int currentstock = 0;
                    order = GetPartInfo(order, cnn, out currentstock);
                    tbUnitPrice.Text = order.unitPrice.ToString();
                    tbShippingTime.Text = order.shippingTime;
                    tbPartID.Text = order.partID.ToString();
                    tbVendor.Text = GetVendorName(order, cnn);
                    tbQtyStock.Text = currentstock.ToString();
                    tbPODate.Text = DateTime.Now.ToString();
                    cnn.Close();
                }
            }

        }

        /* ORDER REQUEST TAB
         * Gets the part ID for the selected part from the drop table
         * Returns: int partID
         */
        private int GetPartID(SqlConnection cnn)
        {
            SqlCommand getPart = new SqlCommand("SELECT partID FROM Parts WHERE itemDesc ='" + cBoxPartDescription.Text + "'", cnn);
            SqlDataReader reader = getPart.ExecuteReader(); reader.Read();
            int partID = Convert.ToInt32(reader["partID"]); reader.Close();
            return partID;
        }

        /* ORDER REQUEST TAB
         * Populates the order class with things from the parts database
         * Returns: order object
         */
        private Order GetPartInfo(Order order, SqlConnection cnn, out int qty)
        {
            SqlCommand getInfo = new SqlCommand("SELECT * FROM Parts WHERE partID ='" + order.partID + "'", cnn);
            SqlDataReader reader = getInfo.ExecuteReader(); reader.Read();
            order.unitPrice = Convert.ToInt32(reader["costUSD"]);
            order.vendorID = Convert.ToInt32(reader["vendorID"]);
            order.shippingTime = reader["shipmentTime"].ToString();
            qty = Convert.ToInt32(reader["qty"]);
            reader.Close();
            return order;
        }

        /* ORDER REQUEST TAB
         * when given a vendor ID it finds the matching name
         * Returns: string name
         */
        private string GetVendorName(Order order, SqlConnection cnn)
        {
            SqlCommand getVendor = new SqlCommand("SELECT vendorName FROM Vendors WHERE vendorID='" + order.vendorID + "'", cnn);
            SqlDataReader reader = getVendor.ExecuteReader(); reader.Read();
            string name = reader["vendorName"].ToString();
            reader.Close();
            return name;
        }
    }
}
