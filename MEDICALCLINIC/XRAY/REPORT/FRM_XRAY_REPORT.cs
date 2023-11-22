using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.XRAY.REPORT
{
    public partial class FRM_XRAY_REPORT : Form
    {
        public FRM_XRAY_REPORT()
        {
            InitializeComponent();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void FRM_XRAY_REPORT_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_L_ALL_XRAY_REPORTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_L_ALL_XRAY_REPORT, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))),"", new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                LBL_TOTAL.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[6].Value)).ToString();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgvalldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                XRAY.REPORT.FRM_XRY_REPORT_DETAILS FRM = new FRM_XRY_REPORT_DETAILS(dgvalldata.CurrentRow.Cells[12].Value.ToInt());
                FRM.ShowDialog();
            }
        }
    }
}
