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
            // TODO: This line of code loads data into the 'accountPayableDataSet.login' table. You can move, or remove it, as needed.
           // this.loginTableAdapter.Fill(this.AccountsPayableDataSet);

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

        
       

        private void AccountsPayable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void auditReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rec_rep == null)
            {
                rec_rep = new ReceivingReports();
                rec_rep.MdiParent = this;
                rec_rep.FormClosed += new FormClosedEventHandler(rec_rep_FormClosed);
                rec_rep.Show();
                //this.Close();
            }
            else
            {
                rec_rep.Activate();
            }
        }
    
       
        void rec_rep2_FormClosed(object sender, FormClosedEventArgs e)
        {
            rec_rep2 = null;
        }

        ViewReceivingReport rec_rep2;
        private void viewReceivingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rec_rep2 == null)
            {
                rec_rep2 = new ViewReceivingReport();
                rec_rep2.MdiParent = this;
                rec_rep2.FormClosed += new FormClosedEventHandler(rec_rep2_FormClosed);
                rec_rep2.Show();
            }
            else
                rec_rep2.Activate();
        }

        

        ViewInvoice view_i;
        private void viewInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (view_i == null)
            {
                view_i = new ViewInvoice();
                view_i.MdiParent = this;
                view_i.FormClosed += new FormClosedEventHandler(view_i_FormClosed);
                view_i.Show();
                //this.Close();
            }
            else
            {
                view_i.Activate();
            }
        }
        void view_i_FormClosed(object sender, FormClosedEventArgs e)
        {
            view_i = null;
        }

        invoiceApproval invapp;
        private void invoiceProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (invapp == null)
            {
                invapp = new invoiceApproval();
                invapp.MdiParent = this;
                invapp.FormClosed += new FormClosedEventHandler(invapp_FormClosed);
                invapp.Show();
                //this.Close();
            }
            else
            {
                ALLPO.Activate();
            }
        }
        void invapp_FormClosed(object sender, FormClosedEventArgs e)
        {
            invapp = null;
        }


       
        CreatePurchaseOrder CPO;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (CPO == null)
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

        PurchaseOrders ALLPO;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ALLPO == null)
            {
                ALLPO = new PurchaseOrders();
                ALLPO.MdiParent = this;
                ALLPO.FormClosed += new FormClosedEventHandler(ALLPO_FormClosed);
                ALLPO.Show();
                //this.Close();
            }
            else
            {
                ALLPO.Activate();
            }
        }
        void ALLPO_FormClosed(object sender, FormClosedEventArgs e)
        {
            ALLPO = null;
        }

        ReceivingReports rec_rep;
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
       
                if (rec_rep == null)
                {
                    rec_rep = new ReceivingReports();
                    rec_rep.MdiParent = this;
                    rec_rep.FormClosed += new FormClosedEventHandler(rec_rep_FormClosed);
                    rec_rep.Show();
                    //this.Close();
                }
                else
                {
                    rec_rep.Activate();
                }
            }
            void rec_rep_FormClosed(object sender, FormClosedEventArgs e)
            {
                rec_rep = null;
            }
    
        Invoices all_inv;
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
           
                if (all_inv == null)
                {
                    all_inv = new Invoices();
                    all_inv.MdiParent = this;
                    all_inv.FormClosed += new FormClosedEventHandler(all_inv_FormClosed);
                    all_inv.Show();
                }
                else
                {
                    all_inv = null;
                }
         }
            void all_inv_FormClosed(object sender, FormClosedEventArgs e)
            {
                all_inv = null;
            }

        SearchVendor SearchV;
        private void toolStripButton5_Click(object sender, EventArgs e)
        { 
                if (SearchV == null)
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

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
    
    
    
    

