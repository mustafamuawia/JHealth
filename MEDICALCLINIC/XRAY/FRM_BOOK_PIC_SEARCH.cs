using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.XRAY
{
    public partial class FRM_BOOK_PIC_SEARCH : Form
    {
        int? PER_PAYID = 0;
        int? PER_NO_PAID = 0;
        DataTable GGG = new DataTable();
        public FRM_BOOK_PIC_SEARCH()
        {

            InitializeComponent();
        }

       

        private void FRM_SHOW_ALL_BOOKING_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);

            dOCTOR_NAMEComboBox.SelectedIndex =- 1;
            try
            {

                DATE_BOOKING.Value = System.DateTime.Now;
                timer1.Interval = 1200000;
                timer1.Enabled = true;
               /////// this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, Convert.ToDateTime(DATE_BOOKING.Value),Convert.ToInt32( dOCTOR_NAMEComboBox.SelectedValue));

                // this.v_PER_PAID_TO_BOXTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_PER_PAID_TO_BOX);
                //this.v_PERS_DEBIT_ALL_USERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_PERS_DEBIT_ALL_USER);
               // LBL_DOC_NAME.Text = CLS.USER_NAME;

                if (dataGridView2.Rows.Count > 0)
                {
                    this.gET_COUNT_TEST_UNTESTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COUNT_TEST_UNTEST, DATE_BOOKING.Value, CLS.USER_CODE, true);
                    LBL_TESTED.Text = this.mEDICAL_CLINIC_DBDataSet.GET_COUNT_TEST_UNTEST.Rows[0][0].ToString();

                    this.gET_COUNT_TEST_UNTESTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COUNT_TEST_UNTEST, DATE_BOOKING.Value, CLS.USER_CODE, false);
                    LBL_UNTEST.Text = this.mEDICAL_CLINIC_DBDataSet.GET_COUNT_TEST_UNTEST.Rows[0][0].ToString();

                    this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, CLS.USER_CODE, DATE_BOOKING.Value);
                    GGG = this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED;
                    LBL_TOTAT_PAY_FOR.Text = GGG.Rows[0][0].ToString();

                    var GET_NUM_AC_INC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    GET_NUM_AC_INC.GET_NUM_PERSON_PAY_NOPAY(CLS.USER_CODE, DATE_BOOKING.Value, ref PER_PAYID, 1);
                    LBL_NUM_PAID.Text = PER_PAYID.ToString();

                    var GET_NUM_AC_INC1 = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    GET_NUM_AC_INC1.GET_NUM_PERSON_PAY_NOPAY(CLS.USER_CODE, DATE_BOOKING.Value, ref PER_NO_PAID, 0);
                    LBL_NUM_NO_PAID.Text = PER_NO_PAID.ToString();
                    LBL_NUM_PER.Text = dataGridView2.Rows.Count.ToString();

                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        bool IS_CHEK = Convert.ToBoolean(this.dataGridView2.Rows[i].Cells[10].Value);
                        if (IS_CHEK == true)
                        {
                            this.dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Teal;
                        }
                    }

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "لا يوجد حجوزات مفعلة");
            }

        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 21)
                {
                    ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).LBL_PER_CODE.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).LBL_PERSON_NAME.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    ((FRM_IMGE_PRSN)Application.OpenForms["FRM_IMGE_PRSN"]).LBL_BOOK_CODE.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();


                    this.Close();
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), CLS.USER_CODE);

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    bool IS_CHEK = Convert.ToBoolean(this.dataGridView2.Rows[i].Cells[10].Value);
                    if (IS_CHEK == true)
                    {
                        this.dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Teal;
                    }
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Boolean C;
                if (e.ColumnIndex == 11)
                {
                    C = Convert.ToBoolean(dataGridView2.CurrentRow.Cells[11].Value);

                    var CNGE_STATE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var DELL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    int ID_BOOKED = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                    if (C == true)
                    {
                        CNGE_STATE.P_CHANGE_KSHFIA_STATE(Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value), false, "غير مدفوع", ref CLS.SUBMIT_FLAG);
                        DELL.P_DELETE_T_BOX(ID_BOOKED, 12, "", ref CLS.SUBMIT_FLAG);

                    }
                    else
                    {
                        decimal PRIC_PAY = Convert.ToDecimal(Properties.Settings.Default.SET_PRICE_DOCTOR);
                        string TXT_KSHFIA = Properties.Settings.Default.SET_PRICE_DOCTOR;
                        CNGE_STATE.P_CHANGE_KSHFIA_STATE(Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value), true, TXT_KSHFIA, ref CLS.SUBMIT_FLAG);

                        string SANAD_DISCRIPTION = "\\من ح/ " + Convert.ToString(dataGridView2.CurrentRow.Cells[4].Value) + " الى ح/ " + "الصندوق";
                        int ACCOUNT_FROM_CODE = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);


                        var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERT_SALES.P_INSERT_T_BOX(ID_BOOKED
                                                                        , System.DateTime.Now
                                                                        , 12
                                                                        , 0
                                                                        , ACCOUNT_FROM_CODE
                                                                        , SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(PRIC_PAY)
                                                                        , ""
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.Text);

                        INSERT_SALES.P_INSERT_T_BOX(ID_BOOKED
                                                                        , System.DateTime.Now
                                                                        , 12
                                                                        , 0
                                                                        , 10
                                                                        , SANAD_DISCRIPTION
                                                                        , 0
                                                                        , 0
                                                                        , Convert.ToDecimal(PRIC_PAY)
                                                                        , 0
                                                                        , ""
                                                                        , 1
                                                                        , 1
                                                                        , true
                                                                        , CLS.USER_CODE
                                                                        , ref CLS.SUBMIT_FLAG);
                    }
                    bool PY_STATE = Convert.ToBoolean(this.dataGridView2.CurrentRow.Cells[11].Value);
                    if (PY_STATE == true)
                    {
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_KSH_TYP.Text = "غير مدفوع";
                    }
                    else
                    {
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_KSH_TYP.Text = "  مدفوع";
                    }

                    FRM_SHOW_ALL_BOOKING_Load(null, null);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {


                this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));

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

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, Convert.ToDateTime(DATE_BOOKING.Value), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue));

        }

        private void PIC_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
