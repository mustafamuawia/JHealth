using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.ADDPICT_GENE
{
    public partial class FRM_IMG_BOOKING_SHOW : Form
    {
        DataTable DT = new DataTable();
        Bitmap bm;
        Size bm_size;
        int zommm;
        int limit;
        Image imgOriginal;
        int BOOK_ID,IDFLAG=0;
        public FRM_IMG_BOOKING_SHOW(int BOOK_CODE,int flg)
        {
            InitializeComponent();
            BOOK_ID = BOOK_CODE;
            IDFLAG = flg;
        }

        //public void ResizeImage(string fileName, int width, int height)
        //{
        //    using (Image image = Image.FromFile(fileName))
        //    {
        //        new Bitmap(image, width, height).Save(fileName);
        //    }
        //}
        Image ZoomPicture(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width),
                Convert.ToInt32(img.Height * size.Height));
            Graphics gpu = Graphics.FromImage(bm);
            gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bm;
        }

        PictureBox org;
        private void FRM_IMG_BOOKING_SHOW_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;

            this.DoubleBuffered = true; //minimizes the strutter
            if (IDFLAG==1)
            {
                this.p_GET_T_BOOKING_T_PERSON_IMGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_IMG, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_ID, typeof(int))))));
                DT = this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_IMG;
            }
            else
             if (IDFLAG == 2)
            {
                this.gET_T_IMG_RAISTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_IMG_RAIS, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_ID, typeof(int))))));
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_T_IMG_RAIS;
            }
            if (DT.Rows.Count>0)
            {

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 6;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

           
            //org = new PictureBox();
            //org.Image = pictureBox1.Image;
           // this.p_GET_T_BOOKING_T_PERSON_IMGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_IMG, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_ID, typeof(int))))));
            FILL_MENU();
            }
           
        }

        void FILL_MENU()
        {
            try
            {
                MemoryStream ms1=null;
                int i; byte[] imge1;
                flowLayoutPanel1.Controls.Clear();
              
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    //CLS.DESC_CODE = DT.Rows[i][3].ToString();
                    //CLS.DESC_NAME = DT.Rows[i][1].ToString();
                    if (IDFLAG==1)
                    {
                         imge1 = (byte[])DT.Rows[i][1];
                          ms1 = new MemoryStream(imge1);
                    }
                    else
                     if (IDFLAG == 2)
                    {
                      imge1 = (byte[])DT.Rows[i][2];
                          ms1 = new MemoryStream(imge1);
                    }
                   
                   
                    
                    PictureBox BTN_MENU = new PictureBox();
                    BTN_MENU.Click += Click_MENU_ME;
                    BTN_MENU.BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)14.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.Yellow;
                    BTN_MENU.Size = new System.Drawing.Size(flowLayoutPanel1.Width - 5, Convert.ToInt32(DT.Rows.Count) > 1 ? flowLayoutPanel1.Height / DT.Rows.Count : flowLayoutPanel1.Height / 2);
                   
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Image = Image.FromStream(ms1);
                    BTN_MENU.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel1.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception )
            {

              //  MessageBox.Show(EX.Message);

            }


        }


        private void Click_MENU_ME(object Sender, EventArgs e)
        {

            try
            {

                PictureBox BTN_MENU_CLICK = default(PictureBox);
                BTN_MENU_CLICK = (PictureBox)Sender;
               // ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DESC.Text += BTN_MENU_CLICK.Text + "\r\n";
                pictureBox1.Image = BTN_MENU_CLICK.Image;
                imgOriginal = pictureBox1.Image;
                org = new PictureBox();
                org.Image = pictureBox1.Image;

                bm = new Bitmap(pictureBox1.Image);
                bm_size = bm.Size;
                zommm = 1;
                limit = 128;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }

        
        //Zoom image file
        Image Zoom(Image img, Size size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            //if (trackBar1.Value > 0)
            //{
            //    pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
            //}
            if (trackBar1.Value != 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = ZoomPicture(org.Image, new Size(trackBar1.Value, trackBar1.Value));
            }
        }

        private void BTN_ZOOMIN_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = (int)(pictureBox1.Top - (pictureBox1.Height * 0.025));
            pictureBox1.Left = (int)(pictureBox1.Left - (pictureBox1.Width * 0.025));
            pictureBox1.Height = (int)(pictureBox1.Height + (pictureBox1.Height * 0.05));
            pictureBox1.Width = (int)(pictureBox1.Width + (pictureBox1.Width * 0.05));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //try
            //{
            //    if (zommm < limit)
            //    {
            //        zommm = zommm * 2;
            //    }
            //    pictureBox1.Size = new Size(zommm * bm_size.Width, zommm * bm_size.Height);
            //    pictureBox1.Invalidate();
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void BTN_ZOOMOUT_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = (int)(pictureBox1.Top + (pictureBox1.Height * 0.025));
            pictureBox1.Left = (int)(pictureBox1.Left + (pictureBox1.Width * 0.025));
            pictureBox1.Height = (int)(pictureBox1.Height - (pictureBox1.Height * 0.05));
            pictureBox1.Width = (int)(pictureBox1.Width - (pictureBox1.Width * 0.05));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //try
            //{
            //    if (zommm > 0)
            //    {
            //        zommm = zommm / 2;
            //    }
            //    pictureBox1.Size = new Size(zommm * bm_size.Width, zommm * bm_size.Height);
            //    pictureBox1.Invalidate();
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void BTN_RR_Click(object sender, EventArgs e)
        {
            bm.RotateFlip(RotateFlipType.Rotate90FlipY);
            pictureBox1.Image = bm;
        }

        

        private void BTN_RL_Click(object sender, EventArgs e)
        {
            bm.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = bm;
        }
    }
}
