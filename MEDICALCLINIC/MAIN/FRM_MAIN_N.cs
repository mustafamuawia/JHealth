using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace MEDICALCLINIC.MAIN
{
    public partial class FRM_MAIN_N : Form
    {
        public FRM_MAIN_N()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            //Properties.Settings.Default.F_PROG = 0;
            //Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //(EndDate - StartDate).TotalDays
            LBLTIME.Text = DateTime.Now.ToString("hh:mm:ss tt");
            LBLDATE.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }



        System.Windows.Forms.Timer t = null;
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(timer1_Tick);
            t.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Properties.Settings.Default.F_PROG = 0;
            //Properties.Settings.Default.Save();
        }

        private void FRM_AMIN_Load(object sender, EventArgs e)
        {
           

            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            LBLUSERNAME.Text = CLS.USER_NAME;
            if (Properties.Settings.Default.TYPEACTIE== "Trial")
            {
                label1.Visible = true;
                label3.Visible = true;
                lbl_daytaial.Visible = true;
                lbl_daytaial.Text = ((Convert.ToDateTime(Properties.Settings.Default.ENDTRIALVER) - System.DateTime.Now).TotalDays.ToInt()).ToString();

            }

            if (Properties.Settings.Default.PROG_ID == 4)
            {
                BTN_G_CLINIC.Text = "عيادة الاسنان";
            }
            if (Properties.Settings.Default.PROG_ID == 3)
            {
                BTN_G_CLINIC.Text = "العيادة الطبية";
            }
        }

        
       
        private void BTN_RPT_Click(object sender, EventArgs e)
        {
            REPORT.FRM_ALL_RPT FRM = new REPORT.FRM_ALL_RPT(); FRM.ShowDialog();
            //PERSONS.FRM_PERSON FRM = new PERSONS.FRM_PERSON(); FRM.ShowDialog();
        }

        private void BTN_SAND_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_SANAD", null);
            //SANAD.FRM_SANAD FRM = new SANAD.FRM_SANAD();
            //FRM.ShowDialog();
        }

        private void BTN_SETTINGS_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_SANAD", null);
            //TOOTH_OP.FRM_TEETH FRM = new TOOTH_OP.FRM_TEETH();
            //FRM.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            SELAS.FRM_SEALS FRM = new SELAS.FRM_SEALS(DT,0);FRM.ShowDialog();
        }

        private void BTN_BOOKING_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_PERSON", null);
            //BOOKING.FRM_BOOKING FRM = new BOOKING.FRM_BOOKING();
            //FRM.ShowDialog();
            //PERSONS.FRM_PERSON FRM = new PERSONS.FRM_PERSON();
            //FRM.ShowDialog();

        }

        private void BTN_ACTIVE_BOOK_Click(object sender, EventArgs e)
        {
            BOOKING.FRM_ALLBOOK FRM = new BOOKING.FRM_ALLBOOK();
            FRM.ShowDialog();
        }

        private void BTN_TEETH_Click(object sender, EventArgs e)
        {
            TOOTH_OP.FRM_TEETH FRM = new TOOTH_OP.FRM_TEETH();
            FRM.ShowDialog();
        }

        //private void BTN_WAIT_SCREEN_Click(object sender, EventArgs e)
        //{
        //    DIAGNOSES.FRM_VIDEO_PLAYER FRM = new DIAGNOSES.FRM_VIDEO_PLAYER();
        //    FRM.ShowDialog();
        //}

       

        

        private void BTN_PURCHES_Click(object sender, EventArgs e)
        {
            PURCHES.FRM_PURCHERS FRM = new PURCHES.FRM_PURCHERS();FRM.ShowDialog();
        }

        private void BTN_G_CLINIC_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PROG_ID==3)
            {
                OpenFrm("FRM_CLINIC", null);
            }
         else
          if (Properties.Settings.Default.PROG_ID == 4)
            {
                OpenFrm("FRM_TEETH", null);
            }

           
            //CLINIC.FRM_CLINIC FRM = new CLINIC.FRM_CLINIC();
            //FRM.ShowDialog();

        }

        private void BTN_SETTING_Click(object sender, EventArgs e)
        {
            SETTING.FRM_ALL_SETTINGS FRM = new SETTING.FRM_ALL_SETTINGS();
            FRM.ShowDialog();
        }

        private void BTN_XRAY_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_RAYS", null);
           // XRAY.FRM_RAYS FRM = new XRAY.FRM_RAYS(); FRM.ShowDialog();
            // FRM_IMGE_PRSN FRM = new FRM_IMGE_PRSN();
            
        }

        private void BTN_FEATURE_BOOK_Click(object sender, EventArgs e)
        {
            BOOKING.FRM_FEATURE_BOOK FRM = new BOOKING.FRM_FEATURE_BOOK();
            FRM.ShowDialog();
        }

        private void BTN_CNG_USER_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FRM_LOGIN FRM = new FRM_LOGIN();
            Application.OpenForms["FRM_LOGIN"].Show();
            this.Close();
        }

        private void BTN_PERSON_Click(object sender, EventArgs e)
        {
            REPORT.FRM_PROFIT_CLONIC FRM = new REPORT.FRM_PROFIT_CLONIC();
            FRM.ShowDialog();
        }

        private void BTN_OP_PRICE_Click(object sender, EventArgs e)
        {

            ACCOUNT.FRM_ACCOUNT_CONT FRM = new ACCOUNT.FRM_ACCOUNT_CONT();
            FRM.ShowDialog();
        }

        //private void BTN_CAMERA_Click(object sender, EventArgs e)
        //{
        //    ADDPICT_GENE.FRM_ADD_PIC_NEW FRM = new ADDPICT_GENE.FRM_ADD_PIC_NEW();FRM.ShowDialog();
        //}

        private void label1_Click(object sender, EventArgs e)
        {
           HOSPITAL.FRM_H_GETBOOK FRM=new HOSPITAL.FRM_H_GETBOOK();FRM.ShowDialog();
        }

        private void BTN_LAB_Click(object sender, EventArgs e)
        {
            LAB.FRM_TESTLAB FRM = new LAB.FRM_TESTLAB();FRM.ShowDialog();
        }

        private void BTN_X_RAY_Click(object sender, EventArgs e)
        {
            XRAY.FRM_RAYS FRM = new XRAY.FRM_RAYS();FRM.ShowDialog();
        }

        private void BTN_WAIT_Click(object sender, EventArgs e)
        {

            DIAGNOSES.FRM_VIDEO_PLAYER FRM = new DIAGNOSES.FRM_VIDEO_PLAYER();
            FRM.Show();
        }

        private void BTN_LABO_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_TESTLAB", null);
           // LAB.FRM_TESTLAB FRM = new LAB.FRM_TESTLAB(); FRM.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SETTING.HOSPITALSETTING.FRM_ADD_BEDS FRM = new SETTING.HOSPITALSETTING.FRM_ADD_BEDS();
            FRM.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
            HOSPITAL.FRM_ALL_BED FRM = new HOSPITAL.FRM_ALL_BED(); FRM.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            HOSPITAL.FRM_DOCTOR_SCHEDULE FRM = new HOSPITAL.FRM_DOCTOR_SCHEDULE();
            FRM.ShowDialog();
        }

        private void BTN_ALLBED_Click(object sender, EventArgs e)
        {
            HOSPITAL.FRM_ALL_BED FRM = new HOSPITAL.FRM_ALL_BED(); FRM.ShowDialog();
        }

        private void BTN_SCHDUELDOCT_Click(object sender, EventArgs e)
        {
            HOSPITAL.FRM_DOCTOR_SCHEDULE FRM = new HOSPITAL.FRM_DOCTOR_SCHEDULE();
            FRM.ShowDialog();
        }

        private void BTN_GETH_BOOK_Click(object sender, EventArgs e)
        {
            HOSPITAL.FRM_H_GETBOOK FRM = new HOSPITAL.FRM_H_GETBOOK(); FRM.ShowDialog();
        }

        private void BTN_ADD_BED_Click(object sender, EventArgs e)
        {
 
           HOSPITAL.SETTING_H.FRM_G_SETTING FRM = new HOSPITAL.SETTING_H.FRM_G_SETTING();
            FRM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            REPORT.FRM_ADD_RPT_IMG_TBL FRM = new REPORT.FRM_ADD_RPT_IMG_TBL();FRM.ShowDialog();
        }

      
       
      
        FRM_MAIN_N frmmain = Application.OpenForms[nameof(MAIN.FRM_MAIN_N)] as MAIN.FRM_MAIN_N;
        public void OpenFrm(string FormName, string FormOpen = null)
        {
            // Check Is Form Open

            var IfOpen = Application.OpenForms[FormName];
            if (IfOpen != null)
            {
                IfOpen.Show();
                IfOpen.BringToFront();
                IfOpen.WindowState = FormWindowState.Normal;
                return;
            }

            var formInst = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == FormName);
            if (formInst != null)
            {
                if (CLS.Permessions!=null)
                {

                
                var frm = Activator.CreateInstance(formInst) as Form;


                for (int i = 0; i < CLS.Permessions.Rows.Count; i++)
                {
                    if (CLS.Permessions.Rows[i][1].ToString() == FormName)
                    {
                        if ((bool)CLS.Permessions.Rows[i][4] == true)
                        {
                            frm.Owner = frmmain;
                            frm.Show();
                            break;

                        }
                        else
                        {
                            MessageBox.Show("عذرا لا تملك صلاحية الدخول");
                        }
                    }
                }


            }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CLINIC.Chatter_chat1 FRM = new CLINIC.Chatter_chat1();
            FRM.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_minmize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SETTING.FRM_PROGRAM_SETTING frm = new SETTING.FRM_PROGRAM_SETTING();
            frm.ShowDialog();
        }

        private void lbl_backup_Click(object sender, EventArgs e)
        {
            DB_CONFIG.FRM_BACKUP frm = new DB_CONFIG.FRM_BACKUP();
            frm.ShowDialog();
        }
    }
}
