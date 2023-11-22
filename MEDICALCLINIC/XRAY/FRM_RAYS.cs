
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.XRAY
{
    public partial class FRM_RAYS : MEDICALCLINIC.XRAY.basexray
    {
        int    FLAG_PAY = 0;
        List<string> tooth;
        byte[] imge1;
        //byte[] imge2;
        //byte[] imge3;
        //byte[] imge4;
        int id_res_de, id_res,ID_BOOK_RES=0;
        decimal TOTALPRICE, INCREMENTPRICE, DECREMENTPRICE;
        int FLAGR_EMPTY = -1;
        public FRM_RAYS()
        {
            InitializeComponent();
        }

       

        private void FRM_TESTLAB_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            dateTimePicker1.Value = System.DateTime.Now;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
            this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG' table. You can move, or remove it, as needed.
            this.v_GET_A_L_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG);
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), "", new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System.DateTime.Now, typeof(System.DateTime))))));
            tooth = new List<string>();

            DataTable dt = new DataTable();
            dt = this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON;
            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasource.Add(dt.Rows[i][1].ToString());
            }
            this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
            this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

        

        private void PIC_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gET_LAB_TEST_BY_CATEGDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count > 0)
            {
                if (FLAGR_EMPTY == 1)
                {
                    if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == null || gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == DBNull.Value || (String.IsNullOrWhiteSpace(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString())))

                    {
                        INCREMENTPRICE = 0;
                    }
                    else
                    {
                        INCREMENTPRICE = Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value);
                        LBL_TOTAL_PRICE.Text = (Convert.ToDecimal(LBL_TOTAL_PRICE.Text) + Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value)).ToString();

                    }


                }
                else
                if (FLAGR_EMPTY == 2)
                {
                    if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == null || gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == DBNull.Value || (String.IsNullOrWhiteSpace(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString())))
                    {
                        LBL_TOTAL_PRICE.Text = (Convert.ToDecimal(LBL_TOTAL_PRICE.Text) - Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value)).ToString();

                    }

                }


            }
        }

        private void pERSON_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //////////////////////
            ///
            try {
                if (pERSON_NAMEComboBox.SelectedIndex != -1 )
                {
                this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), "", new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System.DateTime.Now, typeof(System.DateTime))))));

                    if (   pERSON_NAMEComboBox.Text != "Lab.Cash.Customer")
                    {
                      TXT_PATIENT.Text = pERSON_NAMEComboBox.Text;
                    }
                    else
                    {
                        TXT_PATIENT.Text = "";
                        TXT_PATIENT.Focus();
                    }
                   
                }
           
        }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
}

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dOCTOR_NAMEComboBox.Text != "Dr.Lab.cash")
            {
               
                TXT_DOCTOR.Text = dOCTOR_NAMEComboBox.Text;
            }
            else
            {
                TXT_DOCTOR.Text = "";
                TXT_DOCTOR.Focus();
            }

        }



       


        private void gET_LAB_TEST_BY_CATEGDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int col = gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell.ColumnIndex;
                int row = gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell.RowIndex;

                if (col < gET_LAB_TEST_BY_CATEGDataGridView.ColumnCount - 1)
                {
                    col++;
                }
                else
                {
                    col = 0;
                    row++;
                    gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell = gET_LAB_TEST_BY_CATEGDataGridView.Rows[row].Cells[4];

                }

                //if (row == gET_LAB_TEST_BY_CATEGDataGridView.RowCount)
                //  dataGridView1.Rows.Add();

                gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell = gET_LAB_TEST_BY_CATEGDataGridView[col, row];
                e.Handled = true;

                gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Selected = true;
                gET_LAB_TEST_BY_CATEGDataGridView.BeginEdit(true);

            }
        }

       

        private void PIC1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
           // ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP;*.Raw,*.tif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                PIC1.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void PIC_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
           // ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP;*.Raw,*.tif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                PIC2.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void PIC3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
           // ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP;*.Raw,*.tif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                PIC3.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void PIC4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
           // ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP;*.Raw,*.tif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                PIC4.Image = Image.FromFile(ofd1.FileName);
            }
        }

      

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {

 //DataGridViewRow row = (DataGridViewRow)dataGridView1.CurrentRow.Clone();
               
            //row.Cells["Column2"].Value = "XYZ";
            //row.Cells["Column6"].Value = 50.2;
            if ( gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count > 0)
                {
                    
                        MessageBox.Show("هناك قيد موجود حاليا");
                        return;
                    
                    
 }
                else
                {

                    gET_LAB_TEST_BY_CATEGDataGridView.Rows.Add(
                                      dataGridView1.CurrentRow.Cells[16].Value.ToString(),
                                      dataGridView1.CurrentRow.Cells[21].Value.ToString(),
                                      dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                                      dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                                      dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                                      dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                                      dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                                      dataGridView1.CurrentRow.Cells[5].Value.ToString(),
                                      dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                                      dataGridView1.CurrentRow.Cells[9].Value.ToString());
                        ID_BOOK_RES = dataGridView1.CurrentRow.Cells[16].Value.ToInt();

                     pERSON_NAMEComboBox.SelectedValue=Convert.ToInt32(dataGridView1.CurrentRow.Cells[20].Value );
                    dOCTOR_NAMEComboBox.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[18].Value);
                    dOCTOR_NAMEComboBox_SelectedIndexChanged(null, null);
                    pERSON_NAMEComboBox_SelectedIndexChanged(null, null);
                    dataGridView1.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
                    //TXT_PAID.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                }
                    
               
                    
                   
               
            }
           
        }

        private void gET_LAB_TEST_BY_CATEGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            if (e.ColumnIndex == 10)
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    gET_LAB_TEST_BY_CATEGDataGridView.Rows.RemoveAt(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Index);
                   
                }
            }
        }

        private void BTN_CASH_Click(object sender, EventArgs e)
        {
            foreach (var x in tooth)
            {
                var controls = tableLayoutPanel13.Controls.Find(x, false);
                if (controls.Length > 0)
                    controls[0].BackColor = Color.SteelBlue;
            }
            tooth.Clear();

            if (tooth.Any(s => s == ((Control)sender).Name))
            {
                ((Control)sender).BackColor = Color.SteelBlue;
                tooth.Remove(((Control)sender).Name);
                //TOOTHNAMEE.Text = "X";
            }
            else
            {
                tooth.Add(((Control)sender).Name);
                // TOOTHNAMEE.Text = ((Control)sender).Name;

                ((Control)sender).BackColor = Color.Red;
                if (((Control)sender).Name == "BTN_CASH")
                {
                    FLAG_PAY = 1;

                }
                else
                if (((Control)sender).Name == "BTN_NO_CASH")
                {
                    FLAG_PAY = 2;

                }
                else
                if (((Control)sender).Name == "BTN_PARTIAL_CASH")
                {
                    FLAG_PAY = 3;

                }
            }
        }

        private void BTN_NO_CASH_Click(object sender, EventArgs e)
        {
            foreach (var x in tooth)
            {
                var controls = tableLayoutPanel13.Controls.Find(x, false);
                if (controls.Length > 0)
                    controls[0].BackColor = Color.SteelBlue;
            }
            tooth.Clear();

            if (tooth.Any(s => s == ((Control)sender).Name))
            {
                ((Control)sender).BackColor = Color.SteelBlue;
                tooth.Remove(((Control)sender).Name);
                //TOOTHNAMEE.Text = "X";
            }
            else
            {
                tooth.Add(((Control)sender).Name);
                // TOOTHNAMEE.Text = ((Control)sender).Name;

                ((Control)sender).BackColor = Color.Red;
                if (((Control)sender).Name == "BTN_CASH")
                {
                    FLAG_PAY = 1;

                }
                else
                if (((Control)sender).Name == "BTN_NO_CASH")
                {
                    FLAG_PAY = 2;

                }
                else
                if (((Control)sender).Name == "BTN_PARTIAL_CASH")
                {
                    FLAG_PAY = 3;

                }
            }
        }

        private void BTN_PARTIAL_CASH_Click(object sender, EventArgs e)
        {
            foreach (var x in tooth)
            {
                var controls = tableLayoutPanel13.Controls.Find(x, false);
                if (controls.Length > 0)
                    controls[0].BackColor = Color.SteelBlue;
            }
            tooth.Clear();

            if (tooth.Any(s => s == ((Control)sender).Name))
            {
                ((Control)sender).BackColor = Color.SteelBlue;
                tooth.Remove(((Control)sender).Name);
                //TOOTHNAMEE.Text = "X";
            }
            else
            {
                tooth.Add(((Control)sender).Name);
                // TOOTHNAMEE.Text = ((Control)sender).Name;

                ((Control)sender).BackColor = Color.Red;
                if (((Control)sender).Name == "BTN_CASH")
                {
                    FLAG_PAY = 1;

                }
                else
                if (((Control)sender).Name == "BTN_NO_CASH")
                {
                    FLAG_PAY = 2;

                }
                else
                if (((Control)sender).Name == "BTN_PARTIAL_CASH")
                {
                    FLAG_PAY = 3;

                }
            }
        }

        
        private void TXT_PAID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                
                this.TXT_PAID.Text = Convert.ToDecimal(this.TXT_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PAID.SelectionStart = TXT_PAID.TextLength;
                LBL_REMAIN.Text = (Convert.ToDecimal(LBL_TOTAL_PRICE.Text) - Convert.ToDecimal(TXT_PAID.Text)).ToString();

             
            }
            catch
            {
                return;
            }
        }
        DataTable DT = new DataTable();
        void FILL_MENU()
        {
            try
            {
                int i;
                flowLayoutPanel1.Controls.Clear();
                this.gET_T_IMG_RAISTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_IMG_RAIS, new System.Nullable<int>(((int)(System.Convert.ChangeType(ID_BOOK_RES, typeof(int))))));

                DT = this.mEDICAL_CLINIC_DBDataSet.GET_T_IMG_RAIS;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    //CLS.DESC_CODE = DT.Rows[i][3].ToString();
                    //CLS.DESC_NAME = DT.Rows[i][1].ToString();

                    byte[] imge1 = (byte[])DT.Rows[i][2];
                    MemoryStream ms1 = new MemoryStream(imge1);

                    PictureBox BTN_MENU = new PictureBox();
                    BTN_MENU.Click += Click_MENU_ME;
                    BTN_MENU.BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)14.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.Yellow;
                    BTN_MENU.Size = new System.Drawing.Size(flowLayoutPanel1.Height - 20, Convert.ToInt32(DT.Rows.Count) > 1 ? flowLayoutPanel1.Width / DT.Rows.Count : flowLayoutPanel1.Width / 2);
                    BTN_MENU.BorderStyle = BorderStyle.FixedSingle;
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Image = Image.FromStream(ms1);
                    BTN_MENU.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel1.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception)
            {

                //  MessageBox.Show(EX.Message);

            }


        }
        Image imgOriginal;
        Bitmap bm;
        Size bm_size;
        int zommm;
        int limit;
        PictureBox org;
        private void Click_MENU_ME(object Sender, EventArgs e)
        {

            try
            {

                PictureBox BTN_MENU_CLICK = default(PictureBox);
                BTN_MENU_CLICK = (PictureBox)Sender;
                // ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DESC.Text += BTN_MENU_CLICK.Text + "\r\n";
                pictureBox3.Image = BTN_MENU_CLICK.Image;
                imgOriginal = pictureBox3.Image;
                org = new PictureBox();
                org.Image = pictureBox3.Image;

                bm = new Bitmap(pictureBox3.Image);
                bm_size = bm.Size;
                zommm = 1;
                limit = 128;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            // ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP;*.Raw,*.tif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void BTN_BROWS_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            // ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP;*.Raw,*.tif";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(ofd1.FileName);
                org = new PictureBox();
                org.Image = pictureBox3.Image;

                bm = new Bitmap(pictureBox3.Image);
                bm_size = bm.Size;
                zommm = 1;
                limit = 128;
            }
        }

        private void LBL_TOTAL_PRICE_TextChanged(object sender, EventArgs e)
        {
            try
            {


                this.LBL_TOTAL_PRICE.Text = Convert.ToDecimal(this.LBL_TOTAL_PRICE.Text).ToString("N0", new CultureInfo("en-US"));
                this.LBL_TOTAL_PRICE.SelectionStart = LBL_TOTAL_PRICE.TextLength;
 

            }
            catch
            {
                return;
            }
        }

        private void BTN_RR_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = RotateImage(pictureBox3.Image, 90);
            //pictureBox3.Image = bm;
        }

        private void BTN_RL_Click(object sender, EventArgs e)
        {
            // pictureBox3.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            ///* pictureBox3.Image*/ = bm;
         pictureBox3.Image=   RotateImage(pictureBox3.Image, -90);
        }
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
        private void BT_NEWSAVE_Click(object sender, EventArgs e)
        {
            var INSERTEDP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            MemoryStream ms1 = new MemoryStream();
            pictureBox3.Image.Save(ms1, pictureBox3.Image.RawFormat);
            imge1 = ms1.ToArray();
            INSERTEDP.P_INSERT_IMG_RAIS(ID_BOOK_RES, imge1, ref CLS.SUBMIT_FLAG);
           
            pictureBox3.Image = null;
            FILL_MENU();
            MessageBox.Show("تم الحفظ بنجاح");
            //CHAT.FRM_SCANNER frm = new CHAT.FRM_SCANNER(ID_MAIN_BOOK,2);
            //frm.ShowDialog();
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.gET_T_IMG_RAISTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_IMG_RAIS, new System.Nullable<int>(((int)(System.Convert.ChangeType(, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void TXT_PAID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
                //MessageBox.Show("عذرا قم بادخال ارقام صحيحة او عشرية فقط");
            }
        }

        

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (FLAG_PAY == 0)
                {
                    MessageBox.Show("يرجى تحديد نوع الدفع!");
                    return;
                }
                if (TXT_PAID.Text == string.Empty || TXT_PAID.Text == "")
                {
                    MessageBox.Show("يرجى ادخال المبلغ الواصل اولا", CLS.TITEL_MESG);
                    return;
                }
                if (LBL_TOTAL_PRICE.Text == string.Empty || LBL_TOTAL_PRICE.Text == "")
                {
                    MessageBox.Show("يرجى ادخال المبلغ الكلي اولا", CLS.TITEL_MESG);
                    return;
                }
                if (TXT_DOCTOR.Text ==string.Empty ||TXT_DOCTOR.Text=="")
                {
                    MessageBox.Show("يرجى ادخال أسم الدكتور اولا", CLS.TITEL_MESG);
                    return;
                }
                if (TXT_PATIENT.Text == string.Empty || TXT_PATIENT.Text == "")
                {
                    MessageBox.Show("يرجى ادخال أسم المراجع اولا", CLS.TITEL_MESG);
                    return;
                }
                CLS.CLIENT_CODE_DR_XRY = dOCTOR_NAMEComboBox.SelectedValue.ToInt();
                CLS.CLIENT_CODE_PER_XRY = pERSON_NAMEComboBox.SelectedValue.ToInt();
               
                if (gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count < 1)
                {
                    MessageBox.Show("يرجى أختيار تحليل اولا", CLS.TITEL_MESG);
                    return;
                }

                var INSERTED_D = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();


                //MemoryStream ms1 = new MemoryStream();
                //MemoryStream ms2 = new MemoryStream();
                //MemoryStream ms3 = new MemoryStream();
                //MemoryStream ms4 = new MemoryStream();


                //if (PIC1.Image == null)
                //{
                //    imge1 = new byte[0];
                //}
                //else
                //{
                //    PIC1.Image.Save(ms1, PIC1.Image.RawFormat);
                //}
                //if (PIC2.Image == null)
                //{
                //    imge2 = new byte[0];
                //}
                //else
                //{
                //    PIC2.Image.Save(ms2, PIC2.Image.RawFormat);
                //}
                //if (PIC3.Image == null)
                //{
                //    imge3 = new byte[0];
                //}
                //else
                //{
                //    PIC3.Image.Save(ms3, PIC3.Image.RawFormat);
                //}
                //if (PIC4.Image == null)
                //{
                //    imge4 = new byte[0];
                //}
                //else
                //{
                //    PIC4.Image.Save(ms4, PIC4.Image.RawFormat);
                //}

                //imge1 = ms1.ToArray();
                //imge2 = ms2.ToArray();
                //imge3 = ms3.ToArray();
                //imge4 = ms4.ToArray();
                //byte[] M1 = imge1.Length == 0 ? null : imge1;
                //byte[] M2 = imge2.Length == 0 ? null : imge2;
                //byte[] M3 = imge3.Length == 0 ? null : imge3;
                //byte[] M4 = imge4.Length == 0 ? null : imge4;


                INSERTED.P_UPDATE_T_RESULTRAY(
                        Convert.ToInt32(gET_LAB_TEST_BY_CATEGDataGridView.Rows[0].Cells[0].Value.ToString())
                      , CLS.USER_CODE
                      , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                      , true
                      , true
                      , 0
                      , ref CLS.SUBMIT_FLAG);


                INSERTED_D.P_UPDATE_T_RESULTRAY_DETAILS(
                                  Convert.ToInt32( gET_LAB_TEST_BY_CATEGDataGridView.Rows[0].Cells[1].Value.ToString())
                                , Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.Rows[0].Cells[8].Value.ToString())
                                , gET_LAB_TEST_BY_CATEGDataGridView.Rows[0].Cells[9].Value.ToString()
                                , true
                                , null
                                , null
                                , null
                                , null
                                , ref CLS.SUBMIT_FLAG
                                 );




                if (CLS.SUBMIT_FLAG == 1)
                {
                    this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), "", new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System.DateTime.Now, typeof(System.DateTime))))));
                    gET_LAB_TEST_BY_CATEGDataGridView.Rows.Clear();
                    //PIC1.Image = null;
                    //PIC2.Image = null;
                    //PIC3.Image = null;
                    //PIC4.Image = null;


                    //--------------------
                    //----------------------------
                    try
                    {

                       
                        //int? BILL_num = -1;
                        //string SANAD_DISCRIPTION = "\\من ح/ " + pERSON_NAMEComboBox.Text + " الى ح/   العمليات";
                        //var GET_BILL_ID = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //GET_BILL_ID.P_GET_BILL_NUMBER(16, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), ref BILL_num);


                        //var INSERT_BOX = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        ////  string ServiceAccount = "", DoctorAccount = "", PatientAccount = "";
                       // decimal DoctorPrecentage = Convert.ToDecimal(0);
                       // decimal DebitPatient = 0;
                       // decimal TOTAL_PRICE = 0;
                       // decimal CreditService = 0;
                       // decimal CreditDoctor = 0;
                         
                       //TOTAL_PRICE = Convert.ToDecimal(LBL_TOTAL_PRICE.Text);
                       // DebitPatient = TOTAL_PRICE;
                       // CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                       // CreditService = TOTAL_PRICE - CreditDoctor;

                 


                        var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //  string ServiceAccount = "", DoctorAccount = "", PatientAccount = "";
                        int BookIdS;

                        decimal DoctorPrecentage = 0;
                        decimal DebitPatient = 0;
                        decimal TOTAL_PRICE = Convert.ToDecimal(LBL_TOTAL_PRICE.Text);
                        decimal CreditService = 0;
                        decimal CreditDoctor = 0;

                        if (DoctorPrecentage > 0)
                        {



                            DebitPatient = TOTAL_PRICE;
                            CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                            CreditService = TOTAL_PRICE - CreditDoctor;



                            BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                        id_res
                                      , System.DateTime.Now
                                      , "عن اجور اشعة "
                                      , 16
                                      , 0
                                      , true
                                      , CLS.USER_CODE
                                      , ref CLS.SUBMIT_FLAG
                                      , CLS.BRANCH_ID
                                      , 11
                                      ).ToString());

                            if (FLAG_PAY == 1)
                            {
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , 111
                                                , " اجور تحليل"
                                                , 0
                                                , 0
                                                , DebitPatient
                                                , 0
                                                , "من حساب الزبون الى حساب الصندوق"
                                                , 1
                                                , 1
                                                , ref CLS.SUBMIT_FLAG
                                                 );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BookIdS
                                , CLS.CLIENT_CODE_PER_XRY
                                , " اجوراشعة"
                                , 0
                                , 0
                                , 0
                                , DebitPatient
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                 (
                                   BookIdS
                                 , CLS.CLIENT_CODE_PER_XRY
                                 , " اجوراشعة"
                                 , 0
                                 , 0
                                 , DebitPatient
                                 , 0
                                 , "من حساب الزبون الى حساب الصندوق"
                                 , 1
                                 , 1
                                 , ref CLS.SUBMIT_FLAG
                                  );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                              (
                                BookIdS
                              , CLS.CLIENT_CODE_DR_XRY
                              , " اجوراشعة"
                              , 0
                              , 0
                              , 0
                              , CreditDoctor
                              , "من حساب الزبون الى حساب الدكتور"
                              , 1
                              , 1
                              , ref CLS.SUBMIT_FLAG
                               );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                 BookIdS
                               , 4008
                               , " اجوراشعة"
                               , 0
                               , 0
                               , 0
                               , CreditService
                               , "من حساب الزبون الى حساب المختبر"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );











                            }
                            if (FLAG_PAY == 2)
                            {
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , CLS.CLIENT_CODE_PER_XRY
                                                , " اجوراشعة"
                                                , 0
                                                , 0
                                                , DebitPatient
                                                , 0
                                                , "من حساب الزبون الى حساب المختبر"
                                                , 1
                                                , 1
                                                , ref CLS.SUBMIT_FLAG
                                                 );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BookIdS
                                , 4008
                                , " اجوراشعة"
                                , 0
                                , 0
                                , 0
                                , CreditService
                                , "من حساب الزبون الى حساب المختبر"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                           (
                             BookIdS
                           , CLS.CLIENT_CODE_DR_XRY
                           , " اجوراشعة"
                           , 0
                           , 0
                           , 0
                           , CreditDoctor
                           , "من حساب الزبون الى حساب الدكتور"
                           , 1
                           , 1
                           , ref CLS.SUBMIT_FLAG
                            );
                            }
                            if (FLAG_PAY == 3)
                            {
                                //جزء النقدي من الجزئي
                                DoctorPrecentage = 0;
                                TOTAL_PRICE = Convert.ToDecimal(TXT_PAID.Text);
                                DebitPatient = 0;
                                CreditService = 0;
                                CreditDoctor = 0;

                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditService = TOTAL_PRICE - CreditDoctor;

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , 111
                                                , " اجوراشعة"
                                                , 0
                                                , 0
                                                , DebitPatient
                                                , 0
                                                , "من حساب الزبون الى حساب الصندوق"
                                                , 1
                                                , 1
                                                , ref CLS.SUBMIT_FLAG
                                                 );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BookIdS
                                , CLS.CLIENT_CODE_PER_XRY
                                , " اجوراشعة"
                                , 0
                                , 0
                                , 0
                                , DebitPatient
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                 (
                                   BookIdS
                                 , CLS.CLIENT_CODE_PER_XRY
                                   , " اجوراشعة"
                                 , 0
                                 , 0
                                 , DebitPatient
                                 , 0
                                 , "من حساب الزبون الى حساب الصندوق"
                                 , 1
                                 , 1
                                 , ref CLS.SUBMIT_FLAG
                                  );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                              (
                                BookIdS
                              , CLS.CLIENT_CODE_DR_XRY
                               , " اجوراشعة"
                              , 0
                              , 0
                              , 0
                              , CreditDoctor
                              , "من حساب الزبون الى حساب الدكتور"
                              , 1
                              , 1
                              , ref CLS.SUBMIT_FLAG
                               );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                 BookIdS
                               , 4008
                               , " اجوراشعة"
                               , 0
                               , 0
                               , 0
                               , CreditService
                               , "من حساب الزبون الى حساب المختبر"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );


                                //الجزء الاجل من الجزئي


                                DoctorPrecentage = 0;
                                TOTAL_PRICE = Convert.ToDecimal(LBL_REMAIN.Text);
                                DebitPatient = 0;
                                CreditService = 0;
                                CreditDoctor = 0;

                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditService = TOTAL_PRICE - CreditDoctor;

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , CLS.CLIENT_CODE_PER_XRY
                                                , " اجوراشعة"
                                                , 0
                                                , 0
                                                , DebitPatient
                                                , 0
                                                , "من حساب الزبون الى حساب الصندوق"
                                                , 1
                                                , 1
                                                , ref CLS.SUBMIT_FLAG
                                                 );

                                //TO




                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                              (
                                BookIdS
                              , CLS.CLIENT_CODE_DR_XRY
                              , " اجوراشعة"
                              , 0
                              , 0
                              , 0
                              , CreditDoctor
                              , "من حساب الزبون الى حساب الدكتور"
                              , 1
                              , 1
                              , ref CLS.SUBMIT_FLAG
                               );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                 BookIdS
                               , 4008
                               , " اجوراشعة"
                               , 0
                               , 0
                               , 0
                               , CreditService
                               , "من حساب الزبون الى حساب المختبر"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );







                            }
                        }

                        else
                               if (DoctorPrecentage == 0)
                        {



                            BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                        id_res
                                      , System.DateTime.Now
                                      , " اجوراشعة"
                                      , 16
                                      , 0
                                      , true
                                      , CLS.USER_CODE
                                      , ref CLS.SUBMIT_FLAG
                                      , CLS.BRANCH_ID
                                      , 11
                                      ).ToString());

                            if (FLAG_PAY == 1)
                            {
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , 111
                                              , " اجوراشعة"
                                                , 0
                                                , 0
                                                , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                                                , 0
                                                , "من حساب الزبون الى حساب الصندوق"
                                                , 1
                                                , 1
                                                , ref CLS.SUBMIT_FLAG
                                                 );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BookIdS
                                , CLS.CLIENT_CODE_PER_XRY
                                 , " اجوراشعة"
                                , 0
                                , 0
                                , 0
                                , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                 (
                                   BookIdS
                                 , CLS.CLIENT_CODE_PER_XRY
                                 , " اجوراشعة"
                                 , 0
                                 , 0
                                 , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                                 , 0
                                 , "من حساب الزبون الى حساب الصندوق"
                                 , 1
                                 , 1
                                 , ref CLS.SUBMIT_FLAG
                                  );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                              (
                                BookIdS
                              , 4008
                              , " اجوراشعة"
                              , 0
                              , 0
                              , 0
                              , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                              , "من حساب الزبون الى حساب الدكتور"
                              , 1
                              , 1
                              , ref CLS.SUBMIT_FLAG
                               );



                            }
                            if (FLAG_PAY == 2)
                            {
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , CLS.CLIENT_CODE_PER_XRY
                                                , " اجوراشعة"
                                                , 0
                                                , 0
                                                , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                                                , 0
                                                , "من حساب الزبون الى حساب الصندوق"
                                                , 1
                                                , 1
                                                , ref CLS.SUBMIT_FLAG
                                                 );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                           (
                             BookIdS
                           , 4008
                           , " اجوراشعة"
                           , 0
                           , 0
                           , 0
                           , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                           , "من حساب الزبون الى حساب الدكتور"
                           , 1
                           , 1
                           , ref CLS.SUBMIT_FLAG
                            );
                            }
                            if (FLAG_PAY == 3)
                            {



                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                 (
                                   BookIdS
                                 , CLS.CLIENT_CODE_PER_XRY
                                 , " اجوراشعة"
                                 , 0
                                 , 0
                                 , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                                 , 0
                                 , "من حساب الزبون الى حساب الصندوق"
                                 , 1
                                 , 1
                                 , ref CLS.SUBMIT_FLAG
                                  );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                              (
                                BookIdS
                              , 4008
                               , " اجوراشعة"
                              , 0
                              , 0
                              , 0
                              , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                              , "من حساب الزبون الى حساب الدكتور"
                              , 1
                              , 1
                              , ref CLS.SUBMIT_FLAG
                               );





                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                               (
                                                BookIdS
                                               , 111
                                               , " اجوراشعة"
                                               , 0
                                               , 0
                                               , Convert.ToDecimal(TXT_PAID.Text)
                                               , 0
                                               , "من حساب الزبون الى حساب الصندوق"
                                               , 1
                                               , 1
                                               , ref CLS.SUBMIT_FLAG
                                                );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BookIdS
                                , 4008
                                 , " اجوراشعة"
                                , 0
                                , 0
                                , 0
                                , Convert.ToDecimal(TXT_PAID.Text)
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );






                            }
                        }

















                        if (CLS.SUBMIT_FLAG == 1)
                        {
                            MSG.Msg.Alart(AlartType.Save);
                            //TXT_PRICE_TOT.Text = "";
                            //button3.Enabled = false;
                            CLS.TIMER_BORROW = 1;

                           // ((OPERATION_PP.FRM_ALL_OPERTION_PRICE)Application.OpenForms["FRM_ALL_OPERTION_PRICE"]).p_GET_PRICE_OPERTION_BY_GRIDDataGridView.DataSource = this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PRICE_OPERTION_BY_GRID, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.DOCTOR_CODE_ADD_IMG, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(CLS.F_DATE_PRT, typeof(System.DateTime))))));

                        }
                        else
                        {

                            MSG.Msg.Alart(AlartType.Error);

                        }
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }


                    //-----------------------


                }


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        private void gET_LAB_TEST_BY_CATEGDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count > 0)
                {
                    if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == null || gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == DBNull.Value || (String.IsNullOrWhiteSpace(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString())))

                    {

                        gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell = gET_LAB_TEST_BY_CATEGDataGridView.Rows[gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Index].Cells[4];

                        FLAGR_EMPTY = 1;
                        //gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Selected = true;
                        // gET_LAB_TEST_BY_CATEGDataGridView.BeginEdit(true);
                    }
                    else
                    {
                        FLAGR_EMPTY = 2;
                        DECREMENTPRICE = Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value);

                        //if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value != null || gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString() != "")
                        //{
                        //  DataGridViewCell cellQty = gET_LAB_TEST_BY_CATEGDataGridView.Rows[gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Index].Cells[4];
                        //  gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell = cellQty;
                        gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Selected = true;
                        gET_LAB_TEST_BY_CATEGDataGridView.BeginEdit(true);

                        //}
                    }
                }
            }
            catch
            {

            }

        }


    }
}
