using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_RPT_SEALS : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        public FRM_RPT_SEALS()
        {
            InitializeComponent();
        }

        private void FRM_RPT_SEALS_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            this.gET_DOCTOR_BY_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_FLOOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), 2);

        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_SEALSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_SEALS, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                LBL_TOTAL.Text =
                          (from DataGridViewRow row in dgvalldata.Rows
                           where row.Cells[9].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[9].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_SEALSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_SEALS, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                LBL_TOTAL.Text =
                          (from DataGridViewRow row in dgvalldata.Rows
                           where row.Cells[9].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[9].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_SEALSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_SEALS, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                LBL_TOTAL.Text =
                          (from DataGridViewRow row in dgvalldata.Rows
                           where row.Cells[9].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[9].FormattedValue)).Sum().ToString();
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
                this.gET_ALL_SEALSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_SEALS, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                LBL_TOTAL.Text =
                          (from DataGridViewRow row in dgvalldata.Rows
                           where row.Cells[9].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[9].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRINT.PRINT_SALES.FRM_ALL_SEALS FRM = new PRINT.PRINT_SALES.FRM_ALL_SEALS(dOCTOR_NAMEComboBox.SelectedValue.ToInt(), dateTimePicker1.Value, dateTimePicker2.Value, 2);
            FRM.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PRINT.PRINT_SALES.FRM_ALL_SEALS FRM = new PRINT.PRINT_SALES.FRM_ALL_SEALS(dOCTOR_NAMEComboBox.SelectedValue.ToInt(), dateTimePicker1.Value, dateTimePicker2.Value, 1);
            FRM.ShowDialog();
        }
    }
}
