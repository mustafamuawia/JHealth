using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PERSONS
{
    public partial class FRM_SEARCH_PER_FOR_CBOX : Form
    {

        public FRM_SEARCH_PER_FOR_CBOX()
        {
            InitializeComponent();

        }

        

        private void buttonX4_Click(object sender, EventArgs e)
        {
         

        }

        
        private void buttonX3_Click(object sender, EventArgs e)
        {
        

        }

       

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    this.gET_PERSON_NAME_CODE_CBOXTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_NAME_CODE_CBOX, CLS.CBOX_DOCT, "");
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    this.gET_PERSON_NAME_CODE_CBOXTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_NAME_CODE_CBOX, CLS.CBOX_DOCT, TXT_SEARCH .Text );
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ((BOOKING.FRM_BOOKING)Application.OpenForms["FRM_BOOKING"]).LBL_NAMEPERSON.SelectedValue =
                    Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    //((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).LBL_NAMEPERSON.Text  =
                   // dataGridView2.CurrentRow.Cells[1].Value.ToString() ;
                  

                    this.Dispose();
              

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

       

       

        private void fillToolStripButton_Click_4(object sender, EventArgs e)
        {
            //try
            //{
            //    this.gET_PERSON_NAME_CODE_CBOXTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_NAME_CODE_CBOX, CLS.CBOX_DOCT,"");
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

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
