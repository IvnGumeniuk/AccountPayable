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
    public partial class InvoicePayment : Form
    {
        public static string invoicePaymentInvoiceId = "";
        public InvoicePayment()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");

        private void InvoicePayment_Load(object sender, EventArgs e)
        {
            textBox1.Text = ViewInvoice.invoiceid;
            String query = "SELECT NUM_vendorID, FT_total, NUM_POID, DT_due_date FROM TBL_INVOICE WHERE NUM_invoiceID = " + textBox1.Text.Trim() + " ;";
            SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
            DataTable dtbl2 = new DataTable();
            sda1.Fill(dtbl2);
            textBox2.Text = Convert.ToString(dtbl2.Rows[0][0]);
            lbltotal.Text = Convert.ToString(dtbl2.Rows[0][1]);
            POIDlbl.Text = Convert.ToString(dtbl2.Rows[0][2]);
            duedatebox.Text = Convert.ToString(dtbl2.Rows[0][3]);

            query = "SELECT * FROM TBL_VENDOR INNER JOIN TBL_INVOICE ON NUM_vendorID=NUM_Vendor_ID WHERE NUM_invoiceID = " + textBox1.Text.Trim() + ";";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            string vendor = Convert.ToString(dtbl.Rows[0][3]); label39.Text = vendor;
            string firstname = Convert.ToString(dtbl.Rows[0][8]); lblname.Text = firstname;
            string surname = Convert.ToString(dtbl.Rows[0][9]); lblsurname.Text = surname;
            string email = Convert.ToString(dtbl.Rows[0][10]); lblemail.Text = email;
            string phone = Convert.ToString(dtbl.Rows[0][1]); lblphone.Text = phone;
            string address = Convert.ToString(dtbl.Rows[0][2]); lbladdress.Text = address;
            string city = Convert.ToString(dtbl.Rows[0][6]); lblcity.Text = city;
            string country = Convert.ToString(dtbl.Rows[0][5]); lblcountry.Text = country;

            query = "SELECT NUM_PaymentID FROM TBL_PAYMENT";
            sda = new SqlDataAdapter(query, con);
            dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count != 0)
            {
                int paymentID = Convert.ToInt32(dtbl.Rows[dtbl.Rows.Count - 1][0]) + 1;
                paymentidtxt.Text = Convert.ToString(paymentID);
            }
            else
                paymentidtxt.Text = Convert.ToString(1000);

            con.Open();
            query = "INSERT INTO TBL_PAYMENT (NUM_PaymentID, NUM_PaymentType, NUM_invoiceID, NUM_vendorID, NUM_POID, DT_PaymentDate, FT_amount, DT_DueDate) VALUES (" + paymentidtxt.Text.Trim() + ", 2 , " + textBox1.Text.Trim() + ", " + textBox2.Text.Trim() + " , " + POIDlbl.Text.Trim() + ", '" + paymentDate.Value.Date.ToString("yyyyMMdd") + "' , " + lbltotal.Text.Trim() + " ,'" + issueDate.Value.Date.ToString("yyyyMMdd") + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        ViewInvoice vi;
        private void button1_Click(object sender, EventArgs e)
        {
            invoicePaymentInvoiceId = textBox1.Text.Trim();
            con.Open();
            string query = "UPDATE TBL_INVOICE SET NUM_Istatus = 2 WHERE NUM_invoiceID= " + textBox1.Text.Trim() + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();


            if (vi == null)
            {

                vi = new ViewInvoice();
                vi.MdiParent = this.MdiParent;
                vi.FormClosed += new FormClosedEventHandler(vi_FormClosed);
                vi.Show();
                this.Close();
            }
            else
            {
                vi.Activate();
                vi.FormClosed += new FormClosedEventHandler(vi_FormClosed);
                vi.Show();
            }
            MessageBox.Show("Vendor Paid.");
        }
        void vi_FormClosed(object sender, FormClosedEventArgs e)
        {
            vi = null;
        }
    }
}

