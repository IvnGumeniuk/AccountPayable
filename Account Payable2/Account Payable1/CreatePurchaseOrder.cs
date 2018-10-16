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
    public partial class CreatePurchaseOrder : Form
    {
        public CreatePurchaseOrder()
        {
            autoCompleteText();
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void CreatePurchaseOrder_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void CreatePurchaseOrder_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void autoCompleteText()
        {
           /* searchtxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchtxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
            string query = "SELECT companyName From TBL_VENDOR GROUP BY Vendor_ID;";
            SqlCommand cmdDatabase = new SqlCommand(query, con); 
            SqlDataReader myreader;

            con.Open();
            myreader = cmdDatabase.ExecuteReader();
            while (myreader.Read())
            {
                string company = myreader.GetString(8);
                coll.Add(company);
            }
            searchtxt.AutoCompleteCustomSource = coll; */
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           /* DataView DV = new DataView();
            DV.RowFilter = string.Format("companyName LIKE '%{0}%'" + searchtxt.Text.Trim());
            DataGrid dataGrid = new DataGrid();
            dataGrid.DataSource = DV;*/
        }
    }
}
