using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT.PRINT_PERSON_MONEY
{
    public partial class FRM_PER_MON_ONE_DATE : Form
    {
        public FRM_PER_MON_ONE_DATE()
        {
            InitializeComponent();
        }

        private void FRM_PER_MON_ONE_DATE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_PERSON_MONEY_BY_ONEDATE_AVAL_R' table. You can move, or remove it, as needed.
            this.p_GET_PERSON_MONEY_BY_ONEDATE_AVAL_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PERSON_MONEY_BY_ONEDATE_AVAL_P, CLS.PER_RPT_F, CLS.USER_CODE, Convert.ToDateTime(CLS.F_DATE_PRT));


            this.reportViewer1.RefreshReport();
        }
    }
}
