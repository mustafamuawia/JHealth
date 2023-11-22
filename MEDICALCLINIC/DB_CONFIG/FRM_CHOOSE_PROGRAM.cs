using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.DB_CONFIG
{
    public partial class FRM_CHOOSE_PROGRAM : Form
    {
        public FRM_CHOOSE_PROGRAM()
        {
            InitializeComponent();
        }

        private void B_HOSPITAL_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PROG_ID = 1;
            Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);
        }

        private void B_LAB_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PROG_ID = 2;
            Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);
        }

        private void B_CLINIC_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PROG_ID =3;
            Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);
        }

        private void B_DENTAL_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PROG_ID = 4;
            Properties.Settings.Default.Save();
            Application.Restart();
            Environment.Exit(0);
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_CHOOSE_PROGRAM_Load(object sender, EventArgs e)
        {
            Process p = new Process()
            {
                StartInfo = new ProcessStartInfo("cmd.exe")
                {
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {   sw.WriteLine("sqllocaldb stop   MSSQLLocalDBc");
                sw.WriteLine("sqllocaldb delete MSSQLLocalDBc");
                sw.WriteLine("sqllocaldb create MSSQLLocalDBc");
                sw.WriteLine("sqllocaldb start  MSSQLLocalDBc");
             
            }

            p.Close();
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/C  sqllocaldb create MSSQLLocalDBb";
            //startInfo.Arguments = "/C  sqllocaldb create MSSQLLocalDBb";
            //startInfo.Arguments = "/C  sqllocaldb create MSSQLLocalDBb";
            //startInfo.Arguments = "/C  sqllocaldb create MSSQLLocalDBb";
            //process.StartInfo = startInfo;
            //process.Start();
        }
    }
}
