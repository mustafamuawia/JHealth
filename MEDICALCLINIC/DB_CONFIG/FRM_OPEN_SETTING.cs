using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.DB_CONFIG
{
    public partial class FRM_OPEN_SETTING : Form
    {
        public FRM_OPEN_SETTING()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (TXT_PWD_SETTING.Text == "ba90sh98au19" || TXT_PWD_SETTING.Text == "BA90SH98AU19")
            {
                this.Hide();
                
                DB_CONFIG.FRM_DB FRM = new FRM_DB();
                FRM.ShowDialog();
            }
            else
            {
                MessageBox.Show("كلمة المرور غير صحيحة");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_PWD_SETTING_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TXT_PWD_SETTING.Text == "ba90sh98au19" || TXT_PWD_SETTING.Text == "BA90SH98AU19")
                {
                    DB_CONFIG.FRM_DB FRM = new FRM_DB();
                    FRM.ShowDialog();
                }
                else
                {
                    MessageBox.Show("كلمة المرور غير صحيحة");
                }
            }
        }
    }
}
