using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SEACRH_LOGIN : Form
    {

        public FRM_SEACRH_LOGIN()
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

      

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((MAIN.FRM_LOGIN)Application.OpenForms["FRM_LOGIN"]).txt_user .Text =
                dataGridView2.CurrentRow.Cells[4].Value.ToString();
           
            
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

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
