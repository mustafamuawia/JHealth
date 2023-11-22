using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_ADD_RPT_IMG_TBL : USERSE.masterfrm
    {
        byte[] imgeHEADER;
        byte[] imgeBODY;
        byte[] imgeFOOTER;
        byte[] imgeLOGO;
        public FRM_ADD_RPT_IMG_TBL()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                IMG_HEADER.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                IMG_BODY.Image = Image.FromFile(ofd2.FileName);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd3 = new OpenFileDialog();
            ofd3.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd3.ShowDialog() == DialogResult.OK)
            {
                IMG_FOOTER.Image = Image.FromFile(ofd3.FileName);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd4 = new OpenFileDialog();
            ofd4.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd4.ShowDialog() == DialogResult.OK)
            {
                IMG_LOGO.Image = Image.FromFile(ofd4.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{

                 

                
            //        var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            //        MemoryStream ms1 = new MemoryStream();
            //        pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
            //        imge1 = ms1.ToArray();
            //    MemoryStream ms2 = new MemoryStream();
            //    pictureBox2.Image.Save(ms2, pictureBox2.Image.RawFormat);
            //    imge2 = ms2.ToArray();
            //    MemoryStream ms3 = new MemoryStream();
            //    pictureBox3.Image.Save(ms3, pictureBox3.Image.RawFormat);
            //    imge3 = ms3.ToArray();
            //    MemoryStream ms4 = new MemoryStream();
            //    pictureBox4.Image.Save(ms4, pictureBox4.Image.RawFormat);
            //    imge4 = ms4.ToArray();

            //    INSERTED.P_INSERT_T_IMG_RPT_TBL

            //            (
            //              imge1
            //            , imge2
            //            , imge3
            //            , imge4
            //            , 1
            //            ,
            //            , ref CLS.SUBMIT_FLAG);


            //        if (CLS.SUBMIT_FLAG == 1)
            //        {
                        
                     

            //            MSG.Msg.Alart(AlartType.Error);

            //        }
                
            //}

            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            //}
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {


                if (rPT_NAMEComboBox.Text == String.Empty&& rPT_NAMEComboBox.SelectedIndex ==-1)
                {
                    MessageBox.Show("يرجى ادخال البيانات بصورة صحيحة  ");
                    return;
                }
               else
               {
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    MemoryStream ms1 = new MemoryStream();
                    IMG_HEADER.Image.Save(ms1, IMG_HEADER.Image.RawFormat);
                    imgeHEADER = ms1.ToArray();
                    MemoryStream ms2 = new MemoryStream();
                    IMG_BODY.Image.Save(ms2, IMG_BODY.Image.RawFormat);
                    imgeBODY = ms2.ToArray();
                    MemoryStream ms3 = new MemoryStream();
                    IMG_FOOTER.Image.Save(ms3, IMG_FOOTER.Image.RawFormat);
                    imgeFOOTER = ms3.ToArray();
                    MemoryStream ms4 = new MemoryStream();
                    IMG_LOGO.Image.Save(ms4, IMG_LOGO.Image.RawFormat);
                    imgeLOGO = ms4.ToArray();

                    INSERTED.P_INSERT_T_IMG_RPT_TBL
                            (
                              imgeHEADER
                            , imgeBODY
                            , imgeFOOTER
                            , imgeLOGO
                            , Convert.ToInt32(rPT_NAMEComboBox.SelectedValue)
                            , rPT_NAMEComboBox.Text
                            , ref CLS.SUBMIT_FLAG);


                }




                if (CLS.SUBMIT_FLAG == 1)
                {



                    MSG.Msg.Alart(AlartType.Save);

                }

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {


                if (rPT_NAMEComboBox.SelectedIndex>-1)
                {
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                MemoryStream ms1 = new MemoryStream();
                IMG_HEADER.Image.Save(ms1, IMG_HEADER.Image.RawFormat);
                imgeHEADER = ms1.ToArray();
                MemoryStream ms2 = new MemoryStream();
                IMG_BODY.Image.Save(ms2, IMG_BODY.Image.RawFormat);
                imgeBODY = ms2.ToArray();
                MemoryStream ms3 = new MemoryStream();
                IMG_FOOTER.Image.Save(ms3, IMG_FOOTER.Image.RawFormat);
                imgeFOOTER = ms3.ToArray();
                MemoryStream ms4 = new MemoryStream();
                IMG_LOGO.Image.Save(ms4, IMG_LOGO.Image.RawFormat);
                imgeLOGO = ms4.ToArray();

                INSERTED.P_UPDATE_T_IMG_RPT_TBL

                        (
                          Convert.ToInt32(rPT_NAMEComboBox.SelectedValue)
                        , imgeHEADER
                        , imgeBODY
                        , imgeFOOTER
                        , imgeLOGO
                        , Convert.ToInt32(rPT_NAMEComboBox.SelectedValue)
                        , rPT_NAMEComboBox.Text
                        , ref CLS.SUBMIT_FLAG);

                }

               

                if (CLS.SUBMIT_FLAG == 1)
                {



                    MSG.Msg.Alart(AlartType.Update);

                }

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            SETTING.FRM_SEARCH_IMG_RPT FRM = new SETTING.FRM_SEARCH_IMG_RPT();
            FRM.ShowDialog();
        }

        private void FRM_ADD_RPT_IMG_TBL_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_IMG_RPT' table. You can move, or remove it, as needed.
            this.v_GET_IMG_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_IMG_RPT);
            rPT_NAMEComboBox.SelectedIndex = -1;
        }

        private void pic_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
