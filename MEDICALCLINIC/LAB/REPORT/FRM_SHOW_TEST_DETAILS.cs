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
    public partial class FRM_SHOW_TEST_DETAILS : Form
    {
        int ID_RESULT;
        public FRM_SHOW_TEST_DETAILS(int IDRESULT)
        {
            InitializeComponent();
            ID_RESULT = IDRESULT;
        }

       

       

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_SHOW_TEST_DETAILS_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            try
            {
                this.p_GET_L_ALL_LABTESTS_REPORT_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_L_ALL_LABTESTS_REPORT_DET, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System.DateTime.Now, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System.DateTime.Now, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(ID_RESULT, typeof(int))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
