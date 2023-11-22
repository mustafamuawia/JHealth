
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.BOOKING
{

    public partial class FRM_ALLBOOK : Form
    {
        int GETPRECNTAGE, BookIdS;
         
        public FRM_ALLBOOK()
        {
            InitializeComponent();
        }

        private void FRM_ALLBOOK_Load(object sender, EventArgs e)
        {
           
               DATE_DAY.Value  = System.DateTime.Now;
            
             this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            dOCTOR_NAMEComboBox.SelectedIndex = -1;
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
           
        }



        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, TXT_SEARCH .Text , new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_DAY.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE , typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, TXT_SEARCH.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_DAY.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        

        private void dgvActive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try 
            
            {
            if (e.ColumnIndex == 12)
            {
                    //if (R_NO_PAID.Checked == false && R_PAID.Checked == false)
                    //{
                    //    MessageBox.Show("رجاء حدد نوع الدفع اولا ثم اعد المحاولة");
                    //    return;
                    //}

                    var DELL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var CNGE_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    int ID_BOOKED = Convert.ToInt32(dgvActive.CurrentRow.Cells[1].Value);
                    int ID_PERSON = Convert.ToInt32(dgvActive.CurrentRow.Cells[2].Value);
                     var GET_NUM = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                  var UPD = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    var CAHNGE_BOOK_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, "0.00", DATE_DAY.Value, false, false);



                    if ((bool) (dgvActive.CurrentRow.Cells[13].Value) == true)
                  {
                     // UPD.P_UDATE_T_BOOKING_T_PERSON(Convert.ToInt32(dgvActive.CurrentRow.Cells[1].Value), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), false, false  );
                     // CNGE_STATE.P_CHANGE_KSHFIA_STATE(ID_BOOKED, false, "0.00", ref CLS.SUBMIT_FLAG);
                       DELL.P_DELETE_T_BOX_DETAILS(ID_BOOKED, 12,ID_PERSON,DATE_DAY.Value, ref CLS.SUBMIT_FLAG);
                   }

                  //else
                  //    if ((bool)(dgvActive.CurrentRow.Cells[13].Value) == false)
                  //{
                  //  //  UPD.P_UDATE_T_BOOKING_T_PERSON(Convert.ToInt32(dgvActive.CurrentRow.Cells[1].Value), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), false, false );
 
                  //}
                  button1_Click(null, null);
                  this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED,Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_DAY.Value);
                  LBL_TOTAL .Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##0.00");
               
                  LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                  LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
            }

        }

        catch (System.Exception ex)
        {
            //System.Windows.Forms.MessageBox.Show(ex.Message);
        }
        }

        // غير  مفعله
        private void dgvInActive_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 10)
                {

                    if (R_NO_PAID.Checked == false && R_PAID.Checked == false)
                    {
                        MessageBox.Show("رجاء حدد نوع الدفع اولا ثم اعد المحاولة");
                        return;
                    }

                    //  if (MessageBox.Show("هل انت متاكد من  تفعيل المريض ", "تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    // {
                  
                    int ID_BOOKED = Convert.ToInt32(dgvInActive.CurrentRow.Cells[0].Value);
                   // int ID_PERSON = Convert.ToInt32(dgvInActive.CurrentRow.Cells[1].Value);

                    //var U_TIME = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                  //  var CNGE_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    //var DELL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                   // var GET_NUM = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                   /// var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                   // var UPD = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    var CAHNGE_BOOK_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    //UPD.P_UDATE_T_BOOKING_T_PERSON(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), false, true);
                    // var GET_ID_ACCTIVE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    //GET_ID_ACCTIVE.P_CHANGE_ID_ACTIVE( Convert.ToInt32 (dgvInActive.CurrentRow.Cells[0].Value),Convert .ToInt32 (dOCTOR_NAMEComboBox .SelectedValue ),DATE_DAY.Value );

                    if (R_PAID.Checked == true)
                    {
                        CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, kSHFIA_PRICELabel1.Text, DATE_DAY.Value, false, true);

                        // CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, true, kSHFIA_PRICELabel1.Text, DATE_DAY.Value,false,true );

                        //  CNGE_STATE.P_CHANGE_KSHFIA_STATE(ID_BOOKED, true, kSHFIA_PRICELabel1.Text, ref CLS.SUBMIT_FLAG);
                        // U_TIME.P_UDATE_T_BOOKING_TIME(Convert.ToInt32(dgvInActive .CurrentRow.Cells[0].Value),
                        //   Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now);
                        var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        
                      
                           int PERSON_CODE =Convert.ToInt32( dgvInActive.CurrentRow.Cells[1].Value );
                        //var GET_BILL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                      //  int? BILL_SANAD=-1;
                      //  GET_BILL.P_GET_BILL_NUMBER(12, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), ref BILL_SANAD);

                        Decimal DoctorPrecentage = Convert.ToDecimal(pRECENTAGE_KSHFIALabel1.Text);
                        decimal TOTAL_PRICE = Convert.ToDecimal(kSHFIA_PRICELabel1.Text);
                        decimal DebitPatient = 0;
                        decimal CreditService = 0;
                        decimal CreditDoctor = 0;
                        var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        if (DoctorPrecentage > 0)
                        {



                            DebitPatient = TOTAL_PRICE;
                            CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                            CreditService = TOTAL_PRICE - CreditDoctor;



                            BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                       ID_BOOKED
                                      , System.DateTime.Now
                                      ,""
                                      , 12
                                      , 0
                                      , true
                                      , CLS.USER_CODE
                                      , ref CLS.SUBMIT_FLAG
                                      , CLS.BRANCH_ID
                                      ,0
                                      ).ToString());

                            if (R_PAID.Checked == true)
                            {

                                BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                           PERSON_CODE
                                         , System.DateTime.Now
                                          ,   ""
                                         , 12
                                         , 0
                                         , true
                                         , CLS.USER_CODE
                                         , ref CLS.SUBMIT_FLAG, CLS.BRANCH_ID
                                         ,0
                                         ).ToString());

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , 111
                                                , " اجور  كشفية"
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
                                , PERSON_CODE
                                 , " اجور  كشفية"
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
                                 , PERSON_CODE
                                  , " اجور  كشفية"
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
                              , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                               , " اجور  كشفية"
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
                               , 4006
                               , " اجور  كشفية"
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



                            BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                        ID_BOOKED
                                      , System.DateTime.Now
                                       , ""
                                      , 12
                                      , 0
                                      , true
                                      , CLS.USER_CODE
                                      , ref CLS.SUBMIT_FLAG 
                                      , CLS.BRANCH_ID
                                      ,0
                                      ).ToString());

                            if (R_PAID.Checked == true)
                            {
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , 111
                                                , " اجور  كشفية"
                                                , 0
                                                , 0
                                                , Convert.ToDecimal(kSHFIA_PRICELabel1.Text)
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
                                , PERSON_CODE
                                , " اجور  كشفية"
                                , 0
                                , 0
                                , 0
                                , Convert.ToDecimal(kSHFIA_PRICELabel1.Text)
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                 (
                                   BookIdS
                                 , PERSON_CODE
                                  , " اجور  كشفية"
                                 , 0
                                 , 0
                                 , Convert.ToDecimal(kSHFIA_PRICELabel1.Text)
                                 , 0
                                 , "من حساب الزبون الى حساب الصندوق"
                                 , 1
                                 , 1
                                 , ref CLS.SUBMIT_FLAG
                                  );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                              (
                                BookIdS
                              , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                               , " اجور  كشفية"
                              , 0
                              , 0
                              , 0
                              , Convert.ToDecimal(kSHFIA_PRICELabel1.Text)
                              , "من حساب الزبون الى حساب الدكتور"
                              , 1
                              , 1
                              , ref CLS.SUBMIT_FLAG
                               );












                            }
        


                         
                        }






                        ////  string ServiceAccount = "", DoctorAccount = "", PatientAccount = "";
                        //int DoctorPrecentage = GETPRECNTAGE;
                        //decimal DebitPatient = 0, TOTAL_PRICE=Convert.ToDecimal(kSHFIA_PRICELabel1.Text);

                        //decimal CreditService = 0;
                        //decimal CreditDoctor = 0;

                        //DebitPatient = TOTAL_PRICE;
                        //CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                        //CreditService = TOTAL_PRICE - CreditDoctor;

  

                    }
                    else
                    ///////////////////////////////////////////////

                    if (R_NO_PAID.Checked == true)
                    {
                        CAHNGE_BOOK_STATE.P_CAHNGE_BOOKING_TO_ACTIVE(ID_BOOKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now, false, "00.0", DATE_DAY.Value, false, true);

                        //CNGE_STATE.P_CHANGE_KSHFIA_STATE(ID_BOOKED, false, "0.00", ref CLS.SUBMIT_FLAG);
                        //DELL.P_DELETE_T_BOX(ID_BOOKED, 12, "", ref CLS.SUBMIT_FLAG);
                        //this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_DAY.Value);
                        //label7.Text = this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0].ToString();

                        //U_TIME.P_UDATE_T_BOOKING_TIME(Convert.ToInt32(dgvInActive.CurrentRow.Cells[0].Value),
                        //    Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), System.DateTime.Now);

                    }



                    button1_Click(null, null);
                    // this.gET_H_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(12, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                    // LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();
                    this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_DAY.Value);
                    LBL_TOTAL.Text = Convert.ToDecimal( this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0]).ToString("#,##0.00");
                    LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                    LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                    R_NO_PAID.BackColor = Color.SteelBlue;
                    R_PAID.BackColor = Color.SteelBlue;
                    R_NO_PAID.Checked = false;
                    R_PAID.Checked = false;
                }
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_DAY.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox .SelectedValue , typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_DAY.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));

            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "",  Convert .ToDateTime ( DATE_DAY.Value), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
            //    this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", Convert.ToDateTime(DATE_DAY.Value), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
            //    var GET_NUM = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            //    LBL_ACTIVE.Text = (  dgvActive.Rows.Count ).ToString ();
            //    LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
            //    this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_DAY.Value);
            //    label7.Text = this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0].ToString();
            //}
            //catch (System.Exception ex)
            //{
                
            //}
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {

            var GET_NUM = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_DAY.Value);
            LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0].ToString();
              }
            catch (System.Exception ex)
            {
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dOCTOR_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءا حدد اسم الدكتور اولا");
                    return;
                }
                this.p_GET_T_BOOKING_T_PERSON_INACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_INACTIVE, "", Convert.ToDateTime(DATE_DAY.Value), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_ACTIVETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_ACTIVE, "", Convert.ToDateTime(DATE_DAY.Value), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
                var GET_NUM = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                LBL_ACTIVE.Text = (dgvActive.Rows.Count).ToString();
                LBL_ANACTIVE.Text = (dgvInActive.Rows.Count).ToString();
                this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_DAY.Value);
                LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0].ToString();
            }
            catch (System.Exception ex)
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
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

        

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                var GET_NUM = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_DAY.Value);
                LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0].ToString();

               // this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
                GETPRECNTAGE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR.Rows[dOCTOR_NAMEComboBox.SelectedIndex][6]);
                this.gET_H_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(12, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();

            }
            catch (System.Exception ex)
            {
                return;
            }
        }
    }
}
