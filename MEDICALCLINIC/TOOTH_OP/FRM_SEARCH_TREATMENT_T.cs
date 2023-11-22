using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.TOOTH_OP
{
    public partial class FRM_SEARCH_TREATMENT_T : Form
    {
        public FRM_SEARCH_TREATMENT_T()
        {
            InitializeComponent();
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ((TOOTH_OP.FRM_TREATMENT_TOOTH)Application.OpenForms["FRM_TREATMENT_TOOTH"]).TREAT_CODETextBoxX.Text =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((TOOTH_OP.FRM_TREATMENT_TOOTH)Application.OpenForms["FRM_TREATMENT_TOOTH"]).TREAT_NAME.Text =
               dataGridView2.CurrentRow.Cells[1].Value.ToString();
            ((TOOTH_OP.FRM_TREATMENT_TOOTH)Application.OpenForms["FRM_TREATMENT_TOOTH"]).TXT_PRICE.Text =
             dataGridView2.CurrentRow.Cells[2].Value.ToString();
            this.Dispose();
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_TREATMENT_TOOTH_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_TREATMENT_TOOTH_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FRM_SEARCH_TREATMENT_T_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_TREATMENT_TOOTH_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_TREATMENT_TOOTH_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }
    }
}
