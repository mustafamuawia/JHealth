using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.ACCOUNT
{
    public partial class FRM_KSHIF_HISAB_MASRIF : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        public FRM_KSHIF_HISAB_MASRIF()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_KASHIF_HSAB_MSARIF_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_KASHIF_HSAB_MSARIF_DET, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(10, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_COST_CENTERComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
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

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_ALL_ACCOUNTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ALL_ACCOUNT, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_ALL_ACCOUNTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ALL_ACCOUNT, "");

                this.p_GET_ALL_COST_CENTERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ALL_COST_CENTER,"");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FRM_KSHIF_HISAB_MASRIF_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            this.p_GET_ALL_ACCOUNTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ALL_ACCOUNT, "");

            this.p_GET_ALL_COST_CENTERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ALL_COST_CENTER, "");
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_KASHIF_HSAB_MSARIF_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_KASHIF_HSAB_MSARIF_DET, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(10, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_COST_CENTERComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                LBL_TOTAL.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                LBL_PAID.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[4].Value)).ToString();
                LBL_REMAIN.Text = (Convert.ToDecimal(LBL_TOTAL.Text) - Convert.ToDecimal(LBL_PAID.Text)).ToString();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            LBL_TOTAL.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
            LBL_PAID.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[4].Value)).ToString();
            LBL_REMAIN.Text = (Convert.ToDecimal(LBL_TOTAL.Text) - Convert.ToDecimal(LBL_PAID.Text)).ToString();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            SANAD.FRM_SANAD FRM = new SANAD.FRM_SANAD();
        }
    }
}
