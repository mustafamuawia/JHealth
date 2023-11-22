using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace MEDICALCLINIC.UPDATE
{
    public partial class FRM_UPDATES : Form
    {
        public FRM_UPDATES()
        {
            InitializeComponent();
        }
        string URLFILEUPDATE;
        string URLZIPFILE;
        string CurrentVersion;
        string FOLDERUPDATE;
        string FILEDOWLOAD;
       
        private void button1_Click(object sender, EventArgs e)
        {
            //Info info = new Info
            //{
            //    Version = "2000",
            //    VersionText = "2.0.0.0",
            //    Description = "Description Update",
            //    Typeupates=Typeupate.Normal

            //};
            //string json=new JavaScriptSerializer().Serialize(info);
            //System.IO.File.WriteAllText("infoupdate", json);
          
        }

        private void FRM_UPDATES_Load(object sender, EventArgs e)
        {
           
            URLFILEUPDATE = "https://drive.google.com/u/0/uc?id=1l0pRkZaaDyQ2tnAdij4eITtuzv20H3AL&export=download";
            URLZIPFILE = "https://drive.google.com/u/0/uc?id=1nLxxBmyAerViGkl6sIXI3SIAujvXYlgj&export=download";
            FOLDERUPDATE = Path.GetDirectoryName(Application.ExecutablePath) + "\\UPDATES";
            FILEDOWLOAD = FOLDERUPDATE + "\\NEWFILEUPDATE.zip";
            WebClient web = new WebClient();
            string jsond = web.DownloadString(URLFILEUPDATE);
            CurrentVersion = File.ReadAllText("version.txt");
           
            Info FileUpdateText = new JavaScriptSerializer().Deserialize<Info>(jsond);
            MessageBox.Show(FileUpdateText.Version);
            if (Convert.ToInt32(FileUpdateText.Version) > Convert.ToInt32(CurrentVersion))
            {
                FRM_NOTIFICATION frm = new FRM_NOTIFICATION();
                frm.ShowDialog();
                if (frm.Isaccept==true)
                {
                    CreateFolderUpload();
                    using (WebClient wc=new WebClient())
                    {
                        wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
                        wc.DownloadFileTaskAsync(new Uri(URLZIPFILE), FILEDOWLOAD);
                    }
                }
            }

        }
        string path ="";
        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            if (progressBar1.Value==100)
            { 
                string trgdirct = Path.GetDirectoryName(Application.ExecutablePath);
                path = FOLDERUPDATE+ "Extract";
                ZipFile.ExtractToDirectory(FILEDOWLOAD, path);
                foreach (var file in Directory.GetFiles(path))
                {
                  
                    File.Copy(file, Path.Combine(trgdirct, Path.GetFileName(file)), true);
                }
                label1.Text = "Updates Sucessfully!!";
                Thread.Sleep(5000);
                string runf = trgdirct + "\\MEDICALCLINIC.exe";
                Process.Start(runf);
                Application.Exit();
            }
        }

        private void CreateFolderUpload()
        {
            if (Directory.Exists(FOLDERUPDATE))
            {
                Directory.Delete(FOLDERUPDATE);
            }
            Directory.CreateDirectory(FOLDERUPDATE);
            Directory.CreateDirectory(FOLDERUPDATE + "\\Extract");
           
        }
    }
}
