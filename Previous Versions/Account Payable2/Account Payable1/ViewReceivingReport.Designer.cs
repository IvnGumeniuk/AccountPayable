namespace Account_Payable1
{
    partial class ViewReceivingReport
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
            this.totallbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.accountsPayableDataSet = new Account_Payable1.AccountsPayableDataSet();
            this.tBLRECEIVINGREPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_RECEIVING_REPORTTableAdapter = new Account_Payable1.AccountsPayableDataSetTableAdapters.TBL_RECEIVING_REPORTTableAdapter();
            this.rRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totallbl
            // 
            this.totallbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totallbl.AutoSize = true;
            this.totallbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(895, 654);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(79, 25);
            this.totallbl.TabIndex = 19;
            this.totallbl.Text = "TOTAL";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 738);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 66);
            this.button1.TabIndex = 20;
            this.button1.Text = "Create Purchase Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 744);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 54);
            this.button2.TabIndex = 21;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(251, 654);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 54);
            this.button3.TabIndex = 22;
            this.button3.Text = "Previous";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(366, 654);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 54);
            this.button4.TabIndex = 23;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.totalDataGridViewTextBoxColumn,
            this.cb1,
            this.sb});
            this.dataGridView1.DataSource = this.tBLRECEIVINGREPORTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 58);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // accountsPayableDataSet
            // 
            this.accountsPayableDataSet.DataSetName = "AccountsPayableDataSet";
            this.accountsPayableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLRECEIVINGREPORTBindingSource
            // 
            this.tBLRECEIVINGREPORTBindingSource.DataMember = "TBL_RECEIVING_REPORT";
            this.tBLRECEIVINGREPORTBindingSource.DataSource = this.accountsPayableDataSet;
            // 
            // tBL_RECEIVING_REPORTTableAdapter
            // 
            this.tBL_RECEIVING_REPORTTableAdapter.ClearBeforeFill = true;
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
            // cb1
            // 
            this.cb1.HeaderText = "CheckBox ";
            this.cb1.Name = "cb1";
            // 
            // sb
            // 
            this.sb.HeaderText = "Status";
            this.sb.Name = "sb";
            // 
            // ViewReceivingReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1066, 810);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totallbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewReceivingReport";
            this.Text = "View Receiving Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewReceivingReport_FormClosing);
            this.Load += new System.EventHandler(this.ViewReceivingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLRECEIVINGREPORTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AccountsPayableDataSet accountsPayableDataSet;
        private System.Windows.Forms.BindingSource tBLRECEIVINGREPORTBindingSource;
        private AccountsPayableDataSetTableAdapters.TBL_RECEIVING_REPORTTableAdapter tBL_RECEIVING_REPORTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sb;
    }
}