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
    public partial class FRM_PROFIT_CLONIC : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        decimal total=0;
        public FRM_PROFIT_CLONIC()
        {
            InitializeComponent();
        }

        private void FRM_PROFIT_CLONIC_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR' table. You can move, or remove it, as needed.
            this.v_GET_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR);
            this.gET_DOCTOR_BY_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_FLOOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(fLOOR_NAMEComboBox.SelectedValue, typeof(int))))), 2);
            dOCTOR_NAMEComboBox.SelectedIndex = -1;
            fLOOR_NAMEComboBox.SelectedIndex = -1;

        }

       

        private void fLOOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fLOOR_NAMEComboBox.SelectedIndex>-1)
            {
            this.gET_DOCTOR_BY_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_FLOOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(fLOOR_NAMEComboBox.SelectedValue, typeof(int))))),1);

            }

        }
  

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (fLOOR_NAMEComboBox.SelectedIndex != -1|| dOCTOR_NAMEComboBox.SelectedIndex != -1)
                {
                    this.p_GET_PROFIT_CLINICTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PROFIT_CLINIC, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                    //  this.p_GET_EXPENSES_OP_CLINICTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_OP_CLINIC, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));

                    //if (this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_OP_CLINIC.Rows.Count>0)
                    //{
                    //    lbl_op_exp.Text = this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_OP_CLINIC.Rows[0][0].ToString();
                    //}else{
                    //    lbl_op_exp.Text = "0.00";
                    //}

                    //this.p_GET_EXPENSES_GEN_CLINICTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_GEN_CLINIC, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

                    //if (this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_GEN_CLINIC.Rows.Count > 0)
                    //{
                    //    lbl_g_epx.Text = this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_GEN_CLINIC.Rows[0][0].ToString();
                    //}
                    //else
                    //{
                    //    lbl_g_epx.Text = "0.00";
                    //}


                    lbl_total_op.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[9].Value)).ToString();
                    lbl_op_exp.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[10].Value)).ToString();
                    lbl_kishfia.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[12].Value)).ToString();
                    //for (int i = 0; i < this.mEDICAL_CLINIC_DBDataSet.P_GET_PROFIT_CLINIC.Rows.Count; i++)
                    //{
                    //    total +=Convert.ToDecimal( this.mEDICAL_CLINIC_DBDataSet.P_GET_PROFIT_CLINIC.Rows[i][2]);
                    //}
                    //lbl_total_op.Text = total.ToString();
                    lbl_profit.Text = (Convert.ToDecimal(lbl_total_op.Text) - (Convert.ToDecimal(lbl_op_exp.Text))).ToString();
                    // lbl_profit.Text = (Convert.ToDecimal(lbl_total_op.Text) - (Convert.ToDecimal(lbl_g_epx.Text) + Convert.ToDecimal(lbl_op_exp.Text))).ToString();
                }
        }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

}

        private void btn_search_byfloor_Click(object sender, EventArgs e)
        {
            try
            {
                if (fLOOR_NAMEComboBox.SelectedIndex != -1 || dOCTOR_NAMEComboBox.SelectedIndex != -1)
                {
                    this.p_GET_PROFIT_CLINICTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PROFIT_CLINIC, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                    //this.p_GET_EXPENSES_OP_CLINICTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_OP_CLINIC, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));

                    //if (this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_OP_CLINIC.Rows.Count>0)
                    //{
                    //    lbl_op_exp.Text = this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_OP_CLINIC.Rows[0][0].ToString();
                    //}else{
                    //    lbl_op_exp.Text = "0.00";
                    //}

                    this.p_GET_EXPENSES_GEN_CLINICTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_GEN_CLINIC, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                    if (this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_GEN_CLINIC.Rows.Count > 0)
                    {
                        lbl_g_epx.Text = this.mEDICAL_CLINIC_DBDataSet.P_GET_EXPENSES_GEN_CLINIC.Rows[0][0].ToString();
                    }
                    else
                    {
                        lbl_g_epx.Text = "0.00";
                    }
                    if (dgvalldata.Rows.Count > 0)
                    {

                        lbl_total_op.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[9].Value)).ToString();
                        lbl_op_exp.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[10].Value)).ToString();
                        lbl_kishfia.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[12].Value)).ToString();
                        lbl_profit.Text = (Convert.ToDecimal(lbl_total_op.Text) - (Convert.ToDecimal(lbl_g_epx.Text) + Convert.ToDecimal(lbl_op_exp.Text))).ToString();

                    }


                    //for (int i = 0; i < this.mEDICAL_CLINIC_DBDataSet.P_GET_PROFIT_CLINIC.Rows.Count; i++)
                    //{
                    //    total +=Convert.ToDecimal( this.mEDICAL_CLINIC_DBDataSet.P_GET_PROFIT_CLINIC.Rows[i][2]);
                    //}
                    //lbl_total_op.Text = total.ToString();
                }
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

        
    }
}
