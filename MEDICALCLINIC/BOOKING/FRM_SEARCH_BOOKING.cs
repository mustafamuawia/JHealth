using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.BOOKING
{
    public partial class FRM_SEARCH_BOOKING : Form
    {
        int FRMSIDE;
        public FRM_SEARCH_BOOKING(int FRMS)
        {
            InitializeComponent();
            FRMSIDE = FRMS;
        }

       

        private void buttonX3_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);


        }

       
        

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            try
            {
               
                this.gET_BOOKING__NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING__NAME_CODE, "",DATE_BOOK .Value ,Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue));
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
                this.gET_BOOKING__NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING__NAME_CODE, TXT_SEARCH.Text, DATE_BOOK.Value, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue));
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
                if (FRMSIDE==1)
                {
                    ((FRM_BOOKING)Application.OpenForms["FRM_BOOKING"]).TXTBOOKCODE.Text =
                   dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    ((FRM_BOOKING)Application.OpenForms["FRM_BOOKING"]).dOCTOR_NAMEComboBox.SelectedValue =
                    Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());

                    ((FRM_BOOKING)Application.OpenForms["FRM_BOOKING"]).LBL_NAMEPERSON.SelectedValue =
                    Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());



                    ((FRM_BOOKING)Application.OpenForms["FRM_BOOKING"]).bOOK_TYPE_CODEComboBox.Text =
                       dataGridView2.CurrentRow.Cells[5].Value.ToString();

                    ((FRM_BOOKING)Application.OpenForms["FRM_BOOKING"]).dISEASE_NAMEComboBox.Text =
                     dataGridView2.CurrentRow.Cells[6].Value.ToString();

                    ((FRM_BOOKING)Application.OpenForms["FRM_BOOKING"]).DATE_BOOKING.Text =
                   dataGridView2.CurrentRow.Cells[7].Value.ToString();

                    ((FRM_BOOKING)Application.OpenForms["FRM_BOOKING"]).TIME_BOOKING.Text =
                   dataGridView2.CurrentRow.Cells[8].Value.ToString();

                }
                if (FRMSIDE == 2)
                {
                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).TXTBOOKCODE.Text =
                   dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).dOCTOR_NAMEComboBox.SelectedValue =
                    Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());

                    
                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).getidpersonforedit =
                    Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());

                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).pERSON_NAMEComboBox.SelectedValue =
                    Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value.ToString());
                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).bOOK_TYPE_CODEComboBox.Text =
                       dataGridView2.CurrentRow.Cells[5].Value.ToString();

                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).dISEASE_NAMEComboBox.Text =
                     dataGridView2.CurrentRow.Cells[6].Value.ToString();

                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).DATE_BOOKING.Text =
                   dataGridView2.CurrentRow.Cells[7].Value.ToString();

                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).TIME_BOOKING.Text =
                   dataGridView2.CurrentRow.Cells[8].Value.ToString();

                }

                this.Dispose();
        }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
}

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        //private void fillToolStripButton_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.gET_DOCTOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_NAME_CODE, "");
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
 
       
        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gET_BOOKING__NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING__NAME_CODE, TXT_SEARCH.Text, DATE_BOOK.Value, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue));

        }
    }
}
