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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageParts = new System.Windows.Forms.TabPage();
            this.tabPagePending = new System.Windows.Forms.TabPage();
            this.tabPageRequest = new System.Windows.Forms.TabPage();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
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
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Location = new System.Drawing.Point(13, 87);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1254, 486);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageParts
            // 
            this.tabPageParts.Location = new System.Drawing.Point(4, 22);
            this.tabPageParts.Name = "tabPageParts";
            this.tabPageParts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParts.Size = new System.Drawing.Size(1246, 460);
            this.tabPageParts.TabIndex = 0;
            this.tabPageParts.Text = "Inventory";
            this.tabPageParts.UseVisualStyleBackColor = true;
            // 
            // tabPagePending
            // 
            this.tabPagePending.Location = new System.Drawing.Point(4, 22);
            this.tabPagePending.Name = "tabPagePending";
            this.tabPagePending.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePending.Size = new System.Drawing.Size(1246, 450);
            this.tabPagePending.TabIndex = 1;
            this.tabPagePending.Text = "Pending Orders";
            this.tabPagePending.UseVisualStyleBackColor = true;
            // 
            // tabPageRequest
            // 
            this.tabPageRequest.Location = new System.Drawing.Point(4, 22);
            this.tabPageRequest.Name = "tabPageRequest";
            this.tabPageRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRequest.Size = new System.Drawing.Size(1246, 450);
            this.tabPageRequest.TabIndex = 2;
            this.tabPageRequest.Text = "Make Order Request";
            this.tabPageRequest.UseVisualStyleBackColor = true;
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(1246, 450);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "Order History";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1246, 460);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage tabPage1;
    }
}