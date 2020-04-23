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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxApprove = new System.Windows.Forms.CheckBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.tbOtherCharges = new System.Windows.Forms.TextBox();
            this.tbShippingHandling = new System.Windows.Forms.TextBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.lbApproveOrder = new System.Windows.Forms.Label();
            this.tbShippingTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPODate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTerms = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.DataGridView = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vendorIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP4DataSet = new WWOC_Desktop_App.GROUP4DataSet();
            this.DGVMainMenu = new System.Windows.Forms.TabPage();
            this.partsTableAdapter = new WWOC_Desktop_App.GROUP4DataSetPartsTableAdapters.PartsTableAdapter();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMetrics = new System.Windows.Forms.Button();
            this.vendorsTableAdapter = new WWOC_Desktop_App.GROUP4DataSetTableAdapters.VendorsTableAdapter();
            this.tbPartID = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetParts)).BeginInit();
            this.tabPageRequest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageParts);
            this.tabControlMain.Controls.Add(this.tabPagePending);
            this.tabControlMain.Controls.Add(this.tabPageRequest);
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(967, 455);
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
            this.tabPagePending.Location = new System.Drawing.Point(4, 25);
            this.tabPagePending.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePending.Name = "tabPagePending";
            this.tabPagePending.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePending.Size = new System.Drawing.Size(1115, 568);
            this.tabPagePending.TabIndex = 1;
            this.tabPagePending.Text = "Pending Orders";
            this.tabPagePending.UseVisualStyleBackColor = true;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Controls.Add(this.groupBox3);
            this.tabPageRequest.Controls.Add(this.groupBox1);
            this.tabPageRequest.Controls.Add(this.button2);
            this.tabPageRequest.Controls.Add(this.label2);
            this.tabPageRequest.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequest.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageRequest.Size = new System.Drawing.Size(1115, 568);
            this.tabPageRequest.TabIndex = 2;
            this.tabPageRequest.Text = "Make Order Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxApprove);
            this.groupBox3.Controls.Add(this.tbTotalPrice);
            this.groupBox3.Controls.Add(this.tbOtherCharges);
            this.groupBox3.Controls.Add(this.tbShippingHandling);
            this.groupBox3.Controls.Add(this.tbSubTotal);
            this.groupBox3.Controls.Add(this.lbApproveOrder);
            this.groupBox3.Controls.Add(this.tbShippingTime);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbPODate);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbTerms);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(554, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 409);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Information";
            // 
            // checkBoxApprove
            // 
            this.checkBoxApprove.AutoSize = true;
            this.checkBoxApprove.Location = new System.Drawing.Point(183, 362);
            this.checkBoxApprove.Name = "checkBoxApprove";
            this.checkBoxApprove.Size = new System.Drawing.Size(15, 14);
            this.checkBoxApprove.TabIndex = 21;
            this.checkBoxApprove.UseVisualStyleBackColor = true;
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(185, 314);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(195, 23);
            this.tbTotalPrice.TabIndex = 24;
            // 
            // tbOtherCharges
            // 
            this.tbOtherCharges.Location = new System.Drawing.Point(185, 275);
            this.tbOtherCharges.Name = "tbOtherCharges";
            this.tbOtherCharges.ReadOnly = true;
            this.tbOtherCharges.Size = new System.Drawing.Size(195, 23);
            this.tbOtherCharges.TabIndex = 23;
            // 
            // tbShippingHandling
            // 
            this.tbShippingHandling.Location = new System.Drawing.Point(185, 236);
            this.tbShippingHandling.Name = "tbShippingHandling";
            this.tbShippingHandling.ReadOnly = true;
            this.tbShippingHandling.Size = new System.Drawing.Size(195, 23);
            this.tbShippingHandling.TabIndex = 22;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.Location = new System.Drawing.Point(185, 198);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.ReadOnly = true;
            this.tbSubTotal.Size = new System.Drawing.Size(195, 23);
            this.tbSubTotal.TabIndex = 21;
            // 
            // lbApproveOrder
            // 
            this.lbApproveOrder.AutoSize = true;
            this.lbApproveOrder.Location = new System.Drawing.Point(70, 360);
            this.lbApproveOrder.Name = "lbApproveOrder";
            this.lbApproveOrder.Size = new System.Drawing.Size(109, 16);
            this.lbApproveOrder.TabIndex = 15;
            this.lbApproveOrder.Text = "Approve Order:";
            // 
            // tbShippingTime
            // 
            this.tbShippingTime.Location = new System.Drawing.Point(185, 58);
            this.tbShippingTime.Name = "tbShippingTime";
            this.tbShippingTime.ReadOnly = true;
            this.tbShippingTime.Size = new System.Drawing.Size(195, 23);
            this.tbShippingTime.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(94, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Total Price:";
            // 
            // tbPODate
            // 
            this.tbPODate.Location = new System.Drawing.Point(185, 22);
            this.tbPODate.Name = "tbPODate";
            this.tbPODate.ReadOnly = true;
            this.tbPODate.Size = new System.Drawing.Size(195, 23);
            this.tbPODate.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Other Charges:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Shipping and Handling:";
            // 
            // tbTerms
            // 
            this.tbTerms.Location = new System.Drawing.Point(185, 96);
            this.tbTerms.Multiline = true;
            this.tbTerms.Name = "tbTerms";
            this.tbTerms.Size = new System.Drawing.Size(195, 86);
            this.tbTerms.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Subtotal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Shipping Terms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estimated Shipping Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Purchase Order Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPartID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tbVendor);
            this.groupBox1.Controls.Add(this.tbQtyOrder);
            this.groupBox1.Controls.Add(this.tbQtyStock);
            this.groupBox1.Controls.Add(this.tbUnitPrice);
            this.groupBox1.Controls.Add(this.cBoxPartDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(174, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 409);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part Information";
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
            this.cBoxPartDescription.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsBindingSource, "partID", true));
            this.cBoxPartDescription.DataSource = this.partsBindingSource;
            this.cBoxPartDescription.DisplayMember = "itemDesc";
            this.cBoxPartDescription.FormattingEnabled = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "Submit Order Request";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Request Form";
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Location = new System.Drawing.Point(4, 25);
            this.tabPageHistory.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageHistory.Size = new System.Drawing.Size(1115, 568);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "Order History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
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
            this.dataGridView2.Size = new System.Drawing.Size(709, 538);
            this.dataGridView2.TabIndex = 0;
            // 
            // vendorIDDataGridViewTextBoxColumn1
            // 
            this.vendorIDDataGridViewTextBoxColumn1.DataPropertyName = "vendorID";
            this.vendorIDDataGridViewTextBoxColumn1.HeaderText = "vendorID";
            this.vendorIDDataGridViewTextBoxColumn1.Name = "vendorIDDataGridViewTextBoxColumn1";
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "vendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "vendorName";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            // 
            // vendorEmailDataGridViewTextBoxColumn
            // 
            this.vendorEmailDataGridViewTextBoxColumn.DataPropertyName = "vendorEmail";
            this.vendorEmailDataGridViewTextBoxColumn.HeaderText = "vendorEmail";
            this.vendorEmailDataGridViewTextBoxColumn.Name = "vendorEmailDataGridViewTextBoxColumn";
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
            this.DGVMainMenu.Location = new System.Drawing.Point(4, 25);
            this.DGVMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.DGVMainMenu.Name = "DGVMainMenu";
            this.DGVMainMenu.Padding = new System.Windows.Forms.Padding(4);
            this.DGVMainMenu.Size = new System.Drawing.Size(1115, 568);
            this.DGVMainMenu.TabIndex = 5;
            this.DGVMainMenu.Text = "Manage";
            this.DGVMainMenu.UseVisualStyleBackColor = true;
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
            // tbPartID
            // 
            this.tbPartID.Location = new System.Drawing.Point(144, 62);
            this.tbPartID.Name = "tbPartID";
            this.tbPartID.ReadOnly = true;
            this.tbPartID.Size = new System.Drawing.Size(195, 23);
            this.tbPartID.TabIndex = 23;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetParts)).EndInit();
            this.tabPageRequest.ResumeLayout(false);
            this.tabPageRequest.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridView dataGridView2;
        private GROUP4DataSet gROUP4DataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private GROUP4DataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cBoxPartDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQtyOrder;
        private System.Windows.Forms.TextBox tbQtyStock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxApprove;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.TextBox tbOtherCharges;
        private System.Windows.Forms.TextBox tbShippingHandling;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.TextBox tbShippingTime;
        private System.Windows.Forms.TextBox tbPODate;
        private System.Windows.Forms.TextBox tbTerms;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbVendor;
        private System.Windows.Forms.TextBox tbPartID;
    }
}