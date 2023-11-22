using System;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.DB_CONFIG
{
    public partial class FRM_TRAIL_VERSION :MEDICALCLINIC. SETTING.BASEANYFORM
    {
        public FRM_TRAIL_VERSION()
        {
            InitializeComponent();
        }

        private void FRM_TRAIL_VERSION_Load(object sender, EventArgs e)
        {
            txtProductid.Text = ComputerInfo.ProductId();
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            KeyManger km = new KeyManger(txtProductid.Text);
            if (km.Valid(txtLice.Text, 1))
            {
                // MessageBox.Show("ok");
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                INSERTED.P_INSERT_T_LIY(

                      txtLice.Text
                    , 1
                    , txtProductid.Text
                    , ref CLS.SUBMIT_FLAG);
                LBL_MSGGGG.ForeColor = Color.Green;
                LBL_MSGGGG.Text = "تم تفعيل البرنامج بنجاح";
                //تم تفعيل البرنامج بنجاح 
            }
            else
            {
                LBL_MSGGGG.Text = "كود التفعيل غير صحيح";
                LBL_MSGGGG.Text = "كود التفعيل غير صحيح";
                LBL_MSGGGG.Text = "كود التفعيل غير صحيح";
                Application.Exit();
            }
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_COPY_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtProductid.Text);
        }

        private void BTN_PASTE_Click(object sender, EventArgs e)
        {
            txtLice.Text = Clipboard.GetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
