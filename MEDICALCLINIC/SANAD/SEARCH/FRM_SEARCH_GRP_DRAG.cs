using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SEARCH_GRP_DRAG : Form
    {

        public FRM_SEARCH_GRP_DRAG()
        {
            InitializeComponent();

        }

      
       

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {

            try
            {
                this.gET_DRAGE_GROUP_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_GROUP_NAME_CODE, "");
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
                this.gET_DRAGE_GROUP_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_GROUP_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((SETTING.FRM_GROUP_DRAG)Application.OpenForms["FRM_GROUP_DRAG"]).TXT_GRP_DRAG_CODE.Text =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((SETTING.FRM_GROUP_DRAG)Application.OpenForms["FRM_GROUP_DRAG"]).TXT_GRP_GRP_NAME.Text =
               dataGridView2.CurrentRow.Cells[1].Value.ToString();
            
            this.Dispose();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }


         

        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_DRAGE_GROUP_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_GROUP_NAME_CODE,  "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
