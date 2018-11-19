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
    public partial class ViewPurchaseOrder : Form
    {
        public ViewPurchaseOrder()
        {
            InitializeComponent();
        }

        private void ViewPurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountPayableDataSet.purchaseOrder' table. You can move, or remove it, as needed.
            this.purchaseOrderTableAdapter.Fill(this.accountPayableDataSet.purchaseOrder);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
