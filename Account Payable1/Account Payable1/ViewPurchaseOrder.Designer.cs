namespace Account_Payable1
{
    partial class ViewPurchaseOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accountPayableDataSet = new Account_Payable1.AccountPayableDataSet();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderTableAdapter = new Account_Payable1.AccountPayableDataSetTableAdapters.purchaseOrderTableAdapter();
            this.nUMPurchaseOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHRNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHRTermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHRDeliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDeliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPayableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMPurchaseOrderIDDataGridViewTextBoxColumn,
            this.cHRNoteDataGridViewTextBoxColumn,
            this.cHRTermsDataGridViewTextBoxColumn,
            this.mONTaxDataGridViewTextBoxColumn,
            this.dTDateCreatedDataGridViewTextBoxColumn,
            this.cHRDeliveryAddressDataGridViewTextBoxColumn,
            this.dTDeliveryDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchaseOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 115);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1082, 265);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 46);
            this.button2.TabIndex = 26;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // accountPayableDataSet
            // 
            this.accountPayableDataSet.DataSetName = "AccountPayableDataSet";
            this.accountPayableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataMember = "purchaseOrder";
            this.purchaseOrderBindingSource.DataSource = this.accountPayableDataSet;
            // 
            // purchaseOrderTableAdapter
            // 
            this.purchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // nUMPurchaseOrderIDDataGridViewTextBoxColumn
            // 
            this.nUMPurchaseOrderIDDataGridViewTextBoxColumn.DataPropertyName = "NUM_PurchaseOrderID";
            this.nUMPurchaseOrderIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.nUMPurchaseOrderIDDataGridViewTextBoxColumn.Name = "nUMPurchaseOrderIDDataGridViewTextBoxColumn";
            // 
            // cHRNoteDataGridViewTextBoxColumn
            // 
            this.cHRNoteDataGridViewTextBoxColumn.DataPropertyName = "CHR_Notes";
            this.cHRNoteDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.cHRNoteDataGridViewTextBoxColumn.Name = "cHRNoteDataGridViewTextBoxColumn";
            // 
            // cHRTermsDataGridViewTextBoxColumn
            // 
            this.cHRTermsDataGridViewTextBoxColumn.DataPropertyName = "CHR_Terms";
            this.cHRTermsDataGridViewTextBoxColumn.HeaderText = "Terms";
            this.cHRTermsDataGridViewTextBoxColumn.Name = "cHRTermsDataGridViewTextBoxColumn";
            // 
            // mONTaxDataGridViewTextBoxColumn
            // 
            this.mONTaxDataGridViewTextBoxColumn.DataPropertyName = "MON_Tax";
            this.mONTaxDataGridViewTextBoxColumn.HeaderText = "Tax";
            this.mONTaxDataGridViewTextBoxColumn.Name = "mONTaxDataGridViewTextBoxColumn";
            // 
            // dTDateCreatedDataGridViewTextBoxColumn
            // 
            this.dTDateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DT_DateCreated";
            this.dTDateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Created";
            this.dTDateCreatedDataGridViewTextBoxColumn.Name = "dTDateCreatedDataGridViewTextBoxColumn";
            // 
            // cHRDeliveryAddressDataGridViewTextBoxColumn
            // 
            this.cHRDeliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "CHR_DeliveryAddress";
            this.cHRDeliveryAddressDataGridViewTextBoxColumn.HeaderText = "Delivery Address";
            this.cHRDeliveryAddressDataGridViewTextBoxColumn.Name = "cHRDeliveryAddressDataGridViewTextBoxColumn";
            // 
            // dTDeliveryDateDataGridViewTextBoxColumn
            // 
            this.dTDeliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DT_DeliveryDate";
            this.dTDeliveryDateDataGridViewTextBoxColumn.HeaderText = "Delivery Date";
            this.dTDeliveryDateDataGridViewTextBoxColumn.Name = "dTDeliveryDateDataGridViewTextBoxColumn";
            // 
            // ViewPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 708);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewPurchaseOrder";
            this.Text = "View Purchase Order";
            this.Load += new System.EventHandler(this.ViewPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountPayableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private AccountPayableDataSet accountPayableDataSet;
        private System.Windows.Forms.BindingSource purchaseOrderBindingSource;
        private AccountPayableDataSetTableAdapters.purchaseOrderTableAdapter purchaseOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMPurchaseOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHRNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHRTermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTDateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHRDeliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTDeliveryDateDataGridViewTextBoxColumn;
    }
}