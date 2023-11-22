using MEDICALCLINIC.Services;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC
{
    static class Program
    {
        public static BookingDoctorService bookingDoctorService = null;
        public static LabService labService = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //String runUpdate = Path.GetDirectoryName(Application.ExecutablePath) + "\\Autoupdate.exe";
            //Process.Start(runUpdate);
            Application.Run(new MAIN.FRM_LOGIN());
          //  Application.Run(new CHAT.FRM_WHASTAPP());
            //}
            //catch (Exception ex)

            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
