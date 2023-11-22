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
    public partial class FRM_XRY_REPORT_DETAILS : Form
    {
        int ID_XRY;
        public FRM_XRY_REPORT_DETAILS(int IDXRY)
        {
            InitializeComponent();
            ID_XRY = IDXRY;
        }

        private void FRM_XRY_REPORT_DETAILS_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            try
            {
                this.p_GET_L_ALL_XRAY_REPORT_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_L_ALL_XRAY_REPORT_DET,
                new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System.DateTime.Now, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System.DateTime.Now, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(ID_XRY, typeof(int))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
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
