using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.UPDATE
{
    public partial class FRM_NOTIFICATION : Form
    {
        int x, y;
        public bool Isaccept { get; set; }
        private void FRM_NOTIFICATION_Shown(object sender, EventArgs e)
        {
            while (x>= Screen.PrimaryScreen.WorkingArea.Width-this.Width+25)
            {
                x -= 25;
                this.Location = new Point(x, y);
                Refresh();
            }
            while (x >= Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10)
            {
                x -= 2;
                this.Location = new Point(x, y);
                Refresh();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("لتنفيذ الاجراء سوف يتم اغلاق البرنامج هل انت موافق؟","تنبيه",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                foreach (var process in Process.GetProcessesByName("MEDICALCLINIC.exe"))
                {
                    process.Kill();
                }
                Isaccept = true;
                this.Close();
            }
        }

        private void btnlater_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        public FRM_NOTIFICATION()
        {
            InitializeComponent();
            x = Screen.PrimaryScreen.WorkingArea.Width;
            y = Screen.PrimaryScreen.WorkingArea.Height -this.Height- 15;
            this.Location = new Point(x, y);
            this.TopMost = true;
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //لانشاء ملف مضغوط
        //    string src = Path.GetDirectoryName(Application.ExecutablePath);
        //    string dest = "E:\\NewFile.zip";
        //    ZipFile.CreateFromDirectory(src, dest);
        //}
    }
}
