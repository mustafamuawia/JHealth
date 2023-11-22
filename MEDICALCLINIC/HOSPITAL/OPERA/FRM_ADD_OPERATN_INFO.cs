using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.OPERA
{

    public partial class FRM_ADD_OPERATN_INFO :MEDICALCLINIC.HOSPITAL. BaseHospital
    {
        decimal T_TOTAL_CURRENT_OP = 0, T_PRICE_TYP = 0, pricetyp;
       
        int BOOK_CODE,OP_CODE, PERSON_CODE, FLAG_INS=0;
        int? flag_p = -1, OPER_ID, idtyp;
        
        public FRM_ADD_OPERATN_INFO(int BOOK_ID,int OPE_CODE,int F_INS,int PERSON_ID)
        {
            InitializeComponent();
            BOOK_CODE = BOOK_ID;
            OP_CODE = OPE_CODE;
            FLAG_INS = F_INS;
            PERSON_CODE = PERSON_ID;
        }
        public FRM_ADD_OPERATN_INFO( )
        {
            InitializeComponent();

        }
        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_drage_Click(object sender, EventArgs e)
        {
            CR_BUTTONS.FRM_DRAGE FRM = new CR_BUTTONS.FRM_DRAGE(2);
            FRM.ShowDialog();
        }

        private void FRM_ADD_OPERATN_INFO_Load(object sender, EventArgs e)
        {
          
            //this.gET_DOCTOR_BY_GROUP5TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP5, new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))));
            //this.gET_DOCTOR_BY_GROUP3TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP3, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            //this.gET_DOCTOR_BY_GROUP2TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP2, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            //this.gET_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            //this.gET_DOCTOR_BY_GROUP4TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP4, new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))));
            //this.gET_DOCTOR_BY_GROUP6TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP6, new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))));
            this.gET_H_OPERATION_TYPE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_TYPE_NAME_CODE, "");
            this.gET_H_ALL_DOCTOR_PROCESSOR1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALL_DOCTOR_PROCESSOR1, "");
            this.gET_H_ALL_DOCTOR_PROCESSOR2TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALL_DOCTOR_PROCESSOR2, "");
            this.gET_H_DOCTOR_TAKDEERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DOCTOR_TAKDEER, "");
            this.gET_H_DOCTOR_TAKDEER1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DOCTOR_TAKDEER1, "");
            this.gET_H_DOCTOR_TAKDEER2TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DOCTOR_TAKDEER2, "");
            this.gET_H_ALL_DOCTOR_PROCESSORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALL_DOCTOR_PROCESSOR, "");
            DR_PROSComboBox.SelectedIndex = -1;
            TK_ASSComboBox1.SelectedIndex = -1;
            TK_ASSComboBox2.SelectedIndex = -1;
            TKComboBox.SelectedIndex = -1;
            ASSComboBox1.SelectedIndex = -1;
            ASSComboBox2.SelectedIndex = -1;
            TXT_PRICE.Text = "";
            TXT_FINDING.Text = "";
            TXT_DRAG.Text = "";
            

            if (FLAG_INS==2)
            {
                this.gET_H_OPERATION_INFOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO, new System.Nullable<int>(((int)(System.Convert.ChangeType(OP_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                DR_PROSComboBox.SelectedValue = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO.Rows[0][4]);
                TKComboBox.SelectedValue = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO.Rows[0][5]);
                this.gET_A_H_OPEARTION_BY_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_A_H_OPEARTION_BY_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(DR_PROSComboBox.SelectedValue, typeof(int))))));
                sTATE_NAMEComboBox.SelectedValue = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO.Rows[0][2]);
                TXT_PRICE.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO.Rows[0][6].ToString();
                TXT_FINDING.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO.Rows[0][27].ToString();
                TXT_DRAG.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO.Rows[0][28].ToString();
            }

        }

       
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (DR_PROSComboBox.SelectedIndex == -1 || ASSComboBox1.SelectedIndex == -1|| ASSComboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى أختيار حقل الدكتور المعالج او المساعدين اولا");
                   
                    errorProvider1.SetError(DR_PROSComboBox, CLS.TXT_NULL);
                    return;
                }
                if (TKComboBox.SelectedIndex == -1 || TK_ASSComboBox1.SelectedIndex == -1 || TK_ASSComboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى أختيار حقل دكتور التخدير او المساعدين اولا");
                    errorProvider1.SetError(TKComboBox, CLS.TXT_NULL); return;
                }
                if (sTATE_NAMEComboBox.SelectedIndex == -1  )
                {
                    MessageBox.Show("يرجى أختيار حقل العمليةاولا");
                    errorProvider1.SetError(sTATE_NAMEComboBox, CLS.TXT_NULL); return;
                }

                 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {


                    if (FLAG_INS==1)
                    {
                        var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();


                        for (int i = 0; i < gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows.Count; i++)
                        {
                            if ((Boolean)gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[3].Value == true)
                            {

                                idtyp = Convert.ToInt32(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[0].Value);
                                String ITEMNAME = gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[1].Value.ToString();

                                pricetyp = Convert.ToDecimal(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[2].Value);
                                T_PRICE_TYP = T_PRICE_TYP + pricetyp;
                               

                                 
                            }

                        }
                        var INSERTEDF = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                        INSERTEDF.P_UPDATE_H_FLAGE_MONEY(

                    BOOK_CODE
                   , CLS.USER_CODE
                   , Convert.ToDecimal(TXT_PRICE.Text)
                   , false
                   , ref CLS.SUBMIT_FLAG

                 );
                        T_TOTAL_CURRENT_OP = Convert.ToDecimal(TXT_PRICE.Text) - T_PRICE_TYP;
                        
                        OPER_ID = int.Parse(INSERTED.P_INSERT_T_H_OPERATION_PROCED
                        (

                          Convert.ToInt32(sTATE_NAMEComboBox.SelectedValue)
                         , BOOK_CODE
                         , TXT_FINDING.Text
                         , TXT_DRAG.Text
                         , ""
                         , 1
                         , 1
                         , true
                         , DATE_DAY.Text
                         , TIME_FROM.Text
                         , TIME_TO.Text
                         , Convert.ToInt32(DR_PROSComboBox.SelectedValue)
                         , Convert.ToInt32(ASSComboBox1.SelectedValue)
                         , Convert.ToInt32(ASSComboBox2.SelectedValue)
                         , Convert.ToInt32(TKComboBox.SelectedValue)
                         , Convert.ToInt32(TK_ASSComboBox1.SelectedValue)
                         , Convert.ToInt32(TK_ASSComboBox2.SelectedValue)
                         , CLS.USER_CODE
                         , T_TOTAL_CURRENT_OP
                         , ref flag_p
                         , TXT_STATMENT.Text
                         , ref CLS.SUBMIT_FLAG

                          ).ToString());



                        decimal TOT_T = 0;
                        DataTable fd = new DataTable();
                        this.gET_INVOICE_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_INVOICE_BOOKING, BOOK_CODE.ToString(),1);

                        fd = this.mEDICAL_CLINIC_DBDataSet.GET_INVOICE_BOOKING;
                        int id_invo = Convert.ToInt32(fd.Rows[0][0]);

                        var INSERTINVDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                        var INSERTDGV = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                        for (int i = 0; i < gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows.Count; i++)
                        {
                            if ((Boolean)gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[3].Value == true)
                            {

                                idtyp = Convert.ToInt32(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[0].Value);
                                String ITEMNAME =  gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[1].Value.ToString();

                                pricetyp = Convert.ToDecimal(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[2].Value);
                              //  T_PRICE_TYP = T_PRICE_TYP + pricetyp;
                                INSERTDGV.P_INSERT_T_H_OPERATION_BOOKING(
                                  OPER_ID
                                , idtyp
                                , pricetyp
                                , false
                                , ref CLS.SUBMIT_FLAG

                                );

                                INSERTINVDET.P_INSERT_T_INVOICE_DETAILS(
                                    id_invo
                                  , idtyp
                                  , ITEMNAME
                                  , 1
                                  , pricetyp
                                  , pricetyp
                                  , 0
                                  , ref CLS.SUBMIT_FLAG);
                            }

                        }

                       // T_TOTAL_CURRENT_OP = Convert.ToDecimal(TXT_PRICE.Text) - T_PRICE_TYP;
                       
                        decimal L_PRICE = Convert.ToDecimal(fd.Rows[0][3]);
                        TOT_T = T_TOTAL_CURRENT_OP + L_PRICE;


                        var EDITINVOIC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                        EDITINVOIC.P_UPDATE_T_INVOICES_PRICE_(
                                id_invo, 0, TOT_T,1, ref CLS.SUBMIT_FLAG
                                );




                        //var INSERTINVC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //ID_INVC = int.Parse(INSERTINVC.P_INSERT_T_INVOICES(
                        //DATE_DAY.Value
                        //, 0
                        //, T_TOTAL
                        //, BOOK_CODE
                        //, false
                        //, 0
                        //, CLS.USER_CODE
                        //, ref CLS.SUBMIT_FLAG).ToString());

                        //تسجيل القيود اليومية 


                        var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        int BOXID;
                        BOXID = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                               BOOK_CODE
                             , System.DateTime.Now
                             , "عن اجور عملية المريض: "  
                             , 13
                             , 0
                             , true
                             , CLS.USER_CODE
                             , ref CLS.SUBMIT_FLAG
                             , CLS.BRANCH_ID
                             , 0
                             ).ToString());



                        if (Convert.ToDecimal(pRECENTAGE_DOCTPR.Text) == 0)
                        {

                            // اجل بدون نسبة

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BOXID
                            , PERSON_CODE
                            , "المريض"
                            , 0
                            , 0
                            , T_TOTAL_CURRENT_OP
                            , 0
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );
                            //TO
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BOXID
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , T_TOTAL_CURRENT_OP
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );


                            if (T_PRICE_TYP > 0)
                            {
                                int BOXIDS;
                                BOXIDS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                  BOOK_CODE
                                , System.DateTime.Now
                                , "عن اجور عملية المريض: "  
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
                                BOXIDS
                               , PERSON_CODE
                               , "المريض"
                               , 0
                               , 0
                               , T_PRICE_TYP
                               , 0
                               , "من حساب الزبون الى حساب العمليات"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );
                                //TO
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BOXIDS
                                , 4002
                                , "محلقات العمليات"
                                , 0
                                , 0
                                , 0
                                , T_PRICE_TYP
                                , "من حساب الزبون الى حساب محلقات العمليات"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                            }







                        }

                        if (Convert.ToDecimal(pRECENTAGE_DOCTPR.Text) > 0)
                        {


                            decimal DoctorPrecentage = Convert.ToDecimal(pRECENTAGE_DOCTPR.Text);
                            decimal TakderPrecentage = Convert.ToDecimal(pRECENTAGE_TK.Text);
                            decimal ServicePrecentage = 100 - (DoctorPrecentage + TakderPrecentage);
                            decimal DebitPatient = 0;
                            decimal TOTAL_PRICE = 0;
                            decimal CreditService = 0;
                            decimal CreditDoctor = 0;
                            decimal CreditTakder = 0;

                            if (Convert.ToDecimal(TXT_PRICE.Text) >= Convert.ToDecimal(mINI_PRICELabel1.Text))
                            {
                                TOTAL_PRICE = T_TOTAL_CURRENT_OP;
                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditTakder = TOTAL_PRICE * TakderPrecentage / 100;
                                CreditService = TOTAL_PRICE - (CreditDoctor + CreditTakder);
                            }
                            else
                            {

                                TOTAL_PRICE = T_TOTAL_CURRENT_OP;

                                DebitPatient = TOTAL_PRICE;
                                //CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditTakder = Convert.ToDecimal(mINI_PRICELabel1.Text) * TakderPrecentage / 100;
                                CreditService = Convert.ToDecimal(mINI_PRICELabel1.Text) * ServicePrecentage / 100;
                                CreditDoctor = TOTAL_PRICE -(CreditTakder+ CreditService);
                            }
                            // اجل  نسبة
                            //240
                            //50
                            //137


                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BOXID
                            ,PERSON_CODE
                            , "المريض"
                            , 0
                            , 0
                            , DebitPatient
                            , 0
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );
                            //TO
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BOXID
                            , 4003
                            , "العمليات"
                            , 0
                            , 0
                            , 0
                            , CreditService
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );
                            //TO
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BOXID
                            , Convert.ToInt32(DR_PROSComboBox.SelectedValue)
                            , "الطبيب الجراح"
                            , 0
                            , 0
                            , 0
                            , CreditDoctor
                            , "من حساب الزبون الى حساب الطبيب الجراح"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            //TO
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BOXID
                            , Convert.ToInt32(TKComboBox.SelectedValue)
                            , "طبيب التخدير"
                            , 0
                            , 0
                            , 0
                            , CreditTakder
                            , "من حساب الزبون الى حساب طبيب التخدير"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );



                            if (T_PRICE_TYP > 0)
                            {
                                int BOXIDS;
                                BOXIDS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                  BOOK_CODE
                                , System.DateTime.Now
                                , "عن اجور عملية المريض: " 
                                , 18
                                , 0
                                , true
                                , CLS.USER_CODE
                                , ref CLS.SUBMIT_FLAG
                                , CLS.BRANCH_ID
                                , 0
                                ).ToString());


                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                BOXIDS
                               , PERSON_CODE
                               , "المريض"
                               , 0
                               , 0
                               , T_PRICE_TYP
                               , 0
                               , "من حساب الزبون الى حساب العمليات"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );
                                //TO
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BOXIDS
                                , 4002
                                , "محلقات العمليات"
                                , 0
                                , 0
                                , 0
                                , T_PRICE_TYP
                                , "من حساب الزبون الى حساب محلقات العمليات"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                            }







                        }


                        //نهاية القيود اليومية


                    }

                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        
                            try
                            {
                                Cursor.Current = Cursors.WaitCursor;




                             

                                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                                {
                                    MessageBox.Show("حدد الطابعة أولا");
                                    SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                                    FRM.ShowDialog();
                                    return;

                                }
                             

                               // HOSPITAL.PRINT.FRM_PRINT_PERSONINF myfrrm = new HOSPITAL.PRINT.FRM_PRINT_PERSONINF();
                               // HOSPITAL.PRINT.RPT_PERSON_BOOK mmprt = new HOSPITAL.PRINT.RPT_PERSON_BOOK();
                               // PrinterSettings settings = new PrinterSettings();
                               // SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString);
                               // string ServerName = SqlConnectionStringBuilder.DataSource;
                               // string DatabaseName = SqlConnectionStringBuilder.InitialCatalog;
                               // Boolean IntegratedSecurity = SqlConnectionStringBuilder.IntegratedSecurity;
                               // string UserID = SqlConnectionStringBuilder.UserID;
                               // string Password = SqlConnectionStringBuilder.Password;

                               // foreach (CrystalDecisions.CrystalReports.Engine.Table Table in mmprt.Database.Tables)
                               // {
                               //     CrystalDecisions.Shared.TableLogOnInfo TableLogOnInfo = Table.LogOnInfo;
                               //     TableLogOnInfo.ConnectionInfo.ServerName = ServerName;
                               //     TableLogOnInfo.ConnectionInfo.DatabaseName = DatabaseName;
                               //     TableLogOnInfo.ConnectionInfo.IntegratedSecurity = IntegratedSecurity;

                               //     if (IntegratedSecurity != true)
                               //     {
                               //         TableLogOnInfo.ConnectionInfo.UserID = UserID;
                               //         TableLogOnInfo.ConnectionInfo.Password = Password;
                               //     }
                               //     Table.ApplyLogOnInfo(TableLogOnInfo);
                               // }
                               // //  mmprt.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DataBase, Properties.Settings.Default.ID, Properties.Settings.Default.Password);

                               // // mmprt.SetParameterValue("@ID_BOOK", CLS.ID_BOOK_PRINT);
                               // // mmprt.SetParameterValue("@DOCT_CODE", CLS.USER_CODE);
                               // mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                               // DataTable DTDATA = new DataTable();
                               // DataTable DTHDR = new DataTable();
                               // this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(OPER_ID, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
                               // DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID;
                               // this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 1);
                               // DTHDR = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                               // //lصدر بيانات الصورة
                               // mmprt.Subreports[0].SetDataSource(DTHDR);//lصدر بيانات الجدول الاخر
                               // mmprt.SetDataSource(DTDATA);
                               // myfrrm.crystalReportViewer1.ReportSource = mmprt;
                               //// myfrrm.ShowDialog();
                               // mmprt.PrintToPrinter(1, false, 0, 0);
                                Cursor.Current = Cursors.Default;

                            }
                            catch (System.Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message);
                            }
                       


                        MSG.Msg.Alart(AlartType.Save);
                        DR_PROSComboBox.SelectedIndex = -1;
                        ASSComboBox1.SelectedIndex = -1;
                        ASSComboBox2.SelectedIndex = -1;
                        TKComboBox.SelectedIndex = -1;
                        TK_ASSComboBox2.SelectedIndex = -1;
                        TK_ASSComboBox1.SelectedIndex = -1;
                        TXT_DRAG.Text = "";
                        TXT_FINDING.Text = "";


                        
                    }
                    else
                    {

                      //  MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }

            catch (Exception EX)
            {
              //  MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }
 
        
       

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_A_H_OPEARTION_BY_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_A_H_OPEARTION_BY_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(DR_PROSComboBox.SelectedValue, typeof(int))))));
            }
            catch (System.Exception )
            {
                
            }
}

      

        

        

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            FRM_ADD_OPERATN_INFO_Load(null, null);
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (DR_PROSComboBox.SelectedIndex == -1 || ASSComboBox1.SelectedIndex == -1 || ASSComboBox2.SelectedIndex == -1)
                {
                    MSG.Msg.Alart(AlartType.Error, "يرجى أدخال البينات بشكل صحيح ثم اعادة المحاولة");
                    return;
                    //errorProvider1.SetError(DR_PROSComboBox, CLS.TXT_NULL);
                }
                if (TKComboBox.SelectedIndex == -1 || TK_ASSComboBox1.SelectedIndex == -1 || TK_ASSComboBox2.SelectedIndex == -1)
                {

                    errorProvider1.SetError(TKComboBox, CLS.TXT_NULL);
                }
                if (sTATE_NAMEComboBox.SelectedIndex == -1)
                {

                    errorProvider1.SetError(sTATE_NAMEComboBox, CLS.TXT_NULL);
                }

                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {



                    if (FLAG_INS==2)
                    {
                        var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        int? flag_p = -1, OPER_ID;
                        OPER_ID = int.Parse(INSERTED.P_UPDATE_T_H_OPERATION_PROCED
                        (
                          OP_CODE
                         , Convert.ToInt32(sTATE_NAMEComboBox.SelectedValue)
                         , BOOK_CODE
                         , TXT_FINDING.Text
                         , TXT_DRAG.Text
                         , ""
                         , 1
                         , 1
                         , true
                         , DATE_DAY.Text
                         , TIME_FROM.Text
                         , TIME_TO.Text
                         , Convert.ToInt32(DR_PROSComboBox.SelectedValue)
                         , Convert.ToInt32(ASSComboBox1.SelectedValue)
                         , Convert.ToInt32(ASSComboBox2.SelectedValue)
                         , Convert.ToInt32(TKComboBox.SelectedValue)
                         , Convert.ToInt32(TK_ASSComboBox1.SelectedValue)
                         , Convert.ToInt32(TK_ASSComboBox2.SelectedValue)
                         , CLS.USER_CODE
                         , Convert.ToDecimal(TXT_PRICE.Text)
                         , ref flag_p
                         ,TXT_STATMENT.Text
                         , ref CLS.SUBMIT_FLAG

                          ).ToString());
                    }

                  
                       
                        if (CLS.SUBMIT_FLAG == 1)
                        {

                            MSG.Msg.Alart(AlartType.Update);
                            DR_PROSComboBox.SelectedIndex = -1;
                            ASSComboBox1.SelectedIndex = -1;
                            ASSComboBox2.SelectedIndex = -1;
                            TKComboBox.SelectedIndex = -1;
                            TK_ASSComboBox2.SelectedIndex = -1;
                            TK_ASSComboBox1.SelectedIndex = -1;
                            TXT_DRAG.Text = "";
                            TXT_FINDING.Text = "";
                        }






                   
                }
              
            }

            catch (Exception EX)
            {
                //  MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void DR_PROSComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_A_H_OPEARTION_BY_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_A_H_OPEARTION_BY_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(DR_PROSComboBox.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {

            }
        }

        

        
        private void TXT_PRICE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                this.TXT_PRICE.Text = Convert.ToDecimal(this.TXT_PRICE.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PRICE.SelectionStart = TXT_PRICE.TextLength;

            }
            catch
            {
                return;
            }
        }

      

       
    }
}
