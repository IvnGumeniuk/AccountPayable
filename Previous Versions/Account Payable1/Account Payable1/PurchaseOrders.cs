using System;
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
    public partial class PurchaseOrders : Form
    {
        public static string purchaseOrder="";
        public PurchaseOrders()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet.TBL_PURCHASE_ORDER' table. You can move, or remove it, as needed.
            this.tBL_PURCHASE_ORDERTableAdapter.Fill(this.accountsPayableDataSet.TBL_PURCHASE_ORDER);
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_PURCHASE_ORDER' table. You can move, or remove it, as needed.
            //  this.tBL_PURCHASE_ORDERTableAdapter.Fill(this.accountsPayableDataSet1.TBL_PURCHASE_ORDER);




        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                string POID = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
                dataGridView2.Rows.RemoveAt(item.Index);

                con.Open();
                string query = "DELETE FROM TBL_PO_ITEMS WHERE NUM_POID= " + POID + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = "DELETE FROM TBL_PURCHASE_ORDER WHERE NUM_POID= " + POID + ";";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ViewPurchaseOrder vpo;
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchaseOrders.purchaseOrder = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            if (vpo == null)
            {
                vpo = new ViewPurchaseOrder();
                vpo.MdiParent = this.MdiParent;
                vpo.FormClosed += new FormClosedEventHandler(vpo_FormClosed);
                vpo.Show();
                //this.Close();
            }
            else
            {
                vpo.Activate();
                vpo.FormClosed += new FormClosedEventHandler(vpo_FormClosed);
                vpo.Show();
            }
        }
        void vpo_FormClosed(object sender, FormClosedEventArgs e)
        {
            vpo = null;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string query = " SELECT * FROM TBL_PURCHASE_ORDER WHERE DT_created_date >= '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + " ' AND DT_created_date <= '" +
                dateTimePicker2.Value.Date.ToString("yyyyMMdd") + "';";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb2 = new DataTable();
            sda.Fill(dtb2);
            dataGridView2.DataSource = dtb2;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string query = " SELECT * FROM TBL_PURCHASE_ORDER WHERE DT_created_date >= '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + " ' AND DT_created_date <= '" +
               dateTimePicker2.Value.Date.ToString("yyyyMMdd") + "';";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb2 = new DataTable();
            sda.Fill(dtb2);
            dataGridView2.DataSource = dtb2;
        }
    }
}
