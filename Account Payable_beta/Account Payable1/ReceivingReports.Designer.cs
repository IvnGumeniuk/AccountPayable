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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBLRECEIVINGREPORTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountsPayableDataSet = new Account_Payable1.AccountsPayableDataSet();
            this.tBLRECEIVINGREPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.tBL_RECEIVING_REPORTTableAdapter = new Account_Payable1.AccountsPayableDataSetTableAdapters.TBL_RECEIVING_REPORTTableAdapter();
            this.nUMRRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTdeliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTcreateddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHRtermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHRnotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMPOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMRRIDDataGridViewTextBoxColumn,
            this.dTdeliverydateDataGridViewTextBoxColumn,
            this.dTcreateddateDataGridViewTextBoxColumn,
            this.fTtotalDataGridViewTextBoxColumn,
            this.cHRtermsDataGridViewTextBoxColumn,
            this.cHRnotesDataGridViewTextBoxColumn,
            this.nUMPOIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLRECEIVINGREPORTBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(790, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tBLRECEIVINGREPORTBindingSource1
            // 
            this.tBLRECEIVINGREPORTBindingSource1.DataMember = "TBL_RECEIVING_REPORT";
            this.tBLRECEIVINGREPORTBindingSource1.DataSource = this.accountsPayableDataSet;
            // 
            // accountsPayableDataSet
            // 
            this.accountsPayableDataSet.DataSetName = "AccountsPayableDataSet";
            this.accountsPayableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLRECEIVINGREPORTBindingSource
            // 
            this.tBLRECEIVINGREPORTBindingSource.DataMember = "TBL_RECEIVING_REPORT";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Receiving Reports:";
            // 
            // tBL_RECEIVING_REPORTTableAdapter
            // 
            this.tBL_RECEIVING_REPORTTableAdapter.ClearBeforeFill = true;
            // 
            // nUMRRIDDataGridViewTextBoxColumn
            // 
            this.nUMRRIDDataGridViewTextBoxColumn.DataPropertyName = "NUM_RRID";
            this.nUMRRIDDataGridViewTextBoxColumn.HeaderText = "Receiving Report";
            this.nUMRRIDDataGridViewTextBoxColumn.Name = "nUMRRIDDataGridViewTextBoxColumn";
            this.nUMRRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTdeliverydateDataGridViewTextBoxColumn
            // 
            this.dTdeliverydateDataGridViewTextBoxColumn.DataPropertyName = "DT_delivery_date";
            this.dTdeliverydateDataGridViewTextBoxColumn.HeaderText = "Delivery Date";
            this.dTdeliverydateDataGridViewTextBoxColumn.Name = "dTdeliverydateDataGridViewTextBoxColumn";
            this.dTdeliverydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTcreateddateDataGridViewTextBoxColumn
            // 
            this.dTcreateddateDataGridViewTextBoxColumn.DataPropertyName = "DT_created_date";
            this.dTcreateddateDataGridViewTextBoxColumn.HeaderText = "Created Date";
            this.dTcreateddateDataGridViewTextBoxColumn.Name = "dTcreateddateDataGridViewTextBoxColumn";
            this.dTcreateddateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fTtotalDataGridViewTextBoxColumn
            // 
            this.fTtotalDataGridViewTextBoxColumn.DataPropertyName = "FT_total";
            this.fTtotalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.fTtotalDataGridViewTextBoxColumn.Name = "fTtotalDataGridViewTextBoxColumn";
            this.fTtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cHRtermsDataGridViewTextBoxColumn
            // 
            this.cHRtermsDataGridViewTextBoxColumn.DataPropertyName = "CHR_terms";
            this.cHRtermsDataGridViewTextBoxColumn.HeaderText = "Terms";
            this.cHRtermsDataGridViewTextBoxColumn.Name = "cHRtermsDataGridViewTextBoxColumn";
            this.cHRtermsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cHRnotesDataGridViewTextBoxColumn
            // 
            this.cHRnotesDataGridViewTextBoxColumn.DataPropertyName = "CHR_notes";
            this.cHRnotesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.cHRnotesDataGridViewTextBoxColumn.Name = "cHRnotesDataGridViewTextBoxColumn";
            this.cHRnotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMPOIDDataGridViewTextBoxColumn
            // 
            this.nUMPOIDDataGridViewTextBoxColumn.DataPropertyName = "NUM_POID";
            this.nUMPOIDDataGridViewTextBoxColumn.HeaderText = "Purchase Order";
            this.nUMPOIDDataGridViewTextBoxColumn.Name = "nUMPOIDDataGridViewTextBoxColumn";
            this.nUMPOIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 502);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Search by date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "To:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(189, 527);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker2.TabIndex = 41;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 527);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 22);
            this.dateTimePicker1.TabIndex = 40;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ReceivingReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 566);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceivingReports";
            this.Text = "Receiving Reports";
            this.Load += new System.EventHandler(this.ReceivingReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       // private AccountPayableDataSet accountPayableDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label1;
       // private AccountsPayableDataSet1 accountsPayableDataSet1;
        private System.Windows.Forms.BindingSource tBLRECEIVINGREPORTBindingSource;
        //private AccountsPayableDataSet1TableAdapters.TBL_RECEIVING_REPORTTableAdapter tBL_RECEIVING_REPORTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private AccountsPayableDataSet accountsPayableDataSet;
        private System.Windows.Forms.BindingSource tBLRECEIVINGREPORTBindingSource1;
        private AccountsPayableDataSetTableAdapters.TBL_RECEIVING_REPORTTableAdapter tBL_RECEIVING_REPORTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMRRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTdeliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTcreateddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHRtermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHRnotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMPOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}