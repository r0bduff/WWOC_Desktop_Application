/* Class: MainMenu.cs
 * @Authors Rob Duff, Luis Jimenez, Miranda Gleason
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
        public int currentUserID;//bad code ignore pls
        private int accessLevel;
        private Order order;//maybe worse also ignore
        private OrderLineItem item;//probably even worse chiltion just keep scrolling
        private SqlConnection cnn = new SqlConnection("Data Source=10.135.85.184;Initial Catalog=GROUP4;User ID=Group4;Password=Grp4s2117");

        public MainMenu(int currentUser, int accessLevel)
        {
            InitializeComponent();
            currentUserID = currentUser;
            this.accessLevel = accessLevel;
        }



        /* Description: 
         * Req: 
         * Returns: 
         */
        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            //DATAGRID TABLE LOADING
            //Location
            this.locationTableAdapter.Fill(this.gROUP4DataSetLocation.Location);
            //Users
            this.usersTableAdapter.Fill(this.gROUP4DataSetUsers.Users);
            //OrderConfirmation
            this.ordersTableAdapter2.FillByApprovedReceived(this.gROUP4DataSetOrderConfirmation.Orders);
            //OrderPending
            this.ordersTableAdapter.FillBy(this.gROUP4DataSetPendingOrders.Orders);
            //OrderRequest1
            this.partsTableAdapter1.Fill(this.gROUP4DataSetOrderLineItem.Parts);
            //OrderRequest2
            this.order_Line_ItemTableAdapter.Fill(this.gROUP4DataSetOrderLineItem.Order_Line_Item);
            //Vendors
            this.vendorsTableAdapter.Fill(this.gROUP4DataSet.Vendors);
            //Inventory
            this.partsTableAdapter.Fill(this.gROUP4DataSetParts.Parts);

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

            //test on visibility for access level 1
            if (accessLevel == 1)
            {
                //hides buttons for orders
                btnConfirmOrder.Visible = false;
                btnRejectOrder.Visible = false;
                //hides for create orders
                btnCreateOrder.Enabled = false;

                //hides tab for manage
                tabControlMain.TabPages.Remove(DGVMainMenu);
            }else if(accessLevel == 3)
            {
                //hides buttons for orders
                btnConfirmOrder.Visible = false;
                btnRejectOrder.Visible = false;

                //hides tab for manage
                tabControlMain.TabPages.Remove(DGVMainMenu);
            }
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

        //---------------------------------------------------------------------------ORDER REQUEST TAB METHODS---------------------------------------------------------------------------

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
                item = new OrderLineItem();
                cnn.Open();
                    item.FillPartInfo(cBoxPartDescription.Text, cnn);
                cnn.Close();

                //fill textboxes with text duh
                tbPartID.Text = item.partID.ToString();
                tbUnitPrice.Text = item.unitPrice.ToString();
                tbQtyStock.Text = item.qtyOH.ToString();
                cnn.Open();
                    tbVendor.Text = item.ReturnVendorName(cnn);
                cnn.Close();
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

            cnn.Open();
                order = new Order(currentUserID, cnn);
            cnn.Close();

            btnCreateOrder.Enabled = false;
        }

        /* PAGE: Order request
         * Description: Add a new part to the order. Also updates the data grid view and wipes old info from part info groupbox
         * Req: clicking the button
         * Returns: not much, but does some background stuffs
         */
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (tbQtyOrder.Text == "")
            {
                MessageBox.Show("Please Enter a Quantity");
            }
            else
            {
                item.qty = Convert.ToInt32(tbQtyOrder.Text);
                item.orderID = order.orderID;
                cnn.Open();
                    item.AddOrderLineItem(cnn);
                cnn.Close();
                order.AddPartToOrder(item);
                AddItemToDataGrid();
                order.CalculateFinalCosts();

                cBoxPartDescription.Text = "";
                tbPartID.Text = "";
                tbUnitPrice.Text = "";
                tbQtyStock.Text = "";
                tbVendor.Text = "";
                tbQtyOrder.Text = "";

                tbSubTotal.Text = order.subtotal.ToString("C2");
                tbSalesTax.Text = order.salesTax.ToString("C2");
                tbShippingHandling.Text = order.shippingHandling.ToString("C2");
                tbTotalPrice.Text = order.totalPrice.ToString("C2");
                tbPODate.Text = DateTime.Now.ToString();

            }//end else
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
            string itemDesc = cBoxRemove.Text;
            int index;
            order.RemovePartFromOrder(itemDesc, out index);
            cBoxRemove.Items.RemoveAt(index + 1);
            dataGridParts.Rows.RemoveAt(index);
        }

        /* PAGE: Order request
         * Description: Submits the order for approval or sends it out if you have the authority
        * Req: nothing
        * Returns: clears the page and updates the db
        */
        private void btnSubmitOrderRequest_Click(object sender, EventArgs e)
        {
            order.poDate = DateTime.Now;
            order.terms = tbTerms.Text;

            //Check to see if the order should be auto approved or not
            if (accessLevel == 2)
                order.approved = checkBoxApprove.Checked;
            else if (order.totalPrice > 25000)
                order.approved = false;
            else
                order.approved = true;
            cnn.Open();
                order.UpdateDatabase(cnn);
            cnn.Close();

            groupBoxOrderSummary.Enabled = false;
            groupBoxOrderInfo.Enabled = false;
            groupBoxPartInfo.Enabled = false;
            groupBoxRemove.Enabled = false;
            btnCreateOrder.Enabled = true;
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

        //---------------------------------------------------------------------------APPROVE ORDER TAB METHODS---------------------------------------------------------------------------
        
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
                int id = Convert.ToInt32(row.Cells[0].Value);
                cnn.Open();
                    order = new Order(id, currentUserID, cnn);
                cnn.Close();

                tbPO_OrderID.Text = order.orderID.ToString();
                User findUser = new User(order.userID);
                tbPO_Username.Text = findUser.username;
                tbPO_PODate.Text = order.poDate.ToString();
                tbPO_ShipTime.Text = order.shippingTime.ToString();
                tbPO_Terms.Text = order.terms.ToString();
                tbPO_SubTotal.Text = order.subtotal.ToString("C2");
                tbPO_SalesTax.Text = order.salesTax.ToString("C2");
                tbPO_ShippingHandling.Text = order.shippingHandling.ToString("C2");
                tbPO_TotalPrice.Text = order.totalPrice.ToString("C2");

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
            cnn.Open();
                order.ApproveOrderDB(cnn);
            cnn.Close();
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
            cnn.Open();
                order.RemoveOrderDB(cnn);
            cnn.Close();

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
           this.ordersTableAdapter.FillBy(this.gROUP4DataSetPendingOrders.Orders);
           this.ordersTableAdapter2.FillByApprovedReceived(this.gROUP4DataSetOrderConfirmation.Orders);
        }

        //---------------------------------------------------------------------------ORDER CONFIRMATION TAB METHODS---------------------------------------------------------------------------

        /* PAGE: Order Confirmation
       * Description: when a user clicks an item in the datagridview this then updates the page with some more details for them.
       * Req: click a cell
       * Returns: updates the order details datagridview
       */
        private void dataGridOH_orderHistory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridOH_orderHistory.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells[0].Value);
                cnn.Open();
                    order = new Order(id, currentUserID, cnn);
                cnn.Close();

                tbOH_orderID.Text = order.orderID.ToString();
                User findUser = new User(order.userID);
                tbOH_username.Text = findUser.username;
                tbOH_POdate.Text = order.poDate.ToString();
                tbOH_shippingTime.Text = order.shippingTime.ToString();
                tbOH_terms.Text = order.terms.ToString();
                tbOH_subtotal.Text = order.subtotal.ToString("C2");
                tbOH_salesTax.Text = order.salesTax.ToString("C2");
                tbOH_shippingHandling.Text = order.shippingHandling.ToString("C2");
                tbOH_totalPrice.Text = order.totalPrice.ToString("C2");

                dataGridOH_PartsInOrder.Rows.Clear();
                OrderLineItem[] arrCart = order.cart.ToArray();
                for (int i = 0; i < arrCart.Length; i++)
                {
                    dataGridOH_PartsInOrder.Rows.Add(arrCart[i].itemDesc, arrCart[i].partID, arrCart[i].qty, arrCart[i].unitPrice);
                }
                btnConfirmOrder.Enabled = true;
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            cnn.Open();
                order.ConfirmOrderReceived(cnn);
                OrderLineItem[] arr = order.cart.ToArray();
            cnn.Close();

            for(int i = 0; i < arr.Length; i++)
            {
                Part cartPart = new Part(arr[i].partID);
                cartPart.qtyOH += arr[i].qty;
                cartPart.updateDB();
            }

            tbOH_orderID.Text = "";
            tbOH_username.Text = "";
            tbOH_POdate.Text = "";
            tbOH_shippingTime.Text = "";
            tbOH_terms.Text = "";
            tbOH_subtotal.Text = "";
            tbOH_salesTax.Text = "";
            tbOH_shippingHandling.Text = "";
            tbOH_totalPrice.Text = "";

            dataGridOH_PartsInOrder.Rows.Clear();

            btnConfirmOrder.Enabled = false;

            this.ordersTableAdapter2.FillByApprovedReceived(this.gROUP4DataSetOrderConfirmation.Orders);
            this.partsTableAdapter.Fill(this.gROUP4DataSetParts.Parts);

            MessageBox.Show("Inventory Updated");
        }

        //---------------------------------------------------------------------------MANAGE TAB METHODS---------------------------------------------------------------------------

        /* PAGE: Manage
        * Description: adds a user to the DB when button is clicked
        * Req: nothing
        * Returns: updates the DB
        */
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //add the new user to the db
            if (tbAddPassword.Text == tbAddConfPassword.Text)
            {
                if(tbAddName.Text == "" || tbAddUsername.Text == "" || tbAddPassword.Text == "" || cbJobTitle.Text == "")
                {
                    MessageBox.Show("Please fill out all of the required information");
                }
                else
                {
                    //find the job title id
                    int jobTitle = 0;
                    if (cbJobTitle.Text == "Auditor")
                    {
                        jobTitle = 1;
                    }
                    else if (cbJobTitle.Text == "Field Supervisor")
                    {
                        jobTitle = 2;
                    }
                    else if (cbJobTitle.Text == "Drilling Engineer")
                    {
                        jobTitle = 3;
                    }

                    User newUser = new User(tbAddName.Text, tbAddUsername.Text, tbAddPassword.Text, jobTitle);
                    this.usersTableAdapter.Fill(this.gROUP4DataSetUsers.Users);
                    //clear the text boxes
                    tbAddName.Text = "";
                    tbAddUsername.Text = "";
                    tbAddPassword.Text = "";
                    cbJobTitle.Text = "";
                }            
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            } 
        }

     /* PAGE: Manage
      * Description: adds a location to the DB if button is clicked
      * Req: nothing
      * Returns: updates the DB
      */
        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (tbAddLocName.Text == "" || tbAddStreet.Text == "" || tbAddCity.Text == "" || tbAddState.Text == "" || tbAddZip.Text == "" || cbLocType.Text == "")
            {
                MessageBox.Show("Please fill in all the required information");
            }
            else
            {
                Location loc = new Location(tbAddLocName.Text, tbAddStreet.Text, tbAddCity.Text, tbAddState.Text, tbAddZip.Text, cbLocType.Text);
                this.locationTableAdapter.Fill(this.gROUP4DataSetLocation.Location);

                tbAddLocName.Text = "";
                tbAddStreet.Text = "";
                tbAddCity.Text = "";
                tbAddState.Text = "";
                tbAddZip.Text = "";
                cbLocType.Text = "";
            }       
        }

        //---------------------------------------------------------------------------VENDORS TAB METHODS---------------------------------------------------------------------------

        /* PAGE: vendors
         * Description: Adds a vendor to the DB when button is clicked
         * Req: nothing
         * Returns: updates the DB
         */
        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            if(tbVendorName.Text == "" || tbVendorEmail.Text == "")
            {
                MessageBox.Show("Please fill in all the required information");
            }
            else
            {
                Vendor newVendor = new Vendor(tbVendorName.Text, tbVendorEmail.Text);
                this.vendorsTableAdapter.Fill(this.gROUP4DataSet.Vendors);

                tbVendorName.Text = "";
                tbVendorEmail.Text = "";
            }    
        }

        //---------------------------------------------------------------------------INVENTORY TAB METHODS---------------------------------------------------------------------------

        /* PAGE: Inventory
         * Description: Adds a part to the DB when button is clicked
         * Req: nothing
         * Returns: updates the DB
         */
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (tbAddItemDesc.Text == "" || tbAddItemCost.Text == "" || tbAddPartVendor.Text == "" || tbAddQTY.Text == "" || tbAddReorderPoint.Text == "" || tbAddExptLife.Text == "" || tbAddShipTime.Text == "" || cbPartLocSelect.Text == "")
            {
                MessageBox.Show("Please fill in all the required information");
            }
            else
            {
                Vendor findVendor = new Vendor(tbAddPartVendor.Text);
                Location findLoc = new Location(cbPartLocSelect.Text);

                Part newPart = new Part(tbAddItemDesc.Text, Convert.ToDouble(tbAddItemCost.Text), findVendor.vendorID, Convert.ToInt32(tbAddQTY.Text), Convert.ToInt32(tbAddReorderPoint.Text), Convert.ToInt32(tbAddExptLife.Text), tbAddShipTime.Text, findLoc.locationID);
                this.partsTableAdapter.Fill(this.gROUP4DataSetParts.Parts);

                tbAddItemCost.Text = "";
                tbAddPartVendor.Text = "";
                tbAddQTY.Text = "";
                tbAddReorderPoint.Text = "";
                tbAddExptLife.Text = "";
                tbAddShipTime.Text = "";
                cbPartLocSelect.Text = "";
            } 
        }

        private void groupBoxOrderSummary_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
