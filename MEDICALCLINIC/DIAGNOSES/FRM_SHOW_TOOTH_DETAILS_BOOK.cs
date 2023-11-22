using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.DIAGNOSES
{

    public partial class FRM_SHOW_TOOTH_DETAILS_BOOK : Form
    {
        public int PERSON_CODE;
        public FRM_SHOW_TOOTH_DETAILS_BOOK(int  PER_CODE)
        {
            InitializeComponent();
            PERSON_CODE = PER_CODE;
        }
        int MOUSE_X = 0, MOUSE_Y = 0;
        bool MOUSDOWN_CC;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MOUSDOWN_CC = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            MOUSDOWN_CC = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (MOUSDOWN_CC)
            {
                MOUSE_X = MousePosition.X - 200;
                MOUSE_Y = MousePosition.Y - 40;
                this.SetDesktopLocation(MOUSE_X, MOUSE_Y);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     
      

       
        private void FRM_SHOW_TOOTH_DETAILS_BOOK_Load(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_TOOTH_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_TOOTH_BOOKING, new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE , typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

     
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == 10)
                {
                    ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value),1);
                    FRM.ShowDialog();
                    //this.p_GET_IMG_BY_CODE_BOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BY_CODE_BOOK, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView2.CurrentRow.Cells[0].Value, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView2.CurrentRow.Cells[6].Value, typeof(int))))));

                    //if (this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BY_CODE_BOOK.Rows.Count > 0)
                    //{
                    //    CLS.CODE_PER_IMG = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[6].Value.ToString());
                    //    CLS.CODE_BOOK_IMG = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    //    DIAGNOSES.FRM_IMG_PER_BOOK FRM = new DIAGNOSES.FRM_IMG_PER_BOOK();
                    //    FRM.ShowDialog();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("الحجز الحالي لايحتوي على صور");
                    //    return;
                    //}

                }
////////////////////////////////////////////

                if (e.ColumnIndex == 11)
                {
                    if (this.dataGridView2.CurrentRow.Cells[8].Value.ToString() == string.Empty)
                    {
                        MessageBox.Show("الحالة لاتحتوي على ملاحظات");
                        return;
                    }
                    else
                    {
                        FRM_TOOTH_NOTE_BOOKING frm = new FRM_TOOTH_NOTE_BOOKING(this.dataGridView2.CurrentRow.Cells[8].Value.ToString());
                        frm.ShowDialog();
                    }
                }

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }


    }
}
