using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.DIAGNOSES
{
    public partial class FRM_SHOW_ALL_BOOKING : Form
    {
        int? PER_PAYID = 0;
        int? PER_NO_PAID = 0;
         DataTable GGG = new DataTable();
        public FRM_SHOW_ALL_BOOKING()
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
                this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, Convert.ToDateTime(DATE_BOOKING.Value), CLS.USER_CODE);
                this.p_GET_T_BOOKING_T_PERSON_BACKTODOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_BACKTODOCT, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));

                // this.v_PER_PAID_TO_BOXTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_PER_PAID_TO_BOX);
                //this.v_PERS_DEBIT_ALL_USERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_PERS_DEBIT_ALL_USER);
                //   LBL_DOC_NAME.Text = CLS.USER_NAME;
                this.gET_NUM_MONEY_CHECKEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED, CLS.USER_CODE, DATE_BOOKING.Value);
                LBL_TOTAT_PAY_FOR.Text = this.mEDICAL_CLINIC_DBDataSet.GET_NUM_MONEY_CHECKED.Rows[0][0].ToString();
                var GET_NUM_AC_INC = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                GET_NUM_AC_INC.GET_NUM_PERSON_PAY_NOPAY(CLS.USER_CODE, DATE_BOOKING.Value, ref PER_PAYID, 1);
                LBL_NUM_PAID.Text = PER_PAYID.ToString();

                var GET_NUM_AC_INC1 = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                GET_NUM_AC_INC1.GET_NUM_PERSON_PAY_NOPAY(CLS.USER_CODE, DATE_BOOKING.Value, ref PER_NO_PAID, 0);
                LBL_NUM_NO_PAID.Text = PER_NO_PAID.ToString();
                this.gET_COUNT_TEST_UNTESTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COUNT_TEST_UNTEST, DATE_BOOKING.Value, CLS.USER_CODE, true);
                LBL_TESTED.Text = this.mEDICAL_CLINIC_DBDataSet.GET_COUNT_TEST_UNTEST.Rows[0][0].ToString();

                this.gET_COUNT_TEST_UNTESTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COUNT_TEST_UNTEST, DATE_BOOKING.Value, CLS.USER_CODE, false);
                LBL_UNTEST.Text = this.mEDICAL_CLINIC_DBDataSet.GET_COUNT_TEST_UNTEST.Rows[0][0].ToString();
 
                LBL_NUM_PER.Text = dataGridView2.Rows.Count.ToString();

                //if (dataGridView2.Rows.Count > 0)
                //{
         
                //    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                //    {
                //        bool IS_CHEK = Convert.ToBoolean(this.dataGridView2.Rows [i].Cells[10].Value);
                //        if (IS_CHEK == true)
                //        {
                //            this.dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Teal;
                //        }
                //    }

                //}
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message+"لا يوجد حجوزات مفعلة");
            }

        }

        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 12)
                {



                     ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_ID_PERSON.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
                     ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_ID_DOCTOR.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
                     ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_ID_BOOK.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
                     ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]). TXT_PERSON.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
                     ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_BOOK_TYPE.Text = this.dataGridView2.CurrentRow.Cells[6].Value.ToString();
                     ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]). TXT_DISEASE.Text = this.dataGridView2.CurrentRow.Cells[7].Value.ToString();
                     ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).lbl_l_paitent_name.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                     ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_RAY_NAME_PERSON.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                     ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).lbl_paitent_name_med.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                     this.gET_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(this.dataGridView2.CurrentRow.Cells[2].Value.ToString(), typeof(int))))), CLS.Cost_Center_WARD_DR,System.DateTime.Now,System.DateTime.Now, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                     
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_PAST_BORROW.Text = this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();

                 


                    bool PY_STATE = Convert.ToBoolean(this.dataGridView2.CurrentRow.Cells[11].Value);
                    if (PY_STATE == true)
                    {
                         ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]). LBL_KSH_TYP.Text = "مدفوع";
                    }
                    else
                    {
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_KSH_TYP.Text = "غير مدفوع";
                    }
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_AGE.Text = this.dataGridView2.CurrentRow.Cells[13].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_SEX.Text = this.dataGridView2.CurrentRow.Cells[14].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DESC.Text = this.dataGridView2.CurrentRow.Cells[16].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_STATE.Text = this.dataGridView2.CurrentRow.Cells[17].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DRAGE.Text = this.dataGridView2.CurrentRow.Cells[18].Value.ToString();

                    gET_ORDER_BY_BOOKING_NUMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ORDER_BY_BOOKING_NUM, Convert.ToInt32( this.dataGridView2.CurrentRow.Cells[1].Value), CLS.USER_CODE);
                    
                    gET_BOOKING_BY_ID_PER_DOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT, CLS.USER_CODE, Convert .ToInt32 (this.dataGridView2.CurrentRow.Cells[2].Value),DATE_BOOKING .Value );
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT;
                    if (this.dataGridView2.CurrentRow.Cells[21].Value.ToString() != string .Empty  )
                    {
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).PIC_PERSON.Image = null;
                        byte[] imge2 = (byte[])this.dataGridView2.CurrentRow.Cells[21].Value;
                        MemoryStream ms2 = new MemoryStream(imge2);
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).PIC_PERSON.Image = Image.FromStream(ms2);
                    }
                    var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    UPDT.P_UPDATE_T_BOOKING_ENTER_DOCT(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[1].Value), ref CLS.SUBMIT_FLAG);
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
                                                                        , ref  CLS.SUBMIT_FLAG);


                        // ===================== TO
                        // int ACCOUNT_TO_CODE = Convert.ToInt32(LBL_NAMEPERSON.SelectedValue);

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

        //private void buttonX2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
               
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}

      

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                this.gET_BOOKING_BY_DATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_DATE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                this.p_GET_T_BOOKING_T_PERSON_BACKTODOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_T_BOOKING_T_PERSON_BACKTODOCT, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_BOOKING.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 12)
                {



                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_ID_PERSON.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_ID_DOCTOR.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_ID_BOOK.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_PERSON.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_BOOK_TYPE.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DISEASE.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).lbl_l_paitent_name.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_RAY_NAME_PERSON.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).lbl_paitent_name_med.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_AGE.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_SEX.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DESC.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_STATE.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DRAGE.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();

                    this.gET_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(this.dataGridView1.CurrentRow.Cells[2].Value.ToString(), typeof(int))))), CLS.Cost_Center_WARD_DR,System.DateTime.Now,System.DateTime.Now, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));

                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_PAST_BORROW.Text = this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();
                    


                    bool PY_STATE = Convert.ToBoolean(this.dataGridView1.CurrentRow.Cells[11].Value);
                    if (PY_STATE == true)
                    {
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_KSH_TYP.Text = "مدفوع";
                    }
                    else
                    {
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).LBL_KSH_TYP.Text = "غير مدفوع";
                    }
                   
                    gET_ORDER_BY_BOOKING_NUMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ORDER_BY_BOOKING_NUM, Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[1].Value), CLS.USER_CODE);

                    gET_BOOKING_BY_ID_PER_DOCTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT, CLS.USER_CODE, Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value), DATE_BOOKING.Value);
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.GET_BOOKING_BY_ID_PER_DOCT;
                    if (this.dataGridView1.CurrentRow.Cells[21].Value.ToString() != string.Empty)
                    {
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).PIC_PERSON.Image = null;
                        byte[] imge2 = (byte[])this.dataGridView1.CurrentRow.Cells[21].Value;
                        MemoryStream ms2 = new MemoryStream(imge2);
                        ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).PIC_PERSON.Image = Image.FromStream(ms2);
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

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}
