using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace MEDICALCLINIC.DB_CONFIG
{
    public partial class FRM_BACKUP :MEDICALCLINIC. SETTING.BASEANYFORM
    {
        SqlConnection con;
        SqlCommand cmd;

        string database, filenamedb;
        //string dbpath = AppDomain.CurrentDomain.BaseDirectory + @"MEDICAL_CLINIC_DB.mdf";
        public FRM_BACKUP()
        {
            InitializeComponent();
          
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.BackupPath = txtPath.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //string sqrQry = "Backup  Database " + databa + " to Disk='" + filename + ".bak'";
                //using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString)) ;
                //cmd = new SqlCommand(sqrQry, conn);
                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();
                string filename = txtPath.Text + "\\" + filenamedb + DateTime.Now.ToLongDateString().Replace('/', '-');
                string commandText = "Backup  Database [" + database + "] to Disk='" + filename + ".bak'";
                MessageBox.Show(commandText);
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString))
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }


                MessageBox.Show("تم أنشاء نسخة أحتياطية بنجاح", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_BACKUP_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ConnectTypeDB == 1)
            {
                database = AppDomain.CurrentDomain.BaseDirectory + @"MEDICAL_CLINIC_DB.mdf";
                filenamedb = Path.GetFileNameWithoutExtension(database);
            }
            else
               if (Properties.Settings.Default.ConnectTypeDB == 2)
            {
                database = Properties.Settings.Default.DataBase;
                filenamedb = database;
            }
             txtPath.Text = Properties.Settings.Default.BackupPath;
        }
    }
}
