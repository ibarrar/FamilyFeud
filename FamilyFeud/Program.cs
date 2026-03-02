using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FamilyFeud
{
    static class Program
    {
        static public frmFamilyFeud FamilyFeud;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FamilyFeud = new frmFamilyFeud();
            Application.Run(FamilyFeud);
        }
    }
}
