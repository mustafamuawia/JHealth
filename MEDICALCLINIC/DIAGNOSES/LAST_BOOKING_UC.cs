using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.DIAGNOSES
{
    public partial class LAST_BOOKING_UC : UserControl
    {
        public int PER_CODEE;
        public LAST_BOOKING_UC(int PER_CODE)
        {
            InitializeComponent();
            PER_CODEE = PER_CODE;
            this.p_GET_TOOTH_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_TOOTH_BOOKING, new System.Nullable<int>(((int)(System.Convert.ChangeType(PER_CODEE, typeof(int))))));

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_TOOTH_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_TOOTH_BOOKING, new System.Nullable<int>(((int)(System.Convert.ChangeType(PER_CODEE, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          try {

            if (e.ColumnIndex == 8)
            {
                this.p_GET_IMG_BY_CODE_BOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BY_CODE_BOOK, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView2.CurrentRow.Cells[0].Value, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView2.CurrentRow.Cells[6].Value, typeof(int))))));

                if (this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BY_CODE_BOOK.Rows.Count > 0)
                {
                    CLS.CODE_PER_IMG = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[6].Value.ToString());
                    CLS.CODE_BOOK_IMG = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    DIAGNOSES.FRM_IMG_PER_BOOK FRM = new DIAGNOSES.FRM_IMG_PER_BOOK();
                    FRM.ShowDialog();
               }
                else
                {
                    MessageBox.Show("الحجز الحالي لايحتوي على صور");
                    return;
                }
            }

               }

           catch (Exception EX)
           {
              MessageBox.Show(EX.Message , CLS.TITEL_MESG);
           }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void fillToolStripButton_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.p_GET_IMG_BY_CODE_BOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BY_CODE_BOOK, new System.Nullable<int>(((int)(System.Convert.ChangeType(vAR_IDToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pER_CODEToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}

