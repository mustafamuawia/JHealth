using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT.PRINT_SALES
{
    public partial class FRM_DOCTOR_SEAL : Form
    {
        public FRM_DOCTOR_SEAL()
        {
            InitializeComponent();
        }

        private void FRM_DOCTOR_SEAL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_SALES_BY_DOCTOR_P' table. You can move, or remove it, as needed.
            this.p_GET_SALES_BY_DOCTOR_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_SALES_BY_DOCTOR_P, CLS.CODE_DOC_COMBO);

            this.reportViewer1.RefreshReport();
        }
    }
}
