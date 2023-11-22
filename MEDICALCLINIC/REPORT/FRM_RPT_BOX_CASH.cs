using DevComponents.DotNetBar.Controls;
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
    public partial class FRM_RPT_BOX_CASH : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        public FRM_RPT_BOX_CASH()
        {
            InitializeComponent();
        }

        

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_CASH_BOXTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_CASH_BOX, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                LBL_TOTAL.Text =
                      (from DataGridViewRow row in dgvalldata.Rows
                       where row.Cells[3].FormattedValue.ToString() != string.Empty
                       select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
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

  

        private void FRM_RPT_BOX_CASH_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_CASH_BOXTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_CASH_BOX, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                LBL_TOTAL.Text =
                      (from DataGridViewRow row in dgvalldata.Rows
                       where row.Cells[3].FormattedValue.ToString() != string.Empty
                       select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PRINT.PRINT_MONEY.FRM_ALL_CASH_BOX FRM = new PRINT.PRINT_MONEY.FRM_ALL_CASH_BOX(1, dateTimePicker1.Value, dateTimePicker2.Value, 1);
            FRM.ShowDialog();
        }
    }
}
