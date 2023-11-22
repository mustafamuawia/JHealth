using MEDICALCLINIC.MAIN;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_CLINIC_SETTINGS : Form
    {
        public FRM_CLINIC_SETTINGS()
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
            OpenFrm("FRM_BOOK_TYPE", null);
            //SETTING.FRM_BOOK_TYPE FRM = new FRM_BOOK_TYPE();
            //FRM.ShowDialog();
        }

        private void BTN_UNITS_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_STATE", null);
            //SETTING.FRM_STATE FRM = new FRM_STATE();
            //FRM.ShowDialog();
        }

   
        private void BTN_DRAGE_GROUP_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_GROUP_DRAG", null);
            //SETTING.FRM_GROUP_DRAG FRM = new SETTING.FRM_GROUP_DRAG();
            //FRM.ShowDialog();
        }

        private void BTN_DRAGE_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_DRAGE", null);

            //SETTING.FRM_DRAGE FRM = new FRM_DRAGE();
            //FRM.ShowDialog();
        }

        private void BTN_OPERATION_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_DESC", null);
            //SETTING.FRM_DESC frm = new FRM_DESC();
            //frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_OPERATIONCATEG_Click(object sender, EventArgs e)
        {

            OpenFrm("FRM_ADD_OPERATION_CATEG", null);
        }

        private void T_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_categ_op_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_H_CATEG", null);
        }

        private void btn_item_op_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_H_ITEM", null);
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
