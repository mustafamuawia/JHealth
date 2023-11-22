using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.XRAY
{
    public partial class FRM_SETTING_XRAY : Form
    {

        public FRM_SETTING_XRAY()
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
            OpenFrm("FRM_ADD_ROOMNAME", null);
            //XRAY.FRM_ADD_ROOMNAME FRM = new FRM_ADD_ROOMNAME();
            //FRM.ShowDialog();
        }

        private void BTN_FLOOR_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_ADD_RAYNAME", null);
            //XRAY.FRM_ADD_RAYNAME FRM = new FRM_ADD_RAYNAME();
            //FRM.ShowDialog();
        }

      
        

       

        private void BTN_COLSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
