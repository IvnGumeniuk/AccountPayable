using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Account_Payable1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JML7RM2\SQLEXPRESS; Initial Catalog=AccountsPayable;Integrated Security=True");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AccountsPayable());
        }
    }
}
