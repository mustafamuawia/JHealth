using System;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC
{
    public partial class frm_form : Form
    {
        public frm_form()
        {
            InitializeComponent();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_form_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
        }
    }
}
