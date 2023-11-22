using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.USERSE
{
    public partial class FRM_SEARCH_USERS : Form
    {

        public FRM_SEARCH_USERS()
        {
            InitializeComponent();

        }
 
        
        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_USER_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_USER_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
             //   System.Windows.Forms.MessageBox.Show(ex.Message);
            }



        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_USER_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_USER_NAME_CODE, TXT_SEARCH .Text );
            }
            catch (System.Exception ex)
            {
              //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((USERSE.FRM_USERS)Application.OpenForms["FRM_USERS"]).TXT_USER_CODE .Text =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((USERSE.FRM_USERS)Application.OpenForms["FRM_USERS"]).TXT_USER_NAEME .Text =
               dataGridView2.CurrentRow.Cells[4].Value.ToString();
            ((USERSE.FRM_USERS)Application.OpenForms["FRM_USERS"]).PWD_TXT .Text  =
            dataGridView2.CurrentRow.Cells[5].Value.ToString();
            ((USERSE.FRM_USERS)Application.OpenForms["FRM_USERS"]).RE_PWD_TXT.Text =
            dataGridView2.CurrentRow.Cells[5].Value.ToString();
            int vv= Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            ((USERSE.FRM_USERS)Application.OpenForms["FRM_USERS"]).LEVL_COMB.SelectedValue  =
            Convert .ToInt32 (dataGridView2.CurrentRow.Cells[1].Value.ToString());
            ((USERSE.FRM_USERS)Application.OpenForms["FRM_USERS"]).COMB_EMP.SelectedValue =
             Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
             this.Dispose();

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
