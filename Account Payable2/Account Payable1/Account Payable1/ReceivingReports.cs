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
    public partial class ReceivingReports : Form
    {
        public ReceivingReports()
        {
            InitializeComponent();
        }

        private void ReceivingReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountsPayableDataSet1.TBL_RECEIVING_REPORT' table. You can move, or remove it, as needed.
            this.tBL_RECEIVING_REPORTTableAdapter.Fill(this.accountsPayableDataSet1.TBL_RECEIVING_REPORT);

        }
    }
}
