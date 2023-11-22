using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace MEDICALCLINIC.DIAGNOSES
{
    public partial class FRM_IMG_PER_BOOK : Form
    {
        Bitmap bm;
        Size bm_size;
        int zommm;
        int limit;
        public FRM_IMG_PER_BOOK()
        {
            InitializeComponent();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
          

        }
        DataTable DT = new DataTable();
        private void FRM_IMG_PER_BOOK_Load(object sender, EventArgs e)
        {
            try
            {
             this.p_GET_IMG_BY_CODE_BOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BY_CODE_BOOK, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.CODE_BOOK_IMG, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.CODE_PER_IMG, typeof(int))))));
             DT = this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BY_CODE_BOOK;
             TXT_PERSON.Text = DT.Rows[0][1].ToString() ;
             TXT_ID_BOOK.Text = DT.Rows[0][0].ToString();
                byte[] imge1 = (byte[])DT.Rows [0][13];
            MemoryStream ms1 = new MemoryStream(imge1);
            BB_PIC1.Image = Image.FromStream(ms1);

            byte[] imge2 = (byte[])(byte[])DT.Rows[0][14];
            MemoryStream ms2 = new MemoryStream(imge2);
            BB_PIC2.Image = Image.FromStream(ms2);

            byte[] imge3 = (byte[])(byte[])DT.Rows[0][15];
            MemoryStream ms3 = new MemoryStream(imge3);
            BB_PIC3.Image = Image.FromStream(ms3);

            byte[] imge4 = (byte[])(byte[])DT.Rows[0][16];
            MemoryStream ms4 = new MemoryStream(imge4);
            BB_PIC4.Image = Image.FromStream(ms4);

            byte[] imge5 = (byte[])(byte[])DT.Rows[0][17];
            MemoryStream ms5 = new MemoryStream(imge5);
            BB_PIC5.Image = Image.FromStream(ms5);

            
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BB_PIC1_Click(object sender, EventArgs e)
        {
           MAIN_PIC .Image = BB_PIC1.Image;
           bm = new Bitmap(MAIN_PIC.Image);
           bm_size = bm.Size;
           zommm = 1;
           limit = 128;
        }

        private void BB_PIC2_Click(object sender, EventArgs e)
        {
            MAIN_PIC.Image = BB_PIC2.Image;
            bm = new Bitmap(MAIN_PIC.Image);
            bm_size = bm.Size;
            zommm = 1;
            limit = 128;
        }

        private void BB_PIC3_Click(object sender, EventArgs e)
        {
            MAIN_PIC.Image = BB_PIC3.Image;
            bm = new Bitmap(MAIN_PIC.Image);
            bm_size = bm.Size;
            zommm = 1;
            limit = 128;
        }

        private void BB_PIC4_Click(object sender, EventArgs e)
        {
            MAIN_PIC.Image = BB_PIC4.Image;
            bm = new Bitmap(MAIN_PIC.Image);
            bm_size = bm.Size;
            zommm = 1;
            limit = 128;
        }

        private void BB_PIC5_Click(object sender, EventArgs e)
        {
            MAIN_PIC.Image = BB_PIC5.Image;
            bm = new Bitmap(MAIN_PIC.Image);
            bm_size = bm.Size;
            zommm = 1;
            limit = 128;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (zommm < limit)
                {
                    zommm = zommm * 2;
                }
                MAIN_PIC .Size = new Size(zommm * bm_size.Width, zommm * bm_size.Height);
                MAIN_PIC.Invalidate();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (zommm > 0)
                {
                    zommm = zommm / 2;
                }
                MAIN_PIC.Size = new Size(zommm * bm_size.Width, zommm * bm_size.Height);
                MAIN_PIC.Invalidate();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bm.RotateFlip(RotateFlipType.Rotate90FlipY);
            MAIN_PIC.Image = bm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bm.RotateFlip(RotateFlipType.Rotate90FlipXY);
            MAIN_PIC.Image = bm;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        

    }
}