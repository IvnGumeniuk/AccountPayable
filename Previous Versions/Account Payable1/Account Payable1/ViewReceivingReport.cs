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
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_RECEIVED_ITEMS' table. You can move, or remove it, as needed.
            // this.TBL_RECEIVED_ITEMSTableAdapter.Fill(this.accountsPayableDataSet1.TBL_RECEIVED_ITEMS);

            RRIDtxt.Text = ReceivingReports.receivingReportId;

            String query = "SELECT * FROM TBL_RECEIVING_REPORT INNER JOIN TBL_PURCHASE_ORDER ON TBL_RECEIVING_REPORT.NUM_POID=TBL_PURCHASE_ORDER.NUM_POID INNER JOIN TBL_VENDOR ON TBL_PURCHASE_ORDER.NUM_VendorID=TBL_VENDOR.NUM_Vendor_ID WHERE NUM_RRID = " + RRIDtxt.Text.Trim() + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            String vendorId = Convert.ToString(dtbl.Rows[0][19]); vendortxt.Text = vendorId;
            String vendor = Convert.ToString(dtbl.Rows[0][22]); label39.Text = vendor;
            String firstname = Convert.ToString(dtbl.Rows[0][27]); lblname.Text = firstname;
            String surname = Convert.ToString(dtbl.Rows[0][28]); lblsurname.Text = surname;
            String email = Convert.ToString(dtbl.Rows[0][29]); lblemail.Text = email;
            String phone = Convert.ToString(dtbl.Rows[0][20]); lblphone.Text = phone;
            String address = Convert.ToString(dtbl.Rows[0][21]); lbladdress.Text = address;
            String city = Convert.ToString(dtbl.Rows[0][25]); lblcity.Text = city;
            String country = Convert.ToString(dtbl.Rows[0][24]); lblcountry.Text = country;

            query = "SELECT * FROM TBL_RECEIVING_REPORT WHERE NUM_RRID = " + RRIDtxt.Text.Trim() + ";";
            SqlDataAdapter sda3 = new SqlDataAdapter(query, con);
            DataTable dtbl3 = new DataTable();
            sda3.Fill(dtbl3);
            string total = Convert.ToString(dtbl3.Rows[0][6]); // totaltxt.Text = total;
            string created = Convert.ToString(dtbl3.Rows[0][2]); createtxt.Text = created;
            string delivery = Convert.ToString(dtbl3.Rows[0][1]); deliverytxt.Text = delivery;
            string notes = Convert.ToString(dtbl3.Rows[0][5]); notestxt.Text = notes;
            string terms = Convert.ToString(dtbl3.Rows[0][3]); termstxt.Text = terms;


        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void RRIDtxt_TextChanged(object sender, EventArgs e)
        {
            string query = " SELECT TBL_RECEIVED_ITEMS.NUM_itemID, TBL_RECEIVED_ITEMS.NUM_quantity, TBL_SC_ITEMS.CHR_item_name, TBL_SC_ITEMS.FT_price " +
"FROM TBL_RECEIVED_ITEMS INNER JOIN TBL_SC_ITEMS ON TBL_RECEIVED_ITEMS.NUM_itemID = TBL_SC_ITEMS.NUM_itemID WHERE TBL_RECEIVED_ITEMS.NUM_RRID = '"
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
            totaltxt.Text = "€ " + sum.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(RRIDtxt.Text.Trim());
            num = num - 1;
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
    }
}
