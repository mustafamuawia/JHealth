using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.OPERATION_PP
{
    public partial class FRM_BOOK_TOOTH : Form
    {
        int? PER_PAYID = 0;
        int? PER_NO_PAID = 0;
        DataTable GGG = new DataTable();
        public FRM_BOOK_TOOTH()
        {

            InitializeComponent();
        }

      

        private void FRM_SHOW_ALL_BOOKING_Load(object sender, EventArgs e)
        {


            try
            {
                var workingArea = Screen.FromHandle(Handle).WorkingArea;
                MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
                WindowState = FormWindowState.Maximized;
                 DATE_BOOKING.Value = System.DateTime.Now;
                //timer1.Interval = 1200000;
                //timer1.Enabled = true;
                this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, Convert.ToDateTime(DATE_BOOKING.Value), CLS.USER_CODE);
                this.p_GET_T_BOOKING_T_PERSON_BACKTODOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_BACKTODOCT, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));

                // this.v_PER_PAID_TO_BOXTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_PER_PAID_TO_BOX);
                //this.v_PERS_DEBIT_ALL_USERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_PERS_DEBIT_ALL_USER);
                //LBL_DOC_NAME.Text = CLS.USER_NAME;

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
                if (e.ColumnIndex == 12)
                {
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).lblpersoncode.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).LBL_NAMEPERSON.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).lblbookcode.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).aGELabel2.Text = dataGridView2.CurrentRow.Cells[11].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).sEX_NAMELabel2.Text = dataGridView2.CurrentRow.Cells[14].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).lbl_l_paitent_name.Text   = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]). LBL_RAY_NAME_PERSON.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).lbl_paitent_name_med.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                  //  ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).bOOKING_CODELabel1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                    this.gET_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(this.dataGridView2.CurrentRow.Cells[2].Value.ToString(), typeof(int))))),CLS.Cost_Center_WARD_DR,DateTime.Now,DateTime.Now, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                    // string debit_p =( this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][2]).ToString();

                    //if (!debit_p.Equals(string.Empty))
                    //{
                    //debit_p= Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][2]).ToString("#,##0.00");
                        ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).LBL_PAST_DEBIT.Text =( Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][2]).ToString("#,##0.00")).ToString();


                    //}

                    if (dataGridView2.CurrentRow.Cells[21].Value.ToString() !=string.Empty)
                    {
                    byte[] imge1 = (byte[])dataGridView2.CurrentRow.Cells[21].Value;
                    MemoryStream ms1 = new MemoryStream(imge1);

                        ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).pICTURE_PERSONPictureBox1.Image = Image.FromStream(ms1);

                    }

                    var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    UPDT.P_UPDATE_T_BOOKING_ENTER_DOCT(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[1].Value), ref CLS.SUBMIT_FLAG);


                    this.Close();
                }

            }
            catch (System.Exception ex)
            {
              //  System.Windows.Forms.MessageBox.Show(ex.Message);
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
                                                                        , ref  CLS.SUBMIT_FLAG);


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
                                                                        , ref  CLS.SUBMIT_FLAG);
                    }
                    //bool PY_STATE = Convert.ToBoolean(this.dataGridView2.CurrentRow.Cells[11].Value);
                    //if (PY_STATE == true)
                    //{
                    //    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_CLINIC"]).LBL_KSH_TYP.Text = "غير مدفوع";
                    //}
                    //else
                    //{
                    //    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_CLINIC"]).LBL_KSH_TYP.Text = "  مدفوع";
                    //}

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

       

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.p_GET_T_BOOKING_T_PERSON_BACKTODOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_BACKTODOCT, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType( CLS.USER_CODE, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 12)
                {



                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).lblpersoncode.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    //((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_CLINIC"]).TXT_ID_DOCTOR.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).lblbookcode.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                   // ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).bOOKING_CODELabel1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).LBL_NAMEPERSON.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                     //((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_CLINIC"]).TXT_DISEASE.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).lbl_l_paitent_name.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).LBL_RAY_NAME_PERSON.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).lbl_paitent_name_med.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                    this.gET_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(this.dataGridView1.CurrentRow.Cells[2].Value.ToString(), typeof(int))))),CLS.Cost_Center_WARD_DR,DateTime.Now,DateTime.Now, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).LBL_PAST_DEBIT.Text = this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();


                    //bool PY_STATE = Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells[11].Value);
                    //if (PY_STATE == true)
                    //{
                    //    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_CLINIC"]).LBL_KSH_TYP.Text = "مدفوع";
                    //}
                    //else
                    //{
                    //    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_CLINIC"]).LBL_KSH_TYP.Text = "غير مدفوع";
                    //}
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).aGELabel2.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).sEX_NAMELabel2.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    //((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_CLINIC"]).TXT_DESC.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
                    //((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_CLINIC"]).TXT_STATE.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
                    //((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_CLINIC"]).TXT_DRAGE.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();

                    gET_ORDER_BY_BOOKING_NUMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ORDER_BY_BOOKING_NUM, Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[1].Value), CLS.USER_CODE);

                    gET_BOOKING_BY_ID_PER_DOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT, CLS.USER_CODE, Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value), DATE_BOOKING.Value);
                   // ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT;
                    if (this.dataGridView1.CurrentRow.Cells[21].Value.ToString() != string.Empty)
                    {
                        ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).pICTURE_PERSONPictureBox1.Image = null;
                        byte[] imge2 = (byte[])this.dataGridView1.CurrentRow.Cells[21].Value;
                        MemoryStream ms2 = new MemoryStream(imge2);
                        ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).pICTURE_PERSONPictureBox1.Image = Image.FromStream(ms2);
                    }
                    var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    UPDT.P_UPDATE_T_BOOKING_ENTER_DOCT(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[1].Value), ref CLS.SUBMIT_FLAG);
                    this.Close();

                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, Convert.ToDateTime(DATE_BOOKING.Value), CLS.USER_CODE);

            this.p_GET_T_BOOKING_T_PERSON_BACKTODOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_BACKTODOCT, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType( CLS.USER_CODE, typeof(int))))));

        }

        
    }
}
