using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.DIAGNOSES
{
    public partial class FRM_OPERTION_PRICE : Form
    {
        public FRM_OPERTION_PRICE()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
        }

        private void FRM_OPERTION_PRICE_Load(object sender, EventArgs e)
        {
            LBL_NAME.Text = CLS.PERSON_NAME_IMGE;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_PRICE_OPE.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا ادخل مبلغ العمليه اولا ");
                    return;
                }
                else
                {
                    var UPDATE_OPE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    UPDATE_OPE.P_UPDATE_T_BOOKING_OPERTIONS(CLS.ID_BOOKING_IMG, CLS.ID_PERSON_IMG, TXT_PRICE_OPE.Text, false,1, ref  CLS.SUBMIT_FLAG);
                }
                if (CLS.SUBMIT_FLAG == 1)
                {
                    MSG.Msg.Alart(AlartType.Save);
                    TXT_PRICE_OPE.Text = "";
                    button4.Enabled = false;
                    
                }
                else
                {

                    MSG.Msg.Alart(AlartType.Error);

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
