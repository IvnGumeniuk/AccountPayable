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
        public ReceivingReports()
        {
            InitializeComponent();
        }

        private void ReceivingReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet.TBL_RECEIVING_REPORT' table. You can move, or remove it, as needed.
            this.tBL_RECEIVING_REPORTTableAdapter1.Fill(this.accountsPayableDataSet.TBL_RECEIVING_REPORT);
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_RECEIVING_REPORT' table. You can move, or remove it, as needed.
            this.tBL_RECEIVING_REPORTTableAdapter.Fill(this.accountsPayableDataSet1.TBL_RECEIVING_REPORT);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F1MP1PB;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=***********");
            DataTable dt = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM AccountPayable where PRID like" + txt_id.Text, conn);
            SDA.Fill(dt);
            dataGridView1.DataSource = dt; 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
