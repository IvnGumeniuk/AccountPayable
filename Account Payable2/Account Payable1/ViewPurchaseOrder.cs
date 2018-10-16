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
    public partial class ViewPurchaseOrder : Form
    {
        public ViewPurchaseOrder()
        {
            InitializeComponent();
        }

        private void ViewPurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_PO_ITEMS' table. You can move, or remove it, as needed.
            //this.tBL_PO_ITEMSTableAdapter.Fill(this.accountsPayableDataSet1.TBL_PO_ITEMS);
            // TODO: This line of code loads data into the 'accountPayableDataSet.purchaseOrder' table. You can move, or remove it, as needed.
            //  this.purchaseOrderTableAdapter.Fill(this.accountPayableDataSet.purchaseOrder);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tBL_PO_ITEMSTableAdapter.FillBy(this.accountsPayableDataSet1.TBL_PO_ITEMS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void createdatelbl_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void POID_TextChanged(object sender, EventArgs e)
        {
            string query = " SELECT TBL_PO_ITEMS.itemID, TBL_PO_ITEMS.quantity, TBL_SC_ITEMS.item_name, TBL_SC_ITEMS.price " +
"FROM TBL_PO_ITEMS INNER JOIN TBL_SC_ITEMS ON TBL_PO_ITEMS.itemID = TBL_SC_ITEMS.itemID WHERE TBL_PO_ITEMS.POID = '"
+ POID.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            totallbl.Text = "€ " + sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(POID.Text.Trim());
            num = num + 1;
            POID.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(POID.Text.Trim());
            num = num - 1;
            POID.Text = num.ToString();
        }
    }
}
