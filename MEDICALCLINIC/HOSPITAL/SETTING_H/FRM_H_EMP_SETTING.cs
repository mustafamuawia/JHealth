using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.SETTING_H
{
    public partial class FRM_H_EMP_SETTING : Form
    {

        public FRM_H_EMP_SETTING()
        {
            InitializeComponent();

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
            OpenFrm("FRM_EMP", null);
            //SETTING.FRM_EMP FRM = new SETTING.FRM_EMP();
            //FRM.ShowDialog();
        }

        private void BTN_FLOOR_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_SERVICES", null);
            //HOSPITAL.SETTING_H.FRM_SERVICES FRM = new HOSPITAL.SETTING_H.FRM_SERVICES();
            //FRM.ShowDialog();
        }

       

        private void BTN_BED_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_INCOMING", null);
            //SETTING.FRM_INCOMING FRM = new SETTING.FRM_INCOMING();
            //FRM.ShowDialog();
        }

        private void BTN_COMB_FD_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_EXPENSES", null);
            //SETTING.FRM_EXPENSES FRM = new SETTING.FRM_EXPENSES();
            //FRM.ShowDialog();
        }

        private void BTN_COLSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
