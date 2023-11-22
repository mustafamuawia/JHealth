using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_DOCTOR_SETTINGS : Form
    {
        public FRM_DOCTOR_SETTINGS()
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




        private void BTN_DRAGE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_MAJOR_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_MAJOR", null);
            //SETTING.FRM_MAJOR FRM = new FRM_MAJOR();
            //FRM.ShowDialog();
        }

        private void BTN_SPE_MAJOR_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_MAJOR_DETAILS", null);
            //FRM_MAJOR_DETAILS FRM = new FRM_MAJOR_DETAILS();FRM.ShowDialog();
        }

        private void BTN_DOCTOR_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_DOCTOR", null);
            //DOCTOR.FRM_DOCTOR FRM = new DOCTOR.FRM_DOCTOR();FRM.ShowDialog();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_GRP_DR_Click(object sender, EventArgs e)
        { 
            OpenFrm("FRM_DR_GROUP", null);
        }
    }
}
