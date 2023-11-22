using System;
using System.Globalization;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_DESC : BASEANYFORM
    {

        public FRM_DESC()
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
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_H_GET_OPERTION_CACTEG' table. You can move, or remove it, as needed.
            this.v_H_GET_OPERTION_CACTEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_H_GET_OPERTION_CACTEG);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);

        }

        

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEARCH_DESC FRM = new SEARCH.FRM_SEARCH_DESC();
            FRM.ShowDialog();
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            cleartextbox(this.groupBox2);
            DOCTOR_COMB.SelectedValue = -1;
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {

            try
            {
                if (DESC_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(DESC_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (DESC_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(DESC_CODETextBoxX.Text);
                    }
                    var INSERTEDop = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTEDop.P_INSERT_T_DESCRTION(CLS.CHEECK_CODE, ref  CLS.OP_CODE, DESC_NAME_ARTextBoxX.Text, Convert.ToInt32(DOCTOR_COMB.SelectedValue),Convert.ToDecimal(TXT_PRICE.Text), Convert.ToDecimal(TXT_MINI_PRICE.Text), Convert.ToDecimal(TXT_PERCENT.Text),0,Convert.ToInt32(nAME_OP_CATEGComboBox.SelectedValue), true, ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        DESC_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (DESC_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(DESC_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_DESCRTION(Convert.ToInt32(DESC_CODETextBoxX.Text), DESC_NAME_ARTextBoxX.Text, Convert.ToInt32(DOCTOR_COMB.SelectedValue), true, Convert.ToDecimal(TXT_PRICE.Text), Convert.ToDecimal(TXT_PRICE.Text), Convert.ToDecimal(TXT_PERCENT.Text), 0,Convert.ToInt32(nAME_OP_CATEGComboBox.SelectedValue), ref  CLS.SUBMIT_FLAG);




                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        DESC_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (DESC_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(DESC_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_DESCRTION(Convert.ToInt32(DESC_CODETextBoxX.Text), ref  CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        DESC_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_PRICE_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                this.TXT_PRICE.Text = Convert.ToDecimal(this.TXT_PRICE.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PRICE.SelectionStart = TXT_PRICE.TextLength;


                
            }
            catch
            {
                return;
            }
        }

        private void TXT_MINI_PRICE_TextChanged(object sender, EventArgs e)
        {
            try
            {

                this.TXT_MINI_PRICE.Text = Convert.ToDecimal(this.TXT_MINI_PRICE.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_MINI_PRICE.SelectionStart = TXT_MINI_PRICE.TextLength;

            }
            catch
            {
                return;
            }
        }
    }
}
