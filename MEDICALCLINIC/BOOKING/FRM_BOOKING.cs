
using MEDICALCLINIC.HOSPITAL.PRINT;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.BOOKING
{
    public partial class FRM_BOOKING : Form
    {
        //byte[] imge1;
        //byte[] imge2;
        //byte[] imge3;
     
        public FRM_BOOKING()
        {
            InitializeComponent();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {

            try
            {
                //if (PERSON_NAME_ARTextBoxX.Text == "")
                //{

                //    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                //}
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (TXTBOOKCODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TXTBOOKCODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    //DateTime datetie = new DateTime(TIME_BOOKING.Value);
                    //imge1 = new byte[0];
                    //imge2= new byte[0];
                    //imge3= new byte[0];
                    //INSERTED.P_INSERT_T_BOOKING( 
                    //      Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
                    //    , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                    //    , bOOK_TYPE_CODEComboBox.Text
                    //    , dISEASE_NAMEComboBox.Text
                    //    , ""
                    //    , ""
                    //    , ""
                    //    , CLIENT_NOTETextBoxX.Text
                    //    , Convert.ToDateTime(DATE_BOOKING.Value)
                    //    ,false 
                    //    , TIME_BOOKING.Text 
                    //    ,false
                    //    , ref  CLS.SUBMIT_FLAG);
                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
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

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           // try
           // {
                //if (PERSON_NAME_ARTextBoxX.Text == "")
                //{

                //    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                //}
               // if (MessageBox.Show(CLS.Q_MSG_UPDATE, CLS.OP_UPDATE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               // {

                //    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                //    imge1 = new byte[0];
                //    imge2 = new byte[0];
                //    imge3 = new byte[0];
                //    INSERTED.P_UPDATE_T_BOOKING( 
                //           CLS.CLIENT_CODE
                //        , Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
                //        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                //        , bOOK_TYPE_CODEComboBox.Text
                //        , dISEASE_NAMEComboBox.Text
                //        , ""
                //        , ""
                //        , ""
                //        , CLIENT_NOTETextBoxX.Text
                //        , Convert.ToDateTime(DATE_BOOKING.Value)
                //        , TIME_BOOKING.Text 
                //         , false
                       
                //        , ref  CLS.SUBMIT_FLAG);
                //    if (CLS.SUBMIT_FLAG == 1)
                //    {

                //        TXTBOOKCODE.Text = CLS.CLIENT_CODE.ToString();
                //        MSG.Msg.Alart(AlartType.Update);

                //    }
                //    else
                //    {

                //        MSG.Msg.Alart(AlartType.Error);

                //    }
                //}
           // }

         //   catch (Exception EX)
           // {
              //  MessageBox.Show(EX.Message, CLS.TITEL_MESG);
           // }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                //if (PERSON_NAME_ARTextBoxX.Text == "")
                //{

                //    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                //}
 MSG.Msg.Alart(AlartType.Error);
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_BOOKING (Convert.ToInt32(TXTBOOKCODE.Text),Convert .ToInt32 (dOCTOR_NAMEComboBox .SelectedValue ), CLS.USER_CODE,ref  CLS.SUBMIT_FLAG);


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

        public void cleartextbox(Control root)
        {
            foreach (Control ct in root.Controls)
            {
                if (ct is TextBox)
                    ((TextBox)ct).Clear();

                //' افراغ لتيكست بوكس 
            }
        }
        

        
       
        
 

        private void FRM_BOOKING_Load(object sender, EventArgs e)
        {
            try
            {
                                 this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
                                 this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
                    this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    this.p_GET_A_BOOKTYPETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_A_BOOKTYPE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    this.p_GET_A_DISEASETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_A_DISEASE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                          DataTable dt = new DataTable();
                          dt = this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON;
                        AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            datasource.Add(dt.Rows[i][1].ToString());
                        }
                        this.LBL_NAMEPERSON.AutoCompleteCustomSource = datasource;
                        this.LBL_NAMEPERSON.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        this.LBL_NAMEPERSON.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


                        dOCTOR_NAMEComboBox.SelectedIndex = -1;
                        LBL_NAMEPERSON.SelectedIndex = -1;
            
            
            }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                try
                {
                    this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    this.p_GET_A_BOOKTYPETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_A_BOOKTYPE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    this.p_GET_A_DISEASETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_A_DISEASE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                       }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void buttonX4_Click_1(object sender, EventArgs e)
        {
            BOOKING.FRM_SEARCH_BOOKING FRM = new BOOKING.FRM_SEARCH_BOOKING(1);
            FRM.ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            cleartextbox(this.groupBox1);
        }

       
        private void buttonX10_Click(object sender, EventArgs e)
        {
           
        }

        

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonX4_Click_2(object sender, EventArgs e)
        {
            //BOOKING.FRM_SEARCH_BOOKING FRM = new BOOKING.FRM_SEARCH_BOOKING();
            //FRM.ShowDialog();
        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            //OPERATION_PP.FRM_ALL_OPERTION_PRICE FRM = new OPERATION_PP.FRM_ALL_OPERTION_PRICE();
            //FRM.ShowDialog();
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
           //PERSONS . FRM_CONVERT_TO_DOCT FRM = new PERSONS . FRM_CONVERT_TO_DOCT();
           // FRM.ShowDialog();
        }

        private void buttonX11_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    int BookId;
            //    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            //    BookId = int.Parse(
            //      INSERTED.P_INSERT_T_BOOKING(
            //      Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
            //    , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
            //    , bOOK_TYPE_CODEComboBox.Text
            //    , dISEASE_NAMEComboBox.Text
            //    , ""
            //    , ""
            //    , ""
            //    , textBoxX1.Text
            //    , Convert.ToDateTime(DATE_BOOKING.Value)
            //    , false
            //    , TIME_BOOKING.Text
            //    , true
            //    , "0.00"
            //    , false
            //    , ref  CLS.SUBMIT_FLAG).ToString());

            //    if (CLS.SUBMIT_FLAG == 1)
            //    {
            //        //var GET_NUM = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            //        //GET_NUM.GET_NUM_MONEY_CHECKED(Convert.ToInt32(comboBox1.SelectedValue)
            //        //    , Convert.ToDateTime(DATE_BOOKING.Value)
            //        //    , ref  PRICE_RET, ref NUM_RET);
            //        //label7.Text = PRICE_RET.ToString();
            //        //MessageBox.Show(CLS.COMP_MSG_SAVE, CLS.TITEL_MESG);
            //        TXTBOOKCODE.Text = BookId.ToString();
            //        dOCTOR_NAMEComboBox.SelectedIndex = -1;
            //        LBL_NAMEPERSON.SelectedIndex = -1;
            //    }
            //    else
            //    {

            //        MSG.Msg.Alart(AlartType.Error);

            //    }

            //}

            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message + "تم الحجز مسبقا لهذا المراجع", CLS.TITEL_MESG);
            //}
        }

        private void buttonX10_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    if (TXTBOOKCODEX.Text == "")
            //    {

            //        errorProvider1.SetError(TXTBOOKCODEX, CLS.TXT_NULL);
            //    }
            //    if (MessageBox.Show(CLS.Q_MSG_UPDATE, CLS.OP_UPDATE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {

            //        var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            //        UPDT.P_UPDATE_T_BOOKING(
            //              Convert.ToInt32(TXTBOOKCODEX.Text)
            //            , Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
            //            , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
            //            , bOOK_TYPE_CODEComboBox.Text
            //            , dISEASE_NAMEComboBox.Text
            //            , ""
            //            , ""
            //            , ""
            //            , textBoxX1.Text
            //            , Convert.ToDateTime(DATE_BOOKING.Value)
            //            , TIME_BOOKING.Text
            //            , false
            //            , true
            //            , ref  CLS.SUBMIT_FLAG);
            //        if (CLS.SUBMIT_FLAG == 1)
            //        {

            //            TXTBOOKCODEX.Text = CLS.CLIENT_CODE.ToString();
            //            MSG.Msg.Alart(AlartType.Update);

            //        }
            //        else
            //        {

            //            MSG.Msg.Alart(AlartType.Error);

            //        }
            //    }
            //}

            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            //}
        }

        private void buttonX9_Click_1(object sender, EventArgs e)
        {
            try
            {
                //if (PERSON_NAME_ARTextBoxX.Text == "")
                //{

                //    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                //}
 MSG.Msg.Alart(AlartType.Error);
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_BOOKING(Convert.ToInt32(TXTBOOKCODEX.Text), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue),CLS.USER_CODE, ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        TXTBOOKCODEX.Text = CLS.CLIENT_CODE.ToString();
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

        private void buttonX1_Click_2(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void buttonX6_Click_1(object sender, EventArgs e)
        {
            //cleartextbox(groupBox1 );
        }

        private void dOCTOR_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LBL_NAMEPERSON.Focus();
            }
        }

        private void LBL_NAMEPERSON_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bOOK_TYPE_CODEComboBox.Focus();
            }
        }

        private void bOOK_TYPE_CODEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dISEASE_NAMEComboBox .Focus();
            }
        }

        private void dISEASE_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DATE_BOOKING.Focus();
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
                buttonX11_Click_1(null, null);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BOOKING.FRM_SEARCH_BOOKING FRM = new BOOKING.FRM_SEARCH_BOOKING(1);
            FRM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleartextbox(groupBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                if (dOCTOR_NAMEComboBox.SelectedIndex==-1)
                {
                    MessageBox.Show("رجاءا حدد الطبيب اولا", CLS.TITEL_MESG);
                    return;
                }
                if (LBL_NAMEPERSON.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءا حدد المريض اولا", CLS.TITEL_MESG);
                    return;
                }
                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);



                int BookId;
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                if (CLS.SUBMIT_IS_BOOK == 1) { 
                BookId = int.Parse(
                  INSERTED.P_INSERT_T_BOOKING(
                  
                  Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
                , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                , bOOK_TYPE_CODEComboBox.Text
                , dISEASE_NAMEComboBox.Text
                , ""
                , ""
                , ""
                , TXTNOTE.Text
                , Convert.ToDateTime(DATE_BOOKING.Value)
                , false
                , TIME_BOOKING.Text
                , true
                , "0.00"
               
                , false
                , CLS.BRANCH_ID
                ,1
                ,false
                , ref  CLS.SUBMIT_FLAG).ToString());

                if(Convert.ToString(BookId)==String.Empty)
                {
                    return;
                }
                else
                if (CLS.SUBMIT_FLAG == 1)
                {
                    //var GET_NUM = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    //GET_NUM.GET_NUM_MONEY_CHECKED(Convert.ToInt32(comboBox1.SelectedValue)
                    //    , Convert.ToDateTime(DATE_BOOKING.Value)
                    //    , ref  PRICE_RET, ref NUM_RET);
                    //label7.Text = PRICE_RET.ToString();
                    //MessageBox.Show(CLS.COMP_MSG_SAVE, CLS.TITEL_MESG);
                    TXTBOOKCODE.Text = BookId.ToString();
                    dOCTOR_NAMEComboBox.SelectedIndex = -1;
                    LBL_NAMEPERSON.SelectedIndex = -1;
                }
                    //else
                    //{

                    //    MSG.Msg.Alart(AlartType.Error);
                    //    return;
                    //}
                }
                else
                {
                    MessageBox.Show("تم الحجز مسبقا لهذا المراجع", CLS.TITEL_MESG);
                    return;
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show( "تم الحجز مسبقا لهذا المراجع", CLS.TITEL_MESG);
                //return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
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
                        , Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                        , bOOK_TYPE_CODEComboBox.Text
                        , dISEASE_NAMEComboBox.Text
                        , ""
                        , ""
                        , ""
                        , TXTNOTE.Text
                        , Convert.ToDateTime(DATE_BOOKING.Value)
                        , TIME_BOOKING.Text
                        , false
                        , true
                        ,false
                        ,""
                        , ref  CLS.SUBMIT_FLAG
                        ,CLS.BRANCH_ID);
                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        TXTBOOKCODE.Text = CLS.CLIENT_CODE.ToString();
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //if (PERSON_NAME_ARTextBoxX.Text == "")
                //{

                //    errorProvider1.SetError(PERSON_NAME_ARTextBoxX, CLS.TXT_NULL);
                //}
 MSG.Msg.Alart(AlartType.Error);
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_BOOKING(Convert.ToInt32(TXTBOOKCODE.Text), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue),CLS.USER_CODE, ref  CLS.SUBMIT_FLAG);


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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OPERATION_PP.FRM_ALL_OPERTION_PRICE FRM = new OPERATION_PP.FRM_ALL_OPERTION_PRICE();
            FRM.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //PERSONS.FRM_CONVERT_TO_DOCT FRM = new PERSONS.FRM_CONVERT_TO_DOCT();
            //FRM.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            try
            {
                if (LBL_NAMEPERSON.Text == "")
                {
                    MessageBox.Show("فضلا قم بأختيار مريض اولا");
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
                button4_Click(null, null);
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                this.p_GET_BOOKING_PRINT_NUMBERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_PRINT_NUMBER, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXTBOOKCODE.Text, typeof(int))))));
                dt = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_PRINT_NUMBER;
                this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;   
                LocalReport lr = new LocalReport();
                lr.ReportEmbeddedResource = "MEDICALCLINIC.PRINT.RPT_BOOKING_NUMBER.rpt";
                lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                lr.Print();
                Cursor.Current = Cursors.Default;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void PIC_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}
