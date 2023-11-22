using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.SANAD
{
    public partial class FRM_SEARCH_SANAD : Form
    {

        public FRM_SEARCH_SANAD()
        {
            InitializeComponent();
        }
       
        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
           
            try
            {
                this.p_BOX_ALLTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_BOX_ALL, TXT_SEARCH.Text, dateTimePicker1.Value,dateTimePicker2.Value,1);
                //foreach (DataGridViewRow row in dataGridView2.Rows)
                //{
                //    row.Cells[13].ReadOnly = false;
                //    row.Cells[13].Value = row.Cells[13].Value.ToString().Replace("-", System.Environment.NewLine);
                //}
            }
            catch (System.Exception ex)
            {
             //   System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.p_BOX_ALLTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_BOX_ALL, TXT_SEARCH.Text, dateTimePicker1.Value, dateTimePicker2.Value, 1);
                //foreach (DataGridViewRow row in dataGridView2.Rows)
                //{
                //    row.Cells[13].ReadOnly = false;
                //    row.Cells[13].Value = row.Cells[13].Value.ToString().Replace("-", System.Environment.NewLine);
                //}
            }
            catch (System.Exception ex)
            {
                //   System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==14)
            {
                //BTN_DETAILS_Click(null, null);
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {
                    var DELETE_BOX = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    DELETE_BOX.P_DELETE_T_BOX(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value),CLS.USER_CODE.ToString(), ref CLS.SUBMIT_FLAG);

                    //DELETE_BOX.P_DELETE_T_BOX(Convert.ToInt32(BILL_NUMBERTextBoxX.Text + 1), Convert.ToInt32(B_NAMEComboBox.SelectedValue), "DELETE BY " + CLS.USER_NAME + " IN  " + DateTime.Now, ref CLS.SUBMIT_FLAG);
                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                       /// FRM_SEARCH_SANAD_Load(null, null);
                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }
           
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {

            //((FRM_SANAD)Application.OpenForms["FRM_SANAD"]).BILL_NUMBERTextBoxX.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            //((FRM_SANAD)Application.OpenForms["FRM_SANAD"]).BILL_DATEDateTimePicker.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            //((FRM_SANAD)Application.OpenForms["FRM_SANAD"]).ACCOUNT_FROMCODETextBoxX.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            //((FRM_SANAD)Application.OpenForms["FRM_SANAD"]).FROM_ACCOUNTTextBoxX.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
            //((FRM_SANAD)Application.OpenForms["FRM_SANAD"]).ACCOUNT_TOCODETextBoxX.Text = dataGridView2.CurrentRow.Cells[19].Value.ToString();
            //((FRM_SANAD)Application.OpenForms["FRM_SANAD"]).TO_ACCOUNTTextBoxX.Text = dataGridView2.CurrentRow.Cells[21].Value.ToString();
            //((FRM_SANAD)Application.OpenForms["FRM_SANAD"]).AMO_DEBITTextBoxX.Text = dataGridView2.CurrentRow.Cells[13].Value.ToString();
            //((FRM_SANAD)Application.OpenForms["FRM_SANAD"]).AMO_DEBIT_IQTextBoxX.Text = dataGridView2.CurrentRow.Cells[15].Value.ToString();
            //// ((FRM_SANAD)Application.OpenForms["FRM_SANAD"]).DESCRIPTIONTextBoxX.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();
            this.Dispose();
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //((MEDICAL_CLINIC_DBDataSet.P_BOX_ALLDataTable)p_BOX_ALLBindingSource.DataSource).Columns[10].ReadOnly = false;
            //dataGridView2.Columns[10].ReadOnly = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_BOX_ALLTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_BOX_ALL, TXT_SEARCH.Text, dateTimePicker1.Value, dateTimePicker2.Value,1);
                //foreach (DataGridViewRow row in dataGridView2.Rows)
                //{
                //    row.Cells[13].ReadOnly = false;
                //    row.Cells[13].Value = row.Cells[13].Value.ToString().Replace("-", System.Environment.NewLine);
                //}
            }
            catch (System.Exception ex)
            {
             //   System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_BOX_ALLTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_BOX_ALL, TXT_SEARCH.Text, dateTimePicker1.Value, dateTimePicker2.Value, 2);
                //foreach (DataGridViewRow row in dataGridView2.Rows)
                //{
                //    row.Cells[13].ReadOnly = false;
                //    row.Cells[13].Value = row.Cells[13].Value.ToString().Replace("-", System.Environment.NewLine);
                //}
            }
            catch (System.Exception ex)
            {
              //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.p_BOX_ALLTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_BOX_ALL, iD_BOXToolStripTextBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fdateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(edateToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(idflagToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
