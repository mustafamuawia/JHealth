using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT.PRINT_SALES
{
    public partial class FRM_SALES_CATEG : Form
    {
        public FRM_SALES_CATEG()
        {
            InitializeComponent();
        }

        private void FRM_SALES_CATEG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.P_GET_SALES_CATEG_PRT_P' table. You can move, or remove it, as needed.
            this.p_GET_SALES_CATEG_PRT_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_SALES_CATEG_PRT_P,CLS .CODE_DOC_COMBO ,Convert .ToDateTime (CLS .F_DATE_PRT ),Convert .ToDateTime (CLS.E_DATE_PRT ));

            this.reportViewer1.RefreshReport();
        }
    }
}
