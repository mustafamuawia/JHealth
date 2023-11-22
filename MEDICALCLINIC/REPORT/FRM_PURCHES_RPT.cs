using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_PURCHES_RPT : Form
    {

        public FRM_PURCHES_RPT()
        {
            InitializeComponent();
        }

      

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
  
       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.p_GET_PURCHES_ONEDATE_PRTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_ONEDATE_PRT, TXT_SEARCH.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_DAY.Value, typeof(System.DateTime))))));
            //    dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_ONEDATE_PRT;
            //    LBL_T_CREDIT.Text =
            //    (from DataGridViewRow row in dataGridView2.Rows
            //     where row.Cells[7].FormattedValue.ToString() != string.Empty
            //     select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                this.p_GET_PURCHES_PRTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_PRT, Convert.ToString(iTEM_MAMEComboBox.SelectedValue),Convert .ToInt32 ( dOCTOR_NAMEComboBox.SelectedValue));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_PRT;
                LBL_T_CREDIT.Text =
                (from DataGridViewRow row in dataGridView2.Rows
                 where row.Cells[7].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
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
                this.p_GET_PURCHES_TOWDATE_PRTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_TOWDATE_PRT, iTEM_MAMEComboBox.SelectedValue.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE3.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE3.Value, typeof(System.DateTime))))));
             dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_TOWDATE_PRT;
             LBL_T_CREDIT.Text =
             (from DataGridViewRow row in dataGridView2.Rows
              where row.Cells[7].FormattedValue.ToString() != string.Empty
              select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
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
                CLS.TEXT_FOR_REPORT = iTEM_MAMEComboBox.SelectedValue.ToString();
                CLS.F_DATE_PRT = F_DATE3.Text;
                CLS.E_DATE_PRT = E_DATE3.Text;
                PRINT.PPRINT_PURCHES.FRM_RPT_PURCHES_TOW_DATE_F FRM = new PRINT.PPRINT_PURCHES.FRM_RPT_PURCHES_TOW_DATE_F();
                FRM.ShowDialog();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
           
            //try
            //{
            //    CLS.F_DATE_PRT = DATE_DAY.Text;
            //    CLS.TEXT_FOR_REPORT = TXT_SEARCH.Text;
            //    PRINT.PPRINT_PURCHES.FRM_RPT_PRUCHES_F FRM = new PRINT.PPRINT_PURCHES.FRM_RPT_PRUCHES_F();
            //    FRM.ShowDialog();
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                CLS.TEXT_FOR_REPORT = iTEM_MAMEComboBox .Text;
                CLS.F_DATE_PRT = F_DATE3.Text;
                CLS.E_DATE_PRT = E_DATE3.Text;
                PRINT.PPRINT_PURCHES.FRM_RPT_PURCHES_TOW_DATE_F FRM = new PRINT.PPRINT_PURCHES.FRM_RPT_PURCHES_TOW_DATE_F();
                FRM.ShowDialog();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

       

       

        private void FRM_PURCHES_RPT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_CATEG' table. You can move, or remove it, as needed.
            this.v_A_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_CATEG);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_ITEM' table. You can move, or remove it, as needed.
            this.v_GET_A_ITEMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_ITEM);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_PURCHES_TOWDATE_PRTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_TOWDATE_PRT, iTEM_MAMEComboBox.SelectedValue.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE1.Value, typeof(System.DateTime))))));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_TOWDATE_PRT;
                LBL_T_CREDIT.Text =
                (from DataGridViewRow row in dataGridView2.Rows
                 where row.Cells[7].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_PURCHES_BY_CATEG_PRTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_BY_CATEG_PRT, new System.Nullable<int>(((int)(System.Convert.ChangeType(cATEGORIS_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue , typeof(int))))));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_BY_CATEG_PRT;
                LBL_T_CREDIT.Text =
                (from DataGridViewRow row in dataGridView2.Rows
                 where row.Cells[7].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
 
        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_PURCHES_BY_CATEG_TOW_DATE_PRTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_BY_CATEG_TOW_DATE_PRT, Convert.ToInt32(cATEGORIS_NAMEComboBox.SelectedValue), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE2.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE2.Value, typeof(System.DateTime))))));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_BY_CATEG_TOW_DATE_PRT;
                LBL_T_CREDIT.Text =
                (from DataGridViewRow row in dataGridView2.Rows
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
                this.p_GET_PURCHES_BY_DOCTOR_TWO_DATE_PRTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_BY_DOCTOR_TWO_DATE_PRT, new System.Nullable<int>(((int)(System.Convert.ChangeType(Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE3.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE3.Value, typeof(System.DateTime))))));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_BY_DOCTOR_TWO_DATE_PRT;
                LBL_T_CREDIT.Text =
                (from DataGridViewRow row in dataGridView2.Rows
                 where row.Cells[7].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_PURCHES_BY_DOCTOR_PRTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_BY_DOCTOR_PRT, new System.Nullable<int>(((int)(System.Convert.ChangeType(Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), typeof(int))))));
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_PURCHES_BY_DOCTOR_PRT;
                LBL_T_CREDIT.Text =
                (from DataGridViewRow row in dataGridView2.Rows
                 where row.Cells[7].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

   
    }
}
