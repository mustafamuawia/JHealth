using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.PURCHES
{
    public partial class FRM_SEARCH_PURCHES : Form
    {

        public FRM_SEARCH_PURCHES()
        {
            InitializeComponent();

        }

        private void buttonX8_Click(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {


            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);


        }

   
        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_PURCHES_TO_EDITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_TO_EDIT, "");
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
                this.p_GET_PURCHES_TO_EDITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_TO_EDIT, TXT_SEARCH .Text );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }
       
 DataTable DT = new DataTable();
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
               
                DT.Clear();
            ((PURCHES.FRM_PURCHERS)Application.OpenForms["FRM_PURCHERS"]).TXT_ID_PURCHES .Text  =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((PURCHES.FRM_PURCHERS)Application.OpenForms["FRM_PURCHERS"]).DATE_PURCHER.Text =
                      dataGridView2.CurrentRow.Cells[1].Value.ToString();
            ((PURCHES.FRM_PURCHERS)Application.OpenForms["FRM_PURCHERS"]).TXT_TOTAL.Text =
                     dataGridView2.CurrentRow.Cells[4].Value.ToString();
            ((PURCHES.FRM_PURCHERS)Application.OpenForms["FRM_PURCHERS"]).TXT_PAID .Text =
                     dataGridView2.CurrentRow.Cells[5].Value.ToString();
            ((PURCHES.FRM_PURCHERS)Application.OpenForms["FRM_PURCHERS"]).TXT_REMAIN.Text =
                     dataGridView2.CurrentRow.Cells[6].Value.ToString();
            ((PURCHES.FRM_PURCHERS)Application.OpenForms["FRM_PURCHERS"]).cLIENT_NAME_ARComboBox .SelectedValue  =
                  Convert .ToInt32 (dataGridView2.CurrentRow.Cells[7].Value);
            ((PURCHES.FRM_PURCHERS)Application.OpenForms["FRM_PURCHERS"]).dOCTOR_NAMEComboBox .SelectedValue =
                 Convert.ToInt32(dataGridView2.CurrentRow.Cells[9].Value.ToString());
              
                this.p_GET_PURCHES_DEATILS_BY_NUMBERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_DEATILS_BY_NUMBER, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView2.CurrentRow.Cells[0].Value, typeof(int))))));
            DT = this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_DEATILS_BY_NUMBER;
            ((PURCHES.FRM_PURCHERS)Application.OpenForms["FRM_PURCHERS"]).dataGridView1.Rows.Clear(); ;

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                ((PURCHES.FRM_PURCHERS)Application.OpenForms["FRM_PURCHERS"]).dataGridView1.Rows.Add(
                      DT.Rows[i][2].ToString()
                    , DT.Rows[i][3].ToString()
                    , DT.Rows[i][4].ToString()
                    , DT.Rows[i][6].ToString()
                    , DT.Rows[i][7].ToString()
                    , DT.Rows[i][8].ToString());

            }
            this.Dispose();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_PURCHES_TO_EDITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_TO_EDIT,"");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_PURCHES_DEATILS_BY_NUMBERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_DEATILS_BY_NUMBER, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView2 .CurrentRow .Cells [0].Value, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
