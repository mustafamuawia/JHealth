using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_ITEMS_STTING : Form
    {
        public FRM_ITEMS_STTING()
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
            OpenFrm("FRM_ITEM", null);

            //SETTING.FRM_ITEM FRM = new FRM_ITEM();
            //FRM.ShowDialog();
        }
 

         
        private void BTN_CATEGORIS_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_CATEGORIS", null);
            //SETTING.FRM_CATEGORIS FRM = new FRM_CATEGORIS();
            //FRM.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_STORE_Click(object sender, EventArgs e)
        {
        
            //OpenFrm("FRM_CATEGORIS", null);
        }
    }
}
