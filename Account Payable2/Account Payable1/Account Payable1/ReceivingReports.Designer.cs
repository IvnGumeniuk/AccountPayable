namespace Account_Payable1
{
    partial class ReceivingReports
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
            this.accountPayableDataSet1 = new Account_Payable1.AccountPayableDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLRECEIVINGREPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsPayableDataSet1 = new Account_Payable1.AccountsPayableDataSet1();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tBL_RECEIVING_REPORTTableAdapter = new Account_Payable1.AccountsPayableDataSet1TableAdapters.TBL_RECEIVING_REPORTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.accountPayableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountPayableDataSet1
            // 
            this.accountPayableDataSet1.DataSetName = "AccountPayableDataSet";
            this.accountPayableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rRIDDataGridViewTextBoxColumn,
            this.pOIDDataGridViewTextBoxColumn,
            this.deliverydateDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLRECEIVINGREPORTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(889, 561);
            this.dataGridView1.TabIndex = 0;
            // 
            // rRIDDataGridViewTextBoxColumn
            // 
            this.rRIDDataGridViewTextBoxColumn.DataPropertyName = "RRID";
            this.rRIDDataGridViewTextBoxColumn.HeaderText = "#";
            this.rRIDDataGridViewTextBoxColumn.Name = "rRIDDataGridViewTextBoxColumn";
            this.rRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOIDDataGridViewTextBoxColumn
            // 
            this.pOIDDataGridViewTextBoxColumn.DataPropertyName = "POID";
            this.pOIDDataGridViewTextBoxColumn.HeaderText = "#PurchaseOrder:";
            this.pOIDDataGridViewTextBoxColumn.Name = "pOIDDataGridViewTextBoxColumn";
            this.pOIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliverydateDataGridViewTextBoxColumn
            // 
            this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "delivery_date";
            this.deliverydateDataGridViewTextBoxColumn.HeaderText = "Delivered:";
            this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
            this.deliverydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "Created:";
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            this.createddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total:";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBLRECEIVINGREPORTBindingSource
            // 
            this.tBLRECEIVINGREPORTBindingSource.DataMember = "TBL_RECEIVING_REPORT";
            this.tBLRECEIVINGREPORTBindingSource.DataSource = this.accountsPayableDataSet1;
            // 
            // accountsPayableDataSet1
            // 
            this.accountsPayableDataSet1.DataSetName = "AccountsPayableDataSet1";
            this.accountsPayableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Receiving Reports:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tBL_RECEIVING_REPORTTableAdapter
            // 
            this.tBL_RECEIVING_REPORTTableAdapter.ClearBeforeFill = true;
            // 
            // ReceivingReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceivingReports";
            this.Text = "Receiving Reports";
            this.Load += new System.EventHandler(this.ReceivingReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountPayableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountPayableDataSet accountPayableDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private AccountsPayableDataSet1 accountsPayableDataSet1;
        private System.Windows.Forms.BindingSource tBLRECEIVINGREPORTBindingSource;
        private AccountsPayableDataSet1TableAdapters.TBL_RECEIVING_REPORTTableAdapter tBL_RECEIVING_REPORTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}