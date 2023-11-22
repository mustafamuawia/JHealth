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
    public partial class FRM_PROGRAM_SETTING : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        public FRM_PROGRAM_SETTING()
        {
            InitializeComponent();
        }

        private void CB_COST_CENTER_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_COST_CENTER.Checked)
            {
                Properties.Settings.Default.COST_CENTER_TYPE = 1;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.COST_CENTER_TYPE = 0;
                Properties.Settings.Default.Save();
            }


        }

        private void FRM_PROGRAM_SETTING_Load(object sender, EventArgs e)
        {
            if ( Properties.Settings.Default.COST_CENTER_TYPE == 1)
            {
                CB_COST_CENTER.Checked=true;

            }
            else
             if (Properties.Settings.Default.COST_CENTER_TYPE == 0)
            {
                CB_COST_CENTER.Checked = false;

            }

            if (Properties.Settings.Default.LABTYPE == 1)
            {
                CK_L_OUT.Checked = true;

            }
            else
            if (Properties.Settings.Default.LABTYPE == 2)
            {
                CK_L_INT.Checked = true;

            }
            else
            if (Properties.Settings.Default.LABTYPE == 3)
            {
                CK_L_COMB.Checked = true;

            }
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CK_L_OUT_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LABTYPE = 1;
            Properties.Settings.Default.Save();
        }

        private void CK_L_INT_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LABTYPE = 2;
            Properties.Settings.Default.Save();
        }

        private void CK_L_COMB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LABTYPE =3;
            Properties.Settings.Default.Save();
        }
    }
}
