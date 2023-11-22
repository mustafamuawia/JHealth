using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SEARCH_DRAGE : Form
    {

        public FRM_SEARCH_DRAGE()
        {
            InitializeComponent();

        }

        private void buttonX8_Click(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
       

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {


            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
           


        }

        private void CLIENT_NAME_ARTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_NAME_ENTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_PHONE1TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_PHONE2TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_PHONE3TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_EMAILETextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_NAME_CODE, "");
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
                this.gET_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_NAME_CODE, TXT_SEARCH .Text );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((SETTING .FRM_DRAGE)Application.OpenForms["FRM_DRAGE"]).DRAGE_CODETextBoxX .Text =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((SETTING.FRM_DRAGE)Application.OpenForms["FRM_DRAGE"]).DRAGE_NAME_ARTextBoxX.Text =
               dataGridView2.CurrentRow.Cells[1].Value.ToString();
            ((SETTING.FRM_DRAGE)Application.OpenForms["FRM_DRAGE"]).dRAGE_GROUP_NAMEComboBox.SelectedValue =
             Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());
            this.Dispose();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        
        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.gET_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
