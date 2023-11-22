using MEDICALCLINIC.MAIN;
using MEDICALCLINIC.REPORT;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.LAB
{
    public partial class FRM_SETTING_LAB : Form
    {

        public FRM_SETTING_LAB()
        {
            InitializeComponent();

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (CLS.Permessions != null)
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

        private void BTN_DEP_Click(object sender, EventArgs e)
        {
           // OpenFrm("FRM_L_CATEG", null);

            LAB.FRM_L_CATEG FRM = new FRM_L_CATEG(); FRM.ShowDialog();
        }

        private void BTN_FLOOR_Click(object sender, EventArgs e)
        {
           // OpenFrm("FRM_L_TESTNAME", null);
            LAB.FRM_L_TESTNAME FRM = new FRM_L_TESTNAME(); FRM.ShowDialog();
        }

        private void BTN_ROOM_Click(object sender, EventArgs e)
        {
            //OpenFrm("FRM_L_UNIT", null);
            LAB.FRM_L_UNIT FRM = new FRM_L_UNIT();
            FRM.ShowDialog();
        }

        private void BTN_BED_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_LAB_NAME", null);
            //LAB.FRM_LAB_NAME FRM = new LAB.FRM_LAB_NAME();
            //FRM.ShowDialog();
        }

       

        private void BTN_COLSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_USER_Click(object sender, EventArgs e)
        {

            LAB.FRM_USERS_CONT FRM = new LAB.FRM_USERS_CONT();
            FRM.ShowDialog();
        }

        private void BTN_PERSON_Click(object sender, EventArgs e)
        { 
            OpenFrm("FRM_H_PERSON", null);
            //PERSONS.FRM_PERSON FRM = new PERSONS.FRM_PERSON();
            //FRM.ShowDialog();
        }

        private void BTN_DOCTOR_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_DOCTOR", null);
            //DOCTOR.FRM_DOCTOR FRM = new DOCTOR.FRM_DOCTOR();
            //FRM.ShowDialog();
        }

        private void BTN_COMB_FD_Click(object sender, EventArgs e)
        {
          //  OpenFrm("FRM_LIST_PRINTER", null);
            SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
            FRM.ShowDialog();
        }

        private void BTN_EMP_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_EMP", null);
            //SETTING.FRM_EMP FRM = new SETTING.FRM_EMP();
            //FRM.ShowDialog();
        }

        private void BTN_RPTIMG_Click(object sender, EventArgs e)
        {
            //OpenFrm("FRM_ADD_RPT_IMG_TBL", null);
            FRM_ADD_RPT_IMG_TBL frm = new FRM_ADD_RPT_IMG_TBL(); frm.ShowDialog();
        }

        private void BTN_ERRAD_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_INCOMING", null);
        }

        private void BTN_EXPONSE_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_EXPENSES", null);
        }
    }
}
