namespace Account_Payable1
{
    partial class Invoices
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tBLINVOICEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.accountsPayableDataSet = new Account_Payable1.AccountsPayableDataSet();
            this.tBLINVOICEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLRECEIVINGREPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLINVOICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBLINVOICEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBLPURCHASEORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLINVOICEITEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_INVOICE_ITEMSTableAdapter = new Account_Payable1.AccountsPayableDataSetTableAdapters.TBL_INVOICE_ITEMSTableAdapter();
            this.tBL_INVOICETableAdapter = new Account_Payable1.AccountsPayableDataSetTableAdapters.TBL_INVOICETableAdapter();
            this.nUMinvoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMvendorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTdiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTduedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEITEMSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Invoices:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMinvoiceIDDataGridViewTextBoxColumn,
            this.nUMvendorIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.fTdiscountDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dTduedateDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.tBLINVOICEBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(16, 48);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(884, 346);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // tBLINVOICEBindingSource3
            // 
            this.tBLINVOICEBindingSource3.DataMember = "TBL_INVOICE";
            this.tBLINVOICEBindingSource3.DataSource = this.accountsPayableDataSet;
            // 
            // accountsPayableDataSet
            // 
            this.accountsPayableDataSet.DataSetName = "AccountsPayableDataSet";
            this.accountsPayableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLINVOICEBindingSource2
            // 
            this.tBLINVOICEBindingSource2.DataMember = "TBL_INVOICE";
            this.tBLINVOICEBindingSource2.DataSource = this.accountsPayableDataSet;
            // 
            // tBLRECEIVINGREPORTBindingSource
            // 
            this.tBLRECEIVINGREPORTBindingSource.DataMember = "TBL_RECEIVING_REPORT";
            // 
            // tBLINVOICEBindingSource
            // 
            this.tBLINVOICEBindingSource.DataMember = "TBL_INVOICE";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(780, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 30);
            this.button3.TabIndex = 30;
            this.button3.Tag = "";
            this.button3.Text = "Delete item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "To:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(238, 426);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker2.TabIndex = 37;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 425);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 22);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Search by date:";
            // 
            // tBLINVOICEBindingSource1
            // 
            this.tBLINVOICEBindingSource1.DataMember = "TBL_INVOICE";
            // 
            // tBLPURCHASEORDERBindingSource
            // 
            this.tBLPURCHASEORDERBindingSource.DataMember = "TBL_PURCHASE_ORDER";
            // 
            // tBLINVOICEITEMSBindingSource
            // 
            this.tBLINVOICEITEMSBindingSource.DataMember = "TBL_INVOICE_ITEMS";
            this.tBLINVOICEITEMSBindingSource.DataSource = this.accountsPayableDataSet;
            // 
            // tBL_INVOICE_ITEMSTableAdapter
            // 
            this.tBL_INVOICE_ITEMSTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_INVOICETableAdapter
            // 
            this.tBL_INVOICETableAdapter.ClearBeforeFill = true;
            // 
            // nUMinvoiceIDDataGridViewTextBoxColumn
            // 
            this.nUMinvoiceIDDataGridViewTextBoxColumn.DataPropertyName = "NUM_invoiceID";
            this.nUMinvoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
            this.nUMinvoiceIDDataGridViewTextBoxColumn.Name = "nUMinvoiceIDDataGridViewTextBoxColumn";
            this.nUMinvoiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMvendorIDDataGridViewTextBoxColumn
            // 
            this.nUMvendorIDDataGridViewTextBoxColumn.DataPropertyName = "NUM_vendorID";
            this.nUMvendorIDDataGridViewTextBoxColumn.HeaderText = "Vendor";
            this.nUMvendorIDDataGridViewTextBoxColumn.Name = "nUMvendorIDDataGridViewTextBoxColumn";
            this.nUMvendorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FT_total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // fTdiscountDataGridViewTextBoxColumn
            // 
            this.fTdiscountDataGridViewTextBoxColumn.DataPropertyName = "FT_discount";
            this.fTdiscountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.fTdiscountDataGridViewTextBoxColumn.Name = "fTdiscountDataGridViewTextBoxColumn";
            this.fTdiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DT_created_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Created Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dTduedateDataGridViewTextBoxColumn
            // 
            this.dTduedateDataGridViewTextBoxColumn.DataPropertyName = "DT_due_date";
            this.dTduedateDataGridViewTextBoxColumn.HeaderText = "Due Date";
            this.dTduedateDataGridViewTextBoxColumn.Name = "dTduedateDataGridViewTextBoxColumn";
            this.dTduedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NUM_POID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Purchase Order";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEITEMSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        //private AccountsPayableDataSet1 accountsPayableDataSet1;
        private System.Windows.Forms.BindingSource tBLINVOICEBindingSource;
       // private AccountsPayableDataSet1TableAdapters.TBL_INVOICETableAdapter tBL_INVOICETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMPOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTcreateddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBLINVOICEBindingSource1;
        private System.Windows.Forms.BindingSource tBLPURCHASEORDERBindingSource;
       // private AccountsPayableDataSet1TableAdapters.TBL_PURCHASE_ORDERTableAdapter tBL_PURCHASE_ORDERTableAdapter;
        private System.Windows.Forms.BindingSource tBLRECEIVINGREPORTBindingSource;
        private AccountsPayableDataSet accountsPayableDataSet;
        private System.Windows.Forms.BindingSource tBLINVOICEITEMSBindingSource;
        private AccountsPayableDataSetTableAdapters.TBL_INVOICE_ITEMSTableAdapter tBL_INVOICE_ITEMSTableAdapter;
        private System.Windows.Forms.BindingSource tBLINVOICEBindingSource2;
        private AccountsPayableDataSetTableAdapters.TBL_INVOICETableAdapter tBL_INVOICETableAdapter;
        private System.Windows.Forms.BindingSource tBLINVOICEBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMinvoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMvendorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTdiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTduedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        // private AccountsPayableDataSet1TableAdapters.TBL_RECEIVING_REPORTTableAdapter tBL_RECEIVING_REPORTTableAdapter;
    }
}