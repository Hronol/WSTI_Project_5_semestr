using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSTI_Project
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        /// 

        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login_Form());

            Login_Form login = new Login_Form();

            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Main_Form());
                }
                else if (login.ShowDialog() == DialogResult.No)
                {       
                    Application.Exit();
                }
            }
        }
    }
}
