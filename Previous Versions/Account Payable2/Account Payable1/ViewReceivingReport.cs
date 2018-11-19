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
    public partial class ViewReceivingReport : Form
    {
        public ViewReceivingReport()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewReceivingReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet.TBL_RECEIVING_REPORT' table. You can move, or remove it, as needed.
            this.tBL_RECEIVING_REPORTTableAdapter.Fill(this.accountsPayableDataSet.TBL_RECEIVING_REPORT);
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_RECEIVED_ITEMS' table. You can move, or remove it, as needed.
            // this.TBL_RECEIVED_ITEMSTableAdapter.Fill(this.accountsPayableDataSet1.TBL_RECEIVED_ITEMS);

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void RRIDtxt_TextChanged(object sender, EventArgs e)
        {
            string query = " SELECT TBL_RECEIVED_ITEMS.itemID, TBL_RECEIVED_ITEMS.quantity, TBL_SC_ITEMS.item_name, TBL_SC_ITEMS.price " +
"FROM TBL_RECEIVED_ITEMS INNER JOIN TBL_SC_ITEMS ON TBL_RECEIVED_ITEMS.itemID = TBL_SC_ITEMS.itemID WHERE TBL_RECEIVED_ITEMS.RRID = '" 
+ RRIDtxt.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            totallbl.Text = "€ "+ sum.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(RRIDtxt.Text.Trim());
            num=num - 1;
            RRIDtxt.Text = num.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(RRIDtxt.Text.Trim());
            num = num + 1;
            RRIDtxt.Text = num.ToString();
        }

        private void ViewReceivingReport_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(false);
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(false);
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(true);
            dataGridView1.Rows.Add(true);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
