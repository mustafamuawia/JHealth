using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.DOCTOR
{
    public partial class FRM_SETTING_DR : Form
    {

        public FRM_SETTING_DR()
        {
            InitializeComponent();

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void BTN_DEP_Click(object sender, EventArgs e)
        {
            SETTING.FRM_DR_GROUP FRM = new SETTING.FRM_DR_GROUP();
            FRM.ShowDialog();
        }

        private void BTN_FLOOR_Click(object sender, EventArgs e)
        {
           SETTING.FRM_MAJOR FRM = new SETTING.FRM_MAJOR();
            FRM.ShowDialog();
        }

        private void BTN_ROOM_Click(object sender, EventArgs e)
        {
           SETTING.FRM_MAJOR_DETAILS FRM = new SETTING.FRM_MAJOR_DETAILS();
            FRM.ShowDialog();
        }

        private void BTN_BED_Click(object sender, EventArgs e)
        {
           DOCTOR.FRM_DOCTOR FRM = new DOCTOR.FRM_DOCTOR();
            FRM.ShowDialog();
        }

        private void BTN_COMB_FD_Click(object sender, EventArgs e)
        {
            HOSPITAL.SETTING_H.FRM_COMB_SUBD_FLOOR FRM = new HOSPITAL.SETTING_H.FRM_COMB_SUBD_FLOOR();
            FRM.ShowDialog();
        }

        private void BTN_COLSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
