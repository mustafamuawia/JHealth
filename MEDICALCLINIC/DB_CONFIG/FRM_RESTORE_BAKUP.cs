using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MEDICALCLINIC.DB_CONFIG
{
    public partial class FRM_RESTORE_BAKUP :MEDICALCLINIC. SETTING.BASEANYFORM
    {

        SqlConnection con;
        SqlCommand cmd;
        string database; 
        public FRM_RESTORE_BAKUP()
        {

            InitializeComponent();
            try
            {

                if (Properties.Settings.Default.ConnectTypeDB == 1)
                {
                    con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=Master;Integrated Security=True;Connect Timeout=30;");
                }
                else
                if (Properties.Settings.Default.ConnectTypeDB == 2)
                {


                    string mode = Properties.Settings.Default.Mode;
                    if (mode == "SQL")
                    {
                        con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=master ;Integrated Security=false; User ID=" + Properties.Settings.Default.ID + ";Password=" + Properties.Settings.Default.Password + "");
                    }
                    else
                    {
                        con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=master;Integrated Security=true");

                    }
                }
               
            }
            catch
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string filen = "ALTER Database ["+ database + "] SET SINGLE_USER  WITH ROLLBACK IMMEDIATE";
                filen += " Restore DataBase [" + database + "] From Disk='" + txtPath.Text + "' WITH REPLACE ; ALTER DATABASE [" + database + "] SET MULTI_USER WITH ROLLBACK IMMEDIATE ";
                //  string filen = "ALTER Database Super_mark SET SINGLE_USER WITH ROLLBACK IMMEDIATE;  Restore DataBase Super_mark From Disk= 'D:\\Super_markFriday, April 1, 2016.bak' WITH REPLACE; ALTER DATABASE Super_mark SET MULTI_USER WITH ROLLBACK IMMEDIATE ";

                cmd = new SqlCommand(filen, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم أستعادة النسخة ألاحتياطية بنجاح", "أستعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "نسخة احتياطية(.BAK)|*.BAK";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
                 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_RESTORE_BAKUP_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ConnectTypeDB==1)
            {
                database = AppDomain.CurrentDomain.BaseDirectory + @"MEDICAL_CLINIC_DB.mdf";
            }
            else
            if (Properties.Settings.Default.ConnectTypeDB == 2)
            {
                database = Properties.Settings.Default.DataBase;
            }
          
        }
    }
}
