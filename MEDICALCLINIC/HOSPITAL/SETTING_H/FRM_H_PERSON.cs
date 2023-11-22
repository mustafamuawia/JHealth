using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.SETTING_H
{
    public partial class FRM_H_PERSON :MEDICALCLINIC. USERSE.masterfrm
    {
        int FLAGE_SEARCH = 0;
        int cam_flg = -1;
        private FilterInfoCollection WEBCAM;
        private VideoCaptureDevice CAM;
        byte[] imge1;
        public FRM_H_PERSON()
        {
            InitializeComponent();
        }
     
    
        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            try
            {

                if (PERSON_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                    return;
                }

 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (PERSON_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(PERSON_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();




                    INSERTED.P_INSERT_T_PERSON

                        (
                        CLS.CHEECK_CODE
                        , ref CLS.CLIENT_CODE
                        , PERSON_NAME_ARTextBoxX.Text
                        , Convert.ToInt32(0)
                        , Convert.ToInt32(SEX_COMB.SelectedValue)
                        , AGE_TextBoxX.Text
                        , TXT_PHONE.Text
                        , TXT_ADDRESS.Text
                        , imge1
                        , TXT_NOTE.Text
                         , ""
                         , TXT_JOB.Text
                         , TXT_ID_NUM.Text
                         , TXT_ID_REC.Text
                         , TXT_ID_PAGE.Text
                         , TXT_ID_NUMF.Text
                         , TXT_ID_RECF.Text
                        , TXT_ID_PAGEF.Text
                        , 0
                        , TXT_FATHER.Text
                        , true
                        , ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                         MSG.Msg.Alart(AlartType.Save);
                        PERSON_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                        // this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                        //  dOCTOR_NAMEComboBox.SelectedIndex = -1;
                        SEX_COMB.SelectedIndex = -1;
                       
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

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (PERSON_CODETextBoxX.Text == "")
                {

                    errorProvider1.SetError(PERSON_CODETextBoxX, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {
                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_UPDATE_T_PERSON(
                    Convert.ToInt32(PERSON_CODETextBoxX.Text)
                    , PERSON_NAME_ARTextBoxX.Text
                    , Convert.ToInt32(0)
                    , Convert.ToInt32(SEX_COMB.SelectedValue)
                    , AGE_TextBoxX.Text, TXT_PHONE.Text
                    , TXT_ADDRESS.Text, imge1
                    , TXT_NOTE.Text
                    , TXT_JOB.Text
                    , TXT_ID_NUM.Text
                    , TXT_ID_REC.Text
                    , TXT_ID_PAGE.Text
                    , TXT_ID_NUMF.Text
                    , TXT_ID_RECF.Text
                    , TXT_ID_PAGEF.Text
                    , 0
                    , TXT_FATHER.Text
                    , true
                    , ref CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {


                        MSG.Msg.Alart(AlartType.Update);

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
                if (PERSON_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_DELETE_T_PERSON(Convert.ToInt32(PERSON_CODETextBoxX.Text), Convert.ToInt32(0), ref CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        PERSON_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            PERSONS.FRM_SEARCH_PERSON FRM = new PERSONS.FRM_SEARCH_PERSON(2);
            FRM.ShowDialog();
        }
        void CAMM_NEWFRM(object sender, NewFrameEventArgs EventArgs)
        {
            Bitmap BIT = (Bitmap)EventArgs.Frame.Clone();
            pictureBox2.Image = BIT;

        }
        private void CAM_ON_Click(object sender, EventArgs e)
        {
            try
            {
                cam_flg = 1;
                CAM = new VideoCaptureDevice(WEBCAM[COM_CAMLIST.SelectedIndex].MonikerString);
                CAM.NewFrame += new NewFrameEventHandler(CAMM_NEWFRM);
                CAM.Start();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CAM_CAPTURE_Click(object sender, EventArgs e)
        {
            //try 
            //{

            ImageConverter converter = new ImageConverter();

            byte[] imge1 = (byte[])converter.ConvertTo(pictureBox2.Image, typeof(byte[]));
            MemoryStream ms1 = new MemoryStream(imge1);
            pictureBox1.Image = Image.FromStream(ms1);
            // pictureBox1.Image = pictureBox2.Image;
            //MemoryStream ms2 = new MemoryStream();
            //pictureBox1.Image.Save(ms2, pictureBox2.Image.RawFormat);

            //}

            //   catch (System.Exception ex)
            //   {
            //       System.Windows.Forms.MessageBox.Show(ex.Message);
            //   }
        }

        private void CAM_OFF_Click(object sender, EventArgs e)
        {
            try
            {

                if (cam_flg == 1)
                {
                    cam_flg = -1;
                    CAM.Stop();
                    pictureBox2.Image = null;

                }
            }
            catch (System.Exception )
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_CHOOSE_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            cleartextbox(tableLayoutPanel14);
            cleartextbox(tableLayoutPanel15);
            cleartextbox(tableLayoutPanel16);
            pictureBox1.Image = Properties.Resources.per_img;
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

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_H_PERSON_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.T_SEX_STATE' table. You can move, or remove it, as needed.
            this.t_SEX_STATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.T_SEX_STATE);
            WEBCAM = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo VideoCaptureDevice in WEBCAM)
            {
                COM_CAMLIST.Items.Add(VideoCaptureDevice.Name);
            }
            COM_CAMLIST.SelectedIndex = 0;

        }

        private void t_SEX_STATEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_SEX_STATEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mEDICAL_CLINIC_DBDataSet);

        }

        private void FRM_H_PERSON_Shown(object sender, EventArgs e)
        {
            PERSON_NAME_ARTextBoxX.Focus();
        }

        private void PERSON_NAME_ARTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SEX_COMB.Focus();
            }
           
        }

        private void SEX_COMB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AGE_TextBoxX.Focus();
            }
        }

        private void AGE_TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_JOB.Focus();
            }
        }

        private void TXT_JOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PHONE.Focus();
            }
        }

        private void TXT_PHONE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ADDRESS.Focus();
            }
        }

       

        private void TXT_ADDRESS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_PAGE.Focus();
            }
        }
        private void TXT_ID_PAGE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_REC.Focus();
            }
        }

        private void TXT_ID_REC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_NUM.Focus();
            }
        }

        private void TXT_ID_NUM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_FATHER.Focus();
            }
        }

        private void TXT_FATHER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_PAGEF.Focus();
            }
        }

        private void TXT_ID_PAGEF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_RECF.Focus();
            }
        }

        private void TXT_ID_RECF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_NUMF.Focus();
            }
        }

        private void TXT_ID_NUMF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_NOTE.Focus();
            }
        }

        private void TXT_NOTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
BTN_ADD_Click(null,null);
            }
        }
    }
}
