using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL
{

    public partial class FRM_H_GETBOOK : Form
    {
        int FLAGE_SEARCH = 0;
        int cam_flg = -1;
    private FilterInfoCollection WEBCAM;
    private VideoCaptureDevice CAM;
        byte[] imge1;
        public FRM_H_GETBOOK()
        {
            InitializeComponent();
          
        }
        void FILL_MENU()
        {
            try
            {
                int i;
                flowLayoutPanel1.Controls.Clear();
                this.v_A_H_MAINDEPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_MAINDEP);
                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.V_A_H_MAINDEP;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][1].ToString();
                    Button BTN_MENU = new Button();

                    BTN_MENU.Click += Click_MENU_ME;
                    BTN_MENU.BackColor = System.Drawing.Color.White;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.FlatAppearance.BorderSize = 3;
                    BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
                    BTN_MENU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                 

                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)22.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.Size = new System.Drawing.Size((tabControl1.Width / DT.Rows.Count) - 20, (flowLayoutPanel5.Height) - 10);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = CLS.DESC_NAME;
                    BTN_MENU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    BTN_MENU.UseVisualStyleBackColor = false;
                    flowLayoutPanel1.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }

        }



        // ADD SUB DEPARTMENT

        void FILL_SUBDEPART()
        {
            try
            {
                int i;
                flowLayoutPanel5.Controls.Clear();
                //  this.gET_H_SUBDEP_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_SUBDEP_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.H_MAINPART, typeof(int))))));
                this.gET_H_SUBDEP_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_SUBDEP_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(11, typeof(int))))));

                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_H_SUBDEP_BUTTON;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][1].ToString();
                    Button BTN_MENU = new Button();

                    BTN_MENU.Click += Click_MENU_SUBDEP;
                    BTN_MENU.BackColor = System.Drawing.Color.White;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.FlatAppearance.BorderSize = 3;
                    BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
                    BTN_MENU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                   

                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)22.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.Size = new System.Drawing.Size((flowLayoutPanel5.Width / DT.Rows.Count) - 10, (flowLayoutPanel5.Height) - 10);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = CLS.DESC_NAME;
                    BTN_MENU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    BTN_MENU.UseVisualStyleBackColor = false;
                    flowLayoutPanel5.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }

        }

        //--------


        //FLOOR

        void FILL_FLOOR()
        {
            try
            {
                int i;
                flowLayoutPanel4.Controls.Clear();
                this.gET_H_FLOOR_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_FLOOR_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(11, typeof(int))))));

                //  this.gET_H_FLOOR_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_FLOOR_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType( CLS.H_SUBDEP, typeof(int))))));
                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_H_FLOOR_BUTTON;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][1].ToString();
                    Button BTN_MENU = new Button();

                    BTN_MENU.Click += Click_MENU_FLOOR;
                    BTN_MENU.BackColor = System.Drawing.Color.White;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.FlatAppearance.BorderSize = 3;
                    BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
                    BTN_MENU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)22.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.Size = new System.Drawing.Size((tabControl1.Width / DT.Rows.Count) - 20, (flowLayoutPanel4.Height) - 10);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = CLS.DESC_NAME;
                    BTN_MENU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    BTN_MENU.UseVisualStyleBackColor = false;
                    flowLayoutPanel4.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }

        }



        //

        //ROOM

        void FILL_ROOM()
        {
            try
            {
                int i;
                flowLayoutPanel3.Controls.Clear();
                this.gET_H_ROOM_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ROOM_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.H_FLOOR, typeof(int))))));
                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_H_ROOM_BUTTON;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][1].ToString();
                    Button BTN_MENU = new Button();

                    BTN_MENU.Click += Click_MENU_ROOM;
                    BTN_MENU.BackColor = System.Drawing.Color.WhiteSmoke;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.FlatAppearance.BorderSize = 3;
                    BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
                    BTN_MENU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)22.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.Size = new System.Drawing.Size((flowLayoutPanel3.Width / DT.Rows.Count) - 10, (flowLayoutPanel3.Height) - 10);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = CLS.DESC_NAME;
                    BTN_MENU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    BTN_MENU.UseVisualStyleBackColor = false;
                    //Label LBL = new Label();
                    //LBL.Text = DT.Rows[i][0].ToString();
                    //LBL.BackColor = Color.Red;
                    //LBL.Dock = DockStyle.Bottom;
                    //BTN_MENU.Controls.Add(LBL);
                    flowLayoutPanel3.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }

        }

        //----


        //BED

        void FILL_BED()
        {
            try
            {
                int i;
                flowLayoutPanel2.Controls.Clear();
                this.gET_H_BED_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.H_ROOM, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.H_FLOOR, typeof(int))))));
                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_BUTTON;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][1].ToString();
                    Button BTN_MENU = new Button();
                    BTN_MENU.Click += Click_MENU_BED;
                    //  BTN_MENU.BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
                    BTN_MENU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.FlatAppearance.BorderSize = 3;
                    BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
                    BTN_MENU.BackColor = System.Drawing.Color.White;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)1.00, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.Black;
                    BTN_MENU.Size = new System.Drawing.Size((flowLayoutPanel2.Width / DT.Rows.Count) - 10, (flowLayoutPanel2.Height) - 10);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = CLS.DESC_NAME;
                    byte[] imge1 = (byte[])DT.Rows[i][4];
                    MemoryStream ms1 = new MemoryStream(imge1);
                    // Bitmap btm = new Bitmap(ms1); 
                   // BTN_MENU.BorderStyle = BorderStyle.FixedSingle;
                    BTN_MENU.BackgroundImageLayout = ImageLayout.Zoom;
                    BTN_MENU.BackgroundImage = Image.FromStream(ms1);
                    BTN_MENU.ImageAlign = ContentAlignment.MiddleCenter;
                    BTN_MENU.TextAlign = ContentAlignment.BottomCenter;
                   // BTN_MENU.TextImageRelation = TextImageRelation.Overlay;
                    //Label LBL = new Label();
                    //LBL.Text = DT.Rows[i][0].ToString();
                    //LBL.BackColor = Color.Red;
                    //LBL.Dock = DockStyle.Bottom;
                    //BTN_MENU.Controls.Add(LBL);
                    flowLayoutPanel2.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }
        }
            //------


           
        private void Click_MENU_ME(object Sender, EventArgs e)
        {

            try
            {
                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                CLS.H_MAINPART = Convert.ToInt32( BTN_MENU_CLICK.Name);
                
                FILL_SUBDEPART();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            //-BTN CLICK SUB DEPARTMENT

            private void Click_MENU_SUBDEP(object Sender, EventArgs e)
            {

                try
                {

                    Button BTN_MENU_CLICK = default(Button);
                    BTN_MENU_CLICK = (Button)Sender;
                   CLS.H_SUBDEP = Convert.ToInt32(BTN_MENU_CLICK.Name);
                   FILL_FLOOR();
                

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //-----
            }


        private void Click_MENU_FLOOR(object Sender, EventArgs e)
        {

            try
            {

                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                CLS.H_FLOOR = Convert.ToInt32(BTN_MENU_CLICK.Name);
                FILL_ROOM();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-----
        }
        private void Click_MENU_ROOM(object Sender, EventArgs e)
        {

            try
            {

                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                CLS.H_ROOM = Convert.ToInt32(BTN_MENU_CLICK.Name);
                FILL_BED();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-----
        }

        private void Click_MENU_BED(object Sender, EventArgs e)
        {

            try
            {

                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                // HOSPITAL.FRM_DETAIL_BOOKING frm = new FRM_DETAIL_BOOKING();
                // frm.ShowDialog();
                CLS.H_ROOM_BED =Convert.ToInt32( BTN_MENU_CLICK.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-----
        }


        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.gET_H_BED_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType( CLS.H_ROOM, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType( CLS.H_FLOOR, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void FRM_H_GETBOOK_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR' table. You can move, or remove it, as needed.
            this.v_A_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_H_GET_CONVERTED_TYPE' table. You can move, or remove it, as needed.
            this.v_H_GET_CONVERTED_TYPETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_H_GET_CONVERTED_TYPE);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_EMP_ACCOUNT' table. You can move, or remove it, as needed.
            this.v_GET_EMP_ACCOUNTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_EMP_ACCOUNT);


            try
            {
                var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            this.v_A_H_MAINDEPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_MAINDEP);
          

            this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE,1);

          
            this.v_A_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR);
            this.v_GET_EMP_LEGALMANTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_EMP_LEGALMAN);
              this.v_GET_EMP_NURSETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_EMP_NURSE);
            //DATE_FROM.Value = System.DateTime.Now;
            //DATE_TO.Value = System.DateTime.Now;

            this.gET_DOCTOR_BY_GROUP3TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP3, new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
            this.gET_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            this.gET_DOCTOR_BY_GROUP2TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP2, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));




            this.t_SEX_STATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.T_SEX_STATE);
            this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
           
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);

          
         

            dOCTOR_NAMECOM.SelectedIndex = -1;
            dOCTOR_NAMEComboBox1.SelectedIndex = -1;
            cONV_SIDEComboBox.SelectedIndex = -1;
            ACCOUNTANT_ComboBox2.SelectedIndex = -1;
            dISEASE_NAMEComboBox.SelectedIndex = -1;
            COMB_TAKDEER.SelectedIndex = -1;
            pERSON_NAMEComboBox.SelectedIndex = -1;
            bOOK_NAMEComboBox.SelectedIndex = -1;
            SEX_COMB.SelectedIndex = -1;

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



           

                WEBCAM = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                foreach (FilterInfo VideoCaptureDevice in WEBCAM)
                {
                    COM_CAMLIST.Items.Add(VideoCaptureDevice.Name);
                }
                COM_CAMLIST.SelectedIndex = 0;

            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
           
            
            FILL_MENU();
            FILL_SUBDEPART();
            FILL_FLOOR();
           FILL_floor();

            }

        private void pic_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
        //     public static int H_MAINPART = 0;
        //public static int H_SUBDEP = 0;
        //public static int H_FLOOR = 0;
        //public static int H_ROOM = 0;
        //public static int H_ROOM_BED = 0;
                //if (CLS.H_MAINPART == 0)
                //{
                //    MessageBox.Show("رجاءاً حددالقسم الرئيس اولا", CLS.TITEL_MESG);
                //    return;
                //}
                //if (CLS.H_SUBDEP == 0)
                //{
                //    MessageBox.Show("رجاءاً حددالقسم الفرعي اولا", CLS.TITEL_MESG);
                //    return;
                //}
                if (CLS.H_FLOOR == 0)
                {
                    MessageBox.Show("رجاءاً حددالطابق اولا", CLS.TITEL_MESG);
                    return;
                }
                if (CLS.H_ROOM == 0)
                {
                    MessageBox.Show("رجاءاً حددالغرفة اولا", CLS.TITEL_MESG);
                    return;
                }
                if (CLS.H_ROOM_BED == 0)
                {
                    MessageBox.Show("رجاءاً حددالسرير اولا", CLS.TITEL_MESG);
                    return;
                }
                if (dOCTOR_NAMECOM.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد الطبيب اولا", CLS.TITEL_MESG);
                    return;
                }
                if (pERSON_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد المريض اولا", CLS.TITEL_MESG);
                    return;
                }
                if (TXT_PRICE.Text == "")
                {
                    MessageBox.Show("رجاءاً حدد مبلغ العملية اولا", CLS.TITEL_MESG);
                    return;
                }
                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                //   INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);
                CLS.H_MAINPART = 1;
                CLS.H_SUBDEP = 11;

                int BookId;
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                if (1 == 1)//if (CLS.SUBMIT_IS_BOOK == 1)
                {
                    BookId = int.Parse(
                      INSERTED.P_INSERT_T_H_BOOKING(
                    
                      Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                    , Convert.ToInt32(dOCTOR_NAMECOM.SelectedValue)
                    , Convert.ToInt32(dOCTOR_NAMEComboBox1.SelectedValue)
                    , Convert.ToInt32(0)
                    , CLS.H_SUBDEP
                    , CLS.H_FLOOR
                    , CLS.H_ROOM
                    , CLS.H_ROOM_BED
                    , DATE_FROM.Value
                    , DATE_TO.Value
                    , Convert.ToInt32(bOOK_NAMEComboBox.SelectedValue) 
                    ,Convert.ToInt32(dISEASE_NAMEComboBox.SelectedValue)  
                    , ""
                    , 0
                    , Convert.ToInt32(cONV_SIDEComboBox.SelectedValue)
                    , 0
                    , CLS.USER_CODE
                    
                    ,Convert.ToDecimal(TXT_PRICE.Text)
                    ,false
                    , Convert.ToInt32(COMB_TAKDEER.SelectedValue)
                    , Convert.ToInt32(ACCOUNTANT_ComboBox2.SelectedValue)
                    , 0
                    
                    , ref CLS.SUBMIT_FLAG).ToString());

                    if (Convert.ToString(BookId) == String.Empty)
                    {
                        return;
                    }
                    else
                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        var INSERTEDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                        //INSERTEDT.P_INSERT_T_H_OPERATION_PROCED(
                        // 0
                        // , BookId
                        // , ""
                        // , ""
                        // , ""
                        // , 0
                        // , 0
                        // , false
                        // , ""
                        // , ""
                        // , ""
                        // , Convert.ToInt32(dOCTOR_NAMEComboBox1.SelectedValue)
                        // , Convert.ToInt32(0)
                        // , Convert.ToInt32(0)
                        // , Convert.ToInt32(COMB_TAKDEER.SelectedValue)
                        // , Convert.ToInt32(0)
                        // , Convert.ToInt32(0)
                        // , CLS.USER_CODE
                        // , Convert.ToDecimal(TXT_PRICE.Text)
                        // ,ref CLS.SUBMIT_FLAG
                        // ,""
                        // , ref CLS.SUBMIT_FLAG

                        //      );

                        try
                        {
                            Cursor.Current = Cursors.WaitCursor;
                           // CLS.ID_BOOK_PRINT = Convert.ToInt32(TXT_ID_BOOK.Text);
                           
                            if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                            {
                                MessageBox.Show("حدد الطابعة أولا");
                                SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                                FRM.ShowDialog();
                                return;

                            }
                          //  BTN_SAVEE_Click(null, null);

                          // HOSPITAL.PRINT.FRM_PRINT_PERSONINF myfrrm = new HOSPITAL.PRINT.FRM_PRINT_PERSONINF();
                          //  HOSPITAL.PRINT.RPT_PERSON_BOOK mmprt = new HOSPITAL.PRINT.RPT_PERSON_BOOK();
                          //  PrinterSettings settings = new PrinterSettings();
                          //  SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString);
                          //  string ServerName = SqlConnectionStringBuilder.DataSource;
                          //  string DatabaseName = SqlConnectionStringBuilder.InitialCatalog;
                          //  Boolean IntegratedSecurity = SqlConnectionStringBuilder.IntegratedSecurity;
                          //  string UserID = SqlConnectionStringBuilder.UserID;
                          //  string Password = SqlConnectionStringBuilder.Password;

                          //  foreach (CrystalDecisions.CrystalReports.Engine.Table Table in mmprt.Database.Tables)
                          //  {
                          //      CrystalDecisions.Shared.TableLogOnInfo TableLogOnInfo = Table.LogOnInfo;
                          //      TableLogOnInfo.ConnectionInfo.ServerName = ServerName;
                          //      TableLogOnInfo.ConnectionInfo.DatabaseName = DatabaseName;
                          //      TableLogOnInfo.ConnectionInfo.IntegratedSecurity = IntegratedSecurity;

                          //      if (IntegratedSecurity != true)
                          //      {
                          //          TableLogOnInfo.ConnectionInfo.UserID = UserID;
                          //          TableLogOnInfo.ConnectionInfo.Password = Password;
                          //      }
                          //      Table.ApplyLogOnInfo(TableLogOnInfo);
                          //  }
                          ////  mmprt.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DataBase, Properties.Settings.Default.ID, Properties.Settings.Default.Password);

                          //  // mmprt.SetParameterValue("@ID_BOOK", CLS.ID_BOOK_PRINT);
                          //  // mmprt.SetParameterValue("@DOCT_CODE", CLS.USER_CODE);
                          //  mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                          //  DataTable DTDATA = new DataTable();
                          //  DataTable DTHDR = new DataTable();
                          //  DataTable DTFTR = new DataTable();
                          //  DataTable DTBDY = new DataTable();
                          //  DataTable DTLGO = new DataTable();
                          //  this.gET_IMG_HEADER_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_HEADER_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                          //  this.gET_IMG_FOOTER_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_FOOTER_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                          //  this.gET_IMG_BODY_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_BODY_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                          //  this.gET_IMG_LOGO_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_LOGO_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                          //  this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(BookId, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                          //  DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID;
                          //  this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE,1);
                          //  DTHDR = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                          // //lصدر بيانات الصورة
                          //  mmprt.Subreports[0].SetDataSource(DTHDR);//lصدر بيانات الجدول الاخر
                          //  mmprt.SetDataSource(DTDATA);
                          //  myfrrm.crystalReportViewer1.ReportSource = mmprt;
                          //  myfrrm.ShowDialog();
                          //  mmprt.PrintToPrinter(1, false, 0, 0);
                            Cursor.Current = Cursors.Default;

                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }

                        this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), DATE_FROM.Value, DATE_TO.Value);
                        FILL_BEDTOCHECK();
                       
                        MSG.Msg.Alart(AlartType.Save);
                   
                        dOCTOR_NAMECOM.SelectedIndex = -1;
                    
                    }
                   
                }
                else
                {
                    MessageBox.Show("تم الحجز مسبقا لهذا المراجع", CLS.TITEL_MESG);
                    return;
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
                //return;
            }
        }

      
        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            try
            {

                if (PERSON_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                    return;
                }

 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (PERSON_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(PERSON_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();




                    INSERTED.P_INSERT_T_PERSON

                        (
                        CLS.CHEECK_CODE
                        , ref CLS.CLIENT_CODE
                        , PERSON_NAME_ARTextBoxX.Text
                        , Convert.ToInt32(0)
                        , Convert.ToInt32(SEX_COMB.SelectedValue)
                        , AGE_TextBoxX.Text
                        , TXT_PHONE.Text
                        , TXT_ADDRESS.Text
                        , imge1
                        , TXT_NOTE.Text
                         ,""
                         ,TXT_JOB.Text
                         ,TXT_ID_NUM.Text
                         ,TXT_ID_REC.Text
                         ,TXT_ID_PAGE.Text
                         ,TXT_ID_NUMF.Text
                         ,TXT_ID_RECF.Text
                        , TXT_ID_PAGEF.Text
                        ,0
                        ,TXT_FATHER.Text
                        , true
                        , ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        // MSG.Msg.Alart(AlartType.Save);
                        PERSON_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                        // this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                        //  dOCTOR_NAMEComboBox.SelectedIndex = -1;
                        SEX_COMB.SelectedIndex = -1;
                        FRM_H_GETBOOK_Load_1(null, null);
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
                if (PERSON_CODETextBoxX.Text == "")
                {

                    errorProvider1.SetError(PERSON_CODETextBoxX, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {
                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_UPDATE_T_PERSON(
                    Convert.ToInt32(PERSON_CODETextBoxX.Text)
                    , PERSON_NAME_ARTextBoxX.Text
                    , Convert.ToInt32(dOCTOR_NAMECOM.SelectedValue)
                    , Convert.ToInt32(SEX_COMB.SelectedValue)
                    , AGE_TextBoxX.Text, TXT_PHONE.Text
                    , TXT_ADDRESS.Text, imge1
                    , TXT_NOTE.Text
                    , TXT_JOB.Text
                    , TXT_ID_NUM.Text
                    , TXT_ID_REC.Text
                    , TXT_ID_PAGE.Text
                    , TXT_ID_NUMF.Text
                    , TXT_ID_RECF.Text
                    , TXT_ID_PAGEF.Text
                    , 0
                    , TXT_FATHER.Text
                    , true
                    , ref CLS.SUBMIT_FLAG);

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

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (PERSON_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
 MSG.Msg.Alart(AlartType.Error);
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_DELETE_T_PERSON(Convert.ToInt32(PERSON_CODETextBoxX.Text), Convert.ToInt32(dOCTOR_NAMECOM.SelectedValue), ref CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        PERSON_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
          PERSONS.  FRM_SEARCH_PERSON FRM = new PERSONS. FRM_SEARCH_PERSON(1);
            FRM.ShowDialog();
        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void cleartextbox(Control root)
        {
            foreach (Control ct in root.Controls)
            {
                if (ct is TextBox)
                    ((TextBox)ct).Clear();

                //' افراغ لتيكست بوكس 
            }
        }
        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            cleartextbox(tableLayoutPanel14);
            cleartextbox(tableLayoutPanel15);
            cleartextbox(tableLayoutPanel16);
            pictureBox1.Image = Properties.Resources.per_img;
        }
        void CAMM_NEWFRM(object sender, NewFrameEventArgs EventArgs)
        {
            Bitmap BIT = (Bitmap)EventArgs.Frame.Clone();
            pictureBox2.Image = BIT;

        }
        private void CAM_ON_Click(object sender, EventArgs e)
        {
            try
            {
                cam_flg = 1;
                CAM = new VideoCaptureDevice(WEBCAM[COM_CAMLIST.SelectedIndex].MonikerString);
                CAM.NewFrame += new NewFrameEventHandler(CAMM_NEWFRM);
                CAM.Start();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CAM_CAPTURE_Click(object sender, EventArgs e)
        {
            //try 
            //{

            ImageConverter converter = new ImageConverter();

            byte[] imge1 = (byte[])converter.ConvertTo(pictureBox2.Image, typeof(byte[]));
            MemoryStream ms1 = new MemoryStream(imge1);
            pictureBox1.Image = Image.FromStream(ms1);
            // pictureBox1.Image = pictureBox2.Image;
            //MemoryStream ms2 = new MemoryStream();
            //pictureBox1.Image.Save(ms2, pictureBox2.Image.RawFormat);

            //}

            //   catch (System.Exception ex)
            //   {
            //       System.Windows.Forms.MessageBox.Show(ex.Message);
            //   }
        }

        private void CAM_OFF_Click(object sender, EventArgs e)
        {
            try
            {

                if (cam_flg == 1)
                {
                    cam_flg = -1;
                    CAM.Stop();
                    pictureBox2.Image = null;

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_CHOOSE_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void FRM_H_GETBOOK_Shown(object sender, EventArgs e)
        {
           
           
            pERSON_NAMEComboBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FILL_MENU();
        }

        
        private void Click_MENU_FLOORALLBED(object Sender, EventArgs e)
        {

            try
            {

                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                CLS.H_FLOOR = Convert.ToInt32(BTN_MENU_CLICK.Name);
                FILL_BEDTOCHECK();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-----
        }
        

        void FILL_floor()
        {
            try
            {
                int i;
                flowLayoutPanel7.Controls.Clear();
                this.v_A_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR);
              //  this.gET_H_FLOOR_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_FLOOR_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(11, typeof(int))))));

                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][1].ToString();
                    Button BTN_MENU = new Button();
                    BTN_MENU.Click += Click_MENU_FLOORALLBED;
                    BTN_MENU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.FlatAppearance.BorderSize = 3;
                    BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
                    BTN_MENU.BackColor = System.Drawing.Color.White;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)22.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.Black;
                    BTN_MENU.Size = new System.Drawing.Size((tabControl1.Width / DT.Rows.Count) - 15, (flowLayoutPanel7.Height) - 10);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = CLS.DESC_NAME;
                   
                    flowLayoutPanel7.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }
        }

        //---------------

        //////////////////////
        ///

        void FILL_BEDTOCHECK()
        {
            try
            {
                int i;
                flowLayoutPanel8.Controls.Clear();
                this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), DATE_FROM.Value, DATE_TO.Value);

                //---

                if (FLAGE_SEARCH == 0)
                {
                    this.gET_H_ALLBED_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON, CLS.H_FLOOR.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                }
                else

                 if (FLAGE_SEARCH == 1)
                {
                    this.gET_H_ALLBED_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON, CLS.H_FLOOR.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));


                }



                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][3].ToString();
                    Button BTN_MENU = new Button();
                    BTN_MENU.Click += Click_MENU_BEDTOCHECK;
                    //  BTN_MENU.BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
                    BTN_MENU.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.FlatAppearance.BorderSize = 3;
                    BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.Size = new System.Drawing.Size(250, 150);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = "";//this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[i][1].ToString();
                    byte[] imge1 = (byte[])DT.Rows[i][6];
                    MemoryStream ms1 = new MemoryStream(imge1);

                    // BTN_MENU.BorderStyle = BorderStyle.FixedSingle;
                    BTN_MENU.BackgroundImageLayout = ImageLayout.Zoom;
                    BTN_MENU.BackgroundImage = Image.FromStream(ms1);



                    BTN_MENU.ImageAlign = ContentAlignment.MiddleCenter;
                    BTN_MENU.TextAlign = ContentAlignment.BottomCenter;
                    BTN_MENU.TextImageRelation = TextImageRelation.Overlay;


                    Label LBL = new Label();
                    Label LBLNAME = new Label();
                    for (int J = 0; J < mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows.Count; J++)
                    {
                        string B_FLOOR, B_ROOM, B_BED, F_FLOOR, F_ROOM, F_BED, comb_f = "", comb_b = "";
                        F_FLOOR = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON.Rows[i][2].ToString();
                        F_ROOM = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON.Rows[i][1].ToString();
                        F_BED = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON.Rows[i][0].ToString();

                        B_FLOOR = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][9].ToString();
                        B_ROOM = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][10].ToString();
                        B_BED = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][11].ToString();
                        comb_b = B_FLOOR + "" + B_ROOM + "" + B_BED;
                        comb_f = F_FLOOR + "" + F_ROOM + "" + F_BED;
                        if (comb_f == comb_b)
                        {
                            //int VA = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][0]);
                            //DataTable DG = new DataTable();
                            //this.gET_H_BOOK_DATE_E_LTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOK_DATE_E_L, new System.Nullable<int>(((int)(System.Convert.ChangeType(VA, typeof(int))))));
                            //DG = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOK_DATE_E_L;
                            //DateTime DN = System.DateTime.Now;
                            //DateTime DE = DateTime.Parse(DG.Rows[0][1].ToString());
                            //int FCP = int.Parse(DG.Rows[0][3].ToString());
                            //if (DE.Date < DN.Date && FCP==0)
                            //{
                            //   // MessageBox.Show("المريض الحالي انتهت فترة الحجز الخاصة بة ");

                            //    LBLNAME.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][2].ToString();
                            //    LBLNAME.BackColor = Color.Orange;
                            //    LBLNAME.Dock = DockStyle.Bottom;
                            //    LBLNAME.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                            //    BTN_MENU.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][0].ToString();
                            //    LBLNAME.ForeColor = System.Drawing.Color.Yellow;
                            //    LBLNAME.TextAlign = ContentAlignment.MiddleCenter;
                            //    BTN_MENU.Controls.Add(LBLNAME);

                            //    LBL.Text = DT.Rows[i][5].ToString() + "-" + DT.Rows[i][4].ToString() + "-" + DT.Rows[i][3].ToString();
                            //    LBL.BackColor = Color.Orange;
                            //    BTN_MENU.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);

                            //    LBL.Dock = DockStyle.Top;
                            //    BTN_MENU.ForeColor = System.Drawing.Color.Yellow;
                            //    LBL.TextAlign = ContentAlignment.MiddleCenter;
                            //    BTN_MENU.Controls.Add(LBL);

                            //    break;
                            //}
                            //else{

                                LBLNAME.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][2].ToString();
                                LBLNAME.BackColor = Color.Red;
                                LBLNAME.Dock = DockStyle.Bottom;
                                LBLNAME.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                                BTN_MENU.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][0].ToString();
                                LBLNAME.ForeColor = System.Drawing.Color.Yellow;
                                LBLNAME.TextAlign = ContentAlignment.MiddleCenter;
                                BTN_MENU.Controls.Add(LBLNAME);

                                LBL.Text = DT.Rows[i][5].ToString() + "-" + DT.Rows[i][4].ToString() + "-" + DT.Rows[i][3].ToString();
                                LBL.BackColor = Color.Red;
                                BTN_MENU.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);

                                LBL.Dock = DockStyle.Top;
                                BTN_MENU.ForeColor = System.Drawing.Color.Yellow;
                                LBL.TextAlign = ContentAlignment.MiddleCenter;
                                BTN_MENU.Controls.Add(LBL);

                                break;


                          //  }

                        }

                        else
                        {

                            LBLNAME.Text = "غير محجوزه";
                            LBLNAME.BackColor = Color.WhiteSmoke;
                            LBLNAME.Dock = DockStyle.Bottom;
                            LBLNAME.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);

                            BTN_MENU.ForeColor = System.Drawing.Color.Blue;
                            LBLNAME.TextAlign = ContentAlignment.MiddleCenter;
                            BTN_MENU.Controls.Add(LBLNAME);

                            LBL.Text = DT.Rows[i][5].ToString() + "-" + DT.Rows[i][4].ToString() + "-" + DT.Rows[i][3].ToString();
                            LBL.BackColor = Color.WhiteSmoke;
                            BTN_MENU.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);

                            LBL.Dock = DockStyle.Top;
                            BTN_MENU.ForeColor = System.Drawing.Color.Black;
                            LBL.TextAlign = ContentAlignment.MiddleCenter;
                            BTN_MENU.Controls.Add(LBL);
                        }
                    }

                   
                   



                    flowLayoutPanel8.AutoScroll = true;
                    flowLayoutPanel8.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }
        }

        private void Click_MENU_BEDTOCHECK(object Sender, EventArgs e)
        {
            DataTable DD = new DataTable();
            try
            {
               // Label LBL = new Label();
                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                if (BTN_MENU_CLICK.Text != String.Empty)
                {
                    this.gET_H_BOOK_DATE_E_LTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOK_DATE_E_L, new System.Nullable<int>(((int)(System.Convert.ChangeType(BTN_MENU_CLICK.Text, typeof(int))))));
                    DD = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOK_DATE_E_L;
                    DateTime DN =  System.DateTime.Now;
                    DateTime DE = DateTime.Parse(DD.Rows[0][1].ToString());
                   int ID_OP = Convert.ToInt32( DD.Rows[0][1] );
                    if (DE.Date<DN.Date)
                    {
                        MessageBox.Show("المريض الحالي انتهت فترة الحجز الخاصة بة ");
                    }
                    HOSPITAL.FRM_DETAILS_PROCEDURE frm = new FRM_DETAILS_PROCEDURE(BTN_MENU_CLICK.Text,ID_OP);
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("عذرا لا يوجد حجز هنا");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-----
        }

     

       

     
        private void SEX_COMB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AGE_TextBoxX.Focus();
            }
        }

        private void PERSON_NAME_ARTextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEX_COMB.Focus();
            }
        }

        private void AGE_TextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_JOB.Focus();
            }
        }

        private void TXT_JOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PHONE.Focus();
            }
        }

        private void TXT_PHONE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ADDRESS.Focus();
            }
        }

        private void TXT_ADDRESS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_NUM.Focus();
            }
        }

        private void TXT_ID_NUM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_REC.Focus();
            }
        }

        private void TXT_ID_REC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_PAGE.Focus();
            }
        }

        private void TXT_ID_PAGE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_FATHER.Focus();
            }
        }

        private void TXT_FATHER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_NUMF.Focus();
            }
        }

        private void TXT_ID_RECF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_PAGEF.Focus();
            }
        }

        
        private void nAME_EMPComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_NOTE.Focus();
            }
        }

        private void TXT_NOTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_ADD_Click (null,null);
            }
        }

        private void TXT_ID_NUMF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_RECF.Focus();
            }
        }

      
      

        
     
       

       

     
    

        private void PERSON_NAME_ARTextBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEX_COMB.Focus();
            }
        }

        private void AGE_TextBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_JOB.Focus();
            }
        }

        private void TXT_JOB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PHONE.Focus();
            }
        }

        private void TXT_PHONE1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ADDRESS.Focus();
            }
        }

        private void TXT_ADDRESS1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_NUM.Focus();
            }
        }

        private void TXT_ID_NUM1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_REC.Focus();
            }
        }

        private void TXT_ID_REC1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_PAGE.Focus();
            }
        }

        private void TXT_ID_PAGE1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_FATHER.Focus();
            }
        }

      
        private void TXT_FATHER1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_NUMF.Focus();
            }
        }

   
        private void TXT_ID_NUMF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_RECF.Focus();
            }
        }

        private void TXT_ID_RECF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_ID_PAGEF.Focus();
            }
        }

        private void TXT_ID_PAGEF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_NOTE.Focus();
            }
        }

        private void TXT_NOTE1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_ADD_Click(null, null);
            }
        }

     
        

        

        

        private void dOCTOR_NAMEComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_DISEASE_BYDOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DISEASE_BYDOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox1.SelectedValue, typeof(int))))));
                this.gET_H_BOOKITYPE_BYDOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKITYPE_BYDOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox1.SelectedValue, typeof(int))))));

            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void nAME_EMPComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox19_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox20_Enter(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(iDToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(fLAG_SToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
             ///   this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(iDToolStripTextBox.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(fLAG_SToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void gET_H_PERSON_BOOKING_IDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void TXT_PRICE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (CLS.F_SEARCH_PAID != 1)
                //{


                var origText = this.TXT_PRICE.Text;

                this.TXT_PRICE.Text = Convert.ToDecimal(this.TXT_PRICE.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PRICE.SelectionStart = TXT_PRICE.TextLength;
            }
            catch
            {
                return;
            }
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
              //  this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, iD_VARToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(fLAGR_SEARCHToolStripTextBox.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dATE_FROMToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dATE_TOToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            HOSPITAL.OPERA.FRM_SHOW_PERSONINFO FRM = new OPERA.FRM_SHOW_PERSONINFO();FRM.Show();
        }
    }
}
