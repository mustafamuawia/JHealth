using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SEARCH_CLIENT : Form
    {

        public FRM_SEARCH_CLIENT()
        {
            InitializeComponent();

        }

        private void buttonX8_Click(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLASS_S.CLS.TITEL_MESG);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {


            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLASS_S.CLS.TITEL_MESG);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLASS_S.CLS.TITEL_MESG);
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);


        }

        private void CLIENT_NAME_ARTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_NAME_ENTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_PHONE1TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_PHONE2TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_PHONE3TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CLIENT_EMAILETextBoxX_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_CLIENT_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_CLIENT_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_CLIENT_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_CLIENT_NAME_CODE,TXT_SEARCH .Text );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            ((SETTING.FRM_CLIENT)Application.OpenForms["FRM_CLIENT"]).CLIENT_CODETextBoxX.Text =
                dataGridView2.CurrentRow.Cells[0].Value.ToString();
            ((SETTING.FRM_CLIENT)Application.OpenForms["FRM_CLIENT"]).CLIENT_NAME_ARTextBoxX.Text =
               dataGridView2.CurrentRow.Cells[1].Value.ToString();
            ((SETTING.FRM_CLIENT)Application.OpenForms["FRM_CLIENT"]).CLIENT_NAME_ENTextBoxX.Text =
              dataGridView2.CurrentRow.Cells[2].Value.ToString();
            ((SETTING.FRM_CLIENT)Application.OpenForms["FRM_CLIENT"]).CLIENT_PHONE1TextBoxX .Text =
            dataGridView2.CurrentRow.Cells[4].Value.ToString();
            ((SETTING.FRM_CLIENT)Application.OpenForms["FRM_CLIENT"]).CLIENT_PHONE2TextBoxX.Text =
            dataGridView2.CurrentRow.Cells[5].Value.ToString();
            ((SETTING.FRM_CLIENT)Application.OpenForms["FRM_CLIENT"]).CLIENT_PHONE3TextBoxX.Text =
            dataGridView2.CurrentRow.Cells[6].Value.ToString();
            ((SETTING.FRM_CLIENT)Application.OpenForms["FRM_CLIENT"]).CLIENT_EMAILETextBoxX.Text =
            dataGridView2.CurrentRow.Cells[7].Value.ToString();
            ((SETTING.FRM_CLIENT)Application.OpenForms["FRM_CLIENT"]).CLIENT_NOTETextBoxX.Text =
            dataGridView2.CurrentRow.Cells[8].Value.ToString();
            this.Dispose();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.gET_DOCTOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.gET_CLIENT_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_CLIENT_NAME_CODE,"");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
