using System;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.ADDPICT_GENE
{
    public partial class FRM_SEARCH_ADD_PIC : Form
    {

        public FRM_SEARCH_ADD_PIC()
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

        private void buttonX3_Click(object sender, EventArgs e)
        {
           
        }
        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Value = System.DateTime.Now;
                this.p_GET_BOOK_ADD_IMGE_BYALLTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_ADD_IMGE_BYALL, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.DOCTOR_CODE_ADD_IMG, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_ADD_IMGE_BYALL;
                if (dataGridView2.Rows.Count>0)
                {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                bool IS_CHEK = Convert.ToBoolean(this.dataGridView2.Rows[i].Cells[5].Value);
                if (IS_CHEK == false )
                {
                    this.dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Teal;

                }
            }
            }
   }
            catch (System.Exception ex)
            {
              //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_BOOK_ADD_IMGE_BYALLTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_ADD_IMGE_BYALL, TXT_SEARCH.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.DOCTOR_CODE_ADD_IMG, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((ADDPICT_GENE .FRM_ADD_PIC_NEW)Application.OpenForms["FRM_ADD_PIC_NEW"]).LBL_BOOK_CODE .Text  =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((ADDPICT_GENE.FRM_ADD_PIC_NEW)Application.OpenForms["FRM_ADD_PIC_NEW"]).LBL_PERS_CODE .Text =
               dataGridView2.CurrentRow.Cells[1].Value.ToString();
            ((ADDPICT_GENE.FRM_ADD_PIC_NEW)Application.OpenForms["FRM_ADD_PIC_NEW"]).LBL_PERS_NAME .Text  =
             dataGridView2.CurrentRow.Cells[2].Value.ToString() ;
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
