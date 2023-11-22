using MEDICALCLINIC.HOSPITAL.PRINT;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace MEDICALCLINIC.SANAD
{
    public partial class FRM_SANAD : USERSE.masterfrm
    {
        int cost_center_code ;
        string SANAD_DISCRIPTION;
        int? B_CODE, BILL_SANAD, ACCOUNT_TO_CODE, ACCOUNT_FROM_CODE, ACCOUNT_F_CODE;
        int BILL_BOX, B_COD_BILL;
        // DateTime DATE_ENTRY;
        public FRM_SANAD()
        {
            InitializeComponent();

        }

        

        private void FRM_SANAD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_SANAD' table. You can move, or remove it, as needed.
            this.v_SANADTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_SANAD);
            this.gET_COST_CENTER_BY_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_BY_FLOOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.BRANCH_ID, typeof(int))))));
            nAME_COST_CENTERComboBox.SelectedIndex = -1;
            B_NAMEComboBox.SelectedIndex = -1;
            if (Properties.Settings.Default.COST_CENTER_TYPE ==0)
            {
                nAME_COST_CENTERComboBox.Visible = false;
                
            } 

        }
 

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                CLS.Flag_SANAD_S = 1;
                SANAD.FRM_SEARCH_ACCOUNT FRM = new SANAD.FRM_SEARCH_ACCOUNT();
                FRM.ShowDialog();


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
 

        private void Button2_Click(object sender, EventArgs e)
        {
            CLS.Flag_SANAD_S = 2;
            SANAD.FRM_SEARCH_ACCOUNT FRM = new SANAD.FRM_SEARCH_ACCOUNT();
            FRM.ShowDialog();
        }
 
        private void Button8_Click(object sender, EventArgs e)
        {
            FROM_ACCOUNTTextBoxX.Clear();
            ACCOUNT_FROMCODETextBoxX.Clear();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TO_ACCOUNTTextBoxX.Clear();
            ACCOUNT_TOCODETextBoxX.Clear();
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
        
        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            FRM_SEARCH_SANAD FRM = new FRM_SEARCH_SANAD();
            FRM.ShowDialog();
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            //var GET_BILL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            cleartextbox(this.groupBox2);
            B_NAMEComboBox.SelectedValue = -1;
            /// GET_BILL.P_GET_BILL_NUMBER(B_CODE, ref  BILL_SANAD);
            // BILL_NUMBERTextBoxX.Text = BILL_SANAD.ToString();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (B_NAMEComboBox.SelectedIndex == -1)
                {
                    errorProvider1.SetError(B_NAMEComboBox, CLS.TXT_NULL);
                    MessageBox.Show("يرجى تحديد نوع السند ");
                    return;
                }
                //               if (MessageBox.Show(CLS.Q_MSG_SAVE, CLS.OP_SAVE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {
                    ACCOUNT_FROMCODETextBoxX.IsEmpty();
                    ACCOUNT_TOCODETextBoxX.IsEmpty();
                    AMO_DEBIT_IQTextBoxX.IsEmpty();
                    //if (AMO_DEBIT_IQTextBoxX.Text == "")
                    //{
                    //    AMO_DEBIT_IQTextBoxX.Text = "0";
                    //}
                    //if (AMO_DEBITTextBoxX.Text == ""||AMO_DEBITTextBoxX.Text ==string.Empty)
                    //{
                        AMO_DEBITTextBoxX.Text = "0";
                   // }
                   
                    B_CODE = Convert.ToInt32(B_NAMEComboBox.SelectedValue);
                    var GET_BILL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    GET_BILL.P_GET_BILL_NUMBER(B_CODE, CLS.DOCTOR_CODE_GENE, ref BILL_SANAD);
                    BILL_NUMBERTextBoxX.Text = BILL_SANAD.ToString();
                    SANAD_DISCRIPTION = "\\من ح/ " + FROM_ACCOUNTTextBoxX.Text + " الى ح/ " + TO_ACCOUNTTextBoxX.Text;
                    if (B_COD_BILL==8)
                    {
                        ACCOUNT_F_CODE = Convert.ToInt32(ACCOUNT_FROMCODETextBoxX.Text);
                        if (Properties.Settings.Default.COST_CENTER_TYPE == 0)
                        {
                            cost_center_code = 110001;

                        }
                       
                    }
                    else
                     if (B_COD_BILL ==10)
                    {
                        ACCOUNT_F_CODE = Convert.ToInt32(ACCOUNT_TOCODETextBoxX.Text);
                        if (Properties.Settings.Default.COST_CENTER_TYPE == 0)
                        {
                            cost_center_code = 120001;

                        }
                       
                    }

                    ACCOUNT_TO_CODE = Convert.ToInt32(ACCOUNT_TOCODETextBoxX.Text);
                    var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    int BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                  BILL_SANAD
                                , System.DateTime.Now
                                , DESCRIPTIONTextBoxX.Text
                                , B_CODE
                                , 0
                                , true
                                , CLS.USER_CODE
                                ,ref CLS.SUBMIT_FLAG
                                , CLS.BRANCH_ID
                                , cost_center_code
                                ).ToString());

                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BookId
                                        , Convert.ToInt32(ACCOUNT_TOCODETextBoxX.Text)
                                        , SANAD_DISCRIPTION
                                        , Convert.ToDecimal(AMO_DEBITTextBoxX.Text)
                                        , 0
                                        , Convert.ToDecimal(AMO_DEBIT_IQTextBoxX.Text)
                                        , 0
                                        , DESCRIPTIONTextBoxX.Text
                                        , 1
                                        , 1
                                        , ref CLS.SUBMIT_FLAG
                                         );

                    //TO

                    INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                    (
                      BookId
                    , Convert.ToInt32(ACCOUNT_FROMCODETextBoxX.Text)
                     , SANAD_DISCRIPTION
                    , 0
                    , Convert.ToDecimal(AMO_DEBITTextBoxX.Text)
                    , 0
                    , Convert.ToDecimal(AMO_DEBIT_IQTextBoxX.Text)
                    , DESCRIPTIONTextBoxX.Text
                    , 1
                    , 1
                    , ref CLS.SUBMIT_FLAG
                     );

                    BILL_BOX = BookId;

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);

                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }

                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }


        }

        private void AMO_DEBIT_IQTextBoxX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var origText = this.AMO_DEBIT_IQTextBoxX.Text;

                this.AMO_DEBIT_IQTextBoxX.Text = Convert.ToDecimal(this.AMO_DEBIT_IQTextBoxX.Text).ToString("N0", new CultureInfo("en-US"));
                this.AMO_DEBIT_IQTextBoxX.SelectionStart = AMO_DEBIT_IQTextBoxX.TextLength;

            }
            catch
            {
                return;
            }
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
            {
                var DELETE_BOX = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                DELETE_BOX.P_DELETE_T_BOX_DETAILS(Convert.ToInt32(BILL_NUMBERTextBoxX.Text), Convert.ToInt32(B_NAMEComboBox.SelectedValue),0 , DateTime.Now, ref CLS.SUBMIT_FLAG);

                //DELETE_BOX.P_DELETE_T_BOX(Convert.ToInt32(BILL_NUMBERTextBoxX.Text + 1), Convert.ToInt32(B_NAMEComboBox.SelectedValue), "DELETE BY " + CLS.USER_NAME + " IN  " + DateTime.Now, ref CLS.SUBMIT_FLAG);
                if (CLS.SUBMIT_FLAG == 1)
                {
                    MSG.Msg.Alart(AlartType.Delete);

                }
                else
                {

                    MSG.Msg.Alart(AlartType.Error);

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nAME_COST_CENTERComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nAME_COST_CENTERComboBox.SelectedIndex>-1)
            {
                cost_center_code = nAME_COST_CENTERComboBox.SelectedValue.ToInt();
                TXT_COST_CENTER_CODE.Text= nAME_COST_CENTERComboBox.SelectedValue.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BTN_EDIT_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (B_NAMEComboBox.Text == "")
                {
                    errorProvider1.SetError(B_NAMEComboBox, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {
                    if (AMO_DEBIT_IQTextBoxX.Text == "")
                    {
                        AMO_DEBIT_IQTextBoxX.Text = "0";
                    }
                    if (AMO_DEBITTextBoxX.Text == "")
                    {
                        AMO_DEBITTextBoxX.Text = "0";
                    }
                    B_CODE = Convert.ToInt32(B_NAMEComboBox.SelectedValue);
                    var GET_BILL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    SANAD_DISCRIPTION = "\\من ح/ " + FROM_ACCOUNTTextBoxX.Text + " الى ح/ " + TO_ACCOUNTTextBoxX.Text;
                    ACCOUNT_FROM_CODE = Convert.ToInt32(ACCOUNT_FROMCODETextBoxX.Text);
                    var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERT_SALES.P_UPDATE_T_BOX(Convert.ToInt32(BILL_NUMBERTextBoxX.Text)

                                                                    , B_CODE
                                                                    , 0
                                                                    , Convert.ToInt32(ACCOUNT_FROMCODETextBoxX.Text)
                                                                    , SANAD_DISCRIPTION
                                                                    , 0
                                                                    , Convert.ToDecimal(AMO_DEBITTextBoxX.Text)
                                                                    , 0
                                                                    , Convert.ToDecimal(AMO_DEBIT_IQTextBoxX.Text)
                                                                    , DESCRIPTIONTextBoxX.Text
                                                                    , 1
                                                                    , 1
                                                                    , true
                                                                    , CLS.DOCTOR_CODE_GENE
                                                                    
                                                                    , ref CLS.SUBMIT_FLAG);


                    // ===================== TO
                    ACCOUNT_TO_CODE = Convert.ToInt32(ACCOUNT_TOCODETextBoxX.Text);

                    INSERT_SALES.P_UPDATE_T_BOX(Convert.ToInt32(BILL_NUMBERTextBoxX.Text)

                                                                    , B_CODE + 1
                                                                    , 0
                                                                    , ACCOUNT_TO_CODE
                                                                    , SANAD_DISCRIPTION
                                                                    , Convert.ToDecimal(AMO_DEBITTextBoxX.Text)
                                                                     , 0
                                                                     , Convert.ToDecimal(AMO_DEBIT_IQTextBoxX.Text)
                                                                     , 0
                                                                     , DESCRIPTIONTextBoxX.Text
                                                                    , 1
                                                                    , 1
                                                                    , true
                                                                    , CLS.DOCTOR_CODE_GENE
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
            catch (Exception ec)
            {
                MessageBox.Show("" + ec.Message);
            }
        }

        private void BTN_EXIT_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void B_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            B_COD_BILL = Convert.ToInt32(B_NAMEComboBox.SelectedValue);
        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            try
            {
                if (B_COD_BILL == 10)
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
                     this.gET_SANAD_TO_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType( BILL_BOX, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(ACCOUNT_F_CODE , typeof(int))))), B_COD_BILL);
                    dt = this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT;
                    this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(5, typeof(int))))));
                    dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                  
                    LocalReport lr = new LocalReport();

                    lr.ReportEmbeddedResource = "MEDICALCLINIC.SANAD.PRINT.RPT_SANAD_SRF.rdlc";
                    lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                    lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                    lr.Print();


                }
                else
                      if (B_COD_BILL == 8)
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
                    this.gET_SANAD_TO_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType(BILL_BOX, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(ACCOUNT_F_CODE, typeof(int))))), B_COD_BILL);
                    dt = this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT;
                    this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(5, typeof(int))))));
                    dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                    LocalReport lr = new LocalReport();
                    //lr.ReportEmbeddedResource = "MEDICALCLINIC.SANAD.PRINT.RPT_SANAD_QBD.rdlc";
                    //lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                    //lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                    //lr.Print();
                    lr.ReportEmbeddedResource = "MEDICALCLINIC.SANAD.PRINT.PRT_SANAD80MM.rdlc";
                    lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                    lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                    lr.Print();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

      
        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
