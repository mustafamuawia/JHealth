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
    public partial class FRM_L_SHOW_LABTEST_RESULT : Form
    {
        int PERSONCODE = 0,idres=0;
        public FRM_L_SHOW_LABTEST_RESULT(int PERCODE)
        {
            InitializeComponent();
            PERSONCODE = PERCODE;
        }

        

       

        private void FRM_L_SHOW_LABTEST_RESULT_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG' table. You can move, or remove it, as needed.
            this.v_GET_A_L_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG);

        }

       

        //private void nAME_CATEGComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.gET_LAB_TEST_BY_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_TEST_BY_CATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox1.SelectedValue, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void BTN_SEARCH_TESTNAME_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_H_ALL_TESTS_FOR_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_H_ALL_TESTS_FOR_PERSON, "2", new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSONCODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
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
                this.p_GET_H_ALL_TESTS_FOR_PERSON_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_H_ALL_TESTS_FOR_PERSON_DET,  "", new System.Nullable<int>(((int)(System.Convert.ChangeType(DGV_ALL_TEST.CurrentRow.Cells[13].Value, typeof(int))))));
                idres=  DGV_ALL_TEST.CurrentRow.Cells[13].Value.ToInt();
                }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

      
        private void BTN_SEARCH_ALL_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_H_ALL_TESTS_FOR_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_H_ALL_TESTS_FOR_PERSON, "1", new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSONCODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
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

       
  

      

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
            ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(idres, 1);
            FRM.ShowDialog();
            }
           
        }
    }
}
