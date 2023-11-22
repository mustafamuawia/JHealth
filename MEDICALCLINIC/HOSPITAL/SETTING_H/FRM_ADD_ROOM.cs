using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.SETTING_H
{
    public partial class FRM_ADD_ROOM : MEDICALCLINIC.HOSPITAL.BaseHospital
    {

        public FRM_ADD_ROOM()
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

        private void FRM_ADD_OPERATN_INFO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR' table. You can move, or remove it, as needed.
            this.v_GET_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_H_ROOM_TYP' table. You can move, or remove it, as needed.
            this.v_H_ROOM_TYPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_H_ROOM_TYP);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_MAIN_DEP' table. You can move, or remove it, as needed.
            this.v_GET_H_MAIN_DEPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_MAIN_DEP);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_EMP_TYPE' table. You can move, or remove it, as needed.
            this.gET_B_DEPART_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_B_DEPART_NAME_CODE, "");
            this.gET_H_ROOM_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ROOM_NAME_CODE,  "");
        }
        byte[] imge1;
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (SUB_DEB_NAME.Text == "")
                {

                    errorProvider1.SetError(SUB_DEB_NAME, CLS.TXT_NULL);
                }
                if (TXT_NUMBER.Text == "")
                {

                    TXT_NUMBER.Text = "1";
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (DEP_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(DEP_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    INSERTED.P_INSERT_T_H_ROOM(

                            SUB_DEB_NAME.Text
                           , COMB_ROOMTYP.Text
                           , Convert.ToInt32( COMB_FLOOR.SelectedValue)
                           , imge1
                           , Convert.ToInt32(TXT_NUMBER.Text)
                           ,0
                           , true
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_OPERATN_INFO_Load(null, null);
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

     

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_ROOM_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ROOM_NAME_CODE, TXT_SEARCH.Text);
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
            DEP_CODE.Text = "";
            SUB_DEB_NAME.Text = "";
          
            pictureBox1.Image = Properties.Resources.NOPIC;
          
            SUB_DEB_NAME.Focus();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            { 
                if (SUB_DEB_NAME.Text == "")
                {

                    errorProvider1.SetError(SUB_DEB_NAME, CLS.TXT_NULL);
                }


 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    if (DEP_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(DEP_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    INSERTED.P_UPDATE_T_H_ROOM(
                    Convert.ToInt32(DEP_CODE.Text),
                           SUB_DEB_NAME.Text
                          , COMB_ROOMTYP.Text
                          , Convert.ToInt32(COMB_FLOOR.SelectedValue)
                          , imge1
                          , Convert.ToInt32(TXT_NUMBER.Text)
                          , 0
                          , true
                          , ref CLS.SUBMIT_FLAG

                         );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Update);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_OPERATN_INFO_Load(null, null);
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
                
                if (DEP_CODE.Text == "")
                {

                    errorProvider1.SetError(DEP_CODE, CLS.TXT_NULL);
                }



 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_H_ROOM(
                    
                              Convert.ToInt32(DEP_CODE.Text)
                              
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_OPERATN_INFO_Load(null, null);
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
            SUB_DEB_NAME.Focus();
        }

        private void gET_EMP_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gET_EMP_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
                {
                    pictureBox1.Image = Properties.Resources.NOPIC;
                    
                   // COMB_FLOOR.SelectedValue = Convert.ToInt32(gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[5].Value);
                    if (gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[5].Value.ToString() != string.Empty)
                    {
                        byte[] imge1 = (byte[])gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[5].Value;
                        MemoryStream ms1 = new MemoryStream(imge1);
                        pictureBox1.Image = Image.FromStream(ms1);
                    }
                    DEP_CODE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                    SUB_DEB_NAME.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();
                    COMB_ROOMTYP.Text =  gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[3].Value.ToString();
                   // COMB_FLOOR.SelectedValue = Convert.ToInt32(gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[4].Value);
                    TXT_NUMBER.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[6].Value.ToString();
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

 
       

       
    }
}
