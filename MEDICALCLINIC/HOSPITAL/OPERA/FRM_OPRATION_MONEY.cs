using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.OPERA
{
    public partial class FRM_OPRATION_MONEY : Form
    {
        int BOOK_CODE, op_CODE,  BookId, DOCT_CODE,TAKDER_CODE,FLAG_CASH=-1;
        decimal DOCT_PRECENT, TAKDER_PRCENT, MINI_OP,  TOT_T;
        public FRM_OPRATION_MONEY(int BOOK_ID)
        {
            InitializeComponent();
            BOOK_CODE = BOOK_ID;
        }
        public FRM_OPRATION_MONEY( )
        {
            InitializeComponent();
           
        }
        void CLRCONTRL()
        {
            LBL_NAME.Text = "0.00";
            LBL_TOTAL_OP.Text = "0.00";
            LBL_T_REMAIN.Text = "0.00";
            LBL_T_SERVICE.Text = "0.00";
            TXT_TOTAL.Text = "";
            TXT_REMAIN.Text = "";
            TXT_PAID.Text = "";

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
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_PERSON' table. You can move, or remove it, as needed.
            this.v_GET_H_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_PERSON);

            try
            {
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
                pERSON_NAMEComboBox.SelectedIndex = -1;



            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        int? B_CODE, BILL_SANAD, ACCOUNT_TO_CODE, ACCOUNT_FROM_CODE;

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
                   // this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXTBARCODE.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                    this.gET_H_BOOKING_PRICE_OPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP, Convert.ToInt32(TXTBARCODE.Text),1);
                    this.gET_H_OP_TYP_BOOK_PRICETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OP_TYP_BOOK_PRICE,Convert.ToInt32( TXTBARCODE.Text),1);
                   // pERSON_NAMEComboBox.SelectedValue = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][0]);
                    LBL_NAME.Text = pERSON_NAMEComboBox.Text;
                    LBL_TOTAL_OP.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][10].ToString();
                    DOCT_CODE = Convert.ToInt32(  this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][2]);
                    TAKDER_CODE = Convert.ToInt32(  this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][5]);
                    for (int i = 0; i < this.mEDICAL_CLINIC_DBDataSet.GET_H_OP_TYP_BOOK_PRICE.Rows.Count; i++)
                    {
                        LBL_T_SERVICE.Text =(Convert.ToDecimal(LBL_T_SERVICE.Text)+ Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_OP_TYP_BOOK_PRICE.Rows[i][5])).ToString();
                    }
                  
                    LBL_T_REMAIN.Text = (Convert.ToDecimal(LBL_TOTAL_OP.Text) - Convert.ToDecimal(LBL_T_SERVICE.Text)).ToString();
                    TXT_TOTAL.Text = LBL_T_REMAIN.Text;
                    DOCT_PRECENT = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][4]);
                    TAKDER_PRCENT = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][7]);
                    BOOK_CODE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][8]);
                    DOCT_CODE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][2]);
                    TAKDER_CODE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][5]);
                    MINI_OP = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][64]);
                    op_CODE =Convert.ToInt32( TXTBARCODE.Text);


                    TXTBARCODE.Clear();
                    TXT_PAID.Focus();
                    }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            }

      

        

        private void TXT_PAID_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                //if (CLS.F_SEARCH_PAID != 1)
                //{


                var origText = this.TXT_PAID.Text;

                this.TXT_PAID.Text = Convert.ToDecimal(this.TXT_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PAID.SelectionStart = TXT_PAID.TextLength;
                TXT_REMAIN.Text = (Convert.ToDecimal(TXT_TOTAL.Text) - Convert.ToDecimal(TXT_PAID.Text)).ToString();

                // }
            }
            catch
            {
                return;
            }

        }

       
       

      

        private void pERSON_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gET_H_BOOKING_PRICE_OPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP, Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue), 2);
           // this.gET_H_OP_TYP_BOOK_PRICETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OP_TYP_BOOK_PRICE, Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue), 2);

        }

        private void gET_H_BOOKING_PRICE_OPDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                if (pERSON_NAMEComboBox.SelectedIndex!=-1)
                {
                    try
                    {
                        CLRCONTRL();
                        // this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXTBARCODE.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                        // this.gET_H_BOOKING_PRICE_OPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP, Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue), 2);
                        this.gET_H_OP_TYP_BOOK_PRICETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OP_TYP_BOOK_PRICE, Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[67].Value), 1);
                      //  pERSON_NAMEComboBox.SelectedValue = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP.Rows[0][0]);
                        // LBL_NAME.Text = pERSON_NAMEComboBox.Text;
                        LBL_TOTAL_OP.Text = gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[11].Value.ToString();
                        //DOCT_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[3]);
                        //TAKDER_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[6]);

                        for (int i = 0; i < this.mEDICAL_CLINIC_DBDataSet.GET_H_OP_TYP_BOOK_PRICE.Rows.Count; i++)
                        {
                            LBL_T_SERVICE.Text = (Convert.ToDecimal(LBL_T_SERVICE.Text) + Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_OP_TYP_BOOK_PRICE.Rows[i][5])).ToString();
                        }

                        LBL_T_REMAIN.Text = (Convert.ToDecimal(LBL_TOTAL_OP.Text) - Convert.ToDecimal(LBL_T_SERVICE.Text)).ToString();
                        TXT_TOTAL.Text = LBL_T_REMAIN.Text;
                        DOCT_PRECENT = Convert.ToDecimal(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[5].Value);
                        TAKDER_PRCENT = Convert.ToDecimal(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[8].Value);
                        BOOK_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[9].Value);
                        DOCT_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[3].Value);
                        TAKDER_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[6].Value);
                        MINI_OP = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[65].Value);
                        op_CODE = Convert.ToInt32(gET_H_BOOKING_PRICE_OPDataGridView.CurrentRow.Cells[67].Value);


                        TXTBARCODE.Clear();
                        TXT_PAID.Focus();
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
            }
        }

       

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            //    this.gET_INVOICE_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_INVOICE_BOOKING, iD_VARToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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

        private void LBL_REMAIN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (CLS.F_SEARCH_PAID != 1)
                //{


                var origText = this.TXT_REMAIN.Text;

                this.TXT_REMAIN.Text = Convert.ToDecimal(this.TXT_REMAIN.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_REMAIN.SelectionStart = TXT_REMAIN.TextLength;
 
                // }
            }
            catch
            {
                return;
            }

        }

        private void LBL_TOTAL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (CLS.F_SEARCH_PAID != 1)
                //{


                var origText = this.TXT_REMAIN.Text;

                this.TXT_TOTAL.Text = Convert.ToDecimal(this.TXT_TOTAL.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_TOTAL.SelectionStart = TXT_TOTAL.TextLength;

                // }
            }
            catch
            {
                return;
            }
        }

        private void LBL_T_OP_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_OPRATION_MONEY_Shown(object sender, EventArgs e)
        {
            TXTBARCODE.Focus();
        }

    
       

        private void BTN_SAVE_S_Click(object sender, EventArgs e)
        {

            var INSERTEDF = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            if (FLAG_CASH==-1)
            {

                MessageBox.Show("حدد نوع الدفع اولا");
                return;
            }


            INSERTEDF.P_UPDATE_H_FLAGE_MONEY(

                     BOOK_CODE
                     
                    , CLS.USER_CODE
                    , Convert.ToDecimal(LBL_TOTAL_OP.Text)
                    , false
                    , ref CLS.SUBMIT_FLAG

                  );
            INSERTEDF.P_UPDATE_H_OP_MONEY(

              op_CODE,
              Convert.ToDecimal(LBL_T_REMAIN.Text)

           
             , ref CLS.SUBMIT_FLAG

           );

            //this.gET_INVOICE_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_INVOICE_BOOKING, BOOK_CODE.ToString());
            //DataTable fd = new DataTable();

            //fd = this.mEDICAL_CLINIC_DBDataSet.GET_INVOICE_BOOKING;
            //int id_invo = Convert.ToInt32(fd.Rows[0][0]);
            //decimal L_PRICE = Convert.ToDecimal(fd.Rows[0][3]);
            //TOT_T = Convert.ToDecimal(LBL_TOTAL_OP.Text) + L_PRICE;


            //var EDITINVOIC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            //EDITINVOIC.P_UPDATE_T_INVOICES_PRICE_(
            //        id_invo, 0, TOT_T, 1, ref CLS.SUBMIT_FLAG
            //        );




            if (CLS.SUBMIT_FLAG == 1)
            {


                try
                {


                    var GET_BILL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        GET_BILL.P_GET_BILL_NUMBER(18, CLS.DOCTOR_CODE_GENE, ref BILL_SANAD);
                    var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTBOXDETSERF = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    decimal DoctorPrecentage = Convert.ToDecimal(DOCT_PRECENT);
                    decimal TakderPrecentage = Convert.ToDecimal(TAKDER_PRCENT);
                    decimal ServicePrecentage =100 -(DOCT_PRECENT + TAKDER_PRCENT)  ;
                    decimal DebitPatient = 0;
                    decimal TOTAL_PRICE = 0;
                    decimal CreditService = 0;
                    decimal CreditDoctor = 0;
                    decimal CreditTakder = 0;



                    BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                           BOOK_CODE
                         , DT_NOW.Value
                          , "عن اجور العمليات "
                         , 13
                         , 0
                         , true
                         , CLS.USER_CODE
                         , ref CLS.SUBMIT_FLAG
                         , CLS.BRANCH_ID
                         , 0
                         ).ToString());

                  

                    if (DOCT_PRECENT == 0)
                    {





                        //بدون نسبة#
                        //نقددداٌ بدون نسبة

                        if (FLAG_CASH == 1)
                        {

                            if (Convert.ToDecimal(LBL_T_SERVICE.Text) > 0)
                            {
                                // TOTAL_PRICE = Convert.ToDecimal(LBL_TOTAL.Text) ;
                                //الخدمات#

                    BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                          BOOK_CODE
                        , DT_NOW.Value
                        , "عن اجور عملية المريض: " + pERSON_NAMEComboBox.Text
                        , 18
                        , 0
                        , true
                        , CLS.USER_CODE
                        , ref CLS.SUBMIT_FLAG
                        , CLS.BRANCH_ID
                        ,0
                        ).ToString());

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                   (
                                    BookId
                                   , 111
                                   , "الصندوق"
                                   , 0
                                   , 0
                                   , Convert.ToDecimal(LBL_T_SERVICE.Text)
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
                                , "المريض"
                                , 0
                                , 0
                                , 0
                                , Convert.ToDecimal(LBL_T_SERVICE.Text)
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );



                                //من المريض الى الخدمات
                                //FROM
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                 BookId
                               , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                               , "المريض"
                               , 0
                               , 0
                               , Convert.ToDecimal(LBL_T_SERVICE.Text)
                               , 0
                               , "من حساب الزبون الى حساب الخدمات"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );

                                // TO


                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                BookId
                               , 4002
                               , "الخدمات"
                               , 0
                               , 0
                               , 0
                               , Convert.ToDecimal(LBL_T_SERVICE.Text)
                               , "من حساب الزبون الى حساب الخدمات"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );
                                ////END
                                ////نهاية الخدمات#


                            }


                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , 111
                            , "الصندوق"
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_TOTAL.Text)
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
                            , "المريض"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_TOTAL.Text)
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );



                            //من المريض الى العمليات
                            //FROM
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                           (
                             BookId
                           , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                           , "المريض"
                           , 0
                           , 0
                           , Convert.ToDecimal(TXT_TOTAL.Text)
                           , 0
                           , "من حساب الزبون الى حساب العمليات"
                           , 1
                           , 1
                           , ref CLS.SUBMIT_FLAG
                            );

                            //TO


                            // var INSERTBOXDETSERTP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_TOTAL.Text)
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );
                        }

                        // اجل بدون نسبة
                        if (FLAG_CASH == 2)
                        {
                            // var INSERTBOXDETSERF = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                            , "المريض"
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_TOTAL.Text)
                            , 0
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );



                            //TO

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_TOTAL.Text)
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );




                        }

                        //جزئي بدون نسبة
                        if (FLAG_CASH == 3)
                        {
                            // var INSERTBOXDETSERF = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , 111
                            , "الصندوق"
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
                              BookId
                            , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                            , "المريض"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_PAID.Text)
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            //من المريض الى الخدمات
                            //FROM
                            // INSERTBOXDETSERFP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                            , "المريض"
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_PAID.Text)
                            , 0
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            //TO


                            // var INSERTBOXDETSERTP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_PAID.Text)
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );


                            //////////
                            ///


                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
