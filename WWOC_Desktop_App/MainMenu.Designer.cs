namespace WWOC_Desktop_App
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageParts = new System.Windows.Forms.TabPage();
            this.groupBoxCheckOut = new System.Windows.Forms.GroupBox();
            this.btnPartCheckOut = new System.Windows.Forms.Button();
            this.tbInvQtyTaken = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.tbInvQtyOH = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.cbPartName = new System.Windows.Forms.ComboBox();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetParts = new WWOC_Desktop_App.GROUP4DataSetParts();
            this.partsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label57 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costUSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exptdLifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.groupBoxRemove = new System.Windows.Forms.GroupBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cBoxRemove = new System.Windows.Forms.ComboBox();
            this.groupBoxOrderSummary = new System.Windows.Forms.GroupBox();
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.groupBoxOrderInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxApprove = new System.Windows.Forms.CheckBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.tbSalesTax = new System.Windows.Forms.TextBox();
            this.btnSubmitOrderRequest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbShippingHandling = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbApproveOrder = new System.Windows.Forms.Label();
            this.tbShippingTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTerms = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPODate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxPartInfo = new System.Windows.Forms.GroupBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.tbPartID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbVendor = new System.Windows.Forms.TextBox();
            this.tbQtyOrder = new System.Windows.Forms.TextBox();
            this.tbQtyStock = new System.Windows.Forms.TextBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.cBoxPartDescription = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPagePending = new System.Windows.Forms.TabPage();
            this.groupBoxOrderDetailsP = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridPO_PartsinOrder = new System.Windows.Forms.DataGridView();
            this.btnRejectOrder = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbPO_Terms = new System.Windows.Forms.TextBox();
            this.tbPO_TotalPrice = new System.Windows.Forms.TextBox();
            this.tbPO_ShippingHandling = new System.Windows.Forms.TextBox();
            this.tbPO_SalesTax = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbPO_SubTotal = new System.Windows.Forms.TextBox();
            this.tbPO_ShipTime = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbPO_PODate = new System.Windows.Forms.TextBox();
            this.tbPO_Username = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbPO_OrderID = new System.Windows.Forms.TextBox();
            this.btnApproveOrder = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPendingOrders = new System.Windows.Forms.GroupBox();
            this.dataGridPO_PendingOrders = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetPendingOrders = new WWOC_Desktop_App.GROUP4DataSetPendingOrders();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.gbOH_orderDetails = new System.Windows.Forms.GroupBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.dataGridOH_PartsInOrder = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tbOH_terms = new System.Windows.Forms.TextBox();
            this.tbOH_totalPrice = new System.Windows.Forms.TextBox();
            this.tbOH_shippingHandling = new System.Windows.Forms.TextBox();
            this.tbOH_salesTax = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tbOH_subtotal = new System.Windows.Forms.TextBox();
            this.tbOH_shippingTime = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tbOH_POdate = new System.Windows.Forms.TextBox();
            this.tbOH_username = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tbOH_orderID = new System.Windows.Forms.TextBox();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxOrderHistory = new System.Windows.Forms.GroupBox();
            this.dataGridOH_orderHistory = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.receivedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetOrderConfirmation = new WWOC_Desktop_App.GROUP4DataSetOrderConfirmation();
            this.DataGridView = new System.Windows.Forms.TabPage();
            this.groupBoxAddVendor = new System.Windows.Forms.GroupBox();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.tbVendorEmail = new System.Windows.Forms.TextBox();
            this.tbVendorName = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vendorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSet = new WWOC_Desktop_App.GROUP4DataSet();
            this.DGVMainMenu = new System.Windows.Forms.TabPage();
            this.groupBoxAddPart = new System.Windows.Forms.GroupBox();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cbPartLocSelect = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetLocation = new WWOC_Desktop_App.GROUP4DataSetLocation();
            this.tbAddPartVendor = new System.Windows.Forms.ComboBox();
            this.tbAddShipTime = new System.Windows.Forms.TextBox();
            this.tbAddExptLife = new System.Windows.Forms.TextBox();
            this.tbAddReorderPoint = new System.Windows.Forms.TextBox();
            this.tbAddQTY = new System.Windows.Forms.TextBox();
            this.tbAddItemCost = new System.Windows.Forms.TextBox();
            this.tbAddItemDesc = new System.Windows.Forms.TextBox();
            this.groupBoxViewLocation = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.locationIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxViewUsers = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetUsers = new WWOC_Desktop_App.GROUP4DataSetUsers();
            this.groupBoxAddLocation = new System.Windows.Forms.GroupBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.cbLocType = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tbAddZip = new System.Windows.Forms.TextBox();
            this.tbAddState = new System.Windows.Forms.TextBox();
            this.tbAddCity = new System.Windows.Forms.TextBox();
            this.tbAddStreet = new System.Windows.Forms.TextBox();
            this.tbAddLocName = new System.Windows.Forms.TextBox();
            this.groupBoxAddUser = new System.Windows.Forms.GroupBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.cbJobTitle = new System.Windows.Forms.ComboBox();
            this.tbAddConfPassword = new System.Windows.Forms.TextBox();
            this.tbAddPassword = new System.Windows.Forms.TextBox();
            this.tbAddUsername = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tbAddName = new System.Windows.Forms.TextBox();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetOrderHistory = new WWOC_Desktop_App.GROUP4DataSetOrderHistory();
            this.orderLineItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetOrderLineItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetOrderLineItem = new WWOC_Desktop_App.GROUP4DataSetOrderLineItem();
            this.partsTableAdapter = new WWOC_Desktop_App.GROUP4DataSetPartsTableAdapters.PartsTableAdapter();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMetrics = new System.Windows.Forms.Button();
            this.vendorsTableAdapter = new WWOC_Desktop_App.GROUP4DataSetTableAdapters.VendorsTableAdapter();
            this.grouP4DataSet1 = new WWOC_Desktop_App.GROUP4DataSet();
            this.grouP4DataSet2 = new WWOC_Desktop_App.GROUP4DataSet();
            this.orderLineItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_Line_ItemTableAdapter = new WWOC_Desktop_App.GROUP4DataSetOrderLineItemTableAdapters.Order_Line_ItemTableAdapter();
            this.partsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter1 = new WWOC_Desktop_App.GROUP4DataSetOrderLineItemTableAdapters.PartsTableAdapter();
            this.ordersTableAdapter = new WWOC_Desktop_App.GROUP4DataSetPendingOrdersTableAdapters.OrdersTableAdapter();
            this.ordersTableAdapter1 = new WWOC_Desktop_App.GROUP4DataSetOrderHistoryTableAdapters.OrdersTableAdapter();
            this.usersTableAdapter = new WWOC_Desktop_App.GROUP4DataSetUsersTableAdapters.UsersTableAdapter();
            this.locationTableAdapter = new WWOC_Desktop_App.GROUP4DataSetLocationTableAdapters.LocationTableAdapter();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter2 = new WWOC_Desktop_App.GROUP4DataSetOrderConfirmationTableAdapters.OrdersTableAdapter();
            this.gROUP4DataSetOrderConfirmationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabPageParts.SuspendLayout();
            this.groupBoxCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageRequest.SuspendLayout();
            this.groupBoxRemove.SuspendLayout();
            this.groupBoxOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            this.groupBoxOrderInfo.SuspendLayout();
            this.groupBoxPartInfo.SuspendLayout();
            this.tabPagePending.SuspendLayout();
            this.groupBoxOrderDetailsP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPO_PartsinOrder)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.groupBoxPendingOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPO_PendingOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPendingOrders)).BeginInit();
            this.tabPageHistory.SuspendLayout();
            this.gbOH_orderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOH_PartsInOrder)).BeginInit();
            this.fillByToolStrip1.SuspendLayout();
            this.groupBoxOrderHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOH_orderHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderConfirmation)).BeginInit();
            this.DataGridView.SuspendLayout();
            this.groupBoxAddVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).BeginInit();
            this.DGVMainMenu.SuspendLayout();
            this.groupBoxAddPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetLocation)).BeginInit();
            this.groupBoxViewLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBoxViewUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetUsers)).BeginInit();
            this.groupBoxAddLocation.SuspendLayout();
            this.groupBoxAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderLineItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderLineItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouP4DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouP4DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderConfirmationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageParts);
            this.tabControlMain.Controls.Add(this.tabPageRequest);
            this.tabControlMain.Controls.Add(this.tabPagePending);
            this.tabControlMain.Controls.Add(this.tabPageHistory);
            this.tabControlMain.Controls.Add(this.DataGridView);
            this.tabControlMain.Controls.Add(this.DGVMainMenu);
            this.tabControlMain.Location = new System.Drawing.Point(284, 17);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1123, 597);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageParts
            // 
            this.tabPageParts.Controls.Add(this.groupBoxCheckOut);
            this.tabPageParts.Controls.Add(this.dataGridView1);
            this.tabPageParts.Location = new System.Drawing.Point(4, 25);
            this.tabPageParts.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageParts.Name = "tabPageParts";
            this.tabPageParts.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageParts.Size = new System.Drawing.Size(1115, 568);
            this.tabPageParts.TabIndex = 0;
            this.tabPageParts.Text = "Inventory";
            this.tabPageParts.UseVisualStyleBackColor = true;
            // 
            // groupBoxCheckOut
            // 
            this.groupBoxCheckOut.Controls.Add(this.btnPartCheckOut);
            this.groupBoxCheckOut.Controls.Add(this.tbInvQtyTaken);
            this.groupBoxCheckOut.Controls.Add(this.label59);
            this.groupBoxCheckOut.Controls.Add(this.tbInvQtyOH);
            this.groupBoxCheckOut.Controls.Add(this.label58);
            this.groupBoxCheckOut.Controls.Add(this.cbPartName);
            this.groupBoxCheckOut.Controls.Add(this.label57);
            this.groupBoxCheckOut.Location = new System.Drawing.Point(863, 7);
            this.groupBoxCheckOut.Name = "groupBoxCheckOut";
            this.groupBoxCheckOut.Size = new System.Drawing.Size(245, 239);
            this.groupBoxCheckOut.TabIndex = 1;
            this.groupBoxCheckOut.TabStop = false;
            this.groupBoxCheckOut.Text = "Check Out Part";
            // 
            // btnPartCheckOut
            // 
            this.btnPartCheckOut.Location = new System.Drawing.Point(10, 181);
            this.btnPartCheckOut.Name = "btnPartCheckOut";
            this.btnPartCheckOut.Size = new System.Drawing.Size(229, 33);
            this.btnPartCheckOut.TabIndex = 6;
            this.btnPartCheckOut.Text = "Check Out Part";
            this.btnPartCheckOut.UseVisualStyleBackColor = true;
            this.btnPartCheckOut.Click += new System.EventHandler(this.btnPartCheckOut_Click);
            // 
            // tbInvQtyTaken
            // 
            this.tbInvQtyTaken.Location = new System.Drawing.Point(10, 136);
            this.tbInvQtyTaken.Name = "tbInvQtyTaken";
            this.tbInvQtyTaken.Size = new System.Drawing.Size(229, 23);
            this.tbInvQtyTaken.TabIndex = 5;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(7, 116);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(116, 16);
            this.label59.TabIndex = 4;
            this.label59.Text = "Quantity Taken:";
            // 
            // tbInvQtyOH
            // 
            this.tbInvQtyOH.Location = new System.Drawing.Point(10, 90);
            this.tbInvQtyOH.Name = "tbInvQtyOH";
            this.tbInvQtyOH.ReadOnly = true;
            this.tbInvQtyOH.Size = new System.Drawing.Size(229, 23);
            this.tbInvQtyOH.TabIndex = 3;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(7, 70);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(132, 16);
            this.label58.TabIndex = 2;
            this.label58.Text = "Quantity On Hand:";
            // 
            // cbPartName
            // 
            this.cbPartName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsBindingSource, "itemDesc", true));
            this.cbPartName.DataSource = this.partsBindingSource2;
            this.cbPartName.DisplayMember = "itemDesc";
            this.cbPartName.FormattingEnabled = true;
            this.cbPartName.Location = new System.Drawing.Point(10, 43);
            this.cbPartName.Name = "cbPartName";
            this.cbPartName.Size = new System.Drawing.Size(229, 24);
            this.cbPartName.TabIndex = 1;
            this.cbPartName.ValueMember = "itemDesc";
            this.cbPartName.SelectedIndexChanged += new System.EventHandler(this.cbPartName_SelectedIndexChanged);
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.gROUP4DataSetPartsBindingSource;
            // 
            // gROUP4DataSetPartsBindingSource
            // 
            this.gROUP4DataSetPartsBindingSource.DataSource = this.gROUP4DataSetParts;
            this.gROUP4DataSetPartsBindingSource.Position = 0;
            // 
            // gROUP4DataSetParts
            // 
            this.gROUP4DataSetParts.DataSetName = "GROUP4DataSetParts";
            this.gROUP4DataSetParts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource2
            // 
            this.partsBindingSource2.DataMember = "Parts";
            this.partsBindingSource2.DataSource = this.gROUP4DataSetPartsBindingSource;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(7, 23);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(82, 16);
            this.label57.TabIndex = 0;
            this.label57.Text = "Part Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.itemDescDataGridViewTextBoxColumn,
            this.costUSDDataGridViewTextBoxColumn,
            this.vendorIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.exptdLifeDataGridViewTextBoxColumn,
            this.reorderPoint,
            this.locationIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(852, 560);
            this.dataGridView1.TabIndex = 0;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "partID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "Part ID";
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            this.partIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.partIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // itemDescDataGridViewTextBoxColumn
            // 
            this.itemDescDataGridViewTextBoxColumn.DataPropertyName = "itemDesc";
            this.itemDescDataGridViewTextBoxColumn.HeaderText = "Item Description";
            this.itemDescDataGridViewTextBoxColumn.Name = "itemDescDataGridViewTextBoxColumn";
            this.itemDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDescDataGridViewTextBoxColumn.Width = 175;
            // 
            // costUSDDataGridViewTextBoxColumn
            // 
            this.costUSDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.costUSDDataGridViewTextBoxColumn.DataPropertyName = "costUSD";
            this.costUSDDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costUSDDataGridViewTextBoxColumn.Name = "costUSDDataGridViewTextBoxColumn";
            this.costUSDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costUSDDataGridViewTextBoxColumn.Width = 63;
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "vendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "Vendor ID";
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            this.vendorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendorIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Quantity OH";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 105;
            // 
            // exptdLifeDataGridViewTextBoxColumn
            // 
            this.exptdLifeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.exptdLifeDataGridViewTextBoxColumn.DataPropertyName = "exptdLife";
            this.exptdLifeDataGridViewTextBoxColumn.HeaderText = "Expected Life";
            this.exptdLifeDataGridViewTextBoxColumn.Name = "exptdLifeDataGridViewTextBoxColumn";
            this.exptdLifeDataGridViewTextBoxColumn.ReadOnly = true;
            this.exptdLifeDataGridViewTextBoxColumn.Width = 112;
            // 
            // reorderPoint
            // 
            this.reorderPoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.reorderPoint.DataPropertyName = "reorderPoint";
            this.reorderPoint.HeaderText = "Reorder Point";
            this.reorderPoint.Name = "reorderPoint";
            this.reorderPoint.ReadOnly = true;
            this.reorderPoint.Width = 111;
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "locationID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "Location ID";
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            this.locationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationIDDataGridViewTextBoxColumn.Width = 99;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.btnCreateOrder);
            this.tabPageRequest.Controls.Add(this.groupBoxRemove);
            this.tabPageRequest.Controls.Add(this.groupBoxOrderSummary);
            this.tabPageRequest.Controls.Add(this.groupBoxOrderInfo);
            this.tabPageRequest.Controls.Add(this.groupBoxPartInfo);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequest.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageRequest.Size = new System.Drawing.Size(1115, 568);
            this.tabPageRequest.TabIndex = 2;
            this.tabPageRequest.Text = "Make Order Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(98, 16);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(195, 40);
            this.btnCreateOrder.TabIndex = 23;
            this.btnCreateOrder.Text = "Create New Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // groupBoxRemove
            // 
            this.groupBoxRemove.Controls.Add(this.btnRemoveItem);
            this.groupBoxRemove.Controls.Add(this.label14);
            this.groupBoxRemove.Controls.Add(this.cBoxRemove);
            this.groupBoxRemove.Enabled = false;
            this.groupBoxRemove.Location = new System.Drawing.Point(17, 386);
            this.groupBoxRemove.Name = "groupBoxRemove";
            this.groupBoxRemove.Size = new System.Drawing.Size(355, 175);
            this.groupBoxRemove.TabIndex = 22;
            this.groupBoxRemove.TabStop = false;
            this.groupBoxRemove.Text = "Remove Item From Order";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(81, 86);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(195, 40);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Select an Item:";
            // 
            // cBoxRemove
            // 
            this.cBoxRemove.FormattingEnabled = true;
            this.cBoxRemove.Location = new System.Drawing.Point(135, 40);
            this.cBoxRemove.Name = "cBoxRemove";
            this.cBoxRemove.Size = new System.Drawing.Size(195, 24);
            this.cBoxRemove.TabIndex = 0;
            this.cBoxRemove.SelectedIndexChanged += new System.EventHandler(this.cBoxRemove_SelectedIndexChanged);
            // 
            // groupBoxOrderSummary
            // 
            this.groupBoxOrderSummary.Controls.Add(this.dataGridParts);
            this.groupBoxOrderSummary.Enabled = false;
            this.groupBoxOrderSummary.Location = new System.Drawing.Point(378, 7);
            this.groupBoxOrderSummary.Name = "groupBoxOrderSummary";
            this.groupBoxOrderSummary.Size = new System.Drawing.Size(730, 330);
            this.groupBoxOrderSummary.TabIndex = 21;
            this.groupBoxOrderSummary.TabStop = false;
            this.groupBoxOrderSummary.Text = "Order Summary";
            // 
            // dataGridParts
            // 
            this.dataGridParts.AllowUserToAddRows = false;
            this.dataGridParts.AllowUserToDeleteRows = false;
            this.dataGridParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridParts.Location = new System.Drawing.Point(3, 19);
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.ReadOnly = true;
            this.dataGridParts.Size = new System.Drawing.Size(724, 308);
            this.dataGridParts.TabIndex = 0;
            // 
            // groupBoxOrderInfo
            // 
            this.groupBoxOrderInfo.Controls.Add(this.checkBoxApprove);
            this.groupBoxOrderInfo.Controls.Add(this.tbTotalPrice);
            this.groupBoxOrderInfo.Controls.Add(this.tbSalesTax);
            this.groupBoxOrderInfo.Controls.Add(this.btnSubmitOrderRequest);
            this.groupBoxOrderInfo.Controls.Add(this.label3);
            this.groupBoxOrderInfo.Controls.Add(this.tbShippingHandling);
            this.groupBoxOrderInfo.Controls.Add(this.label4);
            this.groupBoxOrderInfo.Controls.Add(this.tbSubTotal);
            this.groupBoxOrderInfo.Controls.Add(this.label9);
            this.groupBoxOrderInfo.Controls.Add(this.lbApproveOrder);
            this.groupBoxOrderInfo.Controls.Add(this.tbShippingTime);
            this.groupBoxOrderInfo.Controls.Add(this.label13);
            this.groupBoxOrderInfo.Controls.Add(this.tbTerms);
            this.groupBoxOrderInfo.Controls.Add(this.label12);
            this.groupBoxOrderInfo.Controls.Add(this.tbPODate);
            this.groupBoxOrderInfo.Controls.Add(this.label11);
            this.groupBoxOrderInfo.Controls.Add(this.label10);
            this.groupBoxOrderInfo.Enabled = false;
            this.groupBoxOrderInfo.Location = new System.Drawing.Point(378, 343);
            this.groupBoxOrderInfo.Name = "groupBoxOrderInfo";
            this.groupBoxOrderInfo.Size = new System.Drawing.Size(730, 218);
            this.groupBoxOrderInfo.TabIndex = 20;
            this.groupBoxOrderInfo.TabStop = false;
            this.groupBoxOrderInfo.Text = "Order Information";
            // 
            // checkBoxApprove
            // 
            this.checkBoxApprove.AutoSize = true;
            this.checkBoxApprove.Location = new System.Drawing.Point(527, 183);
            this.checkBoxApprove.Name = "checkBoxApprove";
            this.checkBoxApprove.Size = new System.Drawing.Size(15, 14);
            this.checkBoxApprove.TabIndex = 21;
            this.checkBoxApprove.UseVisualStyleBackColor = true;
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(529, 138);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(195, 23);
            this.tbTotalPrice.TabIndex = 24;
            // 
            // tbSalesTax
            // 
            this.tbSalesTax.Location = new System.Drawing.Point(529, 99);
            this.tbSalesTax.Name = "tbSalesTax";
            this.tbSalesTax.ReadOnly = true;
            this.tbSalesTax.Size = new System.Drawing.Size(195, 23);
            this.tbSalesTax.TabIndex = 23;
            // 
            // btnSubmitOrderRequest
            // 
            this.btnSubmitOrderRequest.Location = new System.Drawing.Point(566, 167);
            this.btnSubmitOrderRequest.Name = "btnSubmitOrderRequest";
            this.btnSubmitOrderRequest.Size = new System.Drawing.Size(158, 45);
            this.btnSubmitOrderRequest.TabIndex = 16;
            this.btnSubmitOrderRequest.Text = "Submit Order Request";
            this.btnSubmitOrderRequest.UseVisualStyleBackColor = true;
            this.btnSubmitOrderRequest.Click += new System.EventHandler(this.btnSubmitOrderRequest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Purchase Order Date:";
            // 
            // tbShippingHandling
            // 
            this.tbShippingHandling.Location = new System.Drawing.Point(529, 60);
            this.tbShippingHandling.Name = "tbShippingHandling";
            this.tbShippingHandling.ReadOnly = true;
            this.tbShippingHandling.Size = new System.Drawing.Size(195, 23);
            this.tbShippingHandling.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estimated Shipping Time:";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(529, 22);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(195, 23);
            this.tbSubTotal.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Shipping Terms:";
            // 
            // lbApproveOrder
            // 
            this.lbApproveOrder.AutoSize = true;
            this.lbApproveOrder.Location = new System.Drawing.Point(414, 181);
            this.lbApproveOrder.Name = "lbApproveOrder";
            this.lbApproveOrder.Size = new System.Drawing.Size(109, 16);
            this.lbApproveOrder.TabIndex = 15;
            this.lbApproveOrder.Text = "Approve Order:";
            // 
            // tbShippingTime
            // 
            this.tbShippingTime.Location = new System.Drawing.Point(188, 61);
            this.tbShippingTime.Name = "tbShippingTime";
            this.tbShippingTime.ReadOnly = true;
            this.tbShippingTime.Size = new System.Drawing.Size(174, 23);
            this.tbShippingTime.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(438, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Total Price:";
            // 
            // tbTerms
            // 
            this.tbTerms.Location = new System.Drawing.Point(188, 99);
            this.tbTerms.Multiline = true;
            this.tbTerms.Name = "tbTerms";
            this.tbTerms.Size = new System.Drawing.Size(174, 113);
            this.tbTerms.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(438, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Sales Tax:";
            // 
            // tbPODate
            // 
            this.tbPODate.Location = new System.Drawing.Point(188, 25);
            this.tbPODate.Name = "tbPODate";
            this.tbPODate.ReadOnly = true;
            this.tbPODate.Size = new System.Drawing.Size(174, 23);
            this.tbPODate.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Shipping and Handling:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Subtotal:";
            // 
            // groupBoxPartInfo
            // 
            this.groupBoxPartInfo.Controls.Add(this.btnAddToOrder);
            this.groupBoxPartInfo.Controls.Add(this.tbPartID);
            this.groupBoxPartInfo.Controls.Add(this.label15);
            this.groupBoxPartInfo.Controls.Add(this.tbVendor);
            this.groupBoxPartInfo.Controls.Add(this.tbQtyOrder);
            this.groupBoxPartInfo.Controls.Add(this.tbQtyStock);
            this.groupBoxPartInfo.Controls.Add(this.tbUnitPrice);
            this.groupBoxPartInfo.Controls.Add(this.cBoxPartDescription);
            this.groupBoxPartInfo.Controls.Add(this.label1);
            this.groupBoxPartInfo.Controls.Add(this.label7);
            this.groupBoxPartInfo.Controls.Add(this.label5);
            this.groupBoxPartInfo.Controls.Add(this.label8);
            this.groupBoxPartInfo.Controls.Add(this.label6);
            this.groupBoxPartInfo.Enabled = false;
            this.groupBoxPartInfo.Location = new System.Drawing.Point(17, 62);
            this.groupBoxPartInfo.Name = "groupBoxPartInfo";
            this.groupBoxPartInfo.Size = new System.Drawing.Size(355, 318);
            this.groupBoxPartInfo.TabIndex = 18;
            this.groupBoxPartInfo.TabStop = false;
            this.groupBoxPartInfo.Text = "Part Information";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(145, 254);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(194, 40);
            this.btnAddToOrder.TabIndex = 24;
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // tbPartID
            // 
            this.tbPartID.Location = new System.Drawing.Point(144, 62);
            this.tbPartID.Name = "tbPartID";
            this.tbPartID.ReadOnly = true;
            this.tbPartID.Size = new System.Drawing.Size(195, 23);
            this.tbPartID.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(78, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Vendor:";
            // 
            // tbVendor
            // 
            this.tbVendor.Location = new System.Drawing.Point(144, 172);
            this.tbVendor.Name = "tbVendor";
            this.tbVendor.ReadOnly = true;
            this.tbVendor.Size = new System.Drawing.Size(195, 23);
            this.tbVendor.TabIndex = 21;
            // 
            // tbQtyOrder
            // 
            this.tbQtyOrder.Location = new System.Drawing.Point(145, 211);
            this.tbQtyOrder.Name = "tbQtyOrder";
            this.tbQtyOrder.Size = new System.Drawing.Size(194, 23);
            this.tbQtyOrder.TabIndex = 20;
            // 
            // tbQtyStock
            // 
            this.tbQtyStock.Location = new System.Drawing.Point(144, 134);
            this.tbQtyStock.Name = "tbQtyStock";
            this.tbQtyStock.ReadOnly = true;
            this.tbQtyStock.Size = new System.Drawing.Size(195, 23);
            this.tbQtyStock.TabIndex = 19;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(144, 99);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.ReadOnly = true;
            this.tbUnitPrice.Size = new System.Drawing.Size(195, 23);
            this.tbUnitPrice.TabIndex = 18;
            // 
            // cBoxPartDescription
            // 
            this.cBoxPartDescription.CausesValidation = false;
            this.cBoxPartDescription.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsBindingSource, "partID", true));
            this.cBoxPartDescription.DataSource = this.partsBindingSource;
            this.cBoxPartDescription.DisplayMember = "itemDesc";
            this.cBoxPartDescription.FormattingEnabled = true;
            this.cBoxPartDescription.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cBoxPartDescription.Location = new System.Drawing.Point(144, 22);
            this.cBoxPartDescription.Name = "cBoxPartDescription";
            this.cBoxPartDescription.Size = new System.Drawing.Size(195, 24);
            this.cBoxPartDescription.TabIndex = 1;
            this.cBoxPartDescription.ValueMember = "itemDesc";
            this.cBoxPartDescription.SelectedIndexChanged += new System.EventHandler(this.cBoxPartDescription_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select an Item:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Part ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unit Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quanitity in Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantity to Order:";
            // 
            // tabPagePending
            // 
            this.tabPagePending.Controls.Add(this.groupBoxOrderDetailsP);
            this.tabPagePending.Controls.Add(this.fillByToolStrip);
            this.tabPagePending.Controls.Add(this.label2);
            this.tabPagePending.Controls.Add(this.groupBoxPendingOrders);
            this.tabPagePending.Location = new System.Drawing.Point(4, 25);
            this.tabPagePending.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePending.Name = "tabPagePending";
            this.tabPagePending.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePending.Size = new System.Drawing.Size(1115, 568);
            this.tabPagePending.TabIndex = 1;
            this.tabPagePending.Text = "Pending Orders";
            this.tabPagePending.UseVisualStyleBackColor = true;
            // 
            // groupBoxOrderDetailsP
            // 
            this.groupBoxOrderDetailsP.Controls.Add(this.label25);
            this.groupBoxOrderDetailsP.Controls.Add(this.dataGridPO_PartsinOrder);
            this.groupBoxOrderDetailsP.Controls.Add(this.btnRejectOrder);
            this.groupBoxOrderDetailsP.Controls.Add(this.label24);
            this.groupBoxOrderDetailsP.Controls.Add(this.label23);
            this.groupBoxOrderDetailsP.Controls.Add(this.label22);
            this.groupBoxOrderDetailsP.Controls.Add(this.label21);
            this.groupBoxOrderDetailsP.Controls.Add(this.tbPO_Terms);
            this.groupBoxOrderDetailsP.Controls.Add(this.tbPO_TotalPrice);
            this.groupBoxOrderDetailsP.Controls.Add(this.tbPO_ShippingHandling);
            this.groupBoxOrderDetailsP.Controls.Add(this.tbPO_SalesTax);
            this.groupBoxOrderDetailsP.Controls.Add(this.label20);
            this.groupBoxOrderDetailsP.Controls.Add(this.label19);
            this.groupBoxOrderDetailsP.Controls.Add(this.tbPO_SubTotal);
            this.groupBoxOrderDetailsP.Controls.Add(this.tbPO_ShipTime);
            this.groupBoxOrderDetailsP.Controls.Add(this.label18);
            this.groupBoxOrderDetailsP.Controls.Add(this.label17);
            this.groupBoxOrderDetailsP.Controls.Add(this.tbPO_PODate);
            this.groupBoxOrderDetailsP.Controls.Add(this.tbPO_Username);
            this.groupBoxOrderDetailsP.Controls.Add(this.label16);
            this.groupBoxOrderDetailsP.Controls.Add(this.tbPO_OrderID);
            this.groupBoxOrderDetailsP.Controls.Add(this.btnApproveOrder);
            this.groupBoxOrderDetailsP.Location = new System.Drawing.Point(461, 54);
            this.groupBoxOrderDetailsP.Name = "groupBoxOrderDetailsP";
            this.groupBoxOrderDetailsP.Size = new System.Drawing.Size(647, 504);
            this.groupBoxOrderDetailsP.TabIndex = 12;
            this.groupBoxOrderDetailsP.TabStop = false;
            this.groupBoxOrderDetailsP.Text = "Order Details";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(426, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(123, 20);
            this.label25.TabIndex = 42;
            this.label25.Text = "Parts in Order";
            // 
            // dataGridPO_PartsinOrder
            // 
            this.dataGridPO_PartsinOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPO_PartsinOrder.Location = new System.Drawing.Point(324, 42);
            this.dataGridPO_PartsinOrder.Name = "dataGridPO_PartsinOrder";
            this.dataGridPO_PartsinOrder.Size = new System.Drawing.Size(317, 445);
            this.dataGridPO_PartsinOrder.TabIndex = 41;
            // 
            // btnRejectOrder
            // 
            this.btnRejectOrder.Location = new System.Drawing.Point(163, 440);
            this.btnRejectOrder.Name = "btnRejectOrder";
            this.btnRejectOrder.Size = new System.Drawing.Size(137, 47);
            this.btnRejectOrder.TabIndex = 40;
            this.btnRejectOrder.Text = "Reject Order";
            this.btnRejectOrder.UseVisualStyleBackColor = true;
            this.btnRejectOrder.Click += new System.EventHandler(this.btnRejectOrder_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(78, 305);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 16);
            this.label24.TabIndex = 39;
            this.label24.Text = "Total Price:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 267);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(158, 16);
            this.label23.TabIndex = 38;
            this.label23.Text = "Shipping and Handling:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(85, 228);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 16);
            this.label22.TabIndex = 37;
            this.label22.Text = "Sales Tax:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(85, 190);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 16);
            this.label21.TabIndex = 36;
            this.label21.Text = "Sub Total:";
            // 
            // tbPO_Terms
            // 
            this.tbPO_Terms.Location = new System.Drawing.Point(72, 340);
            this.tbPO_Terms.Multiline = true;
            this.tbPO_Terms.Name = "tbPO_Terms";
            this.tbPO_Terms.ReadOnly = true;
            this.tbPO_Terms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPO_Terms.Size = new System.Drawing.Size(228, 91);
            this.tbPO_Terms.TabIndex = 35;
            // 
            // tbPO_TotalPrice
            // 
            this.tbPO_TotalPrice.Location = new System.Drawing.Point(169, 302);
            this.tbPO_TotalPrice.Name = "tbPO_TotalPrice";
            this.tbPO_TotalPrice.ReadOnly = true;
            this.tbPO_TotalPrice.Size = new System.Drawing.Size(131, 23);
            this.tbPO_TotalPrice.TabIndex = 34;
            // 
            // tbPO_ShippingHandling
            // 
            this.tbPO_ShippingHandling.Location = new System.Drawing.Point(169, 264);
            this.tbPO_ShippingHandling.Name = "tbPO_ShippingHandling";
            this.tbPO_ShippingHandling.ReadOnly = true;
            this.tbPO_ShippingHandling.Size = new System.Drawing.Size(131, 23);
            this.tbPO_ShippingHandling.TabIndex = 33;
            // 
            // tbPO_SalesTax
            // 
            this.tbPO_SalesTax.Location = new System.Drawing.Point(169, 225);
            this.tbPO_SalesTax.Name = "tbPO_SalesTax";
            this.tbPO_SalesTax.ReadOnly = true;
            this.tbPO_SalesTax.Size = new System.Drawing.Size(131, 23);
            this.tbPO_SalesTax.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 343);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 16);
            this.label20.TabIndex = 31;
            this.label20.Text = "Terms:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(58, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = "Shipping Time:";
            // 
            // tbPO_SubTotal
            // 
            this.tbPO_SubTotal.Location = new System.Drawing.Point(169, 187);
            this.tbPO_SubTotal.Name = "tbPO_SubTotal";
            this.tbPO_SubTotal.ReadOnly = true;
            this.tbPO_SubTotal.Size = new System.Drawing.Size(131, 23);
            this.tbPO_SubTotal.TabIndex = 29;
            // 
            // tbPO_ShipTime
            // 
            this.tbPO_ShipTime.Location = new System.Drawing.Point(169, 149);
            this.tbPO_ShipTime.Name = "tbPO_ShipTime";
            this.tbPO_ShipTime.ReadOnly = true;
            this.tbPO_ShipTime.Size = new System.Drawing.Size(131, 23);
            this.tbPO_ShipTime.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 16);
            this.label18.TabIndex = 26;
            this.label18.Text = "Purchase Order Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 16);
            this.label17.TabIndex = 25;
            this.label17.Text = "Employee Ordering:";
            // 
            // tbPO_PODate
            // 
            this.tbPO_PODate.Location = new System.Drawing.Point(169, 111);
            this.tbPO_PODate.Name = "tbPO_PODate";
            this.tbPO_PODate.ReadOnly = true;
            this.tbPO_PODate.Size = new System.Drawing.Size(131, 23);
            this.tbPO_PODate.TabIndex = 24;
            // 
            // tbPO_Username
            // 
            this.tbPO_Username.Location = new System.Drawing.Point(169, 72);
            this.tbPO_Username.Name = "tbPO_Username";
            this.tbPO_Username.ReadOnly = true;
            this.tbPO_Username.Size = new System.Drawing.Size(131, 23);
            this.tbPO_Username.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(94, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Order ID:";
            // 
            // tbPO_OrderID
            // 
            this.tbPO_OrderID.Location = new System.Drawing.Point(169, 34);
            this.tbPO_OrderID.Name = "tbPO_OrderID";
            this.tbPO_OrderID.ReadOnly = true;
            this.tbPO_OrderID.Size = new System.Drawing.Size(131, 23);
            this.tbPO_OrderID.TabIndex = 21;
            // 
            // btnApproveOrder
            // 
            this.btnApproveOrder.Location = new System.Drawing.Point(15, 440);
            this.btnApproveOrder.Name = "btnApproveOrder";
            this.btnApproveOrder.Size = new System.Drawing.Size(137, 47);
            this.btnApproveOrder.TabIndex = 0;
            this.btnApproveOrder.Text = "Approve Order";
            this.btnApproveOrder.UseVisualStyleBackColor = true;
            this.btnApproveOrder.Click += new System.EventHandler(this.btnApproveOrder_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(1013, 88);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(51, 25);
            this.fillByToolStrip.TabIndex = 11;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Approve Pending Orders Form";
            // 
            // groupBoxPendingOrders
            // 
            this.groupBoxPendingOrders.Controls.Add(this.dataGridPO_PendingOrders);
            this.groupBoxPendingOrders.Location = new System.Drawing.Point(7, 54);
            this.groupBoxPendingOrders.Name = "groupBoxPendingOrders";
            this.groupBoxPendingOrders.Size = new System.Drawing.Size(448, 507);
            this.groupBoxPendingOrders.TabIndex = 0;
            this.groupBoxPendingOrders.TabStop = false;
            this.groupBoxPendingOrders.Text = "Pending Orders";
            // 
            // dataGridPO_PendingOrders
            // 
            this.dataGridPO_PendingOrders.AutoGenerateColumns = false;
            this.dataGridPO_PendingOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPO_PendingOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.poDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.approvedDataGridViewCheckBoxColumn});
            this.dataGridPO_PendingOrders.DataSource = this.ordersBindingSource;
            this.dataGridPO_PendingOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPO_PendingOrders.Location = new System.Drawing.Point(3, 19);
            this.dataGridPO_PendingOrders.MultiSelect = false;
            this.dataGridPO_PendingOrders.Name = "dataGridPO_PendingOrders";
            this.dataGridPO_PendingOrders.ReadOnly = true;
            this.dataGridPO_PendingOrders.Size = new System.Drawing.Size(442, 485);
            this.dataGridPO_PendingOrders.TabIndex = 0;
            this.dataGridPO_PendingOrders.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridPO_PendingOrders_CellMouseClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poDateDataGridViewTextBoxColumn
            // 
            this.poDateDataGridViewTextBoxColumn.DataPropertyName = "poDate";
            this.poDateDataGridViewTextBoxColumn.HeaderText = "PO Date";
            this.poDateDataGridViewTextBoxColumn.Name = "poDateDataGridViewTextBoxColumn";
            this.poDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // approvedDataGridViewCheckBoxColumn
            // 
            this.approvedDataGridViewCheckBoxColumn.DataPropertyName = "approved";
            this.approvedDataGridViewCheckBoxColumn.HeaderText = "Approved";
            this.approvedDataGridViewCheckBoxColumn.Name = "approvedDataGridViewCheckBoxColumn";
            this.approvedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.gROUP4DataSetPendingOrders;
            // 
            // gROUP4DataSetPendingOrders
            // 
            this.gROUP4DataSetPendingOrders.DataSetName = "GROUP4DataSetPendingOrders";
            this.gROUP4DataSetPendingOrders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.gbOH_orderDetails);
            this.tabPageHistory.Controls.Add(this.fillByToolStrip1);
            this.tabPageHistory.Controls.Add(this.groupBoxOrderHistory);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 25);
            this.tabPageHistory.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageHistory.Size = new System.Drawing.Size(1115, 568);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "Order Confirmation";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // gbOH_orderDetails
            // 
            this.gbOH_orderDetails.Controls.Add(this.btnConfirmOrder);
            this.gbOH_orderDetails.Controls.Add(this.label26);
            this.gbOH_orderDetails.Controls.Add(this.dataGridOH_PartsInOrder);
            this.gbOH_orderDetails.Controls.Add(this.label27);
            this.gbOH_orderDetails.Controls.Add(this.label28);
            this.gbOH_orderDetails.Controls.Add(this.label29);
            this.gbOH_orderDetails.Controls.Add(this.label30);
            this.gbOH_orderDetails.Controls.Add(this.tbOH_terms);
            this.gbOH_orderDetails.Controls.Add(this.tbOH_totalPrice);
            this.gbOH_orderDetails.Controls.Add(this.tbOH_shippingHandling);
            this.gbOH_orderDetails.Controls.Add(this.tbOH_salesTax);
            this.gbOH_orderDetails.Controls.Add(this.label31);
            this.gbOH_orderDetails.Controls.Add(this.label32);
            this.gbOH_orderDetails.Controls.Add(this.tbOH_subtotal);
            this.gbOH_orderDetails.Controls.Add(this.tbOH_shippingTime);
            this.gbOH_orderDetails.Controls.Add(this.label33);
            this.gbOH_orderDetails.Controls.Add(this.label34);
            this.gbOH_orderDetails.Controls.Add(this.tbOH_POdate);
            this.gbOH_orderDetails.Controls.Add(this.tbOH_username);
            this.gbOH_orderDetails.Controls.Add(this.label35);
            this.gbOH_orderDetails.Controls.Add(this.tbOH_orderID);
            this.gbOH_orderDetails.Location = new System.Drawing.Point(462, 7);
            this.gbOH_orderDetails.Name = "gbOH_orderDetails";
            this.gbOH_orderDetails.Size = new System.Drawing.Size(647, 551);
            this.gbOH_orderDetails.TabIndex = 13;
            this.gbOH_orderDetails.TabStop = false;
            this.gbOH_orderDetails.Text = "Order Details";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Enabled = false;
            this.btnConfirmOrder.Location = new System.Drawing.Point(72, 455);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(164, 47);
            this.btnConfirmOrder.TabIndex = 43;
            this.btnConfirmOrder.Text = "Confirm Order Arrived";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(426, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 20);
            this.label26.TabIndex = 42;
            this.label26.Text = "Parts in Order";
            // 
            // dataGridOH_PartsInOrder
            // 
            this.dataGridOH_PartsInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOH_PartsInOrder.Location = new System.Drawing.Point(324, 42);
            this.dataGridOH_PartsInOrder.Name = "dataGridOH_PartsInOrder";
            this.dataGridOH_PartsInOrder.Size = new System.Drawing.Size(317, 503);
            this.dataGridOH_PartsInOrder.TabIndex = 41;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(78, 305);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 16);
            this.label27.TabIndex = 39;
            this.label27.Text = "Total Price:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 267);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(158, 16);
            this.label28.TabIndex = 38;
            this.label28.Text = "Shipping and Handling:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(85, 228);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(78, 16);
            this.label29.TabIndex = 37;
            this.label29.Text = "Sales Tax:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(85, 190);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(78, 16);
            this.label30.TabIndex = 36;
            this.label30.Text = "Sub Total:";
            // 
            // tbOH_terms
            // 
            this.tbOH_terms.Location = new System.Drawing.Point(72, 340);
            this.tbOH_terms.Multiline = true;
            this.tbOH_terms.Name = "tbOH_terms";
            this.tbOH_terms.ReadOnly = true;
            this.tbOH_terms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOH_terms.Size = new System.Drawing.Size(228, 91);
            this.tbOH_terms.TabIndex = 35;
            // 
            // tbOH_totalPrice
            // 
            this.tbOH_totalPrice.Location = new System.Drawing.Point(169, 302);
            this.tbOH_totalPrice.Name = "tbOH_totalPrice";
            this.tbOH_totalPrice.ReadOnly = true;
            this.tbOH_totalPrice.Size = new System.Drawing.Size(131, 23);
            this.tbOH_totalPrice.TabIndex = 34;
            // 
            // tbOH_shippingHandling
            // 
            this.tbOH_shippingHandling.Location = new System.Drawing.Point(169, 264);
            this.tbOH_shippingHandling.Name = "tbOH_shippingHandling";
            this.tbOH_shippingHandling.ReadOnly = true;
            this.tbOH_shippingHandling.Size = new System.Drawing.Size(131, 23);
            this.tbOH_shippingHandling.TabIndex = 33;
            // 
            // tbOH_salesTax
            // 
            this.tbOH_salesTax.Location = new System.Drawing.Point(169, 225);
            this.tbOH_salesTax.Name = "tbOH_salesTax";
            this.tbOH_salesTax.ReadOnly = true;
            this.tbOH_salesTax.Size = new System.Drawing.Size(131, 23);
            this.tbOH_salesTax.TabIndex = 32;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 343);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 16);
            this.label31.TabIndex = 31;
            this.label31.Text = "Terms:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(58, 152);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(105, 16);
            this.label32.TabIndex = 30;
            this.label32.Text = "Shipping Time:";
            // 
            // tbOH_subtotal
            // 
            this.tbOH_subtotal.Location = new System.Drawing.Point(169, 187);
            this.tbOH_subtotal.Name = "tbOH_subtotal";
            this.tbOH_subtotal.ReadOnly = true;
            this.tbOH_subtotal.Size = new System.Drawing.Size(131, 23);
            this.tbOH_subtotal.TabIndex = 29;
            // 
            // tbOH_shippingTime
            // 
            this.tbOH_shippingTime.Location = new System.Drawing.Point(169, 149);
            this.tbOH_shippingTime.Name = "tbOH_shippingTime";
            this.tbOH_shippingTime.ReadOnly = true;
            this.tbOH_shippingTime.Size = new System.Drawing.Size(131, 23);
            this.tbOH_shippingTime.TabIndex = 27;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 114);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(151, 16);
            this.label33.TabIndex = 26;
            this.label33.Text = "Purchase Order Date:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(27, 75);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(136, 16);
            this.label34.TabIndex = 25;
            this.label34.Text = "Employee Ordering:";
            // 
            // tbOH_POdate
            // 
            this.tbOH_POdate.Location = new System.Drawing.Point(169, 111);
            this.tbOH_POdate.Name = "tbOH_POdate";
            this.tbOH_POdate.ReadOnly = true;
            this.tbOH_POdate.Size = new System.Drawing.Size(131, 23);
            this.tbOH_POdate.TabIndex = 24;
            // 
            // tbOH_username
            // 
            this.tbOH_username.Location = new System.Drawing.Point(169, 72);
            this.tbOH_username.Name = "tbOH_username";
            this.tbOH_username.ReadOnly = true;
            this.tbOH_username.Size = new System.Drawing.Size(131, 23);
            this.tbOH_username.TabIndex = 23;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(94, 37);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(69, 16);
            this.label35.TabIndex = 22;
            this.label35.Text = "Order ID:";
            // 
            // tbOH_orderID
            // 
            this.tbOH_orderID.Location = new System.Drawing.Point(169, 34);
            this.tbOH_orderID.Name = "tbOH_orderID";
            this.tbOH_orderID.ReadOnly = true;
            this.tbOH_orderID.Size = new System.Drawing.Size(131, 23);
            this.tbOH_orderID.TabIndex = 21;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(1014, 42);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(51, 25);
            this.fillByToolStrip1.TabIndex = 11;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton1.Text = "FillBy";
            // 
            // groupBoxOrderHistory
            // 
            this.groupBoxOrderHistory.Controls.Add(this.dataGridOH_orderHistory);
            this.groupBoxOrderHistory.Location = new System.Drawing.Point(7, 7);
            this.groupBoxOrderHistory.Name = "groupBoxOrderHistory";
            this.groupBoxOrderHistory.Size = new System.Drawing.Size(449, 554);
            this.groupBoxOrderHistory.TabIndex = 2;
            this.groupBoxOrderHistory.TabStop = false;
            this.groupBoxOrderHistory.Text = "Order History";
            // 
            // dataGridOH_orderHistory
            // 
            this.dataGridOH_orderHistory.AutoGenerateColumns = false;
            this.dataGridOH_orderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOH_orderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.poDate,
            this.totalPriceDataGridViewTextBoxColumn1,
            this.approvedDataGridViewCheckBoxColumn1,
            this.receivedDataGridViewCheckBoxColumn});
            this.dataGridOH_orderHistory.DataSource = this.ordersBindingSource3;
            this.dataGridOH_orderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOH_orderHistory.Location = new System.Drawing.Point(3, 19);
            this.dataGridOH_orderHistory.Name = "dataGridOH_orderHistory";
            this.dataGridOH_orderHistory.Size = new System.Drawing.Size(443, 532);
            this.dataGridOH_orderHistory.TabIndex = 0;
            this.dataGridOH_orderHistory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridOH_orderHistory_CellMouseClick);
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "Order ID";
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // poDate
            // 
            this.poDate.DataPropertyName = "poDate";
            this.poDate.HeaderText = "PO Date";
            this.poDate.Name = "poDate";
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "Total Price";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            // 
            // approvedDataGridViewCheckBoxColumn1
            // 
            this.approvedDataGridViewCheckBoxColumn1.DataPropertyName = "approved";
            this.approvedDataGridViewCheckBoxColumn1.HeaderText = "Approved";
            this.approvedDataGridViewCheckBoxColumn1.Name = "approvedDataGridViewCheckBoxColumn1";
            // 
            // receivedDataGridViewCheckBoxColumn
            // 
            this.receivedDataGridViewCheckBoxColumn.DataPropertyName = "received";
            this.receivedDataGridViewCheckBoxColumn.HeaderText = "received";
            this.receivedDataGridViewCheckBoxColumn.Name = "receivedDataGridViewCheckBoxColumn";
            this.receivedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // ordersBindingSource3
            // 
            this.ordersBindingSource3.DataMember = "Orders";
            this.ordersBindingSource3.DataSource = this.gROUP4DataSetOrderConfirmation;
            // 
            // gROUP4DataSetOrderConfirmation
            // 
            this.gROUP4DataSetOrderConfirmation.DataSetName = "GROUP4DataSetOrderConfirmation";
            this.gROUP4DataSetOrderConfirmation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataGridView
            // 
            this.DataGridView.Controls.Add(this.groupBoxAddVendor);
            this.DataGridView.Controls.Add(this.dataGridView2);
            this.DataGridView.Location = new System.Drawing.Point(4, 25);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Padding = new System.Windows.Forms.Padding(4);
            this.DataGridView.Size = new System.Drawing.Size(1115, 568);
            this.DataGridView.TabIndex = 4;
            this.DataGridView.Text = "Vendors";
            this.DataGridView.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddVendor
            // 
            this.groupBoxAddVendor.Controls.Add(this.btnAddVendor);
            this.groupBoxAddVendor.Controls.Add(this.label55);
            this.groupBoxAddVendor.Controls.Add(this.label56);
            this.groupBoxAddVendor.Controls.Add(this.tbVendorEmail);
            this.groupBoxAddVendor.Controls.Add(this.tbVendorName);
            this.groupBoxAddVendor.Location = new System.Drawing.Point(762, 8);
            this.groupBoxAddVendor.Name = "groupBoxAddVendor";
            this.groupBoxAddVendor.Size = new System.Drawing.Size(325, 225);
            this.groupBoxAddVendor.TabIndex = 1;
            this.groupBoxAddVendor.TabStop = false;
            this.groupBoxAddVendor.Text = "Add Vendor";
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Location = new System.Drawing.Point(78, 132);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(188, 35);
            this.btnAddVendor.TabIndex = 14;
            this.btnAddVendor.Text = "Add Vendor";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(148, 69);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(48, 16);
            this.label55.TabIndex = 13;
            this.label55.Text = "E-Mail";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(122, 24);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(95, 16);
            this.label56.TabIndex = 12;
            this.label56.Text = "Vendor Name";
            // 
            // tbVendorEmail
            // 
            this.tbVendorEmail.Location = new System.Drawing.Point(53, 88);
            this.tbVendorEmail.Name = "tbVendorEmail";
            this.tbVendorEmail.Size = new System.Drawing.Size(231, 23);
            this.tbVendorEmail.TabIndex = 11;
            // 
            // tbVendorName
            // 
            this.tbVendorName.Location = new System.Drawing.Point(53, 43);
            this.tbVendorName.Name = "tbVendorName";
            this.tbVendorName.Size = new System.Drawing.Size(231, 23);
            this.tbVendorName.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorIDDataGridViewTextBoxColumn1,
            this.vendorNameDataGridViewTextBoxColumn,
            this.vendorEmailDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vendorsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 8);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(720, 553);
            this.dataGridView2.TabIndex = 0;
            // 
            // vendorIDDataGridViewTextBoxColumn1
            // 
            this.vendorIDDataGridViewTextBoxColumn1.DataPropertyName = "vendorID";
            this.vendorIDDataGridViewTextBoxColumn1.HeaderText = "Vendor ID";
            this.vendorIDDataGridViewTextBoxColumn1.Name = "vendorIDDataGridViewTextBoxColumn1";
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "vendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "Vendor Name";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            this.vendorNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // vendorEmailDataGridViewTextBoxColumn
            // 
            this.vendorEmailDataGridViewTextBoxColumn.DataPropertyName = "vendorEmail";
            this.vendorEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.vendorEmailDataGridViewTextBoxColumn.Name = "vendorEmailDataGridViewTextBoxColumn";
            this.vendorEmailDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.gROUP4DataSet;
            // 
            // gROUP4DataSet
            // 
            this.gROUP4DataSet.DataSetName = "GROUP4DataSet";
            this.gROUP4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DGVMainMenu
            // 
            this.DGVMainMenu.Controls.Add(this.groupBoxAddPart);
            this.DGVMainMenu.Controls.Add(this.groupBoxViewLocation);
            this.DGVMainMenu.Controls.Add(this.groupBoxViewUsers);
            this.DGVMainMenu.Controls.Add(this.groupBoxAddLocation);
            this.DGVMainMenu.Controls.Add(this.groupBoxAddUser);
            this.DGVMainMenu.Location = new System.Drawing.Point(4, 25);
            this.DGVMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.DGVMainMenu.Name = "DGVMainMenu";
            this.DGVMainMenu.Padding = new System.Windows.Forms.Padding(4);
            this.DGVMainMenu.Size = new System.Drawing.Size(1115, 568);
            this.DGVMainMenu.TabIndex = 5;
            this.DGVMainMenu.Text = "Manage";
            this.DGVMainMenu.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddPart
            // 
            this.groupBoxAddPart.Controls.Add(this.btnAddPart);
            this.groupBoxAddPart.Controls.Add(this.label54);
            this.groupBoxAddPart.Controls.Add(this.label53);
            this.groupBoxAddPart.Controls.Add(this.label52);
            this.groupBoxAddPart.Controls.Add(this.label51);
            this.groupBoxAddPart.Controls.Add(this.label50);
            this.groupBoxAddPart.Controls.Add(this.label49);
            this.groupBoxAddPart.Controls.Add(this.label48);
            this.groupBoxAddPart.Controls.Add(this.label47);
            this.groupBoxAddPart.Controls.Add(this.cbPartLocSelect);
            this.groupBoxAddPart.Controls.Add(this.tbAddPartVendor);
            this.groupBoxAddPart.Controls.Add(this.tbAddShipTime);
            this.groupBoxAddPart.Controls.Add(this.tbAddExptLife);
            this.groupBoxAddPart.Controls.Add(this.tbAddReorderPoint);
            this.groupBoxAddPart.Controls.Add(this.tbAddQTY);
            this.groupBoxAddPart.Controls.Add(this.tbAddItemCost);
            this.groupBoxAddPart.Controls.Add(this.tbAddItemDesc);
            this.groupBoxAddPart.Location = new System.Drawing.Point(820, 11);
            this.groupBoxAddPart.Name = "groupBoxAddPart";
            this.groupBoxAddPart.Size = new System.Drawing.Size(288, 550);
            this.groupBoxAddPart.TabIndex = 6;
            this.groupBoxAddPart.TabStop = false;
            this.groupBoxAddPart.Text = "Add Part";
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(30, 397);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(229, 36);
            this.btnAddPart.TabIndex = 16;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(27, 338);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(70, 16);
            this.label54.TabIndex = 15;
            this.label54.Text = "Location:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(27, 293);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(111, 16);
            this.label53.TabIndex = 14;
            this.label53.Text = "Shipment Time:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(27, 248);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(103, 16);
            this.label52.TabIndex = 13;
            this.label52.Text = "Expected Life:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(26, 203);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(102, 16);
            this.label51.TabIndex = 12;
            this.label51.Text = "Reorder Point:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(26, 156);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(71, 16);
            this.label50.TabIndex = 11;
            this.label50.Text = "Quantity:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(27, 110);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(60, 16);
            this.label49.TabIndex = 10;
            this.label49.Text = "Vendor:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(26, 65);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(88, 16);
            this.label48.TabIndex = 9;
            this.label48.Text = "Cost (USD):";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(25, 20);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(122, 16);
            this.label47.TabIndex = 8;
            this.label47.Text = "Item Description:";
            // 
            // cbPartLocSelect
            // 
            this.cbPartLocSelect.CausesValidation = false;
            this.cbPartLocSelect.DataSource = this.locationBindingSource;
            this.cbPartLocSelect.DisplayMember = "name";
            this.cbPartLocSelect.FormattingEnabled = true;
            this.cbPartLocSelect.Location = new System.Drawing.Point(29, 357);
            this.cbPartLocSelect.Name = "cbPartLocSelect";
            this.cbPartLocSelect.Size = new System.Drawing.Size(230, 24);
            this.cbPartLocSelect.TabIndex = 7;
            this.cbPartLocSelect.ValueMember = "name";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.gROUP4DataSetLocation;
            // 
            // gROUP4DataSetLocation
            // 
            this.gROUP4DataSetLocation.DataSetName = "GROUP4DataSetLocation";
            this.gROUP4DataSetLocation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAddPartVendor
            // 
            this.tbAddPartVendor.CausesValidation = false;
            this.tbAddPartVendor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendorsBindingSource, "vendorID", true));
            this.tbAddPartVendor.DataSource = this.vendorsBindingSource;
            this.tbAddPartVendor.DisplayMember = "vendorName";
            this.tbAddPartVendor.FormattingEnabled = true;
            this.tbAddPartVendor.Location = new System.Drawing.Point(30, 129);
            this.tbAddPartVendor.Name = "tbAddPartVendor";
            this.tbAddPartVendor.Size = new System.Drawing.Size(230, 24);
            this.tbAddPartVendor.TabIndex = 6;
            this.tbAddPartVendor.ValueMember = "vendorName";
            // 
            // tbAddShipTime
            // 
            this.tbAddShipTime.Location = new System.Drawing.Point(29, 312);
            this.tbAddShipTime.Name = "tbAddShipTime";
            this.tbAddShipTime.Size = new System.Drawing.Size(230, 23);
            this.tbAddShipTime.TabIndex = 5;
            // 
            // tbAddExptLife
            // 
            this.tbAddExptLife.Location = new System.Drawing.Point(29, 267);
            this.tbAddExptLife.Name = "tbAddExptLife";
            this.tbAddExptLife.Size = new System.Drawing.Size(230, 23);
            this.tbAddExptLife.TabIndex = 4;
            // 
            // tbAddReorderPoint
            // 
            this.tbAddReorderPoint.Location = new System.Drawing.Point(29, 222);
            this.tbAddReorderPoint.Name = "tbAddReorderPoint";
            this.tbAddReorderPoint.Size = new System.Drawing.Size(231, 23);
            this.tbAddReorderPoint.TabIndex = 3;
            // 
            // tbAddQTY
            // 
            this.tbAddQTY.Location = new System.Drawing.Point(29, 175);
            this.tbAddQTY.Name = "tbAddQTY";
            this.tbAddQTY.Size = new System.Drawing.Size(231, 23);
            this.tbAddQTY.TabIndex = 2;
            // 
            // tbAddItemCost
            // 
            this.tbAddItemCost.Location = new System.Drawing.Point(29, 84);
            this.tbAddItemCost.Name = "tbAddItemCost";
            this.tbAddItemCost.Size = new System.Drawing.Size(231, 23);
            this.tbAddItemCost.TabIndex = 1;
            // 
            // tbAddItemDesc
            // 
            this.tbAddItemDesc.Location = new System.Drawing.Point(29, 39);
            this.tbAddItemDesc.Name = "tbAddItemDesc";
            this.tbAddItemDesc.Size = new System.Drawing.Size(231, 23);
            this.tbAddItemDesc.TabIndex = 0;
            // 
            // groupBoxViewLocation
            // 
            this.groupBoxViewLocation.Controls.Add(this.dataGridView3);
            this.groupBoxViewLocation.Location = new System.Drawing.Point(378, 270);
            this.groupBoxViewLocation.Name = "groupBoxViewLocation";
            this.groupBoxViewLocation.Size = new System.Drawing.Size(440, 291);
            this.groupBoxViewLocation.TabIndex = 5;
            this.groupBoxViewLocation.TabStop = false;
            this.groupBoxViewLocation.Text = "Locations";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.zIPDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.locationBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(434, 269);
            this.dataGridView3.TabIndex = 4;
            // 
            // locationIDDataGridViewTextBoxColumn1
            // 
            this.locationIDDataGridViewTextBoxColumn1.DataPropertyName = "locationID";
            this.locationIDDataGridViewTextBoxColumn1.HeaderText = "Location ID";
            this.locationIDDataGridViewTextBoxColumn1.Name = "locationIDDataGridViewTextBoxColumn1";
            this.locationIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // zIPDataGridViewTextBoxColumn
            // 
            this.zIPDataGridViewTextBoxColumn.DataPropertyName = "ZIP";
            this.zIPDataGridViewTextBoxColumn.HeaderText = "ZIP";
            this.zIPDataGridViewTextBoxColumn.Name = "zIPDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Location Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // groupBoxViewUsers
            // 
            this.groupBoxViewUsers.Controls.Add(this.dataGridView4);
            this.groupBoxViewUsers.Location = new System.Drawing.Point(7, 270);
            this.groupBoxViewUsers.Name = "groupBoxViewUsers";
            this.groupBoxViewUsers.Size = new System.Drawing.Size(362, 291);
            this.groupBoxViewUsers.TabIndex = 4;
            this.groupBoxViewUsers.TabStop = false;
            this.groupBoxViewUsers.Text = "Users";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.usersBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 19);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(356, 269);
            this.dataGridView4.TabIndex = 4;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User ID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 81;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.gROUP4DataSetUsers;
            // 
            // gROUP4DataSetUsers
            // 
            this.gROUP4DataSetUsers.DataSetName = "GROUP4DataSetUsers";
            this.gROUP4DataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxAddLocation
            // 
            this.groupBoxAddLocation.Controls.Add(this.btnAddLocation);
            this.groupBoxAddLocation.Controls.Add(this.label46);
            this.groupBoxAddLocation.Controls.Add(this.label45);
            this.groupBoxAddLocation.Controls.Add(this.label44);
            this.groupBoxAddLocation.Controls.Add(this.label43);
            this.groupBoxAddLocation.Controls.Add(this.cbLocType);
            this.groupBoxAddLocation.Controls.Add(this.label42);
            this.groupBoxAddLocation.Controls.Add(this.label41);
            this.groupBoxAddLocation.Controls.Add(this.tbAddZip);
            this.groupBoxAddLocation.Controls.Add(this.tbAddState);
            this.groupBoxAddLocation.Controls.Add(this.tbAddCity);
            this.groupBoxAddLocation.Controls.Add(this.tbAddStreet);
            this.groupBoxAddLocation.Controls.Add(this.tbAddLocName);
            this.groupBoxAddLocation.Location = new System.Drawing.Point(381, 11);
            this.groupBoxAddLocation.Name = "groupBoxAddLocation";
            this.groupBoxAddLocation.Size = new System.Drawing.Size(433, 256);
            this.groupBoxAddLocation.TabIndex = 1;
            this.groupBoxAddLocation.TabStop = false;
            this.groupBoxAddLocation.Text = "Add Location";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(129, 176);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(179, 29);
            this.btnAddLocation.TabIndex = 11;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(229, 114);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(36, 16);
            this.label46.TabIndex = 16;
            this.label46.Text = "ZIP:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(225, 68);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(51, 16);
            this.label45.TabIndex = 15;
            this.label45.Text = "State:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(225, 19);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(40, 16);
            this.label44.TabIndex = 14;
            this.label44.Text = "City:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(19, 114);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(56, 16);
            this.label43.TabIndex = 13;
            this.label43.Text = "Street:";
            // 
            // cbLocType
            // 
            this.cbLocType.FormattingEnabled = true;
            this.cbLocType.Items.AddRange(new object[] {
            "",
            "Warehouse",
            "Drilling Site"});
            this.cbLocType.Location = new System.Drawing.Point(19, 87);
            this.cbLocType.Name = "cbLocType";
            this.cbLocType.Size = new System.Drawing.Size(179, 24);
            this.cbLocType.TabIndex = 10;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(19, 68);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(47, 16);
            this.label42.TabIndex = 12;
            this.label42.Text = "Type:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(16, 19);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(50, 16);
            this.label41.TabIndex = 11;
            this.label41.Text = "Name:";
            // 
            // tbAddZip
            // 
            this.tbAddZip.Location = new System.Drawing.Point(228, 133);
            this.tbAddZip.Name = "tbAddZip";
            this.tbAddZip.Size = new System.Drawing.Size(172, 23);
            this.tbAddZip.TabIndex = 10;
            // 
            // tbAddState
            // 
            this.tbAddState.Location = new System.Drawing.Point(228, 84);
            this.tbAddState.Name = "tbAddState";
            this.tbAddState.Size = new System.Drawing.Size(172, 23);
            this.tbAddState.TabIndex = 9;
            // 
            // tbAddCity
            // 
            this.tbAddCity.Location = new System.Drawing.Point(228, 39);
            this.tbAddCity.Name = "tbAddCity";
            this.tbAddCity.Size = new System.Drawing.Size(172, 23);
            this.tbAddCity.TabIndex = 8;
            // 
            // tbAddStreet
            // 
            this.tbAddStreet.Location = new System.Drawing.Point(19, 133);
            this.tbAddStreet.Name = "tbAddStreet";
            this.tbAddStreet.Size = new System.Drawing.Size(179, 23);
            this.tbAddStreet.TabIndex = 7;
            // 
            // tbAddLocName
            // 
            this.tbAddLocName.Location = new System.Drawing.Point(19, 39);
            this.tbAddLocName.Name = "tbAddLocName";
            this.tbAddLocName.Size = new System.Drawing.Size(179, 23);
            this.tbAddLocName.TabIndex = 5;
            // 
            // groupBoxAddUser
            // 
            this.groupBoxAddUser.Controls.Add(this.btnAddUser);
            this.groupBoxAddUser.Controls.Add(this.label40);
            this.groupBoxAddUser.Controls.Add(this.label39);
            this.groupBoxAddUser.Controls.Add(this.label38);
            this.groupBoxAddUser.Controls.Add(this.label37);
            this.groupBoxAddUser.Controls.Add(this.cbJobTitle);
            this.groupBoxAddUser.Controls.Add(this.tbAddConfPassword);
            this.groupBoxAddUser.Controls.Add(this.tbAddPassword);
            this.groupBoxAddUser.Controls.Add(this.tbAddUsername);
            this.groupBoxAddUser.Controls.Add(this.label36);
            this.groupBoxAddUser.Controls.Add(this.tbAddName);
            this.groupBoxAddUser.Location = new System.Drawing.Point(7, 11);
            this.groupBoxAddUser.Name = "groupBoxAddUser";
            this.groupBoxAddUser.Size = new System.Drawing.Size(362, 256);
            this.groupBoxAddUser.TabIndex = 0;
            this.groupBoxAddUser.TabStop = false;
            this.groupBoxAddUser.Text = "Add User";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(143, 213);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(179, 32);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(67, 182);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(70, 16);
            this.label40.TabIndex = 9;
            this.label40.Text = "Job Title:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(7, 142);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(130, 16);
            this.label39.TabIndex = 8;
            this.label39.Text = "Confirm Password:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(61, 103);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(76, 16);
            this.label38.TabIndex = 7;
            this.label38.Text = "Password:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(59, 64);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(78, 16);
            this.label37.TabIndex = 6;
            this.label37.Text = "Username:";
            // 
            // cbJobTitle
            // 
            this.cbJobTitle.FormattingEnabled = true;
            this.cbJobTitle.Items.AddRange(new object[] {
            "",
            "Auditor",
            "Field Supervisor",
            "Drilling Enginner"});
            this.cbJobTitle.Location = new System.Drawing.Point(143, 179);
            this.cbJobTitle.Name = "cbJobTitle";
            this.cbJobTitle.Size = new System.Drawing.Size(179, 24);
            this.cbJobTitle.TabIndex = 5;
            // 
            // tbAddConfPassword
            // 
            this.tbAddConfPassword.Location = new System.Drawing.Point(143, 139);
            this.tbAddConfPassword.Name = "tbAddConfPassword";
            this.tbAddConfPassword.Size = new System.Drawing.Size(179, 23);
            this.tbAddConfPassword.TabIndex = 4;
            this.tbAddConfPassword.UseSystemPasswordChar = true;
            // 
            // tbAddPassword
            // 
            this.tbAddPassword.Location = new System.Drawing.Point(143, 100);
            this.tbAddPassword.Name = "tbAddPassword";
            this.tbAddPassword.Size = new System.Drawing.Size(179, 23);
            this.tbAddPassword.TabIndex = 3;
            this.tbAddPassword.UseSystemPasswordChar = true;
            // 
            // tbAddUsername
            // 
            this.tbAddUsername.Location = new System.Drawing.Point(143, 61);
            this.tbAddUsername.Name = "tbAddUsername";
            this.tbAddUsername.Size = new System.Drawing.Size(179, 23);
            this.tbAddUsername.TabIndex = 2;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(87, 26);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(50, 16);
            this.label36.TabIndex = 1;
            this.label36.Text = "Name:";
            // 
            // tbAddName
            // 
            this.tbAddName.Location = new System.Drawing.Point(143, 23);
            this.tbAddName.Name = "tbAddName";
            this.tbAddName.Size = new System.Drawing.Size(179, 23);
            this.tbAddName.TabIndex = 0;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.gROUP4DataSetOrderHistory;
            // 
            // gROUP4DataSetOrderHistory
            // 
            this.gROUP4DataSetOrderHistory.DataSetName = "GROUP4DataSetOrderHistory";
            this.gROUP4DataSetOrderHistory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderLineItemBindingSource1
            // 
            this.orderLineItemBindingSource1.DataMember = "Order_Line_Item";
            this.orderLineItemBindingSource1.DataSource = this.gROUP4DataSetOrderLineItemBindingSource;
            // 
            // gROUP4DataSetOrderLineItemBindingSource
            // 
            this.gROUP4DataSetOrderLineItemBindingSource.DataSource = this.gROUP4DataSetOrderLineItem;
            this.gROUP4DataSetOrderLineItemBindingSource.Position = 0;
            // 
            // gROUP4DataSetOrderLineItem
            // 
            this.gROUP4DataSetOrderLineItem.DataSetName = "GROUP4DataSetOrderLineItem";
            this.gROUP4DataSetOrderLineItem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = global::WWOC_Desktop_App.Properties.Resources.main_menu__5_;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Location = new System.Drawing.Point(32, 399);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(209, 128);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WWOC_Desktop_App.Properties.Resources.Luis_Oil_Logo__2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 202);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnMetrics
            // 
            this.btnMetrics.BackgroundImage = global::WWOC_Desktop_App.Properties.Resources.main_menu__3_;
            this.btnMetrics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMetrics.Location = new System.Drawing.Point(32, 251);
            this.btnMetrics.Margin = new System.Windows.Forms.Padding(4);
            this.btnMetrics.Name = "btnMetrics";
            this.btnMetrics.Size = new System.Drawing.Size(209, 128);
            this.btnMetrics.TabIndex = 2;
            this.btnMetrics.UseVisualStyleBackColor = true;
            this.btnMetrics.Click += new System.EventHandler(this.btnMetrics_Click);
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // grouP4DataSet1
            // 
            this.grouP4DataSet1.DataSetName = "GROUP4DataSet";
            this.grouP4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grouP4DataSet2
            // 
            this.grouP4DataSet2.DataSetName = "GROUP4DataSet";
            this.grouP4DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderLineItemBindingSource
            // 
            this.orderLineItemBindingSource.DataMember = "Order_Line_Item";
            this.orderLineItemBindingSource.DataSource = this.gROUP4DataSetOrderLineItemBindingSource;
            // 
            // order_Line_ItemTableAdapter
            // 
            this.order_Line_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // partsBindingSource1
            // 
            this.partsBindingSource1.DataMember = "Parts";
            this.partsBindingSource1.DataSource = this.gROUP4DataSetOrderLineItemBindingSource;
            // 
            // partsTableAdapter1
            // 
            this.partsTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.gROUP4DataSetOrderConfirmation;
            // 
            // ordersTableAdapter2
            // 
            this.ordersTableAdapter2.ClearBeforeFill = true;
            // 
            // gROUP4DataSetOrderConfirmationBindingSource
            // 
            this.gROUP4DataSetOrderConfirmationBindingSource.DataSource = this.gROUP4DataSetOrderConfirmation;
            this.gROUP4DataSetOrderConfirmationBindingSource.Position = 0;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 30000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1425, 628);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.btnMetrics);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageParts.ResumeLayout(false);
            this.groupBoxCheckOut.ResumeLayout(false);
            this.groupBoxCheckOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageRequest.ResumeLayout(false);
            this.groupBoxRemove.ResumeLayout(false);
            this.groupBoxRemove.PerformLayout();
            this.groupBoxOrderSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
            this.groupBoxOrderInfo.ResumeLayout(false);
            this.groupBoxOrderInfo.PerformLayout();
            this.groupBoxPartInfo.ResumeLayout(false);
            this.groupBoxPartInfo.PerformLayout();
            this.tabPagePending.ResumeLayout(false);
            this.tabPagePending.PerformLayout();
            this.groupBoxOrderDetailsP.ResumeLayout(false);
            this.groupBoxOrderDetailsP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPO_PartsinOrder)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.groupBoxPendingOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPO_PendingOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPendingOrders)).EndInit();
            this.tabPageHistory.ResumeLayout(false);
            this.tabPageHistory.PerformLayout();
            this.gbOH_orderDetails.ResumeLayout(false);
            this.gbOH_orderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOH_PartsInOrder)).EndInit();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            this.groupBoxOrderHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOH_orderHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderConfirmation)).EndInit();
            this.DataGridView.ResumeLayout(false);
            this.groupBoxAddVendor.ResumeLayout(false);
            this.groupBoxAddVendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).EndInit();
            this.DGVMainMenu.ResumeLayout(false);
            this.groupBoxAddPart.ResumeLayout(false);
            this.groupBoxAddPart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetLocation)).EndInit();
            this.groupBoxViewLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBoxViewUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetUsers)).EndInit();
            this.groupBoxAddLocation.ResumeLayout(false);
            this.groupBoxAddLocation.PerformLayout();
            this.groupBoxAddUser.ResumeLayout(false);
            this.groupBoxAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderLineItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderLineItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouP4DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouP4DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetOrderConfirmationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMetrics;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageParts;
        private System.Windows.Forms.TabPage tabPagePending;
        private System.Windows.Forms.TabPage tabPageRequest;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.TabPage DataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gROUP4DataSetPartsBindingSource;
        private GROUP4DataSetParts gROUP4DataSetParts;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private GROUP4DataSetPartsTableAdapters.PartsTableAdapter partsTableAdapter;
        private System.Windows.Forms.TabPage DGVMainMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GROUP4DataSet gROUP4DataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private GROUP4DataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.ComboBox cBoxPartDescription;
        private System.Windows.Forms.GroupBox groupBoxPartInfo;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmitOrderRequest;
        private System.Windows.Forms.Label lbApproveOrder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQtyOrder;
        private System.Windows.Forms.TextBox tbQtyStock;
        private System.Windows.Forms.GroupBox groupBoxOrderInfo;
        private System.Windows.Forms.CheckBox checkBoxApprove;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.TextBox tbSalesTax;
        private System.Windows.Forms.TextBox tbShippingHandling;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.TextBox tbShippingTime;
        private System.Windows.Forms.TextBox tbPODate;
        private System.Windows.Forms.TextBox tbTerms;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbVendor;
        private System.Windows.Forms.TextBox tbPartID;
        private System.Windows.Forms.GroupBox groupBoxOrderSummary;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.GroupBox groupBoxRemove;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cBoxRemove;
        private GROUP4DataSet grouP4DataSet1;
        private System.Windows.Forms.BindingSource gROUP4DataSetOrderLineItemBindingSource;
        private GROUP4DataSetOrderLineItem gROUP4DataSetOrderLineItem;
        private System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.Button btnCreateOrder;
        private GROUP4DataSet grouP4DataSet2;
        private System.Windows.Forms.BindingSource orderLineItemBindingSource;
        private GROUP4DataSetOrderLineItemTableAdapters.Order_Line_ItemTableAdapter order_Line_ItemTableAdapter;
        private System.Windows.Forms.BindingSource partsBindingSource1;
        private GROUP4DataSetOrderLineItemTableAdapters.PartsTableAdapter partsTableAdapter1;
        private System.Windows.Forms.BindingSource orderLineItemBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPendingOrders;
        private System.Windows.Forms.DataGridView dataGridPO_PendingOrders;
        private System.Windows.Forms.GroupBox groupBoxOrderHistory;
        private System.Windows.Forms.DataGridView dataGridOH_orderHistory;
        private GROUP4DataSetPendingOrders gROUP4DataSetPendingOrders;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private GROUP4DataSetPendingOrdersTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.GroupBox groupBoxOrderDetailsP;
        private System.Windows.Forms.TextBox tbPO_OrderID;
        private System.Windows.Forms.Button btnApproveOrder;
        private System.Windows.Forms.TextBox tbPO_Username;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbPO_PODate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridPO_PartsinOrder;
        private System.Windows.Forms.Button btnRejectOrder;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbPO_Terms;
        private System.Windows.Forms.TextBox tbPO_TotalPrice;
        private System.Windows.Forms.TextBox tbPO_ShippingHandling;
        private System.Windows.Forms.TextBox tbPO_SalesTax;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbPO_SubTotal;
        private System.Windows.Forms.TextBox tbPO_ShipTime;
        private GROUP4DataSetOrderHistory gROUP4DataSetOrderHistory;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private GROUP4DataSetOrderHistoryTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.GroupBox gbOH_orderDetails;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dataGridOH_PartsInOrder;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbOH_terms;
        private System.Windows.Forms.TextBox tbOH_totalPrice;
        private System.Windows.Forms.TextBox tbOH_shippingHandling;
        private System.Windows.Forms.TextBox tbOH_salesTax;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbOH_subtotal;
        private System.Windows.Forms.TextBox tbOH_shippingTime;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbOH_POdate;
        private System.Windows.Forms.TextBox tbOH_username;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbOH_orderID;
        private System.Windows.Forms.GroupBox groupBoxAddVendor;
        private System.Windows.Forms.GroupBox groupBoxViewLocation;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBoxViewUsers;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox groupBoxAddLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox cbLocType;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tbAddZip;
        private System.Windows.Forms.TextBox tbAddState;
        private System.Windows.Forms.TextBox tbAddCity;
        private System.Windows.Forms.TextBox tbAddStreet;
        private System.Windows.Forms.TextBox tbAddLocName;
        private System.Windows.Forms.GroupBox groupBoxAddUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cbJobTitle;
        private System.Windows.Forms.TextBox tbAddConfPassword;
        private System.Windows.Forms.TextBox tbAddPassword;
        private System.Windows.Forms.TextBox tbAddUsername;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbAddName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approvedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox tbVendorEmail;
        private System.Windows.Forms.TextBox tbVendorName;
        private GROUP4DataSetUsers gROUP4DataSetUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private GROUP4DataSetUsersTableAdapters.UsersTableAdapter usersTableAdapter;
        private GROUP4DataSetLocation gROUP4DataSetLocation;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private GROUP4DataSetLocationTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxAddPart;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox cbPartLocSelect;
        private System.Windows.Forms.ComboBox tbAddPartVendor;
        private System.Windows.Forms.TextBox tbAddShipTime;
        private System.Windows.Forms.TextBox tbAddExptLife;
        private System.Windows.Forms.TextBox tbAddReorderPoint;
        private System.Windows.Forms.TextBox tbAddQTY;
        private System.Windows.Forms.TextBox tbAddItemCost;
        private System.Windows.Forms.TextBox tbAddItemDesc;
        private System.Windows.Forms.GroupBox groupBoxCheckOut;
        private System.Windows.Forms.ComboBox cbPartName;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tbInvQtyTaken;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox tbInvQtyOH;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costUSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exptdLifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPartCheckOut;
        private System.Windows.Forms.Button btnConfirmOrder;
        private GROUP4DataSetOrderConfirmation gROUP4DataSetOrderConfirmation;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private GROUP4DataSetOrderConfirmationTableAdapters.OrdersTableAdapter ordersTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn poDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approvedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn receivedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
        private System.Windows.Forms.BindingSource gROUP4DataSetOrderConfirmationBindingSource;
        private System.Windows.Forms.BindingSource partsBindingSource2;
        private System.Windows.Forms.Timer timerUpdate;
    }
}