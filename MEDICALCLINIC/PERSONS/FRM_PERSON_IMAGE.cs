using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.PERSONS
{
    public partial class FRM_PERSON_IMAGE : Form
    {
        byte[] imge1;
        byte[] imge2;
        byte[] imge3;
        byte[] imge4;
        byte[] imge5;
        byte[] imge6;
        byte[] imge7;
        byte[] imge8;
        byte[] imge9;
        byte[] imge10;
        byte[] imgetest;
        public FRM_PERSON_IMAGE()
        {
            InitializeComponent();
        }

        private void FRM_PERSON_IMAGE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
            this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
            DataTable dt = new DataTable();
            dt = this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON;
            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasource.Add(dt.Rows[i][1].ToString());
            }
            this.pERSON_NAMEComboBox .AutoCompleteCustomSource = datasource;
            this.pERSON_NAMEComboBox .AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.pERSON_NAMEComboBox .AutoCompleteMode = AutoCompleteMode.SuggestAppend;

           // pictureBox11.Image = Properties.Resources.test;     
            
        }

      

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_IMG_PER_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE,  Convert .ToInt32 (pERSON_NAMEComboBox .SelectedValue ));
                if (this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows.Count > 0)
                {
                    textBox1.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][7].ToString();
                    textBox2.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][8].ToString();
                    textBox3.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][9].ToString();
                    textBox4.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][10].ToString();
                    textBox5.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][11].ToString();
                    textBox6.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][12].ToString();
                    textBox7.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][13].ToString();
                    textBox8.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][14].ToString();
                    textBox9.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][15].ToString();
                    textBox10.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][16].ToString();

                    byte[] imge1 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][17];
                    MemoryStream ms1 = new MemoryStream(imge1);
                    pictureBox1.Image = Image.FromStream(ms1);

                    byte[] imge2 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][18];
                    MemoryStream ms2 = new MemoryStream(imge2);
                    pictureBox2.Image = Image.FromStream(ms2);

                    byte[] imge3 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][19];
                    MemoryStream ms3 = new MemoryStream(imge3);
                    pictureBox3.Image = Image.FromStream(ms3);

                    byte[] imge4 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][20];
                    MemoryStream ms4 = new MemoryStream(imge4);
                    pictureBox4.Image = Image.FromStream(ms4);

                    byte[] imge5 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][21];
                    MemoryStream ms5 = new MemoryStream(imge5);
                    pictureBox5.Image = Image.FromStream(ms5);

                    byte[] imge6 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][22];
                    MemoryStream ms6 = new MemoryStream(imge6);
                    pictureBox7.Image = Image.FromStream(ms6);

                    byte[] imge7 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][23];
                    MemoryStream ms7 = new MemoryStream(imge7);
                    pictureBox9.Image = Image.FromStream(ms7);

                    byte[] imge8 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][24];
                    MemoryStream ms8 = new MemoryStream(imge8);
                    pictureBox10.Image = Image.FromStream(ms8);

                    byte[] imge9 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][25];
                    MemoryStream ms9 = new MemoryStream(imge9);
                    pictureBox10.Image = Image.FromStream(ms9);

                    byte[] imge10 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][26];
                    MemoryStream ms10 = new MemoryStream(imge10);
                    pictureBox6.Image = Image.FromStream(ms10);
                }
                else
                {
                    MessageBox.Show("لايوجد ملفات لهذا المريض");
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //byte[] imgete = (byte[])Properties.Resources.test.ToString();
        //MemoryStream mstest = new MemoryStream(imgete);
        //pictureBox3.Image = Image.FromStream(mstest);
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == Properties.Resources.test)
            {
                OpenFileDialog ofd1 = new OpenFileDialog();
                ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd1.FileName);
                }
            }
            else
            {
                FRM_SHOW_FULL_IMG FRM = new FRM_SHOW_FULL_IMG();
                FRM.pictureBox1.Image = pictureBox1.Image;
                FRM.ShowDialog();
            }

 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image ==  Properties.Resources.test)
            {
                OpenFileDialog ofd1 = new OpenFileDialog();
                ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = Image.FromFile(ofd1.FileName);
                }
            }
            else
            {
                FRM_SHOW_FULL_IMG FRM = new FRM_SHOW_FULL_IMG();
                FRM.pictureBox1.Image = pictureBox2.Image;
                FRM.ShowDialog();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox6.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox7.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox8.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox9.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox10.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_IMG_PER_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE, Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue));
                if (this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows.Count > 0)
                {
                    textBox1.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][7].ToString();
                    textBox2.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][8].ToString();
                    textBox3.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][9].ToString();
                    textBox4.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][10].ToString();
                    textBox5.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][11].ToString();
                    textBox6.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][12].ToString();
                    textBox7.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][13].ToString();
                    textBox8.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][14].ToString();
                    textBox9.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][15].ToString();
                    textBox10.Text = this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][16].ToString();

                    byte[] imge1 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][17];
                    MemoryStream ms1 = new MemoryStream(imge1);
                    pictureBox1.Image = Image.FromStream(ms1);

                    byte[] imge2 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][18];
                    MemoryStream ms2 = new MemoryStream(imge2);
                    pictureBox2.Image = Image.FromStream(ms2);

                    byte[] imge3 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][19];
                    MemoryStream ms3 = new MemoryStream(imge3);
                    pictureBox3.Image = Image.FromStream(ms3);

                    byte[] imge4 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][20];
                    MemoryStream ms4 = new MemoryStream(imge4);
                    pictureBox4.Image = Image.FromStream(ms4);

                    byte[] imge5 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][21];
                    MemoryStream ms5 = new MemoryStream(imge5);
                    pictureBox5.Image = Image.FromStream(ms5);

                    byte[] imge6 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][22];
                    MemoryStream ms6 = new MemoryStream(imge6);
                    pictureBox6.Image = Image.FromStream(ms6);

                    byte[] imge7 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][23];
                    MemoryStream ms7 = new MemoryStream(imge7);
                    pictureBox7.Image = Image.FromStream(ms7);

                    byte[] imge8 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][24];
                    MemoryStream ms8 = new MemoryStream(imge8);
                    pictureBox8.Image = Image.FromStream(ms8);

                    byte[] imge9 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][25];
                    MemoryStream ms9 = new MemoryStream(imge9);
                    pictureBox9.Image = Image.FromStream(ms9);

                    byte[] imge10 = (byte[])this.mEDICAL_CLINIC_DBDataSet.GET_IMG_PER_CODE.Rows[0][26];
                    MemoryStream ms10 = new MemoryStream(imge10);
                    pictureBox10.Image = Image.FromStream(ms10);
                }
                else
                {
                    MessageBox.Show("لايوجد ملفات لهذا المريض");
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {
                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    MemoryStream ms2 = new MemoryStream();
                    pictureBox2.Image.Save(ms2, pictureBox2.Image.RawFormat);
                    imge2 = ms2.ToArray();
                    MemoryStream ms3 = new MemoryStream();
                    pictureBox3.Image.Save(ms3, pictureBox3.Image.RawFormat);
                    imge3 = ms3.ToArray();
                    MemoryStream ms4 = new MemoryStream();
                    pictureBox4.Image.Save(ms4, pictureBox4.Image.RawFormat);
                    imge4 = ms4.ToArray();
                    MemoryStream ms5 = new MemoryStream();
                    pictureBox5.Image.Save(ms5, pictureBox5.Image.RawFormat);
                    imge5 = ms5.ToArray();
                    MemoryStream ms6 = new MemoryStream();
                    pictureBox6.Image.Save(ms6, pictureBox6.Image.RawFormat);
                    imge6 = ms6.ToArray();
                    MemoryStream ms7 = new MemoryStream();
                    pictureBox7.Image.Save(ms7, pictureBox7.Image.RawFormat);
                    imge7 = ms7.ToArray();
                    MemoryStream ms8 = new MemoryStream();
                    pictureBox8.Image.Save(ms8, pictureBox8.Image.RawFormat);
                    imge8 = ms8.ToArray();
                    MemoryStream ms9 = new MemoryStream();
                    pictureBox9.Image.Save(ms9, pictureBox9.Image.RawFormat);
                    imge9 = ms9.ToArray();
                    MemoryStream ms10 = new MemoryStream();
                    pictureBox10.Image.Save(ms10, pictureBox10.Image.RawFormat);
                    imge10 = ms10.ToArray();
                    var INSERTED_IMGE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED_IMGE.P_INSERT_T_IMAG_PERS(
                        Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                        , textBox1.Text
                        , textBox2.Text
                        , textBox3.Text
                        , textBox4.Text
                        , textBox5.Text
                        , textBox6.Text
                        , textBox7.Text
                        , textBox8.Text
                        , textBox9.Text
                        , textBox10.Text
                        , imge1
                        , imge2
                        , imge3
                        , imge4
                        , imge5
                        , imge6
                        , imge7
                        , imge8
                        , imge9
                        , imge10
                        , ref  CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);

                        pictureBox1.Image = Properties.Resources.test;
                        pictureBox2.Image = Properties.Resources.test;
                        pictureBox3.Image = Properties.Resources.test;
                        pictureBox4.Image = Properties.Resources.test;
                        pictureBox5.Image = Properties.Resources.test;
                        pictureBox6.Image = Properties.Resources.test;
                        pictureBox7.Image = Properties.Resources.test;
                        pictureBox8.Image = Properties.Resources.test;
                        pictureBox9.Image = Properties.Resources.test;
                        pictureBox10.Image = Properties.Resources.test;



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
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {
                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    MemoryStream ms2 = new MemoryStream();
                    pictureBox2.Image.Save(ms2, pictureBox2.Image.RawFormat);
                    imge2 = ms2.ToArray();
                    MemoryStream ms3 = new MemoryStream();
                    pictureBox3.Image.Save(ms3, pictureBox3.Image.RawFormat);
                    imge3 = ms3.ToArray();
                    MemoryStream ms4 = new MemoryStream();
                    pictureBox4.Image.Save(ms4, pictureBox4.Image.RawFormat);
                    imge4 = ms4.ToArray();
                    MemoryStream ms5 = new MemoryStream();
                    pictureBox5.Image.Save(ms5, pictureBox5.Image.RawFormat);
                    imge5 = ms5.ToArray();
                    MemoryStream ms6 = new MemoryStream();
                    pictureBox6.Image.Save(ms6, pictureBox6.Image.RawFormat);
                    imge6 = ms6.ToArray();
                    MemoryStream ms7 = new MemoryStream();
                    pictureBox7.Image.Save(ms7, pictureBox7.Image.RawFormat);
                    imge7 = ms7.ToArray();
                    MemoryStream ms8 = new MemoryStream();
                    pictureBox8.Image.Save(ms8, pictureBox8.Image.RawFormat);
                    imge8 = ms8.ToArray();
                    MemoryStream ms9 = new MemoryStream();
                    pictureBox9.Image.Save(ms9, pictureBox9.Image.RawFormat);
                    imge9 = ms9.ToArray();
                    MemoryStream ms10 = new MemoryStream();
                    pictureBox10.Image.Save(ms10, pictureBox10.Image.RawFormat);
                    imge10 = ms10.ToArray();
                    var INSERTED_IMGE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED_IMGE.P_UPDATE_T_IMAG_PERS(Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                        , textBox1.Text
                        , textBox2.Text
                        , textBox3.Text
                        , textBox4.Text
                        , textBox5.Text
                        , textBox6.Text
                        , textBox7.Text
                        , textBox8.Text
                        , textBox9.Text
                        , textBox10.Text
                        , imge1
                        , imge2
                        , imge3
                        , imge4
                        , imge5
                        , imge6
                        , imge7
                        , imge8
                        , imge9
                        , imge10
                        , ref  CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);

                        pictureBox1.Image = Properties.Resources.test;
                        pictureBox2.Image = Properties.Resources.test;
                        pictureBox3.Image = Properties.Resources.test;
                        pictureBox4.Image = Properties.Resources.test;
                        pictureBox5.Image = Properties.Resources.test;
                        pictureBox7.Image = Properties.Resources.test;
                        pictureBox9.Image = Properties.Resources.test;
                        pictureBox10.Image = Properties.Resources.test;
                        pictureBox8.Image = Properties.Resources.test;
                        pictureBox6.Image = Properties.Resources.test;

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

      
    }
}