(
 BookId
, Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
, "المريض"
, 0
, 0
, Convert.ToDecimal(TXT_REMAIN.Text)
, 0
, "من حساب الزبون الى حساب العمليات"
, 1
, 1
, ref CLS.SUBMIT_FLAG
);

                            //TO


                            // var INSERTBOXDETSERTP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_REMAIN.Text)
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            //////




                        }

                    }//نهاية النسبة#




                    //مع النسبة

                    if (DOCT_PRECENT > 0)
                    {
                        // TOTAL_PRICE = Convert.ToDecimal(LBL_TOTAL.Text) ;
                        //الخدمات#

                        if (Convert.ToDecimal(LBL_TOTAL_OP.Text) >= MINI_OP)
                        {
                            TOTAL_PRICE = Convert.ToDecimal(TXT_TOTAL.Text);
                            DebitPatient = TOTAL_PRICE;
                            CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                            CreditTakder = TOTAL_PRICE * TakderPrecentage / 100;
                            CreditService = TOTAL_PRICE - (CreditDoctor + CreditTakder);
                        }
                        else
                        {

                            TOTAL_PRICE = Convert.ToDecimal(TXT_TOTAL.Text);

                            DebitPatient = TOTAL_PRICE;
                            CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                            CreditTakder = TOTAL_PRICE * TakderPrecentage / 100;
                            CreditService = MINI_OP * ServicePrecentage / 100;
                        }



                        // نسبة#
                        //نقددداٌ  نسبة

                        if (FLAG_CASH == 1)
                        {


                            if (Convert.ToDecimal(LBL_T_SERVICE.Text) > 0)
                            {
                                // TOTAL_PRICE = Convert.ToDecimal(LBL_TOTAL.Text) ;
                                //الخدمات#

                                BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                          BOOK_CODE
                        , DT_NOW.Value
                        , "عن اجور عملية المريض: " + pERSON_NAMEComboBox.Text
                        , 18
                        , 0
                        , true
                        , CLS.USER_CODE
                        , ref CLS.SUBMIT_FLAG, CLS.BRANCH_ID,0
                        ).ToString());

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                   (
                                    BookId
                                   , 111
                                   , "الصندوق"
                                   , 0
                                   , 0
                                   , Convert.ToDecimal(LBL_T_SERVICE.Text)
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
                                , "المريض"
                                , 0
                                , 0
                                , 0
                                , Convert.ToDecimal(LBL_T_SERVICE.Text)
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );



                                //من المريض الى الخدمات
                                //FROM
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                 BookId
                               , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                               , "المريض"
                               , 0
                               , 0
                               , Convert.ToDecimal(LBL_T_SERVICE.Text)
                               , 0
                               , "من حساب الزبون الى حساب الخدمات"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );

                                // TO


                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                BookId
                               , 4002

                               , "الخدمات"
                               , 0
                               , 0
                               , 0
                               , Convert.ToDecimal(LBL_T_SERVICE.Text)
                               , "من حساب الزبون الى حساب الخدمات"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );
                                ////END
                                ////نهاية الخدمات#

                            }



                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
    (
     BookId
    , 111
    , "الصندوق"
    , 0
    , 0
    , Convert.ToDecimal(TXT_TOTAL.Text)
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
                            , "المريض"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_TOTAL.Text)
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );



                            //من المريض الى العمليات
                            //FROM
                            // INSERTBOXDETSERFP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                            , "المريض"
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_TOTAL.Text)
                            , 0
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            //TO


                            // var INSERTBOXDETSERTP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(CreditService)
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                          (
                           BookId
                          , DOCT_CODE
                          , "الدكتور"
                          , 0
                          , 0
                          , 0
                          , Convert.ToDecimal(CreditDoctor)
                          , "من حساب الزبون الى حساب العمليات"
                          , 1
                          , 1
                          , ref CLS.SUBMIT_FLAG
                           );
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                         (
                          BookId
                         , TAKDER_CODE
                         , "التخدير"
                         , 0
                         , 0
                         , 0
                         , Convert.ToDecimal(CreditTakder)
                         , "من حساب الزبون الى حساب العمليات"
                         , 1
                         , 1
                         , ref CLS.SUBMIT_FLAG
                          );


                        }

                        // اجل  نسبة
                        if (FLAG_CASH == 2)
                        {
                            // var INSERTBOXDETSERF = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                            , "المريض"
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_TOTAL.Text)
                            , 0
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );



                            //TO


                            // var INSERTBOXDETSERTP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(CreditService)
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                          (
                           BookId
                          , DOCT_CODE
                          , "الدكتور"
                          , 0
                          , 0
                          , 0
                          , Convert.ToDecimal(CreditDoctor)
                          , "من حساب الزبون الى حساب الدكتور"
                          , 1
                          , 1
                          , ref CLS.SUBMIT_FLAG
                           );
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                         (
                          BookId
                         , TAKDER_CODE
                         , "التخدير"
                         , 0
                         , 0
                         , 0
                         , Convert.ToDecimal(CreditTakder)
                         , "من حساب الزبون الى حساب التخدير"
                         , 1
                         , 1
                         , ref CLS.SUBMIT_FLAG
                          );




                        }

                        //جزئي بدون نسبة
                        if (FLAG_CASH == 3)
                        {


                            if (Convert.ToDecimal(LBL_TOTAL_OP.Text) >= MINI_OP)
                            {
                                TOTAL_PRICE = Convert.ToDecimal(TXT_PAID.Text);
                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditTakder = TOTAL_PRICE * TakderPrecentage / 100;
                                CreditService = TOTAL_PRICE - (CreditDoctor + CreditTakder);
                            }
                            else
                            {

                                TOTAL_PRICE = Convert.ToDecimal(TXT_PAID.Text);

                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditTakder = TOTAL_PRICE * TakderPrecentage / 100;
                                CreditService = MINI_OP * ServicePrecentage / 100;
                            }


                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
   (
    BookId
   , 111
   , "الصندوق"
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
                              BookId
                            , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                            , "المريض"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_PAID.Text)
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );



                            //من المريض الى العمليات
                            //FROM
                            // INSERTBOXDETSERFP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                            , "المريض"
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_PAID.Text)
                            , 0
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            //TO


                            // var INSERTBOXDETSERTP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(CreditService)
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                          (
                           BookId
                          , DOCT_CODE
                          , "الدكتور"
                          , 0
                          , 0
                          , 0
                          , Convert.ToDecimal(CreditDoctor)
                          , "من حساب الزبون الى حساب العمليات"
                          , 1
                          , 1
                          , ref CLS.SUBMIT_FLAG
                           );
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                         (
                          BookId
                         , TAKDER_CODE
                         , "التخدير"
                         , 0
                         , 0
                         , 0
                         , Convert.ToDecimal(CreditTakder)
                         , "من حساب الزبون الى حساب العمليات"
                         , 1
                         , 1
                         , ref CLS.SUBMIT_FLAG
                          );



                            //////
                            ///

                            if (Convert.ToDecimal(LBL_TOTAL_OP.Text) >= MINI_OP)
                            {
                                TOTAL_PRICE = Convert.ToDecimal(TXT_REMAIN.Text);
                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditTakder = TOTAL_PRICE * TakderPrecentage / 100;
                                CreditService = TOTAL_PRICE - (CreditDoctor + CreditTakder);
                            }
                            else
                            {

                                TOTAL_PRICE = Convert.ToDecimal(TXT_REMAIN.Text);

                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditTakder = TOTAL_PRICE * TakderPrecentage / 100;
                                CreditService = MINI_OP * ServicePrecentage / 100;
                            }


                            // var INSERTBOXDETSERF = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                            , "المريض"
                            , 0
                            , 0
                            , Convert.ToDecimal(TXT_REMAIN.Text)
                            , 0
                            , "من حساب الزبون الى حساب مذكورين"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );



                            //TO


                            // var INSERTBOXDETSERTP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookId
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(CreditService)
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                          (
                           BookId
                          , DOCT_CODE
                          , "الدكتور"
                          , 0
                          , 0
                          , 0
                          , Convert.ToDecimal(CreditDoctor)
                          , "من حساب الزبون الى حساب الدكتور"
                          , 1
                          , 1
                          , ref CLS.SUBMIT_FLAG
                           );
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                         (
                          BookId
                         , TAKDER_CODE
                         , "التخدير"
                         , 0
                         , 0
                         , 0
                         , Convert.ToDecimal(CreditTakder)
                         , "من حساب الزبون الى حساب التخدير"
                         , 1
                         , 1
                         , ref CLS.SUBMIT_FLAG
                          );





                        }

                    }//نهاية النسبة#


                    //نهاية النسبة







                    // Cursor.Current = Cursors.WaitCursor;
                    // CLS.ID_BOOK_PRINT = Convert.ToInt32(TXT_ID_BOOK.Text);

                    if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                    {
                        //    MessageBox.Show("حدد الطابعة أولا");
                        //    SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                        //    FRM.ShowDialog();
                        //    return;

                        //}
                        ////  BTN_SAVEE_Click(null, null);

                        //HOSPITAL.PRINT.FRM_PRINT_SANA_INCOME myfrrm = new HOSPITAL.PRINT.FRM_PRINT_SANA_INCOME();
                        //HOSPITAL.PRINT.RPT_SANAD_INCOME mmprt = new HOSPITAL.PRINT.RPT_SANAD_INCOME();
                        //PrinterSettings settings = new PrinterSettings();
                        //SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString);
                        //string ServerName = SqlConnectionStringBuilder.DataSource;
                        //string DatabaseName = SqlConnectionStringBuilder.InitialCatalog;
                        //Boolean IntegratedSecurity = SqlConnectionStringBuilder.IntegratedSecurity;
                        //string UserID = SqlConnectionStringBuilder.UserID;
                        //string Password = SqlConnectionStringBuilder.Password;

                        //foreach (CrystalDecisions.CrystalReports.Engine.Table Table in mmprt.Database.Tables)
                        //{
                        //    CrystalDecisions.Shared.TableLogOnInfo TableLogOnInfo = Table.LogOnInfo;
                        //    TableLogOnInfo.ConnectionInfo.ServerName = ServerName;
                        //    TableLogOnInfo.ConnectionInfo.DatabaseName = DatabaseName;
                        //    TableLogOnInfo.ConnectionInfo.IntegratedSecurity = IntegratedSecurity;

                        //    if (IntegratedSecurity != true)
                        //    {
                        //        TableLogOnInfo.ConnectionInfo.UserID = UserID;
                        //        TableLogOnInfo.ConnectionInfo.Password = Password;
                        //    }
                        //    Table.ApplyLogOnInfo(TableLogOnInfo);
                        //}
                        ////  mmprt.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DataBase, Properties.Settings.Default.ID, Properties.Settings.Default.Password);

                        //// mmprt.SetParameterValue("@ID_BOOK", CLS.ID_BOOK_PRINT);
                        //// mmprt.SetParameterValue("@DOCT_CODE", CLS.USER_CODE);
                        //mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                        //DataTable DTDATA = new DataTable();
                        //this.gET_H_PERSON_BOOKING_SANAD_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_SANAD_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(op_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));

                        //DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_SANAD_ID;


                        //// mmprt.Subreports[0].SetDataSource(DTHDR); 
                        //mmprt.SetDataSource(DTDATA);
                        //myfrrm.crystalReportViewer1.ReportSource = mmprt;

                        //mmprt.PrintToPrinter(1, false, 0, 0);

                        // Cursor.Current = Cursors.Default;

                        MSG.Msg.Alart(AlartType.Save);
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }


            }
        }

        

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_PERSON_BOOKING_SANAD_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_SANAD_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType( BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType( 2, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void TXT_PAID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (CLS.F_SEARCH_PAID != 1)
                //{


                var origText = this.TXT_PAID.Text;

                this.TXT_PAID.Text = Convert.ToDecimal(this.TXT_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PAID.SelectionStart = TXT_PAID.TextLength;
                TXT_REMAIN.Text = (Convert.ToDecimal(TXT_TOTAL.Text) - Convert.ToDecimal(TXT_PAID.Text)).ToString();

                // }
            }
            catch
            {
                return;
            }
        }
    }
}
