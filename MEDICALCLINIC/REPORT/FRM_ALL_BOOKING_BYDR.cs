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
    public partial class FRM_ALL_BOOKING_BYDR : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        public FRM_ALL_BOOKING_BYDR()
        {
            InitializeComponent();
        }

        

     

        private void FRM_ALL_BOOKING_BYDR_Load(object sender, EventArgs e)
        { var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_GRP_DOCTOR' table. You can move, or remove it, as needed.
            this.v_GET_A_GRP_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_GRP_DOCTOR);
           
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR' table. You can move, or remove it, as needed.
            this.v_GET_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR);
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        try{ 
            if (dOCTOR_NAMEComboBox1.SelectedIndex>-1)
            {
                this.gET_ALL_BOOKING_BY_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_BOOKING_BY_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox1.SelectedValue, typeof(int))))), dateTimePicker1.Value, dateTimePicker2.Value,1);
               
                lbl_kishfia.Text = dgvalldata.Rows.Cast<DataGridViewRow>()
                   .Sum(t => Convert.ToDecimal(t.Cells[12].Value)).ToString();
                int indxy=0;
                if (gROUP_DOCTORComboBox.SelectedValue.ToInt()==2)
                {
                    indxy = 15;
                }
                else
                {
                    indxy = 13;
                }
                if (dgvalldata.Rows.Count>0)
                {
   lbl_total_op.Text = dgvalldata.Rows.Cast<DataGridViewRow>()
                   .Sum(t => Convert.ToDecimal(t.Cells[indxy].Value)).ToString();
                }
             

            }
        }
            catch (System.Exception ex)
            {
                //   System.Windows.Forms.MessageBox.Show(ex.Message);
            }

}

 
       

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_DEBIT_Click(object sender, EventArgs e)
        {
            ACCOUNT.FRM_DOCTORT_DEBIT_CLINIC FRM = new ACCOUNT.FRM_DOCTORT_DEBIT_CLINIC();
            FRM.ShowDialog();
        }

        

        private void gROUP_DOCTORComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gROUP_DOCTORComboBox.SelectedIndex>-1)
            {
                try
                {
                    this.gET_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(gROUP_DOCTORComboBox.SelectedValue, typeof(int))))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
