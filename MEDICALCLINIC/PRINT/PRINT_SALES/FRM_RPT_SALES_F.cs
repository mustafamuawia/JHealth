using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT.PRINT_SALES
{
    public partial class FRM_RPT_SALES_F : Form
    {
        public FRM_RPT_SALES_F()
        {
            InitializeComponent();
        }

        private void FRM_RPT_SALES_F_Load(object sender, EventArgs e)
        {
            
           
        }

        private void FRM_RPT_SALES_F_Load_1(object sender, EventArgs e)
        {

            this.p_GET_SALES_PRT_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_SALES_PRT_P, CLS.TEXT_FOR_REPORT, CLS.USER_CODE);

            this.reportViewer1.RefreshReport();
        }
    }
}
