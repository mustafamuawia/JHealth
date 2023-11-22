using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
namespace MEDICALCLINIC.DB_CONFIG
{
    public partial class FRM_DB :MEDICALCLINIC. SETTING.BASEANYFORM
    {
        public FRM_DB()
        {
            InitializeComponent();
            txtServer.Text = Properties.Settings.Default.Server;
            txtDB.Text = Properties.Settings.Default.DataBase;
            if (Properties.Settings.Default.Mode == "SQL")
            {
                rbSql.Checked = true;
                txtID.Text = Properties.Settings.Default.ID;
                txtPWD.Text = Properties.Settings.Default.Password;
            }
            else
            {
                rbWindows.Checked = true;
                txtID.Clear();
                txtPWD.Clear();
                txtID.Enabled = false;
                txtPWD.Enabled = false;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
        try
            {

                if (Properties.Settings.Default.ConnectTypeDB == 0)
                {
                    MessageBox.Show("يرجى تحديد نوع الاتصال أولاً");
                    return;
                }

            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.DataBase = txtDB.Text;
            Properties.Settings.Default.Mode = rbSql.Checked == true ? "SQL" : "WIND";
            Properties.Settings.Default.ID = txtID.Text;
            Properties.Settings.Default.Password = txtPWD.Text;
            Properties.Settings.Default.Save();

                if (Properties.Settings.Default.ConnectTypeDB == 1)
                {
                   
                    Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"] = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename =|DataDirectory|\MEDICAL_CLINIC_DB.mdf;Integrated Security=True";
                    Properties.Settings.Default.Save();
                    MessageBox.Show(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
                }
                else
           if (Properties.Settings.Default.ConnectTypeDB == 2)
                {
                     

                        if (rbWindows.Checked)
                        {

                            Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"] = @"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.DataBase + ";Integrated Security=true";
                            Properties.Settings.Default.Save();
                        }
                        else if (rbSql.Checked)
                        {
                            // sqlconn = new SqlConnection("data source=" + txtServer.Text + ";user id=" + txtID.Text + ";password =" + txtPWD.Text + "");
                            Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"] = @"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.DataBase + " ; User ID=" + Properties.Settings.Default.ID + ";Password=" + Properties.Settings.Default.Password + "";
                            Properties.Settings.Default.Save();

                        }
                    
                }  
        

                MessageBox.Show("تم الاتصال بنجاح");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("يوجد خطأ في الاتصال" + Environment.NewLine + sqlex.Message);

            }
        
        }

        private void rbSql_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtPWD.Enabled = true;
        }

        private void rbWindows_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtPWD.Enabled = false;
        }

        private void btntestcon_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = null;
            if (rbWindows.Checked)
                sqlconn = new SqlConnection("data source=" + txtServer.Text + ";integrated security=sspi");
            else if (rbSql.Checked)
                sqlconn = new SqlConnection("data source=" + txtServer.Text + ";user id=" + txtID.Text + ";password =" + txtPWD.Text + "");

            MessageBox.Show(sqlconn.ConnectionString);
            try
            {
                if (sqlconn.State == ConnectionState.Open)
                     sqlconn.Close();
                     sqlconn.Open();

                MessageBox.Show("اتصال ناجح");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("يوجد خطأ في الاتصال" + Environment.NewLine + sqlex.Message);

            }

        }

       

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                txtPWD .UseSystemPasswordChar = false;
            }
            else
            {
                txtPWD.UseSystemPasswordChar = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_GETSQLSERVERNAME_Click(object sender, EventArgs e)
        {
            if (CmbServerName.SelectedIndex!=-1)
            {
                txtServer.Text = CmbServerName.Text;
            }
           
        }
        

 
 
public List<string> GetDatabaseList()
    {
        List<string> list = new List<string>();

        // Open connection to the database
        string conString = "server="+CmbServerName.SelectedText+";uid=sa;pwd=manager; database=northwind";

        using (SqlConnection con = new SqlConnection(conString))
        {
            con.Open();

            // Set up a command with the given query and associate
            // this with the current connection.
            using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(dr[0].ToString());
                    }
                }
            }
        }
        return list;

    }

        private void btn_getdb_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //comb_db.DataSource = GetDatabaseList();
            using (var con = new SqlConnection("Data Source="+CmbServerName.Text+"; Integrated Security=True;"))
            {
                con.Open();
                DataTable databases = con.GetSchema("Databases");
                foreach (DataRow database in databases.Rows)
                {
                  comb_db.Items.Add ( database.Field<String>("database_name"));
                    short dbID = database.Field<short>("dbid");
                    DateTime creationDate = database.Field<DateTime>("create_date");
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btn_get_instance_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string myServer = Environment.MachineName;

            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                    {
                        CmbServerName.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                        CmbServerName.SelectedIndex = 0;
                    }
                    else
                        CmbServerName.Items.Add(servers.Rows[i]["ServerName"].ToString());

                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btn_copydb_Click(object sender, EventArgs e)
        {
            if (comb_db.SelectedIndex!=-1)
            {
                txtDB.Text = comb_db.Text;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActiveprd_Click(object sender, EventArgs e)
        {
            FRM_TRAIL_VERSION FRM = new FRM_TRAIL_VERSION();
            FRM.ShowDialog();
        }

        private void d_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectTypeDB = 1;
            Properties.Settings.Default.Save();
            btn_SQLDB.BackColor= Color.DimGray; 
            d.BackColor= Color.Red;
        }

        private void btn_SQLDB_Click(object sender, EventArgs e)
        {
            btn_SQLDB.BackColor = Color.Red;
            d.BackColor = Color.DimGray;
            Properties.Settings.Default.ConnectTypeDB = 2;
            Properties.Settings.Default.Save();
        }

        private void bt_chagetype_Click(object sender, EventArgs e)
        {
            FRM_CHOOSE_PROGRAM frm =new FRM_CHOOSE_PROGRAM();
            frm.ShowDialog();
        }
    }
}
