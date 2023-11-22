using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SEARCH_SELAS : Form
    {
        int ID_O;
        public FRM_SEARCH_SELAS(int ID_ORDER )
        {
            InitializeComponent();
            ID_O = ID_ORDER;

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
         
        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {

            try
            {
                this.p_GET_ORDER_FOR_EDITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_FOR_EDIT,"");
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
                this.p_GET_ORDER_FOR_EDITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_FOR_EDIT,TXT_SEARCH .Text );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }



        }
        DataTable dt = new DataTable();
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                this.p_GET_ORDER_DETAILS_FOR_EDIT_BY_IDTableAdapter .Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_DETAILS_FOR_EDIT_BY_ID ,Convert .ToInt32 (dataGridView2 .CurrentRow .Cells [5].Value ));
                dt = this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_DETAILS_FOR_EDIT_BY_ID;

                for (int i = 0; i < dt .Rows.Count ; i++)
                {
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).dgv_order.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][4].ToString());
                }


                ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_ID_ORDER.Text = dt.Rows[1][5].ToString();
                ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).DATE_ORDER.Text = dt.Rows[1][7].ToString();
                ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).LBL_NAMEPERSON .SelectedValue  = dt.Rows[1][8].ToString();
                ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).dOCTOR_NAMEComboBox  .SelectedValue  = dt.Rows[1][9].ToString();
                ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_ID_BOOKING.Text = dt.Rows[1][11].ToString();
                ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_TOTAL.Text = dt.Rows[1][12].ToString();
                ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_PAID.Text = dt.Rows[1][13].ToString();
                ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_REMAIN.Text = dt.Rows[1][14].ToString();
        
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

       

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

      
    
    }
}
