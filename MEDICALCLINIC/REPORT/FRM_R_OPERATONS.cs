using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_R_OPERATONS : Form
    {
        public FRM_R_OPERATONS()
        {
            InitializeComponent();
        }

        private void FRM_R_TOOTH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DES_OPERATION' table. You can move, or remove it, as needed.
            this.v_A_DES_OPERATIONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DES_OPERATION);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_TREATMENT' table. You can move, or remove it, as needed.
            this.v_GET_A_TREATMENTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_TREATMENT);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_CLASS' table. You can move, or remove it, as needed.
            this.v_GET_A_CLASSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_CLASS);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_R_GET_booking_operationsTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_R_GET_booking_operations, dESC_NAMEComboBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox .SelectedValue , typeof(int))))));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_R_GET_booking_operations;
                LBL_TOTAL.Text =
                       (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[7].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.p_R_GET_booking_operations_two_dateTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_R_GET_booking_operations_two_date, dESC_NAMEComboBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Text, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_R_GET_booking_operations_two_date;
                LBL_TOTAL.Text =
                      (from DataGridViewRow row in dataGridView1.Rows
                       where row.Cells[7].FormattedValue.ToString() != string.Empty
                       select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
