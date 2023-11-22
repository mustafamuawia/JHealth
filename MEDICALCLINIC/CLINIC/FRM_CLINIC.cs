
using MEDICALCLINIC.HOSPITAL.PRINT;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace MEDICALCLINIC.CLINIC
{
    public partial class FRM_CLINIC :MEDICALCLINIC. SETTING.baseclinicanddental
    {

        Decimal DR_OPPERCENT;
        int cost_center_code;
        int F_PAY = 0, BookIdS;
        List<string> PayList;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        Decimal DoctorPrecentage;
        public FRM_CLINIC()
        {
            InitializeComponent();
           
        }



        private void FRM_CLINIC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_ALL_CASE_IS_COMP' table. You can move, or remove it, as needed.
         
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            this.v_GET_ALL_CASE_IS_COMPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_ALL_CASE_IS_COMP);
            this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 4);
            this.t_RPT_IMGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.T_RPT_IMG);
            this.v_GET_A_RAY_NAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_RAY_NAME);
            this.v_GET_A_ROOMRAYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_ROOMRAY);
            this.v_L_GET_A_LABNAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_L_GET_A_LABNAME);
            this.v_GET_A_L_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG);
            this.gET_REGION_BODY_CODENAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_REGION_BODY_CODENAME, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
            PayList = new List<string>();
            //if (Properties.Settings.Default.COST_CENTER_TYPE == 1)
            //{
            //    cost_center_code = CLS.Cost_Center_WARD_DR;
            //}
           int c= Properties.Settings.Default.COST_CENTER_TYPE;
            cost_center_code = CLS.Cost_Center_WARD_DR;

            //label15.Text = cost_center_code.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DIAGNOSES.FRM_SHOW_ALL_BOOKING FRM = new DIAGNOSES.FRM_SHOW_ALL_BOOKING();

            FRM.ShowDialog();
            gET_BOOKING_BY_ID_PER_DOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT, CLS.USER_CODE, CLS.ID_PERSON_IMG, System.DateTime.Now);

        }

        private void BTN_OPERATION_Click(object sender, EventArgs e)
        {
            if (TXT_ID_PERSON.Text == String.Empty)
            {
                MessageBox.Show("فضلا قم بأختيار مريض اولا");
                return;
            }
            else
            {
                CLS.ID_BOOKING_IMG = Convert.ToInt32(TXT_ID_BOOK.Text);
                CLS.ID_PERSON_IMG = Convert.ToInt32(TXT_ID_PERSON.Text);
                CLS.PERSON_NAME_IMGE = TXT_PERSON.Text;
                DIAGNOSES.FRM_OPERTION_PRICE FRM = new DIAGNOSES.FRM_OPERTION_PRICE();
                FRM.ShowDialog();
            }
        }

        private void btn_medical_history_Click(object sender, EventArgs e)
        {

            try
            {
                if (TXT_ID_PERSON.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا حدد المريض اولا .واعد المحاولة");
                    return;
                }
                else
                {
                    PERSONS.FRM_MEDICAL_HISTORY frm = new PERSONS.FRM_MEDICAL_HISTORY(Convert.ToInt32(TXT_ID_PERSON.Text));
                    frm.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {


            try
            {

                if (TXT_ID_PERSON.Text == string.Empty || TXT_ID_BOOK.Text == string.Empty)
                {
                    MessageBox.Show("يرجى أختيار مريض أولا");
                    return;
                }


                if (TXT_TOTAL_OP.Text != "0")
                {
                    if (F_PAY == 0)
                    {
                        MessageBox.Show("يرجى تحديد نوع الدفع أولا");
                        return;
                    }
                }

                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("حدد الطابعة أولا");
                    SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                    FRM.ShowDialog();
                }
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                if (TXT_ID_PERSON.Text == string.Empty || TXT_ID_BOOK.Text == string.Empty)
                {
                    errorProvider1.SetError(TXT_PERSON, CLS.TXT_NULL);
                }


                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {
                  //  this.gET_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                   /* Program.bookingDoctorService.Book(new Services.BookParamters()
                    {
                        _ACTIVE_BOOKING = true,
                        _BOOKING_CODE = TXT_ID_BOOK.Text.ToInt(),
                        _BOOKING_TYPE = TXT_BOOK_TYPE.Text,
                        _CHECKED_DOC = true,
                        _DESCRPTION = TXT_DESC.Text,
                        _DISEASE_TYPE = TXT_DISEASE.Text,
                        _DOCTOR_CODE = CLS.USER_CODE.ToInt(),
                        _DRAGE_NAME = TXT_DRAGE.Text,
                        _ENTER_TO_DOC = true,
                        _PERSON_CODE = TXT_ID_PERSON.Text.ToInt(),
                        _PRICE_OP = TXT_TOTAL_OP.Text,
                        _STATE_NAME = TXT_STATE.Text,
                        _SUBMIT_FLAG = 1

                    });*/
                    INSERTED.P_UPDATE_T_BOOKING_DOCT(Convert.ToInt32(TXT_ID_BOOK.Text)
                        , Convert.ToInt32(TXT_ID_PERSON.Text)
                        , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                        , TXT_BOOK_TYPE.Text
                        , TXT_DISEASE.Text
                        , TXT_DESC.Text
                        , TXT_STATE.Text
                        , TXT_DRAGE.Text
                        , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                        , true
                        , true
                        , true
                        ,nAME_IS_COMPComboBox.SelectedValue.ToInt()
                        , ref CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        //var UPD_ADV = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //UPD_ADV.P_UDATE_T_BOOKING_T_ADS(Convert.ToInt32(TXT_ID_BOOK.Text), true);
                        //TXT_ORDER.Text = string.Empty;
                        // MSG.Msg.Alart(AlartType.Save);
                        //var UPD = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //UPD.P_UDATE_T_BOOKING_T_PERSON(Convert.ToInt32(TXT_ID_BOOK.Text), CLS.USER_CODE, true, false);
                        //this.gET_BOOKING_BY_ID_PER_DOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT, Convert.ToInt32(CLS.USER_CODE), Convert.ToInt32(TXT_ID_PERSON.Text), System.DateTime.Now);
                        //dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT;
                        var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        Decimal DoctorPrecentage;
                        if (TXT_TOTAL_OP.Text != String.Empty || TXT_TOTAL_OP.Text != "")
                        {
                           

                            if (TXT_PAID.Text == String.Empty || TXT_PAID.Text == "")
                            {
                                TXT_PAID.Text = "0";
                            }

                            
                            this.gET_DOCTOR_BY_USERCODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_USERCODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                            DR_OPPERCENT = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_USERCODE.Rows[0][10].ToString());
                            DoctorPrecentage = DR_OPPERCENT;
                            decimal TOTAL_PRICE = Convert.ToDecimal(TXT_TOTAL_OP.Text);
                            decimal DebitPatient = 0;
                            decimal CreditService = 0;
                            decimal CreditDoctor = 0;
                            var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            if (DR_OPPERCENT > 0)
                            {



                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditService = TOTAL_PRICE - CreditDoctor;



                                BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                            Convert.ToInt32(TXT_ID_BOOK.Text)
                                          , System.DateTime.Now
                                          , "عن اجور عمليات "
                                          , 19
                                          , 0
                                          , true
                                          , CLS.USER_CODE
                                          , ref CLS.SUBMIT_FLAG
                                          , CLS.BRANCH_ID
                                          , cost_center_code
                                          ).ToString());

                                if (F_PAY == 1)
                                {
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , 111
                                                    , " اجور  عملية"
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
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                     , " اجور  عملية"
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
                                     , Convert.ToInt32(TXT_ID_PERSON.Text)
                                      , " اجور  عملية"
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
                                  , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                   , " اجور  عملية"
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
                                   , 4004
                                   , " اجور  عملية"
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
                                if (F_PAY == 2)
                                {
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                                    , " اجور  عملية"
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
                                    , 4004
                                     , " اجور  عملية"
                                    , 0
                                    , 0
                                    , 0
                                    , CreditService
                                    , "من حساب الزبون الى حساب العمليات"
                                    , 1
                                    , 1
                                    , ref CLS.SUBMIT_FLAG
                                     );
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                 BookIdS
                               , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                , " اجور  عملية"
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
                                if (F_PAY == 3)
                                {
                                    //جزء النقدي من الجزئي
                                    DoctorPrecentage = DR_OPPERCENT;
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
                                                    , " اجور  عملية"
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
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                     , " اجور  عملية"
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
                                     , Convert.ToInt32(TXT_ID_PERSON.Text)
                                      , " اجور  عملية"
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
                                  , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                   , " اجور  عملية"
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
                                   , 4004
                                   , " اجور  عملية"
                                   , 0
                                   , 0
                                   , 0
                                   , CreditService
                                   , "من حساب الزبون الى حساب العمليات"
                                   , 1
                                   , 1
                                   , ref CLS.SUBMIT_FLAG
                                    );


                                    //الجزء الاجل من الجزئي


                                    DoctorPrecentage = DR_OPPERCENT;
                                    TOTAL_PRICE = Convert.ToDecimal(TXT_REMAIN.Text);
                                    DebitPatient = 0;
                                    CreditService = 0;
                                    CreditDoctor = 0;

                                    DebitPatient = TOTAL_PRICE;
                                    CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                    CreditService = TOTAL_PRICE - CreditDoctor;

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                                    , " اجور  عملية"
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
                                  , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                   , " اجور  عملية"
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
                                   , 4004
                                   , " اجور  عملية"
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
                            if (DR_OPPERCENT == 0)
                            {



                                BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                            Convert.ToInt32(TXT_ID_BOOK.Text)
                                          , System.DateTime.Now
                                          , "عن اجور العمليات "
                                          , 19
                                          , 0
                                          , true
                                          , CLS.USER_CODE
                                          , ref CLS.SUBMIT_FLAG
                                          , CLS.BRANCH_ID
                                          , cost_center_code
                                          ).ToString());

                                if (F_PAY == 1)
                                {
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , 111
                                                    , " اجور  عملية"
                                                    , 0
                                                    , 0
                                                    , Convert.ToDecimal(TXT_TOTAL_OP.Text)
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
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                     , " اجور  عملية"
                                    , 0
                                    , 0
                                    , 0
                                    , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                    , "من حساب الزبون الى حساب الصندوق"
                                    , 1
                                    , 1
                                    , ref CLS.SUBMIT_FLAG
                                     );
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                     (
                                       BookIdS
                                     , Convert.ToInt32(TXT_ID_PERSON.Text)
                                      , " اجور  عملية"
                                     , 0
                                     , 0
                                     , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                     , 0
                                     , "من حساب الزبون الى حساب الصندوق"
                                     , 1
                                     , 1
                                     , ref CLS.SUBMIT_FLAG
                                      );

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                  (
                                    BookIdS
                                  , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                   , " اجور  عملية"
                                  , 0
                                  , 0
                                  , 0
                                  , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                  , "من حساب الزبون الى حساب الدكتور"
                                  , 1
                                  , 1
                                  , ref CLS.SUBMIT_FLAG
                                   );












                                }
                                if (F_PAY == 2)
                                {
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                                    , " اجور  عملية"
                                                    , 0
                                                    , 0
                                                    , Convert.ToDecimal(TXT_TOTAL_OP.Text)
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
                               , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                , " اجور  عملية"
                               , 0
                               , 0
                               , 0
                               , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                               , "من حساب الزبون الى حساب الدكتور"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );
                                }


                                if (F_PAY == 3)
                                {



                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                     (
                                       BookIdS
                                     , Convert.ToInt32(TXT_ID_PERSON.Text)
                                      , " اجور  عملية"
                                     , 0
                                     , 0
                                     , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                     , 0
                                     , "من حساب الزبون الى حساب الصندوق"
                                     , 1
                                     , 1
                                     , ref CLS.SUBMIT_FLAG
                                      );

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                  (
                                    BookIdS
                                  , Convert.ToInt32(CLS.USER_CODE)
                                   , " اجور  عملية"
                                  , 0
                                  , 0
                                  , 0
                                  , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                  , "من حساب الزبون الى حساب الدكتور"
                                  , 1
                                  , 1
                                  , ref CLS.SUBMIT_FLAG
                                   );





                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                   (
                                                    BookIdS
                                                   , 111
                                                   , " اجور  عملية"
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
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                     , " اجور  عملية"
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
                            //Cursor.Current = Cursors.WaitCursor;
                            //CLS.ID_BOOK_PRINT = Convert.ToInt32(TXT_ID_BOOK.Text);
                            //PRINT.CLINICPRINT.FRM_PRINT_bOOK myfrrm = new PRINT.CLINICPRINT.FRM_PRINT_bOOK();
                            //PRINT.CLINICPRINT.CR_RPT_CLINIC_RACHITA mmprt = new PRINT.CLINICPRINT.CR_RPT_CLINIC_RACHITA();
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

                            //// mmprt.SetParameterValue("@ID_BOOK", CLS.ID_BOOK_PRINT);
                            //// mmprt.SetParameterValue("@DOCT_CODE", CLS.USER_CODE);
                            //mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                            //DataTable DTDATA = new DataTable();
                            //DataTable DTIMG = new DataTable();
                            //this.p_PRINT_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_PRINT_BOOKING, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_BOOK.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                            //DTDATA = this.mEDICAL_CLINIC_DBDataSet.P_PRINT_BOOKING;
                            //this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 2);
                            //DTIMG = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                            //mmprt.Load("MEDICALCLINIC.PRINT.CLINICPRINT.CR_RPT_CLINIC_RACHITA.rpt");

                            ////mmprt.Subreports[0].SetDataSource(DTIMG);//lصدر بيانات الجدول الاخر
                            //mmprt.SetDataSource(DTDATA);//lصدر بيانات الصورة

                            //FieldObject fieldD;
                            //FontDialog fieldFont = new FontDialog();

                            //fieldD =mmprt.ReportDefinition.ReportObjects["DOCTORNAME1"] as FieldObject;
                            //fieldD.Left = 9792;
                            //fieldD.Top = 3000;

                            //FieldObject fieldD1;
                            //FontDialog fieldFont1 = new FontDialog();

                            //fieldD1 = mmprt.ReportDefinition.ReportObjects["PERSONNAME1"] as FieldObject;
                            //fieldD1.Left = 500;
                            //fieldD1.Top = 3000;

                            //CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
                            //txtReportHeader = mmprt.ReportDefinition.ReportObjects["Text23"] as TextObject;
                            //txtReportHeader.Text = "baemText";
                            //txtReportHeader.Left = 1500;
                            //txtReportHeader.Top = 1500;

                            //mmprt.PrintToPrinter(1, true, 0, 0);
                            //myfrrm.crystalReportViewer2.ReportSource = mmprt;
                            //myfrrm.crystalReportViewer2.RefreshReport();
                            //myfrrm.ShowDialog();


                            //Cursor.Current = Cursors.Default;








                            this.p_PRINT_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_PRINT_BOOKING, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_BOOK.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                            dt = this.mEDICAL_CLINIC_DBDataSet.P_PRINT_BOOKING;
                            this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                            dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                            LocalReport lr = new LocalReport();
                            lr.ReportEmbeddedResource = "MEDICALCLINIC.PRINT.CLINICPRINT.RPT_CLINIC_BOOKING.rdlc";
                            lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                            lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                            lr.Print();







                            //this.gET_H_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                            //LBL_PAST_BORROW.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();

                        }
                        MSG.Msg.Alart(AlartType.Save);
                    }

                    CLEARFORM();

                }
              
            }
            catch (Exception EX)
            {
                 MessageBox.Show(EX.Message);
            }
        }
        void CLEARFORM()
        {
          
            TXT_DESC.Text = "";
            TXT_STATE.Text = "";
            TXT_DRAGE.Text = "";
            TXT_EXPENSE.Text = "0";
            TXT_ID_BOOK.Text = "";
            TXT_ID_PERSON.Text = "";
            TXT_PAID.Text = "";
            TXT_REMAIN.Text = "0";
            TXT_TOTAL_OP.Text = "0";
            TXT_BOOK_TYPE.Text = ".................";
            LBL_KSH_TYP.Text = ".................";
            LBL_SEX.Text = ".................";
            LBL_AGE.Text = ".................";
            TXT_PERSON.Text = ".................";
            F_PAY = 0;
            dataGridView1.DataSource = null;
            BTN_CASH.BackColor = Color.FromArgb(16, 127, 201);
            BTN_NO_CASH.BackColor = Color.FromArgb(16, 127, 201);
            BTN_PARTIAL_CASH.BackColor = Color.FromArgb(16, 127, 201);



        }
        private void BTN_SAVEE_Click(object sender, EventArgs e)
        {
            try
            {  
            if (TXT_ID_PERSON.Text == string.Empty || TXT_ID_BOOK.Text== string.Empty)
                {
                    MessageBox.Show("يرجى أختيار مريض أولا");
                    return;
                }

                if ( TXT_TOTAL_OP.Text.ToDecimal()>0 )
                {
                    if (F_PAY == 0){
  
                    MessageBox.Show("يرجى تحديد نوع الدفع أولا");
                    return;
                    }
                 
                }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();



                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    /* Program.bookingDoctorService.Book(new Services.BookParamters()
                     {
                         _ACTIVE_BOOKING = true,
                         _BOOKING_CODE = TXT_ID_BOOK.Text.ToInt(),
                         _BOOKING_TYPE = TXT_BOOK_TYPE.Text,
                         _CHECKED_DOC = true,
                         _DESCRPTION = TXT_DESC.Text,
                         _DISEASE_TYPE = TXT_DISEASE.Text,
                         _DOCTOR_CODE = CLS.USER_CODE.ToInt(),
                         _DRAGE_NAME = TXT_DRAGE.Text,
                         _ENTER_TO_DOC = true,
                         _PERSON_CODE = TXT_ID_PERSON.Text.ToInt(),
                         _PRICE_OP = TXT_TOTAL_OP.Text,
                         _STATE_NAME = TXT_STATE.Text,
                         _SUBMIT_FLAG = 1

                     });
                     */

                    // this.gET_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));

                    INSERTED.P_UPDATE_T_BOOKING_DOCT(
                          Convert.ToInt32(TXT_ID_BOOK.Text)
                        , Convert.ToInt32(TXT_ID_PERSON.Text)
                        , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                        , TXT_BOOK_TYPE.Text
                        , TXT_DISEASE.Text
                        , TXT_DESC.Text
                        , TXT_STATE.Text
                        , TXT_DRAGE.Text
                        , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                        , true
                        , true
                        , true
                        , nAME_IS_COMPComboBox.SelectedValue.ToInt()
                        , ref CLS.SUBMIT_FLAG) ;

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        //if (Properties.Settings.Default.COST_CENTER_TYPE == 0)
                        //{
                        //    cost_center_code = 110001;
                        //}

                        //var UPD_ADV = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //UPD_ADV.P_UDATE_T_BOOKING_T_ADS(Convert.ToInt32(TXT_ID_BOOK.Text), true);
                        //TXT_ORDER.Text = string.Empty;
                        // MSG.Msg.Alart(AlartType.Save);
                        //var UPD = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //UPD.P_UDATE_T_BOOKING_T_PERSON(Convert.ToInt32(TXT_ID_BOOK.Text), CLS.USER_CODE, true, false);
                        //this.gET_BOOKING_BY_ID_PER_DOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT, Convert.ToInt32(CLS.USER_CODE), Convert.ToInt32(TXT_ID_PERSON.Text), System.DateTime.Now);
                        //dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT;
                        var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                      
                        if (TXT_TOTAL_OP.Text.ToDecimal()>0)
                        {
                            

                            if (TXT_PAID.Text == String.Empty || TXT_PAID.Text == "")
                            {
                                TXT_PAID.Text = "0";
                            }

                            //if (TXT_REMAIN.Text == String.Empty || TXT_REMAIN.Text == "")
                            //{
                            //    TXT_REMAIN.Text = "0";
                            //}
                            this.gET_DOCTOR_BY_USERCODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_USERCODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                            DR_OPPERCENT = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_USERCODE.Rows[0][10].ToString());
                            DoctorPrecentage = DR_OPPERCENT;
                            decimal TOTAL_PRICE = Convert.ToDecimal(TXT_TOTAL_OP.Text);
                            decimal DebitPatient = 0;
                            decimal CreditService = 0;
                            decimal CreditDoctor = 0;
                            var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            if (DR_OPPERCENT > 0)
                            {



                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditService = TOTAL_PRICE - CreditDoctor;



                                BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                            Convert.ToInt32(TXT_ID_BOOK.Text)
                                          , System.DateTime.Now
                                          , "عن اجور عمليات "
                                          , 19
                                          , 0
                                          , true
                                          , CLS.USER_CODE
                                          , ref CLS.SUBMIT_FLAG
                                          , CLS.BRANCH_ID
                                          , cost_center_code
                                          ).ToString());

                                if (F_PAY == 1)
                                {
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , 111
                                                    , " اجور  عملية"
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
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                     , " اجور  عملية"
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
                                     , Convert.ToInt32(TXT_ID_PERSON.Text)
                                      , " اجور  عملية"
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
                                  , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                   , " اجور  عملية"
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
                                   , 4004
                                   , " اجور  عملية"
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
                                if (F_PAY == 2)
                                {
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                                    , " اجور  عملية"
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
                                    , 4004
                                     , " اجور  عملية"
                                    , 0
                                    , 0
                                    , 0
                                    , CreditService
                                    , "من حساب الزبون الى حساب العمليات"
                                    , 1
                                    , 1
                                    , ref CLS.SUBMIT_FLAG
                                     );
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                 BookIdS
                               , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                , " اجور  عملية"
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
                                if (F_PAY == 3)
                                {
                                    //جزء النقدي من الجزئي
                                    DoctorPrecentage = DR_OPPERCENT;
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
                                                    , " اجور  عملية"
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
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                     , " اجور  عملية"
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
                                     , Convert.ToInt32(TXT_ID_PERSON.Text)
                                      , " اجور  عملية"
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
                                  , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                   , " اجور  عملية"
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
                                   , 4004
                                   , " اجور  عملية"
                                   , 0
                                   , 0
                                   , 0
                                   , CreditService
                                   , "من حساب الزبون الى حساب العمليات"
                                   , 1
                                   , 1
                                   , ref CLS.SUBMIT_FLAG
                                    );


                                    //الجزء الاجل من الجزئي


                                    DoctorPrecentage = DR_OPPERCENT;
                                    TOTAL_PRICE = Convert.ToDecimal(TXT_REMAIN.Text);
                                    DebitPatient = 0;
                                    CreditService = 0;
                                    CreditDoctor = 0;

                                    DebitPatient = TOTAL_PRICE;
                                    CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                    CreditService = TOTAL_PRICE - CreditDoctor;

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                                    , " اجور  عملية"
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
                                  , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                   , " اجور  عملية"
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
                                   , 4004
                                   , " اجور  عملية"
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
                            if (DR_OPPERCENT == 0)
                            {



                                BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                            Convert.ToInt32(TXT_ID_BOOK.Text)
                                          , System.DateTime.Now
                                           , "عن اجور العمليات "
                                          , 19
                                          , 0
                                          , true
                                          , CLS.USER_CODE
                                          , ref CLS.SUBMIT_FLAG
                                          , CLS.BRANCH_ID
                                          , cost_center_code
                                          ).ToString());

                                if (F_PAY == 1)
                                {
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , 111
                                                    , " اجور  عملية"
                                                    , 0
                                                    , 0
                                                    , Convert.ToDecimal(TXT_TOTAL_OP.Text)
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
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                     , " اجور  عملية"
                                    , 0
                                    , 0
                                    , 0
                                    , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                    , "من حساب الزبون الى حساب الصندوق"
                                    , 1
                                    , 1
                                    , ref CLS.SUBMIT_FLAG
                                     );
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                     (
                                       BookIdS
                                     , Convert.ToInt32(TXT_ID_PERSON.Text)
                                      , " اجور  عملية"
                                     , 0
                                     , 0
                                     , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                     , 0
                                     , "من حساب الزبون الى حساب الصندوق"
                                     , 1
                                     , 1
                                     , ref CLS.SUBMIT_FLAG
                                      );

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                  (
                                    BookIdS
                                  , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                                   , " اجور  عملية"
                                  , 0
                                  , 0
                                  , 0
                                  , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                  , "من حساب الزبون الى حساب الدكتور"
                                  , 1
                                  , 1
                                  , ref CLS.SUBMIT_FLAG
                                   );












                                }
                                if (F_PAY == 2)
                                {
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                    (
                                                     BookIdS
                                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                                    , " اجور  عملية"
                                                    , 0
                                                    , 0
                                                    , Convert.ToDecimal(TXT_TOTAL_OP.Text)
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
                               , CLS.USER_CODE
                                , " اجور  عملية"
                               , 0
                               , 0
                               , 0
                               , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                               , "من حساب الزبون الى حساب الدكتور"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );
                                }


                                if (F_PAY == 3)
                                {



                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                     (
                                       BookIdS
                                     , Convert.ToInt32(TXT_ID_PERSON.Text)
                                      , " اجور  عملية"
                                     , 0
                                     , 0
                                     , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                     , 0
                                     , "من حساب الزبون الى حساب الدكتور"
                                     , 1
                                     , 1
                                     , ref CLS.SUBMIT_FLAG
                                      );

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                  (
                                    BookIdS
                                  , Convert.ToInt32(CLS.USER_CODE)
                                  , " اجور  عملية"
                                  , 0
                                  , 0
                                  , 0
                                  , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                                  , "من حساب الزبون الى حساب الدكتور"
                                  , 1
                                  , 1
                                  , ref CLS.SUBMIT_FLAG
                                   );





                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                   (
                                                    BookIdS
                                                   , 111
                                                   , " اجور  عملية"
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
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                     , " اجور  عملية"
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

                            //this.gET_H_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                            //LBL_PAST_BORROW.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();

                        }
                        MSG.Msg.Alart(AlartType.Save);
                    }

                    CLEARFORM();

                }

               
                }
            catch (Exception EX)
            {
                 MessageBox.Show(EX.Message);
            }
        }

        private void BTN_IMAGE_Click(object sender, EventArgs e)
        {
            try
            {
                CLS.ID_PERSON_IMG = Convert.ToInt32(TXT_ID_PERSON.Text);
                CLS.ID_DOCTOR_IMG = Convert.ToInt32(TXT_ID_DOCTOR.Text);
                CLS.ID_BOOKING_IMG = Convert.ToInt32(TXT_ID_BOOK.Text);
                CLS.PERSON_NAME_IMGE = TXT_PERSON.Text;
                FRM_IMGE_PRSN FRM = new FRM_IMGE_PRSN();
                FRM.ShowDialog();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("رجاءا اختر تفاصيل المريض اولا");
            }
        }

        private void BTN_CONVERT_TO_Click(object sender, EventArgs e)
        {
            PERSONS.FRM_CONVERT_TO_DOCT FRM = new PERSONS.FRM_CONVERT_TO_DOCT( CLS.USER_CODE.ToInt(), Convert.ToInt32(TXT_ID_PERSON.Text), TXT_ID_BOOK.Text.ToInt());
            FRM.ShowDialog();
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_DRAGE_Click(object sender, EventArgs e)
        {
            CR_BUTTONS.FRM_DRAGE FRM = new CR_BUTTONS.FRM_DRAGE(1);
            FRM.ShowDialog();
        }

        private void BTN_STATE_Click(object sender, EventArgs e)
        {
            CR_BUTTONS.FRM_STATE FRM = new CR_BUTTONS.FRM_STATE();
            FRM.ShowDialog();
        }

        private void BTN_OPER_Click(object sender, EventArgs e)
        {

            CR_BUTTONS.FRM_DES FRM = new CR_BUTTONS.FRM_DES();
            FRM.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == 0)
                {


                    ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value),1);
                    FRM.ShowDialog();
                    //this.p_GET_IMG_BY_CODE_BOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BY_CODE_BOOK, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView1.CurrentRow.Cells[2].Value, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView1.CurrentRow.Cells[3].Value, typeof(int))))));

                    //if (this.mEDICAL_CLINIC_DBDataSet.P_GET_IMG_BY_CODE_BOOK.Rows.Count > 0)
                    //{
                    //    CLS.CODE_PER_IMG = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    //    CLS.CODE_BOOK_IMG = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    //    DIAGNOSES.FRM_IMG_PER_BOOK FRM = new DIAGNOSES.FRM_IMG_PER_BOOK();
                    //    FRM.ShowDialog();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("الحجز الحالي لايحتوي على صور");
                    //    return;
                    //}
                }
                if (e.ColumnIndex == 1)
                {


                    this.p_GET_ORDER_DETAILS_FOR_EDIT_BY_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_DETAILS_FOR_EDIT_BY_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(dataGridView1.CurrentRow.Cells[2].Value, typeof(int))))));

                    DataTable dt = new DataTable();

                    dt = this.mEDICAL_CLINIC_DBDataSet.P_GET_ORDER_DETAILS_FOR_EDIT_BY_ID;
                    if (dt.Rows.Count > 0)
                    {
                        CLS.wich_op_img = 9;
                        SELAS.FRM_SEALS frm = new SELAS.FRM_SEALS(dt, CLS.wich_op_img);
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("الحجز الحالي لايحتوي على مبيعات");
                        return;
                    }



                }



                if (e.ColumnIndex > 1 || e.ColumnIndex < 16)
                {
                    DataTable dt = new DataTable();
                    DataTable dt_new = new DataTable();
                    int DOC_CODE = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    TXT_ID_PERSON.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    TXT_ID_BOOK.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    gET_ORDER_BY_BOOKING_NUMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ORDER_BY_BOOKING_NUM, Convert.ToInt32(TXT_ID_BOOK.Text), DOC_CODE);
                    dt = this.mEDICAL_CLINIC_DBDataSet.GET_ORDER_BY_BOOKING_NUM;

                    TXT_ID_DOCTOR.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    TXT_PERSON.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    LBL_AGE.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    LBL_SEX.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    TXT_DESC.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
                    TXT_STATE.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
                    TXT_DRAGE.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
                    TXT_DISEASE.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    TXT_BOOK_TYPE.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();

                    bool PY_STATE = Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells[11].Value);
                    if (PY_STATE == true)
                    {
                        LBL_KSH_TYP.Text = "مدفوع";
                    }
                    else
                    {
                        LBL_KSH_TYP.Text = "غير مدفوع";
                    }
                    DateTime DATE_CHEK_OP = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[9].Value);
                    bool OPERT_BOOL = Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells[20].Value);

                    //if (OPERT_BOOL == true)
                    //{
                    //    LBL_OPERTION_PRICE.Visible = true;
                    //    label10.Visible = true;
                    //    LBL_OPERTION_PRICE.Text = this.dataGridView1.CurrentRow.Cells[19].Value.ToString();
                    //}
                    //else
                    //{
                    //    LBL_OPERTION_PRICE.Visible = false;
                    //    label10.Visible = false;
                    //}





                    // }
                    //LBL_PAST_BORROW.Text = "0.00";

                    TXT_ORDER.Text = string.Empty;






                }
            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sales_clinic_Click(object sender, EventArgs e)
        {


            try
            {
                if (TXT_ID_PERSON.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا حدد المريض اولا .واعد المحاولة");
                    return;
                }
                else
                {

                    DataTable dt = new DataTable();
                    dt = null;
                    CLS.CODE_PER_IMG = Convert.ToInt32(TXT_ID_PERSON.Text);

                    SELAS.FRM_SEALS FRM = new SELAS.FRM_SEALS(dt, 10);
                    FRM.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        

        private void BTN_SEARCH_ALL_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_H_ALL_TESTS_FOR_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_H_ALL_TESTS_FOR_PERSON, "1", new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATET1.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTESTPERSON_FOR_DOCTORY, TXT_ID_PERSON.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void BTN_SEARCH_TESTNAME_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_H_ALL_TESTS_FOR_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_H_ALL_TESTS_FOR_PERSON, "2", new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATET1.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTESTPERSON_FOR_DOCTORY, TXT_ID_PERSON.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_TESTComboBox1.SelectedValue, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show("يرجى تحديد اسم التحليل اولا");
            //}
        }

        private void BTN_SEARCH_DATE_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTESTPERSON_FOR_DOCTORY, TXT_ID_PERSON.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATET1.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ADD_GRD_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count; i++)
            {

                DGV_TEST_SENT.Rows.Add(
                gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[0].Value.ToString(),
                gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[1].Value.ToString(),
                gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[5].Value.ToString(),
                "");

            }


        }

        private void BTN_SAVESENTTEST_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (DGV_TEST_SENT.Rows.Count <= 0)
                {
                    MessageBox.Show("يرجى اضافة تحليل اولا", CLS.TITEL_MESG);
                    return;
                }
                if (nAME_LABComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى اضافة تحليل اولا", CLS.TITEL_MESG);
                    return;
                }

                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                // INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);



                int BookId;
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED_D = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                BookId = int.Parse(
                  INSERTED.P_INSERT_L_RESTESTNAME(
                 0
                , CLS.USER_CODE
                , Convert.ToInt32(TXT_ID_BOOK.Text)
                , System.DateTime.Now
                , 0
                , Convert.ToInt32(TXT_ID_PERSON.Text)
                , false
                , false
                , Convert.ToInt32(nAME_LABComboBox.SelectedValue)
                ,""
                ,0
                , ref CLS.SUBMIT_FLAG).ToString());

                for (int i = 0; i < DGV_TEST_SENT.Rows.Count; i++)
                {
                    INSERTED_D.P_INSERT_L_RESTESTNAME_DETAILS(
                        Convert.ToInt32(
                        DGV_TEST_SENT.Rows[i].Cells[0].Value)
                        , ""
                        , Convert.ToDecimal(DGV_TEST_SENT.Rows[i].Cells[2].Value)
                        , DGV_TEST_SENT.Rows[i].Cells[3].Value.ToString()
                        ,false
                        , BookId
                        , ref CLS.SUBMIT_FLAG);
                }


                if (CLS.SUBMIT_FLAG == 1)
                {
                    var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    UPDT.P_UPDATE_T_BOOKING_GOWAIT(Convert.ToInt32(TXT_ID_BOOK.Text), ref CLS.SUBMIT_FLAG);
                    MessageBox.Show("تمت العملية بنجاح", CLS.TITEL_MESG);
                    DGV_TEST_SENT.Rows.Clear();
                }


            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BTN_REFESH_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), System.DateTime.Now);


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        private void nAME_CATEGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_LAB_TEST_BY_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_TEST_BY_CATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        string V_SIDE, H_SIDE;
        private void R_UP_CheckedChanged(object sender, EventArgs e)
        {
            V_SIDE = "UPPER";
        }

        private void R_LOWER_CheckedChanged(object sender, EventArgs e)
        {
            V_SIDE = "LOWER";
        }

        private void BTN_C_V_Click(object sender, EventArgs e)
        {
            R_UP.Checked = false;
            R_LOWER.Checked = false;
            V_SIDE = "";
        }

        private void R_LEFT_CheckedChanged(object sender, EventArgs e)
        {
            H_SIDE = "LEFT";
        }

        private void R_RIGHT_CheckedChanged(object sender, EventArgs e)
        {
            H_SIDE = "RIGHT";
        }

        private void BTN_C_H_Click(object sender, EventArgs e)
        {
            R_LEFT.Checked = false;
            R_RIGHT.Checked = false;
        }




        private void BTN_ADD_RAY_TODGV_Click(object sender, EventArgs e)
        {
            if (nAME_RAYSComboBox.SelectedIndex == -1)

            {
                MessageBox.Show("يرجى اختيار الاشعة ", CLS.TITEL_MESG);
                return;
            }
            else
            {

                DGV_X_SEND.Rows.Add(nAME_RAYSComboBox.Text, 0, V_SIDE, H_SIDE, "color");
            }

        }

        private void BTN_S_R_ALL_Click(object sender, EventArgs e)
        {
            
        this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }

        private void BTN_S_R_RAY_Click(object sender, EventArgs e)
        {
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }

        private void BTN_S_R_DATE_Click(object sender, EventArgs e)
        {
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }
        byte[] imge1, imge2, imge3, imge4;
        DataTable DT = new DataTable();
        private void btn_getdata_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_MEDICAL_HISTORY_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY_P, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))));
                this.gET_MEDICAL_HISTORY_QUESTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY_QUES, new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))));


                DT = this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY_QUES;
                if ((bool)DT.Rows[0][0] == true)
                {
                    LBL_P_VISIT_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_P_VISIT_NO.BackColor = Color.Yellow;
                }
                if ((bool)DT.Rows[0][1] == true)
                {
                    LBL_Digestiv.BackColor = Color.Yellow;
                }
                if ((bool)DT.Rows[0][2] == true)
                {
                    LBL_Breath.BackColor = Color.Yellow;
                }

                if ((bool)DT.Rows[0][3] == true)
                {
                    LBL_Neurolo.BackColor = Color.Yellow;
                }
                if ((bool)DT.Rows[0][4] == true)
                {
                    LBL_Heart.BackColor = Color.Yellow;
                }

                if ((bool)DT.Rows[0][5] == true)
                {
                    LBL_NO.BackColor = Color.Yellow;
                }
                TXT_CHRONIC.Text = DT.Rows[0][6].ToString();

                if ((bool)DT.Rows[0][7] == true)
                {
                    LBL_medica_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_medica_YES.BackColor = Color.Yellow;
                }


                TXT_medications.Text = DT.Rows[0][8].ToString();

                if ((bool)DT.Rows[0][9] == true)
                {
                    LBL_allergies_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_allergies_NO.BackColor = Color.Yellow;
                }
                TXT_allergies.Text = DT.Rows[0][10].ToString();

                if ((bool)DT.Rows[0][11] == true)
                {
                    LBL_SOMKE_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_SMOKE_NO.BackColor = Color.Yellow;
                }
                if ((bool)DT.Rows[0][12] == true)
                {
                    LBL_COHOL_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_COHOL_NO.BackColor = Color.Yellow;
                }

                if ((bool)DT.Rows[0][13] == true)
                {
                    LBL_breastf_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_breastf_NO.BackColor = Color.Yellow;
                }

                if ((bool)DT.Rows[0][14] == true)
                {
                    LBL_pregnant_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_pregnant_YES.BackColor = Color.Yellow;
                }
                LBL_REASON_VISIT.Text = DT.Rows[0][15].ToString();
            }
            catch (System.Exception ex)
            {
                //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }




        private void label32_Click(object sender, EventArgs e)
        {
            PERSONS.FRM_M_HISTORY FRM = new PERSONS.FRM_M_HISTORY(TXT_ID_PERSON.Text.ToInt()); FRM.ShowDialog();

        }

        private void DGV_TEST_SENT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    DGV_TEST_SENT.Rows.RemoveAt(DGV_TEST_SENT.CurrentRow.Index);

                }
            }
        }



        private void TXT_PAY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //var origText = this.TXT_PAID.Text;

                this.TXT_PAID.Text = Convert.ToDecimal(this.TXT_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PAID.SelectionStart = TXT_PAID.TextLength;
                TXT_REMAIN.Text = (Convert.ToDecimal(TXT_TOTAL_OP.Text) - Convert.ToDecimal(TXT_PAID.Text)).ToString();

            }
            catch (System.Exception ex)
            {
                return;
            }

        }

        private void BTN_CASH_Click(object sender, EventArgs e)
        {

            try
            {

                foreach (var x in PayList)
                {
                    var controls = tableLayoutPanel63.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                PayList.Clear();
                if (PayList.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    PayList.Remove(((Control)sender).Name);
                    F_PAY = 0;
                }
                else
                {

                    PayList.Add(((Control)sender).Name);
                    // CLS.CANAL_UPPER_N = ((Control)sender).Text;
                    ((Control)sender).BackColor = Color.Red;
                    if (((Control)sender).Name == "BTN_CASH")
                    {
                        F_PAY = 1;
                    }
                    if (((Control)sender).Name == "BTN_NO_CASH")
                    {
                        F_PAY = 2;
                    }
                    else
                     if (((Control)sender).Name == "BTN_PARTIAL_CASH")
                    {
                        F_PAY = 3;
                    }
                }


            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }

            //if (PayList.Any(s => s == ((Control)sender).Name))
            //{
            //    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
            //    PayList.Remove(((Control)sender).Name);

            //}
            //else
            //{ 

            //    PayList.Add(((Control)sender).Name);
            //    if (((Control)sender).Name== "BTN_CASH")
            //    {
            //     F_PAY = 1;
            //    }
            //    if (((Control)sender).Name == "BTN_NO_CASH")
            //    {
            //        F_PAY =2;
            //    }
            //    else
            //     if (((Control)sender).Name == "BTN_PARTIAL_CASH")
            //    {
            //        F_PAY = 3;
            //    }
            //    ((Control)sender).BackColor = Color.Red;

            //}

        }

        private void BTN_NO_CASH_Click(object sender, EventArgs e)
        {
            if (PayList.Any(s => s == ((Control)sender).Name))
            {
                ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                PayList.Remove(((Control)sender).Name);

            }
            else
            {
                F_PAY = 2;
                PayList.Add(((Control)sender).Name);


                ((Control)sender).BackColor = Color.Red;

            }
        }

        private void BTN_IMG_Click(object sender, EventArgs e)
        {
        try{ 
            ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(Convert.ToInt32(TXT_ID_BOOK.Text),1);
            FRM.ShowDialog();
        }
            catch (System.Exception ex)
            {
                 System.Windows.Forms.MessageBox.Show("يرجى اختيار مريض اولا");
            }
}

        private void BTN_GOWAITREPORT_Click(object sender, EventArgs e)
        {
        try{ 
            if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
            {
           var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            UPDT.P_UPDATE_T_BOOKING_GOWAIT(Convert.ToInt32(TXT_ID_BOOK.Text), ref CLS.SUBMIT_FLAG);
            CLEARFORM();
                MSG.Msg.Alart(AlartType.Save);

            }
        }
            catch (System.Exception ex)
            {
                 System.Windows.Forms.MessageBox.Show("يرجى اختيار مريض اولا");
            }
}

        private void BTN_GOWAIT_Click(object sender, EventArgs e)
        {
        try{ 
            if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
            {
                var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                UPDT.P_UPDATE_T_BOOKING_BACKQEUE_DOCT(Convert.ToInt32(TXT_ID_BOOK.Text), ref CLS.SUBMIT_FLAG);
                CLEARFORM();
                MSG.Msg.Alart(AlartType.Save);



            }
        }
            catch (System.Exception ex)
            {
                 System.Windows.Forms.MessageBox.Show("يرجى اختيار مريض اولا");
            }

}

        private void nAME_CATEGComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_LAB_TEST_BY_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_TEST_BY_CATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_expenses_Click(object sender, EventArgs e)
        {
            if (TXT_ID_BOOK.Text!=string.Empty)
            {
         HOSPITAL.OPERA.FRM_ITEM_OPERATION_TOOLS FRM = new HOSPITAL.OPERA.FRM_ITEM_OPERATION_TOOLS(Convert.ToInt32(TXT_ID_BOOK.Text));
            FRM.ShowDialog();
            }
            else{
                MessageBox.Show("يرجى تحديد المريض اولا");
                return;
            }
          
        }

        private void LBL_GET_LASTBOW_Click(object sender, EventArgs e)
        {
        try{ 
            this.gET_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), CLS.Cost_Center_WARD_DR,DateTime.Now,DateTime.Now, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            LBL_PAST_BORROW.Text = (Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][2]).ToString("#,##0.00")).ToString();
        }
            catch (System.Exception ex)
            {
                 System.Windows.Forms.MessageBox.Show("يرجى اختيار مريض اولا");
            }
}

        private void label3_Click(object sender, EventArgs e)
        {
            PERSONS.FRM_MEDICAL_HISTORY_PERSON FRM = new PERSONS.FRM_MEDICAL_HISTORY_PERSON(TXT_ID_PERSON.Text.ToInt()); FRM.ShowDialog();

        }

        private void BTN_ALL_BOOKING_Click(object sender, EventArgs e)
        {
            REPORT.FRM_DR_BOOKING_RPT FRM = new REPORT.FRM_DR_BOOKING_RPT();
            FRM.ShowDialog();
        }

        private void gET_LAB_TEST_BY_CATEGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==16)
            {
    if (nAME_CATEGComboBox.SelectedIndex != -1)
            {
                int FoodIndex = -1;

                for (int i = 0; i < DGV_TEST_SENT.Rows.Count; i++)
                {
                    if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString().Equals(DGV_TEST_SENT.Rows[i].Cells[0].Value.ToString()))
                        FoodIndex = i;

                }
                if (FoodIndex == -1)
                {
                    DGV_TEST_SENT.Rows.Add(
                    gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString(),
                    gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[1].Value.ToString(),
                    gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[5].Value.ToString(),
                    "");

                }
                else
                {
                    MessageBox.Show("التحليل موجود مسبقا");
                    return;
                }

            }
            else
            {
                MessageBox.Show("اختار التحليل اولا ", CLS.TITEL_MESG);
                return;
            }
            }
        

        }

        int idres = 0;

        private void DGV_ALL_TEST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {

                    this.p_GET_H_ALL_TESTS_FOR_PERSON_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_H_ALL_TESTS_FOR_PERSON_DET, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(DGV_ALL_TEST.CurrentRow.Cells[12].Value, typeof(int))))));
                    idres = DGV_ALL_TEST.CurrentRow.Cells[12].Value.ToInt();
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(idres, 1);
                FRM.ShowDialog();
            }
        }

        private void BTN_TO_ACCOUNT_Click(object sender, EventArgs e)
        {
            var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            if (TXT_TOTAL_OP.Text.ToDecimal() > 0)
            {


                if (TXT_PAID.Text == String.Empty || TXT_PAID.Text == "")
                {
                    TXT_PAID.Text = "0";
                }
                this.gET_DOCTOR_BY_USERCODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_USERCODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                DR_OPPERCENT = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_USERCODE.Rows[0][10].ToString());
                DoctorPrecentage = DR_OPPERCENT;
                decimal TOTAL_PRICE = Convert.ToDecimal(TXT_TOTAL_OP.Text);
                decimal DebitPatient = 0;
                decimal CreditService = 0;
                decimal CreditDoctor = 0;
                var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                if (DR_OPPERCENT > 0)
                {



                    DebitPatient = TOTAL_PRICE;
                    CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                    CreditService = TOTAL_PRICE - CreditDoctor;



                    BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                Convert.ToInt32(TXT_ID_BOOK.Text)
                              , System.DateTime.Now
                              , "عن اجور عمليات "
                              , 19
                              , 0
                              , true
                              , CLS.USER_CODE
                              , ref CLS.SUBMIT_FLAG
                              , CLS.BRANCH_ID
                              , cost_center_code
                              ).ToString());

                    if (F_PAY == 1)
                    {
                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BookIdS
                                        , 111
                                        , " اجور  عملية"
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
                        , Convert.ToInt32(TXT_ID_PERSON.Text)
                         , " اجور  عملية"
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
                         , Convert.ToInt32(TXT_ID_PERSON.Text)
                          , " اجور  عملية"
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
                      , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                       , " اجور  عملية"
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
                       , 4004
                       , " اجور  عملية"
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
                    if (F_PAY == 2)
                    {
                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BookIdS
                                        , Convert.ToInt32(TXT_ID_PERSON.Text)
                                        , " اجور  عملية"
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
                        , 4004
                         , " اجور  عملية"
                        , 0
                        , 0
                        , 0
                        , CreditService
                        , "من حساب الزبون الى حساب العمليات"
                        , 1
                        , 1
                        , ref CLS.SUBMIT_FLAG
                         );
                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                   (
                     BookIdS
                   , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                    , " اجور  عملية"
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
                    if (F_PAY == 3)
                    {
                        //جزء النقدي من الجزئي
                        DoctorPrecentage = DR_OPPERCENT;
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
                                        , " اجور  عملية"
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
                        , Convert.ToInt32(TXT_ID_PERSON.Text)
                         , " اجور  عملية"
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
                         , Convert.ToInt32(TXT_ID_PERSON.Text)
                          , " اجور  عملية"
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
                      , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                       , " اجور  عملية"
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
                       , 4004
                       , " اجور  عملية"
                       , 0
                       , 0
                       , 0
                       , CreditService
                       , "من حساب الزبون الى حساب العمليات"
                       , 1
                       , 1
                       , ref CLS.SUBMIT_FLAG
                        );


                        //الجزء الاجل من الجزئي


                        DoctorPrecentage = DR_OPPERCENT;
                        TOTAL_PRICE = Convert.ToDecimal(TXT_REMAIN.Text);
                        DebitPatient = 0;
                        CreditService = 0;
                        CreditDoctor = 0;

                        DebitPatient = TOTAL_PRICE;
                        CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                        CreditService = TOTAL_PRICE - CreditDoctor;

                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BookIdS
                                        , Convert.ToInt32(TXT_ID_PERSON.Text)
                                        , " اجور  عملية"
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
                      , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                       , " اجور  عملية"
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
                       , 4004
                       , " اجور  عملية"
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
                if (DR_OPPERCENT == 0)
                {



                    BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                Convert.ToInt32(TXT_ID_BOOK.Text)
                              , System.DateTime.Now
                               , "عن اجور العمليات "
                              , 19
                              , 0
                              , true
                              , CLS.USER_CODE
                              , ref CLS.SUBMIT_FLAG
                              , CLS.BRANCH_ID
                              , cost_center_code
                              ).ToString());

                    if (F_PAY == 1)
                    {
                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BookIdS
                                        , 111
                                        , " اجور  عملية"
                                        , 0
                                        , 0
                                        , Convert.ToDecimal(TXT_TOTAL_OP.Text)
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
                        , Convert.ToInt32(TXT_ID_PERSON.Text)
                         , " اجور  عملية"
                        , 0
                        , 0
                        , 0
                        , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                        , "من حساب الزبون الى حساب الصندوق"
                        , 1
                        , 1
                        , ref CLS.SUBMIT_FLAG
                         );
                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                         (
                           BookIdS
                         , Convert.ToInt32(TXT_ID_PERSON.Text)
                          , " اجور  عملية"
                         , 0
                         , 0
                         , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                         , 0
                         , "من حساب الزبون الى حساب الصندوق"
                         , 1
                         , 1
                         , ref CLS.SUBMIT_FLAG
                          );

                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                      (
                        BookIdS
                      , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                       , " اجور  عملية"
                      , 0
                      , 0
                      , 0
                      , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                      , "من حساب الزبون الى حساب الدكتور"
                      , 1
                      , 1
                      , ref CLS.SUBMIT_FLAG
                       );












                    }
                    if (F_PAY == 2)
                    {
                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BookIdS
                                        , Convert.ToInt32(TXT_ID_PERSON.Text)
                                        , " اجور  عملية"
                                        , 0
                                        , 0
                                        , Convert.ToDecimal(TXT_TOTAL_OP.Text)
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
                   , CLS.USER_CODE
                    , " اجور  عملية"
                   , 0
                   , 0
                   , 0
                   , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                   , "من حساب الزبون الى حساب الدكتور"
                   , 1
                   , 1
                   , ref CLS.SUBMIT_FLAG
                    );
                    }


                    if (F_PAY == 3)
                    {



                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                         (
                           BookIdS
                         , Convert.ToInt32(TXT_ID_PERSON.Text)
                          , " اجور  عملية"
                         , 0
                         , 0
                         , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                         , 0
                         , "من حساب الزبون الى حساب الدكتور"
                         , 1
                         , 1
                         , ref CLS.SUBMIT_FLAG
                          );

                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                      (
                        BookIdS
                      , Convert.ToInt32(CLS.USER_CODE)
                      , " اجور  عملية"
                      , 0
                      , 0
                      , 0
                      , Convert.ToDecimal(TXT_TOTAL_OP.Text)
                      , "من حساب الزبون الى حساب الدكتور"
                      , 1
                      , 1
                      , ref CLS.SUBMIT_FLAG
                       );





                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                       (
                                        BookIdS
                                       , 111
                                       , " اجور  عملية"
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
                        , Convert.ToInt32(TXT_ID_PERSON.Text)
                         , " اجور  عملية"
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

                //this.gET_H_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(TXT_ID_PERSON.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));

            }
        }

        private void BTN_TO_ACCOUNT_Click_1(object sender, EventArgs e)
        {
            if (TXT_ID_PERSON.Text == string.Empty || TXT_ID_BOOK.Text == string.Empty)
            {
                MessageBox.Show("يرجى أختيار مريض أولا");
                return;
            }
            if (TXT_TOTAL_OP.Text.ToDecimal()>0)
            {

            var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

          
                

                if (TXT_PAID.Text == String.Empty || TXT_PAID.Text == "")
                {
                    TXT_PAID.Text = "0";
                }
            
            this.gET_DOCTOR_BY_USERCODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_USERCODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
            DR_OPPERCENT = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_USERCODE.Rows[0][10].ToString());
            DoctorPrecentage = DR_OPPERCENT;
            decimal TOTAL_PRICE = Convert.ToDecimal(TXT_TOTAL_OP.Text);
            decimal DebitPatient = 0;
            decimal CreditService = 0;
            decimal CreditDoctor = 0;
            var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            if (DR_OPPERCENT > 0)
            {



                DebitPatient = TOTAL_PRICE;
                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                CreditService = TOTAL_PRICE - CreditDoctor;



                BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                            Convert.ToInt32(TXT_ID_BOOK.Text)
                          , System.DateTime.Now
                          , "عن اجور عمليات "
                          , 19
                          , 0
                          , true
                          , CLS.USER_CODE
                          , ref CLS.SUBMIT_FLAG
                          , CLS.BRANCH_ID
                          , cost_center_code
                          ).ToString());

                
                
                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                    (
                                     BookIdS
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                    , " اجور  عملية"
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
                    , 4004
                     , " اجور  عملية"
                    , 0
                    , 0
                    , 0
                    , CreditService
                    , "من حساب الزبون الى حساب العمليات"
                    , 1
                    , 1
                    , ref CLS.SUBMIT_FLAG
                     );
                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
               (
                 BookIdS
               , Convert.ToInt32(TXT_ID_DOCTOR.Text)
                , " اجور  عملية"
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

            else
            if (DR_OPPERCENT == 0)
            {



                BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                            Convert.ToInt32(TXT_ID_BOOK.Text)
                          , System.DateTime.Now
                           , "عن اجور العمليات "
                          , 19
                          , 0
                          , true
                          , CLS.USER_CODE
                          , ref CLS.SUBMIT_FLAG
                          , CLS.BRANCH_ID
                          , cost_center_code
                          ).ToString());

                
                 
                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                    (
                                     BookIdS
                                    , Convert.ToInt32(TXT_ID_PERSON.Text)
                                    , " اجور  عملية"
                                    , 0
                                    , 0
                                    , Convert.ToDecimal(TXT_TOTAL_OP.Text)
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
               , CLS.USER_CODE
               , " اجور  عملية"
               , 0
               , 0
               , 0
               , Convert.ToDecimal(TXT_TOTAL_OP.Text)
               , "من حساب الزبون الى حساب الدكتور"
               , 1
               , 1
               , ref CLS.SUBMIT_FLAG
                );
                }
                
            }
            TXT_TOTAL_OP.Text="0";
            TXT_PAID.Text = "0";
            TXT_REMAIN.Text = "0";
            MSG.Msg.MsgBoxResult("Sent Seccessfully");


        }
        bool ACTIVR_F = false;





        private void BTN_PARTIAL_CASH_Click(object sender, EventArgs e)
        {
            if (PayList.Any(s => s == ((Control)sender).Name))
            {
                ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                PayList.Remove(((Control)sender).Name);

            }
            else
            {
                F_PAY = 3;
                PayList.Add(((Control)sender).Name);


                ((Control)sender).BackColor = Color.Red;

            }
        }





        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==17)
            {
                LBL_SUGER.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                LBL_PRESSURE.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                LBL_PRESCRIPTION.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                LBL_TEMP.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                LBL_BLOOD.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                LBL_HEIGHT.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
                LBL_WEIGHT.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
                LBLNOTE.Text = dataGridView2.CurrentRow.Cells[10].Value.ToString();
                if ((bool)dataGridView2.CurrentRow.Cells[11].Value == true)
                {
                    LBL_HEP.Text = "Positive";
                }
                else
                {
                    LBL_HEP.Text = "Negative";
                }

                if ((bool)dataGridView2.CurrentRow.Cells[12].Value == true)
                {
                    LBL_HIV.Text = "Positive";
                }
                else
                {
                    LBL_HIV.Text = "Negative";
                }

            }
        }


        private void DGV_ALL_RAYS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(DGV_ALL_RAYS.CurrentRow.Cells[16].Value.ToInt(), 2);
            FRM.ShowDialog();
        }

        private void BTN_SEND_Click(object sender, EventArgs e)
        {
            try
            {

                if (DGV_X_SEND.Rows.Count <= 0)
                {
                    MessageBox.Show("يرجى اضافة أشعه اولا", CLS.TITEL_MESG);
                    return;
                }
                if (nAME_RAYComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى اضافة أشعه اولا", CLS.TITEL_MESG);
                    return;
                }

                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                // INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);
                //byte[] imge1;
                //byte[] imge2;
                //byte[] imge3;
                //byte[] imge4;


                //MemoryStream ms1 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms1, Properties.Resources.NOPIC.RawFormat);
                //imge1 = ms1.ToArray();

                //MemoryStream ms2 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms2, Properties.Resources.NOPIC.RawFormat);
                //imge2 = ms2.ToArray();
                //MemoryStream ms3 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms3, Properties.Resources.NOPIC.RawFormat);
                //imge3 = ms3.ToArray();

                //MemoryStream ms4 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms4, Properties.Resources.NOPIC.RawFormat);
                //imge4 = ms4.ToArray();

                int BookId;
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED_D = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                BookId = int.Parse(
                  INSERTED.P_INSERT_T_RESULTRAY(
                 0
                , CLS.USER_CODE
                , Convert.ToInt32(TXT_ID_BOOK.Text)
                , System.DateTime.Now
                , 0
                , Convert.ToInt32(TXT_ID_PERSON.Text)
                , false
                , false
                , Convert.ToInt32(nAME_RAYComboBox.SelectedValue)
                , ref CLS.SUBMIT_FLAG).ToString());

                for (int i = 0; i < DGV_X_SEND.Rows.Count; i++)
                {
                    INSERTED_D.P_INSERT_T_RESULTRAY_DETAILS(

                          DGV_X_SEND.Rows[i].Cells[0].Value.ToString()
                        , DGV_X_SEND.Rows[i].Cells[1].Value.ToString()
                        , DGV_X_SEND.Rows[i].Cells[3].Value.ToString()
                        , DGV_X_SEND.Rows[i].Cells[2].Value.ToString()
                        , DGV_X_SEND.Rows[i].Cells[4].Value.ToString()
                        , 0 
                        , ""
                        , false
                        , BookId
                        , null
                        , null
                        , null
                        , null
                        , ref CLS.SUBMIT_FLAG).ToString();

                }


                if (CLS.SUBMIT_FLAG == 1)
                {
                    MessageBox.Show("تمت العملية بنجاح", CLS.TITEL_MESG);

                    DGV_X_SEND.Rows.Clear();
                }


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

