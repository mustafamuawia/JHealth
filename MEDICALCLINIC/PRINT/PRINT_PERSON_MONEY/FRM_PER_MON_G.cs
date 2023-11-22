using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT.PRINT_PERSON_MONEY
{
    public partial class FRM_PER_MON_G : Form
    {
        public FRM_PER_MON_G()
        {
            InitializeComponent();
        }

        private void FRM_PER_MON_G_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_PERSON_MONEY_AVAL_P' table. You can move, or remove it, as needed.
            this.p_GET_PERSON_MONEY_AVAL_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PERSON_MONEY_AVAL_P, CLS.PER_RPT_F, CLS.USER_CODE);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_PERSON_MONEY_AVAL_R' table. You can move, or remove it, as needed.
            //this.p_GET_PERSON_MONEY_AVAL_RTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PERSON_MONEY_AVAL_R,CLS .PER_RPT_F ,CLS .DOCTOR_CODE_GENE );

            this.reportViewer1.RefreshReport();
        }
    }
}
