using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_GENERAL_SETTINGS : Form
    {
        public FRM_GENERAL_SETTINGS()
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



       

        private void BTN_USERS_Click(object sender, EventArgs e)
        {
            if (CLS.USER_CODE == 0)
            {
                USERSE.FRM_USERS FRM = new USERSE.FRM_USERS();
                FRM.ShowDialog();
            }
            else
                OpenFrm("FRM_USERS", null);
            //USERSE.FRM_USERS FRM = new USERSE.FRM_USERS();
            //FRM.ShowDialog();
        }

        private void BTN_PROVIDER_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_CLIENT", null);
            //SETTING.FRM_CLIENT frm = new FRM_CLIENT();
            //frm.ShowDialog();
        }

        private void BTN_SERVER_Click(object sender, EventArgs e)
        {
            if (CLS.USER_CODE == 0)
            {
               DB_CONFIG.FRM_DB FRM = new DB_CONFIG.FRM_DB();
                FRM.ShowDialog();
            }
            else
                OpenFrm("FRM_DB", null);
           // DB_CONFIG.FRM_DB FRM = new DB_CONFIG.FRM_DB();FRM.ShowDialog();
        }

        private void PRINTER_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_LIST_PRINTER", null);
            //FRM_LIST_PRINTER FRM = new FRM_LIST_PRINTER();
            //FRM.ShowDialog();
        }

        private void BTN_BACKUP_Click(object sender, EventArgs e)
        {
            //OpenFrm("FRM_CONTAIN_BUP", null);
            DB_CONFIG.FRM_CONTAIN_BUP FRM = new DB_CONFIG.FRM_CONTAIN_BUP();
            FRM.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_USERLEVEL_Click(object sender, EventArgs e)
        {
            if (CLS.USER_CODE==0)
            {
                USERSE.FRM_ADD_NEWROLE FRM = new USERSE.FRM_ADD_NEWROLE();
                FRM.ShowDialog();
            }
            else
            OpenFrm("FRM_ADD_NEWROLE", null);
           
        }

        private void BTN_RPTIMG_Click(object sender, EventArgs e)
        { 
            OpenFrm("FRM_ADD_RPT_IMG_TBL", null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CLS.USER_CODE == 0)
            {
                SETTING.FRM_EMP FRM = new SETTING.FRM_EMP();
                FRM.ShowDialog();
            }
            else
                OpenFrm("FRM_EMP", null);
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_PROGRAM_SETTING", null);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SANAD.FRM_COST_CENTER FRM = new SANAD.FRM_COST_CENTER();
            FRM.ShowDialog();
        }
    }
}
