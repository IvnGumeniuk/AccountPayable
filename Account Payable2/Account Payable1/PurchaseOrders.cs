using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Payable1
{
    public partial class PurchaseOrders : Form
    {
        public PurchaseOrders()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_PURCHASE_ORDER' table. You can move, or remove it, as needed.
            this.tBL_PURCHASE_ORDERTableAdapter.Fill(this.accountsPayableDataSet1.TBL_PURCHASE_ORDER);

        }
    }
}
