using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_WHODELDTE_BOOK : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        public FRM_WHODELDTE_BOOK()
        {
            InitializeComponent();
        }

        private void FRM_WHODELDTE_BOOK_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_WHO_DELETEBOOK' table. You can move, or remove it, as needed.
            this.v_WHO_DELETEBOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_WHO_DELETEBOOK);

        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
