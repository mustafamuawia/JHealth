using MEDICALCLINIC.HOSPITAL.PRINT;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.SERVICES
{
    public partial class FRM_H_OP_MONEY_SERVICE :MEDICALCLINIC.HOSPITAL. BaseHospital
    {
        int BOOK_CODE,PERSON_CODE, op_CODE, BookId, DOCT_CODE, TAKDER_CODE, FLAG_CASH = -1;
        decimal DOCT_PRECENT, TAKDER_PRCENT, MINI_OP, TOT_T;
        public FRM_H_OP_MONEY_SERVICE(int BOOK_ID,int ID_PERSON)
        {
            InitializeComponent();
            BOOK_CODE = BOOK_ID;
           
        }
        public FRM_H_OP_MONEY_SERVICE( )
        {
            InitializeComponent();
          

        }
        void CLRCONTRL()
        {
            LBL_OP_TOTAL.Text = "0.00";
            LBL_OP_PAID.Text = "0.00";
            LBL_OP_B_REMAIN.Text = "0.00";
            LBL_OP_A_REMAIN.Text = "0.00";
            TXT_OP_NOW_PAID.Text = "";
            LBL_M_TOTAL.Text = "0.00";
            LBL_M_PAID.Text = "0.00";
            LBL_M_B_REMAIN.Text = "0.00";
            LBL_M_A_REMAIN.Text = "0.00";
            TXT_M_NOW_PAID.Text = "";
            LBL_S_TOTAL.Text = "0.00";
            LBL_S_PAID.Text = "0.00";
            LBL_S_B_REMAIN.Text = "0.00";
            LBL_S_A_REMAIN.Text = "0.00";
            TXT_S_NOW_PAID.Text = "";
        }
        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ADD_OPERATN_INFO_Load(object sender, EventArgs e)
        { 
        try
            {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_PERSON' table. You can move, or remove it, as needed.
                this.v_GET_H_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_PERSON);
                this.gET_H_BOOKING_BY_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_BY_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))));
                // LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_BY_CODE.Rows[0][18].ToString();
                DataTable dt = new DataTable();
                dt = this.mEDICAL_CLINIC_DBDataSet.V_GET_H_PERSON;
                AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    datasource.Add(dt.Rows[i][1].ToString());
                }
                this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
                this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.pERSON_NAMEComboBox.SelectedIndex = -1;



            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
       

        private void PTN_BOX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void TXTBARCODE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    CLRCONTRL();
 
                    this.gET_H_PERSON_COD_BOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXTBARCODE.Text, typeof(int))))),1);

                    if (this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK.Rows.Count > 0)
                    {

                    BOOK_CODE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK.Rows[0][1].ToString());
                        PERSON_CODE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK.Rows[0][0].ToString());
                        pERSON_NAMEComboBox.SelectedValue = PERSON_CODE;
                    this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(13, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                    if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                    {
                        LBL_OP_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                        // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                        LBL_OP_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                        LBL_OP_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                    }
                        this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(18, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                        if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                        {
                            LBL_M_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                            // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                            LBL_M_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                            LBL_M_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                            PERSON_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);

                        }
                        this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(17, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                        if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                        {
                            LBL_S_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                            // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                            LBL_S_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                            LBL_S_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                            PERSON_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);

                        }
                    }
                    TXTBARCODE.Clear();
                   // TXT_PAID.Focus();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }





       





        private void pERSON_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.gET_H_BOOKING_PRICE_OPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP, Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue), 2);
            // this.gET_H_OP_TYP_BOOK_PRICETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OP_TYP_BOOK_PRICE, Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue), 2);
          

            try
            {
                CLRCONTRL();

                this.gET_H_PERSON_COD_BOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK, new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))),2);

                if (this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK.Rows.Count > 0)
                {

                    BOOK_CODE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK.Rows[0][1].ToString());
                    PERSON_CODE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK.Rows[0][0].ToString());
                  
                    // this.gET_H_BOOKING_PRICE_SER_ITMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_SER_ITM, new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                    //  this.gET_BEBIT_BY_BCODE_ACODE_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(17, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                    this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(13, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

                    if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                    {
                        LBL_OP_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                        // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                        LBL_OP_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                        LBL_OP_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                        PERSON_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);

                    }
                    this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(18, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

                    if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                    {
                        LBL_M_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                        // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                        LBL_M_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                        LBL_M_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                        PERSON_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);

                    }
                    this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(17, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

                    if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                    {
                        LBL_S_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                        // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                        LBL_S_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                        LBL_S_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                        PERSON_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);

                    }
                }
            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            } 
        }

        

        private void TXT_M_NOW_PAID_TextChanged(object sender, EventArgs e)
        {
                       try
            {
                var origText = this.TXT_M_NOW_PAID.Text;

                this.TXT_M_NOW_PAID.Text = Convert.ToDecimal(this.TXT_M_NOW_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_M_NOW_PAID.SelectionStart = TXT_M_NOW_PAID.TextLength;
                LBL_M_A_REMAIN.Text = (Convert.ToDecimal(LBL_M_B_REMAIN.Text) - Convert.ToDecimal(TXT_M_NOW_PAID.Text)).ToString();

            }
            catch (System.Exception ex)
            {
                return;
            }
        }

        private void TXT_S_NOW_PAID_TextChanged(object sender, EventArgs e)
        {
                       try
            {
                var origText = this.TXT_S_NOW_PAID.Text;

                this.TXT_S_NOW_PAID.Text = Convert.ToDecimal(this.TXT_S_NOW_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_S_NOW_PAID.SelectionStart = TXT_S_NOW_PAID.TextLength;
                LBL_S_A_REMAIN.Text = (Convert.ToDecimal(LBL_S_B_REMAIN.Text) - Convert.ToDecimal(TXT_S_NOW_PAID.Text)).ToString();

            }
            catch (System.Exception ex)
            {
                return;
            }
        }

     

       
 

        private void TXT_OP_NOW_PAID_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var origText = this.TXT_OP_NOW_PAID.Text;

                this.TXT_OP_NOW_PAID.Text = Convert.ToDecimal(this.TXT_OP_NOW_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_OP_NOW_PAID.SelectionStart = TXT_OP_NOW_PAID.TextLength;
                LBL_OP_A_REMAIN.Text = (Convert.ToDecimal(LBL_OP_B_REMAIN.Text) - Convert.ToDecimal(TXT_OP_NOW_PAID.Text)).ToString();

            }
            catch (System.Exception ex)
            {
                return;
            }

          
        }

        private void gET_H_BOOKING_PRICE_OPDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (pERSON_NAMEComboBox.SelectedIndex != -1)
                {
                    try
                    {
                        //LBL_TOTAL_DGV.Text =
                        //   (from DataGridViewRow row in gET_H_BOOKING_PRICE_OPDataGridView.Rows
                        //    where row.Cells[7].FormattedValue.ToString() != string.Empty
                        //    select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();

                        CLRCONTRL();
            
                       
                        //DOCT_PRECENT = Convert.ToDecimal(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[5].Value);
                        //TAKDER_PRCENT = Convert.ToDecimal(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[8].Value);
                        //BOOK_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[9].Value);
                        //DOCT_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[3].Value);
                        //TAKDER_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[6].Value);
                        //MINI_OP = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[65].Value);
                        //op_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[67].Value);
                       

                        TXTBARCODE.Clear();
                       // TXT_PAID.Focus();
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }
        }



       

        

        private void BTN_CASH_Click(object sender, EventArgs e)
        {
            FLAG_CASH = 1;

        }

        private void BTN_NO_CASH_Click(object sender, EventArgs e)
        {
            FLAG_CASH = 2;
        }





        private void BTN_PARTIAL_CASH_Click(object sender, EventArgs e)
        {
            FLAG_CASH = 3;

        }

       

       

       

        private void FRM_OPRATION_MONEY_Shown(object sender, EventArgs e)
        {
            TXTBARCODE.Focus();
        }




        private void BTN_SAVE_S_Click(object sender, EventArgs e)
        {
        //تسديد العمليات
            if (TXT_OP_NOW_PAID.Text != String.Empty || TXT_OP_NOW_PAID.Text !="")
            {
                if (Convert.ToDecimal(TXT_OP_NOW_PAID.Text ) >0)
                {
                    var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                BOOK_CODE
                              , System.DateTime.Now
                              , "قبض عن اجور عمليات "
                              , 13
                              , 0
                              , true
                              , CLS.USER_CODE
                              , ref CLS.SUBMIT_FLAG
                              , CLS.BRANCH_ID
                              , CLS.Cost_Center_WARD_DR
                              ).ToString());

                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BookId
                                        , 111
                                        , "قبض اجور  عملية"
                                        , 0
                                        , 0
                                        , Convert.ToDecimal(TXT_OP_NOW_PAID.Text)
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
                    , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                    , "قبض اجور  عملية"
                    , 0
                    , 0
                    , 0
                    , Convert.ToDecimal(TXT_OP_NOW_PAID.Text)
                    , "من حساب الزبون الى حساب الصندوق"
                    , 1
                    , 1
                    , ref CLS.SUBMIT_FLAG
                     );

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
                            DataTable dt = new DataTable();
                            DataTable dt1 = new DataTable();
                        this.gET_H_SANAD_TO_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_SANAD_TO_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType(BookId, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(13, typeof(int))))));
                        dt = this.mEDICAL_CLINIC_DBDataSet.GET_H_SANAD_TO_PRINT;
                            this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(5, typeof(int))))));
                            dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                            LocalReport lr = new LocalReport();
                            lr.ReportEmbeddedResource = "MEDICALCLINIC.HOSPITAL.PRINT.RPT_SANAD_INCOME.rdlc";
                            lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                            lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                            lr.Print();


                        //    //  BTN_SAVEE_Click(null, null);
                        //    SANAD.PRINT.FRM_SANAD_PRINT myfrrm = new SANAD.PRINT.FRM_SANAD_PRINT();
                        //    SANAD.PRINT.RPT_SANAD_QBD mmprt = new SANAD.PRINT.RPT_SANAD_QBD(); PrinterSettings settings = new PrinterSettings();
                        //    SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString);
                        //    string ServerName = SqlConnectionStringBuilder.DataSource;
                        //    string DatabaseName = SqlConnectionStringBuilder.InitialCatalog;
                        //    Boolean IntegratedSecurity = SqlConnectionStringBuilder.IntegratedSecurity;
                        //    string UserID = SqlConnectionStringBuilder.UserID;
                        //    string Password = SqlConnectionStringBuilder.Password;

                        //    foreach (CrystalDecisions.CrystalReports.Engine.Table Table in mmprt.Database.Tables)
                        //    {
                        //        CrystalDecisions.Shared.TableLogOnInfo TableLogOnInfo = Table.LogOnInfo;
                        //        TableLogOnInfo.ConnectionInfo.ServerName = ServerName;
                        //        TableLogOnInfo.ConnectionInfo.DatabaseName = DatabaseName;
                        //        TableLogOnInfo.ConnectionInfo.IntegratedSecurity = IntegratedSecurity;

                        //        if (IntegratedSecurity != true)
                        //        {
                        //            TableLogOnInfo.ConnectionInfo.UserID = UserID;
                        //            TableLogOnInfo.ConnectionInfo.Password = Password;
                        //        }
                        //        Table.ApplyLogOnInfo(TableLogOnInfo);
                        //    }
                        //    //  mmprt.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DataBase, Properties.Settings.Default.ID, Properties.Settings.Default.Password);

                        //    // mmprt.SetParameterValue("@ID_BOOK", CLS.ID_BOOK_PRINT);
                        //    // mmprt.SetParameterValue("@DOCT_CODE", CLS.USER_CODE);
                        //    mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                        //    DataTable DTDATA = new DataTable();
                        //    DataTable DTHDR = new DataTable();
                        //    this.gET_SANAD_TO_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType(BookId, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))),13);
                        //    DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT;
                        //  //  this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 1);
                        // //   DTHDR = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                        //    //lصدر بيانات الصورة
                        //   // mmprt.Subreports[0].SetDataSource(DTHDR);//lصدر بيانات الجدول الاخر
                        //    mmprt.SetDataSource(DTDATA);
                        //    myfrrm.crystalReportViewer1.ReportSource = mmprt;
                        //    myfrrm.ShowDialog();
                        //    mmprt.PrintToPrinter(1, false, 0, 0);
                        //    Cursor.Current = Cursors.Default;
                        TXT_OP_NOW_PAID.Text = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }




                }
            }

            //تسديد الملحقات
            if (TXT_M_NOW_PAID.Text != String.Empty || TXT_M_NOW_PAID.Text != "")
            {
                if (Convert.ToDecimal(TXT_M_NOW_PAID.Text) > 0)
                {
                    var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                BOOK_CODE
                              , System.DateTime.Now
                              , "قبض اجور ملحقات عملية"
                              , 18
                              , 0
                              , true
                              , CLS.USER_CODE
                              , ref CLS.SUBMIT_FLAG, CLS.BRANCH_ID
                              , 0
                              ).ToString());

                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BookId
                                        , 111
                                        , "قبض اجور ملحقات عملية"
                                        , 0
                                        , 0
                                        , Convert.ToDecimal(TXT_M_NOW_PAID.Text)
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
                    , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                     , "قبض اجور ملحقات عملية"
                    , 0
                    , 0
                    , 0
                    , Convert.ToDecimal(TXT_M_NOW_PAID.Text)
                    , "من حساب الزبون الى حساب الصندوق"
                    , 1
                    , 1
                    , ref CLS.SUBMIT_FLAG
                     );
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
                        DataTable dt = new DataTable();
                        DataTable dt1 = new DataTable();
                        this.gET_SANAD_TO_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType(BookId, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))),18);
                        dt = this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT;
                        this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(5, typeof(int))))));
                        dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                        LocalReport lr = new LocalReport();
                        lr.ReportEmbeddedResource = "MEDICALCLINIC.SANAD.PRINT.RPT_SANAD_QBD.rdlc";
                        lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                        lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                        lr.Print();
                        //  BTN_SAVEE_Click(null, null);
                        TXT_M_NOW_PAID.Text = "";

                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                }
            }

            //تسديد الخدمات
            if (TXT_S_NOW_PAID.Text != String.Empty || TXT_S_NOW_PAID.Text != "")
            {
                if (Convert.ToDecimal(TXT_S_NOW_PAID.Text) > 0)
                {
                    var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                BOOK_CODE
                              , System.DateTime.Now
                              , "عن اجور عملية المريض: " 
                              , 17
                              , 0
                              , true
                              , CLS.USER_CODE
                              , ref CLS.SUBMIT_FLAG, CLS.BRANCH_ID,0
                              ).ToString());

                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BookId
                                        , 111
                                        , "قبض اجور خدمات"
                                        , 0
                                        , 0
                                        , Convert.ToDecimal(TXT_S_NOW_PAID.Text)
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
                    , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                     , "قبض اجور خدمات"
                    , 0
                    , 0
                    , 0
                    , Convert.ToDecimal(TXT_S_NOW_PAID.Text)
                    , "من حساب الزبون الى حساب الصندوق"
                    , 1
                    , 1
                    , ref CLS.SUBMIT_FLAG
                     );


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
                        DataTable dt = new DataTable();
                        DataTable dt1 = new DataTable();
                        this.gET_SANAD_TO_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType(BookId, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))),17);
                        dt = this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT;
                        this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(5, typeof(int))))));
                        dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                        LocalReport lr = new LocalReport();
                        lr.ReportEmbeddedResource = "MEDICALCLINIC.SANAD.PRINT.RPT_SANAD_QBD.rdlc";
                        lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                        lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                        lr.Print();
                        TXT_S_NOW_PAID.Text = "";

                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }


                }
            }

            MSG.Msg.Alart(AlartType.Save);

        }



      
       
    }
}
