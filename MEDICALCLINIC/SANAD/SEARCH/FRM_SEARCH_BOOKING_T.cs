using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SEARCH_BOOKING_T : Form
    {

        public FRM_SEARCH_BOOKING_T()
        {
            InitializeComponent();

        }
 
       
        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_BOOKI_TYPE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKI_TYPE_NAME_CODE, "");
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
                this.gET_BOOKI_TYPE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKI_TYPE_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((SETTING.FRM_BOOK_TYPE)Application.OpenForms["FRM_BOOK_TYPE"]).BOOK_TYPE_CODETextBoxX .Text =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((SETTING.FRM_BOOK_TYPE)Application.OpenForms["FRM_BOOK_TYPE"]).BOOK_TYPE_NAME_ARTextBoxX.Text =
               dataGridView2.CurrentRow.Cells[1].Value.ToString();
            ((SETTING.FRM_BOOK_TYPE)Application.OpenForms["FRM_BOOK_TYPE"]).DOCTOR_COMB .SelectedValue =
             Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
            this.Dispose();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

       

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        
    }
}
