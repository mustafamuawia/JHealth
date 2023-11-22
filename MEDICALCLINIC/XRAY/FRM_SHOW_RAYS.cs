using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.XRAY
{
    public partial class FRM_SHOW_RAYS : Form
    {
       public Point recLoc, lastPoint, choosingPoint;
        
       
        byte[] imge1, imge2, imge3, imge4;
      
        MemoryStream ms1, ms2, ms3, ms4;
     
        public FRM_SHOW_RAYS(byte[] pic1, byte[] pic2, byte[] pic3, byte[] pic4)//ImageList imageListFROM)
        {
            InitializeComponent();
            // imageListNOW = new ImageList();
            //imageListNOW = imageListFROM;
            //pictureBox1.Image = imageListNOW.Images[0];
            if (pic1==null)
            {
                PIC1.Image = null;
            }
            else
            if (pic1.Length>0 && pic1 !=null)
            {
                imge1 = pic1;
                ms1 = new MemoryStream(imge1);
                PIC1.Image = Image.FromStream(ms1);
            }

            if (pic2 == null)
            {
                PIC2.Image = null;
            }
            else
           if (pic2.Length > 0 && pic2 != null)
            {


                 imge2 = pic2;
                ms2 = new MemoryStream(imge2);
                PIC2.Image = Image.FromStream(ms2);
            }
            if (pic3 == null)
            {
                PIC.Image = null;
            }
            else
           if (pic3.Length > 0 && pic3 != null)
            {
                 imge3 = pic3;
                ms3 = new MemoryStream(imge3);
                PIC.Image = Image.FromStream(ms3);
            }
            if (pic4 == null)
            {
                PIC4.Image = null;
            }
            else
           if (pic4.Length > 0 && pic4 != null)
            {
                imge4 = pic4;
                ms4 = new MemoryStream(imge4);
                PIC4.Image = Image.FromStream(ms4);
            }

            PIC_MAIN.MouseWheel += PIC_MAIN_MouseWheel;
           
           
        }

        private void PIC_MAIN_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta>0)
            {
                PIC_MAIN.Width = PIC_MAIN.Width + 50;
                PIC_MAIN.Height = PIC_MAIN.Height + 50;
            }
            else
            {
                PIC_MAIN.Width = PIC_MAIN.Width - 50;
                PIC_MAIN.Height = PIC_MAIN.Height - 50;
            }
        }

        private void FRM_SHOW_RAYS_Load(object sender, EventArgs e)
        {
          //  PIC_MAIN.Image = Image.FromStream(ms1);
            // pictureBox1.Image = imageListNOW.Images[0];
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PIC1_Click(object sender, EventArgs e)
        {
            PIC_MAIN.Image = PIC1.Image;
        }


        public static Bitmap MergeTwoImages(Image firstImage, Image secondImage)
        {
            if (firstImage == null)
            {
                throw new ArgumentNullException("firstImage");
            }

            if (secondImage == null)
            {
                throw new ArgumentNullException("secondImage");
            }

            int outputImageWidth = firstImage.Width > secondImage.Width ? firstImage.Width : secondImage.Width;

            int outputImageHeight = firstImage.Height + secondImage.Height + 1;

            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.DrawImage(firstImage, new Rectangle(new Point(), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(secondImage, new Rectangle(new Point(0, firstImage.Height + 1), secondImage.Size),
                    new Rectangle(new Point(), secondImage.Size), GraphicsUnit.Pixel);
            }

            return outputImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PIC_MAIN.Image = MergeTwoImages(PIC1.Image, PIC2.Image);
            //Bitmap bitmap = new Bitmap(PIC1.Width + PIC2.Width, Math.Max(PIC1.Height, PIC2.Height));
            //using (Graphics g = Graphics.FromImage(bitmap))
            //{
            //    g.DrawImage(PIC1.Image, 0, 0);
            //   g.DrawImage(PIC2.Image, PIC1.Width, 0);
            //   // Image newImg = g;
            //    PIC_MAIN.Image = bitmap;
            //}
        }

        private void zoomin_Click(object sender, EventArgs e)
        {
            PIC_MAIN.Width = PIC_MAIN.Width + 50;
            PIC_MAIN.Height = PIC_MAIN.Height + 50;
        }

        private void zoomout_Click(object sender, EventArgs e)
        {
            PIC_MAIN.Width = PIC_MAIN.Width - 50;
            PIC_MAIN.Height = PIC_MAIN.Height - 50;
        }

        //private void PIC_MAIN_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (WorkAble)
        //    {
        //        recLoc.X = recLoc.X + e.X - choosingPoint.X;
        //        recLoc.Y = recLoc.Y + e.Y - choosingPoint.Y;
        //        choosingPoint = e.Location;
        //        PIC_MAIN.Invalidate();
        //    }
        //}

        //private void PIC_MAIN_Paint(object sender, PaintEventArgs e)
        //{
        //    if(PIC_MAIN.Image!=null)
        //    e.Graphics.DrawImage(PIC_MAIN.Image, recLoc);
        //}

        //private void PIC_MAIN_MouseDown(object sender, MouseEventArgs e)
        //{
        //    WorkAble = true;
        //    lastPoint.X = e.X;
        //    lastPoint.Y = e.Y;
        //}

        //private void PIC_MAIN_MouseUp(object sender, MouseEventArgs e)
        //{

        //    mouseMove = false;
        //    lastPointX = e.X;
        //    lastPointY = e.Y;
        //}

        private void rright_Click(object sender, EventArgs e)
        {
            Image img = PIC_MAIN.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PIC_MAIN.Image = img;
        }

        private void rleft_Click(object sender, EventArgs e)
        {
            Image img = PIC_MAIN.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            PIC_MAIN.Image = img;
        }

        private void PIC2_Click(object sender, EventArgs e)
        {
            PIC_MAIN.Image = PIC2.Image;
        }

        private void PIC_Click(object sender, EventArgs e)
        {
            PIC_MAIN.Image = PIC.Image;
        }

        private void PIC4_Click(object sender, EventArgs e)
        {
            PIC_MAIN.Image = PIC4.Image;
        }
    }
}
