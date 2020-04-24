/* Class: MainMenu.cs
 * @Authors Rob Duff, 
 * 
 * Description: Handles logic behind all tabs within the main menu form
 * 
 */
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
        public int currentUserID;
        private Order order;
        private OrderLineItem item;

        public MainMenu(int currentUser)
        {
            InitializeComponent();
            currentUserID = currentUser;

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP4DataSetOrderLineItem.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter1.Fill(this.gROUP4DataSetOrderLineItem.Parts);
            // TODO: This line of code loads data into the 'gROUP4DataSetOrderLineItem.Order_Line_Item' table. You can move, or remove it, as needed.
            this.order_Line_ItemTableAdapter.Fill(this.gROUP4DataSetOrderLineItem.Order_Line_Item);
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
            if (cBoxPartDescription.Text != "")
            {
                using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
                {
                    cnn.Open();
                    item = new OrderLineItem();
                    item.FillPartInfo(cBoxPartDescription.Text, cnn);

                    //fill textboxes with text duh
                    tbPartID.Text = item.partID.ToString();
                    tbUnitPrice.Text = item.unitPrice.ToString();
                    tbQtyStock.Text = item.qtyOH.ToString();
                    tbVendor.Text = item.ReturnVendorName(cnn);
                    
                    cnn.Close();
                }
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            //Clear Old Order


            //Unlock GroupBoxes
            groupBoxOrderSummary.Enabled = true;
            groupBoxOrderInfo.Enabled = true;
            groupBoxPartInfo.Enabled = true;
            groupBoxRemove.Enabled = true;

            //create new order object
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                cnn.Open();
                order = new Order(currentUserID, cnn);
                cnn.Close();
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                if(tbQtyOrder.Text == "")
                {
                    MessageBox.Show("Please Enter a Quantity");
                }
                else
                {
                    cnn.Open();
                    item.qty = Convert.ToInt32(tbQtyOrder.Text);
                    item.orderID = order.orderID;
                    item.AddOrderLineItem(cnn);

                    cBoxPartDescription.Text = "";
                    tbPartID.Text = "";
                    tbUnitPrice.Text = "";
                    tbQtyStock.Text = "";
                    tbVendor.Text = "";
                    tbQtyOrder.Text = "";
                }//end else
                
            }//end using
        }//end btnAddToOrderCLick
    }
}
