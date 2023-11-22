using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_INCOMING : USERSE.masterfrm
    {
        public FRM_INCOMING()
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
       

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEARCH_ERRADAT FRM = new SEARCH.FRM_SEARCH_ERRADAT();
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
                if (INCOMING_NAMMETextBoxX.Text == "")
                {

                    errorProvider1.SetError(INCOMING_NAMMETextBoxX, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (INCOMING_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = -1;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(INCOMING_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_ERADAT(Convert.ToInt32(CLS.CHEECK_CODE), ref  CLS.CLIENT_CODE, INCOMING_NAMMETextBoxX.Text, ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        INCOMING_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (INCOMING_CODETextBoxX.Text == "")
                {

                    errorProvider1.SetError(INCOMING_CODETextBoxX, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_ACCOUNT(Convert.ToInt32(INCOMING_CODETextBoxX.Text), INCOMING_NAMMETextBoxX.Text, ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        INCOMING_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (INCOMING_CODETextBoxX.Text == "")
                {

                    errorProvider1.SetError(INCOMING_CODETextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_DELET_T_ACCOUNT(Convert.ToInt32(INCOMING_CODETextBoxX.Text), ref  CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        INCOMING_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
    }
}