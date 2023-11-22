using System;
using System.Globalization;
using System.Windows.Forms;

namespace MEDICALCLINIC.DOCTOR
{
    public partial class FRM_DOCTOR :MEDICALCLINIC. USERSE.masterfrm
    {

        public FRM_DOCTOR()
        {
            InitializeComponent();
        }

        
        public void cleartextbox(Control root)
        {
            foreach (Control ct in root.Controls)
            {
                if (ct is TextBox)
                    ((TextBox)ct).Clear();
                TXT_KASHFIA.Text = "0";
                TXT_PRECENTAGE_KISH.Text = "0";
                TXT_PRECENTAGE.Text = "0";
                //' افراغ لتيكست بوكس 
            }
        }
       
        
        private void FRM_DOCTOR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_GRP_DOCTOR' table. You can move, or remove it, as needed.
            this.v_GET_A_GRP_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_GRP_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_MAJOR' table. You can move, or remove it, as needed.
            this.v_GET_A_MAJORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_MAJOR);
            //gROUP_NAMEComboBox.SelectedIndex = -1;
            //major_COMB.SelectedIndex= - 1;
           
            this.gET_MAJOR_DETAILS_BY_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_MAJOR_DETAILS_BY_CODE, Convert.ToString(1));
            mAJOR_DETAILS_NAMEComboBox.SelectedIndex = -1;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEARCH_DOCTOR FRM = new SEARCH.FRM_SEARCH_DOCTOR();
            FRM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleartextbox(this.groupBox2);
           // major_COMB.SelectedValue = -1;
           // gROUP_NAMEComboBox.SelectedIndex = -1;
            mAJOR_DETAILS_NAMEComboBox.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (DOCTOR_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(DOCTOR_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (mAJOR_DETAILS_NAMEComboBox.SelectedIndex==-1)
                {
                    MessageBox.Show("يرجى تحديد التخصص ثم اعادة المحاولة");
                    return;
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {
                
                    if (DOCTOR_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(DOCTOR_CODETextBoxX.Text);
                    }
                    if (TXT_KASHFIA.Text == "")
                    {

                        TXT_KASHFIA.Text = "0.0";
                    }
                    if (TXT_PRECENTAGE.Text == "")
                    {

                        TXT_PRECENTAGE.Text = "0.0";
                    }
                    if (TXT_PRECENTAGE_KISH.Text == "")
                    {

                        TXT_PRECENTAGE_KISH.Text = "0.0";
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    if (Properties.Settings.Default.PROG_ID == 1)
                    {
                        INSERTED.P_INSERT_T_DOCTOR(
                           CLS.CHEECK_CODE
                         , ref CLS.CLIENT_CODE
                         , DOCTOR_NAME_ARTextBoxX.Text
                         , TXT_DOCOTOR_EN.Text
                         , TXT_INF_AR.Text
                         , TXT_INF_EN.Text
                         , TXT_PHONE.Text
                         , TXT_ADDRESS.Text
                         , TXT_REG_NUM.Text
                         , Convert.ToInt32(major_COMB.SelectedValue)
                         , Convert.ToInt32(mAJOR_DETAILS_NAMEComboBox.SelectedValue)
                         , Convert.ToDecimal(TXT_PRECENTAGE.Text)
                         , Convert.ToInt32(gROUP_NAMEComboBox.SelectedValue)
                         , Convert.ToDecimal(TXT_KASHFIA.Text)
                         , Convert.ToInt32(TXT_PRECENTAGE_KISH.Text)
                         , true
                         , CLS.BRANCH_ID
                         , 1
                         , ref CLS.SUBMIT_FLAG);
                    }
                    else
                    {
                        INSERTED.P_INSERT_T_DOCTOR(
                              CLS.CHEECK_CODE
                            , ref CLS.CLIENT_CODE
                            , DOCTOR_NAME_ARTextBoxX.Text
                            , TXT_DOCOTOR_EN.Text
                            , TXT_INF_AR.Text
                            , TXT_INF_EN.Text
                            , TXT_PHONE.Text
                            , TXT_ADDRESS.Text
                            , TXT_REG_NUM.Text
                            , Convert.ToInt32(major_COMB.SelectedValue)
                            , Convert.ToInt32(mAJOR_DETAILS_NAMEComboBox.SelectedValue)
                            , Convert.ToDecimal(TXT_PRECENTAGE.Text)
                            , Convert.ToInt32(gROUP_NAMEComboBox.SelectedValue)
                            , Convert.ToDecimal(TXT_KASHFIA.Text)
                            , Convert.ToInt32(TXT_PRECENTAGE_KISH.Text)
                            , true
                            , CLS.BRANCH_ID
                            , 0
                            , ref CLS.SUBMIT_FLAG);
                    }
                 

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        DOCTOR_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                        button3_Click(null, null);
                        DOCTOR_NAME_ARTextBoxX.Focus();
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (DOCTOR_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(DOCTOR_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (mAJOR_DETAILS_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد التخصص ثم اعادة المحاولة");
                    return;
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {
                    if (TXT_KASHFIA.Text == "")
                    {

                        TXT_KASHFIA.Text = "0.0";
                    }
                    if (TXT_PRECENTAGE.Text == "")
                    {

                        TXT_PRECENTAGE.Text = "0.0";
                    }

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_DOCTOR(Convert.ToInt32(DOCTOR_CODETextBoxX.Text)
                        , DOCTOR_NAME_ARTextBoxX.Text
                        , TXT_DOCOTOR_EN.Text
                        , TXT_INF_AR.Text
                        , TXT_INF_EN.Text
                        , TXT_PHONE.Text
                        , TXT_ADDRESS.Text
                        , TXT_REG_NUM.Text
                        , Convert.ToInt32(major_COMB.SelectedValue)
                        , Convert.ToInt32(mAJOR_DETAILS_NAMEComboBox.SelectedValue)
                        , Convert.ToInt32(gROUP_NAMEComboBox.SelectedValue)
                        , true
                        , Convert.ToDecimal(TXT_PRECENTAGE.Text)
                        , Convert.ToDecimal(TXT_PRECENTAGE_KISH.Text)
                        , Convert.ToDecimal( TXT_KASHFIA.Text)
                        , ref  CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        DOCTOR_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                        MSG.Msg.Alart(AlartType.Update);
                        gROUP_NAMEComboBox.SelectedIndex = -1;
                        major_COMB.SelectedIndex = -1;
                        mAJOR_DETAILS_NAMEComboBox.SelectedIndex = -1;
                        button3_Click(null, null);

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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (DOCTOR_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(DOCTOR_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
 MSG.Msg.Alart(AlartType.Error);
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_DELETE_T_DOCTOR(Convert.ToInt32(DOCTOR_CODETextBoxX.Text), ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        DOCTOR_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
 
        private void DOCTOR_COMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_MAJOR_DETAILS_BY_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_MAJOR_DETAILS_BY_CODE, Convert.ToString(major_COMB.SelectedValue));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DOCTOR_NAME_ARTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_DOCOTOR_EN.Focus();
            } if (e.KeyCode == Keys.Enter)
            {
                TXT_DOCOTOR_EN.Focus();
            }
        }

        private void TXT_DOCOTOR_EN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_INF_AR.Focus();
            }
        }

        private void TXT_INF_AR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_INF_EN.Focus();
            }
        }

        private void TXT_INF_EN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_KASHFIA.Focus();
            }
        }

        private void TXT_KASHFIA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PRECENTAGE_KISH.Focus();
            }
        }

        private void TXT_PRECENTAGE_KISH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ADDRESS.Focus();
            }
        }

        private void TXT_ADDRESS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PHONE.Focus();
            }
        }

        private void TXT_PHONE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PRECENTAGE.Focus();
            }
        }

        private void TXT_PRECENTAGE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_REG_NUM.Focus();
            }
        }

        private void TXT_REG_NUM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                major_COMB.Focus();
            }
        }

        private void major_COMB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mAJOR_DETAILS_NAMEComboBox.Focus();
            }
        }

        private void mAJOR_DETAILS_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.Focus();
            }
        }

        private void TXT_KASHFIA_TextChanged(object sender, EventArgs e)
        {
            try
            {
         
                this.TXT_KASHFIA.Text = Convert.ToDecimal(this.TXT_KASHFIA.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_KASHFIA.SelectionStart = TXT_KASHFIA.TextLength;

            }
            catch
            {
                return;
            }
        }

        private void TXT_PRECENTAGE_TextChanged(object sender, EventArgs e)
        {
            //try
            //{

            //    this.TXT_PRECENTAGE.Text = Convert.ToDecimal(this.TXT_PRECENTAGE.Text).ToString("N0", new CultureInfo("en-US"));
            //    this.TXT_PRECENTAGE.SelectionStart = TXT_PRECENTAGE.TextLength;

            //}
            //catch
            //{
            //    return;
            //}
        }
    }
}
