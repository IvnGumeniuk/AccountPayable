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
    public partial class CreateNewVendor : Form
    {
        public CreateNewVendor()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");

        private void CreateNewVendor_Load(object sender, EventArgs e)
        {
            String query = "SELECT Vendor_ID FROM TBL_VENDOR";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl != null)
            {
                int poid = Convert.ToInt32(dtbl.Rows[dtbl.Rows.Count - 1][0]) + 1;
                vendorIDtxt.Text = Convert.ToString(poid);
            }
            else
                vendorIDtxt.Text = Convert.ToString(1000);
        }
        SearchVendor SV;
        private void button1_Click(object sender, EventArgs e)
        {
            if(vendorIDtxt.Text != "" && phonetxt.Text != "" && addresstxt.Text != "" && citytxt.Text != "" && countrytxt.Text != "" && phonetxt.Text != "" &&
                companytxt.Text != "" && typetxt.Text != "" && titletxt.Text != "" && firstnametxt.Text != "" && surnametxt.Text != "" && emailtxt.Text != "")
            {
                
                con.Open();

                 string query = "INSERT TBL_VENDOR VALUES (" + vendorIDtxt.Text.Trim() + ", " + phonetxt.Text.Trim() + ", '" + addresstxt.Text.Trim() + "' ,  '" + companytxt.Text.Trim() + "' , '" + typetxt.Text.Trim() +
                     "',  '"+countrytxt.Text.Trim()+"',' "+ citytxt.Text.Trim() + "', '" + titletxt.Text.Trim() + "', '"+ firstnametxt.Text.Trim() + "', '"+ surnametxt.Text.Trim()+ "', '" + emailtxt.Text.Trim()+ "') ;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Vendor has been added!");
                this.Close();


                if (SV == null)
                {
                    SV = new SearchVendor();
                    SV.MdiParent = this.MdiParent;
                    SV.FormClosed += new FormClosedEventHandler(SV_FormClosed);
                    SV.Show();
                    //this.Close();
                }
                else
                {
                    SV.Activate();
                    SV.FormClosed += new FormClosedEventHandler(SV_FormClosed);
                    SV.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Not all fields filled.");
            }
        }
        void SV_FormClosed(object sender, FormClosedEventArgs e)
        {
            SV = null;
        }


    }
}
