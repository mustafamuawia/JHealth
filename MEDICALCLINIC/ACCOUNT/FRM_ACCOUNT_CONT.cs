using MEDICALCLINIC.MAIN;
using MEDICALCLINIC.REPORT;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.ACCOUNT
{
    public partial class FRM_ACCOUNT_CONT : Form
    {
        public FRM_ACCOUNT_CONT()
        {
            InitializeComponent();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_DEBT_PERSON_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_CUSTOMER_DEBIT", null);
            //ACCOUNT.FRM_CUSTOMER_DEBIT FRM = new FRM_CUSTOMER_DEBIT();
            //FRM.ShowDialog();
        }

        private void BTN_DEBIT_DR_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_DOCTORT_DEBIT_CLINIC", null);
            //FRM_DOCTORT_DEBIT_CLINIC FRM = new FRM_DOCTORT_DEBIT_CLINIC();
            //FRM.ShowDialog();
        }

        private void BTN_SANAD_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_ALLUSERS_DEBIT_FOR_DR", null);
            //SANAD.FRM_SANAD FRM = new SANAD.FRM_SANAD();FRM.ShowDialog();
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

        private void BTN_COST_CENTER_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_PROFIT_CLONIC", null);
             
        }
    }
}
