using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.DB_CONFIG
{
    public partial class FRM_CONTAIN_BUP : Form
    {
        public FRM_CONTAIN_BUP()
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
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_BACKUP", null);
            //DB_CONFIG.FRM_BACKUP FRM = new FRM_BACKUP();
            //FRM.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_RESTORE_BAKUP", null);
            //DB_CONFIG.FRM_RESTORE_BAKUP FRM = new FRM_RESTORE_BAKUP();
            //FRM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
