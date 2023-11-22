using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT.PRINT_MONEY
{
    public partial class FRM_MOEY_G : Form
    {
        public FRM_MOEY_G()
        {
            InitializeComponent();
        }

        private void FRM_MOEY_G_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_MONEY_AVAL_R' table. You can move, or remove it, as needed.
            this.p_GET_MONEY_AVAL_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_MONEY_AVAL_P, CLS.USER_CODE);
         // this.p_GET_PERSON_MONEY_AVAL_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_MONEY_BY_ONEDATE_AVAL_P, CLS.BOOK_TYPE_PRT, CLS.DOCTOR_CODE_GENE, Convert.ToDateTime(CLS.F_DATE_PRT));
         
            this.reportViewer1.RefreshReport();
        }
    }
}
