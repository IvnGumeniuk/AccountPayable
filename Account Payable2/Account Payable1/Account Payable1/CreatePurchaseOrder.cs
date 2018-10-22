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
        public static string vendorname ="";
        public static int opened = 0;
        
        public CreatePurchaseOrder()
        {
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
            opened = 1;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
            String query = "SELECT POID FROM TBL_PURCHASE_ORDER";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl != null)
            {
                int poid = Convert.ToInt32(dtbl.Rows[dtbl.Rows.Count-1][0]) +1;
                POIDtxt.Text = Convert.ToString(poid);
            }
            else
                POIDtxt.Text = Convert.ToString(1000);

            query = " SELECT TBL_PO_ITEMS.itemID, TBL_SC_ITEMS.item_name,  TBL_PO_ITEMS.quantity, TBL_SC_ITEMS.price FROM (TBL_PO_ITEMS INNER JOIN TBL_PURCHASE_ORDER ON TBL_PO_ITEMS.POID = TBL_PURCHASE_ORDER.POID) INNER JOIN TBL_SC_ITEMS ON TBL_SC_ITEMS.itemID = TBL_PO_ITEMS.itemID WHERE TBL_PO_ITEMS.POID =" + POIDtxt.Text.Trim() + ";";
            sda = new SqlDataAdapter(query, con);
            DataTable dtb2 = new DataTable();
            sda.Fill(dtb2);
            dataGridView2.DataSource = dtb2;

            con.Open();
            query = "INSERT INTO TBL_PURCHASE_ORDER (POID, delivery_date, created_date, POstatus) VALUES (" + POIDtxt.Text.Trim() + ", '"+ deliveryDate.Value.Date.ToString("yyyyMMdd")  +"' , '"+createdDate.Value.Date.ToString("yyyyMMdd") + "' , 1 );" ;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            query = "SELECT companyName FROM TBL_VENDOR";
            cmd = new SqlCommand(query , con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                MyCollection.Add(reader.GetString(0));
            }
            searchtxt.AutoCompleteCustomSource = MyCollection;
            con.Close();
         
            
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
            opened = 0;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string query = " SELECT TBL_SC_ITEMS.itemID, TBL_SC_ITEMS.item_name, TBL_SC_ITEMS.price FROM TBL_SC_ITEMS INNER JOIN TBL_VENDOR ON manufacturer=Vendor_ID WHERE TBL_VENDOR.companyName = '" + searchtxt.Text.Trim() + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
           

            SearchVendor findvendor = new SearchVendor();
           // findvendor.Show();
            findvendor.ShowDialog();
            this.Focus();
            searchtxt.Text = vendorname;
    
            

        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void POIDtxt_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(POIDtxt.Text.Trim(), out int n);
            if (n != 0)
            {
                string query = " SELECT TBL_PO_ITEMS.itemID, TBL_SC_ITEMS.item_name,  TBL_PO_ITEMS.quantity, TBL_SC_ITEMS.price FROM (TBL_PO_ITEMS INNER JOIN TBL_PURCHASE_ORDER ON TBL_PO_ITEMS.POID = TBL_PURCHASE_ORDER.POID) INNER JOIN TBL_SC_ITEMS ON TBL_SC_ITEMS.itemID = TBL_PO_ITEMS.itemID WHERE TBL_PO_ITEMS.POID =" + POIDtxt.Text.Trim() + ";";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtb2 = new DataTable();
                sda.Fill(dtb2);
                dataGridView2.DataSource = dtb2;
                double sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) * Convert.ToInt64(dataGridView2.Rows[i].Cells[2].Value);
                }
                totallbl.Text = sum.ToString();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string itemID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (POIDtxt.Text == "")
                MessageBox.Show("Enter the Purchase Order number first.");
            else
            {
                string query = "SELECT itemID FROM TBL_PO_ITEMS WHERE POID= " + POIDtxt.Text.Trim() + " AND itemID = " + itemID + ";";
                SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                DataTable dtb1 = new DataTable();
                sda1.Fill(dtb1);
                if(dtb1.Rows.Count==0)
                {
                    con.Open();
                    query = "INSERT INTO TBL_PO_ITEMS VALUES (" + POIDtxt.Text.Trim() + " , " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + " , 1);";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    con.Open();
                    query = "UPDATE TBL_PO_ITEMS SET quantity=quantity+1 WHERE POID= " + POIDtxt.Text.Trim() + " AND itemID = " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                query = " SELECT TBL_PO_ITEMS.itemID, TBL_SC_ITEMS.item_name,  TBL_PO_ITEMS.quantity, TBL_SC_ITEMS.price FROM (TBL_PO_ITEMS INNER JOIN TBL_PURCHASE_ORDER ON TBL_PO_ITEMS.POID = TBL_PURCHASE_ORDER.POID) INNER JOIN TBL_SC_ITEMS ON TBL_SC_ITEMS.itemID = TBL_PO_ITEMS.itemID WHERE TBL_PO_ITEMS.POID =" + POIDtxt.Text.Trim() + ";";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtb2 = new DataTable();
                sda.Fill(dtb2);
                dataGridView2.DataSource = dtb2;
                double sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) * Convert.ToInt64(dataGridView2.Rows[i].Cells[2].Value);
                }
                totallbl.Text =  sum.ToString(); 
            } 

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            var row = dataGridView2.Rows[e.RowIndex];
            var changedValue = (int)row.Cells[e.ColumnIndex].Value;
            string query = "UPDATE TBL_PO_ITEMS SET quantity = "+ changedValue + " WHERE POID= " + POIDtxt.Text.Trim() + " AND itemID = " + this.dataGridView2.CurrentRow.Cells[0].Value.ToString() + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

             query = " SELECT TBL_PO_ITEMS.itemID, TBL_SC_ITEMS.item_name,  TBL_PO_ITEMS.quantity, TBL_SC_ITEMS.price FROM (TBL_PO_ITEMS INNER JOIN TBL_PURCHASE_ORDER ON TBL_PO_ITEMS.POID = TBL_PURCHASE_ORDER.POID) INNER JOIN TBL_SC_ITEMS ON TBL_SC_ITEMS.itemID = TBL_PO_ITEMS.itemID WHERE TBL_PO_ITEMS.POID =" + POIDtxt.Text.Trim() + ";";
             SqlDataAdapter sda = new SqlDataAdapter(query, con);
             DataTable dtb2 = new DataTable();
             sda.Fill(dtb2);
             dataGridView2.DataSource = dtb2;
             double sum = 0;
             for (int i = 0; i < dataGridView2.Rows.Count; ++i)
             {
                 sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) * Convert.ToInt64(dataGridView2.Rows[i].Cells[2].Value);
             }
             totallbl.Text = sum.ToString(); 
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                string itemid = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
                dataGridView2.Rows.RemoveAt(item.Index);

                con.Open();
                string query = "DELETE FROM TBL_PO_ITEMS WHERE itemID = " + itemid + " AND POID= " + POIDtxt.Text.Trim() + ";"; 
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            double sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) * Convert.ToInt64(dataGridView2.Rows[i].Cells[2].Value);
            }
            totallbl.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Vendor_ID FROM TBL_VENDOR WHERE companyName = '" + searchtxt.Text.Trim() + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtb2 = new DataTable();
            sda.Fill(dtb2);
            if(searchtxt.Text != "")
            {
                string vendor = Convert.ToString(dtb2.Rows[0][0]);
                con.Open();

                query = "UPDATE TBL_PURCHASE_ORDER SET terms = '" + termstxt.Text.Trim() + "', notes = '" + notestxt.Text.Trim() + "', tax=" + txtTax.Text.Trim() + ", total =  " + totallbl.Text.Trim() + ",VendorID = " + vendor
                    + ", delivery_date = '" + deliveryDate.Value.Date.ToString("yyyyMMdd") + "', created_date = '" + createdDate.Value.Date.ToString("yyyyMMdd") + "' WHERE POID= " + POIDtxt.Text.Trim() + " ;";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Purchase Order has been added.");
            }
            else
                MessageBox.Show("No Vendor has been selected.");

            opened = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string query = "DELETE FROM TBL_PO_ITEMS WHERE POID= " + POIDtxt.Text.Trim() + ";";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();           
            query = "DELETE FROM TBL_PURCHASE_ORDER WHERE POID = "  + POIDtxt.Text.Trim() + ";";
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            opened = 0;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void createdDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
