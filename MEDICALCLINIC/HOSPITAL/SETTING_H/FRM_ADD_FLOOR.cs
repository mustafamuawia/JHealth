using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.SETTING_H
{
    public partial class FRM_ADD_FLOOR : MEDICALCLINIC.HOSPITAL.BaseHospital
    {
        byte[] imge1;
        public FRM_ADD_FLOOR()
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

        
       
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (FLOOR_NAME.Text == "")
                {

                    errorProvider1.SetError(FLOOR_NAME, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (FLOOR_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(FLOOR_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    INSERTED.P_INSERT_T_H_FLOOR(

                             FLOOR_NAME.Text
                           , 0
                           , imge1
                           , NOTE.Text
                           , true
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_FLOOR_Load(null, null);
                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_EMP_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_EMP_NAME_CODE, "");
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
                this.gET_H_FLOOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_FLOOR_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void cleartextbox(Control root)
        {
            foreach (Control ct in root.Controls)
            {
                if (ct is TextBox)
                    ((TextBox)ct).Clear();

                //' افراغ لتيكست بوكس 
            }
        }
        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            FLOOR_CODE.Text = "";
            FLOOR_NAME.Text = "";
          
            pictureBox1.Image = Properties.Resources.NOPIC;
            NOTE.Text = "";
            FLOOR_NAME.Focus();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (FLOOR_NAME.Text == "")
                {

                    errorProvider1.SetError(FLOOR_NAME, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    if (FLOOR_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(FLOOR_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    INSERTED.P_UPDATE_T_H_FLOOR(
                    Convert.ToInt32(FLOOR_CODE.Text)
                           , FLOOR_NAME.Text
                           , 0
                           , imge1
                           , NOTE.Text
                           , true
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Update);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_FLOOR_Load(null, null);
                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (FLOOR_CODE.Text == "")
                {

                    errorProvider1.SetError(FLOOR_CODE, CLS.TXT_NULL);
                }



 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELTE_T_H_B_DEPART(

                              Convert.ToInt32(FLOOR_CODE.Text)

                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_FLOOR_Load(null, null);
                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void FRM_EMP_Shown(object sender, EventArgs e)
        {
            FLOOR_NAME.Focus();
        }

        private void gET_EMP_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gET_EMP_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
                {
                    pictureBox1.Image = Properties.Resources.NOPIC;
                    FLOOR_CODE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                    FLOOR_NAME.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();
                   // COMB_M_DEP.SelectedValue = Convert.ToInt32(gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[3].Value);
                    if (gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[4].Value.ToString() != string.Empty)
                    {
                        byte[] imge1 = (byte[])gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[4].Value;
                        MemoryStream ms1 = new MemoryStream(imge1);
                        pictureBox1.Image = Image.FromStream(ms1);
                    }
                    NOTE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[5].Value.ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void EMP_NAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NOTE.Focus();
            }
        }

        

        private void EMAIL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NOTE.Focus();
            }
        }

        private void NOTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_SAVE_Click(null, null);
            }
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd1.FileName);
            }
        }

       

        

        private void FRM_ADD_FLOOR_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_FLOOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_FLOOR_NAME_CODE,  "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
