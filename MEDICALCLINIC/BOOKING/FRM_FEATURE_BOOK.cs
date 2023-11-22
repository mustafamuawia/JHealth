
using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.BOOKING
{
    public partial class FRM_FEATURE_BOOK : Form
    {


        public FRM_FEATURE_BOOK()
        {
            InitializeComponent();
        }

        private void FRM_ALLBOOK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);


            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
          
        }



        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_BOOKING_PERSON_GENEBOOKTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.p_GET_BOOKING_PERSON_GENEBOOKT, TXT_SEARCH.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy"), typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



       
       
      



      

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
 
             }
            catch (System.Exception ex)
            {

            }
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.p_GET_T_BOOKING_T_PERSON_GENEBOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_GENEBOOK, iD_VALToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_CODEToolStripTextBox.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dATE_BOOKToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(fLAG_TYPSEARCHToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BTN_BYDATE_Click(object sender, EventArgs e)
        {

            try
            {
             this.p_GET_BOOKING_PERSON_GENEBOOKTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.p_GET_BOOKING_PERSON_GENEBOOKT, TXT_SEARCH.Text , new System.Nullable<int>(((int)(System.Convert.ChangeType( dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy"), typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType( 1, typeof(int))))));
                if (this.mEDICAL_CLINIC_DBDataSet.p_GET_BOOKING_PERSON_GENEBOOKT.Rows.Count > 0)
                    LBL_TOTAL_PERS.Text = this.mEDICAL_CLINIC_DBDataSet.p_GET_BOOKING_PERSON_GENEBOOKT.Rows.Count.ToString();
                else
                    LBL_TOTAL_PERS.Text = "0";
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_GENERAL_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_BOOKING_PERSON_GENEBOOKTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.p_GET_BOOKING_PERSON_GENEBOOKT, TXT_SEARCH.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(monthCalendar1.SelectionRange.Start.ToString("dd MMM yyyy"), typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
              //  this.p_GET_BOOKING_PERSON_GENEBOOKTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.p_GET_BOOKING_PERSON_GENEBOOKT, pERSON_NAMEToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(iD_DOCTToolStripTextBox.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dATE_DAYToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(cHECK_FLAGToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
