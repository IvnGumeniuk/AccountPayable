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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void accountsPayable_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountsPayable a1 = new AccountsPayable();
            a1.Show();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
