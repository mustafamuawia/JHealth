using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT
{
    public partial class FRM_ONE_DATE_BOOOKT : Form
    {
        public FRM_ONE_DATE_BOOOKT()
        {
            InitializeComponent();
        }

        private void FRM_ONE_DATE_BOOOKT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT_ONE_DATE_P' table. You can move, or remove it, as needed.
            this.p_GET_BOOK_TYPE_PRT_ONE_DATE_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT_ONE_DATE_P, CLS.BOOK_TYPE_PRT, CLS.USER_CODE, Convert.ToDateTime(CLS.F_DATE_PRT));
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_ONE_DATE_R' table. You can move, or remove it, as needed.
          //  this.p_GET_BOOK_TYPE_ONE_DATE_RTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_ONE_DATE_R,CLS .BOOK_TYPE_PRT ,CLS .DOCTOR_CODE_GENE ,Convert .ToDateTime (CLS .F_DATE_PRT ));
         
            this.reportViewer1.RefreshReport();
        }
    }
}
