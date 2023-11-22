using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.TOOTH_OP
{
    public partial class FRM_TREATMENT_TOOTH : MEDICALCLINIC.SETTING.baseclinicanddental
    {

        public FRM_TREATMENT_TOOTH()
        {
            InitializeComponent();
        }

         
       
        public void cleartextbox(Control root)
        {
            foreach (Control ct in root.Controls)
            {
                if (ct is TextBox)
                    ((TextBox)ct).Clear();

                //' افراغ لتيكست بوكس 
            }
        }
       

        

       

       
        private void FRM_DESC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);

        }

       

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            TOOTH_OP.FRM_SEARCH_TREATMENT_T FRM = new TOOTH_OP.FRM_SEARCH_TREATMENT_T();
            FRM.ShowDialog();
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            cleartextbox(this.groupBox2);
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TREAT_NAME.Text == "")
                {

                    errorProvider1.SetError(TREAT_NAME, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (TREAT_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TREAT_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_TREATMENT_TOOTH(
                         CLS.CHEECK_CODE
                        , ref  CLS.CLIENT_CODE
                        , TREAT_NAME.Text
                        , TXT_PRICE.Text
                        , true
                        , ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        TREAT_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (TREAT_NAME.Text == "")
                {

                    errorProvider1.SetError(TREAT_NAME, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_TREATMENT_TOOTH(
                        Convert.ToInt32(TREAT_CODETextBoxX.Text)
                        , TREAT_NAME.Text
                        , TXT_PRICE.Text
                        , true
                        , ref  CLS.SUBMIT_FLAG);




                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        TREAT_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                        MSG.Msg.Alart(AlartType.Update);

                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TREAT_NAME.Text == "")
                {

                    errorProvider1.SetError(TREAT_NAME, CLS.TXT_NULL);
                }
 MSG.Msg.Alart(AlartType.Error);
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_TREATMENT_TOOTH(Convert.ToInt32(TREAT_CODETextBoxX.Text), false, ref  CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        TREAT_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TXT_PRICE_TextChanged(object sender, EventArgs e)
        {
            try
            {

                this.TXT_PRICE.Text = Convert.ToDecimal(this.TXT_PRICE.Text).ToString("N0", new System.Globalization.CultureInfo("en-US"));
                this.TXT_PRICE.SelectionStart = TXT_PRICE.TextLength;


            }
            catch
            {
                return;
            }

        }
    }
}
