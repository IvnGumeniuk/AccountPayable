namespace Account_Payable1
{
    partial class AccountsPayable
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseInvoiceInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.logoutcmd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.vendorsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(867, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPurchaseOrderToolStripMenuItem,
            this.viewPurchaseOrderToolStripMenuItem,
            this.purchaseInvoiceInventoryToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // newPurchaseOrderToolStripMenuItem
            // 
            this.newPurchaseOrderToolStripMenuItem.Name = "newPurchaseOrderToolStripMenuItem";
            this.newPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.newPurchaseOrderToolStripMenuItem.Text = "Create Purchase Order";
            this.newPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.newPurchaseOrderToolStripMenuItem_Click);
            // 
            // viewPurchaseOrderToolStripMenuItem
            // 
            this.viewPurchaseOrderToolStripMenuItem.Name = "viewPurchaseOrderToolStripMenuItem";
            this.viewPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.viewPurchaseOrderToolStripMenuItem.Text = "View Purchase Order";
            this.viewPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.viewPurchaseOrderToolStripMenuItem_Click);
            // 
            // purchaseInvoiceInventoryToolStripMenuItem
            // 
            this.purchaseInvoiceInventoryToolStripMenuItem.Name = "purchaseInvoiceInventoryToolStripMenuItem";
            this.purchaseInvoiceInventoryToolStripMenuItem.Size = new System.Drawing.Size(317, 30);
            this.purchaseInvoiceInventoryToolStripMenuItem.Text = "Purchase Invoice (Inventory)";
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInvoicesToolStripMenuItem,
            this.auditReportsToolStripMenuItem,
            this.invoiceProcessingToolStripMenuItem});
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            // 
            // viewInvoicesToolStripMenuItem
            // 
            this.viewInvoicesToolStripMenuItem.Name = "viewInvoicesToolStripMenuItem";
            this.viewInvoicesToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.viewInvoicesToolStripMenuItem.Text = "View Invoices";
            // 
            // auditReportsToolStripMenuItem
            // 
            this.auditReportsToolStripMenuItem.Name = "auditReportsToolStripMenuItem";
            this.auditReportsToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.auditReportsToolStripMenuItem.Text = "View Receiving Reports";
            // 
            // invoiceProcessingToolStripMenuItem
            // 
            this.invoiceProcessingToolStripMenuItem.Name = "invoiceProcessingToolStripMenuItem";
            this.invoiceProcessingToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.invoiceProcessingToolStripMenuItem.Text = "Invoice Processing";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewVendorToolStripMenuItem,
            this.searchVendorToolStripMenuItem});
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.vendorsToolStripMenuItem.Text = "Vendors";
            // 
            // createNewVendorToolStripMenuItem
            // 
            this.createNewVendorToolStripMenuItem.Name = "createNewVendorToolStripMenuItem";
            this.createNewVendorToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.createNewVendorToolStripMenuItem.Text = "Create New Vendor";
            this.createNewVendorToolStripMenuItem.Click += new System.EventHandler(this.createNewVendorToolStripMenuItem_Click);
            // 
            // searchVendorToolStripMenuItem
            // 
            this.searchVendorToolStripMenuItem.Name = "searchVendorToolStripMenuItem";
            this.searchVendorToolStripMenuItem.Size = new System.Drawing.Size(248, 30);
            this.searchVendorToolStripMenuItem.Text = "Search Vendor";
            this.searchVendorToolStripMenuItem.Click += new System.EventHandler(this.searchVendorToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(867, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Account_Payable1.Properties.Resources.Search_512;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Account_Payable1.Properties.Resources.New;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Account_Payable1.Properties.Resources.Save;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Account_Payable1.Properties.Resources.print_icon;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Account_Payable1.Properties.Resources.kisspng_drawing_qcad_toolbar_menu_delete_button_5acb2a1128fd42_7110148415232640171679;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::Account_Payable1.Properties.Resources._1493279;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // logoutcmd
            // 
            this.logoutcmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutcmd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutcmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutcmd.Location = new System.Drawing.Point(771, 32);
            this.logoutcmd.Name = "logoutcmd";
            this.logoutcmd.Size = new System.Drawing.Size(96, 51);
            this.logoutcmd.TabIndex = 3;
            this.logoutcmd.Text = "Logout";
            this.logoutcmd.UseVisualStyleBackColor = true;
            this.logoutcmd.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(621, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back to Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AccountsPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logoutcmd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountsPayable";
            this.Text = "Accounts Payable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseInvoiceInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInvoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripMenuItem searchVendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewVendorToolStripMenuItem;
        private System.Windows.Forms.Button logoutcmd;
        private System.Windows.Forms.Button button1;
    }
}