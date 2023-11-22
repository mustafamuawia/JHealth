using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.SETTING_H
{
    public partial class FRM_SETTING_OP_DIS : Form
    {

        public FRM_SETTING_OP_DIS()
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
            OpenFrm("FRM_DISEASE", null);
            //SETTING.FRM_DISEASE FRM = new SETTING.FRM_DISEASE();
            //FRM.ShowDialog();
        }

        private void BTN_FLOOR_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_BOOK_TYPE", null);
            //SETTING.FRM_BOOK_TYPE FRM = new SETTING.FRM_BOOK_TYPE();
            //FRM.ShowDialog();
        }

     

         

        private void BTN_COLSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_DESC", null);
            //SETTING.FRM_DESC FRM = new SETTING.FRM_DESC();FRM.ShowDialog();
        }
       
        private void BTN_TYP_OP_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_ADD_TYP_OP", null);
            //HOSPITAL.SETTING_H.FRM_ADD_TYP_OP FRM = new FRM_ADD_TYP_OP();
            //FRM.ShowDialog();
        }

        private void BTN_CATEG_OP_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_ADD_OPERATION_CATEG", null);
            //HOSPITAL.SETTING_H.FRM_ADD_OPERATION_CATEG FRM = new FRM_ADD_OPERATION_CATEG();
            //FRM.ShowDialog();
        }

        private void BTN_GRUP_ITEM_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_H_CATEG", null);
            //HOSPITAL.SETTING_H.FRM_H_CATEG FRM = new FRM_H_CATEG();
            //FRM.ShowDialog();
        }

        private void BTN_ITEMS_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_H_ITEM", null);
            //HOSPITAL.SETTING_H.FRM_H_ITEM FRM = new FRM_H_ITEM();
            //FRM.ShowDialog();
        }
    }
}
