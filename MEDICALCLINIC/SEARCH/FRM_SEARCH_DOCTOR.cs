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
    public partial class FRM_SEARCH_DOCTOR : Form
    {

        public FRM_SEARCH_DOCTOR()
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
                this.gET_DOCTOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_NAME_CODE, "");
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
                this.gET_DOCTOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_NAME_CODE, TXT_SEARCH .Text );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (CLASS_S.CLS.BOOK_FLAG == 1)
            {
                ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).dOCTOR_NAMEComboBox.SelectedValue =
                Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                CLASS_S.CLS.BOOK_FLAG = 0;
                this.Dispose();
            }
            else
            {
          
                ((DOCTOR.FRM_DOCTOR)Application.OpenForms["FRM_DOCTOR"]).DOCTOR_CODETextBoxX.Text =
                    dataGridView2.CurrentRow.Cells[0].Value.ToString();
                ((DOCTOR.FRM_DOCTOR)Application.OpenForms["FRM_DOCTOR"]).DOCTOR_NAME_ARTextBoxX.Text =
                   dataGridView2.CurrentRow.Cells[1].Value.ToString();
                ((DOCTOR.FRM_DOCTOR)Application.OpenForms["FRM_DOCTOR"]).TXT_DOCOTOR_EN.Text =
                 dataGridView2.CurrentRow.Cells[2].Value.ToString();
                ((DOCTOR.FRM_DOCTOR)Application.OpenForms["FRM_DOCTOR"]).TXT_INF_AR .Text =
                 dataGridView2.CurrentRow.Cells[3].Value.ToString();
                ((DOCTOR.FRM_DOCTOR)Application.OpenForms["FRM_DOCTOR"]).TXT_INF_EN .Text =
                 dataGridView2.CurrentRow.Cells[4].Value.ToString();
                ((DOCTOR.FRM_DOCTOR)Application.OpenForms["FRM_DOCTOR"]).TXT_PHONE.Text =
                 dataGridView2.CurrentRow.Cells[5].Value.ToString();
                ((DOCTOR.FRM_DOCTOR)Application.OpenForms["FRM_DOCTOR"]).TXT_ADDRESS.Text =
                 dataGridView2.CurrentRow.Cells[6].Value.ToString();
                ((DOCTOR.FRM_DOCTOR)Application.OpenForms["FRM_DOCTOR"]).TXT_REG_NUM.Text =
                 dataGridView2.CurrentRow.Cells[7].Value.ToString();
                ((DOCTOR.FRM_DOCTOR)Application.OpenForms["FRM_DOCTOR"]).DOCTOR_COMB.SelectedValue =
                 Convert.ToInt32(dataGridView2.CurrentRow.Cells[8].Value.ToString());
                this.Dispose();
          }
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


    }
}
