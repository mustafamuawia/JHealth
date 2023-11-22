using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_DENTAL_SETTINGS : Form
    {
        public FRM_DENTAL_SETTINGS()
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

        private void BTN_STORE_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_DISEASE", null);
            //SETTING.FRM_DISEASE FRM = new FRM_DISEASE();
            //FRM.ShowDialog();
        }

        private void BTN_UNIT_GRP_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_CLASS_TOOTH", null);
            //TOOTH_OP.FRM_CLASS_TOOTH frm = new TOOTH_OP.FRM_CLASS_TOOTH();
            //frm.ShowDialog();
        }

        private void BTN_UNITS_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_TREATMENT_TOOTH", null);
            //TOOTH_OP.FRM_TREATMENT_TOOTH frm = new TOOTH_OP.FRM_TREATMENT_TOOTH();
            //frm.ShowDialog();
        }


        private void BTN_DRAGE_GROUP_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_GROUP_DRAG", null);
            //SETTING.FRM_GROUP_DRAG FRM = new SETTING.FRM_GROUP_DRAG();
            //FRM.ShowDialog();
        }

        private void BTN_DRAGE_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_DRAG_TOOTH", null);
            //FRM_DRAG_TOOTH FRM = new FRM_DRAG_TOOTH();
            //FRM.ShowDialog();
        }

        private void BTN_OPERATION_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_GROUP_DRAG", null);
            //SETTING.FRM_GROUP_DRAG FRM = new SETTING.FRM_GROUP_DRAG();
            //FRM.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
