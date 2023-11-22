using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.SETTING_H
{
    public partial class FRM_G_SETTING : Form
    {

        public FRM_G_SETTING()
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





        private void BTN_DEP_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_H_SETTINH  FRM = new HOSPITAL.SETTING_H.FRM_H_SETTINH();
            FRM.ShowDialog();
        }

        private void BTN_FLOOR_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_H_EMP_SETTING FRM = new HOSPITAL.SETTING_H.FRM_H_EMP_SETTING();
            FRM.ShowDialog();
        }

        private void BTN_ROOM_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_ADD_ROOM FRM = new HOSPITAL.SETTING_H.FRM_ADD_ROOM();
            FRM.ShowDialog();
        }

        private void BTN_BED_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_SETTING_OP_DIS FRM = new HOSPITAL.SETTING_H.FRM_SETTING_OP_DIS();
            FRM.ShowDialog();
        }

        private void BTN_COMB_FD_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_COMB_SUBD_FLOOR FRM = new HOSPITAL.SETTING_H.FRM_COMB_SUBD_FLOOR();
            FRM.ShowDialog();
        }

        private void BTN_COLSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LAB.FRM_SETTING_LAB FRM = new LAB.FRM_SETTING_LAB();
            FRM.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XRAY.FRM_SETTING_XRAY FRM = new XRAY.FRM_SETTING_XRAY();
            FRM.ShowDialog();

        }

        private void BTN_ACCOUNT_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_ACCOUNT_SETTING FRM = new FRM_ACCOUNT_SETTING();
            FRM.ShowDialog();
        }

        private void BTN_S_DR_Click(object sender, EventArgs e)
        {
            //OpenFrm("FRM_SETTING_DR", null);
            DOCTOR.FRM_SETTING_DR FRM = new DOCTOR.FRM_SETTING_DR();
            FRM.ShowDialog();
        }

        private void BTN_AUTH_Click(object sender, EventArgs e)
        {
            LAB.FRM_USERS_CONT FRM = new LAB.FRM_USERS_CONT();
            FRM.ShowDialog();
            //else
            //{
            // OpenFrm("FRM_ADD_NEWROLE", null);
            //}
          
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



    }
}
