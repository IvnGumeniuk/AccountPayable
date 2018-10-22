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
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.tBLPURCHASEORDERBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.accountsPayableDataSet11 = new Account_Payable1.AccountsPayableDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.deliverydatelbl = new System.Windows.Forms.Label();
            this.tBLPURCHASEORDERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.createdatelbl = new System.Windows.Forms.Label();
            this.tBLPURCHASEORDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLPURCHASEORDERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.POIDtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.address3 = new System.Windows.Forms.Label();
            this.adress2 = new System.Windows.Forms.Label();
            this.adress1 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.employeetelelbl = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.employeeemaillbl = new System.Windows.Forms.Label();
            this.employeesurnamelbl = new System.Windows.Forms.Label();
            this.tBLVENDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeenamelbl = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.totallbl = new System.Windows.Forms.Label();
            this.tBLINVOICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBL_PURCHASE_ORDERTableAdapter = new Account_Payable1.AccountsPayableDataSet1TableAdapters.TBL_PURCHASE_ORDERTableAdapter();
            this.tBL_VENDORTableAdapter = new Account_Payable1.AccountsPayableDataSet1TableAdapters.TBL_VENDORTableAdapter();
            this.tBL_INVOICETableAdapter = new Account_Payable1.AccountsPayableDataSet1TableAdapters.TBL_INVOICETableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVENDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.usernamelbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addresslbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.deliverydatelbl);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.createdatelbl);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.POIDtxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(46, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 186);
            this.panel2.TabIndex = 27;
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLPURCHASEORDERBindingSource3, "POID", true));
            this.usernamelbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLPURCHASEORDERBindingSource3, "userID", true));
            this.usernamelbl.Location = new System.Drawing.Point(157, 159);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(97, 20);
            this.usernamelbl.TabIndex = 32;
            this.usernamelbl.Text = "usernameID";
            // 
            // tBLPURCHASEORDERBindingSource3
            // 
            this.tBLPURCHASEORDERBindingSource3.DataMember = "TBL_PURCHASE_ORDER";
            this.tBLPURCHASEORDERBindingSource3.DataSource = this.accountsPayableDataSet11;
            // 
            // accountsPayableDataSet11
            // 
            this.accountsPayableDataSet11.DataSetName = "AccountsPayableDataSet1";
            this.accountsPayableDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Created by:";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLPURCHASEORDERBindingSource3, "POID", true));
            this.addresslbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLPURCHASEORDERBindingSource3, "delivery_address", true));
            this.addresslbl.Location = new System.Drawing.Point(184, 135);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(66, 20);
            this.addresslbl.TabIndex = 30;
            this.addresslbl.Text = "address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Delivery Address:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLPURCHASEORDERBindingSource3, "POID", true));
            this.label17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLPURCHASEORDERBindingSource3, "notes", true));
            this.label17.Location = new System.Drawing.Point(104, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "notes";
            // 
            // deliverydatelbl
            // 
            this.deliverydatelbl.AutoSize = true;
            this.deliverydatelbl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLPURCHASEORDERBindingSource2, "POID", true));
            this.deliverydatelbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLPURCHASEORDERBindingSource3, "delivery_date", true));
            this.deliverydatelbl.Location = new System.Drawing.Point(189, 62);
            this.deliverydatelbl.Name = "deliverydatelbl";
            this.deliverydatelbl.Size = new System.Drawing.Size(75, 20);
            this.deliverydatelbl.TabIndex = 27;
            this.deliverydatelbl.Text = "dd/mm/yy";
            // 
            // tBLPURCHASEORDERBindingSource2
            // 
            this.tBLPURCHASEORDERBindingSource2.DataMember = "TBL_PURCHASE_ORDER";
            this.tBLPURCHASEORDERBindingSource2.DataSource = this.accountsPayableDataSet11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLPURCHASEORDERBindingSource2, "POID", true));
            this.label15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLPURCHASEORDERBindingSource2, "terms", true));
            this.label15.Location = new System.Drawing.Point(101, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "terms";
            // 
            // createdatelbl
            // 
            this.createdatelbl.AutoSize = true;
            this.createdatelbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLPURCHASEORDERBindingSource, "created_date", true));
            this.createdatelbl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLPURCHASEORDERBindingSource1, "POID", true));
            this.createdatelbl.Location = new System.Drawing.Point(157, 39);
            this.createdatelbl.Name = "createdatelbl";
            this.createdatelbl.Size = new System.Drawing.Size(75, 20);
            this.createdatelbl.TabIndex = 25;
            this.createdatelbl.Text = "dd/mm/yy";
            this.createdatelbl.Click += new System.EventHandler(this.createdatelbl_Click);
            // 
            // tBLPURCHASEORDERBindingSource
            // 
            this.tBLPURCHASEORDERBindingSource.DataMember = "TBL_PURCHASE_ORDER";
            this.tBLPURCHASEORDERBindingSource.DataSource = this.accountsPayableDataSet11;
            // 
            // tBLPURCHASEORDERBindingSource1
            // 
            this.tBLPURCHASEORDERBindingSource1.DataMember = "TBL_PURCHASE_ORDER";
            this.tBLPURCHASEORDERBindingSource1.DataSource = this.accountsPayableDataSet11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Notes:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Terms:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Delivery Due Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Created Date:";
            // 
            // POIDtxt
            // 
            this.POIDtxt.Enabled = false;
            this.POIDtxt.Location = new System.Drawing.Point(200, 6);
            this.POIDtxt.Name = "POIDtxt";
            this.POIDtxt.Size = new System.Drawing.Size(100, 26);
            this.POIDtxt.TabIndex = 20;
            this.POIDtxt.TextChanged += new System.EventHandler(this.POID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Purchase Order:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.address3);
            this.panel3.Controls.Add(this.adress2);
            this.panel3.Controls.Add(this.adress1);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.employeetelelbl);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.employeeemaillbl);
            this.panel3.Controls.Add(this.employeesurnamelbl);
            this.panel3.Controls.Add(this.employeenamelbl);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label37);
            this.panel3.Controls.Add(this.label39);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(739, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 186);
            this.panel3.TabIndex = 33;
            // 
            // address3
            // 
            this.address3.AutoSize = true;
            this.address3.Location = new System.Drawing.Point(101, 163);
            this.address3.Name = "address3";
            this.address3.Size = new System.Drawing.Size(66, 20);
            this.address3.TabIndex = 46;
            this.address3.Text = "address";
            // 
            // adress2
            // 
            this.adress2.AutoSize = true;
            this.adress2.Location = new System.Drawing.Point(101, 145);
            this.adress2.Name = "adress2";
            this.adress2.Size = new System.Drawing.Size(66, 20);
            this.adress2.TabIndex = 45;
            this.adress2.Text = "address";
            // 
            // adress1
            // 
            this.adress1.AutoSize = true;
            this.adress1.Location = new System.Drawing.Point(101, 127);
            this.adress1.Name = "adress1";
            this.adress1.Size = new System.Drawing.Size(66, 20);
            this.adress1.TabIndex = 44;
            this.adress1.Text = "address";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(15, 131);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 20);
            this.label30.TabIndex = 43;
            this.label30.Text = "Address:";
            // 
            // employeetelelbl
            // 
            this.employeetelelbl.AutoSize = true;
            this.employeetelelbl.Location = new System.Drawing.Point(124, 108);
            this.employeetelelbl.Name = "employeetelelbl";
            this.employeetelelbl.Size = new System.Drawing.Size(80, 20);
            this.employeetelelbl.TabIndex = 42;
            this.employeetelelbl.Text = "telephone";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(15, 109);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(103, 20);
            this.label32.TabIndex = 40;
            this.label32.Text = "Telephone: ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(15, 88);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 20);
            this.label33.TabIndex = 39;
            this.label33.Text = "Email:";
            // 
            // employeeemaillbl
            // 
            this.employeeemaillbl.AutoSize = true;
            this.employeeemaillbl.Location = new System.Drawing.Point(96, 88);
            this.employeeemaillbl.Name = "employeeemaillbl";
            this.employeeemaillbl.Size = new System.Drawing.Size(46, 20);
            this.employeeemaillbl.TabIndex = 41;
            this.employeeemaillbl.Text = "email";
            // 
            // employeesurnamelbl
            // 
            this.employeesurnamelbl.AutoSize = true;
            this.employeesurnamelbl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLVENDORBindingSource, "Vendor_ID", true));
            this.employeesurnamelbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLVENDORBindingSource, "surname", true));
            this.employeesurnamelbl.Location = new System.Drawing.Point(190, 61);
            this.employeesurnamelbl.Name = "employeesurnamelbl";
            this.employeesurnamelbl.Size = new System.Drawing.Size(71, 20);
            this.employeesurnamelbl.TabIndex = 38;
            this.employeesurnamelbl.Text = "surname";
            // 
            // tBLVENDORBindingSource
            // 
            this.tBLVENDORBindingSource.DataMember = "TBL_VENDOR";
            this.tBLVENDORBindingSource.DataSource = this.accountsPayableDataSet11;
            // 
            // employeenamelbl
            // 
            this.employeenamelbl.AutoSize = true;
            this.employeenamelbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLVENDORBindingSource, "firstname", true));
            this.employeenamelbl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLVENDORBindingSource, "Vendor_ID", true));
            this.employeenamelbl.Location = new System.Drawing.Point(170, 38);
            this.employeenamelbl.Name = "employeenamelbl";
            this.employeenamelbl.Size = new System.Drawing.Size(49, 20);
            this.employeenamelbl.TabIndex = 37;
            this.employeenamelbl.Text = "name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(15, 61);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(169, 20);
            this.label27.TabIndex = 36;
            this.label27.Text = "Employee Surname:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(15, 38);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(143, 20);
            this.label28.TabIndex = 35;
            this.label28.Text = "Employee Name:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(5, 7);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(34, 20);
            this.label37.TabIndex = 34;
            this.label37.Text = "To:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLVENDORBindingSource, "companyName", true));
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(45, 4);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(160, 25);
            this.label39.TabIndex = 33;
            this.label39.Text = "Vendor\'s Name";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLPURCHASEORDERBindingSource3, "vendorID", true));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLPURCHASEORDERBindingSource3, "POID", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(225, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Vendor ID";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tBLINVOICEBindingSource, "invoiceID", true));
            this.totallbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tBLINVOICEBindingSource, "Istatus", true));
            this.totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(56, 646);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(48, 25);
            this.totallbl.TabIndex = 35;
            this.totallbl.Text = "total";
            // 
            // tBLINVOICEBindingSource
            // 
            this.tBLINVOICEBindingSource.DataMember = "TBL_INVOICE";
            this.tBLINVOICEBindingSource.DataSource = this.accountsPayableDataSet11;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 405);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tBL_PURCHASE_ORDERTableAdapter
            // 
            this.tBL_PURCHASE_ORDERTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_VENDORTableAdapter
            // 
            this.tBL_VENDORTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_INVOICETableAdapter
            // 
            this.tBL_INVOICETableAdapter.ClearBeforeFill = true;
            // 
            // ViewPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 708);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPurchaseOrder";
            this.Text = "View Purchase Order";
            this.Load += new System.EventHandler(this.ViewPurchaseOrder_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsPayableDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPURCHASEORDERBindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBLVENDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLINVOICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AccountPayableDataSet accountPayableDataSet;
        //private AccountPayableDataSetTableAdapters.purchaseOrderTableAdapter purchaseOrderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHRNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label deliverydatelbl;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label createdatelbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox POIDtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label adress1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label employeetelelbl;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label employeeemaillbl;
        private System.Windows.Forms.Label employeesurnamelbl;
        private System.Windows.Forms.Label employeenamelbl;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.BindingSource accountsPayableDataSet1BindingSource;
        private AccountsPayableDataSet1 accountsPayableDataSet1;
        private System.Windows.Forms.BindingSource tBLPOITEMSBindingSource;
        private AccountsPayableDataSet1TableAdapters.TBL_PO_ITEMSTableAdapter tBL_PO_ITEMSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AccountsPayableDataSet1 accountsPayableDataSet11;
        private System.Windows.Forms.BindingSource tBLPURCHASEORDERBindingSource;
        private AccountsPayableDataSet1TableAdapters.TBL_PURCHASE_ORDERTableAdapter tBL_PURCHASE_ORDERTableAdapter;
        private System.Windows.Forms.BindingSource tBLPURCHASEORDERBindingSource1;
        private System.Windows.Forms.BindingSource tBLPURCHASEORDERBindingSource3;
        private System.Windows.Forms.BindingSource tBLPURCHASEORDERBindingSource2;
        private System.Windows.Forms.BindingSource tBLVENDORBindingSource;
        private AccountsPayableDataSet1TableAdapters.TBL_VENDORTableAdapter tBL_VENDORTableAdapter;
        private System.Windows.Forms.Label address3;
        private System.Windows.Forms.Label adress2;
        private System.Windows.Forms.BindingSource tBLINVOICEBindingSource;
        private AccountsPayableDataSet1TableAdapters.TBL_INVOICETableAdapter tBL_INVOICETableAdapter;
    }
}