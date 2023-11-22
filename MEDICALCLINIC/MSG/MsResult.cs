using System;

using System.Windows.Forms;

namespace Management_Seles.BaseForms
{
    public partial class MsResult : Form
    {

        public MsResult(string _s)
        {
            InitializeComponent();
            lab1.Text = _s;
        }
        public bool Result { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Result = true;
            this.Close();
        }

        private void buttonNew1_Click(object sender, EventArgs e)
        {
            Result = false;
            this.Close();
        }

        private void MsResult_Load(object sender, EventArgs e)
        {
            btnSave.Focus();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
            {
                Result = false;
                this.Close();
            }

        }
    }
}
