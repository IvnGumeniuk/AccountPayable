﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Account_Payable1
{
    public partial class ViewInvoice : Form
    {
        public static string invoiceid = "";
        public ViewInvoice()
        {
            InitializeComponent();
        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_INVOICE' table. You can move, or remove it, as needed.
            this.tBL_INVOICETableAdapter.Fill(this.accountsPayableDataSet1.TBL_INVOICE);
            invoicetxt.Text = Invoices.invoice;
            String query = "SELECT vendorID FROM TBL_INVOICE WHERE invoiceID = " + invoicetxt.Text.Trim() + ";";
            SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
            DataTable dtbl2 = new DataTable();
            sda1.Fill(dtbl2);
            textBox1.Text = Convert.ToString(dtbl2.Rows[0][0]);

            query = "SELECT * FROM TBL_VENDOR INNER JOIN TBL_INVOICE ON vendorID=Vendor_ID WHERE invoiceID = " + invoicetxt.Text.Trim() + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            string vendor = Convert.ToString(dtbl.Rows[0][3]); label39.Text = vendor;
            string firstname = Convert.ToString(dtbl.Rows[0][8]); lblname.Text = firstname;
            string surname = Convert.ToString(dtbl.Rows[0][9]); lblsurname.Text = surname;
            string email = Convert.ToString(dtbl.Rows[0][10]); lblemail.Text = email;
            string phone = Convert.ToString(dtbl.Rows[0][1]); lblphone.Text = phone;
            string address = Convert.ToString(dtbl.Rows[0][2]); lbladdress.Text = address;
            string city = Convert.ToString(dtbl.Rows[0][6]); lblcity.Text = city;
            string country = Convert.ToString(dtbl.Rows[0][5]); lblcountry.Text = country;

            query = "SELECT * FROM TBL_INVOICE WHERE invoiceID = " + invoicetxt.Text.Trim() + ";";
            SqlDataAdapter sda3 = new SqlDataAdapter(query, con);
            DataTable dtbl3 = new DataTable();
            sda3.Fill(dtbl3);
            string total = Convert.ToString(dtbl3.Rows[0][6]); lbltotal.Text = total;
            string created = Convert.ToString(dtbl3.Rows[0][2]); lblcreated.Text = created;
            string pay = Convert.ToString(dtbl3.Rows[0][3]); lblpay.Text = pay;
            string notes = Convert.ToString(dtbl3.Rows[0][4]); lblnotes.Text = notes;
            string poid = Convert.ToString(dtbl3.Rows[0][1]); lblpoid.Text = poid;

            query = "SELECT Istatus FROM TBL_INVOICE WHERE invoiceID = " + invoicetxt.Text.Trim() + ";";
            sda1 = new SqlDataAdapter(query, con);
            dtbl2 = new DataTable();
            sda1.Fill(dtbl2);
            if (Convert.ToString(dtbl2.Rows[0][0]) == "1")
            {
                radioButton1.Checked = true;
                radioButton1.Enabled = true;
                radioButton1.ForeColor = Color.Green;
                radioButton2.Enabled = false;
                approvecmd.Enabled = false;
            }
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string query = " SELECT TBL_INVOICE_ITEMS.itemID, TBL_INVOICE_ITEMS.quantity, TBL_SC_ITEMS.item_name, TBL_SC_ITEMS.price " +
"FROM TBL_INVOICE_ITEMS INNER JOIN TBL_SC_ITEMS ON TBL_INVOICE_ITEMS.itemID = TBL_SC_ITEMS.itemID WHERE TBL_INVOICE_ITEMS.invoiceID = '"
+ invoicetxt.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;


            
        }

        private void ViewInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(invoicetxt.Text.Trim());
            num = num + 1;
            invoicetxt.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(invoicetxt.Text.Trim());
            num = num - 1;
            invoicetxt.Text = num.ToString();
          
            

        }

        invoiceApproval ia;
        private void approvecmd_Click(object sender, EventArgs e)
        {
           

            invoiceid = Convert.ToString(invoicetxt.Text.Trim());
            
            if (ia == null)
            {
                ia = new invoiceApproval();
                ia.MdiParent = this.MdiParent;
                ia.FormClosed += new FormClosedEventHandler(ia_FormClosed);
                ia.Show();
                //this.Close();
            }
            else
            {
                ia.Activate();
                ia.FormClosed += new FormClosedEventHandler(ia_FormClosed);
                ia.Show();
            }
        }

        void ia_FormClosed(object sender, FormClosedEventArgs e)
        {
            ia = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
