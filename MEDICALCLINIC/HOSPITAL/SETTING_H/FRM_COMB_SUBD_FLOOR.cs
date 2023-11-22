using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.SETTING_H
{
    public partial class FRM_COMB_SUBD_FLOOR : MEDICALCLINIC.HOSPITAL.BaseHospital
    {
        int ID_COMB;
        public FRM_COMB_SUBD_FLOOR()
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
        try
            {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_H_SUBDEPARTMENT' table. You can move, or remove it, as needed.
            this.v_H_SUBDEPARTMENTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_H_SUBDEPARTMENT);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR' table. You can move, or remove it, as needed.
            this.v_GET_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR);
           
                this.gET_COMBINE_F_SUB_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COMBINE_F_SUB_NAME_CODE, "");
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
                if (COMB_DEP.SelectedIndex == -1)
                {

                    errorProvider1.SetError(COMB_DEP, CLS.TXT_NULL);
                }

                if (COMB_FLOOR.SelectedIndex == -1)
                {

                    errorProvider1.SetError(COMB_FLOOR, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                  
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                   
                  
                    INSERTED.P_INSERT_T_H_COM( 
                            Convert.ToInt32(COMB_DEP.SelectedValue)
                           , Convert.ToInt32(COMB_FLOOR.SelectedValue)
                           , ref CLS.SUBMIT_FLAG);

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
                this.gET_COMBINE_F_SUB_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COMBINE_F_SUB_NAME_CODE, TXT_SEARCH.Text);
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
           
            COMB_DEP.SelectedValue = -1;

            COMB_FLOOR.SelectedValue = -1;
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMB_DEP.SelectedIndex == -1)
                {

                    errorProvider1.SetError(COMB_DEP, CLS.TXT_NULL);
                }
                if (COMB_FLOOR.SelectedIndex == -1)
                {

                    errorProvider1.SetError(COMB_FLOOR, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                   
                     
                    INSERTED.P_UPDATE_T_H_COM(
                            ID_COMB,
                             Convert.ToInt32(COMB_DEP.SelectedValue)
                           , Convert.ToInt32(COMB_FLOOR.SelectedValue)
                           , ref CLS.SUBMIT_FLAG);

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
                if (COMB_DEP.SelectedIndex == -1)
                {

                    errorProvider1.SetError(COMB_DEP, CLS.TXT_NULL);
                }
                 


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_H_COM(
                    
                              Convert.ToInt32(ID_COMB)
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

      

        private void gET_EMP_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gET_EMP_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
                {
                     
                    COMB_DEP.SelectedValue = Convert.ToInt32(gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[2].Value );
                    COMB_FLOOR.SelectedValue = Convert.ToInt32(gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[3].Value );
                    ID_COMB = Convert.ToInt32(gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[1].Value);

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
                COMB_DEP.Focus();
            }
        }

        
        private void NOTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_SAVE_Click(null, null);
            }
        }

       
    }
}
