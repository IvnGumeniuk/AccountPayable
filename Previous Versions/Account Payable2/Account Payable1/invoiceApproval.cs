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
    public partial class invoiceApproval : Form
    {
        public invoiceApproval()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
        private void invoiceApproval_Load(object sender, EventArgs e)
        {
            invoicelink.Text= ViewInvoice.invoiceid;

            String query = "SELECT vendorID FROM TBL_INVOICE WHERE invoiceID = " + invoicelink.Text.Trim() + ";";
            SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
            DataTable dtbl2 = new DataTable();
            sda1.Fill(dtbl2);
            textBox1.Text = Convert.ToString(dtbl2.Rows[0][0]);

            query = "SELECT * FROM TBL_VENDOR INNER JOIN TBL_INVOICE ON vendorID=Vendor_ID WHERE invoiceID = " + invoicelink.Text.Trim() + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            string vendor = Convert.ToString(dtbl.Rows[0][3]); lblvendor.Text = vendor;
            string firstname = Convert.ToString(dtbl.Rows[0][8]); lblname.Text = firstname;
            string surname = Convert.ToString(dtbl.Rows[0][9]); lblsurname.Text = surname;
            string email = Convert.ToString(dtbl.Rows[0][10]); lblemail.Text = email;
            string phone = Convert.ToString(dtbl.Rows[0][1]); lblphone.Text = phone;
            string address = Convert.ToString(dtbl.Rows[0][2]); lblcountry.Text = address;
            string city = Convert.ToString(dtbl.Rows[0][6]); lblcity.Text = city;
            string country = Convert.ToString(dtbl.Rows[0][5]); lblcountry.Text = country;

            query = "SELECT POID FROM TBL_INVOICE WHERE invoiceID = " + invoicelink.Text.Trim() + ";";
            sda1 = new SqlDataAdapter(query, con);
            dtbl2 = new DataTable();
            sda1.Fill(dtbl2);
            poidlink.Text = Convert.ToString(dtbl2.Rows[0][0]);

            query = "SELECT RRID FROM TBL_PURCHASE_ORDER INNER JOIN TBL_RECEIVING_REPORT ON TBL_PURCHASE_ORDER.POID=TBL_RECEIVING_REPORT.POID WHERE TBL_RECEIVING_REPORT.POID = " + poidlink.Text.Trim() + ";";
            sda1 = new SqlDataAdapter(query, con);
            dtbl2 = new DataTable();
            sda1.Fill(dtbl2);
            rridlink.Text = Convert.ToString(dtbl2.Rows[0][0]);

            query = " SELECT TBL_INVOICE_ITEMS.itemID, item_name, quantity FROM TBL_INVOICE_ITEMS INNER JOIN TBL_SC_ITEMS ON TBL_INVOICE_ITEMS.itemID = TBL_SC_ITEMS.itemID WHERE invoiceID = " + invoicelink.Text.Trim() + ";";
            sda = new SqlDataAdapter(query, con);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView2.DataSource = dtbl;

            query = " SELECT TBL_PO_ITEMS.itemID, item_name , quantity FROM TBL_PO_ITEMS INNER JOIN TBL_SC_ITEMS ON TBL_PO_ITEMS.itemID=TBL_SC_ITEMS.itemID WHERE POID = " + poidlink.Text.Trim() + ";";
            sda = new SqlDataAdapter(query, con);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

            query = " SELECT TBL_RECEIVED_ITEMS.itemID, item_name, quantity FROM TBL_RECEIVED_ITEMS INNER JOIN TBL_SC_ITEMS ON TBL_RECEIVED_ITEMS.itemID=TBL_SC_ITEMS.itemID WHERE RRID = " + rridlink.Text.Trim() + ";";
            sda = new SqlDataAdapter(query, con);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView3.DataSource = dtbl;
        }

        MakePayment mp;
        private void button1_Click(object sender, EventArgs e)
        {
            int count1 = dataGridView1.Rows.Count;
            int count2 = dataGridView2.Rows.Count;
            int count3 = dataGridView3.Rows.Count;

            if(count1 == count2 && count2 == count3)
            {
                for(int i=0; i<count1; i++)
                {
                    if((Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == (Convert.ToString(dataGridView2.Rows[i].Cells[0].Value))) && ((Convert.ToString(dataGridView2.Rows[i].Cells[0].Value)) == (Convert.ToString(dataGridView3.Rows[i].Cells[0].Value))))
                    {
                        if ((Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) == (Convert.ToString(dataGridView2.Rows[i].Cells[2].Value))) && ((Convert.ToString(dataGridView2.Rows[i].Cells[2].Value)) == (Convert.ToString(dataGridView3.Rows[i].Cells[2].Value))))
                        {
                            con.Open();
                            string query = "UPDATE TBL_INVOICE SET Istatus = 1 WHERE invoiceID= " + invoicelink.Text.Trim() + ";";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();                        
                            query = "UPDATE TBL_PURCHASE_ORDER SET POstatus = 1 WHERE POID= " + poidlink.Text.Trim() + ";";
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();   
                            con.Close();

                            radioButton2.Checked = true;
                            radioButton2.Enabled = true;
                            radioButton2.ForeColor = Color.Green;
                            radioButton1.Enabled = false;


                        }
                        else
                        {
                            
                            MessageBox.Show("The invoice was NOT approved. ");
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The invoice was NOT approved. ");
                        break;

                    }
                }
            }
            else
                MessageBox.Show("The invoice was NOT approved.");

            if (radioButton2.Checked)
            {
                if (mp == null)
                {

                    mp = new MakePayment();
                    mp.MdiParent = this.MdiParent;
                    mp.FormClosed += new FormClosedEventHandler(mp_FormClosed);
                    mp.Show();
                    //this.Close();
                }
                else
                {
                    mp.Activate();
                    mp.FormClosed += new FormClosedEventHandler(mp_FormClosed);
                    mp.Show();
                }
            }
        }
        void mp_FormClosed(object sender, FormClosedEventArgs e)
        {
            mp = null;
        }


        private void poidlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
