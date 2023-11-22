using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_CLIENT : MEDICALCLINIC.SETTING. BASEANYFORM
    {
     
        public FRM_CLIENT()
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
       
        private void CLIENT_NAME_ARTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CLIENT_NAME_ENTextBoxX.Focus();
            }
        }

        private void CLIENT_NAME_ENTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CLIENT_PHONE1TextBoxX .Focus();
            }
        }

        private void CLIENT_PHONE1TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CLIENT_PHONE2TextBoxX.Focus();
            }
        }

        private void CLIENT_PHONE2TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CLIENT_PHONE3TextBoxX.Focus();
            }
        }

        private void CLIENT_PHONE3TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CLIENT_EMAILETextBoxX .Focus();
            }
        }

        private void CLIENT_EMAILETextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CLIENT_NOTETextBoxX .Focus();
            }
        }

        

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEARCH_CLIENT FRM = new SEARCH.FRM_SEARCH_CLIENT();
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
                if (CLIENT_NAME_ARTextBoxX.Text == "")
                {
                    errorProvider1.SetError(CLIENT_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (CLIENT_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(CLIENT_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_CLIENTS(CLS.CHEECK_CODE
                        , ref  CLS.CLIENT_CODE
                        , CLIENT_NAME_ARTextBoxX.Text
                        , CLIENT_NAME_ENTextBoxX.Text
                        , " "
                        , CLIENT_PHONE1TextBoxX.Text
                        , CLIENT_PHONE2TextBoxX.Text
                        , CLIENT_PHONE3TextBoxX.Text
                        , CLIENT_EMAILETextBoxX.Text
                        , CLIENT_NOTETextBoxX.Text
                        , 0
                        , 1
                        , 2
                        , 1
                        , true
                        , ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        CLIENT_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (CLIENT_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(CLIENT_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_CLIENTS(Convert.ToInt32(CLIENT_CODETextBoxX.Text), Convert.ToInt32(CLIENT_CODETextBoxX.Text), CLIENT_NAME_ARTextBoxX.Text,
                   CLIENT_NAME_ENTextBoxX.Text, " ", CLIENT_PHONE1TextBoxX.Text, CLIENT_PHONE2TextBoxX.Text,
                   CLIENT_PHONE3TextBoxX.Text, CLIENT_EMAILETextBoxX.Text, CLIENT_NOTETextBoxX.Text, 0,
                   1, 0, 1, true, ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {


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
                if (CLIENT_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(CLIENT_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_CLIENT(Convert.ToInt32(CLIENT_CODETextBoxX.Text), ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        CLIENT_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
            this.Close();
        }
    }
}
