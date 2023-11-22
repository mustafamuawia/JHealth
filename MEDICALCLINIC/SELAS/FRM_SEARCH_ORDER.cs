using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.SELAS
{
    public partial class FRM_SEARCH_ORDER : Form
    { DataTable dt = new DataTable();
        public FRM_SEARCH_ORDER()
        {
           
            InitializeComponent();
        }

        private void FRM_SEARCH_ORDER_Load(object sender, EventArgs e)
        {

            try
            {
                this.p_GET_ORDER_FOR_EDITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_FOR_EDIT, "");
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
                this.p_GET_ORDER_FOR_EDITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_FOR_EDIT, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 11)
                {
                    dt.Clear();
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).dgv_order.Rows.Clear();
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_TOTAL.Text = "0.00";
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_PAID.Text = "0.00";
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_REMAIN.Text = "0.00";
                    this.p_GET_ORDER_DETAILS_FOR_EDIT_BY_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_DETAILS_FOR_EDIT_BY_ID, Convert.ToInt32(dataGridView2.CurrentRow.Cells[5].Value));
                    dt = this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_DETAILS_FOR_EDIT_BY_ID;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).dgv_order.Rows.Add(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][4].ToString());
                    }


                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_ID_ORDER.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).DATE_ORDER.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).LBL_NAMEPERSON.SelectedValue = dataGridView2.CurrentRow.Cells[2].Value;
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).dOCTOR_NAMEComboBox .SelectedValue = dataGridView2.CurrentRow.Cells[4].Value;
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_ID_BOOKING.Text = dt.Rows[0][11].ToString();
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_TOTAL.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_PAID.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                    ((SELAS.FRM_SEALS)Application.OpenForms["FRM_SEALS"]).TXT_REMAIN.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
                }
                this.Dispose();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {
                dataGridView2_CellContentClick(null, null);
        
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
