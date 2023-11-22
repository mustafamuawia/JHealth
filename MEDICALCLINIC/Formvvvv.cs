using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC
{
    public partial class Formvvvv : Form
    {
        byte[] imge1;
        public Formvvvv()
        {
            InitializeComponent();
        }

        private void Formvvvv_Load(object sender, EventArgs e)
        {

        }

        private void Formvvvv_MouseClick(object sender, MouseEventArgs e)
        {
            var lav = new Label
            {
                Text = textBox1.Text,
                Size = new Size(32, 32),
                Location = PointToClient(MousePosition),
                Image = Properties.Resources.per_img,
                //SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(lav);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var picture = new PictureBox
            //{
            //    Name = "pictureBox",
            //    Size = new Size(16, 16),
            //    Location = new Point(MousePosition.X - this.ClientSize.Width, MousePosition.Y - this.ClientSize.Height),

            //    Image = Properties.Resources.NOPIC,
            //    SizeMode = PictureBoxSizeMode.StretchImage
            //};
            //this.Controls.Add(picture);
            //Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            //panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //bmp.Save(@"D:\MyPanelImage.bmp");

            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {

                Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"D:\MyPanelImageaa.bmp");
                bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                imge1 = stream.ToArray();
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            var lav = new Label
            {
                Text = textBox1.Text+"x",
                Size = new Size(32, 32),
                BackColor=Color.Transparent,
                Location =panel1.PointToClient(MousePosition),

                //Image = Properties.Resources.NOPIC,
                //SizeMode = PictureBoxSizeMode.StretchImage


                //Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                //panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                //imge1 = ImageToByteArray(bmp);
            };
            
            panel1.Controls.Add(lav);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process photoViewer = new Process();
            //photoViewer.StartInfo.FileName = @"The photo viewer file path";
            //photoViewer.StartInfo.Arguments = @"Your image file path";
            //photoViewer.Start();
            //System.Diagnostics.Process.Start(pictureBox1.Image*/);
        }
    }
}
