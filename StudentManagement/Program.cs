using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new login_form());

            Loginform loginform = new Loginform();

            if(loginform.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Mainform());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
