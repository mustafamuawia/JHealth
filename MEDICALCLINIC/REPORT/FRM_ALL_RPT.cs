using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_ALL_RPT : Form
    {
        private Form frmmain;

        public FRM_ALL_RPT()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_RPTBOX_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_RPT_BOX_CASH", null);
        }
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
        private void BTN_CLINIC_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_ALL_BOOKING_BYDR", null);
        }

        private void BTN_DENTALCLINIC_Click(object sender, EventArgs e)
        {
            //FRM_R_TOOTH FRM = new FRM_R_TOOTH();FRM.ShowDialog();
            OpenFrm("FRM_ALL_BOOKING_BYPERSON", null);
        }

        private void BTN_BORROW_Click(object sender, EventArgs e)
        {
           FRM_PROFIT_CLONIC FRM = new FRM_PROFIT_CLONIC();FRM.ShowDialog();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CUSTOMERS_Click(object sender, EventArgs e)
        {

            OpenFrm("FRM_KSHIF_HISAB_MASRIF", null);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            LAB.REPORT.FRM_RPT_ALL_DAILYTEST frm = new LAB.REPORT.FRM_RPT_ALL_DAILYTEST();
            frm.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            XRAY.REPORT.FRM_XRAY_REPORT FRM = new XRAY.REPORT.FRM_XRAY_REPORT();
            FRM.ShowDialog();
        }

        private void BTN_PROVIDER_Click(object sender, EventArgs e)
        {
            HOSPITAL.REPORTS.FRM_OP_REPORT FRM = new HOSPITAL.REPORTS.FRM_OP_REPORT();
            FRM.ShowDialog();
        }

        private void BTN_RPT_EXPENSES_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_RPT_EXPENSES", null);
        }

        private void BTN_RPT_SEALS_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_RPT_SEALS", null);
        }

        private void BTN_RPT_OPERATION_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_RPT_ALL_OPERATION", null);
        }
    }
}
