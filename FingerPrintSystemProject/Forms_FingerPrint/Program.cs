using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_FingerPrint
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Greetins());
            //Application.Run(new Form_Create_Company());
            //Application.Run(new Form_Create_Department());
            Application.Run(new Admin_Panel());
        }
        
    }
}
