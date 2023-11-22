using System;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.OPERA
{
    public partial class FRM_SHOW_PERSONINFO :MEDICALCLINIC.HOSPITAL. BaseHospital
    {
        public FRM_SHOW_PERSONINFO()
        {
            InitializeComponent();
        }

        

        private void FRM_SHOW_PERSONINFO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
        }

        private void TXT_G_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_BOOKING_FOR_SHOWBOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_FOR_SHOWBOOK, TXT_G_SEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
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

       
        private void btn_searchdoct_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_BOOKING_FOR_SHOWBOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_FOR_SHOWBOOK, dOCTOR_NAMEComboBox.SelectedValue.ToString(), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                return;
            }
        }

        private void btn_d_searchdtcr_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_BOOKING_FOR_SHOWBOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_FOR_SHOWBOOK, dOCTOR_NAMEComboBox.SelectedValue.ToString(), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_BOOKING_FOR_SHOWBOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_FOR_SHOWBOOK, TXT_G_SEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       
    }
}
