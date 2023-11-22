using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SEARCH_TOOTH_CLASS : Form
    {

        public FRM_SEARCH_TOOTH_CLASS()
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
                this.gET_CLASS_TOOTH_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_CLASS_TOOTH_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_CLASS_TOOTH_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_CLASS_TOOTH_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((TOOTH_OP.FRM_CLASS_TOOTH)Application.OpenForms["FRM_CLASS_TOOTH"]).CLASS_CODETextBoxX.Text =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((TOOTH_OP.FRM_CLASS_TOOTH)Application.OpenForms["FRM_CLASS_TOOTH"]).TXT_CLASS_NAME.Text =
               dataGridView2.CurrentRow.Cells[1].Value.ToString();

            this.Dispose();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }





    }
}
