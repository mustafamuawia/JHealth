using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.OPERA
{
    public partial class FRM_OPE_SERVICE :MEDICALCLINIC.HOSPITAL. BaseHospital
    { 
         DataTable fd = new DataTable();
            decimal total_t = 0, f_total;
        int BOOK_CODE, PERSON_CODE;
        public FRM_OPE_SERVICE(int BOOK_ID,int ID_PERSON)
        {
            InitializeComponent();
            BOOK_CODE = BOOK_ID;
            PERSON_CODE = ID_PERSON;
        }
        public FRM_OPE_SERVICE( )
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

        private void FRM_ADD_OPERATN_INFO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_ITEM' table. You can move, or remove it, as needed.
            this.v_GET_H_ITEMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_ITEM);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_H_SERVCE_TYPE' table. You can move, or remove it, as needed.
            this.v_A_H_SERVCE_TYPETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_SERVCE_TYPE);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_H_OPERATION' table. You can move, or remove it, as needed.
            this.v_A_H_OPERATIONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_OPERATION);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR_2' table. You can move, or remove it, as needed.
            this.v_A_DOCTOR_2TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR_2);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR_1' table. You can move, or remove it, as needed.
            this.v_A_DOCTOR_1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR_1);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_TAKDEER1' table. You can move, or remove it, as needed.
            this.v_GET_TAKDEER1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_TAKDEER1);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_TAKDEER_DOCT' table. You can move, or remove it, as needed.
            this.v_GET_TAKDEER_DOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_TAKDEER_DOCT);

        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMB_SERVICE.SelectedIndex == -1   )
                {

                    errorProvider1.SetError(COMB_SERVICE, CLS.TXT_NULL);
                }
               
                if ( TXT_PRICESRVE.Text == "" || TXT_PRICESRVE.Text ==String.Empty)
                {

                    errorProvider1.SetError(TXT_PRICESRVE, CLS.TXT_NULL);
                }

 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    
                    
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_H_SERVICES(

                    

                             Convert.ToInt32(COMB_SERVICE.SelectedValue)
                             ,BOOK_CODE
                             ,1
                             ,CLS.USER_CODE
                             ,DATE_DAY_S.Value
                             ,true
                             ,ref CLS.SUBMIT_FLAG

                             );

                    this.gET_INVOICE_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_INVOICE_BOOKING, BOOK_CODE.ToString(),1);
                   
                  
                    fd = this.mEDICAL_CLINIC_DBDataSet.GET_INVOICE_BOOKING;
                    int id_invo =Convert.ToInt32( fd.Rows[0][0]);
                    for (int i = 0; i < fd.Rows.Count; i++)
                    {
                        total_t = total_t + Convert.ToDecimal(fd.Rows[i][14]);
                    }


                    f_total = total_t + Convert.ToDecimal(TXT_TOTAL.Text);
                    var EDITINVOIC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    EDITINVOIC.P_UPDATE_T_INVOICES_PRICE_(
                            id_invo,f_total,0,2,ref CLS.SUBMIT_FLAG
                            );



                    // int ID_INVC;
                    // var INSERTINVC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    // ID_INVC = int.Parse(INSERTINVC.P_INSERT_T_INVOICES(
                    //System.DateTime.Now
                    // , Convert.ToDecimal(TXT_TOTAL.Text)
                    // , 0
                    // , BOOK_CODE
                    // , false
                    // , 0
                    // , CLS.USER_CODE
                    // , ref CLS.SUBMIT_FLAG).ToString());
                    var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTINVDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                  
                   int BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                          BOOK_CODE
                        , dateTimePicker1.Value
                         , "عن اجور خدمات "
                        , 17
                        , 0
                        , true
                        , CLS.USER_CODE
                        , ref CLS.SUBMIT_FLAG, CLS.BRANCH_ID,0
                        ).ToString());


                    for (int i = 0; i < DVGITEMS.Rows.Count; i++)
                    {
                        INSERTINVDET.P_INSERT_T_INVOICE_DETAILS(
                          id_invo
                        , Convert.ToInt32( DVGITEMS.Rows[i].Cells[0].Value)
                        , DVGITEMS.Rows[i].Cells[1].Value.ToString()
                        , Convert.ToDecimal( DVGITEMS.Rows[i].Cells[2].Value)
                        , Convert.ToDecimal(DVGITEMS.Rows[i].Cells[3].Value)
                        , Convert.ToDecimal(DVGITEMS.Rows[i].Cells[4].Value)
                        , Convert.ToInt32(DVGITEMS.Rows[i].Cells[5].Value)
                        , ref CLS.SUBMIT_FLAG);



                        //من المريض الى الخدمات
                        //FROM
                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                       (
                         BookId
                       , PERSON_CODE
                       , "المريض"
                       , 0
                       , 0
                       , Convert.ToDecimal(DVGITEMS.Rows[i].Cells[4].Value)
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
                       , 4001
                       , "الخدمات"
                       , 0
                       , 0
                       , 0
                       , Convert.ToDecimal(DVGITEMS.Rows[i].Cells[4].Value)
                       , "من حساب الزبون الى حساب الخدمات"
                       , 1
                       , 1
                       , ref CLS.SUBMIT_FLAG
                        );
                        ////END
                        ////نهاية الخدمات#



                    }





                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        COMB_SERVICE.SelectedIndex = -1;
                        TXT_PRICESRVE.Text = "";
                        DATE_DAY_S.Value = System.DateTime.Now;
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

        private void BTN_A_SERVICE_Click(object sender, EventArgs e)
        {

            try
            {

                int FoodIndex = -1;
                decimal NUMB_X = 1;

                if (TXT_QTY_S.Text == string.Empty)
                {
                    NUMB_X = 1;
                }
                else
                {
                    NUMB_X = Convert.ToDecimal(TXT_QTY_S.Text);
                }
                // this.p_GET_ITEM_TO_SALETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ITEM_TO_SALE, TXT_BARCODE.Text);
                //   DataTable DT = new DataTable();
                //  DT = this.mEDICAL_CLINIC_DBDataSet.P_GET_ITEM_TO_SALE;

                //if (DT.Rows.Count > 0)
                //{
                for (int i = 0; i < DVGITEMS.Rows.Count; i++)
                {
                    if (COMB_SERVICE.SelectedValue.ToString().Equals(DVGITEMS.Rows[i].Cells[0].Value.ToString()))
                        FoodIndex = i;

                }
                if (FoodIndex == -1)
                {
                    DVGITEMS.Rows.Add(COMB_SERVICE.SelectedValue, COMB_SERVICE.Text, NUMB_X, TXT_PRICESRVE.Text, (Convert.ToDecimal(TXT_PRICESRVE.Text) * Convert.ToDecimal(NUMB_X)).ToString(),1);
                     


                    TXT_TOTAL.Text =
                             (from DataGridViewRow row in DVGITEMS.Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                }
                else
                {
                    DVGITEMS.Rows[FoodIndex].Cells[2].Value = (Convert.ToInt32(DVGITEMS.Rows[FoodIndex].Cells[2].Value) + NUMB_X).ToString();
                    double num = Convert.ToDouble(DVGITEMS.Rows[FoodIndex].Cells[2].Value);

                    DVGITEMS.Rows[FoodIndex].Cells[4].Value = ((num) * Convert.ToDouble(DVGITEMS.Rows[FoodIndex].Cells[3].Value)).ToString();

                  


                    TXT_TOTAL.Text =
                             (from DataGridViewRow row in DVGITEMS.Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                }


                //dgv_order.CurrentRow.Cells[4].Value = (Convert.ToDecimal(dgv_order.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dgv_order.CurrentRow.Cells[3].Value));




                //TXT_TOTAL.Text =
                //(from DataGridViewRow row in dgv_order.Rows
                // where row.Cells[4].FormattedValue.ToString() != string.Empty
                // select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                //TXT_BARCODE.Clear();
                //  }


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {

        }

        private void pRICETextBoxITM_TextChanged(object sender, EventArgs e)
        {
            try
            {

                this.pRICETextBoxITM.Text = Convert.ToDecimal(this.pRICETextBoxITM.Text).ToString("N0", new System.Globalization.CultureInfo("en-US"));
                this.pRICETextBoxITM.SelectionStart = pRICETextBoxITM.TextLength;

            }
            catch
            {
                return;
            }
        }

        private void TXT_PRICESRVE_TextChanged(object sender, EventArgs e)
        {
            try
            {

                this.TXT_PRICESRVE.Text = Convert.ToDecimal(this.TXT_PRICESRVE.Text).ToString("N0", new System.Globalization.CultureInfo("en-US"));
                this.TXT_PRICESRVE.SelectionStart = TXT_PRICESRVE.TextLength;

            }
            catch
            {
                return;
            }
        }

        private void BTN_A_ITEMS_Click(object sender, EventArgs e)
        {
            try
            {

                int FoodIndex = -1;
                decimal NUMB_X = 1;

                if (TXT_QTY_I.Text == string.Empty)
                {
                    NUMB_X = 1;
                }
                else
                {
                    NUMB_X = Convert.ToDecimal(TXT_QTY_I.Text);
                }
                // this.p_GET_ITEM_TO_SALETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ITEM_TO_SALE, TXT_BARCODE.Text);
                //   DataTable DT = new DataTable();
                //  DT = this.mEDICAL_CLINIC_DBDataSet.P_GET_ITEM_TO_SALE;
               
                //if (DT.Rows.Count > 0)
                //{
                for (int i = 0; i < DVGITEMS.Rows.Count; i++)
                {
                    if (iTEM_MAMEComboBox.SelectedValue.ToString().Equals(DVGITEMS.Rows[i].Cells[0].Value.ToString()))
                        FoodIndex = i;

                }
                if (FoodIndex == -1)
                {
                    DVGITEMS.Rows.Add(iTEM_MAMEComboBox.SelectedValue, iTEM_MAMEComboBox.Text, NUMB_X, pRICETextBoxITM.Text, (Convert.ToDecimal(pRICETextBoxITM.Text) * Convert.ToDecimal(NUMB_X)).ToString(),1);
                   


                    TXT_TOTAL.Text =
                             (from DataGridViewRow row in DVGITEMS.Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                }
                else
                {
                    DVGITEMS.Rows[FoodIndex].Cells[2].Value = (Convert.ToInt32(DVGITEMS.Rows[FoodIndex].Cells[2].Value) + NUMB_X).ToString();
                    double num = Convert.ToDouble(DVGITEMS.Rows[FoodIndex].Cells[2].Value);

                    DVGITEMS.Rows[FoodIndex].Cells[4].Value = ((num) * Convert.ToDouble(DVGITEMS.Rows[FoodIndex].Cells[3].Value)).ToString();

                  


                    TXT_TOTAL.Text =
                             (from DataGridViewRow row in DVGITEMS.Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                }


                //dgv_order.CurrentRow.Cells[4].Value = (Convert.ToDecimal(dgv_order.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dgv_order.CurrentRow.Cells[3].Value));




                //TXT_TOTAL.Text =
                //(from DataGridViewRow row in dgv_order.Rows
                // where row.Cells[4].FormattedValue.ToString() != string.Empty
                // select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                //TXT_BARCODE.Clear();
                //  }


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       

        private void DVGITEMS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    DVGITEMS.Rows.RemoveAt(DVGITEMS.CurrentRow.Index);


                    TXT_TOTAL.Text =
                             (from DataGridViewRow row in DVGITEMS.Rows
                              where row.Cells[4].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                }
            }
            catch
            {
                return;
            }
        }

       

       

       
    }
}
