using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SANAD
{
    public partial class FRM_SEARCH_ACCOUNT : Form
    {

        public FRM_SEARCH_ACCOUNT()
        {
            InitializeComponent();

        }

        

      
 
        
       
       
        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_ACCOUNT_FRO_TOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_ACCOUNT_FRO_TO, "");
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
                this.gET_ALL_ACCOUNT_FRO_TOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_ACCOUNT_FRO_TO,TXT_SEARCH .Text );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CLS.Flag_SANAD_S == 1)
                {

                    ((SANAD.FRM_SANAD)Application.OpenForms["FRM_SANAD"]).ACCOUNT_FROMCODETextBoxX.Text =
                        dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    ((SANAD.FRM_SANAD)Application.OpenForms["FRM_SANAD"]).FROM_ACCOUNTTextBoxX.Text =
                       dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    this.Dispose();
                }
                if (CLS.Flag_SANAD_S == 2)
                {
                    ((SANAD.FRM_SANAD)Application.OpenForms["FRM_SANAD"]).ACCOUNT_TOCODETextBoxX.Text =
                       dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    ((SANAD.FRM_SANAD)Application.OpenForms["FRM_SANAD"]).TO_ACCOUNTTextBoxX.Text =
                       dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    this.Dispose();
                }
            }
            catch
            {
                return;
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
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
