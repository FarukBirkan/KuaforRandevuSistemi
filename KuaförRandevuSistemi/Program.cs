using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuaförRandevuSistemi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Silver");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new giris());
           // Application.Run(new ());


          
        }
    }
}
