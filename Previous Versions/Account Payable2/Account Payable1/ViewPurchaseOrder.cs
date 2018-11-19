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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void ViewPurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet11.TBL_INVOICE' table. You can move, or remove it, as needed.
            this.tBL_INVOICETableAdapter.Fill(this.accountsPayableDataSet11.TBL_INVOICE);
            // TODO: This line of code loads data into the 'accountsPayableDataSet11.TBL_VENDOR' table. You can move, or remove it, as needed.
            this.tBL_VENDORTableAdapter.Fill(this.accountsPayableDataSet11.TBL_VENDOR);
            // TODO: This line of code loads data into the 'accountsPayableDataSet11.TBL_PURCHASE_ORDER' table. You can move, or remove it, as needed.
            this.tBL_PURCHASE_ORDERTableAdapter.Fill(this.accountsPayableDataSet11.TBL_PURCHASE_ORDER);
            POIDtxt.Text=PurchaseOrders.purchaseOrder;
            String query = "SELECT vendorid FROM TBL_PURCHASE_ORDER WHERE POID = " + POIDtxt.Text.Trim() + ";";
            SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
            DataTable dtbl2 = new DataTable();
            sda1.Fill(dtbl2);
            textBox1.Text = Convert.ToString(dtbl2.Rows[0][0]);

            query = "SELECT * FROM TBL_VENDOR INNER JOIN TBL_PURCHASE_ORDER ON Vendor_ID=vendorid WHERE POID = " + POIDtxt.Text.Trim() + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count != 0 )
            {
                string vendor = Convert.ToString(dtbl.Rows[0][3]); label39.Text = vendor;
                string firstname = Convert.ToString(dtbl.Rows[0][8]); employeenamelbl.Text = firstname;
                string surname = Convert.ToString(dtbl.Rows[0][9]); employeesurnamelbl.Text = surname;
                string email = Convert.ToString(dtbl.Rows[0][10]); employeeemaillbl.Text = email;
                string phone = Convert.ToString(dtbl.Rows[0][1]); employeetelelbl.Text = phone;
                string address = Convert.ToString(dtbl.Rows[0][2]); address3.Text = address;
                string city = Convert.ToString(dtbl.Rows[0][6]); adress2.Text = city;
                string country = Convert.ToString(dtbl.Rows[0][5]); adress1.Text = country;
            }

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

       
        private void POID_TextChanged(object sender, EventArgs e)
        {
            string query = " SELECT TBL_PO_ITEMS.itemID, TBL_PO_ITEMS.quantity, TBL_SC_ITEMS.item_name, TBL_SC_ITEMS.price " +
"FROM TBL_PO_ITEMS INNER JOIN TBL_SC_ITEMS ON TBL_PO_ITEMS.itemID = TBL_SC_ITEMS.itemID WHERE TBL_PO_ITEMS.POID = '"
+ POIDtxt.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

            
        }

       

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tBL_VENDORTableAdapter.FillBy(this.accountsPayableDataSet11.TBL_VENDOR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
