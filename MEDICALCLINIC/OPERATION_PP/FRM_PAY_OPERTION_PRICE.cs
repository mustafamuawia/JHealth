using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.OPERATION_PP
{
    public partial class FRM_PAY_OPERTION_PRICE : Form
    {
        int DOCTOR_CODE_F  ;
        int PERSON_CODE_F ;
        int BOOKING_CODE_F ;
        string PERSON_NAME_F, TOT_RICE_F, GETPRESTNAGE_F;

           
            String F_DATE_PRT_F ;
        List<string> tooth;
        int FLAG_PAY = 0;
        public FRM_PAY_OPERTION_PRICE(int DOCTOR_CODE, int PERSON_CODE , int BOOKING_CODE,String PERSON_NAME,String OPERTION_PRICE,String F_DATE_PRT ,string GETPRESTNAGE)
        {
            InitializeComponent();
            GETPRESTNAGE_F = GETPRESTNAGE;
              DOCTOR_CODE_F = DOCTOR_CODE;
              PERSON_CODE_F = PERSON_CODE;
              BOOKING_CODE_F = BOOKING_CODE;
             LBL_NAME.Text = PERSON_NAME;
             TXT_PRICE_TOT.Text = OPERTION_PRICE;
              F_DATE_PRT_F = F_DATE_PRT;
          
            label2.Text = PERSON_NAME;
            // TXT_PRICE_TOT.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("id-ID"), "{0:#,##0.00}", double.Parse(TXT_PRICE_TOT.Text));



            var origText = this.TXT_PAID.Text;
            this.TXT_PRICE_TOT.Text = Convert.ToDecimal(this.TXT_PRICE_TOT.Text).ToString("N0", new CultureInfo("en-US"));
            this.TXT_PRICE_TOT.SelectionStart = TXT_PRICE_TOT.TextLength;
        }


        private void FRM_PAY_OPERTION_PRICE_Load(object sender, EventArgs e)
        {

           // label1.Text = TOT_RICE_F;
           // label2.Text = PERSON_NAME_F;
            tooth = new List<string>();
            //LBL_NAME.Text =  PERSON_NAME_F;
;
          //  TXT_PRICE_TOT.Text = TOT_RICE_F;


        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (FLAG_PAY==0)
                {
                    MessageBox.Show("يرجى تحديد نوع الدفع!");
                    return;
                }
                int? BILL_NUM = -1;
                string SANAD_DISCRIPTION = "\\من ح/ " + LBL_NAME.Text + " الى ح/   العمليات";
                var GET_BILL_ID = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                GET_BILL_ID.P_GET_BILL_NUMBER(13, CLS.DOCTOR_CODE_ADD_IMG, ref  BILL_NUM);

                var UPDATE_TBOOK = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                UPDATE_TBOOK.P_UPDATE_T_BOOKING_OPERTIONS(
                      BOOKING_CODE_F
                    , PERSON_CODE_F
                    , TXT_PRICE_TOT.Text
                    , true
                    ,1
                    , ref CLS.SUBMIT_FLAG);
                var INSERT_BOX = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
              //  string ServiceAccount = "", DoctorAccount = "", PatientAccount = "";
                decimal DoctorPrecentage =Convert.ToDecimal(GETPRESTNAGE_F);
                decimal DebitPatient = 0;
                decimal TOTAL_PRICE = 0;
                decimal CreditService = 0;
                decimal CreditDoctor = 0;


                TOTAL_PRICE = Convert.ToDecimal(TXT_PRICE_TOT.Text);
                DebitPatient = TOTAL_PRICE;
                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
               CreditService = TOTAL_PRICE - CreditDoctor;

                if (DoctorPrecentage > 0)
                {
                    //نقداَ
                    if (FLAG_PAY == 1)
                    {

                        //من حساب الزبون دائن الى ح الصندوق مدين
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(Convert.ToInt32(BOOKING_CODE_F)
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 91
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , 0
                                                                        , "الى ح/الصندوق" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , "الى ح/الصندوق" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);

                        /////////////////////////////////////////



                        //من حساب الزبون مدين الى ح العمليات دائن
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditService)
                                                                        , 0
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 11
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditService)
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);



                        ///////////////////
                        ///
                        //من حساب الزبون مدين الى حساب الدكتور دائن

                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditDoctor)
                                                                        , 0
                                                                        , "الى ح/الدكتور" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(DOCTOR_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditDoctor)
                                                                        , "الى ح/الدكتور" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);

                    }
                    else

                    //أجل
                    if (FLAG_PAY == 2)
                    {



                        //من حساب الزبون مدين الى ح العمليات دائن
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditService)
                                                                        , 0
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 11
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditService)
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);



                        ///////////////////
                        ///
                        //من حساب الزبون مدين الى حساب الدكتور دائن

                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditDoctor)
                                                                        , 0
                                                                        , "الى ح/الدكتور" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(DOCTOR_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditDoctor)
                                                                        , "الى ح/الدكتور" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);

                    }




                    //جزئي
                    if (FLAG_PAY == 3)
                    {

                        //الجزء الواصل 
                        TOTAL_PRICE = Convert.ToDecimal(TXT_PAID.Text);
                        DebitPatient = TOTAL_PRICE;
                        CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                        CreditService = TOTAL_PRICE - CreditDoctor;


                        //من حساب الزبون دائن الى ح الصندوق مدين
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(Convert.ToInt32(BOOKING_CODE_F)
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 91
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , 0
                                                                        , "الى ح/الصندوق" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , "الى ح/الصندوق" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);

                        /////////////////////////////////////////



                        //من حساب الزبون مدين الى ح الكشفيه دائن
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditService)
                                                                        , 0
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 11
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditService)
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);



                        ///////////////////
                        ///
                        //من حساب الزبون مدين الى حساب الدكتور دائن

                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditDoctor)
                                                                        , 0
                                                                        , "الى ح/الدكتور" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(DOCTOR_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditDoctor)
                                                                        , "الى ح/الدكتور" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        //الجزء الاجل

                        TOTAL_PRICE = Convert.ToDecimal(TXT_REMAIN.Text);
                        DebitPatient = TOTAL_PRICE;
                        CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                        CreditService = TOTAL_PRICE - CreditDoctor;

                        //من حساب الزبون مدين الى ح الكشفيه دائن
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditService)
                                                                        , 0
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 11
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditService)
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);



                        ///////////////////
                        ///
                        //من حساب الزبون مدين الى حساب الدكتور دائن

                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditDoctor)
                                                                        , 0
                                                                        , "الى ح/الدكتور" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(DOCTOR_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(CreditDoctor)
                                                                        , "الى ح/الدكتور" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                    }
                }


                // النسبة =0


                if (DoctorPrecentage == 0)
                {
                    //نقداَ
                    if (FLAG_PAY == 1)
                    {

                        //من حساب الزبون دائن الى ح الصندوق مدين
                        ///from
                                                INSERT_BOX.P_INSERT_T_BOX(Convert.ToInt32(BOOKING_CODE_F)
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 91
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , 0
                                                                        , "الى ح/الصندوق" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , "الى ح/الصندوق" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);

                        /////////////////////////////////////////

                        //من حساب الزبون مدين الى ح العمليات دائن
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , 0
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 11
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);



                       

                    }
                    else

                    //أجل
                    if (FLAG_PAY == 2)
                    {



                        //من حساب الزبون مدين الى ح العمليات دائن
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , 0
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 11
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(DebitPatient)
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);



                        

                    }




                    //جزئي
                    if (FLAG_PAY == 3)
                    {

                        //الجزء الواصل 
                        TOTAL_PRICE = Convert.ToDecimal(TXT_PAID.Text);
                        DebitPatient = TOTAL_PRICE;
                        CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                        CreditService = TOTAL_PRICE - CreditDoctor;


                        //من حساب الزبون دائن الى ح الصندوق مدين
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(Convert.ToInt32(BOOKING_CODE_F)
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 91
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , 0
                                                                        , "الى ح/الصندوق" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , "الى ح/الصندوق" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);

                        /////////////////////////////////////////



                        //من حساب الزبون مدين الى ح الكشفيه دائن
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , 0
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 11
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);



                        


                        //الجزء الاجل

                        TOTAL_PRICE = Convert.ToDecimal(TXT_REMAIN.Text);
                        DebitPatient = TOTAL_PRICE;
                        CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                        CreditService = TOTAL_PRICE - CreditDoctor;

                        //من حساب الزبون مدين الى ح الكشفيه دائن
                        ///from
                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , Convert.ToInt32(PERSON_CODE_F)
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_REMAIN.Text)
                                                                        , 0
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

                        INSERT_BOX.P_INSERT_T_BOX(BOOKING_CODE_F
                                                                        , Convert.ToDateTime(System.DateTime.Now)
                                                                        , 13
                                                                        , 0
                                                                        , 11
                                                                        , ""
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_REMAIN.Text)
                                                                        , "الى ح/العمليات" + LBL_NAME.Text + "من ح/"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(CLS.USER_CODE)
                                                                        , ref CLS.SUBMIT_FLAG);


                    }
                }



                if (CLS.SUBMIT_FLAG == 1)
                {
                    MSG.Msg.Alart(AlartType.Save);
                    //TXT_PRICE_TOT.Text = "";
                    button3.Enabled = false;
                    CLS.TIMER_BORROW = 1;

                    ((OPERATION_PP.FRM_ALL_OPERTION_PRICE)Application.OpenForms["FRM_ALL_OPERTION_PRICE"]).p_GET_PRICE_OPERTION_BY_GRIDDataGridView.DataSource = this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PRICE_OPERTION_BY_GRID, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.DOCTOR_CODE_ADD_IMG, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(CLS.F_DATE_PRT, typeof(System.DateTime))))));

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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_PAID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void BTN_CASH_Click(object sender, EventArgs e)
        {
            foreach (var x in tooth)
            {
                var controls = tableLayoutPanel3.Controls.Find(x, false);
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
                if(((Control)sender).Name== "BTN_CASH")
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



                var origText = this.TXT_PAID.Text;

                this.TXT_PAID.Text = Convert.ToDecimal(this.TXT_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PAID.SelectionStart = TXT_PAID.TextLength;


                TXT_REMAIN.Text = (Convert.ToDecimal(TXT_PRICE_TOT.Text) - Convert.ToDecimal(TXT_PAID.Text)).ToString();

                var origText1 = this.TXT_REMAIN.Text;
                this.TXT_REMAIN.Text = Convert.ToDecimal(this.TXT_REMAIN.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_REMAIN.SelectionStart = TXT_REMAIN.TextLength;
            }
            catch
            {
                return;
            }
        }
    }
}
