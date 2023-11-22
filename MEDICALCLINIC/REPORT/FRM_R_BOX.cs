using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_R_BOX : Form
    {
        public FRM_R_BOX()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_PROFIT FRM = new FRM_PROFIT();
            FRM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
