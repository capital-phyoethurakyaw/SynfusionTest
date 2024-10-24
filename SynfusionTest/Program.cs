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
            //Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1NpR2pGfV5ycEVBal1STnZdUiweQnxTdEFiWX1ccXxWT2VfUEB0Ww==
            //Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1NpRGpGfV5ycEVFallXTnRXUiweQnxTdEFjUH1YcHNRT2VUUkR2Ww==
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1NpR2pGfV5ycEVBal1STnZdUiweQnxTdEFiWX1ccXxWT2VfUEB0Ww==");//("MDAxQDMyMzcyZTMwMmUzMGVIQmM1bWd3dHBYZlg4S0MycTZaRDFNN0pEdG5oOENuVW5YTEVmbVlzMjg9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( new  Visualizer.Visualizer());
        }
    }
}
