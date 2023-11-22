using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.PERSONS
{
    public partial class FRM_MEDICAL_HISTORY : Form
    {
        int PER_CODE;
        public FRM_MEDICAL_HISTORY( int PERSON_CODEE)
        {
            InitializeComponent();
             PER_CODE = PERSON_CODEE;

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
          

        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
           
        }

        private void FRM_MEDICAL_HISTORY_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_MEDICAL_HISTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY, new System.Nullable<int>(((int)(System.Convert.ChangeType( PER_CODE , typeof(int))))));
                richTextBox1.Text = this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY.Rows[0][0].ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {

        }

        private void BTN_EXIT_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                //if (richTextBox1.Text == string.Empty)
                //{
                //    string DOCTOR_NAME = "";
                //    string LINE_SEPATE = "";
                //}

                var INSERTED_HISTORY = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                INSERTED_HISTORY.P_UPDATE_T_PERSON_HISTORY(Convert.ToInt32(PER_CODE), richTextBox1.Text + "\n" + CLS.USER_NAME + "\n" + "-------------------------------------------------------------------------------" + "\n", ref  CLS.SUBMIT_FLAG);
                this.gET_MEDICAL_HISTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY, new System.Nullable<int>(((int)(System.Convert.ChangeType(PER_CODE, typeof(int))))));
                richTextBox1.Text = this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY.Rows[0][0].ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (CLS.SUBMIT_FLAG == 1)
            {


                MSG.Msg.Alart(AlartType.Save);
            }
        }

      
    }
}
