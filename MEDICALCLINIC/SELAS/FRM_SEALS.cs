using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.SELAS
{
    public partial class FRM_SEALS : SETTING.baseclinicanddental
    {
        int ID_BOOK;
        int f_start = 0;
        DataTable DT = new DataTable();
        DataTable dt_come=new DataTable() ;
        public FRM_SEALS(DataTable dt,int f_ff_ff)
        {
            InitializeComponent();
            dt_come = dt;
            f_start = f_ff_ff;
            //this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            //this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.SelectedValue, typeof(int))))));
            //DataTable dt = new DataTable();
            //dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE;
            //AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    datasource.Add(dt.Rows[i][1].ToString ());
            //}
            //this.LBL_NAMEPERSON.AutoCompleteCustomSource = datasource;
            //this.LBL_NAMEPERSON.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //this.LBL_NAMEPERSON.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }
        public FRM_SEALS()
        {
            InitializeComponent();
          
        }
        int ORDERID;
        
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

       



       
 
     
        private void FRM_PURCHERS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
          
            try
            {
               
                    this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);

                    this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
                if (f_start == 9)
                {
                    TXT_ID_ORDER.Text = dt_come.Rows[0][5].ToString();
                    DATE_ORDER.Text = dt_come.Rows[0][7].ToString();
                    LBL_NAMEPERSON.SelectedValue = dt_come.Rows[0][8].ToString();
                    dOCTOR_NAMEComboBox.SelectedValue = dt_come.Rows[0][10].ToString();
                    TXT_ID_BOOKING.Text = dt_come.Rows[0][11].ToString();
                    TXT_TOTAL.Text = dt_come.Rows[0][12].ToString();
                    TXT_PAID.Text = dt_come.Rows[0][13].ToString();
                    TXT_REMAIN.Text = dt_come.Rows[0][14].ToString();
                    for (int i = 0; i < dt_come.Rows.Count; i++)
                    {
                        this.dgv_order.Rows.Add(dt_come.Rows[i][0].ToString(), dt_come.Rows[i][1].ToString(), dt_come.Rows[i][3].ToString(), dt_come.Rows[i][2].ToString(), dt_come.Rows[i][4].ToString());
                    }
                    BTN_SEARCH.Enabled = false;
                    BTN_SAVE.Enabled = false;
                }
                else
                    if (f_start == 10)
                    {
                        dOCTOR_NAMEComboBox.SelectedValue  =CLS .USER_CODE ;
                        LBL_NAMEPERSON.SelectedValue = CLS.CODE_PER_IMG;
                    }
                    else
                {
                   
                    //    this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1 .SelectedValue, typeof(int))))));
                    dgv_order.Columns[2].ReadOnly = true;
                    CLS.OEN_SALES = 1;
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
            }
                
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       
        private void TXT_PAY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TXT_REMAIN.Text = (Convert.ToDecimal(TXT_TOTAL.Text) - Convert.ToDecimal(TXT_PAID .Text)).ToString();
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
                TXT_REMAIN.Text = (Convert.ToDecimal(TXT_TOTAL.Text) - Convert.ToDecimal(TXT_PAID.Text)).ToString();
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

       

        

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBox1.SelectedValue, typeof(int))))));
        //        DataTable dt = new DataTable();
        //        dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE;
        //        AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            datasource.Add(dt.Rows[i][1].ToString());
        //        }
        //        this.LBL_NAMEPERSON.AutoCompleteCustomSource = datasource;
        //        this.LBL_NAMEPERSON.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        this.LBL_NAMEPERSON.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}

        private void TXT_BARCODE_KeyDown(object sender, KeyEventArgs e)
        { 
            try
            {

                if (e.KeyCode == Keys.Enter)
                {

                    string BARCODE =TXT_BARCODE.Text;
                    DataTable DT_ITEM = new MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_ITEM_TO_SALETableAdapter().GetData(BARCODE);
                    var Quantity = DT_ITEM.AsEnumerable().Sum(x => x.Field<Decimal>("QUANTITY"));
                    if (TXT_NUM.Text.ToDecimal() > Quantity)
                    {
                        MessageBox.Show("عفوا الكمية المطلوبة أكثر من الكمية في المخزن");
                        return;
                    }
                    

                    decimal NUMB_X = 1;

                    if (TXT_NUM.Text == string.Empty)
                    {
                        NUMB_X = 1;
                    }
                    else
                    {
                        NUMB_X = Convert.ToDecimal(TXT_NUM.Text);
                    }
                    this.p_GET_ITEM_TO_SALETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ITEM_TO_SALE, TXT_BARCODE.Text);
                    DataTable DT = new DataTable();
                    DT = this.mEDICAL_CLINIC_DBDataSet.P_GET_ITEM_TO_SALE;
                    int FoodIndex = -1;
                    if (DT.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgv_order.Rows.Count; i++)
                        {
                            if (DT.Rows[0][2].ToString().Equals(dgv_order.Rows[i].Cells[0].Value.ToString()))
                                FoodIndex = i;

                        }
                        if (FoodIndex == -1)
                        {
                            dgv_order.Rows.Add(DT.Rows[0][2].ToString(), DT.Rows[0][3].ToString(), DT.Rows[0][7].ToString(), NUMB_X.ToString(), (NUMB_X * Convert.ToDecimal(DT.Rows[0][7].ToString())).ToString(), "حذف", DT.Rows[0][0].ToString(), DT.Rows[0][9].ToString());

                        }
                        else
                        {
                            dgv_order.Rows[FoodIndex].Cells[3].Value = (Convert.ToInt32(dgv_order.Rows[FoodIndex].Cells[3].Value) + 1).ToString();
                            double num = Convert.ToDouble(dgv_order.Rows[FoodIndex].Cells[3].Value);

                            dgv_order.Rows[FoodIndex].Cells[4].Value = ((num) * Convert.ToDouble(dgv_order.Rows[FoodIndex].Cells[2].Value)).ToString();
                        }


                        //dgv_order.CurrentRow.Cells[4].Value = (Convert.ToDecimal(dgv_order.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dgv_order.CurrentRow.Cells[3].Value));




                        TXT_TOTAL.Text =
                        (from DataGridViewRow row in dgv_order.Rows
                         where row.Cells[4].FormattedValue.ToString() != string.Empty
                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                        TXT_BARCODE.Clear();
                        TXT_NUM.Clear();
                        TXT_BARCODE.Focus();
                    }
                }
                 
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        
        
        }
        private void dgv_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    dgv_order.Rows.RemoveAt(dgv_order.CurrentRow.Index);


                    TXT_TOTAL.Text =
                             (from DataGridViewRow row in dgv_order .Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void dgv_order_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_order.Rows.Count > 0)
                {

                    if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
                    {
                        dgv_order.CurrentRow.Cells[4].Value = (Convert.ToDecimal(dgv_order.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dgv_order.CurrentRow.Cells[3].Value)).ToString();
                        TXT_TOTAL.Text =
                        (from DataGridViewRow row in dgv_order.Rows
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

        
       

      

      
        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_PAID.Text == string.Empty)
                {
                    MessageBox.Show("رجاءا أدخل المبلغ المدفوع اولا ثم اعد المحاولة");
                    return;
                }
                this.p_BOOK_CODE_BY_PERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_BOOK_CODE_BY_PER, new System.Nullable<int>(((int)(System.Convert.ChangeType(LBL_NAMEPERSON.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_ORDER.Value, typeof(System.DateTime))))));
                DT = this.mEDICAL_CLINIC_DBDataSet.P_BOOK_CODE_BY_PER;

                if (dgv_order.RowCount > 0)
                {
                    if (DT.Rows.Count > 0)
                    {

                        ID_BOOK = Convert.ToInt32(DT.Rows[0][0]);
                    }
                    else
                    {
                        ID_BOOK = 0;
                        //MessageBox.Show("لا يوجد حجز لهذا الزبون");
                        //return;
                    }

                    var INSERTED_ORDER = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    ORDERID = int.Parse(INSERTED_ORDER.P_INSERT_T_ORDER(DATE_ORDER.Value
                        , Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
                        , dOCTOR_NAMEComboBox.SelectedValue.ToInt() //CLS.DOCTOR_CODE_GENE
                        , CLS.USER_CODE
                        , ID_BOOK
                        , Convert.ToDecimal(TXT_TOTAL.Text)
                        , Convert.ToDecimal(TXT_PAID.Text)
                        , Convert.ToDecimal(TXT_REMAIN.Text)
                        , ref  CLS.SUBMIT_FLAG).ToString());
                    int i;
                    var INSERTED_ORDER_DET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    for (i = 0; i < dgv_order.Rows.Count; i++)
                    {

                        string BARCODE = dgv_order.Rows[i].Cells["BARCODE"].Value.ToString();
                        DataTable DT_ITEM = new MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_ITEM_TO_SALETableAdapter().GetData(BARCODE);
                        var Quantity = DT_ITEM.AsEnumerable().Sum(x => x.Field<decimal>("QUANTITY"));
                        if (decimal.Parse(dgv_order.Rows[i].Cells["dgvcQuantity"].Value.ToString()) > Quantity) { }
                        // MessageBox.Show("عفوا الكمية المطلوبة أكثر من الكمية في المخزن");
                        else
                        {
                            decimal OrderedQuantity = decimal.Parse(dgv_order.Rows[i].Cells["dgvcQuantity"].Value.ToString());
                            //if (decimal.Parse(dgv_order.Rows[i].Cells["dgvcQuantity"].Value.ToString())
                            //    < Quantity)
                            //    {
                            //        var EDIT_QTY = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                            //        EDIT_QTY.P_EDIT_QTY_IN_STOCK(dgv_order.Rows[i].Cells[0].Value.ToString(), int.Parse(DT_ITEM.Rows[0]["PURCHES_DETAILSID"].ToString()),
                            //            Convert.ToDecimal(decimal.Parse(dgv_order.Rows[i].Cells["dgvcQuantity"].Value.ToString())));
                            //    }
                            //else
                            //{
                            for (int j = 0; j < DT_ITEM.Rows.Count; j++)
                            {
                                if (OrderedQuantity > decimal.Parse(DT_ITEM.Rows[j]["QUANTITY"].ToString()))
                                {

                                    var EDIT_QTY = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                                    EDIT_QTY.P_EDIT_QTY_IN_STOCK(dgv_order.Rows[i].Cells[0].Value.ToString(), int.Parse(DT_ITEM.Rows[j]["PURCHES_DETAILSID"].ToString()),
                                        decimal.Parse(DT_ITEM.Rows[j]["QUANTITY"].ToString()));
                                    OrderedQuantity -= decimal.Parse(DT_ITEM.Rows[j]["QUANTITY"].ToString());
                                }
                                else if (OrderedQuantity <= decimal.Parse(DT_ITEM.Rows[j]["QUANTITY"].ToString()) && OrderedQuantity > 0)
                                {
                                    var EDIT_QTY = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                                    EDIT_QTY.P_EDIT_QTY_IN_STOCK(dgv_order.Rows[i].Cells[0].Value.ToString(), int.Parse(DT_ITEM.Rows[j]["PURCHES_DETAILSID"].ToString()),
                                       OrderedQuantity);

                                    OrderedQuantity = 0;
                                }

                            }
                        }
                        INSERTED_ORDER_DET.P_INSERT_T_ORDER_DETAILS(
                  Convert.ToInt32(ORDERID)
                , dgv_order.Rows[i].Cells[0].Value.ToString()
                , dgv_order.Rows[i].Cells[1].Value.ToString()
                , Convert.ToDecimal(dgv_order.Rows[i].Cells[3].Value)
                , Convert.ToDecimal(dgv_order.Rows[i].Cells[2].Value)
                , Convert.ToDecimal(dgv_order.Rows[i].Cells[4].Value)
                 , Convert.ToInt32(dgv_order.Rows[i].Cells[7].Value)
                , ref  CLS.SUBMIT_FLAG);
                    }


                    var DEBI_CASH = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    //     INSERTED_ORDER.P_GET_BILL_NUMBER( 4, ref  ID_ORDER);
                    //    TXT_ORDER.Text = ID_ORDER.ToString();


                    CLS.SANAD_DISCRIPTION = "\\من ح/ " + LBL_NAMEPERSON.Text + " الى ح/ " + "المبيعات";

                    ///////////////أجـــــــــــــــــل
                    if (Convert.ToDouble(TXT_PAID.Text) == 0.00)
                    {

                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(
                              ORDERID
                            , Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
                            , Convert.ToDecimal(TXT_TOTAL.Text)
                            , 2
                            , 1
                            , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                            , 1
                            , ref CLS.SUBMIT_FLAG);


                        //////---------------
                        INSERT_SALES.P_INSERT_T_BOX(Convert.ToInt32(ORDERID)
                                                                        , System.DateTime.Now
                                                                        , 1
                                                                        , 0
                                                                        , Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_TOTAL.Text)
                                                                        , 0
                                                                        , LBL_NAMEPERSON.Text + "- مبيعات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                                                        , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(Convert.ToInt32(ORDERID)
                                                                        , System.DateTime.Now
                                                                        , 1
                                                                        , 0
                                                                        , 4
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_TOTAL.Text)
                                                                        , LBL_NAMEPERSON.Text + "- مبيعات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                                                        , ref  CLS.SUBMIT_FLAG);
                    }
                    //////////////////////نهاية الاجل

                    ////////نقداُ
                    if (Convert.ToDouble(TXT_REMAIN.Text) == 0.00 && Convert.ToDouble(TXT_PAID.Text) > 0.00)
                    {
                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(ORDERID, Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToDecimal(TXT_PAID.Text), 1, 1, CLS.USER_CODE, 1, ref CLS.SUBMIT_FLAG);
                        
                        //FROM 
                        INSERT_SALES.P_INSERT_T_BOX(Convert.ToInt32(ORDERID)
                                                                        , System.DateTime.Now
                                                                        , 1
                                                                        , 0
                                                                        , 4
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , LBL_NAMEPERSON.Text + "- مبيعات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                                                        , ref  CLS.SUBMIT_FLAG);


                        // ' ===================== TO



                        INSERT_SALES.P_INSERT_T_BOX(Convert.ToInt32(ORDERID)
                                                                        , System.DateTime.Now
                                                                        , 1
                                                                        , 0
                                                                        , 91
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , 0
                                                                        , LBL_NAMEPERSON.Text + "- مبيعات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                                                        , ref  CLS.SUBMIT_FLAG);
                    }
                    ///////////////نهاية النقد

                    ///////////////////////////////////////////////////////////////////////////////////////////////  
                    ///////// دفع جزئي
                    if (Convert.ToDouble(TXT_REMAIN.Text) > 0.00 && Convert.ToDouble(TXT_PAID.Text) > 0.00)
                    {

                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(ORDERID, Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToDecimal(TXT_PAID.Text), 1, 1, CLS.USER_CODE, 1, ref CLS.SUBMIT_FLAG);
                        //من زبون للمبيعات نقدي
                        INSERT_SALES.P_INSERT_T_BOX(Convert.ToInt32(ORDERID)
                                                               , System.DateTime.Now
                                                               , 1
                                                               , 4
                                                               , Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
                                                               , CLS.SANAD_DISCRIPTION
                                                               , 0
                                                               , 0
                                                               , 0
                                                               , Convert.ToDecimal(TXT_PAID.Text)
                                                               , LBL_NAMEPERSON.Text + "- مبيعات"
                                                               , 1
                                                               , 1
                                                               , true
                                                               , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                                               , ref  CLS.SUBMIT_FLAG);
                        // ' ===================== TO
                        INSERT_SALES.P_INSERT_T_BOX(Convert.ToInt32(ORDERID)
                                                                        , System.DateTime.Now
                                                                        , 1
                                                                        , 0
                                                                        , 91
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_PAID.Text)
                                                                        , 0
                                                                        , LBL_NAMEPERSON.Text + "- مبيعات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                                                        , ref  CLS.SUBMIT_FLAG);

                        //////////////
                        DEBI_CASH.P_INSERT_T_CASH_DEBIT(ORDERID, Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToDecimal(TXT_REMAIN.Text), 2, 1, CLS.USER_CODE, 1, ref CLS.SUBMIT_FLAG);
                        ///// من زبون للمبيعات الاجل
                        INSERT_SALES.P_INSERT_T_BOX(Convert.ToInt32(ORDERID)
                                                           , System.DateTime.Now
                                                           , 1
                                                           , 0
                                                           , Convert.ToInt32(LBL_NAMEPERSON.SelectedValue)
                                                           , CLS.SANAD_DISCRIPTION
                                                           , 0
                                                           , 0
                                                           , Convert.ToDecimal(TXT_REMAIN.Text)
                                                           , 0
                                                           , LBL_NAMEPERSON.Text + "- مبيعات"
                                                           , 1
                                                           , 1
                                                           , true
                                                           , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                                           , ref  CLS.SUBMIT_FLAG);
                        // ' ===================== TO
                        INSERT_SALES.P_INSERT_T_BOX(Convert.ToInt32(ORDERID)
                                                                        , System.DateTime.Now
                                                                        , 1
                                                                        , 0
                                                                        , 4
                                                                        , CLS.SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(TXT_REMAIN.Text)
                                                                        , LBL_NAMEPERSON.Text + "- مبيعات"
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                                                                        , ref  CLS.SUBMIT_FLAG);


                    }
                    //////////////////////نهاية الدفع الجزئي



                }


                if (CLS.SUBMIT_FLAG == 1)
                {
                    MessageBox.Show("تم الحفظ بنجاح");
                    //var UPD = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    //  UPD.P_UDATE_T_BOOKING_T_PERSON(Convert.ToInt32(ID_BOOK ), CLS.USER_CODE , true, true);
                    BTN_NEW_Click(null, null);
                }
                else
                {

                    MSG.Msg.Alart(AlartType.Error);

                }
                //}
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {

            ///   dataGridView1.Rows.Clear();
            TXT_BARCODE.Clear();
            TXT_ID_ORDER.Clear();
            TXT_ID_BOOKING .Clear ();
            TXT_PAID.Clear();
            TXT_PAID.Clear ();
            TXT_REMAIN.Clear();
            TXT_REMAIN.Text = "0.00";
            TXT_TOTAL.Clear();
            TXT_NUM.Clear();
            dOCTOR_NAMEComboBox.SelectedIndex = -1;
            LBL_NAMEPERSON.SelectedIndex = -1;
            dgv_order.Rows.Clear();
            
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {

                if (TXT_ID_ORDER.Text != string.Empty || dgv_order.Rows.Count <= 0)
                {
                    var DELETE_BOX = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var DELETE_ORDER = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    DELETE_BOX.P_DELETE_T_BOX(Convert.ToInt32(TXT_ID_ORDER.Text), 1, "", ref  CLS.SUBMIT_FLAG);
                    DELETE_ORDER.P_DELETE_T_ORDER_DETAILS(Convert.ToInt32(TXT_ID_ORDER.Text), ref  CLS.SUBMIT_FLAG);
                    BTN_SAVE_Click(null ,null );
                }
                else
                {
                    MessageBox.Show("يرجى تحديد فانورة اولا ");
                    return;
                }
                if (CLS.SUBMIT_FLAG == 1)
                {
                  // MessageBox.Show("تم االتعديل بنجاح");

                    BTN_NEW_Click(null, null);
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

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try 
            {

            if (TXT_ID_ORDER.Text != string.Empty||dgv_order .Rows .Count <=0)
            {
                var DELETE_BOX = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var DELETE_ORDER = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                DELETE_BOX.P_DELETE_T_BOX(Convert.ToInt32(TXT_ID_ORDER.Text), 1, "", ref  CLS.SUBMIT_FLAG);
                DELETE_ORDER.P_DELETE_T_ORDER_DETAILS(Convert.ToInt32(TXT_ID_ORDER.Text), ref  CLS.SUBMIT_FLAG);

            }
            else
            {
                MessageBox.Show("يرجى تحديد فانورة اولا ");
                return;
            }
            if (CLS.SUBMIT_FLAG == 1)
            {
                MessageBox.Show("تم الحذف بنجاح");
              
              
                BTN_NEW_Click(null, null);
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

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            FRM_SEARCH_ORDER FRM = new FRM_SEARCH_ORDER();
            FRM.ShowDialog();
        }
      
    }
}