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
    public partial class Invoices : Form
    {
        public static string invoice = "";
        public Invoices()
        {
            InitializeComponent();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet.TBL_INVOICE' table. You can move, or remove it, as needed.
            this.tBL_INVOICETableAdapter.Fill(this.accountsPayableDataSet.TBL_INVOICE);
            // TODO: This line of code loads data into the 'accountsPayableDataSet.TBL_INVOICE_ITEMS' table. You can move, or remove it, as needed.
            this.tBL_INVOICE_ITEMSTableAdapter.Fill(this.accountsPayableDataSet.TBL_INVOICE_ITEMS);
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_RECEIVING_REPORT' table. You can move, or remove it, as needed.
            // this.tBL_RECEIVING_REPORTTableAdapter.Fill(this.accountsPayableDataSet1.TBL_RECEIVING_REPORT);
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_PURCHASE_ORDER' table. You can move, or remove it, as needed.
            //this.tBL_PURCHASE_ORDERTableAdapter.Fill(this.accountsPayableDataSet1.TBL_PURCHASE_ORDER);
            // TODO: This line of code loads data into the 'accountsPayableDataSet2.TBL_INVOICE' table. You can move, or remove it, as needed.
            //this.tBL_INVOICETableAdapter.Fill(this.accountsPayableDataSet1.TBL_INVOICE);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                string invoice = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
                dataGridView2.Rows.RemoveAt(item.Index);

                con.Open();
                string query = "DELETE FROM TBL_INVOICE_ITEMS WHERE NUM_invoiceID= " + invoice + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = "DELETE FROM TBL_INVOICE WHERE NUM_invoiceID= " + invoice + ";";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string query = " SELECT * FROM TBL_INVOICE WHERE DT_created_date >= '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + " ' AND DT_created_date <= '" +
              dateTimePicker2.Value.Date.ToString("yyyyMMdd") + "';";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb2 = new DataTable();
            sda.Fill(dtb2);
            dataGridView2.DataSource = dtb2;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string query = " SELECT * FROM TBL_INVOICE WHERE DT_created_date >= '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + " ' AND DT_created_date <= '" +
              dateTimePicker2.Value.Date.ToString("yyyyMMdd") + "';";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb2 = new DataTable();
            sda.Fill(dtb2);
            dataGridView2.DataSource = dtb2;
        }

        ViewInvoice vi;

        void vi_FormClosed(object sender, FormClosedEventArgs e)
        {
            vi = null;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            invoice = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();

            if (vi == null)
            {
                vi = new ViewInvoice();
                vi.MdiParent = this.MdiParent;
                vi.FormClosed += new FormClosedEventHandler(vi_FormClosed);
                vi.Show();

                //this.Close();
            }
            else
            {
                vi.Activate();
                vi.FormClosed += new FormClosedEventHandler(vi_FormClosed);
                vi.Show();
            }
        }
    }
}
