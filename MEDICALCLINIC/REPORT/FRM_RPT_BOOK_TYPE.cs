using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_RPT_BOOK_TYPE : Form
    {

        public FRM_RPT_BOOK_TYPE()
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
            this.Dispose();

        }

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {

            try
            {
                this.p_GET_BOOK_TYPE_BY_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_BY_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.DOCTOR_CODE_GENE, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = null;
                this.p_GET_BOOK_TYPE_PRTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT, bOOK_NAMEComboBox3.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       

        

         

        private void button2_Click(object sender, EventArgs e)
        {
            //1D
            //try
            //{
            //    dataGridView2.DataSource = null;
            //    this.p_GET_BOOK_TYPE_PRT_ONE_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT_ONE_DATE, bOOK_NAMEComboBox3.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_DAY.Value, typeof(System.DateTime))))));
            //    dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT_ONE_DATE;
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = null;
                this.p_GET_BOOK_TYPE_PRT_TOW_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT_TOW_DATE, bOOK_NAMEComboBox3.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))));
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_PRT_TOW_DATE;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CLS.BOOK_TYPE_PRT = bOOK_NAMEComboBox3.Text;
            PRINT.RPT_PRINT_BOOKT_G FRM = new PRINT.RPT_PRINT_BOOKT_G();
           FRM.ShowDialog();

        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    CLS.BOOK_TYPE_PRT = bOOK_NAMEComboBox3.Text;
        //    CLS.F_DATE_PRT = DATE_DAY.Text;
        //    PRINT.FRM_ONE_DATE_BOOOKT FRM = new PRINT.FRM_ONE_DATE_BOOOKT();
        //    FRM.ShowDialog();
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            CLS.BOOK_TYPE_PRT = bOOK_NAMEComboBox3.Text;
            CLS.F_DATE_PRT = F_DATE.Text;
            CLS.E_DATE_PRT = E_DATE.Text;
            PRINT.FRM_TOW_DATE_BOOKING_t FRM = new PRINT.FRM_TOW_DATE_BOOKING_t();
            FRM.ShowDialog();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_BOOK_TYPE_BY_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOK_TYPE_BY_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS .DOCTOR_CODE_GENE , typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

     

       
    }
}
