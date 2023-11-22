using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.SEARCH
{
    public partial class FRM_SEARCH_IMG_PER : Form
    {

        public FRM_SEARCH_IMG_PER()
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
                this.p_GET_IMG_BEF_AFTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BEF_AFT, CLASS_S.CLS.ID_PERSON_IMG.ToString());
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
                this.p_GET_IMG_BEF_AFTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BEF_AFT,TXT_SEARCH .Text );
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
            if (CLASS_S.CLS.FALGE_PERSON_IMG == 1)
            {
                byte[] imge1 = (byte[])dataGridView2.CurrentRow.Cells[13].Value;
                MemoryStream ms1 = new MemoryStream(imge1);
                ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).BB_PIC1.Image = Image.FromStream(ms1);

                byte[] imge2 = (byte[])dataGridView2.CurrentRow.Cells[14].Value;
                MemoryStream ms2 = new MemoryStream(imge2);
                ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).BB_PIC2.Image = Image.FromStream(ms2);

                byte[] imge3 = (byte[])dataGridView2.CurrentRow.Cells[15].Value;
                MemoryStream ms3 = new MemoryStream(imge3);
                ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).BB_PIC3.Image = Image.FromStream(ms3);

                byte[] imge4 = (byte[])dataGridView2.CurrentRow.Cells[16].Value;
                MemoryStream ms4 = new MemoryStream(imge4);
                ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).BB_PIC4.Image = Image.FromStream(ms4);

                byte[] imge5 = (byte[])dataGridView2.CurrentRow.Cells[17].Value;
                MemoryStream ms5 = new MemoryStream(imge5);
                ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).BB_PIC5.Image = Image.FromStream(ms5);

                this.Dispose();
            }
            else
                if (CLASS_S.CLS.FALGE_PERSON_IMG == 2)
                {
                    byte[] imge1 = (byte[])dataGridView2.CurrentRow.Cells[13].Value;
                    MemoryStream ms1 = new MemoryStream(imge1);
                    ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).A_PIC1.Image = Image.FromStream(ms1);

                    byte[] imge2 = (byte[])dataGridView2.CurrentRow.Cells[14].Value;
                    MemoryStream ms2 = new MemoryStream(imge2);
                    ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).A_PIC2.Image = Image.FromStream(ms2);

                    byte[] imge3 = (byte[])dataGridView2.CurrentRow.Cells[15].Value;
                    MemoryStream ms3 = new MemoryStream(imge3);
                    ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).A_PIC3.Image = Image.FromStream(ms3);

                    byte[] imge4 = (byte[])dataGridView2.CurrentRow.Cells[16].Value;
                    MemoryStream ms4 = new MemoryStream(imge4);
                    ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).A_PIC4.Image = Image.FromStream(ms4);

                    byte[] imge5 = (byte[])dataGridView2.CurrentRow.Cells[17].Value;
                    MemoryStream ms5 = new MemoryStream(imge5);
                    ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).A_PIC5.Image = Image.FromStream(ms5);

                    this.Dispose();
                }
            CLASS_S.CLS.FALGE_PERSON_IMG = -1;
              }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_IMG_BEF_AFTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BEF_AFT, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


    }
}
