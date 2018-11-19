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
    public partial class ReceivingReports : Form
    {
        public static string receivingReportId = "";

        public ReceivingReports()
        {
            InitializeComponent();
        }

        private void ReceivingReports_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'accountsPayableDataSet.TBL_RECEIVING_REPORT' table. You can move, or remove it, as needed.
            this.tBL_RECEIVING_REPORTTableAdapter.Fill(this.accountsPayableDataSet.TBL_RECEIVING_REPORT);
            // TODO: This line of code loads data into the 'accountsPayableDataSet2.TBL_RECEIVING_REPORT' table. You can move, or remove it, as needed.
            // this.tBL_RECEIVING_REPORTTableAdapter1.Fill(this.accountsPayableDataSet2.TBL_RECEIVING_REPORT);
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_RECEIVING_REPORT' table. You can move, or remove it, as needed.

        }

        ViewReceivingReport vrr;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            receivingReportId = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (vrr == null)
            {
                vrr = new ViewReceivingReport();
                vrr.MdiParent = this.MdiParent;
                vrr.FormClosed += new FormClosedEventHandler(vrr_FormClosed);
                vrr.Show();

                //this.Close();
            }
            else
            {
                vrr.Activate();
                vrr.FormClosed += new FormClosedEventHandler(vrr_FormClosed);
                vrr.Show();
            }
        }
        void vrr_FormClosed(object sender, FormClosedEventArgs e)
        {
            vrr = null;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string query = " SELECT * FROM TBL_RECEIVING_REPORT WHERE DT_created_date >= '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + " ' AND DT_created_date <= '" +
              dateTimePicker2.Value.Date.ToString("yyyyMMdd") + "';";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb2 = new DataTable();
            sda.Fill(dtb2);
            dataGridView1.DataSource = dtb2;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string query = " SELECT * FROM TBL_RECEIVING_REPORT WHERE DT_created_date >= '" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + " ' AND DT_created_date <= '" +
                 dateTimePicker2.Value.Date.ToString("yyyyMMdd") + "';";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb2 = new DataTable();
            sda.Fill(dtb2);
            dataGridView1.DataSource = dtb2;
        }
    }
}
