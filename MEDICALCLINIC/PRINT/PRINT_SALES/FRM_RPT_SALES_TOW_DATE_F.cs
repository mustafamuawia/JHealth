using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT.PRINT_SALES
{
    public partial class FRM_RPT_SALES_TOW_DATE_F : Form
    {
        public FRM_RPT_SALES_TOW_DATE_F()
        {
            InitializeComponent();
        }

        private void FRM_RPT_SALES_TOW_DATE_F_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_SALES_TOWDATE_PRT_P' table. You can move, or remove it, as needed.
            this.p_GET_SALES_TOWDATE_PRT_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_SALES_TOWDATE_PRT_P,CLS .TEXT_FOR_REPORT ,CLS.USER_CODE ,Convert .ToDateTime (CLS .F_DATE_PRT ),Convert .ToDateTime (CLS.E_DATE_PRT ));

            this.reportViewer1.RefreshReport();
        }
    }
}
