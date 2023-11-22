using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.OPERA
{
    public partial class FRM_OUT_PERSON :MEDICALCLINIC.HOSPITAL. BaseHospital
    {
        int BOOK_ID,CODE_OP;

        public FRM_OUT_PERSON(string BOOK_DES,int ID_OP, string NAME)
        {
            InitializeComponent();
            BOOK_ID = Convert.ToInt32(BOOK_DES);
            label1.Text = NAME;
            CODE_OP = ID_OP;
        }
        public FRM_OUT_PERSON( )
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

        decimal LBL_OP_B_REMAIN, LBL_M_B_REMAIN, LBL_S_B_REMAIN;

         

        int PERSON_CODE, BOOK_CODE;
        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {


                if (MSG.Msg.MsgBoxResult("هل انت متأكد من اخراج المريض؟"))
                 {





                    LBL_OP_B_REMAIN = 0;
                    LBL_M_B_REMAIN = 0;
                    LBL_S_B_REMAIN = 0;

                    this.gET_H_PERSON_COD_BOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK, new System.Nullable<int>(((int)(System.Convert.ChangeType(CODE_OP, typeof(int))))),1);

                    if (this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK.Rows.Count > 0)
                    {

                        BOOK_CODE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK.Rows[0][1].ToString());
                        PERSON_CODE = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK.Rows[0][0].ToString());

                        this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(13, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                        if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                        {

                            //  LBL_OP_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                            // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                            // LBL_OP_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                            LBL_OP_B_REMAIN = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString());
                        }
                        this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(18, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                        if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                        {
                            //  LBL_M_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                            // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                            //  LBL_M_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                            LBL_M_B_REMAIN = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString());


                        }
                        this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(17, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                        if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                        {
                            //   LBL_S_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                            // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                            //   LBL_S_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                            LBL_S_B_REMAIN = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString());
                        }
                        if (LBL_OP_B_REMAIN>0|| LBL_M_B_REMAIN>0|| LBL_S_B_REMAIN>0)
                            {
                                MessageBox.Show("لايمكن أخراج المريض يرجى مراجعة قسم الحسابات");
                            return;
                            }
                           


                            var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                            INSERTED.P_H_OUT_PERSON_CMPLT(

                                    BOOK_ID
                                   , 1
                                   , ref CLS.SUBMIT_FLAG

                                  );


                            var EDITINVOIC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                            EDITINVOIC.P_UPDATE_T_INVOICES_PRICE_(
                                    BOOK_ID, 0, 0, 3, ref CLS.SUBMIT_FLAG
                                    );

                            if (CLS.SUBMIT_FLAG == 1)
                            {

                            MSG.Msg.Alart(AlartType.Save,"تم خروخ المريض بنجاح");

                        }
                            //else
                            //{

                            //    MSG.Msg.Alart(AlartType.Error);

                            //}
                       
                    }
                }
                }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }


    }  
}
