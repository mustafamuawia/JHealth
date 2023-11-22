using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SEARCH_TREATMENT : MEDICALCLINIC.SETTING.baseclinicanddental
    {

        public FRM_SEARCH_TREATMENT()
        {
            InitializeComponent();

        }

        

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        

       
        private void buttonX3_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);


        }

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_TREATMENT_TOOTH_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_TREATMENT_TOOTH_NAME_CODE,"");
            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }


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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((TOOTH_OP.FRM_TREATMENT_TOOTH)Application.OpenForms["FRM_TREATMENT_TOOTH"]).TREAT_CODETextBoxX .Text =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((TOOTH_OP.FRM_TREATMENT_TOOTH)Application.OpenForms["FRM_TREATMENT_TOOTH"]).TREAT_NAME.Text =
               dataGridView2.CurrentRow.Cells[1].Value.ToString();
            ((TOOTH_OP.FRM_TREATMENT_TOOTH)Application.OpenForms["FRM_TREATMENT_TOOTH"]).TXT_PRICE.Text  =
             dataGridView2.CurrentRow.Cells[2].Value.ToString();
            this.Dispose();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }



      


    }
}
