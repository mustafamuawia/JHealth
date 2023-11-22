using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.LAB

{
    public partial class FRM_USERS_CONT : Form
    {
        public FRM_USERS_CONT()
        {
            InitializeComponent();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      //  OpenFrm("FRM_CUSTOMER_DEBIT", null);
        

      
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

        private void BTN_AUTH_Click(object sender, EventArgs e)
        {
            if (CLS.USER_CODE==0)
            {
                USERSE.FRM_ADD_NEWROLE FRM = new USERSE.FRM_ADD_NEWROLE();
                FRM.ShowDialog();
            }
            else
            OpenFrm("FRM_ADD_NEWROLE", null);
        }

        private void BTN_EMP_Click(object sender, EventArgs e)
        {

            if (CLS.USER_CODE == 0)
            {
               SETTING.FRM_EMP FRM = new SETTING.FRM_EMP();
                FRM.ShowDialog();
            }
            else
            OpenFrm("FRM_EMP", null);
        }

        private void BTN_USERS_Click(object sender, EventArgs e)
        {

            if (CLS.USER_CODE == 0)
            {
                USERSE.FRM_USERS FRM = new USERSE.FRM_USERS();
                FRM.ShowDialog();
            }
            else
            OpenFrm("FRM_USERS", null);
        }
    }
}
