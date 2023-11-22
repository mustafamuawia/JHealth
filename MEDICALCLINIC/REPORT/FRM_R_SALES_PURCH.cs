using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_R_SALES_PURCH : Form
    {
        public FRM_R_SALES_PURCH()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            REPORT.FRM_PURCHES_RPT FRM = new FRM_PURCHES_RPT();
            FRM.ShowDialog();
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
