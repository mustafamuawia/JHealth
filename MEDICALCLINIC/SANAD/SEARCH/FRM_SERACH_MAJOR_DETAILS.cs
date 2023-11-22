using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SERACH_MAJOR_DETAILS : Form
    {

        public FRM_SERACH_MAJOR_DETAILS()
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
                this.gET_T_MAJOR_DETAILS_NAME_CODE_TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_MAJOR_DETAILS_NAME_CODE_, "");
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
                this.gET_T_MAJOR_DETAILS_NAME_CODE_TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_MAJOR_DETAILS_NAME_CODE_, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((SETTING.FRM_MAJOR_DETAILS)Application.OpenForms["FRM_MAJOR_DETAILS"]).MAJOR_CODETextBoxX.Text =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((SETTING.FRM_MAJOR_DETAILS)Application.OpenForms["FRM_MAJOR_DETAILS"]).MAJOR_NAME_ARTextBoxX.Text =
               dataGridView2.CurrentRow.Cells[1].Value.ToString();
            ((SETTING.FRM_MAJOR_DETAILS)Application.OpenForms["FRM_MAJOR_DETAILS"]).mAJOR_NAMEComboBox.SelectedValue =
             Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
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
                this.gET_DESCRPTION_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DESCRPTION_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.gET_T_MAJOR_DETAILS_NAME_CODE_TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_MAJOR_DETAILS_NAME_CODE_,"");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
