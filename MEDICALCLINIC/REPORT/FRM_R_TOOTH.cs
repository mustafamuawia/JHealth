using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_R_TOOTH : Form
    {
        public FRM_R_TOOTH()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_PROFIT FRM = new FRM_PROFIT();
            FRM.ShowDialog();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            REPORT.FRM_REPORT_TOOTH frm = new FRM_REPORT_TOOTH();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
