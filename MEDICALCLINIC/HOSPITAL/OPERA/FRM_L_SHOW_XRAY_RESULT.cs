using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.OPERA
{
    public partial class FRM_L_SHOW_XRAY_RESULT : Form
    {
        int PERSON_CODE = 0,idres=0;
        public FRM_L_SHOW_XRAY_RESULT(int PERID)
        {
            InitializeComponent();
            PERSON_CODE = PERID;
        }

      

        

        private void BTN_SEARCH_ALL_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_H_ALL_XRAY_FOR_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_H_ALL_XRAY_FOR_PERSON, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_SEARCH_TESTNAME_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_H_ALL_XRAY_FOR_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_H_ALL_XRAY_FOR_PERSON, new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void DGV_ALL_TEST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex==0)
                {
                    this.p_GET_H_ALL_XRAY_FOR_PERSON_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_H_ALL_XRAY_FOR_PERSON_DET, new System.Nullable<int>(((int)(System.Convert.ChangeType(DGV_ALL_TEST.CurrentRow.Cells[9].Value, typeof(int))))));
                    idres = DGV_ALL_TEST.CurrentRow.Cells[9].Value.ToInt();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void FRM_L_SHOW_XRAY_RESULT_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(idres, 2);
                FRM.ShowDialog();
            }
        }
    }
}
