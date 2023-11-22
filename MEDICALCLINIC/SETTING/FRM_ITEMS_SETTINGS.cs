using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_ITEMS_SETTINGS : Form
    {
        public FRM_ITEMS_SETTINGS()
        {
            InitializeComponent();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            SETTING.FRM_CATEGORIS  FRM = new FRM_CATEGORIS ();
            FRM.ShowDialog();

        }

       
        private void button11_Click(object sender, EventArgs e)
        {
            SETTING.FRM_DRAGE FRM = new FRM_DRAGE();
            FRM.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SETTING.FRM_ITEM  FRM = new FRM_ITEM ();
            FRM.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SETTING.FRM_CLIENT  frm = new FRM_CLIENT ();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
