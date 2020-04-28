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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageParts = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costUSDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exptdLifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetPartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSetParts = new WWOC_Desktop_App.GROUP4DataSetParts();
            this.tabPagePending = new System.Windows.Forms.TabPage();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.DataGridView = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addVendor = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.vendorName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSet = new WWOC_Desktop_App.GROUP4DataSet();
            this.DGVMainMenu = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addLocation = new System.Windows.Forms.Button();
            this.Street = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.typeLoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.locationName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addUser = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.NameUser = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.locationIDComboBox = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorNameComboBox = new System.Windows.Forms.ComboBox();
            this.vendorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSet2 = new WWOC_Desktop_App.GROUP4DataSet2();
            this.addPart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.shipmentTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.exptdLife = new System.Windows.Forms.TextBox();
            this.expectedLife = new System.Windows.Forms.Label();
            this.reorderPoint = new System.Windows.Forms.TextBox();
            this.reOrder = new System.Windows.Forms.Label();
            this.quanit = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.VendorID = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partsTableAdapter = new WWOC_Desktop_App.GROUP4DataSetPartsTableAdapters.PartsTableAdapter();
            this.vendorsTableAdapter = new WWOC_Desktop_App.GROUP4DataSetTableAdapters.VendorsTableAdapter();
            this.tableAdapterManager = new WWOC_Desktop_App.GROUP4DataSetTableAdapters.TableAdapterManager();
            this.locationTableAdapter = new WWOC_Desktop_App.GROUP4DataSetTableAdapters.LocationTableAdapter();
            this.vendorsTableAdapter1 = new WWOC_Desktop_App.GROUP4DataSet2TableAdapters.VendorsTableAdapter();
            this.vendorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.securityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityTableAdapter = new WWOC_Desktop_App.GROUP4DataSetTableAdapters.SecurityTableAdapter();
            this.jobTitleComboBox = new System.Windows.Forms.ComboBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetParts)).BeginInit();
            this.DataGridView.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).BeginInit();
            this.DGVMainMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Metrics Menu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "checkin checkout in mobile app";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageParts);
            this.tabControlMain.Controls.Add(this.tabPagePending);
            this.tabControlMain.Controls.Add(this.tabPageRequest);
            this.tabControlMain.Controls.Add(this.tabPageHistory);
            this.tabControlMain.Controls.Add(this.DataGridView);
            this.tabControlMain.Controls.Add(this.DGVMainMenu);
            this.tabControlMain.Location = new System.Drawing.Point(13, 87);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1254, 486);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageParts
            // 
            this.tabPageParts.Controls.Add(this.dataGridView1);
            this.tabPageParts.Location = new System.Drawing.Point(4, 22);
            this.tabPageParts.Name = "tabPageParts";
            this.tabPageParts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParts.Size = new System.Drawing.Size(1246, 460);
            this.tabPageParts.TabIndex = 0;
            this.tabPageParts.Text = "Inventory";
            this.tabPageParts.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partIDDataGridViewTextBoxColumn,
            this.itemDescDataGridViewTextBoxColumn,
            this.costUSDDataGridViewTextBoxColumn,
            this.vendorIDDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.reorderPointDataGridViewTextBoxColumn,
            this.exptdLifeDataGridViewTextBoxColumn,
            this.shipmentTimeDataGridViewTextBoxColumn,
            this.locationIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1124, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "partID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "partID";
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            // 
            // itemDescDataGridViewTextBoxColumn
            // 
            this.itemDescDataGridViewTextBoxColumn.DataPropertyName = "itemDesc";
            this.itemDescDataGridViewTextBoxColumn.HeaderText = "itemDesc";
            this.itemDescDataGridViewTextBoxColumn.Name = "itemDescDataGridViewTextBoxColumn";
            // 
            // costUSDDataGridViewTextBoxColumn
            // 
            this.costUSDDataGridViewTextBoxColumn.DataPropertyName = "costUSD";
            this.costUSDDataGridViewTextBoxColumn.HeaderText = "costUSD";
            this.costUSDDataGridViewTextBoxColumn.Name = "costUSDDataGridViewTextBoxColumn";
            // 
            // vendorIDDataGridViewTextBoxColumn
            // 
            this.vendorIDDataGridViewTextBoxColumn.DataPropertyName = "vendorID";
            this.vendorIDDataGridViewTextBoxColumn.HeaderText = "vendorID";
            this.vendorIDDataGridViewTextBoxColumn.Name = "vendorIDDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // reorderPointDataGridViewTextBoxColumn
            // 
            this.reorderPointDataGridViewTextBoxColumn.DataPropertyName = "reorderPoint";
            this.reorderPointDataGridViewTextBoxColumn.HeaderText = "reorderPoint";
            this.reorderPointDataGridViewTextBoxColumn.Name = "reorderPointDataGridViewTextBoxColumn";
            // 
            // exptdLifeDataGridViewTextBoxColumn
            // 
            this.exptdLifeDataGridViewTextBoxColumn.DataPropertyName = "exptdLife";
            this.exptdLifeDataGridViewTextBoxColumn.HeaderText = "exptdLife";
            this.exptdLifeDataGridViewTextBoxColumn.Name = "exptdLifeDataGridViewTextBoxColumn";
            // 
            // shipmentTimeDataGridViewTextBoxColumn
            // 
            this.shipmentTimeDataGridViewTextBoxColumn.DataPropertyName = "shipmentTime";
            this.shipmentTimeDataGridViewTextBoxColumn.HeaderText = "shipmentTime";
            this.shipmentTimeDataGridViewTextBoxColumn.Name = "shipmentTimeDataGridViewTextBoxColumn";
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "locationID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "locationID";
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
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
            // tabPagePending
            // 
            this.tabPagePending.Location = new System.Drawing.Point(4, 22);
            this.tabPagePending.Name = "tabPagePending";
            this.tabPagePending.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePending.Size = new System.Drawing.Size(1246, 460);
            this.tabPagePending.TabIndex = 1;
            this.tabPagePending.Text = "Pending Orders";
            this.tabPagePending.UseVisualStyleBackColor = true;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(1246, 460);
            this.tabPageRequest.TabIndex = 2;
            this.tabPageRequest.Text = "Make Order Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(1246, 460);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "Order History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            this.DataGridView.Controls.Add(this.groupBox4);
            this.DataGridView.Controls.Add(this.dataGridView2);
            this.DataGridView.Location = new System.Drawing.Point(4, 22);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Padding = new System.Windows.Forms.Padding(3);
            this.DataGridView.Size = new System.Drawing.Size(1246, 460);
            this.DataGridView.TabIndex = 4;
            this.DataGridView.Text = "Vendors";
            this.DataGridView.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addVendor);
            this.groupBox4.Controls.Add(this.email);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.vendorName);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Location = new System.Drawing.Point(467, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 448);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Vendor";
            // 
            // addVendor
            // 
            this.addVendor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVendor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addVendor.Location = new System.Drawing.Point(84, 400);
            this.addVendor.Name = "addVendor";
            this.addVendor.Size = new System.Drawing.Size(113, 42);
            this.addVendor.TabIndex = 19;
            this.addVendor.Text = "Add Vendor";
            this.addVendor.UseVisualStyleBackColor = false;
            this.addVendor.Click += new System.EventHandler(this.button6_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(6, 75);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(255, 20);
            this.email.TabIndex = 5;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 59);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "E-Mail";
            // 
            // vendorName
            // 
            this.vendorName.Location = new System.Drawing.Point(6, 33);
            this.vendorName.Name = "vendorName";
            this.vendorName.Size = new System.Drawing.Size(255, 20);
            this.vendorName.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Vendor Name";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vendorIDDataGridViewTextBoxColumn1,
            this.vendorNameDataGridViewTextBoxColumn,
            this.vendorEmailDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vendorsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(458, 477);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.DGVMainMenu.AutoScroll = true;
            this.DGVMainMenu.Controls.Add(this.groupBox3);
            this.DGVMainMenu.Controls.Add(this.groupBox2);
            this.DGVMainMenu.Controls.Add(this.groupBox1);
            this.DGVMainMenu.Location = new System.Drawing.Point(4, 22);
            this.DGVMainMenu.Name = "DGVMainMenu";
            this.DGVMainMenu.Padding = new System.Windows.Forms.Padding(3);
            this.DGVMainMenu.Size = new System.Drawing.Size(1246, 460);
            this.DGVMainMenu.TabIndex = 5;
            this.DGVMainMenu.Text = "Manage";
            this.DGVMainMenu.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.zip);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.state);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.city);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.addLocation);
            this.groupBox3.Controls.Add(this.Street);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.typeLoc);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.locationName);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(604, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 448);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Location";
            // 
            // addLocation
            // 
            this.addLocation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addLocation.Location = new System.Drawing.Point(84, 400);
            this.addLocation.Name = "addLocation";
            this.addLocation.Size = new System.Drawing.Size(113, 42);
            this.addLocation.TabIndex = 19;
            this.addLocation.Text = "Add Location";
            this.addLocation.UseVisualStyleBackColor = false;
            this.addLocation.Click += new System.EventHandler(this.addLocation_Click);
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(10, 116);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(255, 20);
            this.Street.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Street";
            // 
            // typeLoc
            // 
            this.typeLoc.Location = new System.Drawing.Point(10, 78);
            this.typeLoc.Name = "typeLoc";
            this.typeLoc.Size = new System.Drawing.Size(255, 20);
            this.typeLoc.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Type";
            // 
            // locationName
            // 
            this.locationName.Location = new System.Drawing.Point(10, 32);
            this.locationName.Name = "locationName";
            this.locationName.Size = new System.Drawing.Size(255, 20);
            this.locationName.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jobTitleComboBox);
            this.groupBox2.Controls.Add(this.confirmPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.addUser);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.NameUser);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.username);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(305, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 462);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add User";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addUser.Location = new System.Drawing.Point(84, 400);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(113, 42);
            this.addUser.TabIndex = 19;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Job Title";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // NameUser
            // 
            this.NameUser.Location = new System.Drawing.Point(6, 32);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(255, 20);
            this.NameUser.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Name";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(6, 117);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(255, 20);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 101);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Password";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(6, 74);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(255, 20);
            this.username.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "User Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.locationIDComboBox);
            this.groupBox1.Controls.Add(this.vendorNameComboBox);
            this.groupBox1.Controls.Add(this.addPart);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.shipmentTime);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.exptdLife);
            this.groupBox1.Controls.Add(this.expectedLife);
            this.groupBox1.Controls.Add(this.reorderPoint);
            this.groupBox1.Controls.Add(this.reOrder);
            this.groupBox1.Controls.Add(this.quanit);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.VendorID);
            this.groupBox1.Controls.Add(this.Cost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.itemDesc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Part";
            // 
            // locationIDComboBox
            // 
            this.locationIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locationBindingSource, "locationID", true));
            this.locationIDComboBox.FormattingEnabled = true;
            this.locationIDComboBox.Location = new System.Drawing.Point(3, 328);
            this.locationIDComboBox.Name = "locationIDComboBox";
            this.locationIDComboBox.Size = new System.Drawing.Size(261, 21);
            this.locationIDComboBox.TabIndex = 20;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.gROUP4DataSet;
            // 
            // vendorNameComboBox
            // 
            this.vendorNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "vendorName", true));
            this.vendorNameComboBox.DataSource = this.vendorsBindingSource1;
            this.vendorNameComboBox.FormattingEnabled = true;
            this.vendorNameComboBox.Location = new System.Drawing.Point(3, 116);
            this.vendorNameComboBox.Name = "vendorNameComboBox";
            this.vendorNameComboBox.Size = new System.Drawing.Size(255, 21);
            this.vendorNameComboBox.TabIndex = 19;
            this.vendorNameComboBox.SelectedIndexChanged += new System.EventHandler(this.vendorNameComboBox_SelectedIndexChanged);
            // 
            // vendorsBindingSource1
            // 
            this.vendorsBindingSource1.DataMember = "Vendors";
            this.vendorsBindingSource1.DataSource = this.gROUP4DataSet2;
            // 
            // gROUP4DataSet2
            // 
            this.gROUP4DataSet2.DataSetName = "GROUP4DataSet2";
            this.gROUP4DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addPart
            // 
            this.addPart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addPart.Location = new System.Drawing.Point(91, 400);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(113, 42);
            this.addPart.TabIndex = 18;
            this.addPart.Text = "Add Part";
            this.addPart.UseVisualStyleBackColor = false;
            this.addPart.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Location ID";
            // 
            // shipmentTime
            // 
            this.shipmentTime.Location = new System.Drawing.Point(3, 287);
            this.shipmentTime.Name = "shipmentTime";
            this.shipmentTime.Size = new System.Drawing.Size(258, 20);
            this.shipmentTime.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Shipment Time";
            // 
            // exptdLife
            // 
            this.exptdLife.Location = new System.Drawing.Point(3, 246);
            this.exptdLife.Name = "exptdLife";
            this.exptdLife.Size = new System.Drawing.Size(258, 20);
            this.exptdLife.TabIndex = 13;
            this.exptdLife.TextChanged += new System.EventHandler(this.exptdLife_TextChanged);
            // 
            // expectedLife
            // 
            this.expectedLife.AutoSize = true;
            this.expectedLife.Location = new System.Drawing.Point(0, 230);
            this.expectedLife.Name = "expectedLife";
            this.expectedLife.Size = new System.Drawing.Size(72, 13);
            this.expectedLife.TabIndex = 12;
            this.expectedLife.Text = "Expected Life";
            // 
            // reorderPoint
            // 
            this.reorderPoint.Location = new System.Drawing.Point(3, 203);
            this.reorderPoint.Name = "reorderPoint";
            this.reorderPoint.Size = new System.Drawing.Size(258, 20);
            this.reorderPoint.TabIndex = 11;
            this.reorderPoint.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // reOrder
            // 
            this.reOrder.AutoSize = true;
            this.reOrder.Location = new System.Drawing.Point(0, 187);
            this.reOrder.Name = "reOrder";
            this.reOrder.Size = new System.Drawing.Size(74, 13);
            this.reOrder.TabIndex = 10;
            this.reOrder.Text = "ReOrder Point";
            this.reOrder.Click += new System.EventHandler(this.label7_Click);
            // 
            // quanit
            // 
            this.quanit.Location = new System.Drawing.Point(3, 160);
            this.quanit.Name = "quanit";
            this.quanit.Size = new System.Drawing.Size(258, 20);
            this.quanit.TabIndex = 9;
            this.quanit.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(0, 144);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(43, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Quanity";
            this.label.Click += new System.EventHandler(this.label6_Click);
            // 
            // VendorID
            // 
            this.VendorID.AutoSize = true;
            this.VendorID.Location = new System.Drawing.Point(0, 101);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(41, 13);
            this.VendorID.TabIndex = 6;
            this.VendorID.Text = "Vendor";
            this.VendorID.Click += new System.EventHandler(this.label5_Click);
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(3, 74);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(258, 20);
            this.Cost.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost (USD)";
            // 
            // itemDesc
            // 
            this.itemDesc.Location = new System.Drawing.Point(3, 32);
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(258, 20);
            this.itemDesc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Description";
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LocationTableAdapter = this.locationTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.SecurityTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WWOC_Desktop_App.GROUP4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VendorsTableAdapter = this.vendorsTableAdapter;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsTableAdapter1
            // 
            this.vendorsTableAdapter1.ClearBeforeFill = true;
            // 
            // vendorIDDataGridViewTextBoxColumn1
            // 
            this.vendorIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vendorIDDataGridViewTextBoxColumn1.DataPropertyName = "vendorID";
            this.vendorIDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.vendorIDDataGridViewTextBoxColumn1.Name = "vendorIDDataGridViewTextBoxColumn1";
            this.vendorIDDataGridViewTextBoxColumn1.Width = 43;
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "vendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "Company";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            this.vendorNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // vendorEmailDataGridViewTextBoxColumn
            // 
            this.vendorEmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vendorEmailDataGridViewTextBoxColumn.DataPropertyName = "vendorEmail";
            this.vendorEmailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.vendorEmailDataGridViewTextBoxColumn.Name = "vendorEmailDataGridViewTextBoxColumn";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(6, 160);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(255, 20);
            this.confirmPassword.TabIndex = 21;
            this.confirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Confirm Password";
            // 
            // securityBindingSource
            // 
            this.securityBindingSource.DataMember = "Security";
            this.securityBindingSource.DataSource = this.gROUP4DataSet;
            // 
            // securityTableAdapter
            // 
            this.securityTableAdapter.ClearBeforeFill = true;
            // 
            // jobTitleComboBox
            // 
            this.jobTitleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.securityBindingSource, "jobTitle", true));
            this.jobTitleComboBox.FormattingEnabled = true;
            this.jobTitleComboBox.Location = new System.Drawing.Point(6, 203);
            this.jobTitleComboBox.Name = "jobTitleComboBox";
            this.jobTitleComboBox.Size = new System.Drawing.Size(255, 21);
            this.jobTitleComboBox.TabIndex = 22;
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(10, 244);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(255, 20);
            this.zip.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "ZIP";
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(10, 206);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(255, 20);
            this.state.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "State";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(10, 160);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(255, 20);
            this.city.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "City";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 585);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetParts)).EndInit();
            this.DataGridView.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).EndInit();
            this.DGVMainMenu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costUSDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exptdLifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage DGVMainMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox itemDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VendorID;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quanit;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox reorderPoint;
        private System.Windows.Forms.Label reOrder;
        private System.Windows.Forms.TextBox exptdLife;
        private System.Windows.Forms.Label expectedLife;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NameUser;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox shipmentTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addLocation;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox typeLoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox locationName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GROUP4DataSet gROUP4DataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private GROUP4DataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.ComboBox vendorNameComboBox;
        private GROUP4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GROUP4DataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private GROUP4DataSet2 gROUP4DataSet2;
        private System.Windows.Forms.BindingSource vendorsBindingSource1;
        private GROUP4DataSet2TableAdapters.VendorsTableAdapter vendorsTableAdapter1;
        private System.Windows.Forms.ComboBox locationIDComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addVendor;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox vendorName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource securityBindingSource;
        private GROUP4DataSetTableAdapters.SecurityTableAdapter securityTableAdapter;
        private System.Windows.Forms.ComboBox jobTitleComboBox;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label7;
    }
}