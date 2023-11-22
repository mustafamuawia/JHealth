using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.DIAGNOSES
{
    public partial class UC_TOOTH_BOOK_NO_DETAILS : UserControl
    {
        public int PERSON_CODE;
        public UC_TOOTH_BOOK_NO_DETAILS(int PERS_CODE)
        {
            InitializeComponent();
            PERSON_CODE = PERS_CODE;
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    DRAGE_NAME_ARTextBoxX.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                    FRM_SHOW_TOOTH_DETAILS_BOOK FRM = new FRM_SHOW_TOOTH_DETAILS_BOOK(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                    FRM.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void UC_TOOTH_BOOK_NO_DETAILS_Load(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_TOOTH_NO_DETAILSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_TOOTH_NO_DETAILS, new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
