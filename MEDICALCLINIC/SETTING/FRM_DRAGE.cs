using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_DRAGE : BASEANYFORM
    {

        public FRM_DRAGE()
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
       

        private void FRM_DRAGE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_DRAGE_GRP' table. You can move, or remove it, as needed.
            this.v_GET_A_DRAGE_GRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_DRAGE_GRP);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_GROUP_DRAG' table. You can move, or remove it, as needed.
            // this.v_GET_A_GROUP_DRAGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_GROUP_DRAG);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            
                this.gET_DOCTOR_BY_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_FLOOR, new System.Nullable<int>(((int)(System.Convert.ChangeType( CLS.BRANCH_ID, typeof(int))))),1);
            

        }

        

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {

            SEARCH.FRM_SEARCH_DRAGE FRM = new SEARCH.FRM_SEARCH_DRAGE();
            FRM.ShowDialog();
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            cleartextbox(this.groupBox2);
            dRAGE_GROUP_NAMEComboBox.SelectedValue = -1;
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {

            try
            {
                if (DRAGE_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(DRAGE_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (DRAGE_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(DRAGE_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_DRAGE(
                        CLS.CHEECK_CODE
                        , ref  CLS.CLIENT_CODE
                        , DRAGE_NAME_ARTextBoxX.Text
                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                        , Convert.ToInt32(dRAGE_GROUP_NAMEComboBox.SelectedValue)
                        , true
                        , ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        DRAGE_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (DRAGE_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(DRAGE_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_DRAGE(
                    Convert.ToInt32(DRAGE_CODETextBoxX.Text)
                    , DRAGE_NAME_ARTextBoxX.Text
                    , Convert.ToInt32(dRAGE_GROUP_NAMEComboBox.SelectedValue)
                    , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)


                    , true
                    , ref  CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        DRAGE_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (DRAGE_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(DRAGE_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_DRAGE(Convert.ToInt32(DRAGE_CODETextBoxX.Text), ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        DRAGE_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

        

        

        
    }
}
