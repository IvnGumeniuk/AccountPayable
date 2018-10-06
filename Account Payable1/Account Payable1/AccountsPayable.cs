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
    public partial class AccountsPayable : Form
    {
        public AccountsPayable()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        CreatePurchaseOrder CPO;
        private void newPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CPO==null)
            {
                CPO = new CreatePurchaseOrder();
                CPO.MdiParent = this;
                CPO.FormClosed += new FormClosedEventHandler(CPO_FormClosed);
                CPO.Show();
               // this.Close();
            }
            else
            {
                CPO.Activate();
            }
            
        }
        void CPO_FormClosed(object sender, FormClosedEventArgs e)
        {
            CPO = null;
        }

        ViewPurchaseOrder VPO;
        private void viewPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VPO == null)
            {
                VPO = new ViewPurchaseOrder();
                VPO.MdiParent = this;
                VPO.FormClosed += new FormClosedEventHandler(VPO_FormClosed);
                VPO.Show();
               // this.Close();
            }
            else
            {
                VPO.Activate();
            }
        }
            void VPO_FormClosed(object sender, FormClosedEventArgs e)
            {
                VPO = null;
            }
        SearchVendor SearchV;
        private void searchVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SearchV == null)
            {
                SearchV = new SearchVendor();
                SearchV.MdiParent = this;
                SearchV.FormClosed += new FormClosedEventHandler(SearchV_FormClosed);
                SearchV.Show();
                //this.Close();
            }
            else
            {
                SearchV.Activate();
            }
        }
        void SearchV_FormClosed(object sender, FormClosedEventArgs e)
        {
            SearchV = null;
        }

        CreateNewVendor CNV;
        private void createNewVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CNV == null)
            {
                CNV = new CreateNewVendor();
                CNV.MdiParent = this;
                CNV.FormClosed += new FormClosedEventHandler(CNV_FormClosed);
                CNV.Show();
                //this.Close();
            }
            else
            {
                CNV.Activate();
            }
        }
        void CNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            CNV = null;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login a1 = new Login();
            a1.Show();
            this.Close();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu a1 = new MainMenu();
            a1.Show();
            this.Close();
        }
    }
    }

