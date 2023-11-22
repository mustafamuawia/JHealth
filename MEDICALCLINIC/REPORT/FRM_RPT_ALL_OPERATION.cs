using MEDICALCLINIC.HOSPITAL.PRINT;
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
    public partial class FRM_RPT_ALL_OPERATION : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        public FRM_RPT_ALL_OPERATION()
        {
            InitializeComponent();
        }

        private void FRM_RPT_ALL_OPERATION_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            
                this.gET_DOCTOR_BY_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_FLOOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), 2);

            
        }
        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void bTN_SEARCH_BYDATE_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_BOOKING_BY_DR_GTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_BOOKING_BY_DR_G, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox1.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                lbl_kishfia.Text =
                               (from DataGridViewRow row in dgvalldata.Rows
                                where row.Cells[12].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
                lbl_total_op.Text =
                          (from DataGridViewRow row in dgvalldata.Rows
                           where row.Cells[13].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[13].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_BOOKING_BY_DR_GTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_BOOKING_BY_DR_G, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox1.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                lbl_kishfia.Text =
                                  (from DataGridViewRow row in dgvalldata.Rows
                                   where row.Cells[12].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
                lbl_total_op.Text =
                          (from DataGridViewRow row in dgvalldata.Rows
                           where row.Cells[13].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[13].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_BOOKING_BY_DR_GTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_BOOKING_BY_DR_G, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox1.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                lbl_kishfia.Text =
                               (from DataGridViewRow row in dgvalldata.Rows
                                where row.Cells[12].FormattedValue.ToString() != string.Empty
                                select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
                lbl_total_op.Text =
                          (from DataGridViewRow row in dgvalldata.Rows
                           where row.Cells[13].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[13].FormattedValue)).Sum().ToString();
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
                this.gET_ALL_BOOKING_BY_DR_GTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_BOOKING_BY_DR_G, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox1.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                lbl_kishfia.Text =
                                  (from DataGridViewRow row in dgvalldata.Rows
                                   where row.Cells[12].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
                lbl_total_op.Text =
                          (from DataGridViewRow row in dgvalldata.Rows
                           where row.Cells[13].FormattedValue.ToString() != string.Empty
                           select Convert.ToDouble(row.Cells[13].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             PRINT.PTINT_OP.FRM_SHOW_RPT_OP FRM = new PRINT.PTINT_OP.FRM_SHOW_RPT_OP(dOCTOR_NAMEComboBox1.SelectedValue.ToInt(), dateTimePicker1.Value, dateTimePicker2.Value, 2);
             FRM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PRINT.PTINT_OP.FRM_SHOW_RPT_OP FRM = new PRINT.PTINT_OP.FRM_SHOW_RPT_OP(dOCTOR_NAMEComboBox1.SelectedValue.ToInt(), dateTimePicker1.Value, dateTimePicker2.Value,1);
            FRM.ShowDialog();
        }
    }
}
