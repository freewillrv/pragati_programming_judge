using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pragati_Judge
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Splash());
                Application.Run(new Login());
            }
            catch (Exception) { }
        }
    }
}
