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
            this.tBLRECEIVINGREPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsPayableDataSet1 = new Account_Payable1.AccountsPayableDataSet1();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.button1 = new System.Windows.Forms.Button();
            this.tBL_RECEIVING_REPORTTableAdapter = new Account_Payable1.AccountsPayableDataSet1TableAdapters.TBL_RECEIVING_REPORTTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountsPayableDataSet = new Account_Payable1.AccountsPayableDataSet();
            this.tBLRECEIVINGREPORTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_RECEIVING_REPORTTableAdapter1 = new Account_Payable1.AccountsPayableDataSetTableAdapters.TBL_RECEIVING_REPORTTableAdapter();
            this.rRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.accountPayableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountPayableDataSet1
            // 
            this.accountPayableDataSet1.DataSetName = "AccountPayableDataSet";
            this.accountPayableDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 507);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tBL_RECEIVING_REPORTTableAdapter
            // 
            this.tBL_RECEIVING_REPORTTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Reports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search by ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(168, 74);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(211, 22);
            this.txt_id.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(398, 69);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 33);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(488, 69);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(113, 33);
            this.btn_display.TabIndex = 7;
            this.btn_display.Text = "Display All";
            this.btn_display.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rRIDDataGridViewTextBoxColumn,
            this.deliverydateDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.termsDataGridViewTextBoxColumn,
            this.pOIDDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLRECEIVINGREPORTBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(36, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 263);
            this.dataGridView1.TabIndex = 8;
            // 
            // accountsPayableDataSet
            // 
            this.accountsPayableDataSet.DataSetName = "AccountsPayableDataSet";
            this.accountsPayableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLRECEIVINGREPORTBindingSource1
            // 
            this.tBLRECEIVINGREPORTBindingSource1.DataMember = "TBL_RECEIVING_REPORT";
            this.tBLRECEIVINGREPORTBindingSource1.DataSource = this.accountsPayableDataSet;
            // 
            // tBL_RECEIVING_REPORTTableAdapter1
            // 
            this.tBL_RECEIVING_REPORTTableAdapter1.ClearBeforeFill = true;
            // 
            // rRIDDataGridViewTextBoxColumn
            // 
            this.rRIDDataGridViewTextBoxColumn.DataPropertyName = "RRID";
            this.rRIDDataGridViewTextBoxColumn.HeaderText = "RRID";
            this.rRIDDataGridViewTextBoxColumn.Name = "rRIDDataGridViewTextBoxColumn";
            // 
            // deliverydateDataGridViewTextBoxColumn
            // 
            this.deliverydateDataGridViewTextBoxColumn.DataPropertyName = "delivery_date";
            this.deliverydateDataGridViewTextBoxColumn.HeaderText = "delivery_date";
            this.deliverydateDataGridViewTextBoxColumn.Name = "deliverydateDataGridViewTextBoxColumn";
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "created_date";
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            // 
            // termsDataGridViewTextBoxColumn
            // 
            this.termsDataGridViewTextBoxColumn.DataPropertyName = "terms";
            this.termsDataGridViewTextBoxColumn.HeaderText = "terms";
            this.termsDataGridViewTextBoxColumn.Name = "termsDataGridViewTextBoxColumn";
            // 
            // pOIDDataGridViewTextBoxColumn
            // 
            this.pOIDDataGridViewTextBoxColumn.DataPropertyName = "POID";
            this.pOIDDataGridViewTextBoxColumn.HeaderText = "POID";
            this.pOIDDataGridViewTextBoxColumn.Name = "pOIDDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "From Date: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "To Date: ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(456, 127);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // ReceivingReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 569);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceivingReports";
            this.Text = "Receiving Reports";
            this.Load += new System.EventHandler(this.ReceivingReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountPayableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AccountPayableDataSet accountPayableDataSet1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button button1;
        private AccountsPayableDataSet1 accountsPayableDataSet1;
        private System.Windows.Forms.BindingSource tBLRECEIVINGREPORTBindingSource;
        private AccountsPayableDataSet1TableAdapters.TBL_RECEIVING_REPORTTableAdapter tBL_RECEIVING_REPORTTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_display;
        private AccountsPayableDataSet accountsPayableDataSet;
        private System.Windows.Forms.BindingSource tBLRECEIVINGREPORTBindingSource1;
        private AccountsPayableDataSetTableAdapters.TBL_RECEIVING_REPORTTableAdapter tBL_RECEIVING_REPORTTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
    }
}