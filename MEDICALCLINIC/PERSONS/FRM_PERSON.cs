using AForge.Video;
using AForge.Video.DirectShow;
using MEDICALCLINIC.HOSPITAL.PRINT;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace MEDICALCLINIC.PERSONS
{
    public partial class FRM_PERSON : SETTING.baseclinicanddental
    {
       
         
        // int  ? NUM_RET=0;
        // decimal ? PRICE_RET ;
        byte[] imge1;
        int cam_flg = -1;
        int BookId;
        public int flges = 0; 
        public int getidpersonforedit = 0;
        DataTable dt = new DataTable();
        public FRM_PERSON()
        {
            InitializeComponent();

        }
        private FilterInfoCollection WEBCAM;
        private VideoCaptureDevice CAM;

        public void cleartextbox(Control root)
        {
            foreach (Control ct in root.Controls)
            {
                if (ct is TextBox)
                    ((TextBox)ct).Clear();

                //' افراغ لتيكست بوكس 
            }
        }



        //private void CLIENT_NAME_ARTextBoxX_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        SEX_COMB.Focus();
        //    }
        //}

        private void FRM_PERSON_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR' table. You can move, or remove it, as needed.
         
            try
            {
                var workingArea = Screen.FromHandle(Handle).WorkingArea;
                MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
                WindowState = FormWindowState.Maximized;
                //this.gET_DOCTOR_BY_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_FLOOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.BRANCH_ID, typeof(int))))));
                this.v_GET_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR);
               // this.gET_PERSON_BY_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                this.gET_PERSON_BY_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                this.gET_DOCTOR_BY_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_FLOOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), 2);
               
                // this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
                //this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
                this.p_GET_A_BOOKTYPETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_A_BOOKTYPE, 0);
                this.p_GET_A_DISEASETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_A_DISEASE, 0);
                this.t_SEX_STATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.T_SEX_STATE);
               //dOCTOR_NAMEComboBox.SelectedIndex = -1;
                SEX_COMB.SelectedIndex = -1;
                fLOOR_NAMEComboBox.SelectedIndex= - 1;
                pERSON_NAMEComboBox.SelectedIndex = -1;
                dOCTOR_NAMEComboBox.SelectedIndex = -1;

                WEBCAM = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                foreach (FilterInfo VideoCaptureDevice in WEBCAM)
                {
                    COM_CAMLIST.Items.Add(VideoCaptureDevice.Name);
                }
                //if (WEBCAM.Count>0)
                //{
                //    COM_CAMLIST.SelectedIndex = 0;
                //}
               


                if (flges==0)
                {

                 dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR;
                AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    datasource.Add(dt.Rows[i][1].ToString());
                }
                this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
                this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
              
                }
                AGE_TextBoxX.Text = "";
                TXT_ADDRESS.Text = "";
                TXT_PHONE.Text = "";
                SEX_COMB.SelectedIndex = -1;               

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void t_SEX_STATEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_SEX_STATEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mEDICAL_CLINIC_DBDataSet);

        }

      



      











       


        void CAMM_NEWFRM(object sender, NewFrameEventArgs EventArgs)
        {
            Bitmap BIT = (Bitmap)EventArgs.Frame.Clone();
            pictureBox2.Image = BIT;

        }


        private void buttonX12_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox1.Image;
        }

      

        private void FRM_PERSON_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (cam_flg == 1)
            {
                cam_flg = -1;
                CAM.Stop();


            }
        }

      
        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            //cleartextbox(groupBox1);
            pictureBox1.Image = Properties.Resources.per_img;
        }

     

       
        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            if (cam_flg == 1)
            {
                cam_flg = -1;
                CAM.Stop();


            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_PERSON_IMAGE frm = new FRM_PERSON_IMAGE();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void BTN_ADD_FILES_Click(object sender, EventArgs e)
        {
            FRM_PERSON_IMAGE frm = new FRM_PERSON_IMAGE();
            frm.ShowDialog();
        }

        private void BTN_ADD_QUES_Click(object sender, EventArgs e)
        {
            FRM_M_HISTORY FRM = new FRM_M_HISTORY(pERSON_NAMEComboBox.SelectedValue.ToInt()); FRM.ShowDialog();
        }

        private void BTN_ADD_M_HISTORY_Click(object sender, EventArgs e)
        {
            FRM_MEDICAL_HISTORY_PERSON FRM = new FRM_MEDICAL_HISTORY_PERSON(-1); FRM.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



      

    

        private void BTN_DRBOOK_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                if (dOCTOR_NAMEComboBox.SelectedIndex>-1)
                {
                this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_COMPELETETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_COMPELETE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_WAITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_WAIT, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_BACKTODOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_BACKTODOCT, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_BOOKING.Value);
                LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##0.00");
                LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                LBL_WAIT.Text = (dataGridView1.Rows.Count).ToString();
                LBL_BACKCOMP.Text = (dataGridView3.Rows.Count).ToString();
                LBL_COMP.Text = (dataGridView2.Rows.Count).ToString();
                }
                
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_SEARCHGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (FSEARCH == 1)
                {
                    this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                }
                else
                 if (FSEARCH == 2)
                {
                    this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                }
                else
                 if (FSEARCH == 3)
                {
                    this.p_GET_T_BOOKING_T_PERSON_WAITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_WAIT, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                }

                if (FSEARCH == 4)
                {
                    this.p_GET_T_BOOKING_T_PERSON_BACKTODOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_BACKTODOCT, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                }
                if (FSEARCH == 5)
                {
                    this.p_GET_T_BOOKING_T_PERSON_COMPELETETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_COMPELETE, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        int FSEARCH;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["TP_INACTIVE"])//your specific tabname
            {
                FSEARCH = 1;
            }
            else
             if (tabControl1.SelectedTab == tabControl1.TabPages["TP_ACTIVE"])//your specific tabname
            {
                FSEARCH = 2;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["TP_WAIT"])//your specific tabname
            {
                FSEARCH = 3;
            }

            if (tabControl1.SelectedTab == tabControl1.TabPages["TP_DOCCOMP"])//your specific tabname
            {
                FSEARCH = 4;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["TP_COMP"])//your specific tabname
            {
                FSEARCH = 5;
            }
        }

        private void dgvInActive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    // CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, kSHFIA_PRICETextBox.Text, DATE_DAY.Value,false,true );
                    var CAHNGE_BOOK_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    int ID_BOOKED = Convert.ToInt32(dgvInActive.CurrentRow.Cells[1].Value);
                    CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, kSHFIA_PRICETextBox.Text, DATE_BOOKING.Value, false, true);
                    this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    // this.gET_H_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(12, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                    // LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();
                    this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_BOOKING.Value);
                    LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##0.00");
                    LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                    LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                    LBL_WAIT.Text = (dataGridView1.Rows.Count).ToString();
                    LBL_BACKCOMP.Text = (dataGridView3.Rows.Count).ToString();
                    LBL_COMP.Text = (dataGridView2.Rows.Count).ToString();
                    R_NO_PAID.BackColor = Color.SteelBlue;
                    R_PAID.BackColor = Color.SteelBlue;
                    R_NO_PAID.Checked = false;
                    R_PAID.Checked = false;



                    //    if (R_NO_PAID.Checked == false && R_PAID.Checked == false)
                    //    {
                    //        MessageBox.Show("رجاء حدد نوع الدفع اولا ثم اعد المحاولة");
                    //        return;
                    //    }

                    //   // Program.bookingDoctorService.FireBookingEvent();

                    //    int ID_BOOKED = Convert.ToInt32(dgvInActive.CurrentRow.Cells[1].Value);

                    //    var CAHNGE_BOOK_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    //    var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();


                    //    if (R_PAID.Checked == true)
                    //    {
                    //        CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, kSHFIA_PRICETextBox.Text, DATE_BOOKING.Value, false, true);

                    //        // CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, kSHFIA_PRICETextBox.Text, DATE_DAY.Value,false,true );

                    //        //  CNGE_STATE.P_CHANGE_KSHFIA_STATE(ID_BOOKED, true, kSHFIA_PRICETextBox.Text, ref CLS.SUBMIT_FLAG);
                    //        // U_TIME.P_UDATE_T_BOOKING_TIME(Convert.ToInt32(dgvInActive .CurrentRow.Cells[0].Value),
                    //        //   Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now);
                    //        var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();


                    //        int PERSON_CODE = Convert.ToInt32(dgvInActive.CurrentRow.Cells[2].Value);
                    //        //var GET_BILL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    //        //int? BILL_SANAD=-1;
                    //        //GET_BILL.P_GET_BILL_NUMBER(12, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), ref BILL_SANAD);

                    //        Decimal DoctorPrecentage = Convert.ToDecimal(pRECENTAGE_KSHFIALabel1.Text);
                    //        decimal TOTAL_PRICE = Convert.ToDecimal(kSHFIA_PRICETextBox.Text);
                    //        decimal DebitPatient = 0;
                    //        decimal CreditService = 0;
                    //        decimal CreditDoctor = 0;
                    //        var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    //        if (DoctorPrecentage > 0)
                    //        {



                    //            DebitPatient = TOTAL_PRICE;
                    //            CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                    //            CreditService = TOTAL_PRICE - CreditDoctor;



                    //            BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                    //                       ID_BOOKED
                    //                      , System.DateTime.Now
                    //                      ,"الكشفية"
                    //                      , 12
                    //                      , 0
                    //                      , true
                    //                      , CLS.USER_CODE
                    //                      , ref CLS.SUBMIT_FLAG
                    //                      , CLS.BRANCH_ID
                    //                      ,CLS.Cost_Center_WARD_DR
                    //                      ).ToString());

                    //            if (R_PAID.Checked == true)
                    //            {



                    //                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    //                                (
                    //                                 BookId
                    //                                , 111
                    //                                , ""
                    //                                , 0
                    //                                , 0
                    //                                , DebitPatient
                    //                                , 0
                    //                                , "من حساب الزبون الى حساب الصندوق"
                    //                                , 1
                    //                                , 1
                    //                                , ref CLS.SUBMIT_FLAG
                    //                                 );

                    //                //TO

                    //                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    //                (
                    //                  BookId
                    //                , PERSON_CODE
                    //                , ""
                    //                , 0
                    //                , 0
                    //                , 0
                    //                , DebitPatient
                    //                , "من حساب الزبون الى حساب الصندوق"
                    //                , 1
                    //                , 1
                    //                , ref CLS.SUBMIT_FLAG
                    //                 );


                    //                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    //                 (
                    //                   BookId
                    //                 , PERSON_CODE
                    //                  , ""
                    //                 , 0
                    //                 , 0
                    //                 , DebitPatient
                    //                 , 0
                    //                 , "من حساب الزبون الى حساب الصندوق"
                    //                 , 1
                    //                 , 1
                    //                 , ref CLS.SUBMIT_FLAG
                    //                  );


                    //                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    //              (
                    //                BookId
                    //              , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                    //               , ""
                    //              , 0
                    //              , 0
                    //              , 0
                    //              , CreditDoctor
                    //              , "من حساب الزبون الى حساب الدكتور"
                    //              , 1
                    //              , 1
                    //              , ref CLS.SUBMIT_FLAG
                    //               );

                    //                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    //               (
                    //                 BookId
                    //               , 4006
                    //               , ""
                    //               , 0
                    //               , 0
                    //               , 0
                    //               , CreditService
                    //               , "من حساب الزبون الى حساب العمليات"
                    //               , 1
                    //               , 1
                    //               , ref CLS.SUBMIT_FLAG
                    //                );


                    //            }


                    //        }

                    //        else
                    //   if (DoctorPrecentage == 0)
                    //        {



                    //            BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                    //                        ID_BOOKED
                    //                      , System.DateTime.Now
                    //                      , "الكشفية"
                    //                      , 12
                    //                      , 0
                    //                      , true
                    //                      , CLS.USER_CODE
                    //                      , ref CLS.SUBMIT_FLAG, CLS.BRANCH_ID,0
                    //                      ).ToString());

                    //            if (R_PAID.Checked == true)
                    //            {
                    //                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    //                                (
                    //                                 BookId
                    //                                , 111
                    //                                , ""
                    //                                , 0
                    //                                , 0
                    //                                , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                    //                                , 0
                    //                                , "من حساب الزبون الى حساب الصندوق"
                    //                                , 1
                    //                                , 1
                    //                                , ref CLS.SUBMIT_FLAG
                    //                                 );

                    //                //TO

                    //                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    //                (
                    //                  BookId
                    //                , PERSON_CODE
                    //                , ""
                    //                , 0
                    //                , 0
                    //                , 0
                    //                , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                    //                , "من حساب الزبون الى حساب الصندوق"
                    //                , 1
                    //                , 1
                    //                , ref CLS.SUBMIT_FLAG
                    //                 );

                    //                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    //                 (
                    //                   BookId
                    //                 , PERSON_CODE
                    //                  , ""
                    //                 , 0
                    //                 , 0
                    //                 , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                    //                 , 0
                    //                 , "من حساب الزبون الى حساب الصندوق"
                    //                 , 1
                    //                 , 1
                    //                 , ref CLS.SUBMIT_FLAG
                    //                  );

                    //                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    //              (
                    //                BookId
                    //              , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                    //              , ""
                    //              , 0
                    //              , 0
                    //              , 0
                    //              , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                    //              , "من حساب الزبون الى حساب الدكتور"
                    //              , 1
                    //              , 1
                    //              , ref CLS.SUBMIT_FLAG
                    //               );












                    //            }




                    //        }






                    //        ////  string ServiceAccount = "", DoctorAccount = "", PatientAccount = "";
                    //        //int DoctorPrecentage = GETPRECNTAGE;
                    //        //decimal DebitPatient = 0, TOTAL_PRICE=Convert.ToDecimal(kSHFIA_PRICETextBox.Text);

                    //        //decimal CreditService = 0;
                    //        //decimal CreditDoctor = 0;

                    //        //DebitPatient = TOTAL_PRICE;
                    //        //CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                    //        //CreditService = TOTAL_PRICE - CreditDoctor;



                    //    }
                    //    else
                    //    ///////////////////////////////////////////////

                    //    if (R_NO_PAID.Checked == true)
                    //    {
                    //        CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, false, "00.0", DATE_BOOKING.Value, false, true);

                    //        //CNGE_STATE.P_CHANGE_KSHFIA_STATE(ID_BOOKED, false, "0.00", ref CLS.SUBMIT_FLAG);
                    //        //DELL.P_DELETE_T_BOX(ID_BOOKED, 12, "", ref CLS.SUBMIT_FLAG);
                    //        //this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_DAY.Value);
                    //        //label7.Text = this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0].ToString();

                    //        //U_TIME.P_UDATE_T_BOOKING_TIME(Convert.ToInt32(dgvInActive.CurrentRow.Cells[0].Value),
                    //        //    Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now);

                    //    }


                    //    this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    //    this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    //    // this.gET_H_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(12, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                    //    // LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();
                    //    this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_BOOKING.Value);
                    //    LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##0.00");
                    //    LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                    //    LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                    //    LBL_WAIT.Text = (dataGridView1.Rows.Count).ToString();
                    //    LBL_BACKCOMP.Text = (dataGridView3.Rows.Count).ToString();
                    //    LBL_COMP.Text = (dataGridView2.Rows.Count).ToString();
                    //    R_NO_PAID.BackColor = Color.SteelBlue;
                    //    R_PAID.BackColor = Color.SteelBlue;
                    //    R_NO_PAID.Checked = false;
                    //    R_PAID.Checked = false;
                }
                else
                if (e.ColumnIndex == 12)
                {

                    if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        var ITED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                        ITED.P_DELETE_T_BOOKING_NOW(dgvInActive.CurrentRow.Cells[1].Value.ToInt(), 0,CLS.USER_CODE, ref CLS.SUBMIT_FLAG);

                        if (CLS.SUBMIT_FLAG == 1)
                        {
                            this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                            MSG.Msg.Alart(AlartType.Delete);
                            //if (this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows.Count > 0)
                            //{

                            //    LBL_TOTAL.Text = "0.00";
                            //    LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##");

                            //}
                            Decimal sum = 0;
                            LBL_TOTAL.Text = "0.00";
                            for (int i = 0; i < dgvInActive.Rows.Count; ++i)
                            {
                                sum += Convert.ToDecimal(dgvInActive.Rows[i].Cells[10].Value);
                            }
                            LBL_TOTAL.Text = sum.ToString();

                            pERSON_NAMEComboBox.SelectedIndex = -1;
                            pERSON_NAMEComboBox.Text = string.Empty;
                        }
                        else
                        {

                            MSG.Msg.Alart(AlartType.Error);

                        }
                    }
                }
                else
                if (e.ColumnIndex == 11)
                {

                    if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                    {

                        if (dgvInActive.CurrentRow.Cells[10].Value.ToInt()>0)
                        {
                            MessageBox.Show("الكشفية مدفوعه بالفعل لايمكنك الدفع مرتين");
                            return;
                        }else
                        {
                            var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            UPDT.P_UPDATE_T_BOOKING_KISHFIA(dgvInActive.CurrentRow.Cells[1].Value.ToInt(), Convert.ToDecimal(kSHFIA_PRICETextBox.Text), ref CLS.SUBMIT_FLAG);
                            Decimal DoctorPrecentage = Convert.ToDecimal(pRECENTAGE_KSHFIALabel1.Text);
                            decimal TOTAL_PRICE = Convert.ToDecimal(kSHFIA_PRICETextBox.Text);
                            decimal DebitPatient = 0;
                            decimal CreditService = 0;
                            decimal CreditDoctor = 0;
                            int PERSON_CODE = dgvInActive.CurrentRow.Cells[2].Value.ToInt();
                            if (DoctorPrecentage > 0)
                            {



                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditService = TOTAL_PRICE - CreditDoctor;



                                BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                            dgvInActive.CurrentRow.Cells[1].Value.ToInt()
                                          , System.DateTime.Now
                                          , "الكشفية"
                                          , 12
                                          , 0
                                          , true
                                          , CLS.USER_CODE
                                          , ref CLS.SUBMIT_FLAG
                                          , CLS.BRANCH_ID
                                          , CLS.Cost_Center_KSHFIA_DR
                                          ).ToString());



                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookId
                                                , 111
                                                , ""
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
                                  BookId
                                , PERSON_CODE
                                , ""
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
                                   BookId
                                 , PERSON_CODE
                                  , ""
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
                                BookId
                              , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                               , ""
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
                                 BookId
                               , 4006
                               , ""
                               , 0
                               , 0
                               , 0
                               , CreditService
                               , "من حساب الزبون الى حساب العمليات"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );


                            }

                            else
                       if (DoctorPrecentage == 0)
                            {






                                BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                         dgvInActive.CurrentRow.Cells[1].Value.ToInt()
                                       , System.DateTime.Now
                                       , "الكشفية"
                                       , 12
                                       , 0
                                       , true
                                       , CLS.USER_CODE
                                       , ref CLS.SUBMIT_FLAG
                                       , CLS.BRANCH_ID
                                       , CLS.Cost_Center_KSHFIA_DR
                                       ).ToString());
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookId
                                                , 111
                                                , ""
                                                , 0
                                                , 0
                                                , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                                , 0
                                                , "من حساب الزبون الى حساب الصندوق"
                                                , 1
                                                , 1
                                                , ref CLS.SUBMIT_FLAG
                                                 );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BookId
                                , PERSON_CODE
                                , ""
                                , 0
                                , 0
                                , 0
                                , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                 (
                                   BookId
                                 , PERSON_CODE
                                  , ""
                                 , 0
                                 , 0
                                 , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                 , 0
                                 , "من حساب الزبون الى حساب الصندوق"
                                 , 1
                                 , 1
                                 , ref CLS.SUBMIT_FLAG
                                  );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                              (
                                BookId
                              , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                              , ""
                              , 0
                              , 0
                              , 0
                              , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                              , "من حساب الزبون الى حساب الدكتور"
                              , 1
                              , 1
                              , ref CLS.SUBMIT_FLAG
                               );







                            }
                            this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                            this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                            this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_BOOKING.Value);
                            //if (this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows.Count > 0)
                            //{

                            //    LBL_TOTAL.Text = "0.00";
                            //    LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##");

                            //}
                            Decimal sum = 0;
                            LBL_TOTAL.Text = "0.00";
                            for (int i = 0; i < dgvInActive.Rows.Count; ++i)
                            {
                                sum += Convert.ToDecimal(dgvInActive.Rows[i].Cells[10].Value);
                            }
                            LBL_TOTAL.Text = sum.ToString();

                            LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                            LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                            if (CLS.SUBMIT_FLAG == 1)
                            {
                                MSG.Msg.Alart(AlartType.Save);
                            }
                            {

                            }
                        }
                    }
                }
                else
                    if (e.ColumnIndex == 13)
                {
                    FRM_M_HISTORY FRM = new FRM_M_HISTORY(dgvInActive.CurrentRow.Cells[2].Value.ToInt()); FRM.ShowDialog();
                }
            }
                

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("يرجى اختيار أسم الطبيب اولا");
            }
        }

        private void R_PAID_CheckedChanged(object sender, EventArgs e)
        {
            if (R_PAID.Checked == true)
            {
                R_PAID.BackColor = Color.Red;
            }
            else
            {
                R_PAID.BackColor = Color.SteelBlue;
            }
        }

        private void R_NO_PAID_CheckedChanged(object sender, EventArgs e)
        {
            if (R_NO_PAID.Checked == true)
            {
                R_NO_PAID.BackColor = Color.Red;
            }
            else
            {
                R_NO_PAID.BackColor = Color.SteelBlue;
            }
        }

        private void dgvActive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                if (e.ColumnIndex == 0)
                {
                    //if (R_NO_PAID.Checked == false && R_PAID.Checked == false)
                    //{
                    //    MessageBox.Show("رجاء حدد نوع الدفع اولا ثم اعد المحاولة");
                    //    return;
                    //}

                    var DELL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var CNGE_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    int ID_BOOKED = Convert.ToInt32(dgvActive.CurrentRow.Cells[2].Value);
                    int ID_PERSON = Convert.ToInt32(dgvActive.CurrentRow.Cells[3].Value);
                    var GET_NUM = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    var CAHNGE_BOOK_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, "0.00", DATE_BOOKING.Value, false, false);


                   
                        ////if ((bool)(dgvActive.CurrentRow.Cells[13].Value) == true)
                        ////{
                        ////    // UPD.P_UDATE_T_BOOKING_T_PERSON(Convert.ToInt32(dgvActive.CurrentRow.Cells[1].Value), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), false, false  );
                        ////    // CNGE_STATE.P_CHANGE_KSHFIA_STATE(ID_BOOKED, false, "0.00", ref CLS.SUBMIT_FLAG);
                        ////    DELL.P_DELETE_T_BOX_DETAILS(ID_BOOKED, 12, ID_PERSON, Convert.ToDateTime(dgvActive.CurrentRow.Cells[9].Value), ref CLS.SUBMIT_FLAG);
                        ////}




                        //else
                        //    if ((bool)(dgvActive.CurrentRow.Cells[13].Value) == false)
                        //{
                        //  //  UPD.P_UDATE_T_BOOKING_T_PERSON(Convert.ToInt32(dgvActive.CurrentRow.Cells[1].Value), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), false, false );

                        //}

                        this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(dgvActive.CurrentRow.Cells[9].Value));
                    this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                    LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##0.00");
                    LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                    LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                }
                else
                if (e.ColumnIndex == 15)
                {

                    if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    {
                        var ITED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                        ITED.P_DELETE_T_BOOKING_NOW(dgvActive.CurrentRow.Cells[2].Value.ToInt(), 0,CLS.USER_CODE, ref CLS.SUBMIT_FLAG);
                        
                        if (CLS.SUBMIT_FLAG == 1)
                        {
                            MSG.Msg.Alart(AlartType.Delete);
                            this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                            Decimal sum =0;
                            LBL_TOTAL.Text = "0.00";
                            for (int i = 0; i < dgvActive.Rows.Count; ++i)
                            {
                                sum += Convert.ToDecimal(dgvActive.Rows[i].Cells[12].Value);
                            }
                            LBL_TOTAL.Text = sum.ToString();
                           

                        }
                        else
                        {

                            MSG.Msg.Alart(AlartType.Error);


                        }
                    }
                }
                else
                if (e.ColumnIndex == 14)
                {

                    if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                    {

                        if (dgvActive.CurrentRow.Cells[12].Value.ToInt() > 0)
                        {
                            MessageBox.Show("الكشفية مدفوعه بالفعل لايمكنك الدفع مرتين");
                            return;
                        }
                        else
                        {
                            var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            int PERSON_CODE = dgvActive.CurrentRow.Cells[3].Value.ToInt();
                            int BOOKING_CODE = dgvActive.CurrentRow.Cells[2].Value.ToInt();
                            UPDT.P_UPDATE_T_BOOKING_KISHFIA(BOOKING_CODE, Convert.ToDecimal(kSHFIA_PRICETextBox.Text), ref CLS.SUBMIT_FLAG);
                            Decimal DoctorPrecentage = Convert.ToDecimal(pRECENTAGE_KSHFIALabel1.Text);
                            decimal TOTAL_PRICE = Convert.ToDecimal(kSHFIA_PRICETextBox.Text);
                            decimal DebitPatient = 0;
                            decimal CreditService = 0;
                            decimal CreditDoctor = 0;
                            
                            if (DoctorPrecentage > 0)
                            {



                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditService = TOTAL_PRICE - CreditDoctor;



                                BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                            BOOKING_CODE
                                          , System.DateTime.Now
                                          , "الكشفية"
                                          , 12
                                          , 0
                                          , true
                                          , CLS.USER_CODE
                                          , ref CLS.SUBMIT_FLAG
                                          , CLS.BRANCH_ID
                                          , CLS.Cost_Center_KSHFIA_DR
                                          ).ToString());



                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookId
                                                , 111
                                                , ""
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
                                  BookId
                                , PERSON_CODE
                                , ""
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
                                   BookId
                                 , PERSON_CODE
                                  , ""
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
                                BookId
                              , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                               , ""
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
                                 BookId
                               , 4006
                               , ""
                               , 0
                               , 0
                               , 0
                               , CreditService
                               , "من حساب الزبون الى حساب العمليات"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );


                            }

                            else
                       if (DoctorPrecentage == 0)
                            {






                                BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                        BOOKING_CODE
                                       , System.DateTime.Now
                                       , "الكشفية"
                                       , 12
                                       , 0
                                       , true
                                       , CLS.USER_CODE
                                       , ref CLS.SUBMIT_FLAG
                                       , CLS.BRANCH_ID
                                       , CLS.Cost_Center_KSHFIA_DR
                                       ).ToString());
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookId
                                                , 111
                                                , ""
                                                , 0
                                                , 0
                                                , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                                , 0
                                                , "من حساب الزبون الى حساب الصندوق"
                                                , 1
                                                , 1
                                                , ref CLS.SUBMIT_FLAG
                                                 );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BookId
                                , PERSON_CODE
                                , ""
                                , 0
                                , 0
                                , 0
                                , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                 (
                                   BookId
                                 , PERSON_CODE
                                  , ""
                                 , 0
                                 , 0
                                 , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                 , 0
                                 , "من حساب الزبون الى حساب الصندوق"
                                 , 1
                                 , 1
                                 , ref CLS.SUBMIT_FLAG
                                  );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                              (
                                BookId
                              , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                              , ""
                              , 0
                              , 0
                              , 0
                              , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                              , "من حساب الزبون الى حساب الدكتور"
                              , 1
                              , 1
                              , ref CLS.SUBMIT_FLAG
                               );







                            }
                            this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                            this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                            this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_BOOKING.Value);
                            //if (this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows.Count > 0)
                            //{

                            //    LBL_TOTAL.Text = "0.00";
                            //    LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##");

                            //}
                            Decimal sum = 0;
                            LBL_TOTAL.Text = "0.00";
                            for (int i = 0; i < dgvActive.Rows.Count; ++i)
                            {
                                sum += Convert.ToDecimal(dgvActive.Rows[i].Cells[12].Value);
                            }
                            LBL_TOTAL.Text = sum.ToString();

                            LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                            LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                            if (CLS.SUBMIT_FLAG == 1)
                            {
                                MSG.Msg.Alart(AlartType.Save);
                            }
                            
                        }
                    }
                }

            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13)
            {

                CHAT.FRM_SCANNER frm = new CHAT.FRM_SCANNER(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value),1);
                frm.ShowDialog();
            }
            if (e.ColumnIndex == 14)
            {

                var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                UPDT.P_UPDATE_T_BOOKING_BACKFROMWAIT(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value), ref CLS.SUBMIT_FLAG);
                this.p_GET_T_BOOKING_T_PERSON_WAITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_WAIT, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_BACKTODOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_BACKTODOCT, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

            }

        }

        private void BTN_SEARCH_PER_Click(object sender, EventArgs e)
        {
            FRM_SEARCH_PERSON FRM = new FRM_SEARCH_PERSON(0);
            FRM.ShowDialog();
        }

        private void BTN_SAVE_PER_Click(object sender, EventArgs e)
        {
            try
            {

                //if (PERSON_CODETextBoxX.Text == "")
                //{

                //    errorProvider1.SetError(PERSON_CODETextBoxX, CLS.TXT_NULL);
                //    return;
                //}

 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (pERSON_NAMEComboBox.SelectedIndex == -1)
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);
                    }
                    var INSERTEDP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    if (pictureBox1.Image==null)
                    {
                        imge1 = null;
                    }
                    else
                    {
                        MemoryStream ms1 = new MemoryStream();
                        pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                        imge1 = ms1.ToArray();
                    }
                  

                    if (pERSON_NAMEComboBox.SelectedIndex == -1)
                    {
                        INSERTEDP.P_INSERT_T_PERSON

                           (
                             CLS.CHEECK_CODE
                           , ref CLS.CLIENT_CODE
                           , pERSON_NAMEComboBox.Text
                           , 0
                           , Convert.ToInt32(SEX_COMB.SelectedValue)
                           , AGE_TextBoxX.Text
                           , TXT_PHONE.Text
                           , TXT_ADDRESS.Text
                           , imge1
                           , TXT_NOTE.Text
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , 0
                           , ""
                           , true
                           , ref CLS.SUBMIT_FLAG);




                        if (CLS.SUBMIT_FLAG == 1)
                        {
                            // MSG.Msg.Alart(AlartType.Save);
                            PERSON_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                            // this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                            //  dOCTOR_NAMEComboBox.SelectedIndex = -1;
                            this.gET_PERSON_BY_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                            dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR;
                            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                datasource.Add(dt.Rows[i][1].ToString());
                            }
                            this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
                            this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                            this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                            pERSON_NAMEComboBox.SelectedIndex = -1;
                            SEX_COMB.SelectedIndex = -1;

                        }


                    }



                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_EDIT_PER_Click(object sender, EventArgs e)
        {
            try
            {
                if (pERSON_NAMEComboBox.Text == "")
                {

                    errorProvider1.SetError(pERSON_NAMEComboBox, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {
                    int P = flges;
                    //int P = (int)pERSON_NAMEComboBox.SelectedValue;
                    if (pictureBox1.Image == null)
                    {
                        imge1 = null;
                    }
                    else
                    {
                        MemoryStream ms1 = new MemoryStream();
                        pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                        imge1 = ms1.ToArray();
                    }
                  
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_UPDATE_T_PERSON(
                      getidpersonforedit//Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                    , pERSON_NAMEComboBox.Text
                    , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                    , Convert.ToInt32(SEX_COMB.SelectedValue)
                    , AGE_TextBoxX.Text
                    , TXT_PHONE.Text
                    , TXT_ADDRESS.Text
                    , imge1
                    , TXT_NOTE.Text
                    , ""
                    , ""
                    , ""
                    , ""
                    , ""
                    , ""
                    , ""
                    , 0
                    , ""
                    , true
                    , ref CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {


                        MSG.Msg.Alart(AlartType.Update);
                        flges = 0;
                        getidpersonforedit = 0;
                        this.gET_PERSON_BY_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                        dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR;
                        AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            datasource.Add(dt.Rows[i][1].ToString());
                        }
                        this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
                        this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                    
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

        private void BTN_DELETE_PER_Click(object sender, EventArgs e)
        {
            try
            {
                if (pERSON_NAMEComboBox.Text == "")
                {

                    errorProvider1.SetError(pERSON_NAMEComboBox, CLS.TXT_NULL);
                }
 MSG.Msg.Alart(AlartType.Error);
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_DELETE_T_PERSON(Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), ref CLS.SUBMIT_FLAG);

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

        private void BTN_SEARCHB_Click(object sender, EventArgs e)
        {
            BOOKING.FRM_SEARCH_BOOKING FRM = new BOOKING.FRM_SEARCH_BOOKING(2);
            FRM.ShowDialog();
        }

        private void BTN_SAVEB_Click(object sender, EventArgs e)
        {
            try
            {
                if (pERSON_NAMEComboBox.Text ==string.Empty)
                {
                    MessageBox.Show("يرجى ادخال اسم المريض ثم أعد المحاولة");
                    return;
                }

                if (SEX_COMB.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد جنس المريض ثم أعد المحاولة");
                    return;
                }
                if (R_NO_PAID.Checked == false && R_PAID.Checked == false)
                {
                    MessageBox.Show("يرجى تحدد نوع الدفع اولا ثم أعد المحاولة");
                    return;
                }
                //if (MessageBox.Show(CLS.Q_MSG_SAVE, CLS.OP_SAVE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {
                    int FLOORCODE;
                    if (fLOOR_NAMEComboBox.SelectedIndex == -1)
                    {
                        FLOORCODE = CLS.BRANCH_ID.ToInt();
                    }
                    else
                    {
                        FLOORCODE = fLOOR_NAMEComboBox.SelectedValue.ToInt();
                    }

                    decimal GENRL_KSHFIA_PRICE = Convert.ToDecimal(kSHFIA_PRICETextBox.Text);

                    if (R_PAID.Checked)
                    {
                         GENRL_KSHFIA_PRICE = Convert.ToDecimal(kSHFIA_PRICETextBox.Text);
                    }
                    else
                     if (R_NO_PAID.Checked)
                    {
                         GENRL_KSHFIA_PRICE =0;
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    if (pictureBox1.Image == null)
                    {
                        imge1 = null;
                    }
                    else
                    {
                        MemoryStream ms1 = new MemoryStream();
                        pictureBox1.Image.Save(ms1, pictureBox1.Image.RawFormat);
                        imge1 = ms1.ToArray();

                    }
                    Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);

                    //عمل سكريت شوت 
                    //panel3.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    //pictureBox2.Image = bmp;
                    //imge1 = ImageToByte(bmp);



                    //using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
                    //{

                    //    Bitmap bmp = new Bitmap(panel3.Width, panel3.Height);
                    //    panel3.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    //    bmp.Save(@"D:\MyPanelImageaa.bmp"); 
                    //    bmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                    //    imge1 = stream.ToArray();
                    //}


                    int? GENERAL_CLIENTCOE;
                    GENERAL_CLIENTCOE = pERSON_NAMEComboBox.SelectedValue.ToInt();

                    if (pERSON_NAMEComboBox.SelectedIndex == -1)
                    {

                        var INSERTEDP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERTEDP.P_INSERT_T_PERSON

                           (
                             0
                           , ref CLS.CLIENT_CODE
                           , pERSON_NAMEComboBox.Text
                           , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                           , Convert.ToInt32(SEX_COMB.SelectedValue)
                           , AGE_TextBoxX.Text
                           , TXT_PHONE.Text
                           , TXT_ADDRESS.Text
                           , imge1
                           , TXT_NOTE.Text
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , 0
                           , ""
                           , true
                           , ref CLS.SUBMIT_FLAG);
                        GENERAL_CLIENTCOE = CLS.CLIENT_CODE;
                        BookId = int.Parse(
                          INSERTED.P_INSERT_T_BOOKING(
                          CLS.CLIENT_CODE
                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                        , bOOK_TYPE_CODEComboBox.Text
                        , dISEASE_NAMEComboBox.Text
                        , ""
                        , ""
                        , ""
                        , TXT_NOTE.Text
                        , Convert.ToDateTime(DATE_BOOKING.Value)
                        , false
                        , TIME_BOOKING.Text
                        , false
                        , GENRL_KSHFIA_PRICE.ToString()
                        , false
                        , FLOORCODE
                        , 1
                        , false
                        , ref CLS.SUBMIT_FLAG).ToString());

                       


                    }
                    else
                    {
                       
                        var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                         INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);

                        if (CLS.SUBMIT_IS_BOOK == 1)
                        {
                            //BookId =يحفظ فيه قيمة الايدي الجديد
                            BookId = int.Parse(
                              INSERTED.P_INSERT_T_BOOKING(
                              Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                            , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                            , bOOK_TYPE_CODEComboBox.Text
                            , dISEASE_NAMEComboBox.Text
                            , ""
                            , ""
                            , ""
                            , TXT_NOTE.Text
                            , Convert.ToDateTime(DATE_BOOKING.Value)
                            , false
                            , TIME_BOOKING.Text
                            , false
                            , GENRL_KSHFIA_PRICE.ToString()
                            , false
                            , FLOORCODE
                            , 1
                            ,false
                            , ref CLS.SUBMIT_FLAG).ToString());


                            CLS.SUBMIT_IS_BOOK = 0;
                        }
                        else
                        {
                            MessageBox.Show("تم الحجز مسبقا لهذا المراجع", CLS.TITEL_MESG);
                            return;
                        }

                    }

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                        this.gET_PERSON_BY_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                        dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR;
                        AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            datasource.Add(dt.Rows[i][1].ToString());
                        }
                        this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
                        this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                        pERSON_NAMEComboBox.SelectedIndex = -1;
                        //SEX_COMB.SelectedIndex = -1;

                        //////////////////////////////
                        ///
                      

                        // Program.bookingDoctorService.FireBookingEvent();

                        int ID_BOOKED = BookId;// Convert.ToInt32(dgvInActive.CurrentRow.Cells[1].Value);

                        var CAHNGE_BOOK_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();


                        if (R_PAID.Checked == true)
                        {
                            //CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, kSHFIA_PRICETextBox.Text, DATE_BOOKING.Value, false, true);

                            // CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, kSHFIA_PRICETextBox.Text, DATE_DAY.Value,false,true );

                            //  CNGE_STATE.P_CHANGE_KSHFIA_STATE(ID_BOOKED, true, kSHFIA_PRICETextBox.Text, ref CLS.SUBMIT_FLAG);
                            // U_TIME.P_UDATE_T_BOOKING_TIME(Convert.ToInt32(dgvInActive .CurrentRow.Cells[0].Value),
                            //   Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now);
                            var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            //int? GENERAL_CLIENTCOE;
                            //if (pERSON_NAMEComboBox.SelectedIndex==-1)
                            //{
                            //    GENERAL_CLIENTCOE = CLS.CLIENT_CODE;
                            //}
                            //else
                            //{
                            //    GENERAL_CLIENTCOE = pERSON_NAMEComboBox.SelectedValue.ToInt();
                            //}
                            int? PERSON_CODE = GENERAL_CLIENTCOE; // Convert.ToInt32(dgvInActive.CurrentRow.Cells[2].Value);
                            //var GET_BILL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            //int? BILL_SANAD=-1;
                            //GET_BILL.P_GET_BILL_NUMBER(12, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), ref BILL_SANAD);

                            Decimal DoctorPrecentage = Convert.ToDecimal(pRECENTAGE_KSHFIALabel1.Text);
                            decimal TOTAL_PRICE = GENRL_KSHFIA_PRICE;
                           
                            decimal DebitPatient = 0;
                            decimal CreditService = 0;
                            decimal CreditDoctor = 0;
                            var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            if (DoctorPrecentage > 0)
                            {



                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditService = TOTAL_PRICE - CreditDoctor;



                                BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                           ID_BOOKED
                                          , System.DateTime.Now
                                          , "الكشفية"
                                          , 12
                                          , 0
                                          , true
                                          , CLS.USER_CODE
                                          , ref CLS.SUBMIT_FLAG
                                          , CLS.BRANCH_ID
                                          , CLS.Cost_Center_KSHFIA_DR
                                          ).ToString());

                                if (R_PAID.Checked == true)
                                {



                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookId
                                                    , 111
                                                    , ""
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
                                      BookId
                                    , PERSON_CODE
                                    , ""
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
                                       BookId
                                     , PERSON_CODE
                                      , ""
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
                                    BookId
                                  , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                   , ""
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
                                     BookId
                                   , 4006
                                   , ""
                                   , 0
                                   , 0
                                   , 0
                                   , CreditService
                                   , "من حساب الزبون الى حساب العمليات"
                                   , 1
                                   , 1
                                   , ref CLS.SUBMIT_FLAG
                                    );


                                }


                            }

                            else
                       if (DoctorPrecentage == 0)
                            {



                             

                                if (R_PAID.Checked == true)
                                {
                                    BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                             ID_BOOKED
                                           , System.DateTime.Now
                                           , "الكشفية"
                                           , 12
                                           , 0
                                           , true
                                           , CLS.USER_CODE
                                           , ref CLS.SUBMIT_FLAG
                                           , CLS.BRANCH_ID
                                           , CLS.Cost_Center_KSHFIA_DR
                                           ).ToString());
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookId
                                                    , 111
                                                    , ""
                                                    , 0
                                                    , 0
                                                    , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                                    , 0
                                                    , "من حساب الزبون الى حساب الصندوق"
                                                    , 1
                                                    , 1
                                                    , ref CLS.SUBMIT_FLAG
                                                     );

                                    //TO

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                    (
                                      BookId
                                    , PERSON_CODE
                                    , ""
                                    , 0
                                    , 0
                                    , 0
                                    , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                    , "من حساب الزبون الى حساب الصندوق"
                                    , 1
                                    , 1
                                    , ref CLS.SUBMIT_FLAG
                                     );

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                     (
                                       BookId
                                     , PERSON_CODE
                                      , ""
                                     , 0
                                     , 0
                                     , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                     , 0
                                     , "من حساب الزبون الى حساب الصندوق"
                                     , 1
                                     , 1
                                     , ref CLS.SUBMIT_FLAG
                                      );

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                  (
                                    BookId
                                  , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                  , ""
                                  , 0
                                  , 0
                                  , 0
                                  , Convert.ToDecimal(kSHFIA_PRICETextBox.Text)
                                  , "من حساب الزبون الى حساب الدكتور"
                                  , 1
                                  , 1
                                  , ref CLS.SUBMIT_FLAG
                                   );












                                }




                            }






                            ////  string ServiceAccount = "", DoctorAccount = "", PatientAccount = "";
                            //int DoctorPrecentage = GETPRECNTAGE;
                            //decimal DebitPatient = 0, TOTAL_PRICE=Convert.ToDecimal(kSHFIA_PRICETextBox.Text);

                            //decimal CreditService = 0;
                            //decimal CreditDoctor = 0;

                            //DebitPatient = TOTAL_PRICE;
                            //CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                            //CreditService = TOTAL_PRICE - CreditDoctor;



                        }
                        ////else
                        ///////////////////////////////////////////////////

                        ////if (R_NO_PAID.Checked == true)
                        ////{
                        ////    //CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, false, "00.0", DATE_BOOKING.Value, false, true);

                        ////    //CNGE_STATE.P_CHANGE_KSHFIA_STATE(ID_BOOKED, false, "0.00", ref CLS.SUBMIT_FLAG);
                        ////    //DELL.P_DELETE_T_BOX(ID_BOOKED, 12, "", ref CLS.SUBMIT_FLAG);
                        ////    //this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_DAY.Value);
                        ////    //label7.Text = this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0].ToString();

                        ////    //U_TIME.P_UDATE_T_BOOKING_TIME(Convert.ToInt32(dgvInActive.CurrentRow.Cells[0].Value),
                        ////    //    Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now);

                        ////}


                        this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                        this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                        // this.gET_H_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(12, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                        // LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();
                        this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_BOOKING.Value);
                        LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##0.00");
                        LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                        LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                        LBL_WAIT.Text = (dataGridView1.Rows.Count).ToString();
                        LBL_BACKCOMP.Text = (dataGridView3.Rows.Count).ToString();
                        LBL_COMP.Text = (dataGridView2.Rows.Count).ToString();
                        //R_NO_PAID.BackColor = Color.SteelBlue;
                        //R_PAID.BackColor = Color.SteelBlue;
                        //R_NO_PAID.Checked = false;
                        //R_PAID.Checked = false;

                        BTN_NEWB_Click(null, null);





                    /////////



                    BTN_DRBOOK_SEARCH_Click(null, null);
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

        private void BTN_EDITB_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTBOOKCODE.Text == "")
                {

                    errorProvider1.SetError(TXTBOOKCODE, CLS.TXT_NULL);
                }
       if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    UPDT.P_UPDATE_T_BOOKING(
                          Convert.ToInt32(TXTBOOKCODE.Text)
                        , getidpersonforedit
                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                        , bOOK_TYPE_CODEComboBox.Text
                        , dISEASE_NAMEComboBox.Text
                        , ""
                        , ""
                        , ""
                        , TXT_NOTE.Text
                        , Convert.ToDateTime(DATE_BOOKING.Value)
                        , TIME_BOOKING.Text
                        , false
                        , false
                        ,false
                        , kSHFIA_PRICETextBox.Text
                        , ref CLS.SUBMIT_FLAG
                        , CLS.BRANCH_ID);
                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        TXTBOOKCODE.Text = CLS.CLIENT_CODE.ToString();
                        MSG.Msg.Alart(AlartType.Update);
                        getidpersonforedit = 0;
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

        private void BTN_DELETEB_Click(object sender, EventArgs e)
        {
            try
            {
                //if (PERSON_NAME_ARTextBoxX.Text == "")
                //{

                //    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                //}
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_BOOKING(Convert.ToInt32(TXTBOOKCODE.Text), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue),CLS.USER_CODE, ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        TXTBOOKCODE.Text = CLS.CLIENT_CODE.ToString();
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
        public static byte[] ImageToByteArray(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            //panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //imge1 = ImageToByteArray(bmp);


            try
            {
                if (dOCTOR_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد اسم الطبيب ثم أعد المحاولة");
                    return;
                }
                if (SEX_COMB.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد جنس المريض ثم أعد المحاولة");
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("حدد الطابعة أولا");
                    SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                    FRM.ShowDialog();
                    return;
                }
                BTN_SAVEB_Click(null, null);
                this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                DataTable dt3 = new DataTable();
                this.p_GET_BOOKING_PRINT_NUMBERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_PRINT_NUMBER, new System.Nullable<int>(((int)(System.Convert.ChangeType(BookId, typeof(int))))));
                dt = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_PRINT_NUMBER;
                this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                this.gET_ORGANIZATION_INFO_TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ORGANIZATION_INFO_, "1");
                dt3 = this.mEDICAL_CLINIC_DBDataSet.GET_ORGANIZATION_INFO_;
                LocalReport lr = new LocalReport();
                lr.ReportEmbeddedResource = "MEDICALCLINIC.PRINT.RPT_BOOKING_NUMBER.rdlc";
                lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                lr.DataSources.Add(new ReportDataSource("DataSet2", dt1)); 
                lr.DataSources.Add(new ReportDataSource("DataSet3", dt3));
                lr.Print();
                Cursor.Current = Cursors.Default;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pERSON_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SEX_COMB.Focus();
            }
        }

        private void SEX_COMB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AGE_TextBoxX.Focus();
            }
        }

        private void AGE_TextBoxX_KeyDown(object sender, KeyEventArgs e)
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
                DATE_BOOKING.Focus();
            }
        }

        private void kSHFIA_PRICETextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bOOK_TYPE_CODEComboBox.Focus();
            }
        }

        private void dOCTOR_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                kSHFIA_PRICETextBox.Focus();
            }
        }

        private void bOOK_TYPE_CODEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dISEASE_NAMEComboBox.Focus();
            }
        }

        private void dISEASE_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pERSON_NAMEComboBox.Focus();
            }
        }

        private void DATE_BOOKING_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TIME_BOOKING.Focus();
            }
        }

        private void TIME_BOOKING_KeyDown(object sender, KeyEventArgs e)
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
                BTN_SAVEB_Click(null, null);
            }
        }

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        try{
                if (dOCTOR_NAMEComboBox.SelectedIndex>-1)
                {
 
                this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value));
               // this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(dgvActive.CurrentRow.Cells[9].Value));
                this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##0.00");
                LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                //pERSON_NAMEComboBox.SelectedIndex = -1;
                //    this.gET_PERSON_BY_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                //    dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR;
                //    AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                //    for (int i = 0; i < dt.Rows.Count; i++)
                //    {
                //        datasource.Add(dt.Rows[i][1].ToString());
                //    }
                //    this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
                //    this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //    this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                }

                this.gET_COST_CENTER_BY_DR_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))),5);
                CLS.Cost_Center_KSHFIA_DR = this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_DR_CODE.Rows[0][0].ToInt();


                //TXT_ADDRESS.Text = String.Empty;
                //TXT_PHONE.Text = String.Empty;
                //AGE_TextBoxX.Text = String.Empty;

            }
            catch (System.Exception ex)
                {
                    //System.Windows.Forms.MessageBox.Show(ex.Message);
                }

}

        private void fLOOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fLOOR_NAMEComboBox.SelectedIndex>-1)
            {
                this.gET_DOCTOR_BY_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_FLOOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(fLOOR_NAMEComboBox.SelectedValue, typeof(int))))),1);
                dOCTOR_NAMEComboBox.SelectedIndex = -1;
                //kSHFIA_PRICETextBox.Text = String.Empty;
            }

        }

        private void BTN_NEWB_Click(object sender, EventArgs e)
        {
           // dISEASE_NAMEComboBox.SelectedIndex = -1;
            //bOOK_TYPE_CODEComboBox.SelectedIndex = -1;            
            //fLOOR_NAMEComboBox.SelectedIndex = -1;
            //dOCTOR_NAMEComboBox.SelectedIndex = -1;
            pERSON_NAMEComboBox.SelectedIndex = -1;
            SEX_COMB.SelectedIndex = -1;
            AGE_TextBoxX.Text = String.Empty;
            TXT_PHONE.Text = String.Empty;
            TXT_ADDRESS.Text = String.Empty;
            DATE_BOOKING.Value = DateTime.Now;
            R_PAID.Checked = false;
            R_NO_PAID.Checked = false;
            R_NO_PAID.BackColor = Color.SteelBlue;
            R_PAID.BackColor = Color.SteelBlue;

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (FSEARCH == 1)
                {
                    this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                }
                else
                 if (FSEARCH == 2)
                {
                    this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                }
                else
                 if (FSEARCH == 3)
                {
                    this.p_GET_T_BOOKING_T_PERSON_WAITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_WAIT, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                }

                if (FSEARCH == 4)
                {
                    this.p_GET_T_BOOKING_T_PERSON_BACKTODOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_BACKTODOCT, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                }
                if (FSEARCH == 5)
                {
                    this.p_GET_T_BOOKING_T_PERSON_COMPELETETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_COMPELETE, TXTSEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

 
        private void BTN_LASTBOOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (pERSON_NAMEComboBox.SelectedIndex>-1)
                {
                    this.gET_LAST_BOOKING_PERSON_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAST_BOOKING_PERSON_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))));

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
      
    }
}