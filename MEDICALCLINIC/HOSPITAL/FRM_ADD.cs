using MEDICALCLINIC.HOSPITAL.PRINT;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL
{
    public partial class FRM_ADD : MEDICALCLINIC.HOSPITAL.BaseHospital
    {
        DataTable dt = new DataTable();
        DataTable dtJ = new DataTable();
        DataTable dtA = new DataTable();
        DataTable dtCT = new DataTable();
        DataTable dtOP = new DataTable();
        DataTable dt1 = new DataTable();
        String ID_BED;
        DateTime D_F;
        DateTime D_E;
        String N_P;
        int idtyp;
        int F_GET_BED = 1;
        int CATEGId;
        bool ACTIVR_F = false;
        int BookId, BookIdc, OPER_ID, ID_INVC;
        int? flage_print = -1;
        decimal pricetyp, T_PRICE_TYP_SANAD = 0, T_TOTAL_OP = 0;
        public FRM_ADD()  :base()
        {
            InitializeComponent();
        }

        private void FRM_ADD_Load(object sender, EventArgs e)
        { var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            this.v_SUG_ADDRESSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_SUG_ADDRESS);
            this.t_SEX_STATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.T_SEX_STATE);
            this.v_GET_SUG_JOBTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_SUG_JOB);
            this.v_A_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR);
            //this.v_A_H_OPERATIONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_OPERATION);
            this.v_GET_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR);
            this.v_H_GET_CONVERTED_TYPETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_H_GET_CONVERTED_TYPE);
            this.v_GET_EMP_ACCOUNTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_EMP_ACCOUNT);
            this.v_GET_H_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_PERSON);
            this.gET_H_OPERATION_TYPE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_TYPE_NAME_CODE, "");
            this.gET_A_H_OPEARTION_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_A_H_OPEARTION_CATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            this.gET_A_H_OPEARTION_BY_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_A_H_OPEARTION_BY_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            this.gET_H_ALL_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALL_DOCTOR, "");
            this.gET_H_ALL_DOCTOR_PROCESSORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALL_DOCTOR_PROCESSOR, "");
            this.gET_H_DOCTOR_TAKDEERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DOCTOR_TAKDEER, "");
            FILL_floor();
            dt = this.mEDICAL_CLINIC_DBDataSet.V_GET_H_PERSON;
            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasource.Add(dt.Rows[i][1].ToString());
            }
            this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
            this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            dtJ = this.mEDICAL_CLINIC_DBDataSet.V_GET_SUG_JOB;
            AutoCompleteStringCollection datasourceJ = new AutoCompleteStringCollection();
            for (int i = 0; i < dtJ.Rows.Count; i++)
            {
                datasourceJ.Add(dtJ.Rows[i][0].ToString());
            }
            this.jOBComboBox.AutoCompleteCustomSource = datasourceJ;
            this.jOBComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.jOBComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            dtA = this.mEDICAL_CLINIC_DBDataSet.V_SUG_ADDRESS;
            AutoCompleteStringCollection datasourceA = new AutoCompleteStringCollection();
            for (int i = 0; i < dtA.Rows.Count; i++)
            {
                datasourceA.Add(dtA.Rows[i][0].ToString());
            }
            this.aDDRESS_PERSComboBox.AutoCompleteCustomSource = datasourceA;
            this.aDDRESS_PERSComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.aDDRESS_PERSComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            dtCT = this.mEDICAL_CLINIC_DBDataSet.GET_A_H_OPEARTION_CATEG;
            AutoCompleteStringCollection datasourceCT = new AutoCompleteStringCollection();
            for (int i = 0; i < dtCT.Rows.Count; i++)
            {
                datasourceCT.Add(dtCT.Rows[i][1].ToString());
            }
            this.nAME_OP_CATEGComboBox.AutoCompleteCustomSource = datasourceCT;
            this.nAME_OP_CATEGComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.nAME_OP_CATEGComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            dtOP = this.mEDICAL_CLINIC_DBDataSet.GET_A_H_OPEARTION_BY_DR;
            AutoCompleteStringCollection datasourceOP = new AutoCompleteStringCollection();
            for (int i = 0; i < dtOP.Rows.Count; i++)
            {
                datasourceOP.Add(dtOP.Rows[i][1].ToString());
            }
            this.dESC_NAMEComboBox.AutoCompleteCustomSource = datasourceOP;
            this.dESC_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.dESC_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            aDDRESS_PERSComboBox.SelectedIndex = -1;
            cONV_SIDEComboBox.SelectedIndex = -1;
            fLOOR_NAMEComboBox.SelectedIndex = -1;
            nAME_ROOMComboBox.SelectedIndex = -1;
            dOCTOR_NAMEComboBoxPROSS.SelectedIndex = -1;
            COMB_TAKDEER.SelectedIndex = -1;
            ACCOUNTANT_ComboBox.SelectedIndex = -1;
            pERSON_NAMEComboBox.SelectedIndex = -1;
            pERSON_NAMEComboBox.Focus();

        }



        private void fLOOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (fLOOR_NAMEComboBox.SelectedIndex > -1)
                {
                    this.gET_H_ISBOOKING_ROOMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ISBOOKING_ROOM, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(fLOOR_NAMEComboBox.SelectedValue, typeof(int))))));
                    nAME_ROOMComboBox.SelectedIndex = -1;
                }
                //this.gET_H_ISBOOKING_ROOMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ISBOOKING_ROOM, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType( fLOOR_NAMEComboBox.SelectedValue, typeof(int))))));
                //DataTable DTR = new DataTable();


                // this.gET_H_ROOM_BYFLOOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ROOM_BYFLOOR_NAME_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(fLOOR_NAMEComboBox.SelectedValue, typeof(int))))));
                //nAME_ROOMComboBox.SelectedIndex =- 1;

                //DTR = this.mEDICAL_CLINIC_DBDataSet.GET_H_ROOM_BYFLOOR_NAME_CODE;
                //for (int i =0;i< DTR.Rows.Count - 1;  i++)
                //{
                //    DataRow dr = DTR.Rows[i];
                //    if (dr["ID_FLOOR"] == this.mEDICAL_CLINIC_DBDataSet.GET_H_ISBOOKING_ROOM[i][0] && dr["ID_ROOM"] == this.mEDICAL_CLINIC_DBDataSet.GET_H_ISBOOKING_ROOM[i][1])
                //        dr.Delete();
                //}
                //DTR.AcceptChanges();
                //nAME_ROOMComboBox.DataSource = DTR;
                //nAME_ROOMComboBox.DisplayMember = "NAME_ROOM";
                //nAME_ROOMComboBox.ValueMember = "ID_ROOM";
                //nAME_ROOMComboBox.BindingContext = this.BindingContext;
                //  nAME_ROOMComboBox.SelectedIndex = -1;
            }
            catch (System.Exception EX)
            {
                 System.Windows.Forms.MessageBox.Show(EX.Message);
            }
        }

        void cLEARDATAFORM()
        {
            aDDRESS_PERSComboBox.SelectedIndex = -1;
            cONV_SIDEComboBox.SelectedIndex = -1;
            fLOOR_NAMEComboBox.SelectedIndex = -1;
            nAME_ROOMComboBox.SelectedIndex = -1;
            dOCTOR_NAMEComboBoxPROSS.SelectedIndex = -1;
            COMB_TAKDEER.SelectedIndex = -1;
            ACCOUNTANT_ComboBox.SelectedIndex = -1;
            pERSON_NAMEComboBox.SelectedIndex = -1;
            pERSON_NAMEComboBox.Focus();
            sEX_NAMEComboBox.SelectedIndex = -1;
            jOBComboBox.SelectedIndex = -1;
            TXT_AGE.Clear();
            TXT_PHONE.Clear();
            TXT_PRICE.Clear();
            iD_NO_FTextBox.Clear();
            iD_NO_PERSONTextBox.Clear();
            iD_PAGE_FTextBox.Clear();
            iD_RECORD_FTextBox.Clear();
            iD_PAGE_PERSONTextBox.Clear();
            iD_RECORD_PERSONTextBox.Clear();
            fAHER_NAMETextBox.Clear();
            nAME_OP_CATEGComboBox.SelectedIndex = -1;
            dESC_NAMEComboBox.SelectedIndex = -1;
            DATE_FROM.Value = DateTime.Now;
            DATE_TO.Value = DateTime.Now;
            LBL_ID_BOOKOP.Text = "0";
            for (int i = 0; i < gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows.Count; i++)
            {
                gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[3].Value = false;
            }
             
        }

        private void BTN_ADD_PERSON_Click(object sender, EventArgs e)
        {
            ACTIVR_F = true;
            HOSPITAL.SETTING_H.FRM_H_PERSON FRM = new HOSPITAL.SETTING_H.FRM_H_PERSON(); FRM.ShowDialog();
        }

        private void FRM_ADD_Activated(object sender, EventArgs e)
        {

            if (ACTIVR_F == true)
            {
                this.v_GET_H_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_PERSON);
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
                ACTIVR_F = false;
            }

        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dOCTOR_NAMEComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //this.gET_A_H_OPEARTION_BY_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_A_H_OPEARTION_BY_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBoxPROSS.SelectedValue, typeof(int))))));
            //    //this.gET_BOOK_TYPE_BY_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOK_TYPE_BY_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBoxPROSS.SelectedValue, typeof(int))))));
            //    //this.gET_DISASE_TYPE_BY_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DISASE_TYPE_BY_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBoxPROSS.SelectedValue, typeof(int))))));
            //    ////dISEASE_NAMEComboBox.SelectedIndex = -1;
            //    //bOOK_NAMEComboBox.SelectedIndex = -1;
            //    //dESC_NAMEComboBox.SelectedIndex = -1;
            //}
            //catch (System.Exception ex)
            //{
            //    // System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }


         

        private void pic_exit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

         
        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {

                var INSERTED_ISS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                CLS.CLIENT_CODE = pERSON_NAMEComboBox.SelectedValue.ToInt(); ;
                INSERTED_ISS.P_H_CHECK_IS_BOOKING(Convert.ToInt32(CLS.CLIENT_CODE), Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue), Convert.ToDateTime(DATE_FROM.Value), Convert.ToDateTime(DATE_TO.Value), ref CLS.SUBMIT_IS_BOOK);
                if (CLS.SUBMIT_IS_BOOK == 0)
                {
                    MessageBox.Show("‘عذرأ,لقد قمت مسبقا بالحجز لهذا المريض بنفس المعلومات", CLS.TITEL_MESG);
                    return;
                }

                if (fLOOR_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد الطابق اولا", CLS.TITEL_MESG);
                    return;
                }
                if (nAME_ROOMComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد الغرفة اولا", CLS.TITEL_MESG);
                    return;
                }
                this.p_H_CHECKROOM_IS_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING, new System.Nullable<int>(((int)(System.Convert.ChangeType(fLOOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_ROOMComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), ref CLS.SUBMIT_FLAG);
                if (this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING.Rows.Count > 0)
                {

                    D_F = Convert.ToDateTime(this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING.Rows[0][2]);
                    D_E = Convert.ToDateTime(this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING.Rows[0][3]);
                    N_P = this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING.Rows[0][1].ToString();
                    MessageBox.Show("(" + N_P + ")\n" + "\nالغرفة الحالية محجوزة في الفترة" + "\n" + D_F.ToString("dd/M/yyyy", CultureInfo.InvariantCulture) + "-من\n" + D_E.ToString("dd/M/yyyy", CultureInfo.InvariantCulture) + "-الى\n" + "", "", MessageBoxButtons.OK);
                    return;

                }

                if (dOCTOR_NAMEComboBoxPROSS.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد دكتور المعالج اولا", CLS.TITEL_MESG);
                    return;
                }
             
                if (COMB_TAKDEER.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد التخدير اولا", CLS.TITEL_MESG);
                    return;
                }
              
                if (ACCOUNTANT_ComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد المحاسب اولا", CLS.TITEL_MESG);
                    return;
                }
                if (cONV_SIDEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد جهة التحويل اولا", CLS.TITEL_MESG);
                    return;
                }

               
                if (ID_BED == string.Empty)
                {
                    MessageBox.Show("رجاءاً حدد السرير اولا", CLS.TITEL_MESG);
                    return;
                }
                if (dOCTOR_NAMEComboBoxPROSS.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد الطبيب اولا", CLS.TITEL_MESG);
                    return;
                }
                if (COMB_TAKDEER.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد طبيب التخدير أولا", CLS.TITEL_MESG);
                    return;
                }
             
                if (TXT_PRICE.Text == "" || TXT_PRICE.Text == string.Empty)
                {
                    MessageBox.Show("رجاءاً حدد مبلغ العملية اولا", CLS.TITEL_MESG);
                    return;
                }

                if (Properties.Settings.Default.PRINTER_NAME == "" || Properties.Settings.Default.PRINTER_NAME==string.Empty)
                {
                    MessageBox.Show("رجاءاً حدد الطابعة اولا", CLS.TITEL_MESG);
                    SETTING.FRM_LIST_PRINTER fr = new SETTING.FRM_LIST_PRINTER();
                    fr.ShowDialog();
                    
                }







              
                    var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTEDop = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTEDper = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTEDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTINVC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTDGV = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTINVDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTEDC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                   



                   


                    if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                    {



                    ////اضافة فئة عملية او عملية اذا كانت غير موجودة
                    ///
                    if (nAME_OP_CATEGComboBox.SelectedIndex == -1 && nAME_OP_CATEGComboBox.Text != string.Empty)
                    {
                        CATEGId = int.Parse(INSERTEDC.P_INSERT_T_H_OPERATION_CATEG(

                                  nAME_OP_CATEGComboBox.Text
                                , true
                                , ref CLS.SUBMIT_FLAG

                               ).ToString());
                        nAME_OP_CATEGComboBox.SelectedValue = CATEGId;
                    }
                    else
                    if (nAME_OP_CATEGComboBox.Text == String.Empty)
                    {
                        MSG.Msg.Alart(AlartType.Error);
                        return;
                    }
                    else
                    {
                        CATEGId = Convert.ToInt32(nAME_OP_CATEGComboBox.SelectedValue);
                    }
                    /////ااضافة عملية
                    if (dESC_NAMEComboBox.SelectedIndex == -1 && dESC_NAMEComboBox.Text != string.Empty)
                    {

                        INSERTEDop.P_INSERT_T_DESCRTION(
                        CLS.CHEECK_CODE,
                        ref CLS.OP_CODE,
                        dESC_NAMEComboBox.Text,
                        Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue),
                        0,
                        0,
                        0,
                        0,
                        CATEGId,
                        true,
                        ref CLS.SUBMIT_FLAG);
                        dESC_NAMEComboBox.SelectedValue = CLS.OP_CODE;
                    }
                    else
                    if (dESC_NAMEComboBox.Text == String.Empty)
                    {
                        MSG.Msg.Alart(AlartType.Error);
                        return;
                    }
                    else
                    {
                        CLS.OP_CODE = Convert.ToInt32(dESC_NAMEComboBox.SelectedValue);
                    }

                    /////اضافة فئة عملية او عملية اذا كانت غير موجودة-نهاية 


                    //اضافة معلومات المريض
                    if (pERSON_NAMEComboBox.SelectedIndex == -1)
                    {
                        try
                        {

                            //if (pERSON_NAMEComboBox.SelectedIndex == -1)
                            //{
                            //    CLS.CHEECK_CODE = 0;

                            //}
                            //else
                            //{
                            //    CLS.CHEECK_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);
                            //}

                            INSERTEDper.P_INSERT_T_PERSON

                                (
                                  0
                                , ref CLS.CLIENT_CODE
                                , pERSON_NAMEComboBox.Text
                                , 0
                                , Convert.ToInt32(sEX_NAMEComboBox.SelectedValue)
                                , TXT_AGE.Text
                                , TXT_PHONE.Text
                                , aDDRESS_PERSComboBox.Text
                                , null
                                , ""
                                , ""
                                , jOBComboBox.Text
                                , iD_NO_PERSONTextBox.Text
                                , iD_RECORD_PERSONTextBox.Text
                                , iD_PAGE_PERSONTextBox.Text
                                , iD_NO_FTextBox.Text
                                , iD_RECORD_FTextBox.Text
                                , iD_PAGE_FTextBox.Text
                                , 0
                                , fAHER_NAMETextBox.Text
                                , true
                                , ref CLS.SUBMIT_FLAG);


                            if (CLS.SUBMIT_FLAG != 1)
                            {

                                MSG.Msg.Alart(AlartType.Error);

                            }

                        }

                        catch (Exception EX)
                        {
                            MessageBox.Show(EX.Message, CLS.TITEL_MESG);
                        }
                    }
                    else
                    {

                        CLS.CLIENT_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);
                    }
                    //اضافة معلومات المريض-نهاية

                    //اضافة حجز
                      BookId = int.Parse(
                      INSERTED.P_INSERT_T_H_BOOKING(

                      CLS.CLIENT_CODE
                    , Convert.ToInt32(dOCTOR_NAMEComboBoxSTAY.SelectedValue)
                    , Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue)
                    , 0
                    , 11
                    , Convert.ToInt32(fLOOR_NAMEComboBox.SelectedValue)
                    , Convert.ToInt32(nAME_ROOMComboBox.SelectedValue)
                    , Convert.ToInt32(ID_BED)
                    , DATE_FROM.Value
                    , DATE_TO.Value
                    , 0
                    , 0
                    , ""
                    , 0
                    , Convert.ToInt32(cONV_SIDEComboBox.SelectedValue)
                    , 0
                    , CLS.USER_CODE
                    , Convert.ToDecimal(TXT_PRICE.Text)
                    , false
                    , Convert.ToInt32(COMB_TAKDEER.SelectedValue)
                    , Convert.ToInt32(ACCOUNTANT_ComboBox.SelectedValue)
                    , 0
                    , ref CLS.SUBMIT_FLAG).ToString());
                    BookIdc = int.Parse(
                    INSERTED.P_INSERT_T_BOOKING(
                    CLS.CLIENT_CODE
                  , Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue)
                  , ""
                  , ""
                  , ""
                  , ""
                  , ""
                  , ""
                  , Convert.ToDateTime(DATE_FROM.Value)
                  , false
                  , DATE_FROM.Text
                  , false
                  , ""
                  , true
                  , fLOOR_NAMEComboBox.SelectedValue.ToInt()
                  , 1
                  , false
                  , ref CLS.SUBMIT_FLAG).ToString());
                    BookId = int.Parse(
                    INSERTED.P_INSERT_T_BOOKING(
                    CLS.CLIENT_CODE
                  , Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue)
                  , ""
                  , ""
                  , ""
                  , ""
                  , ""
                  , ""
                  , Convert.ToDateTime(DATE_FROM.Value)
                  , false
                  , DATE_FROM.Text
                  , false
                  , ""
                  , true
                  , fLOOR_NAMEComboBox.SelectedValue.ToInt()
                  , 1
                  , false
                  , ref CLS.SUBMIT_FLAG).ToString());
                    if (Convert.ToString(BookId) == String.Empty)
                        {
                            return;
                        }
                        else
                        if (CLS.SUBMIT_FLAG == 1)
                        {




                        for (int i = 0; i < gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows.Count; i++)
                        {
                            if ((Boolean)gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[3].Value == true)
                            {
                                decimal PRICEY=0;
                                PRICEY = Convert.ToDecimal(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[2].Value);
                                T_PRICE_TYP_SANAD = T_PRICE_TYP_SANAD + PRICEY;


                            }

                        }

                        T_TOTAL_OP = Convert.ToDecimal(TXT_PRICE.Text) - T_PRICE_TYP_SANAD;
                            if (cONV_SIDEComboBox.Text.Equals("مستشفى"))
                            {
                                T_TOTAL_OP = T_TOTAL_OP - 100000;
                            }
                           OPER_ID = int.Parse(INSERTEDT.P_INSERT_T_H_OPERATION_PROCED(
                           CLS.OP_CODE
                         , BookId
                         , ""
                         , ""
                         , ""
                         , 0
                         , 0
                         , false
                         , System.DateTime.Now.ToString()
                         , ""
                         , ""
                         , Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue)
                         , 0
                         , 0
                         , Convert.ToInt32(COMB_TAKDEER.SelectedValue)
                         , 0
                         , 0
                         
                         , CLS.USER_CODE
                         , T_TOTAL_OP
                         , ref flage_print
                         ,""
                         , ref CLS.SUBMIT_FLAG

                              ).ToString());
                        LBL_ID_BOOKOP.Text = OPER_ID.ToString();




                        for (int i = 0; i < gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows.Count; i++)
                        {
                            if ((Boolean)gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[3].Value == true)
                            {

                                idtyp = Convert.ToInt32(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[0].Value);
                                pricetyp = Convert.ToDecimal(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[2].Value);
                                String ITEMNAME = gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[1].Value.ToString();
                               
                                INSERTDGV.P_INSERT_T_H_OPERATION_BOOKING(
                                OPER_ID
                              , idtyp
                              , pricetyp
                              , false
                              , ref CLS.SUBMIT_FLAG

                              );

                                INSERTINVDET.P_INSERT_T_INVOICE_DETAILS(
                                ID_INVC
                              , idtyp
                              , ITEMNAME
                              , 1
                              , pricetyp
                              , pricetyp
                              , 0
                              , ref CLS.SUBMIT_FLAG);
                            }

                        }




                              ///هنا غيرت 
                            ID_INVC = int.Parse(INSERTINVC.P_INSERT_T_INVOICES(
                            DATE_FROM.Value
                            , 0
                            , TXT_PRICE.Text.ToDecimal()//T_TOTAL_OP
                            , BookId
                            , false
                            , 0
                            , CLS.USER_CODE
                            , ref CLS.SUBMIT_FLAG).ToString());


                            INSERTINVDET.P_INSERT_T_INVOICE_DETAILS(
                                ID_INVC
                              , 0
                              , "العملية"
                              , 0
                              , 0
                              , 0
                              , 0
                              , ref CLS.SUBMIT_FLAG);


                            ////////////
                           // if (cONV_SIDEComboBox.Text.Equals("مستشفى"))
                           // {
                           //     INSERTINVDET.P_INSERT_T_INVOICE_DETAILS(
                           //ID_INVC
                           //, 0
                           //, "استقطاع تحويل مستشفى"
                           //, 0
                           //, 100000
                           //, 100000
                           //, 0
                           //, ref CLS.SUBMIT_FLAG);
                           // }
                            ////////////
                            //تسجيل القيود اليومية 


                            int BOXID;
                            BOXID = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                   BookId
                                 , System.DateTime.Now
                                 , "عن اجور عملية المريض: " + pERSON_NAMEComboBox.Text
                                 , 13
                                 , 0
                                 , true
                                 , CLS.USER_CODE
                                 , ref CLS.SUBMIT_FLAG 
                                 ,CLS.BRANCH_ID
                                 ,0
                                 ).ToString());



                            if (Convert.ToDecimal(pRECENTAGE_DOCTPROCSS.Text) == 0)
                            {

                                if (cONV_SIDEComboBox.Text.Equals("مستشفى"))
                                {
                                    //T_TOTAL_OP = T_TOTAL_OP - 100000;
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                   (
                                    BOXID
                                   , 2113
                                   , "المستشفى"
                                   , 0
                                   , 0
                                   , 0
                                   , 100000
                                   , "من حساب المستشفى الى حساب الزبون"
                                   , 1
                                   , 1
                                   , ref CLS.SUBMIT_FLAG
                                    );

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BOXID
                            , CLS.CLIENT_CODE
                            , "المريض"
                            , 0
                            , 0
                            , 100000
                            , 0
                            , "من حساب الزبون الى حساب المستشفى "
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                                }
                                // اجل بدون نسبة

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                 BOXID
                                , CLS.CLIENT_CODE
                                , "المريض"
                                , 0
                                , 0
                                , T_TOTAL_OP
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
                                , T_TOTAL_OP
                                , "من حساب الزبون الى حساب العمليات"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );


                                if (T_PRICE_TYP_SANAD > 0)
                                {
                                    int BOXIDS;
                                    BOXIDS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                      BookId
                                    , System.DateTime.Now
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
                                    BOXIDS
                                   , CLS.CLIENT_CODE
                                   , "المريض"
                                   , 0
                                   , 0
                                   , T_PRICE_TYP_SANAD
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
                                    , T_PRICE_TYP_SANAD
                                    , "من حساب الزبون الى حساب محلقات العمليات"
                                    , 1
                                    , 1
                                    , ref CLS.SUBMIT_FLAG
                                     );

                                }







                            }

                            if (Convert.ToDecimal(pRECENTAGE_DOCTPROCSS.Text) > 0)
                            {
                                if (cONV_SIDEComboBox.Text.Equals("مستشفى"))
                                {
                                    // T_TOTAL_OP = T_TOTAL_OP - 100000;
                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                   (
                                    BOXID
                                   , 2113
                                   , "مستشفى"
                                   , 0
                                   , 0
                                   , 0
                                   , 100000
                                   , "من حساب المستشفى الى حساب الزبون"
                                   , 1
                                   , 1
                                   , ref CLS.SUBMIT_FLAG
                                    );

                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                BOXID
                               , CLS.CLIENT_CODE
                               , "المريض"
                               , 0
                               , 0
                               , 100000
                               , 0
                               , "من حساب الزبون الى حساب المستشفى "
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );

                                }

                                decimal DoctorPrecentage = Convert.ToDecimal(pRECENTAGE_DOCTPROCSS.Text);
                                decimal TakderPrecentage = Convert.ToDecimal(pRECENTAGE_DOCTTK.Text);
                                decimal ServicePrecentage = 100 - (DoctorPrecentage + TakderPrecentage);
                                decimal DebitPatient = 0;
                                decimal TOTAL_PRICE = 0;
                                decimal CreditService = 0;
                                decimal CreditDoctor = 0;
                                decimal CreditTakder = 0;

                                //if (Convert.ToDecimal(TXT_PRICE.Text) >= Convert.ToDecimal(mINI_PRICELabel1.Text))
                                //{
                                TOTAL_PRICE = T_TOTAL_OP;
                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditTakder = TOTAL_PRICE * TakderPrecentage / 100;
                                CreditService = TOTAL_PRICE - (CreditDoctor + CreditTakder);
                                //}
                                //else
                                //{

                                //    TOTAL_PRICE = T_TOTAL_OP;

                                //    DebitPatient = TOTAL_PRICE;

                                //    CreditTakder = Convert.ToDecimal(mINI_PRICELabel1.Text) * TakderPrecentage / 100;
                                //    CreditService = Convert.ToDecimal(mINI_PRICELabel1.Text) * ServicePrecentage / 100;
                                //    CreditDoctor = TOTAL_PRICE - (CreditTakder + CreditService);
                                //}
                                // اجل  نسبة

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                 BOXID
                                , CLS.CLIENT_CODE
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
                                , Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue)
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
                                , Convert.ToInt32(COMB_TAKDEER.SelectedValue)
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



                                if (T_PRICE_TYP_SANAD > 0)
                                {
                                    int BOXIDS;
                                    BOXIDS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                      BookId
                                    , System.DateTime.Now
                                    , "عن اجور عملية المريض: " + pERSON_NAMEComboBox.Text
                                    , 18
                                    , 0
                                    , true
                                    , CLS.USER_CODE
                                   
                                    , ref CLS.SUBMIT_FLAG , CLS.BRANCH_ID,0
                                    ).ToString());


                                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                   (
                                    BOXIDS
                                   , CLS.CLIENT_CODE
                                   , "المريض"
                                   , 0
                                   , 0
                                   , T_PRICE_TYP_SANAD
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
                                    , T_PRICE_TYP_SANAD
                                    , "من حساب الزبون الى حساب محلقات العمليات"
                                    , 1
                                    , 1
                                    , ref CLS.SUBMIT_FLAG
                                     );

                                }







                            }


                            //نهاية القيود اليومية

                        

                       
                            MSG.Msg.Alart(AlartType.Save);
                            //try
                            //{
                            //    Cursor.Current = Cursors.WaitCursor;
                            //    // CLS.ID_BOOK_PRINT = Convert.ToInt32(TXT_ID_BOOK.Text);

                            //    if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                            //    {
                            //        MessageBox.Show("حدد الطابعة أولا");
                            //        SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                            //        FRM.ShowDialog();
                            //        return;

                            //    }
                            //    //  BTN_SAVEE_Click(null, null);

                            //    HOSPITAL.PRINT.FRM_PRINT_PERSONINF myfrrm = new HOSPITAL.PRINT.FRM_PRINT_PERSONINF();
                            //    HOSPITAL.PRINT.RPT_PERSON_BOOK mmprt = new HOSPITAL.PRINT.RPT_PERSON_BOOK();
                            //    PrinterSettings settings = new PrinterSettings();
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
                            //    //DataTable DTFTR = new DataTable();
                            //    //DataTable DTBDY = new DataTable();
                            //    //DataTable DTLGO = new DataTable();
                            //    //this.gET_IMG_HEADER_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_HEADER_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                            //    //this.gET_IMG_FOOTER_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_FOOTER_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                            //    //this.gET_IMG_BODY_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_BODY_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                            //    //this.gET_IMG_LOGO_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_LOGO_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                            //    this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(OPER_ID, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
                            //    DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID;
                            //    this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 1);
                            //    DTHDR = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                            //    //lصدر بيانات الصورة
                            //    mmprt.Subreports[0].SetDataSource(DTHDR);//lصدر بيانات الجدول الاخر
                            //    mmprt.SetDataSource(DTDATA);
                            //    myfrrm.crystalReportViewer1.ReportSource = mmprt;
                            //    // myfrrm.ShowDialog();
                            //    mmprt.PrintToPrinter(1, false, 0, 0);
                            //    Cursor.Current = Cursors.Default;
                            //    FRM_ADD_Load(null, null);
                            //}
                            //catch (System.Exception ex)
                            //{
                            //    System.Windows.Forms.MessageBox.Show(ex.Message);
                            //}

                            //this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), DATE_FROM.Value, DATE_TO.Value);
                            //  FILL_BEDTOCHECK();

                            //MessageBox.Show(CLS.COMP_MSG_SAVE, CLS.TITEL_MESG);
                            //MSG.Msg.Alart(AlartType.Save);
                            // dOCTOR_NAMECOM.SelectedIndex = -1;

                        }

                    }
                
                
               
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
                //return;
            }
        }



 
        //تاب كل الحجوزات
        int  FLAGE_SEARCH;

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
                    //BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
                    //BTN_MENU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
                    BTN_MENU.BackColor = System.Drawing.Color.FromArgb(16, 127, 201); ;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)22.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.White;
                    BTN_MENU.Size = new System.Drawing.Size((greenTabList1.Width / DT.Rows.Count) - 25, (flowLayoutPanel7.Height-8));
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





        void FILL_BEDTOCHECK()
        {
            try
            {
                int i;
                flowLayoutPanel8.Controls.Clear();
                if (F_GET_BED == 1)
                {
                    this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), DT_TODY.Value, System.DateTime.Now);

                }
                if (F_GET_BED == 2)
                {
                    this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))), DT_B_F_TD.Value, DT_B_T_TD.Value);

                }
                if (F_GET_BED == 3)
                {
                    this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))), DT_ENTR_F_D.Value, DT_ENTR_T_D.Value);

                }
                if (F_GET_BED == 4)
                {
                    this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))), DT_ENTR_TODY.Value, System.DateTime.Now);

                }
                if (F_GET_BED == 5)
                {
                    this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(5, typeof(int))))), DT_LEAVE_TODY.Value, System.DateTime.Now);

                }
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
                    CLS.DESC_NAME = DT.Rows[i][4].ToString();
                    Button BTN_MENU = new Button();
                    BTN_MENU.Click += Click_MENU_BEDTOCHECK;
                    //  BTN_MENU.BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
                    BTN_MENU.FlatAppearance.BorderColor = Color.Black; //System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.FlatAppearance.BorderSize = 3;
                    BTN_MENU.BackColor = Color.White;
                    
                    //BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.FromArgb(16, 127, 201);
                    BTN_MENU.Size = new System.Drawing.Size(250, 150);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text =  CLS.DESC_NAME;//this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[i][1].ToString();
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
                            LBLNAME.BorderStyle = BorderStyle.FixedSingle;
                            LBLNAME.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                            BTN_MENU.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][0].ToString();
                            LBLNAME.ForeColor = System.Drawing.Color.White;
                            LBLNAME.TextAlign = ContentAlignment.MiddleCenter;
                            BTN_MENU.Controls.Add(LBLNAME);


                            LBL.Text = DT.Rows[i][5].ToString() + "-" + DT.Rows[i][4].ToString();// + "-" + DT.Rows[i][3].ToString();
                            LBL.BackColor = Color.Red;
                            BTN_MENU.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                            LBL.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                            LBL.BorderStyle = BorderStyle.FixedSingle;
                            LBL.Dock = DockStyle.Top;
                            BTN_MENU.ForeColor = System.Drawing.Color.White;
                            LBL.TextAlign = ContentAlignment.MiddleCenter;
                           
                            BTN_MENU.Controls.Add(LBL);
                            BTN_MENU.FlatAppearance.BorderColor = Color.Black; //System.Drawing.Color.FromArgb(16, 127, 201);
                            BTN_MENU.FlatAppearance.BorderSize = 3;
                            break;


                            //  }

                        }

                        else
                        {

                            LBLNAME.Text = "غير محجوزه";
                            LBLNAME.BackColor = Color.White;
                            LBLNAME.Dock = DockStyle.Bottom;
                            LBLNAME.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                            LBLNAME.BorderStyle = BorderStyle.FixedSingle;
                            //BTN_MENU.ForeColor = System.Drawing.Color.Blue;
                            LBLNAME.TextAlign = ContentAlignment.MiddleCenter;
                            BTN_MENU.Controls.Add(LBLNAME);

                            LBL.Text = DT.Rows[i][5].ToString() + "-" + DT.Rows[i][4].ToString();// + "-" + DT.Rows[i][3].ToString();
                            LBL.BackColor = Color.White;
                            BTN_MENU.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                            LBL.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                            LBL.BorderStyle = BorderStyle.FixedSingle;
                            LBL.Dock = DockStyle.Top;
                            BTN_MENU.ForeColor = System.Drawing.Color.Black;
                            LBL.TextAlign = ContentAlignment.MiddleCenter;
                            BTN_MENU.FlatAppearance.BorderColor = Color.Black; //System.Drawing.Color.FromArgb(16, 127, 201);
                            BTN_MENU.FlatAppearance.BorderSize = 3;
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
           
            try
            {
                int ID_OP=0;
                DataTable DD = new DataTable();
                // Label LBL = new Label();
                Button BTN_MENU_CLICK = default(Button);
                       BTN_MENU_CLICK = (Button)Sender;
                if (BTN_MENU_CLICK.Text != String.Empty)
                {
                    //string v = BTN_MENU_CLICK.Text;
                    this.gET_H_BOOK_DATE_E_LTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOK_DATE_E_L, new System.Nullable<int>(((int)(System.Convert.ChangeType(BTN_MENU_CLICK.Text, typeof(int))))));
                    DD = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOK_DATE_E_L;
                    if (DD.Rows.Count>0)
                    {
                    DateTime DN = System.DateTime.Now;
                    DateTime DE = DateTime.Parse(DD.Rows[0][1].ToString());
                    ID_OP = Convert.ToInt32(DD.Rows[0][4]);
                    if (DE.Date < DN.Date)
                    {
                        MessageBox.Show("المريض الحالي انتهت فترة الحجز الخاصة بة ");
                    }
                    }
                   
                    HOSPITAL.FRM_DETAILS_PROCEDURE frm = new FRM_DETAILS_PROCEDURE(BTN_MENU_CLICK.Text, ID_OP);
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



       

       

        private void BTN_TODY_Click(object sender, EventArgs e)
        {
            F_GET_BED = 1;
        }

        private void BTN_B_T_TD_Click(object sender, EventArgs e)
        {
            F_GET_BED = 2;
        }

        private void BTN_ENTR_T_D_Click(object sender, EventArgs e)
        {
            F_GET_BED = 3;
        }

        private void BTN_ENTR_TODY_Click(object sender, EventArgs e)
        {
            F_GET_BED = 4;
        }

        private void pERSON_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                sEX_NAMEComboBox.Focus();
            }
        }

        private void sEX_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_AGE.Focus();
            }
        }

        private void TXT_AGE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                jOBComboBox.Focus();
            }
        }

        private void jOBComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                aDDRESS_PERSComboBox.Focus();
            }
        }

        private void aDDRESS_PERSComboBox_KeyDown(object sender, KeyEventArgs e)
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
                iD_NO_PERSONTextBox.Focus();
            }
        }

        private void iD_NO_PERSONTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iD_RECORD_PERSONTextBox.Focus();
            }
        }

        private void iD_RECORD_PERSONTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iD_PAGE_PERSONTextBox.Focus();
            }
        }

        private void iD_PAGE_PERSONTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fAHER_NAMETextBox.Focus();
            }
        }

        private void fAHER_NAMETextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iD_NO_FTextBox.Focus();
            }
        }

        private void iD_NO_FTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iD_RECORD_FTextBox.Focus();
            }
        }

        private void iD_RECORD_FTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iD_PAGE_FTextBox.Focus();
            }
        }

        private void iD_PAGE_FTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cONV_SIDEComboBox.Focus();
            }
        }

        private void cONV_SIDEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DATE_FROM.Focus();
            }
        }

        private void DATE_FROM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DATE_TO.Focus();
            }
        }

        private void fLOOR_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nAME_ROOMComboBox.Focus();
            }
        }

        private void DATE_TO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fLOOR_NAMEComboBox.Focus();
            }
        }

        private void nAME_ROOMComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dOCTOR_NAMEComboBoxPROSS.Focus();
            }
        }

        private void dOCTOR_NAMEComboBoxPROSS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dOCTOR_NAMEComboBoxSTAY.Focus();
            }
        }

        private void dOCTOR_NAMEComboBoxSTAY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                COMB_TAKDEER.Focus();
            }
        }

        private void COMB_TAKDEER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dESC_NAMEComboBox.Focus();
            }
        }

        private void dESC_NAMEComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nAME_OP_CATEGComboBox.Focus();
            }
        }

        private void nAME_OP_CATEGComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ACCOUNTANT_ComboBox.Focus();
            }
        }

        private void ACCOUNTANT_ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PRICE.Focus();
            }
        }

        private void TXT_PRICE_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                var origText = this.TXT_PRICE.Text;

                this.TXT_PRICE.Text = Convert.ToDecimal(this.TXT_PRICE.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PRICE.SelectionStart = TXT_PRICE.TextLength;


                // }
            }
            catch
            {
                return;
            }
        }

       

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            cLEARDATAFORM();
        }

        private void BTN_SAVEPRINT_Click(object sender, EventArgs e)
        {
            try
            {

                var INSERTED_ISS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                CLS.CLIENT_CODE = pERSON_NAMEComboBox.SelectedValue.ToInt(); ;
                INSERTED_ISS.P_H_CHECK_IS_BOOKING(Convert.ToInt32(CLS.CLIENT_CODE), Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue), Convert.ToDateTime(DATE_FROM.Value), Convert.ToDateTime(DATE_TO.Value), ref CLS.SUBMIT_IS_BOOK);
                if (CLS.SUBMIT_IS_BOOK == 0)
                {
                    MessageBox.Show("‘عذرأ,لقد قمت مسبقا بالحجز لهذا المريض بنفس المعلومات", CLS.TITEL_MESG);
                    return;
                }

                if (fLOOR_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد الطابق اولا", CLS.TITEL_MESG);
                    return;
                }
                if (nAME_ROOMComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد الغرفة اولا", CLS.TITEL_MESG);
                    return;
                }
                this.p_H_CHECKROOM_IS_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING, new System.Nullable<int>(((int)(System.Convert.ChangeType(fLOOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_ROOMComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), ref CLS.SUBMIT_FLAG);
                if (this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING.Rows.Count > 0)
                {

                    D_F = Convert.ToDateTime(this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING.Rows[0][2]);
                    D_E = Convert.ToDateTime(this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING.Rows[0][3]);
                    N_P = this.mEDICAL_CLINIC_DBDataSet.P_H_CHECKROOM_IS_BOOKING.Rows[0][1].ToString();
                    MessageBox.Show("(" + N_P + ")\n" + "\nالغرفة الحالية محجوزة في الفترة" + "\n" + D_F.ToString("dd/M/yyyy", CultureInfo.InvariantCulture) + "-من\n" + D_E.ToString("dd/M/yyyy", CultureInfo.InvariantCulture) + "-الى\n" + "", "", MessageBoxButtons.OK);
                    return;

                }

                if (dOCTOR_NAMEComboBoxPROSS.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد دكتور المعالج اولا", CLS.TITEL_MESG);
                    return;
                }

                if (COMB_TAKDEER.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد التخدير اولا", CLS.TITEL_MESG);
                    return;
                }

                if (ACCOUNTANT_ComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد المحاسب اولا", CLS.TITEL_MESG);
                    return;
                }
                if (cONV_SIDEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد جهة التحويل اولا", CLS.TITEL_MESG);
                    return;
                }


                if (ID_BED == string.Empty)
                {
                    MessageBox.Show("رجاءاً حدد السرير اولا", CLS.TITEL_MESG);
                    return;
                }
                if (dOCTOR_NAMEComboBoxPROSS.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد الطبيب اولا", CLS.TITEL_MESG);
                    return;
                }
                if (COMB_TAKDEER.SelectedIndex == -1)
                {
                    MessageBox.Show("رجاءاً حدد طبيب التخدير أولا", CLS.TITEL_MESG);
                    return;
                }

                if (TXT_PRICE.Text == "" || TXT_PRICE.Text == string.Empty)
                {
                    MessageBox.Show("رجاءاً حدد مبلغ العملية اولا", CLS.TITEL_MESG);
                    return;
                }

                if (Properties.Settings.Default.PRINTER_NAME == "" || Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("رجاءاً حدد الطابعة اولا", CLS.TITEL_MESG);
                    SETTING.FRM_LIST_PRINTER fr = new SETTING.FRM_LIST_PRINTER();
                    fr.ShowDialog();

                }








                var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTEDop = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTEDper = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTEDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTINVC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTDGV = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTINVDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTEDC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    ////اضافة فئة عملية او عملية اذا كانت غير موجودة
                    ///
                    if (nAME_OP_CATEGComboBox.SelectedIndex == -1 && nAME_OP_CATEGComboBox.Text != string.Empty)
                    {
                        CATEGId = int.Parse(INSERTEDC.P_INSERT_T_H_OPERATION_CATEG(

                                  nAME_OP_CATEGComboBox.Text
                                , true
                                , ref CLS.SUBMIT_FLAG

                               ).ToString());
                        nAME_OP_CATEGComboBox.SelectedValue = CATEGId;
                    }
                    else
                    if (nAME_OP_CATEGComboBox.Text == String.Empty)
                    {
                        MSG.Msg.Alart(AlartType.Error);
                        return;
                    }
                    else
                    {
                        CATEGId = Convert.ToInt32(nAME_OP_CATEGComboBox.SelectedValue);
                    }
                    /////ااضافة عملية
                    if (dESC_NAMEComboBox.SelectedIndex == -1 && dESC_NAMEComboBox.Text != string.Empty)
                    {

                        INSERTEDop.P_INSERT_T_DESCRTION(
                        CLS.CHEECK_CODE,
                        ref CLS.OP_CODE,
                        dESC_NAMEComboBox.Text,
                        Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue),
                        0,
                        0,
                        0,
                        0,
                        CATEGId,
                        true,
                        ref CLS.SUBMIT_FLAG);
                        dESC_NAMEComboBox.SelectedValue = CLS.OP_CODE;
                    }
                    else
                    if (dESC_NAMEComboBox.Text == String.Empty)
                    {
                        MSG.Msg.Alart(AlartType.Error);
                        return;
                    }
                    else
                    {
                        CLS.OP_CODE = Convert.ToInt32(dESC_NAMEComboBox.SelectedValue);
                    }

                    /////اضافة فئة عملية او عملية اذا كانت غير موجودة-نهاية 


                    //اضافة معلومات المريض
                    if (pERSON_NAMEComboBox.SelectedIndex == -1)
                    {
                        try
                        {

                            //if (pERSON_NAMEComboBox.SelectedIndex == -1)
                            //{
                            //    CLS.CHEECK_CODE = 0;

                            //}
                            //else
                            //{
                            //    CLS.CHEECK_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);
                            //}

                            INSERTEDper.P_INSERT_T_PERSON

                                (
                                  0
                                , ref CLS.CLIENT_CODE
                                , pERSON_NAMEComboBox.Text
                                , 0
                                , Convert.ToInt32(sEX_NAMEComboBox.SelectedValue)
                                , TXT_AGE.Text
                                , TXT_PHONE.Text
                                , aDDRESS_PERSComboBox.Text
                                , null
                                , ""
                                , ""
                                , jOBComboBox.Text
                                , iD_NO_PERSONTextBox.Text
                                , iD_RECORD_PERSONTextBox.Text
                                , iD_PAGE_PERSONTextBox.Text
                                , iD_NO_FTextBox.Text
                                , iD_RECORD_FTextBox.Text
                                , iD_PAGE_FTextBox.Text
                                , 0
                                , fAHER_NAMETextBox.Text
                                , true
                                , ref CLS.SUBMIT_FLAG);


                            if (CLS.SUBMIT_FLAG != 1)
                            {

                                MSG.Msg.Alart(AlartType.Error);

                            }

                        }

                        catch (Exception EX)
                        {
                            MessageBox.Show(EX.Message, CLS.TITEL_MESG);
                        }
                    }
                    else
                    {

                        CLS.CLIENT_CODE = Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue);
                    }
                    //اضافة معلومات المريض-نهاية

                    //اضافة حجز
                    BookId = int.Parse(
                      INSERTED.P_INSERT_T_H_BOOKING(
                      CLS.CLIENT_CODE
                    , Convert.ToInt32(dOCTOR_NAMEComboBoxSTAY.SelectedValue)
                    , Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue)
                    , 0
                    , 11
                    , Convert.ToInt32(fLOOR_NAMEComboBox.SelectedValue)
                    , Convert.ToInt32(nAME_ROOMComboBox.SelectedValue)
                    , Convert.ToInt32(ID_BED)
                    , DATE_FROM.Value
                    , DATE_TO.Value
                    , 0
                    , 0
                    , ""
                    , 0
                    , Convert.ToInt32(cONV_SIDEComboBox.SelectedValue)
                    , 0
                    , CLS.USER_CODE
                    , Convert.ToDecimal(TXT_PRICE.Text)
                    , false
                    , Convert.ToInt32(COMB_TAKDEER.SelectedValue)
                    , Convert.ToInt32(ACCOUNTANT_ComboBox.SelectedValue)
                    , 0
                    , ref CLS.SUBMIT_FLAG).ToString());
                    BookIdc = int.Parse(
                         INSERTED.P_INSERT_T_BOOKING(
                         CLS.CLIENT_CODE
                       , Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue)
                       , ""
                       , ""
                       , ""
                       , ""
                       , ""
                       , ""
                       , Convert.ToDateTime(DATE_FROM.Value)
                       , false
                       , DATE_FROM.Text
                       , false
                       , ""
                       , true
                       , fLOOR_NAMEComboBox.SelectedValue.ToInt()
                       , 1
                       , false
                       , ref CLS.SUBMIT_FLAG).ToString());

                    if (Convert.ToString(BookId) == String.Empty)
                    {
                        return;
                    }

                    else
                    if (CLS.SUBMIT_FLAG == 1)
                    {




                        //for (int i = 0; i < gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows.Count; i++)
                        //{
                        //    if ((Boolean)gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[3].Value == true)
                        //    {
                        //        pricetyp = Convert.ToDecimal(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[2].Value);
                        //        T_PRICE_TYP_SANAD = T_PRICE_TYP_SANAD + pricetyp;


                        //    }

                        //}






                        for (int i = 0; i < gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows.Count; i++)
                        {
                            if ((Boolean)gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[3].Value == true)
                            {
                                decimal PRICEY =0;
                                PRICEY = Convert.ToDecimal(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[2].Value);
                                //T_PRICE_TYP = T_PRICE_TYP + pricetyp;
                                T_PRICE_TYP_SANAD = T_PRICE_TYP_SANAD + PRICEY;
                              
                            }

                        }
                        T_TOTAL_OP = Convert.ToDecimal(TXT_PRICE.Text) - T_PRICE_TYP_SANAD;
                        if (cONV_SIDEComboBox.Text.Equals("مستشفى"))
                        {
                            T_TOTAL_OP = T_TOTAL_OP - 100000;
                        }
                        OPER_ID = int.Parse(
                        INSERTEDT.P_INSERT_T_H_OPERATION_PROCED(
                        CLS.OP_CODE
                      , BookId
                      , ""
                      , ""
                      , ""
                      , 0
                      , 0
                      , false
                      , System.DateTime.Now.ToString()
                      , ""
                      , ""
                      , Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue)
                      , 0
                      , 0
                      , Convert.ToInt32(COMB_TAKDEER.SelectedValue)
                      , 0
                      , 0
                      , CLS.USER_CODE
                      , T_TOTAL_OP
                      , ref flage_print
                      , ""
                      , ref CLS.SUBMIT_FLAG

                           ).ToString());
                        LBL_ID_BOOKOP.Text = OPER_ID.ToString();





                        for (int i = 0; i < gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows.Count; i++)
                        {
                            if ((Boolean)gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[3].Value == true)
                            {
                                decimal pricetypNEW;
                                idtyp = Convert.ToInt32(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[0].Value);
                                pricetypNEW = Convert.ToDecimal(gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[2].Value);
                                String ITEMNAME = gET_H_OPERATION_TYPE_NAME_CODEDataGridView.Rows[i].Cells[1].Value.ToString();
                                
                              
                                INSERTDGV.P_INSERT_T_H_OPERATION_BOOKING(
                                OPER_ID
                              , idtyp
                              , pricetypNEW
                              , false
                              , ref CLS.SUBMIT_FLAG

                              );

                                INSERTINVDET.P_INSERT_T_INVOICE_DETAILS(
                                ID_INVC
                              , idtyp
                              , ITEMNAME
                              , 1
                              , pricetypNEW
                              , pricetypNEW
                              , 0
                              , ref CLS.SUBMIT_FLAG);
                            }

                        }

                       


                        ///هنا غيرت 
                        ID_INVC = int.Parse(INSERTINVC.P_INSERT_T_INVOICES(
                        DATE_FROM.Value
                        , 0
                        , TXT_PRICE.Text.ToDecimal()//T_TOTAL_OP
                        , BookId
                        , false
                        , 0
                        , CLS.USER_CODE
                        , ref CLS.SUBMIT_FLAG).ToString());


                        INSERTINVDET.P_INSERT_T_INVOICE_DETAILS(
                            ID_INVC
                          , 0
                          , "العملية"
                          , 0
                          , 0
                          , 0
                          , 0
                          , ref CLS.SUBMIT_FLAG);


                        ////////////
                        // if (cONV_SIDEComboBox.Text.Equals("مستشفى"))
                        // {
                        //     INSERTINVDET.P_INSERT_T_INVOICE_DETAILS(
                        //ID_INVC
                        //, 0
                        //, "استقطاع تحويل مستشفى"
                        //, 0
                        //, 100000
                        //, 100000
                        //, 0
                        //, ref CLS.SUBMIT_FLAG);
                        // }
                        ////////////
                        //تسجيل القيود اليومية 


                        int BOXID;
                        BOXID = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                               BookId
                             , System.DateTime.Now
                             , "عن اجور عملية المريض: " + pERSON_NAMEComboBox.Text
                             , 13
                             , 0
                             , true
                             , CLS.USER_CODE
                             , ref CLS.SUBMIT_FLAG
                             , CLS.BRANCH_ID
                             , 0
                             ).ToString());



                        if (Convert.ToDecimal(pRECENTAGE_DOCTPROCSS.Text) == 0)
                        {

                            if (cONV_SIDEComboBox.Text.Equals("مستشفى"))
                            {
                                //T_TOTAL_OP = T_TOTAL_OP - 100000;
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                BOXID
                               , 2113
                               , "المستشفى"
                               , 0
                               , 0
                               , 0
                               , 100000
                               , "من حساب المستشفى الى حساب الزبون"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                        (
                         BOXID
                        , CLS.CLIENT_CODE
                        , "المريض"
                        , 0
                        , 0
                        , 100000
                        , 0
                        , "من حساب الزبون الى حساب المستشفى "
                        , 1
                        , 1
                        , ref CLS.SUBMIT_FLAG
                         );

                            }
                            // اجل بدون نسبة

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BOXID
                            , CLS.CLIENT_CODE
                            , "المريض"
                            , 0
                            , 0
                            , T_TOTAL_OP
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
                            , T_TOTAL_OP
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );


                            if (T_PRICE_TYP_SANAD > 0)
                            {
                                int BOXIDS;
                                BOXIDS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                  BookId
                                , System.DateTime.Now
                                , "عن اجور عملية المريض: " + pERSON_NAMEComboBox.Text
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
                               , CLS.CLIENT_CODE
                               , "المريض"
                               , 0
                               , 0
                               , T_PRICE_TYP_SANAD
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
                                , T_PRICE_TYP_SANAD
                                , "من حساب الزبون الى حساب محلقات العمليات"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                            }







                        }

                        if (Convert.ToDecimal(pRECENTAGE_DOCTPROCSS.Text) > 0)
                        {
                            if (cONV_SIDEComboBox.Text.Equals("مستشفى"))
                            {
                                // T_TOTAL_OP = T_TOTAL_OP - 100000;
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                BOXID
                               , 2113
                               , "مستشفى"
                               , 0
                               , 0
                               , 0
                               , 100000
                               , "من حساب المستشفى الى حساب الزبون"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                           (
                            BOXID
                           , CLS.CLIENT_CODE
                           , "المريض"
                           , 0
                           , 0
                           , 100000
                           , 0
                           , "من حساب الزبون الى حساب المستشفى "
                           , 1
                           , 1
                           , ref CLS.SUBMIT_FLAG
                            );

                            }

                            decimal DoctorPrecentage = Convert.ToDecimal(pRECENTAGE_DOCTPROCSS.Text);
                            decimal TakderPrecentage = Convert.ToDecimal(pRECENTAGE_DOCTTK.Text);
                            decimal ServicePrecentage = 100 - (DoctorPrecentage + TakderPrecentage);
                            decimal DebitPatient = 0;
                            decimal TOTAL_PRICE = 0;
                            decimal CreditService = 0;
                            decimal CreditDoctor = 0;
                            decimal CreditTakder = 0;

                            //if (Convert.ToDecimal(TXT_PRICE.Text) >= Convert.ToDecimal(mINI_PRICELabel1.Text))
                            //{
                            TOTAL_PRICE = T_TOTAL_OP;
                            DebitPatient = TOTAL_PRICE;
                            CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                            CreditTakder = TOTAL_PRICE * TakderPrecentage / 100;
                            CreditService = TOTAL_PRICE - (CreditDoctor + CreditTakder);
                            //}
                            //else
                            //{

                            //    TOTAL_PRICE = T_TOTAL_OP;

                            //    DebitPatient = TOTAL_PRICE;

                            //    CreditTakder = Convert.ToDecimal(mINI_PRICELabel1.Text) * TakderPrecentage / 100;
                            //    CreditService = Convert.ToDecimal(mINI_PRICELabel1.Text) * ServicePrecentage / 100;
                            //    CreditDoctor = TOTAL_PRICE - (CreditTakder + CreditService);
                            //}
                            // اجل  نسبة

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BOXID
                            , CLS.CLIENT_CODE
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
                            , Convert.ToInt32(dOCTOR_NAMEComboBoxPROSS.SelectedValue)
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
                            , Convert.ToInt32(COMB_TAKDEER.SelectedValue)
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



                            if (T_PRICE_TYP_SANAD > 0)
                            {
                                int BOXIDS;
                                BOXIDS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                  BookId
                                , System.DateTime.Now
                                , "عن اجور عملية المريض: " + pERSON_NAMEComboBox.Text
                                , 18
                                , 0
                                , true
                                , CLS.USER_CODE

                                , ref CLS.SUBMIT_FLAG, CLS.BRANCH_ID, 0
                                ).ToString());


                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                               (
                                BOXIDS
                               , CLS.CLIENT_CODE
                               , "المريض"
                               , 0
                               , 0
                               , T_PRICE_TYP_SANAD
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
                                , T_PRICE_TYP_SANAD
                                , "من حساب الزبون الى حساب محلقات العمليات"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );

                            }







                        }


                        //نهاية القيود اليومية



                        this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(OPER_ID, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
                        dt = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID;
                        this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                        dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                        // dt1.Columns.Add("Header");
                        //dt1.Rows.Add("باسم");
                        LocalReport lr = new LocalReport();
                        lr.ReportEmbeddedResource = "MEDICALCLINIC.HOSPITAL.PRINT.BOOKING_PRINT.rdlc";
                        lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                        lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                        lr.Print();
                        MSG.Msg.Alart(AlartType.Save);
                        //try
                        //{
                        //    Cursor.Current = Cursors.WaitCursor;
                        //    // CLS.ID_BOOK_PRINT = Convert.ToInt32(TXT_ID_BOOK.Text);

                        //    if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                        //    {
                        //        MessageBox.Show("حدد الطابعة أولا");
                        //        SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                        //        FRM.ShowDialog();
                        //        return;

                        //    }
                        //    //  BTN_SAVEE_Click(null, null);

                        //    HOSPITAL.PRINT.FRM_PRINT_PERSONINF myfrrm = new HOSPITAL.PRINT.FRM_PRINT_PERSONINF();
                        //    HOSPITAL.PRINT.RPT_PERSON_BOOK mmprt = new HOSPITAL.PRINT.RPT_PERSON_BOOK();
                        //    PrinterSettings settings = new PrinterSettings();
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
                        //    //DataTable DTFTR = new DataTable();
                        //    //DataTable DTBDY = new DataTable();
                        //    //DataTable DTLGO = new DataTable();
                        //    //this.gET_IMG_HEADER_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_HEADER_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                        //    //this.gET_IMG_FOOTER_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_FOOTER_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                        //    //this.gET_IMG_BODY_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_BODY_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                        //    //this.gET_IMG_LOGO_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_IMG_LOGO_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                        //    this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(OPER_ID, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
                        //    DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID;
                        //    this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 1);
                        //    DTHDR = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                        //    //lصدر بيانات الصورة
                        //    mmprt.Subreports[0].SetDataSource(DTHDR);//lصدر بيانات الجدول الاخر
                        //    mmprt.SetDataSource(DTDATA);
                        //    myfrrm.crystalReportViewer1.ReportSource = mmprt;
                        //    // myfrrm.ShowDialog();
                        //    mmprt.PrintToPrinter(1, false, 0, 0);
                        //    Cursor.Current = Cursors.Default;
                        //    FRM_ADD_Load(null, null);
                        //}
                        //catch (System.Exception ex)
                        //{
                        //    System.Windows.Forms.MessageBox.Show(ex.Message);
                        //}

                        //this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), DATE_FROM.Value, DATE_TO.Value);
                        //  FILL_BEDTOCHECK();

                        //MessageBox.Show(CLS.COMP_MSG_SAVE, CLS.TITEL_MESG);
                        //MSG.Msg.Alart(AlartType.Save);
                        // dOCTOR_NAMECOM.SelectedIndex = -1;

                    }

                }



            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
                //return;
            }
        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType(OPER_ID, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
            dt = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID;
            this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
            LocalReport lr = new LocalReport();
            lr.ReportEmbeddedResource = "MEDICALCLINIC.HOSPITAL.PRINT.BOOKING_PRINT.rdlc";
            lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
            lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
             
            lr.Print();
        }

        private void TXT_PRICE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_SAVE.Focus();
            }
        }

        private void nAME_ROOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_BED_BY_FLOOR_ROOMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_BY_FLOOR_ROOM, new System.Nullable<int>(((int)(System.Convert.ChangeType(fLOOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_ROOMComboBox.SelectedValue, typeof(int))))));
                ID_BED = this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_BY_FLOOR_ROOM.Rows[0][0].ToString();
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
 
       

        private void BTN_LEAVE_TODY_Click(object sender, EventArgs e)
        {
            F_GET_BED = 5;
        }

       

        //نهاية تاب كل الحجوزات
    }
}
