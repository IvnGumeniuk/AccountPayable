using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Account_Payable1
{

    public partial class SearchVendor : Form
    {
        //public static string vendorname = "";
        public SearchVendor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = " SELECT Vendor_ID, companyName, companyType, phone, email, country, city, address_ FROM TBL_VENDOR WHERE (" +
                "Vendor_ID LIKE '%{0}%'" + searchV.Text.Trim() + " OR Vendor_ID LIKE '%{0}%')" + searchV.Text.Trim();


            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "[companyName] Like '%" + searchV.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void SearchVendor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_VENDOR' table. You can move, or remove it, as needed.
            this.tBL_VENDORTableAdapter.Fill(this.accountsPayableDataSet1.TBL_VENDOR);
            if (CreatePurchaseOrder.opened == 1)
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }

        }

        private void searchVendor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        CreatePurchaseOrder cpo;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (CreatePurchaseOrder.opened ==1 )
            {
                CreatePurchaseOrder.vendorname = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }




        //frm2.Activated += new EventHandler(frm2_Activated);
        //this.searchVendor_FormClosed += new FormClosedEventHandler(searchVendor_FormClosed);
        //setVendor();


        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        CreateNewVendor cnv;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cnv == null)
            {
                cnv = new CreateNewVendor();
                cnv.MdiParent = this.MdiParent;
                cnv.FormClosed += new FormClosedEventHandler(cnv_FormClosed);
                cnv.Show();
                //this.Close();
            }
            else
            {
                cnv.Activate();
                cnv.FormClosed += new FormClosedEventHandler(cnv_FormClosed);
                cnv.Show();
            }
            this.Close();


        }
        void cnv_FormClosed(object sender, FormClosedEventArgs e)
        {
            cnv = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                string vendorid = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                dataGridView1.Rows.RemoveAt(item.Index);

                con.Open();
                string query = "DELETE FROM TBL_VENDOR WHERE Vendor_ID= " + vendorid + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = "DELETE FROM TBL_INVOICE WHERE invoiceID= " + vendorid + ";";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }
    }
 }


