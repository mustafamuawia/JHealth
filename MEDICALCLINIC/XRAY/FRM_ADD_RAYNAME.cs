using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.XRAY
{
    public partial class FRM_ADD_RAYNAME :MEDICALCLINIC.XRAY. basexray
    {

        public FRM_ADD_RAYNAME()
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
            this.gET_RAY_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RAY_NAME_CODE, "");
            this.v_GET_A_RAY_TYPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_RAY_TYP);

        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMB_RAY_TYP.SelectedIndex == -1)
                {

                    errorProvider1.SetError(COMB_RAY_TYP, CLS.TXT_NULL);
                }
                if (RAY_NAME.Text == "")
                {

                    errorProvider1.SetError(RAY_NAME, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (RAY_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(RAY_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                  
                    INSERTED.P_INSERT_T_H_RAYNAME(

                             RAY_NAME.Text
                             ,Convert.ToDecimal( TXT_PRICE.Text)
                             
                           , Convert.ToInt32(COMB_RAY_TYP.SelectedValue)
                           
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
                this.gET_RAY_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RAY_NAME_CODE, TXT_SEARCH.Text);
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
            RAY_CODE.Text = "";
            RAY_NAME.Text = "";
            COMB_RAY_TYP.SelectedValue = -1;
          
            RAY_NAME.Focus();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMB_RAY_TYP.SelectedIndex == -1)
                {

                    errorProvider1.SetError(COMB_RAY_TYP, CLS.TXT_NULL);
                }
                if (RAY_NAME.Text == "")
                {

                    errorProvider1.SetError(RAY_NAME, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (RAY_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(RAY_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    
                    INSERTED.P_UPDATE_T_H_RAYNAME(
                       Convert.ToInt32(RAY_CODE.Text)
                             ,  RAY_NAME.Text
                             , Convert.ToDecimal(TXT_PRICE.Text)

                           , Convert.ToInt32(COMB_RAY_TYP.SelectedValue)

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
                if (COMB_RAY_TYP.SelectedIndex == -1)
                {

                    errorProvider1.SetError(COMB_RAY_TYP, CLS.TXT_NULL);
                }
                if (RAY_CODE.Text == "")
                {

                    errorProvider1.SetError(RAY_CODE, CLS.TXT_NULL);
                }



 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_H_RAYNAME(

                              Convert.ToInt32(RAY_CODE.Text)

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
            RAY_NAME.Focus();
        }

        private void gET_EMP_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gET_EMP_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
                {
                   
                    RAY_CODE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                    RAY_NAME.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();
                    COMB_RAY_TYP.SelectedValue = Convert.ToInt32(gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[4].Value);
                     
                    TXT_PRICE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[3].Value.ToString();
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
                COMB_RAY_TYP.Focus();
            }
        }

     

       
       

        private void NOTE_KeyDown(object sender, KeyEventArgs e)
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
