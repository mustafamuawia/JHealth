using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.ACCOUNTANT
{
    public partial class FRM_ACCOUNT_PAY : Form
    {
        public FRM_ACCOUNT_PAY()
        {
            InitializeComponent();
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BTN_DEBIT_PER_Click(object sender, EventArgs e)
        {
            HOSPITAL.SERVICES.FRM_H_OP_MONEY_SERVICE FRM = new SERVICES.FRM_H_OP_MONEY_SERVICE(0,0);
            FRM.ShowDialog();
        }

        private void BTN_DR_ACCOUNT_Click(object sender, EventArgs e)
        {
            HOSPITAL.REPORTS.FRM_DOCTORS_DEBIT FRM = new HOSPITAL.REPORTS.FRM_DOCTORS_DEBIT();
            FRM.ShowDialog();
        }

        private void BTN_SANAD_Click(object sender, EventArgs e)
        {
            SANAD.FRM_SANAD FRM = new SANAD.FRM_SANAD();FRM.ShowDialog();
        }
    }
}
