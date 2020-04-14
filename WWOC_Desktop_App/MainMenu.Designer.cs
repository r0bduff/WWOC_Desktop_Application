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
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.DataGridView = new System.Windows.Forms.TabPage();
            this.DGVMainMenu = new System.Windows.Forms.TabPage();
            this.partsTableAdapter = new WWOC_Desktop_App.GROUP4DataSetPartsTableAdapters.PartsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetParts)).BeginInit();
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
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1123, 597);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageParts
            // 
            this.tabPageParts.Controls.Add(this.dataGridView1);
            this.tabPageParts.Location = new System.Drawing.Point(4, 25);
            this.tabPageParts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageParts.Name = "tabPageParts";
            this.tabPageParts.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridView1.Location = new System.Drawing.Point(5, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1499, 550);
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
            this.tabPagePending.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePending.Name = "tabPagePending";
            this.tabPagePending.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPagePending.Size = new System.Drawing.Size(1115, 568);
            this.tabPagePending.TabIndex = 1;
            this.tabPagePending.Text = "Pending Orders";
            this.tabPagePending.UseVisualStyleBackColor = true;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Location = new System.Drawing.Point(4, 25);
            this.tabPageRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageRequest.Size = new System.Drawing.Size(1115, 568);
            this.tabPageRequest.TabIndex = 2;
            this.tabPageRequest.Text = "Make Order Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Location = new System.Drawing.Point(4, 25);
            this.tabPageHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageHistory.Size = new System.Drawing.Size(1115, 568);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "Order History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            this.DataGridView.Location = new System.Drawing.Point(4, 25);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridView.Size = new System.Drawing.Size(1115, 568);
            this.DataGridView.TabIndex = 4;
            this.DataGridView.Text = "Vendors";
            this.DataGridView.UseVisualStyleBackColor = true;
            // 
            // DGVMainMenu
            // 
            this.DGVMainMenu.Location = new System.Drawing.Point(4, 25);
            this.DGVMainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVMainMenu.Name = "DGVMainMenu";
            this.DGVMainMenu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVMainMenu.Size = new System.Drawing.Size(1115, 568);
            this.DGVMainMenu.TabIndex = 5;
            this.DGVMainMenu.Text = "Manage";
            this.DGVMainMenu.UseVisualStyleBackColor = true;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WWOC_Desktop_App.Properties.Resources.main_menu__5_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(32, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 128);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            // button3
            // 
            this.button3.BackgroundImage = global::WWOC_Desktop_App.Properties.Resources.main_menu__3_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(32, 251);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 128);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1425, 628);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageParts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP4DataSetParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Button button1;
    }
}