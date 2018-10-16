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
    public partial class ViewInvoice : Form
    {
        public ViewInvoice()
        {
            InitializeComponent();
        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_INVOICE' table. You can move, or remove it, as needed.
            this.tBL_INVOICETableAdapter.Fill(this.accountsPayableDataSet1.TBL_INVOICE);

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

            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            totallbl.Text = "€ " + sum.ToString();
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
        public int invoiceID; // = Convert.ToInt32(invoicetxt.Text.Trim());
        private void approvecmd_Click(object sender, EventArgs e)
        {
            invoiceApproval invapp = new invoiceApproval();
            invapp.Show();
           
            
            invoiceID = Convert.ToInt32(invoicetxt.Text.Trim());

        }
    }
}
