using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Syncfusion.Licensing;
namespace SynfusionTest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SyncfusionLicenseProvider.RegisterLicense("MDAxQDMyMzcyZTMwMmUzMGVIQmM1bWd3dHBYZlg4S0MycTZaRDFNN0pEdG5oOENuVW5YTEVmbVlzMjg9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
