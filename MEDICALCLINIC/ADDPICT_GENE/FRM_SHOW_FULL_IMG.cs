using System;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC
{
    public partial class FRM_SHOW_FULL_IMG : Form
    {
        
        public Boolean IsClickMouse = false;
        Point p = new Point();
        public FRM_SHOW_FULL_IMG( )
        {
            InitializeComponent();
            
         
        }
        Bitmap bm;
        Size bm_size;
        int zommm;
        int limit;

 
 
        private void FRM_SHOW_FULL_IMG_Load(object sender, EventArgs e)
        {
            try
            {

                bm = new Bitmap(pictureBox1.Image);
                bm_size = bm.Size;
                zommm = 1;
                limit = 128;
            }
            catch
            {
                return;
            }
        }
 

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
      
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    IsClickMouse = true;
                    p = e.Location;
                }

            }
            catch
            {
                return;
            }
        }
 
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    IsClickMouse = true;
                    p = e.Location;
                }

            }
            catch
            {
                return;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (IsClickMouse == true && e.Y > p.Y)
                {
                    panel1.VerticalScroll.Value += 10;
                    p = e.Location;
                }
                else
                    if (IsClickMouse == true && e.Y < p.Y)
                    {
                        panel1.VerticalScroll.Value -= 10;
                        p = e.Location;
                    }

               
            }
            catch
            {
                return;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {


                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    IsClickMouse = false;
            }
            catch
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (zommm <= 0)
                {
                    zommm = 1;
                }
                if (zommm < limit)
                {
                    zommm = zommm * 2;
                }
                pictureBox1.Size = new Size(zommm * bm_size.Width, zommm * bm_size.Height);
                pictureBox1.Invalidate();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (zommm > 0)
                {
                    zommm = zommm / 2;

                }
                if (zommm != 0)
                {
                    pictureBox1.Size = new Size(zommm * bm_size.Width, zommm * bm_size.Height);
                    pictureBox1.Invalidate();
                }
                //else
                // {

                //  }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bm.RotateFlip(RotateFlipType.Rotate90FlipY);
            pictureBox1.Image = bm;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            bm.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBox1.Image = bm;
        }

      
    }
}
