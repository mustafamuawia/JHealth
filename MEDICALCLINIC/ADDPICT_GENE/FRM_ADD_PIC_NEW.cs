using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.ADDPICT_GENE
{
    public partial class FRM_ADD_PIC_NEW : Form
    {
        byte[] imge1;
        byte[] imge2;
        byte[] imge3;
        byte[] imge4;
        byte[] imge5;

        public FRM_ADD_PIC_NEW()
        {
            InitializeComponent();
        }
        private FilterInfoCollection WEBCAM;
        private VideoCaptureDevice CAM;

      

      

        private void N_PIC1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC1.Image = Image.FromFile(ofd1.FileName);
            }
        }

     
        private void N_PIC2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC2.Image = Image.FromFile(ofd1.FileName);
            }
        }

     

        private void N_PIC3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC3.Image = Image.FromFile(ofd1.FileName);
            }
        }

    
        private void N_PIC4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC4.Image = Image.FromFile(ofd1.FileName);
            }
        }

      

        private void N_PIC5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC5.Image = Image.FromFile(ofd1.FileName);
            }
        }
         
        private void FRM_IMGE_PRSN_Load(object sender, EventArgs e)
        {
              try
            {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            WEBCAM = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo VideoCaptureDevice in WEBCAM)
            {
                COM_CAMLIST.Items.Add(VideoCaptureDevice.Name);
            }
            COM_CAMLIST.SelectedIndex = 0;

            }
              catch (System.Exception ex)
              {
                  System.Windows.Forms.MessageBox.Show(ex.Message);
              }
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            CLS.FALGE_PERSON_IMG = 1;
            SEARCH.FRM_SEARCH_IMG_PER FRM = new SEARCH.FRM_SEARCH_IMG_PER();
            FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLS.FALGE_PERSON_IMG = 2;
            SEARCH.FRM_SEARCH_IMG_PER FRM = new SEARCH.FRM_SEARCH_IMG_PER();
            FRM.ShowDialog();
        }

        
        void CAMM_NEWFRM(object sender, NewFrameEventArgs EventArgs)
        {
            Bitmap BIT = (Bitmap)EventArgs.Frame.Clone();
            picCapture.Image = BIT;

        }
 
        private void button19_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // saveFileDialog1.Filter = "png ,jpg,";
                PictureBoxSave.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

    
        private void buttonX8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC1.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC2.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC3.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC4.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC5.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            CAM = new VideoCaptureDevice(WEBCAM[COM_CAMLIST.SelectedIndex].MonikerString);
            CAM.NewFrame += new NewFrameEventHandler(CAMM_NEWFRM);
            CAM.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PictureBoxSave.Image = picCapture.Image;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // saveFileDialog1.Filter = "png ,jpg,";
                PictureBoxSave.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CAM.IsRunning)
            {
                CAM.Stop();
                picCapture.Image = null;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int doc_x = Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue);
                CLS.DOCTOR_CODE_ADD_IMG = doc_x;
                ADDPICT_GENE.FRM_SEARCH_ADD_PIC FRM = new FRM_SEARCH_ADD_PIC();
                FRM.ShowDialog();
            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {
                    MemoryStream ms1 = new MemoryStream();
                    N_PIC1.Image.Save(ms1, N_PIC1.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    MemoryStream ms2 = new MemoryStream();
                    N_PIC2.Image.Save(ms2, N_PIC2.Image.RawFormat);
                    imge2 = ms2.ToArray();
                    MemoryStream ms3 = new MemoryStream();
                    N_PIC3.Image.Save(ms3, N_PIC3.Image.RawFormat);
                    imge3 = ms3.ToArray();
                    MemoryStream ms4 = new MemoryStream();
                    N_PIC4.Image.Save(ms4, N_PIC4.Image.RawFormat);
                    imge4 = ms4.ToArray();
                    MemoryStream ms5 = new MemoryStream();
                    N_PIC5.Image.Save(ms5, N_PIC5.Image.RawFormat);
                    imge5 = ms5.ToArray();
                    var INSERTED_IMGE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED_IMGE.P_INSERT_T_IMAGE(Convert.ToInt32(LBL_PERS_CODE.Text), Convert.ToInt32(LBL_BOOK_CODE.Text), imge1, imge2, imge3, imge4, imge5, ref  CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        var UPD_STATE_IMGE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        UPD_STATE_IMGE.P_IN_ACTIVE_IMG_ADD_STATE(Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToInt32(LBL_BOOK_CODE.Text), 0, ref  CLS.SUBMIT_FLAG);
                        MSG.Msg.Alart(AlartType.Save);
                        LBL_PERS_CODE.Text = "لايتوفر كود";
                        LBL_PERS_NAME.Text = "لايتوفر أسم مريض";
                        LBL_BOOK_CODE.Text = "لايتوفر أسم مريض";
                        N_PIC1.Image = Properties.Resources.test;
                        N_PIC2.Image = Properties.Resources.test;
                        N_PIC3.Image = Properties.Resources.test;
                        N_PIC4.Image = Properties.Resources.test;
                        N_PIC5.Image = Properties.Resources.test;

                    }
                    else
                    {
                        MSG.Msg.Alart(AlartType.Error);
                    }
                }
                //else
                //    if (CLS.SUBMIT_FLAG == 0)
                //    {

                //        MemoryStream ms1 = new MemoryStream();
                //        N_PIC1.Image.Save(ms1, N_PIC1.Image.RawFormat);
                //        imge1 = ms1.ToArray();
                //        MemoryStream ms2 = new MemoryStream();
                //        N_PIC2.Image.Save(ms2, N_PIC2.Image.RawFormat);
                //        imge2 = ms2.ToArray();
                //        MemoryStream ms3 = new MemoryStream();
                //        N_PIC3.Image.Save(ms3, N_PIC3.Image.RawFormat);
                //        imge3 = ms3.ToArray();
                //        MemoryStream ms4 = new MemoryStream();
                //        N_PIC4.Image.Save(ms4, N_PIC4.Image.RawFormat);
                //        imge4 = ms4.ToArray();
                //        MemoryStream ms5 = new MemoryStream();
                //        N_PIC5.Image.Save(ms5, N_PIC5.Image.RawFormat);
                //        imge5 = ms5.ToArray();
                //        var INSERTED_IMGE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                //        INSERTED_IMGE.P_UPDATE_T_IMAGE(CLS.ID_PERSON_IMG, CLS.ID_BOOKING_IMG, imge1, imge2, imge3, imge4, imge5, ref  CLS.SUBMIT_FLAG);



            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if (CAM.IsRunning)
            //{
            //    CAM.Stop();
            //    picCapture.Image = null;

            //}
            this.Close();
        }

        
    }
}
