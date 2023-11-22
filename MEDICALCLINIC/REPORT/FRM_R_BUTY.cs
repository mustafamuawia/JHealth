using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_R_BUTY : Form
    {
        public FRM_R_BUTY()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            REPORT.FRM_BOOKING_DISEAS FRM = new FRM_BOOKING_DISEAS();
            FRM.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            REPORT.FRM_R_OPERATONS FRM = new FRM_R_OPERATONS();
            FRM.ShowDialog();
        }

        
        private void button4_Click_1(object sender, EventArgs e)
        {
            REPORT.FRM_R_OPERATONS FRM = new FRM_R_OPERATONS();
            FRM.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            REPORT.FRM_R_OPERATONS FRM = new FRM_R_OPERATONS();
            FRM.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            REPORT.FRM_KSHFIA_TYPE FRM = new FRM_KSHFIA_TYPE();
            FRM.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            REPORT.FRM_BOOKING_DISEAS FRM = new FRM_BOOKING_DISEAS();
            FRM.ShowDialog();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button4_Click_2(object sender, EventArgs e)
        {
            FRM_BOOKING_TYPE FRM = new FRM_BOOKING_TYPE();
            FRM.ShowDialog();
        }
    }
}
