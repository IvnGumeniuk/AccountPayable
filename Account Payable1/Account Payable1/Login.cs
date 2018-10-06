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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = usernametxt.Text;
            password = passwordtxt.Text;
            if (username=="sa" && password=="123")
            {
                this.Hide();
                MainMenu m2 = new MainMenu();
                m2.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong.");
            }
        }
    }
}
