using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_EMP : USERSE.masterfrm
    {
        
        public FRM_EMP( )
        {
            InitializeComponent();
          
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADD_OPERATN_INFO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_GROUP_ROLE' table. You can move, or remove it, as needed.
            this.v_GET_GROUP_ROLETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_GROUP_ROLE);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_EMP_TYPE' table. You can move, or remove it, as needed.
            try
            {
                this.v_GET_EMP_TYPETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_EMP_TYPE);

                this.gET_EMP_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_EMP_NAME_CODE, "");
                tYPE_EMPLOYEEComboBox.SelectedIndex = -1;
                }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (tYPE_EMPLOYEEComboBox.SelectedIndex == -1  )
                {

                    errorProvider1.SetError(tYPE_EMPLOYEEComboBox, CLS.TXT_NULL);
                }
                if (EMP_NAME.Text==""  )
                {

                    errorProvider1.SetError(EMP_NAME, CLS.TXT_NULL);
                }
                

 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (EMP_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(EMP_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_EMP(
                             CLS.CHEECK_CODE
                           , CLS.CLIENT_CODE
                           , EMP_NAME.Text
                           , Convert.ToInt32(tYPE_EMPLOYEEComboBox.SelectedValue)
                           , 0
                           , Convert.ToDecimal( SALARY_EMP.Text)
                           , Convert.ToDecimal(TXT_PERCENT.Text)
                           , PHONE.Text
                           , ADDRESS.Text
                           , EMAIL.Text
                           , NOTE.Text
                           , 0
                           , true
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_OPERATN_INFO_Load(null, null);
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

       

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
 
                this.gET_EMP_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_EMP_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            EMP_CODE.Text = "";
           EMP_NAME.Text = "";
            tYPE_EMPLOYEEComboBox.SelectedValue = -1;
                            SALARY_EMP.Text = "0";
                            PHONE.Text = "";
                            ADDRESS.Text = "";
                            EMAIL.Text = "";
                            NOTE.Text = "";
                            TXT_PERCENT.Text = "0";

        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (tYPE_EMPLOYEEComboBox.SelectedIndex == -1)
                {

                    errorProvider1.SetError(tYPE_EMPLOYEEComboBox, CLS.TXT_NULL);
                }
                if (EMP_NAME.Text == "")
                {

                    errorProvider1.SetError(EMP_NAME, CLS.TXT_NULL);
                }
                if (SALARY_EMP.Text == "")
                {

                    errorProvider1.SetError(SALARY_EMP, CLS.TXT_NULL);
                }


            if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_EMP(
                        
                              Convert.ToInt32(EMP_CODE.Text)
                            , EMP_NAME.Text
                           , Convert.ToInt32(tYPE_EMPLOYEEComboBox.SelectedValue)
                           , 0
                           , Convert.ToDecimal(SALARY_EMP.Text)
                           , Convert.ToDecimal(TXT_PERCENT.Text)
                           , PHONE.Text
                           , ADDRESS.Text
                           , EMAIL.Text
                           , NOTE.Text
                           , 0
                           , true
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Update);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_OPERATN_INFO_Load(null, null);
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
                tYPE_EMPLOYEEComboBox.IsEmpty();

                EMP_CODE.IsEmpty();  
                



                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_EMP(

                              Convert.ToInt32(EMP_CODE.Text)
                           ,false
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_OPERATN_INFO_Load(null, null);
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

        private void FRM_EMP_Shown(object sender, EventArgs e)
        {
            EMP_NAME.Focus();
        }

        private void gET_EMP_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gET_EMP_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
                {
                    EMP_CODE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                    EMP_NAME.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();
                    tYPE_EMPLOYEEComboBox.SelectedValue = Convert.ToInt32(gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[4].Value);
                    SALARY_EMP.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[5].Value.ToString();
                    PHONE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[6].Value.ToString();
                    ADDRESS.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[7].Value.ToString();
                    EMAIL.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[8].Value.ToString();
                    NOTE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[9].Value.ToString();
                    TXT_PERCENT.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[12].Value.ToString();

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void EMP_NAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tYPE_EMPLOYEEComboBox.Focus();
            }
        }

        private void tYPE_EMPLOYEEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SALARY_EMP.Focus();
            }
        }

        private void SALARY_EMP_TextChanged(object sender, EventArgs e)
        {
            try
            {

                this.SALARY_EMP.Text = Convert.ToDecimal(this.SALARY_EMP.Text).ToString("N0", new System.Globalization.CultureInfo("en-US"));
                this.SALARY_EMP.SelectionStart = SALARY_EMP.TextLength;


            }
            catch
            {
                return;
            }
        }

        private void SALARY_EMP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PERCENT.Focus();
            }
        }

        private void PHONE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ADDRESS.Focus();
            }
        }

        private void ADDRESS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EMAIL.Focus();
            }
        }

        private void EMAIL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NOTE.Focus();
            }
        }

        private void NOTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_SAVE_Click(null, null);
            }
        }

        private void TXT_PERCENT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PHONE.Focus();
            }
        }
    }
}
