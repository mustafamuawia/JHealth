using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC
{
    public partial class FRM_IMGE_PRSN : Form
    {
        byte[] imge1;
        byte[] imge2;
        byte[] imge3;
        byte[] imge4;
        byte[] imge5;
    
        public FRM_IMGE_PRSN()
        {
            InitializeComponent();
        }
      //  private FilterInfoCollection WEBCAM;
       // private VideoCaptureDevice CAM;

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

       

        private void A_PIC1_Click_1(object sender, EventArgs e)
        {
            PIC_BEFOR.Image = BB_PIC1.Image;
        }

        private void N_PIC1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC1 .Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void button13_Click(object sender, EventArgs e)
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

        private void button14_Click(object sender, EventArgs e)
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

        private void button15_Click(object sender, EventArgs e)
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

        private void button16_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC4.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                N_PIC5.Image = Image.FromFile(ofd1.FileName);
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

        private void button8_Click(object sender, EventArgs e)
        {
         PIC_BEFOR.Image  =   BB_PIC5.Image;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            PIC_BEFOR.Image = BB_PIC1.Image;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PIC_BEFOR.Image = BB_PIC2.Image;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PIC_BEFOR.Image = BB_PIC3.Image;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PIC_BEFOR.Image = BB_PIC4.Image;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC1.Image;
        }

        private void A_PIC2_Click(object sender, EventArgs e)
        {
            PIC_BEFOR.Image = BB_PIC2.Image;
        }

        private void A_PIC3_Click(object sender, EventArgs e)
        {
            PIC_BEFOR.Image = BB_PIC3.Image;
        }

        private void A_PIC4_Click(object sender, EventArgs e)
        {
            PIC_BEFOR.Image = BB_PIC4.Image;
        }

        private void A_PIC5_Click(object sender, EventArgs e)
        {
            PIC_BEFOR.Image = BB_PIC5.Image;
        }

        private void B_PIC1_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC1.Image;
        }

        private void B_PIC2_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC2.Image;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC2.Image;
        }

        private void B_PIC3_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC3.Image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC3.Image;
        }

        private void B_PIC4_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC4.Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC4.Image;
        }

        private void B_PIC5_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC5.Image;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PIC_AFTER.Image = A_PIC5.Image;
        }

        private void FRM_IMGE_PRSN_Load(object sender, EventArgs e)
        {
            //WEBCAM = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //foreach (FilterInfo VideoCaptureDevice in WEBCAM)
            //{
            //    COM_CAMLIST.Items.Add(VideoCaptureDevice.Name);
            //}
            //COM_CAMLIST.SelectedIndex = 0;

            // LBL_PERSON_NAME.Text = CLS.PERSON_NAME_IMGE;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try{

            var CHECK_CODE_PER = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            CHECK_CODE_PER.P_CHECK_PIC_ISAVAL(Convert.ToInt32(LBL_BOOK_CODE.Text),Convert.ToInt32( LBL_PER_CODE.Text),ref  CLS.SUBMIT_FLAG);
            if (CLS.SUBMIT_FLAG == 0)
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

                INSERTED_IMGE.P_INSERT_T_IMAGE(Convert.ToInt32(LBL_PER_CODE.Text), Convert.ToInt32(LBL_BOOK_CODE.Text), imge1, imge2, imge3, imge4, imge5, ref  CLS.SUBMIT_FLAG);
                if (CLS.SUBMIT_FLAG == 1)
                {
                    MSG.Msg.Alart(AlartType.Save);

                }
                else
                {

                    MSG.Msg.Alart(AlartType.Error);

                }    
            }
            else
                if (CLS.SUBMIT_FLAG == 1)
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

                INSERTED_IMGE.P_UPDATE_T_IMAGE (Convert.ToInt32(LBL_PER_CODE.Text), Convert.ToInt32(LBL_BOOK_CODE.Text), imge1, imge2, imge3, imge4, imge5, ref  CLS.SUBMIT_FLAG);
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
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLS.FALGE_PERSON_IMG = 1;
            CLS.ID_PERSON_IMG =Convert.ToInt32( LBL_PER_CODE.Text);
            SEARCH.FRM_SEARCH_IMG_PER FRM = new SEARCH.FRM_SEARCH_IMG_PER();
            FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLS.FALGE_PERSON_IMG = 2;
            CLS.ID_PERSON_IMG = Convert.ToInt32(LBL_PER_CODE.Text);
            SEARCH.FRM_SEARCH_IMG_PER FRM = new SEARCH.FRM_SEARCH_IMG_PER();
            FRM.ShowDialog();
        }

        
        
        private void button23_Click(object sender, EventArgs e)
        {
            FRM_SHOW_FULL_IMG FRM = new FRM_SHOW_FULL_IMG();
            FRM.pictureBox1.Image = PIC_BEFOR.Image;
            FRM.ShowDialog();

        }

        private void button24_Click(object sender, EventArgs e)
        {
            FRM_SHOW_FULL_IMG FRM = new FRM_SHOW_FULL_IMG();
            FRM.pictureBox1.Image = PIC_AFTER.Image;
            FRM.ShowDialog();
        }

        private void PIC_BEFOR_Click(object sender, EventArgs e)
        {
            FRM_SHOW_FULL_IMG FRM = new FRM_SHOW_FULL_IMG();
            FRM.pictureBox1.Image = PIC_BEFOR.Image;
            FRM.ShowDialog();

        }

        private void PIC_AFTER_Click(object sender, EventArgs e)
        {
            FRM_SHOW_FULL_IMG FRM = new FRM_SHOW_FULL_IMG();
            FRM.pictureBox1.Image = PIC_AFTER.Image;
            FRM.ShowDialog();
        }

       

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            if (PIC_BEFOR.Image == null)
            {
                MessageBox.Show("رجاءا حدد الصورة اولا");
                return;
            }
            else
            {
          FRM_SHOW_FULL_IMG FRM = new FRM_SHOW_FULL_IMG();
            FRM.pictureBox1.Image = PIC_BEFOR.Image;
            FRM.ShowDialog();
            }
          
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            if (PIC_BEFOR.Image == null)
            {
                MessageBox.Show("رجاءا حدد الصورة اولا");
                return;
            }
            else
            {
           FRM_SHOW_FULL_IMG FRM = new FRM_SHOW_FULL_IMG();
            FRM.pictureBox1.Image = PIC_AFTER.Image;
            FRM.ShowDialog();
            }
            
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void BTN_SEARCH_BOOK_Click(object sender, EventArgs e)
        {
            XRAY.FRM_BOOK_PIC_SEARCH FRM = new XRAY.FRM_BOOK_PIC_SEARCH();FRM.ShowDialog();
        }
    }
}
