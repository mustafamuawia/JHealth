using DevComponents.DotNetBar.Controls;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.PURCHES
{
    public partial class FRM_PURCHERS : SETTING.baseclinicanddental
    {
        int? ID_PURCHES = 0;
        public FRM_PURCHERS()
        {
            InitializeComponent();
        }

        
        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (TXT_SUPPLIERS.Text == "")
                //{

                //    errorProvider1.SetError(TXT_SUPPLIERS, CLS.TXT_NULL);
                //}
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    // INSERTED.P_UPDATE_T_CLIENTS(Convert.ToInt32(TXT_BARCODE.Text), Convert.ToInt32(TXT_BARCODE.Text), CLIENT_NAME_ARTextBoxX.Text,
                    //CLIENT_NAME_ENTextBoxX.Text, " ", CLIENT_PHONE1TextBoxX.Text, CLIENT_PHONE2TextBoxX.Text,
                    //CLIENT_PHONE3TextBoxX.Text, CLIENT_EMAILETextBoxX.Text, CLIENT_NOTETextBoxX.Text, 0,
                    //1, 1, 1, true, ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        TXT_BARCODE.Text = CLS.CLIENT_CODE.ToString();
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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                //if (TXT_SUPPLIERS.Text == "")
                //{

                //    errorProvider1.SetError(TXT_SUPPLIERS, CLS.TXT_NULL);
                //}
 MSG.Msg.Alart(AlartType.Error);
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_CLIENT(Convert.ToInt32(TXT_BARCODE.Text), ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        TXT_BARCODE.Text = CLS.CLIENT_CODE.ToString();
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



        double Qnty = 1;
        private void CLIENT_CODETextBoxX_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtPrices.Text==String.Empty)
                {
                    MSG.Msg.Alart(AlartType.Error,"يرجى ادخال سعر البيع " );
                    return;
                }
                if (txtPricep.Text == String.Empty)
                {
                    MSG.Msg.Alart(AlartType.Error, "يرجى ادخال سعر الشراء ");
                    return;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if (txt_Qnty.Text!=String.Empty ||txt_Qnty.Text!="")
                    {

                        Qnty = txt_Qnty.Text.ToDouble();
                    }
                   

                    this.p_GET_A_ITEMS_BARCODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_A_ITEMS_BARCODE, TXT_BARCODE.Text);
                    DataTable DT = new DataTable();
                    DT = this.mEDICAL_CLINIC_DBDataSet.P_GET_A_ITEMS_BARCODE;
                    dataGridView1.Rows.Add(DT.Rows[0][1].ToString(), DT.Rows[0][2].ToString(), Qnty, txtPricep.Text,Convert.ToString (Qnty*txtPricep.Text.ToDouble()  ), txtPrices.Text, "حذف");
                    TXT_TOTAL.Text =
                      (from DataGridViewRow row in dataGridView1.Rows
                       where row.Cells[4].FormattedValue.ToString() != string.Empty
                       select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                    TXT_BARCODE.Clear();
                    txtPrices.Clear();
                    txtPricep.Clear();
                    TXT_BARCODE.Focus();
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        

        

        private void FRM_PURCHERS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            try
            {
                var INSER = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
              
                this.p_GET_A_SUPPLIERSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_A_SUPPLIERS);
                dOCTOR_NAMEComboBox.SelectedIndex = -1;
                cLIENT_NAME_ARComboBox.SelectedIndex = -1;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
             dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
       
            TXT_TOTAL.Text =
                     (from DataGridViewRow row in dataGridView1.Rows
                      where row.Cells[4].FormattedValue.ToString() != string.Empty
                      select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if(dataGridView1.Rows.Count>0)
                {

                    if (e.ColumnIndex == 2 || e.ColumnIndex == 3) 
                    {
                      //  String TOTAL = (Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value.ToString()) * Convert.ToDecimal(dataGridView1.CurrentRow.Cells[3].Value.ToString())).ToString();
                       // dataGridView1.CurrentRow.Cells[4].Value = TOTAL;
                        TXT_TOTAL.Text =
                        (from DataGridViewRow row in dataGridView1.Rows
                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                    }

                }


            }
            catch
            {
                return;
            }

        }

        private void TXT_PAY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TXT_REMAIN.Text = (Convert.ToDecimal(TXT_TOTAL.Text) - Convert.ToDecimal(TXT_PAY.Text)).ToString();
            }
            catch
            {
                return;
            }

        }

        private void TXT_PAID_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                //if (CLS.F_SEARCH_PAID != 1)
                //{
                    TXT_REMAIN.Text = (Convert.ToDecimal(TXT_TOTAL.Text) - Convert.ToDecimal(TXT_PAID.Text)).ToString();
               // }
            }
            catch
            {
                return;
            }
        }

        private void TXT_BARCODE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
                //MessageBox.Show("عذرا قم بادخال ارقام صحيحة او عشرية فقط");
            }
        }

        private void TXT_PAID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
                //MessageBox.Show("عذرا قم بادخال ارقام صحيحة او عشرية فقط");
            }
        }

        
        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            CLS.F_SEARCH_PAID = 1;
            PURCHES.FRM_SEARCH_PURCHES frm = new FRM_SEARCH_PURCHES();
            frm.ShowDialog();
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            TXT_BARCODE.Clear();
            TXT_ID_PURCHES.Clear();
            TXT_PAID.Clear();
            TXT_PAID.Text = "0.00";
            TXT_REMAIN.Clear();
            
            TXT_TOTAL.Clear();
            cLIENT_NAME_ARComboBox.SelectedValue = -1;
            var INSER = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            INSER.P_GET_BILL_NUMBER(2, CLS.DOCTOR_CODE_GENE, ref  ID_PURCHES);
            TXT_ID_PURCHES.Text = ID_PURCHES.ToString();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                var DEBI_CASH = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                if (TXT_ID_PURCHES.Text != string.Empty)
                {
                    MessageBox.Show("لايمكن أتمام العملية الرجاء التاكد ");
                    return;
                }
                if (TXT_PAID .Text == string.Empty)
                {
                    MessageBox.Show("رجاءا أدخل المبلغ المدفوع اولا ثم اعد المحاولة");
                    return;
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    int PurchaseID = int.Parse(INSERTED.P_INSERT_T_PURCHES(
                          Convert.ToDateTime(DATE_PURCHER.Value)
                        , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                        , CLS.DOCTOR_CODE_GENE
                        , CLS.USER_CODE
                        , Convert.ToDecimal(TXT_TOTAL.Text)
                        , Convert.ToDecimal(TXT_PAID.Text)
                        , Convert.ToDecimal(TXT_REMAIN.Text)
                        , ref  CLS.SUBMIT_FLAG).ToString());
                    int i;
                    for (i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        var INSERTED_DET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERTED_DET.P_INSERT_T_PURCHES_DETAILDS(PurchaseID

                            , dataGridView1.Rows[i].Cells[0].Value.ToString()
                            , dataGridView1.Rows[i].Cells[1].Value.ToString()
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value)
                            , 0
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString())
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString())
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value.ToString())
                            , ref  CLS.SUBMIT_FLAG);
                        ///////////////////////////////////////////////////
                    }
                    int ID_ORDER = PurchaseID;
                    int ID_PERSON = Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue);
                    string supplier_namme = cLIENT_NAME_ARComboBox.Text;

                    if (Convert.ToDouble(TXT_PAID.Text) == 0.00)
                    {


                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(
                                         PurchaseID
                                       , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                                       , Convert.ToDecimal(TXT_TOTAL.Text)
                                       , 2
                                       , 2
                                       , CLS.USER_CODE
                                       , 2
                                       , ref CLS.SUBMIT_FLAG);

                        CLS.SANAD_DISCRIPTION = "\\من ح/ " + supplier_namme + " الى ح/ " + "مشتريات";
                        var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , ID_PERSON
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_TOTAL.Text)
                                                                        , supplier_namme + "- مشتريات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , 5
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_TOTAL.Text)
                                                                        , 0
                                                                        , supplier_namme + "- مشتريات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);
                    }
                    //////////////////////

                    if (Convert.ToDouble(TXT_REMAIN.Text) == 0.00 && Convert.ToDouble(TXT_PAID.Text) > 0.00)
                    {
                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(
                                         PurchaseID
                                       , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                                       , Convert.ToDecimal(TXT_PAID.Text)
                                       , 1
                                       , 2
                                       , CLS.USER_CODE
                                       , 2
                                       , ref CLS.SUBMIT_FLAG);
                        CLS.SANAD_DISCRIPTION = "\\من ح/ " + supplier_namme + " الى ح/ " + "الصندوق";
                        var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , 5
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , 0
                                                                        , supplier_namme + "- الصندوق"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , 91
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , supplier_namme + "- الصندوق"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);
                    }

                    ///////////////////////////////////////////////////////////////////////////////////////////////    
                    if (Convert.ToDouble(TXT_REMAIN.Text) > 0.00 && Convert.ToDouble(TXT_PAID.Text) > 0.00)
                    {
                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(
                                         PurchaseID
                                       , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                                       , Convert.ToDecimal(TXT_PAID.Text)
                                       , 1
                                       , 2
                                       , CLS.USER_CODE
                                       , 2
                                       , ref CLS.SUBMIT_FLAG);
                        CLS.SANAD_DISCRIPTION = "\\من ح/ " + supplier_namme + " الى ح/ " + "الصندوق";
                        var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                               , System.DateTime.Now
                                                               , 2
                                                               , 0
                                                               , 5
                                                               , CLS.SANAD_DISCRIPTION
                                                               , 0
                                                               , 0
                                                               , Convert.ToDecimal(TXT_PAID.Text)
                                                               , 0
                                                               , supplier_namme + "-الصندوق"
                                                               , 1
                                                               , 1
                                                               , true
                                                               , CLS.USER_CODE
                                                               , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , 91
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , supplier_namme + "- الصندوق"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);

                        //////////////////////////////////////
                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(
                                        PurchaseID
                                      , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                                      , Convert.ToDecimal(TXT_REMAIN.Text)
                                      , 2
                                      , 2
                                      , CLS.USER_CODE
                                      , 2
                                      , ref CLS.SUBMIT_FLAG);
                        CLS.SANAD_DISCRIPTION = "\\من ح/ " + supplier_namme + " الى ح/ " + "المشتريات";
                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                           , System.DateTime.Now
                                                           , 2
                                                           , 0
                                                           , ID_PERSON
                                                           , CLS.SANAD_DISCRIPTION
                                                           , 0
                                                           , 0
                                                           , 0
                                                           , Convert.ToDecimal(TXT_REMAIN.Text)
                                                           , supplier_namme + "- مشتريات"
                                                           , 1
                                                           , 1
                                                           , true
                                                           , CLS.USER_CODE
                                                           , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , 5
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_REMAIN.Text)
                                                                        , 0
                                                                        , supplier_namme + "- مشتريات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);


                    }




                }
                //////////////////////////////////////////////////

                if (CLS.SUBMIT_FLAG == 1)
                {
                    MSG.Msg.Alart(AlartType.Save);
                   
                    dOCTOR_NAMEComboBox.SelectedIndex = -1;
                    cLIENT_NAME_ARComboBox.SelectedIndex = -1;
                }
                else
                {

                    MSG.Msg.Alart(AlartType.Error);


                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_ID_PURCHES.Text == string.Empty)
                {
                    MessageBox.Show("لايمكن أتمام العملية الرجاء التاكد ");
                    return;
                }
                var DEBI_CASH = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var DELE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                DELE.P_DELETE_FOR_EDIT_PURCHES(Convert.ToInt32(TXT_ID_PURCHES.Text), 2);

 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    int PurchaseID = int.Parse(INSERTED.P_INSERT_T_PURCHES(
                          Convert.ToDateTime(DATE_PURCHER.Value)
                        , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                        , CLS.DOCTOR_CODE_GENE
                        , CLS.USER_CODE
                        , Convert.ToDecimal(TXT_TOTAL.Text)
                        , Convert.ToDecimal(TXT_PAID.Text)
                        , Convert.ToDecimal(TXT_REMAIN.Text)
                        , ref  CLS.SUBMIT_FLAG).ToString());
                    int i;
                    for (i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        var INSERTED_DET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERTED_DET.P_INSERT_T_PURCHES_DETAILDS(PurchaseID

                            , dataGridView1.Rows[i].Cells[0].Value.ToString()
                            , dataGridView1.Rows[i].Cells[1].Value.ToString()
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value)
                            , 0
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value.ToString())
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value.ToString())
                            , Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value.ToString())
                            , ref  CLS.SUBMIT_FLAG);
                        ///////////////////////////////////////////////////
                    }
                    int ID_ORDER = PurchaseID;
                    int ID_PERSON = Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue);
                    string supplier_namme = cLIENT_NAME_ARComboBox.Text;

                    if (Convert.ToDouble(TXT_PAID.Text) == 0.00)
                    {


                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(
                                         PurchaseID
                                       , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                                       , Convert.ToDecimal(TXT_TOTAL.Text)
                                       , 2
                                       , 2
                                       , CLS.USER_CODE
                                       , 2
                                       , ref CLS.SUBMIT_FLAG);

                        CLS.SANAD_DISCRIPTION = "\\من ح/ " + supplier_namme + " الى ح/ " + "مشتريات";
                        var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , ID_PERSON
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_TOTAL.Text)
                                                                        , supplier_namme + "- مشتريات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , 5
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_TOTAL.Text)
                                                                        , 0
                                                                        , supplier_namme + "- مشتريات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);
                    }
                    //////////////////////

                    if (Convert.ToDouble(TXT_REMAIN.Text) == 0.00 && Convert.ToDouble(TXT_PAID.Text) > 0.00)
                    {
                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(
                                         PurchaseID
                                       , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                                       , Convert.ToDecimal(TXT_PAID.Text)
                                       , 1
                                       , 2
                                       , CLS.USER_CODE
                                       , 2
                                       , ref CLS.SUBMIT_FLAG);
                        CLS.SANAD_DISCRIPTION = "\\من ح/ " + supplier_namme + " الى ح/ " + "الصندوق";
                        var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , ID_PERSON
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , 0
                                                                        , supplier_namme + "- الصندوق"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , 91
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , supplier_namme + "- الصندوق"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);
                    }

                    ///////////////////////////////////////////////////////////////////////////////////////////////    
                    if (Convert.ToDouble(TXT_REMAIN.Text) > 0.00 && Convert.ToDouble(TXT_PAID.Text) > 0.00)
                    {
                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(
                                         PurchaseID
                                       , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                                       , Convert.ToDecimal(TXT_PAID.Text)
                                       , 1
                                       , 2
                                       , CLS.USER_CODE
                                       , 2
                                       , ref CLS.SUBMIT_FLAG);
                        CLS.SANAD_DISCRIPTION = "\\من ح/ " + supplier_namme + " الى ح/ " + "الصندوق";
                        var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                               , System.DateTime.Now
                                                               , 2
                                                               , 0
                                                               , ID_PERSON
                                                               , CLS.SANAD_DISCRIPTION
                                                               , 0
                                                               , 0
                                                               , Convert.ToDecimal(TXT_PAID.Text)
                                                               , 0
                                                               , supplier_namme + "-الصندوق"
                                                               , 1
                                                               , 1
                                                               , true
                                                               , CLS.USER_CODE
                                                               , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , 91
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , supplier_namme + "- الصندوق"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);

                        //////////////////////////////////////
                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(
                                        PurchaseID
                                      , Convert.ToInt32(cLIENT_NAME_ARComboBox.SelectedValue)
                                      , Convert.ToDecimal(TXT_REMAIN.Text)
                                      , 2
                                      , 2
                                      , CLS.USER_CODE
                                      , 2
                                      , ref CLS.SUBMIT_FLAG);
                        CLS.SANAD_DISCRIPTION = "\\من ح/ " + supplier_namme + " الى ح/ " + "المشتريات";
                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                           , System.DateTime.Now
                                                           , 2
                                                           , 0
                                                           , ID_PERSON
                                                           , CLS.SANAD_DISCRIPTION
                                                           , 0
                                                           , 0
                                                           , 0
                                                           , Convert.ToDecimal(TXT_REMAIN.Text)
                                                           , supplier_namme + "- مشتريات"
                                                           , 1
                                                           , 1
                                                           , true
                                                           , CLS.USER_CODE
                                                           , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(ID_ORDER
                                                                        , System.DateTime.Now
                                                                        , 2
                                                                        , 0
                                                                        , 5
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_REMAIN.Text)
                                                                        , 0
                                                                        , supplier_namme + "- مشتريات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref  CLS.SUBMIT_FLAG);


                    }




                }
                //////////////////////////////////////////////////

                if (CLS.SUBMIT_FLAG == 1)
                {
                    MSG.Msg.Alart(AlartType.Save);
                     

                }
                else
                {

                    MSG.Msg.Alart(AlartType.Error);


                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_PURCHERS_Shown(object sender, EventArgs e)
        {
            TXT_BARCODE.Focus();
        }

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}