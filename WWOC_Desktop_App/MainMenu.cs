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
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WWOC_Desktop_App
{
    public partial class MainMenu : Form
    {
        public int currentUserID;//bad code ignore pls
        private Order order;//maybe worse also ignore
        private OrderLineItem item;//probably even worse chiltion just keep scrolling

        public MainMenu(int currentUser)
        {
            InitializeComponent();
            currentUserID = currentUser;
        }

        /* Description: 
         * Req: 
         * Returns: 
         */
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gROUP4DataSet.Security' table. You can move, or remove it, as needed.
            this.securityTableAdapter.Fill(this.gROUP4DataSet.Security);
            // TODO: This line of code loads data into the 'gROUP4DataSet2.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter1.Fill(this.gROUP4DataSet2.Vendors);
            // TODO: This line of code loads data into the 'gROUP4DataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.gROUP4DataSet.Location);

            // TODO: This line of code loads data into the 'gROUP4DataSetOrderHistory.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.gROUP4DataSetOrderHistory.Orders);
            this.ordersTableAdapter1.FillBy(this.gROUP4DataSetOrderHistory.Orders);
            // TODO: This line of code loads data into the 'gROUP4DataSetPendingOrders.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.gROUP4DataSetPendingOrders.Orders);
            this.ordersTableAdapter.FillBy(this.gROUP4DataSetPendingOrders.Orders);
            // TODO: This line of code loads data into the 'gROUP4DataSetOrderLineItem.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter1.Fill(this.gROUP4DataSetOrderLineItem.Parts);
            // TODO: This line of code loads data into the 'gROUP4DataSetOrderLineItem.Order_Line_Item' table. You can move, or remove it, as needed.
            this.order_Line_ItemTableAdapter.Fill(this.gROUP4DataSetOrderLineItem.Order_Line_Item);
            // TODO: This line of code loads data into the 'gROUP4DataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.gROUP4DataSet.Vendors);
            // TODO: This line of code loads data into the 'gROUP4DataSetParts.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.gROUP4DataSetParts.Parts);


            SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117");
            SqlDataReader reader = null;
            SqlDataReader reader1 = null;

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


            //prep datagridview on make order page
            dataGridParts.Columns.Add("index", "Index");
            dataGridParts.Columns.Add("itemDesc", "Item Description");
            dataGridParts.Columns.Add("partID", "Part ID");
            dataGridParts.Columns.Add("qty", "Quantity");
            dataGridParts.Columns.Add("unitPrice", "Price per Part");
            //prep datagridview on pending orders page
            dataGridPO_PartsinOrder.Columns.Add("itemDesc", "Item Description");
            dataGridPO_PartsinOrder.Columns.Add("partID", "Part ID");
            dataGridPO_PartsinOrder.Columns.Add("qty", "Quantity");
            dataGridPO_PartsinOrder.Columns.Add("unitPrice", "Price per Part");
            //prep datagridview on order history page
            dataGridOH_PartsInOrder.Columns.Add("itemDesc", "Item Description");
            dataGridOH_PartsInOrder.Columns.Add("partID", "Part ID");
            dataGridOH_PartsInOrder.Columns.Add("qty", "Quantity");
            dataGridOH_PartsInOrder.Columns.Add("unitPrice", "Price per Part");
        }

        /* Description: When the metrics button is clicked the metrics form is opened
         * Req: clicking a button
         * Returns: nothing
         */
        private void btnMetrics_Click(object sender, EventArgs e)
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

                string add = "INSERT INTO Parts (itemDesc, costUSD, vendorID, qty, reorderPoint, exptdLife, shipmentTime, locationID) VALUES (@itemDesc, @Cost, @vendor, @quanit, @reorderPoint, @exptdLife, @shipmentTime, @location)";
                using (SqlCommand cmd = new SqlCommand(add, cnn))
                {

                    //find out new part id
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {

                string addvendor = "INSERT INTO Vendors (vendorName, vendoremail) VALUES (@vendor, @email)";
                using (SqlCommand cmd = new SqlCommand(addvendor, cnn))
                {

                    //find out new part id
                    cmd.Parameters.AddWithValue("@vendor", vendorName.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);

                    cnn.Open();
                    cmd.ExecuteNonQuery();

                    //test
                }

            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                //string addPart = "INSERT INTO Parts VALUES (" + partID + ", " + itemDesc + ", " + Cost + ", " + vendor + ", " + quanit + ", " + reorderPoint + ", " + expectLife + ", " + shipmentTime + ", " + locationID + ")";

                //edit code to get job title access level
                /*string vID = "SELECT vendorID FROM Vendors WHERE vendorName = (@name)";
                using (SqlCommand comm = new SqlCommand(vID, cnn))
                {
                    comm.Parameters.AddWithValue("@name", vendorNameComboBox.SelectedValue.ToString());

                    cnn.Open();
                    vendorNumber = (int)comm.ExecuteScalar();
                    cnn.Close();
                }*/

                string addUser = "INSERT INTO Users (username, password, name, accesslevel, lockedOut) VALUES (@username, @pass, @name, @access, @lockedOut)";
                if(password.Text == confirmPassword.Text)
                {
                    using (SqlCommand cmd = new SqlCommand(addUser, cnn))
                    {

                        //find out new part id
                        cmd.Parameters.AddWithValue("@username", NameUser.Text);
                        cmd.Parameters.AddWithValue("@pass", username.Text);
                        cmd.Parameters.AddWithValue("@name", password.Text);
                        cmd.Parameters.AddWithValue("@access", 1);
                        cmd.Parameters.AddWithValue("@lockedOut", 0);


                        //test
                        try
                        {
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User Added!");
                        }
                        catch (Exception eff)
                        {
                            MessageBox.Show("User was unable to be added.");
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }



            }
        }

        private void addLocation_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {

                string addloc = "INSERT INTO Location (name, type, Street, City, State, ZIP) VALUES (@name, @type, @st, @city, @state, @zip)";
                using (SqlCommand cmd = new SqlCommand(addloc, cnn))
                {

                    //find out new part id
                    cmd.Parameters.AddWithValue("@name", locationName.Text);
                    cmd.Parameters.AddWithValue("@type", typeLoc.Text);
                    cmd.Parameters.AddWithValue("@st", Street.Text);
                    cmd.Parameters.AddWithValue("@city", city.Text);
                    cmd.Parameters.AddWithValue("@state", state.Text);
                    cmd.Parameters.AddWithValue("@zip", zip.Text);
                        
                    cnn.Open();
                    cmd.ExecuteNonQuery();

                    //test
                }

            }
        }

        /* Description: When the logout button is clicked the main menu is closed
         * Req: clicking the button
         * Returns: nothing
         */
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Hide();
        }

        /* PAGE: Order Request 
         * Description: When a part is selected from the drop down menu the information below
         *              is updated to describe the selected part.
         * Req: selecting a part
         * Returns: displays some info on the order request page
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

        /* PAGE: Order request
         * Description: Creates a new Order and allows the user to start selecting parts
         *              this may have been added due to my own stupidity, but it works so we aint complaining.
         *              Also utilized to update some stuff on the form page that needed to be done manually.
         * Req: clicking the button
         * Returns: Enables text boxes, adds some columns to the datagrid
         */
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
           
            //Unlock GroupBoxes
            groupBoxOrderSummary.Enabled = true;
            groupBoxOrderInfo.Enabled = true;
            groupBoxPartInfo.Enabled = true;
            groupBoxRemove.Enabled = true;
            cBoxRemove.Items.Add("");

            //create new order object
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                cnn.Open();
                order = new Order(currentUserID, cnn);
                cnn.Close();
            }
        }

        /* PAGE: Order request
         * Description: Add a new part to the order. Also updates the data grid view and wipes old info from part info groupbox
         * Req: clicking the button
         * Returns: not much, but does some background stuffs
         */
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
                    order.AddPartToOrder(item);
                    AddItemToDataGrid();
                    order.CalculateFinalCosts();

                    cBoxPartDescription.Text = "";
                    tbPartID.Text = "";
                    tbUnitPrice.Text = "";
                    tbQtyStock.Text = "";
                    tbVendor.Text = "";
                    tbQtyOrder.Text = "";

                    tbSubTotal.Text = order.subtotal.ToString();
                    tbSalesTax.Text = order.salesTax.ToString();
                    tbShippingHandling.Text = order.shippingHandling.ToString();
                    tbTotalPrice.Text = order.totalPrice.ToString();
                    tbPODate.Text = DateTime.Now.ToString();

                }//end else
                cnn.Close();
            }//end using
        }//end btnAddToOrderCLick

        /* PAGE: Order request
         * Description: Adds and item to the dataGrid. Did I really need a method for this not really but its here.
         *              Also populates the remove combo box list of stuff so this is important dont delete.
         * Req: nothing
         * Returns: updates combo box and datagridview
         */
        private void AddItemToDataGrid()
        {
            dataGridParts.Rows.Add(dataGridParts.Rows.Count, item.itemDesc, item.partID, item.qty, item.unitPrice);
            cBoxRemove.Items.Add(item.itemDesc);  
        }

        /* PAGE: Order request
         * Description: Does some selection on the datagridview when you select a part in the combo box.
         *              was not intending to do this but it seemed like fun so i made it real quick.
         * Req: select a part from the menu
         * Returns: does some cool color things yay
         */
        private void cBoxRemove_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderLineItem[] arrCart = order.cart.ToArray();
            if (cBoxRemove.Text != "")
            {
                for(int i = 0; i < arrCart.Length; i++)
                {
                    if(cBoxRemove.Text == arrCart[i].itemDesc)
                    {
                        dataGridParts.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dataGridParts.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            else
            {
                for(int i = 0; i < dataGridParts.Rows.Count; i++)
                {
                    dataGridParts.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        /* PAGE: Order request
         * Description: Removes an item from the datagrid or cart
         * Req: nothin
         * Returns: drops that boi from the list
         */
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                cnn.Open();
                string itemDesc = cBoxRemove.Text;
                int index;
                order.RemovePartFromOrder(itemDesc, cnn, out index);
                dataGridParts.Rows.RemoveAt(index);
                cnn.Close();
            }
        }

        /* PAGE: Order request
         * Description: Submits the order for approval or sends it out if you have the authority
        * Req: nothing
        * Returns: clears the page and updates the db
        */
        private void btnSubmitOrderRequest_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                cnn.Open();
                order.poDate = DateTime.Now;
                order.terms = tbTerms.Text;
                order.approved = checkBoxApprove.Checked;
                order.UpdateDatabase(cnn);
                cnn.Close();
            }

            groupBoxOrderSummary.Enabled = false;
            groupBoxOrderInfo.Enabled = false;
            groupBoxPartInfo.Enabled = false;
            groupBoxRemove.Enabled = false;
            cBoxRemove.Items.Clear();

            dataGridParts.Rows.Clear();

            UpdateDataGridPO();

            tbTotalPrice.Text = "";
            tbTerms.Text = "";
            tbSubTotal.Text = "";
            tbShippingTime.Text = "";
            tbShippingHandling.Text = "";
            tbSalesTax.Text = "";
            tbPODate.Text = "";

            checkBoxApprove.Checked = false;

            item = new OrderLineItem();
        }

        /* PAGE: Approve Order
         * Description: this stupid idiot is hidden behind a groupbox on the pending orders page
         * Req: nothing
         * Returns: this dude does a little query on the datagridPO_PendingOrders
         */
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.FillBy(this.gROUP4DataSetPendingOrders.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        /* PAGE: Approve Order
         * Description: when a user clicks an item in the datagridview this then updates the page with some more details for them.
         * Req: event triggered on user mouse click
         * Returns: updates the text boxes on the approve order page with selected information.
         */
        private void dataGridPO_PendingOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            { 
                DataGridViewRow row = dataGridPO_PendingOrders.Rows[e.RowIndex];
                using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
                {
                    cnn.Open();
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    order = new Order(id, cnn, currentUserID);
                    cnn.Close();
                }

                tbPO_OrderID.Text = order.orderID.ToString();
                tbPO_Username.Text = order.userID.ToString();//change to a username
                tbPO_PODate.Text = order.poDate.ToString();
                tbPO_ShipTime.Text = order.shippingTime.ToString();
                tbPO_Terms.Text = order.terms.ToString();
                tbPO_SubTotal.Text = order.subtotal.ToString();
                tbPO_SalesTax.Text = order.salesTax.ToString();
                tbPO_ShippingHandling.Text = order.shippingHandling.ToString();
                tbPO_TotalPrice.Text = order.totalPrice.ToString();

                dataGridPO_PartsinOrder.Rows.Clear();
                OrderLineItem[] arrCart = order.cart.ToArray();
                for (int i = 0; i < arrCart.Length; i++)
                {
                    dataGridPO_PartsinOrder.Rows.Add(arrCart[i].itemDesc, arrCart[i].partID, arrCart[i].qty, arrCart[i].unitPrice);
                }
                
            }
        }

       /* PAGE: Approve Order
        * Description: Approves the order on button click, and changes the status in the db
        * Req: nothin
        * Returns: updates the db
        */
        private void btnApproveOrder_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                cnn.Open();
                order.ApproveOrderDB(cnn);
                cnn.Close();
            }
            MessageBox.Show("Order Approved");

            tbPO_OrderID.Text = "";
            tbPO_Username.Text = "";
            tbPO_PODate.Text = "";
            tbPO_ShipTime.Text = "";
            tbPO_Terms.Text = "";
            tbPO_SubTotal.Text = "";
            tbPO_SalesTax.Text = "";
            tbPO_ShippingHandling.Text = "";
            tbPO_TotalPrice.Text = "";

            dataGridPO_PartsinOrder.Rows.Clear();
            UpdateDataGridPO();
        }

      /* PAGE: Approve Order
       * Description: Removes and cancels the order request on button click. Order information is removed from the db
       * Req: nothin
       * Returns: updates the db
       */
        private void btnRejectOrder_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
            {
                cnn.Open();
                order.RemoveOrderDB(cnn);
                cnn.Close();
            }

            MessageBox.Show("Order Rejected and Removed");

            tbPO_OrderID.Text = "";
            tbPO_Username.Text = "";
            tbPO_PODate.Text = "";
            tbPO_ShipTime.Text = "";
            tbPO_Terms.Text = "";
            tbPO_SubTotal.Text = "";
            tbPO_SalesTax.Text = "";
            tbPO_ShippingHandling.Text = "";
            tbPO_TotalPrice.Text = "";

            dataGridPO_PartsinOrder.Rows.Clear();

            UpdateDataGridPO();
        }

        /* PAGE: Approve Order
       * Description: updates the datagridview to match what is in the DB
       * Req: nothin
       * Returns: updates the datagridPO_PendingOrders
       */
        private void UpdateDataGridPO()
        {
            this.ordersTableAdapter.Fill(this.gROUP4DataSetPendingOrders.Orders);
            dataGridPO_PendingOrders.Refresh();
            this.ordersTableAdapter.FillBy(this.gROUP4DataSetPendingOrders.Orders);
        }

        /* PAGE: Order History
        * Description: queries out unapproved orders from orders table
        * Req: nothing
        * Returns: updates the order history datagridview
        */
        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter1.FillBy(this.gROUP4DataSetOrderHistory.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        /* PAGE: Order History
       * Description: when a user clicks an item in the datagridview this then updates the page with some more details for them.
       * Req: click a cell
       * Returns: updates the order details datagridview
       */
        private void dataGridOH_orderHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridOH_orderHistory.Rows[e.RowIndex];
                using (SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117"))
                {
                    cnn.Open();
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    order = new Order(id, cnn, currentUserID);
                    cnn.Close();
                }

                tbOH_orderID.Text = order.orderID.ToString();
                tbOH_username.Text = order.userID.ToString();//change to a username
                tbOH_POdate.Text = order.poDate.ToString();
                tbOH_shippingTime.Text = order.shippingTime.ToString();
                tbOH_terms.Text = order.terms.ToString();
                tbOH_subtotal.Text = order.subtotal.ToString();
                tbOH_salesTax.Text = order.salesTax.ToString();
                tbOH_shippingHandling.Text = order.shippingHandling.ToString();
                tbOH_totalPrice.Text = order.totalPrice.ToString();

                dataGridOH_PartsInOrder.Rows.Clear();
                OrderLineItem[] arrCart = order.cart.ToArray();
                for (int i = 0; i < arrCart.Length; i++)
                {
                    dataGridOH_PartsInOrder.Rows.Add(arrCart[i].itemDesc, arrCart[i].partID, arrCart[i].qty, arrCart[i].unitPrice);
                }

            }
        }

       


    }
}
