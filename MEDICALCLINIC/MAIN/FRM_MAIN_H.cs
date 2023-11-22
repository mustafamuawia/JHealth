using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace MEDICALCLINIC.MAIN
{
    public partial class FRM_MAIN_H : Form
    {
        public FRM_MAIN_H()
        {
            InitializeComponent();
            timer1.Start();
        }


        FRM_MAIN_H frmmain = Application.OpenForms[nameof(MAIN.FRM_MAIN_H)] as MAIN.FRM_MAIN_H;

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

                //if (Info.PermessionsList.Any(x => x.FormsName.FormName == frm.Name && x.Value == true))
                //{
                //    //var btn = Helper.GetAll(frm, typeof(GreenButton)).Where(x => x.Name != "btnCloseForms");
                //    //var grid = Helper.GetAll(frm, typeof(DataGridView));
                //    //foreach (var item in btn)
                //    //{
                //    //    if (Info.PermessionsList.Any(x => x.FormsName.ControlType == item.GetType().Name.ToString() && x.FormsName.FormName == frm.Name && x.FormsName.ControlName == item.Name && x.Value == true))
                //    //        item.Enabled = true;
                //    //    else
                //    //        item.Enabled = false;
                //    //}
                //    //foreach (DataGridView item in grid)
                //    //{
                //    //    foreach (var col in item.Columns)
                //    //    {
                //    //        if (col is DataGridViewImageColumn)
                //    //        {
                //    //            DataGridViewImageColumn d = col as DataGridViewImageColumn;
                //    //            if (Info.PermessionsList.Any(x => x.FormsName.ControlType == item.GetType().Name.ToString() && x.FormsName.FormName == frm.Name && x.FormsName.ControlName == item.Name && x.FormsName.ControlText == d.HeaderText && x.Value == true))
                //    //                d.Visible = true;
                //    //            else
                //    //                d.Visible = false;
                //    //        }

                //    //    }

                //    //}
                //    //frm.Tag = Info.PermessionsList.FirstOrDefault(x => x.FormsName.FormName == frm.Name && x.Value == true).FormsNameId;
                //    if (FormOpen == null)
                //    {
                //        var frmmain = Application.OpenForms[nameof(MAIN.FRM_MAIN_H)] as MAIN.FRM_MAIN_H;
                //        frm.Owner = frmmain;
                //        frm.Show();
                //    }
                //    else
                //    {
                //        var frmmain = Application.OpenForms[FormOpen] as Form;
                //        frm.Owner = frmmain;
                //        frm.Show();
                //    }


                //    //Session. UnitOfWork = new UnitOfWork();
                //}
                //else
                //{
                //MessageBox.Show("", "No Have Permassion !! ");
                //}

            }
        }

    
        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            //Properties.Settings.Default.F_PROG = 0;
            //Properties.Settings.Default.Save();
            Application.Exit();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBLTIME.Text = DateTime.Now.ToString("HH:mm:ss");
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
        
            //Properties.Settings.Default.F_PROG = 0;
            //Properties.Settings.Default.Save();
            Application.Exit();
            
        }

        private void FRM_AMIN_Load(object sender, EventArgs e)
        {
            

            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            LBLUSERNAME.Text = CLS.USER_NAME;
            if (Properties.Settings.Default.TYPEACTIE == "Trial")
            {
                label1.Visible = true;
                label3.Visible = true;
                lbl_daytaial.Visible = true;
                lbl_daytaial.Text = ((Convert.ToDateTime(Properties.Settings.Default.ENDTRIALVER) - System.DateTime.Now).TotalDays.ToInt()).ToString();

            }
        }



        private void BTN_RPT_Click(object sender, EventArgs e)
        {
            REPORT.FRM_ALL_RPT FRM = new REPORT.FRM_ALL_RPT(); FRM.ShowDialog();
        }

        private void BTN_SAND_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_SANAD", null);
        }

        private void OpenFormPermessions(string formName)
        {
            var formInst = System.Reflection.Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == formName);
            var frm = Activator.CreateInstance(formInst) as Form;
            this.gET_permession_formTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_permession_form, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            DataTable dt = new DataTable();
            dt = this.mEDICAL_CLINIC_DBDataSet.GET_permession_form;
            var PermessionList = dt.AsEnumerable().Select(x => new
            {
                FormName = x.Field<string>("FormName"),
                ControlType = x.Field<string>("ControlType"),
                ControlName = x.Field<string>("ControlName"),
                Value = x.Field<bool>("Value"),
            }).ToList();
            if (PermessionList.Any(x => x.FormName == frm.Name && x.Value == true))
            {
                var btn = GetAll(frm, typeof(Button));
                foreach (var item in btn)
                {
                    if (PermessionList.Any(x => x.ControlType == item.GetType().Name.ToString() && x.FormName == frm.Name && x.ControlName == item.Name && x.Value == true))
                        item.Enabled = true;
                    else
                        item.Enabled = false;
                }
                frm.Show();
            }
        }

        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        private void BTN_SETTINGS_Click(object sender, EventArgs e)
        {
            HOSPITAL.FRM_DOCTOR_SCHEDULE FRM = new HOSPITAL.FRM_DOCTOR_SCHEDULE();
            FRM.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            USERSE.FRM_USERS frm = new USERSE.FRM_USERS();
            frm.ShowDialog();
        }

        private void BTN_BOOKING_Click(object sender, EventArgs e)
        {
            USERSE.FRM_USERS FRM = new USERSE.FRM_USERS();
            FRM.ShowDialog();

        }

        private void BTN_ACTIVE_BOOK_Click(object sender, EventArgs e)
        {
            SETTING.FRM_EMP FRM = new SETTING.FRM_EMP();
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
            //OpenFrm("FRM_EMP", null);
            SETTING.FRM_EMP FRM = new SETTING.FRM_EMP();
            FRM.ShowDialog();
            //  PURCHES.FRM_PURCHERS FRM = new PURCHES.FRM_PURCHERS(); FRM.ShowDialog();
        }

        private void BTN_G_CLINIC_Click(object sender, EventArgs e)
        {
            HOSPITAL.FRM_H_GETBOOK FRM = new HOSPITAL.FRM_H_GETBOOK();
            //FRM__CLINC_DIAGNOSES FRM = new FRM__CLINC_DIAGNOSES();
            FRM.ShowDialog();

        }

        private void BTN_SETTING_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_G_SETTING FRM = new HOSPITAL.SETTING_H.FRM_G_SETTING();
            FRM.ShowDialog();
        }

        private void BTN_XRAY_Click(object sender, EventArgs e)
        {
            LAB.FRM_TESTLAB FRM = new LAB.FRM_TESTLAB(); FRM.ShowDialog();
            // FRM_IMGE_PRSN FRM = new FRM_IMGE_PRSN();

        }

        private void BTN_FEATURE_BOOK_Click(object sender, EventArgs e)
        {
            //BOOKING.FRM_FEATURE_BOOK FRM = new BOOKING.FRM_FEATURE_BOOK();
            //FRM.ShowDialog();
            DOCTOR.FRM_DOCTOR FRM = new DOCTOR.FRM_DOCTOR();

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
            DOCTOR.FRM_DOCTOR FRM = new DOCTOR.FRM_DOCTOR();
            FRM.ShowDialog();
        }

        private void BTN_OP_PRICE_Click(object sender, EventArgs e)
        {
            //HOSPITAL.REPORTS.FRM_DOCTORS_DEBIT FRM = new HOSPITAL.REPORTS.FRM_DOCTORS_DEBIT();
            //FRM.ShowDialog();

            HOSPITAL.ACCOUNTANT.FRM_ACCOUNT_PAY FRM = new HOSPITAL.ACCOUNTANT.FRM_ACCOUNT_PAY();
            FRM.ShowDialog();
        }

        //private void BTN_CAMERA_Click(object sender, EventArgs e)
        //{
        //    ADDPICT_GENE.FRM_ADD_PIC_NEW FRM = new ADDPICT_GENE.FRM_ADD_PIC_NEW();FRM.ShowDialog();
        //}

        private void label1_Click(object sender, EventArgs e)
        {
            HOSPITAL.FRM_H_GETBOOK FRM = new HOSPITAL.FRM_H_GETBOOK(); FRM.ShowDialog();
        }

        private void BTN_LAB_Click(object sender, EventArgs e)
        {
            LAB.FRM_TESTLAB FRM = new LAB.FRM_TESTLAB(); FRM.ShowDialog();
        }

        private void BTN_X_RAY_Click(object sender, EventArgs e)
        {
            XRAY.FRM_RAYS FRM = new XRAY.FRM_RAYS(); FRM.ShowDialog();
        }

        private void BTN_WAIT_Click(object sender, EventArgs e)
        {

            HOSPITAL.SETTING_H.FRM_G_SETTING FRM = new HOSPITAL.SETTING_H.FRM_G_SETTING();
            FRM.ShowDialog();
        }

        private void BTN_LABO_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_RAYS", null);
           // XRAY.FRM_RAYS FRM = new XRAY.FRM_RAYS(); FRM.ShowDialog();
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
            REPORT.FRM_ADD_RPT_IMG_TBL FRM = new REPORT.FRM_ADD_RPT_IMG_TBL(); FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///  REPORT.FRM_RPT_IMG_LAB_TBL FRM = new REPORT.FRM_RPT_IMG_LAB_TBL(); FRM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_SUB_DEPART FRM = new HOSPITAL.SETTING_H.FRM_SUB_DEPART();
            FRM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_ADD_FLOOR FRM = new HOSPITAL.SETTING_H.FRM_ADD_FLOOR();
            FRM.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_COMB_SUBD_FLOOR FRM = new HOSPITAL.SETTING_H.FRM_COMB_SUBD_FLOOR();
            FRM.ShowDialog();
        }

       

        private void button12_Click_1(object sender, EventArgs e)
        {
            HOSPITAL.OPERA.FRM_SHOW_PERSONINFO FRM = new HOSPITAL.OPERA.FRM_SHOW_PERSONINFO();

            FRM.ShowDialog();
            //HOSPITAL.FRM_DOCTOR_SCHEDULE FRM = new HOSPITAL.FRM_DOCTOR_SCHEDULE();

            //FRM.ShowDialog();
        }

        private void BTN_BOOKING_Click_1(object sender, EventArgs e)
        {
            OpenFrm("FRM_ADD", null);
            
           // HOSPITAL.FRM_ADD FRM = new HOSPITAL.FRM_ADD();
           // FRM.ShowDialog();
        }

        private void BTN_LABREQ_Click(object sender, EventArgs e)
        {
            LAB.FRM_SEND_TO_LABTEST FRM = new LAB.FRM_SEND_TO_LABTEST(-1, -1);
            FRM.Show();
        }

        private void BTN_SERVICES_Click(object sender, EventArgs e)
        {
            //OpenFrm("FRM_DOCTOR_SCHEDULE", null);
            DIAGNOSES.FRM_VIDEO_PLAYER FRM = new DIAGNOSES.FRM_VIDEO_PLAYER();
            FRM.Show();

        }

        private void BTN_OPERATION_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_SETTING_OP_DIS FRM = new HOSPITAL.SETTING_H.FRM_SETTING_OP_DIS();
            FRM.ShowDialog();
        }

        private void BTN_XRAYRQE_Click(object sender, EventArgs e)
        {
            XRAY.FRM_REQUEST_XRAY frm = new XRAY.FRM_REQUEST_XRAY(0, 0, 0); frm.ShowDialog();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_permession_formTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_permession_form, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CLINIC.Chatter_chat1 FRM = new CLINIC.Chatter_chat1();
            FRM.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            PERSONS.FRM_PERSON FRM = new PERSONS.FRM_PERSON();FRM.ShowDialog();
        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {
            HOSPITAL.FRM_ALL_BED frm = new HOSPITAL.FRM_ALL_BED();
            frm.ShowDialog();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString);
        }

       
    }
}
public class Permessions
{
    public int id { get; set; }
    public int GroupRolsId { get; set; }
    public int FormsNameId { get; set; }
    public bool Value { get; set; }

}