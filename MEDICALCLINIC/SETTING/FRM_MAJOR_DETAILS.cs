using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_MAJOR_DETAILS : BASEANYFORM
    {

        public FRM_MAJOR_DETAILS()
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
            SEARCH.FRM_SERACH_MAJOR_DETAILS FRM = new SEARCH.FRM_SERACH_MAJOR_DETAILS();
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
                if (MAJOR_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(MAJOR_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (MAJOR_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(MAJOR_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                   
                    INSERTED.P_T_MAJOR_DETAILS(CLS.CHEECK_CODE, ref CLS.CLIENT_CODE, MAJOR_NAME_ARTextBoxX.Text,Convert.ToInt32(mAJOR_NAMEComboBox.SelectedValue), true, ref CLS.SUBMIT_FLAG);
                   

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        MAJOR_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (MAJOR_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(MAJOR_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_MAJOR_DETAILS( Convert.ToInt32(MAJOR_CODETextBoxX.Text), MAJOR_NAME_ARTextBoxX.Text, Convert.ToInt32(mAJOR_NAMEComboBox.SelectedValue), true, ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        MAJOR_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (MAJOR_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(MAJOR_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_MAJOR_DETAILS(Convert.ToInt32(MAJOR_CODETextBoxX.Text), ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        MAJOR_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

        private void FRM_MAJOR_DETAILS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_MAJOR' table. You can move, or remove it, as needed.
            this.v_GET_A_MAJORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_MAJOR);

        }
    }
}
