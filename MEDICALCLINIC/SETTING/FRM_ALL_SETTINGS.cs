using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_ALL_SETTINGS : Form
    {
        public FRM_ALL_SETTINGS()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_BOXS_Click(object sender, EventArgs e)
        {
            FRM_BOX_SETTING FRM = new FRM_BOX_SETTING();FRM.ShowDialog();
        }

        private void BTN_GENERAL_Click(object sender, EventArgs e)
        {
            FRM_GENERAL_SETTINGS FRM = new FRM_GENERAL_SETTINGS();FRM.ShowDialog();

        }

        private void BTN_CLINIC_Click(object sender, EventArgs e)
        {
            FRM_CLINIC_SETTINGS FRM = new FRM_CLINIC_SETTINGS();FRM.ShowDialog();
        }

        private void BTN_DENTAL_Click(object sender, EventArgs e)
        {
            FRM_DENTAL_SETTINGS FRM = new FRM_DENTAL_SETTINGS();FRM.ShowDialog();
        }

        private void BTN_DOCTOR_GENERAL_Click(object sender, EventArgs e)
        {
            FRM_DOCTOR_SETTINGS FRM = new FRM_DOCTOR_SETTINGS();FRM.ShowDialog();
        }

        private void BTN_DOCTOR_DENTAL_Click(object sender, EventArgs e)
        {
             XRAY.FRM_SETTING_XRAY FRM = new XRAY.FRM_SETTING_XRAY();FRM.ShowDialog();
           
        }

        private void BTN_ITEM_SETTING_Click(object sender, EventArgs e)
        {
            FRM_ITEMS_STTING FRM = new FRM_ITEMS_STTING(); FRM.ShowDialog();
        }

        private void BTN_LAB_Click(object sender, EventArgs e)
        {
            LAB.FRM_SETTING_LAB FRM=new LAB.FRM_SETTING_LAB();FRM.ShowDialog();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_WHO_DELETE_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_WHODELDTE_BOOK", null);
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
