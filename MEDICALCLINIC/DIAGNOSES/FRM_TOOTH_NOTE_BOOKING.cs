using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.DIAGNOSES
{
    public partial class FRM_TOOTH_NOTE_BOOKING : Form
    {
        public string TXT_NOTE;
        public FRM_TOOTH_NOTE_BOOKING(string NOTE_NAME)
        {
            InitializeComponent();
            TXT_NOTE = NOTE_NAME;
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_TOOTH_NOTE_BOOKING_Load(object sender, EventArgs e)
        {
            TXT_NOTICE.Text = TXT_NOTE;
        }
    }
}
