using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.LAB.REPORT
{
    public partial class FRM_RPT_ALL_DAILYTEST : MEDICALCLINIC.LAB.baselab
    {
        public FRM_RPT_ALL_DAILYTEST()
        {
            InitializeComponent();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_RPT_ALL_DAILYTEST_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
        }

      

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_L_ALL_LABTESTS_REPORTTableAdapter1.Fill(this.mEDICAL_CLINIC_DBDataSet1.P_GET_L_ALL_LABTESTS_REPORT, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                LBL_TOTAL.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[7].Value)).ToString();
                //LBL_PAID.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[4].Value)).ToString();

            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

       

        private void dgvalldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)

            {
                LAB.REPORT.FRM_SHOW_TEST_DETAILS FRM = new FRM_SHOW_TEST_DETAILS(dgvalldata.CurrentRow.Cells[9].Value.ToInt());
                FRM.ShowDialog();
            }
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.p_GET_L_ALL_LABTESTS_REPORTTableAdapter1.Fill(this.mEDICAL_CLINIC_DBDataSet1.P_GET_L_ALL_LABTESTS_REPORT, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fDATEToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(eDATEToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(iD_CODEToolStripTextBox.Text, typeof(int))))), iD_VARToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(iD_FLAGToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
