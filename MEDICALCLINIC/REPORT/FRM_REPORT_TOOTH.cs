using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_REPORT_TOOTH : Form
    {
        public FRM_REPORT_TOOTH()
        {
            InitializeComponent();
        }

        private void FRM_R_TOOTH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR_1' table. You can move, or remove it, as needed.
            this.v_A_DOCTOR_1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR_1);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_TREATMENT' table. You can move, or remove it, as needed.
            this.v_GET_A_TREATMENTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_TREATMENT);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_CLASS' table. You can move, or remove it, as needed.
            this.v_GET_A_CLASSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_CLASS);

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_R_GET_TOOTH_TRAT_CLASSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_R_GET_TOOTH_TRAT_CLASS, cLASS_NAMEComboBox.Text, Convert.ToInt32(dOCTOR_NAMEComboBox1.SelectedValue));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_R_GET_TOOTH_TRAT_CLASS;
                LBL_TOTAL.Text =
                       (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[4].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
               try
            {
                this.p_R_GET_TOOTH_TRAT_CLASSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_R_GET_TOOTH_TRAT_CLASS, tREATMENT_NAMEComboBox.Text ,Convert .ToInt32 (dOCTOR_NAMEComboBox2.SelectedValue ));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_R_GET_TOOTH_TRAT_CLASS;
                   LBL_TOTAL.Text =
                    (from DataGridViewRow row in dataGridView1.Rows
                     where row.Cells[4].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_R_GET_TOOTH_TRAT_CLASS_TOW_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_R_GET_TOOTH_TRAT_CLASS_TOW_DATE, tREATMENT_NAMEComboBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE2.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE1.Text, typeof(System.DateTime))))), Convert.ToInt32(dOCTOR_NAMEComboBox2.SelectedValue));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_R_GET_TOOTH_TRAT_CLASS_TOW_DATE;
                LBL_TOTAL.Text =
                       (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[4].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_R_GET_TOOTH_TRAT_CLASS_TOW_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_R_GET_TOOTH_TRAT_CLASS_TOW_DATE, cLASS_NAMEComboBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE2.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE1.Text, typeof(System.DateTime))))), Convert.ToInt32(dOCTOR_NAMEComboBox1.SelectedValue));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_R_GET_TOOTH_TRAT_CLASS_TOW_DATE;
                LBL_TOTAL.Text =
                       (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[4].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

      
    }
}
