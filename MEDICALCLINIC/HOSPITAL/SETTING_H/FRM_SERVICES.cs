using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.SETTING_H
{
    public partial class FRM_SERVICES : MEDICALCLINIC.HOSPITAL.BaseHospital
    {

        public FRM_SERVICES()
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
            this.gET_H_SERVICE_TYP_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_SERVICE_TYP_NAME_CODE,  "");

        }
     
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (SERVICE_NAME.Text=="")
                {

                    errorProvider1.SetError(SERVICE_NAME, CLS.TXT_NULL);
                }
                if (SERVICE_NAME.Text == "")
                {

                    errorProvider1.SetError(SERVICE_NAME, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (DEP_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(DEP_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                 

                    INSERTED.P_INSERT_T_H_SERVICES_TYPE(
                                 CLS.CHEECK_CODE
                                 , CLS.CLIENT_CODE
                             , SERVICE_NAME.Text
                             , Convert.ToDecimal(TXT_PRICE.Text)
                           , Convert.ToInt32(TXT_P_DOCT.Text)
                           , Convert.ToInt32(TXT_P_HOSPITAL.Text)
                          
                           , ""
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
                this.gET_H_SERVICE_TYP_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_SERVICE_TYP_NAME_CODE, TXT_SEARCH.Text);
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
            DEP_CODE.Text = "";
            SERVICE_NAME.Text = "";
            TXT_PRICE.Text = "";
            TXT_P_DOCT.Text = "";
            TXT_P_HOSPITAL.Text = "";
           
            SERVICE_NAME.Focus();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (SERVICE_NAME.Text == "")
                {

                    errorProvider1.SetError(SERVICE_NAME, CLS.TXT_NULL);
                }


            if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    if (DEP_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(DEP_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                   
                  
                   
                    INSERTED.P_UPDATE_T_H_SERVICES_TYPE(
                     Convert.ToInt32(DEP_CODE.Text)
                           ,  SERVICE_NAME.Text
                             , Convert.ToDecimal(TXT_PRICE.Text)
                           , Convert.ToInt32(TXT_P_DOCT.Text)
                           , Convert.ToInt32(TXT_P_HOSPITAL.Text)

                           , ""
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
                
                if (DEP_CODE.Text == "")
                {

                    errorProvider1.SetError(DEP_CODE, CLS.TXT_NULL);
                }



 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_EMP_TYPE(

                              Convert.ToInt32(DEP_CODE.Text)

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
            SERVICE_NAME.Focus();
        }

        private void gET_EMP_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gET_EMP_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
                {
                  
                    DEP_CODE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                    SERVICE_NAME.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();
                     
                    TXT_PRICE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[3].Value.ToString();
                    TXT_P_DOCT.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[4].Value.ToString();
                    TXT_P_HOSPITAL.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[5].Value.ToString();



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
                TXT_PRICE.Focus();
            }
        }

       

        private void NOTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_SAVE_Click(null, null);
            }
        }

      

       
       

        private void TXT_PRICE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_P_DOCT.Focus();
            }
        }

        private void TXT_P_DOCT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_P_HOSPITAL.Focus();
            }
        }

        private void TXT_P_HOSPITAL_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                BTN_SAVE_Click(null, null);
            }
           
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
