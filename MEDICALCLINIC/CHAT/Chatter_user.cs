using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.CLINIC
{
    public partial class Chatter_user1 : Form
    {
        public int UserID
        {
            get { return (int)cboUser.SelectedValue; }
        }

        public string UserName
        {
            get { return cboUser.Text.Trim(); }
        }

        public Chatter_user1()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_USERS' table. You can move, or remove it, as needed.
            this.v_GET_A_USERSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_USERS);
            //cboUser.DataSource = ChatterData.ChatData.GetUsers();
            //cboUser.DisplayMember = "Name";
            //cboUser.ValueMember = "ID";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}