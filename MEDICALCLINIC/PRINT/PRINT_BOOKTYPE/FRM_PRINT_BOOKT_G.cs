using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT
{
    public partial class RPT_PRINT_BOOKT_G : Form
    {
        public RPT_PRINT_BOOKT_G()
        {
            InitializeComponent();
        }

        private void RPT_PRINT_BOOKT_G_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT_P' table. You can move, or remove it, as needed.
            this.p_GET_BOOK_TYPE_PRT_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT_P, CLS.BOOK_TYPE_PRT, CLS.USER_CODE);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_R' table. You can move, or remove it, as needed.
          // this.p_GET_BOOK_TYPE_RTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_R,CLS .BOOK_TYPE_PRT ,CLS .DOCTOR_CODE_GENE );
          //  this.p_GET_BOOK_TYPE_ONE_DATE_RTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_ONE_DATE_R, "سونار", 3,Convert .ToDateTime ( "2017-02-08"));
           
            this.reportViewer1.RefreshReport();
        }
    }
}
