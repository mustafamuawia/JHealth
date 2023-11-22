using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.LAB
{
    public partial class FRM_LAB_NAME : MEDICALCLINIC.LAB.baselab
    {

        public FRM_LAB_NAME()
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
               this.gET_LABNAME_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LABNAME_NAME_CODE, TXT_SEARCH.Text);

        }
       
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            { 
                if (LAB_NAME.Text == "")
                {

                    errorProvider1.SetError(LAB_NAME, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (LAB_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(LAB_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                  
                    
                    INSERTED.P_INSERT_T_H_LABNAME(

                             LAB_NAME.Text
                             ,ADDRESS.Text
                             ,PHONE.Text
                            
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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_EMP_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_EMP_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_LABNAME_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LABNAME_NAME_CODE, TXT_SEARCH.Text);
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
            LAB_CODE.Text = "";
            LAB_NAME.Text = "";
           
            LAB_NAME.Focus();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (LAB_NAME.Text == "")
                {

                    errorProvider1.SetError(LAB_NAME, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (LAB_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(LAB_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                   
                    INSERTED.P_UPDATE_T_H_LABNAME(
                    Convert.ToInt32(LAB_CODE.Text)
                            , LAB_NAME.Text
                           , ADDRESS.Text
                           ,PHONE.Text
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
               
                if (LAB_CODE.Text == "")
                {

                    errorProvider1.SetError(LAB_CODE, CLS.TXT_NULL);
                }



 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_H_LABNAME(

                              Convert.ToInt32(LAB_CODE.Text)

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
            LAB_NAME.Focus();
        }

        private void gET_EMP_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gET_EMP_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
                {
                  
                    LAB_CODE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                    LAB_NAME.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();

                    PHONE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[4].Value.ToString();
                    ADDRESS.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

       
   
        private void NOTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_SAVE_Click(null, null);
            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.gET_B_DEPART_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_B_DEPART_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
      

      
    }
}
