using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_H_ITEM : MEDICALCLINIC.SETTING.BASEANYFORM
    {

        public FRM_H_ITEM()
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
        private void buttonX3_Click(object sender, EventArgs e)
        {

            //B_NAMEComboBox.SelectedValue = -1;
        }

        private void CLIENT_NAME_ARTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BARCODETextBoxX.Focus();
            }
        }

        private void CLIENT_NAME_ENTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GROUPComboBox.Focus();
            }
        }

     

        private void t_CATEGORIESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_CATEGORIESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mEDICAL_CLINIC_DBDataSet);

        }

        private void FRM_ITEM_Load(object sender, EventArgs e)
        { 
        try
            {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_CATEG' table. You can move, or remove it, as needed.
            this.v_GET_H_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_CATEG);
          
                this.gET_ITEM_H_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ITEM_H_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEARCH_ITEMS FRM = new SEARCH.FRM_SEARCH_ITEMS();
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
                if (ITEM_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(ITEM_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (ITEM_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(ITEM_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_H_ITEMS(
                          CLS.CHEECK_CODE
                        , ref CLS.CLIENT_CODE
                        , BARCODETextBoxX.Text
                        , ITEM_NAME_ARTextBoxX.Text
                        , Convert.ToInt32(GROUPComboBox.SelectedValue)
                        ,Convert.ToDecimal(TXT_PRICE.Text)
                        , true
                        
                        , ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        FRM_ITEM_Load(null, null);
                            MSG.Msg.Alart(AlartType.Save);
                        ITEM_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (ITEM_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(ITEM_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_H_ITEM(
                          Convert.ToInt32(ITEM_CODETextBoxX.Text)
                        , BARCODETextBoxX.Text
                        , ITEM_NAME_ARTextBoxX.Text
                        , Convert.ToInt32(GROUPComboBox.SelectedValue)
                        
                        , true
                        , Convert.ToDecimal(TXT_PRICE.Text)
                        , ref CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        FRM_ITEM_Load(null, null);
                        ITEM_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (ITEM_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(ITEM_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_H_ITEM(Convert.ToInt32(ITEM_CODETextBoxX.Text), ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        FRM_ITEM_Load(null, null);
                        MSG.Msg.Alart(AlartType.Delete);
                        ITEM_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

      
        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_ITEM_H_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ITEM_H_NAME_CODE, TXT_PRICE.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void gET_ITEM_H_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gET_ITEM_H_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
            {
                ITEM_CODETextBoxX.Text = gET_ITEM_H_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                BARCODETextBoxX.Text = gET_ITEM_H_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();
                ITEM_NAME_ARTextBoxX.Text = gET_ITEM_H_NAME_CODEDataGridView.CurrentRow.Cells[3].Value.ToString();
                GROUPComboBox.SelectedValue =Convert.ToInt32( gET_ITEM_H_NAME_CODEDataGridView.CurrentRow.Cells[5].Value );


            }
        }

       

        private void gET_ITEM_H_NAME_CODEDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gET_ITEM_H_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
            {
                ITEM_CODETextBoxX.Text = gET_ITEM_H_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                BARCODETextBoxX.Text = gET_ITEM_H_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();
                ITEM_NAME_ARTextBoxX.Text = gET_ITEM_H_NAME_CODEDataGridView.CurrentRow.Cells[3].Value.ToString();
                GROUPComboBox.SelectedValue = Convert.ToInt32(gET_ITEM_H_NAME_CODEDataGridView.CurrentRow.Cells[5].Value);
                TXT_PRICE.Text = gET_ITEM_H_NAME_CODEDataGridView.CurrentRow.Cells[7].Value.ToString();


            }
        }
    }
}
