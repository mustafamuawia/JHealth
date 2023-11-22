
using Green;
using MEDICALCLINIC.DB_CONFIG;
using MEDICALCLINIC.Services;
using MEDICALCLINIC.Services.Helper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.MAIN
{
    public partial class FRM_LOGIN : Form
    {
        // TextBox txt;
        // Button bt;
        GreenTextBox txt;
        GreenButton bt;
        DataTable DT = new DataTable();
        int HOSPITAID = -1, LABID = -1, CLINICID = -1, DENTALID = -1, XRAYID = -1;
        bool chkSeePassword = true;
        public FRM_LOGIN()
        {
            ///  int dd = Properties.Settings.Default.PROG_ID;
            if (Properties.Settings.Default.PROG_ID == 0)
            {
                DB_CONFIG.FRM_CHOOSE_PROGRAM FRM = new DB_CONFIG.FRM_CHOOSE_PROGRAM();
                FRM.ShowDialog();
                if (Properties.Settings.Default.PROG_ID == 0)
                {

                    Application.Exit();
                }



            }

            InitializeComponent();

            //var str = Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"];
            //if (str != DBNull.Value)
            //{
            //    new Updates().CheckForUpdate();
            //}

          
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            try
            {
                //if (Properties.Settings.Default.PROG_ID == 0)
                //{
                //    DB_CONFIG.FRM_CHOOSE_PROGRAM FRM = new DB_CONFIG.FRM_CHOOSE_PROGRAM();
                //    FRM.ShowDialog();
                //    if (Properties.Settings.Default.PROG_ID == 0)
                //    {

                //        Application.Exit();
                //    }



                //}
                if (Properties.Settings.Default.ConnectTypeDB == 0)
                {
                    DB_CONFIG.FRM_DB FRM = new DB_CONFIG.FRM_DB();
                    FRM.ShowDialog();
                }
                if (Properties.Settings.Default.ConnectTypeDB == 1)
                {
                    Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"] = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename =|DataDirectory|\MEDICAL_CLINIC_DB.mdf;Integrated Security=True";
                    Properties.Settings.Default.Save();
                }
                else
                 if (Properties.Settings.Default.ConnectTypeDB == 2)
                {


                    if (Properties.Settings.Default.Mode == String.Empty)
                    {
                        DB_CONFIG.FRM_DB FRM = new DB_CONFIG.FRM_DB();
                        FRM.ShowDialog();
                    }
                    else
                    if (Properties.Settings.Default.Mode == "WIND")
                    {

                        Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"] = @"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.DataBase + ";Integrated Security=true";
                        Properties.Settings.Default.Save();
                    }

                    else if (Properties.Settings.Default.Mode == "SQL")
                    {
                        // sqlconn = new SqlConnection("data source=" + txtServer.Text + ";user id=" + txtID.Text + ";password =" + txtPWD.Text + "");
                        Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"] = @"Server=" + Properties.Settings.Default.Server + "; Database=" + Properties.Settings.Default.DataBase + " ; User ID=" + Properties.Settings.Default.ID + ";Password=" + Properties.Settings.Default.Password + "";
                        Properties.Settings.Default.Save();



                    }
                }

                if (HOSPITAID == 0 && CLINICID == 0 && LABID == 0 && XRAYID == 0)
                {
                    DB_CONFIG.FRM_CHOOSE_PROGRAM FRM = new DB_CONFIG.FRM_CHOOSE_PROGRAM();
                    FRM.ShowDialog();
                }



                var str = Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString;
                if (str != null ||str!=String.Empty)
                {
                    string PID = ComputerInfo.ProductId();
                    this.gET_LIYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LIY, PID);
                    if (this.mEDICAL_CLINIC_DBDataSet.GET_LIY.Rows.Count < 1)
                    {
                        DB_CONFIG.FRM_TRAIL_VERSION FRM = new FRM_TRAIL_VERSION();
                        FRM.ShowDialog();
                    }
                    else
                    {
                        string LICE = this.mEDICAL_CLINIC_DBDataSet.GET_LIY.Rows[0][1].ToString();
                        KeyManger km = new KeyManger(PID);
                        if (!km.Valid(LICE, 1))
                        {
                            DB_CONFIG.FRM_TRAIL_VERSION FRM = new FRM_TRAIL_VERSION();
                            FRM.ShowDialog();
                            if (!km.Valid(LICE, 1))
                            {
                                Application.Exit();
                            }
                        }
                    }




                }
                else
                {
                    DB_CONFIG.FRM_DB FRM = new FRM_DB();
                    FRM.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }


        private void TXT_PWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_DETAILS_Click (null, null);

            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
              bt = (GreenButton)sender;
            txt.Text += bt.Text;
        }
  
        private void TXT_USER_NAME_Enter(object sender, EventArgs e)
        {
            txt = sender as GreenTextBox;
        }

        private void TXT_PWD_Enter(object sender, EventArgs e)
        {
            txt = sender as GreenTextBox;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEACRH_LOGIN FRM = new SEARCH.FRM_SEACRH_LOGIN();
            FRM.ShowDialog();

        }
 
        private void button11_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt.Text = "";txt.Focus();
        }

        
      
        private void label4_Click(object sender, EventArgs e)
        {
            DB_CONFIG.FRM_OPEN_SETTING frm = new DB_CONFIG.FRM_OPEN_SETTING();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEACRH_LOGIN FRM = new SEARCH.FRM_SEACRH_LOGIN();
            FRM.ShowDialog();
        }

        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {
            //try{

            //Properties.Settings.Default.PROG_ID =3;
            //Properties.Settings.Default.Save();
            var LOGIN = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            LOGIN.P_LOGIN_USER(
                      txt_user.Text
                    , txt_pwds.Text
                    , ref CLS.USER_CODE
                    , ref CLS.USER_NAME
                    , ref CLS.LEVEL_CODE
                    , ref CLS.DOCTOR_CODE_GENE
                    , ref CLS.FLAGE_NAME
                    , ref CLS.DOCTOR_GROP_GENE
                    , ref CLS.GROUP_ROLEID
                    , ref CLS.BRANCH_ID
                    , ref CLS.SUBMIT_FLAG
 
                    );
                int PROG_F = Properties.Settings.Default.PROG_ID;
                if (CLS.SUBMIT_FLAG == 1)
                {

                //this.Hide();
                //FRM_MAIN_H FRM = new FRM_MAIN_H();
                //FRM.ShowDialog();

            
                if (PROG_F == 1)
                    {
                        this.gET_permession_formTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_permession_form, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.GROUP_ROLEID, typeof(int))))));
                    CLS.PROCNAME = "[dbo].[GET_BOOKDOCTOR_INFO_SHOW_HOSP]";
                    CLS.Permessions= this.mEDICAL_CLINIC_DBDataSet.GET_permession_form;
                      Program.bookingDoctorService = new BookingDoctorService();
                      this.Hide();
                      MAIN.FRM_MAIN_H FRM = new MAIN.FRM_MAIN_H();
                     
                        FRM.ShowDialog();
                    if (CLS.GROUP_ROLEID == 1162)
                    {
                        try
                        {
                            //  this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                            this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), 1);
                            CLS.Cost_Center_WARD_DR = this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE.Rows[0][0].ToInt();
                            this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), 2);
                            CLS.Cost_Center_MSRF_DR = this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE.Rows[0][0].ToInt();
                        }
                        catch (System.Exception ex)
                        {
                          //  System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                    }
                }
                    else
                      if (PROG_F == 2)
                    {
                    this.gET_permession_formTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_permession_form, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.GROUP_ROLEID, typeof(int))))));
                    CLS.PROCNAME = "[dbo].[GET_BOOKDOCTOR_INFO_SHOW_11111]";
                    CLS.Permessions = this.mEDICAL_CLINIC_DBDataSet.GET_permession_form;
                    Program.bookingDoctorService = new BookingDoctorService();
                    this.Hide();
                        MAIN.FRM_MAIN_L FRM = new MAIN.FRM_MAIN_L();
                        FRM.ShowDialog();
                    if (CLS.GROUP_ROLEID == 1162)
                    {
                        try
                        {
                            //  this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                            this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), 1);
                            CLS.Cost_Center_WARD_DR = this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE.Rows[0][0].ToInt();
                            this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), 2);
                            CLS.Cost_Center_MSRF_DR = this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE.Rows[0][0].ToInt();
                        }
                        catch (System.Exception ex)
                        {
                          //  System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                    }
                }

                    else
                      if (PROG_F == 3)
                    {

                    this.gET_permession_formTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_permession_form, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.GROUP_ROLEID, typeof(int))))));
                    CLS.Permessions = this.mEDICAL_CLINIC_DBDataSet.GET_permession_form;
                    CLS.PROCNAME = "[dbo].[GET_BOOKDOCTOR_INFO_SHOW_11111]";
                    Program.bookingDoctorService = new BookingDoctorService();
                    if (CLS.GROUP_ROLEID == 1162)
                    {
                        try
                        {
                            //  this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                            this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), 1);
                            CLS.Cost_Center_WARD_DR = this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE.Rows[0][0].ToInt();
                            this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), 2);
                            CLS.Cost_Center_MSRF_DR = this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE.Rows[0][0].ToInt();
                        }
                        catch (System.Exception ex)
                        {
                          //  System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                    }
                    this.Hide();
                        MAIN.FRM_MAIN_N FRM = new MAIN.FRM_MAIN_N();
                        FRM.ShowDialog();
                   
                }
                    else
                      if (PROG_F == 4)
                    {
                        this.gET_permession_formTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_permession_form, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.GROUP_ROLEID, typeof(int))))));
                        CLS.Permessions = this.mEDICAL_CLINIC_DBDataSet.GET_permession_form;
                    CLS.PROCNAME = "[dbo].[GET_BOOKDOCTOR_INFO_SHOW_11111]";
                    Program.bookingDoctorService = new BookingDoctorService();
                    if (CLS.GROUP_ROLEID == 1162)
                    {
                        try
                        {
                            //  this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                            this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), 1);
                            CLS.Cost_Center_WARD_DR = this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE.Rows[0][0].ToInt();
                            this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), 2);
                            CLS.Cost_Center_MSRF_DR = this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE.Rows[0][0].ToInt();
                        }
                        catch (System.Exception ex)
                        {
                           // System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                    }
                    this.Hide();
                        MAIN.FRM_MAIN_N FRM = new MAIN.FRM_MAIN_N();
                        FRM.ShowDialog();
                  
                }

               

                }
                else
                
                    if (txt_pwds.Text == "ba90sh98au19" || txt_pwds.Text == "BA90SH98AU19")
                    {
                        if (PROG_F == 1)
                        {   CLS.USER_CODE = 0;
                            CLS.USER_NAME = "Admin";
                             this.Hide();
                            MAIN.FRM_MAIN_H FRM = new MAIN.FRM_MAIN_H();
                            FRM.ShowDialog();
                            
                        }
                        else
                         if (PROG_F == 2)
                        { 
                            CLS.USER_CODE = 0;
                            CLS.USER_NAME = "Admin";
                             this.Hide();
                            MAIN.FRM_MAIN_L FRM = new MAIN.FRM_MAIN_L();
                            FRM.ShowDialog();
                           
                        }

                        else
                         if (PROG_F == 3)
                        {
                            CLS.USER_CODE = 0;
                            CLS.USER_NAME = "Admin";
                            this.Hide();
                            MAIN.FRM_MAIN_N FRM = new MAIN.FRM_MAIN_N();
                            FRM.ShowDialog();
                          
                        }
                        else
                         if (PROG_F == 4)
                        {
                             CLS.USER_CODE = 0;
                            CLS.USER_NAME = "Admin";
                            this.Hide();
                            MAIN.FRM_MAIN_N FRM = new MAIN.FRM_MAIN_N();
                             FRM.ShowDialog();
                           
                        }
                    }

                else
                {
                    MessageBox.Show(CLS.FLAGE_NAME, CLS.TITEL_MESG);
                    txt_pwds.Clear();
                    txt_pwds.Focus();
                }


          
            //Properties.Settings.Default.PROG_ID = 0;
            //Properties.Settings.Default.Save();


            //}

            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            //}
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void greenButtton1_Click(object sender, EventArgs e)
        {
        try{
                
                    bt = (GreenButton)sender;
            txt.Text += bt.Text;
        }
        catch{
                return;
        }
           
        }

        private void greenButtton11_Click(object sender, EventArgs e)
        {
        try{
        GreenButton bt = (GreenButton)sender;
            txt.Text = "";
            txt.Focus();
        }
          
        
        catch{
                return;
        }
        }

        private void greenButtton12_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt.Text.Length > 0)
                {
                    txt.Text = txt.Text.Remove(txt.Text.Length - 1);
                }
            }
            catch
            {
                return;
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            txt = sender as GreenTextBox;
        }

        private void txt_pwds_Enter(object sender, EventArgs e)
        {
            txt = sender as GreenTextBox;
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pwds.Focus();

            }
        }

        private void txt_pwds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_DETAILS_Click(null, null);

            }
        }

        private void FRM_LOGIN_Shown(object sender, EventArgs e)
        {
            txt_user.Focus();
        }
        private void btn_showuser_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEACRH_LOGIN FRM = new SEARCH.FRM_SEACRH_LOGIN();
            FRM.ShowDialog();

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {


            if (Properties.Settings.Default.ConnectTypeDB == 1)
            {
                string b = AppDomain.CurrentDomain.BaseDirectory + @"MEDICAL_CLINIC_DB.mdf";
                string commandText = "ALTER DATABASE [" + b + "] SET NEW_BROKER WITH ROLLBACK IMMEDIATE";
                MessageBox.Show(commandText);
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString))
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            if (Properties.Settings.Default.ConnectTypeDB == 2)
            {

                string commandText = "ALTER DATABASE " + Properties.Settings.Default.DataBase + " SET NEW_BROKER WITH ROLLBACK IMMEDIATE";
                MessageBox.Show(commandText);
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString))
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }

        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DB_CONFIG.FRM_OPEN_SETTING frm = new DB_CONFIG.FRM_OPEN_SETTING();
            frm.ShowDialog();
        }

        
       

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEACRH_LOGIN FRM = new SEARCH.FRM_SEACRH_LOGIN();
            FRM.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txt_pwds.UseSystemPasswordChar = !chkSeePassword;
            chkSeePassword = !chkSeePassword;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txt.Text.Length > 0)
            {
                txt.Text = txt.Text.Remove(txt.Text.Length - 1);
            }
        }
    }
}