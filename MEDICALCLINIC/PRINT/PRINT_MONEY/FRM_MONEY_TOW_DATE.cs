using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT.PRINT_MONEY
{
    public partial class FRM_MONEY_TOW_DATE : Form
    {
        public FRM_MONEY_TOW_DATE()
        {
            InitializeComponent();
        }

        private void FRM_MONEY_TOW_DATE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_MONEY_BY_TOWDATE_AVAL_P' table. You can move, or remove it, as needed.
            this.p_GET_MONEY_BY_TOWDATE_AVAL_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_MONEY_BY_TOWDATE_AVAL_P, CLS.USER_CODE, Convert.ToDateTime(CLS.F_DATE_PRT), Convert.ToDateTime(CLS.E_DATE_PRT));
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }
    }
}
