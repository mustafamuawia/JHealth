using MEDICALCLINIC.HOSPITAL.PRINT;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL
{
    public partial class FRM_DETAILS_PROCEDURE : MEDICALCLINIC.HOSPITAL.BaseHospital
    {
        int id_person, CODE_OPE;
        string BOOK_DES;
        int BOOK_CODE ;
        int PERSON_CODE;
        public FRM_DETAILS_PROCEDURE(string BOOK_CODE_COME, int ID_OPE)
        {
            InitializeComponent();
            BOOK_DES = BOOK_CODE_COME;
            CODE_OPE = ID_OPE;
        }
        public FRM_DETAILS_PROCEDURE()
        {
            InitializeComponent();


        }
        private void FRM_DETAILS_PROCEDURE_Load(object sender, EventArgs e)
        {
            try
            {
                var workingArea = Screen.FromHandle(Handle).WorkingArea;
                MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
                WindowState = FormWindowState.Maximized;
                // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_H_SERVCE_TYPE' table. You can move, or remove it, as needed.
                this.v_A_H_SERVCE_TYPETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_SERVCE_TYPE);
                // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_H_OPERATION' table. You can move, or remove it, as needed.
                this.v_A_H_OPERATIONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_OPERATION);
                // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
                this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);

                this.gET_H_BOOK_INFOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOK_INFO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_DES, typeof(int))))));

                label18.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOK_INFO.Rows[0][2].ToString();
                id_person = Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOK_INFO.Rows[0][1]);
                this.gET_H_SERVICE_INFOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_SERVICE_INFO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_DES, typeof(int))))));

                this.gET_MEDICAL_HISTORY_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY_P, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_person, typeof(int))))));



                // this.gET_H_BOOKING_BY_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_BY_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_DES, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))));
              
                // this.gET_H_OPERATION_INFOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_DES, typeof(int))))), 1);

                // gET_H_OPERATION_INFODataGridView.Rows[0].Cells[1].Value
                this.gET_H_PERSON_COD_BOOKTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_COD_BOOK, new System.Nullable<int>(((int)(System.Convert.ChangeType(CODE_OPE , typeof(int))))), 1);

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
                        LBL_OP_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                    }
                    this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(18, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                    if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                    {
                        //  LBL_M_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                        // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                        //  LBL_M_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                        LBL_M_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();


                    }
                    this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(17, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                    if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                    {
                        //   LBL_S_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                        // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                        //   LBL_S_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                        LBL_S_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                    }



                }







                //LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO.Rows[0][21].ToString();

                //if (Convert.ToBoolean(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO.Rows[0][37]) == false){
                //    label3.Text = "غير واصل";
                //    label3.ForeColor = Color.Red;
                //}
                //else

                //if (Convert.ToBoolean(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO.Rows[0][37]) == true)
                //{
                //    label3.Text = " واصل";
                //    label3.ForeColor = Color.DarkGreen;
                //}
            }
            catch (System.Exception ex)
            {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
            }


            // this.reportViewer.RefreshReport();
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }









        private void BTN_OPER_REF_Click(object sender, EventArgs e)
        {
            this.gET_H_OPERATION_INFOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_DES, typeof(int))))), 1);

        }

        private void PIC_OP_REF_Click(object sender, EventArgs e)
        {
            //  this.gET_H_OPERATION_INFOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_DES, typeof(int))))),1);
            HOSPITAL.SERVICES.FRM_H_OP_MONEY_SERVICE frm = new SERVICES.FRM_H_OP_MONEY_SERVICE(Convert.ToInt32(BOOK_DES), id_person); frm.ShowDialog();

        }

        private void PIC_OP_ADD_Click(object sender, EventArgs e)
        {
            HOSPITAL.OPERA.FRM_ADD_OPERATN_INFO frm = new OPERA.FRM_ADD_OPERATN_INFO(Convert.ToInt32(BOOK_DES), 0, 1, id_person);
            frm.ShowDialog();
        }

        private void PIC_SERV_ADD_Click(object sender, EventArgs e)
        {
            HOSPITAL.OPERA.FRM_OPE_SERVICE FRM = new HOSPITAL.OPERA.FRM_OPE_SERVICE(Convert.ToInt32(BOOK_DES), Convert.ToInt32(id_person));
            FRM.ShowDialog();
        }

        private void PIC_SERV_REF_Click(object sender, EventArgs e)
        {
            //this.gET_H_SERVICE_INFOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_SERVICE_INFO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_DES, typeof(int))))));
            try
            {
                this.gET_BOOKI_INVOICETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKI_INVOICE, BOOK_DES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void PIC_MED_ADD_Click(object sender, EventArgs e)
        {
            PERSONS.FRM_MEDICAL_HISTORY_PERSON FRM = new PERSONS.FRM_MEDICAL_HISTORY_PERSON(0);
            FRM.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OPERA.FRM_OPRATION_MONEY FRM = new OPERA.FRM_OPRATION_MONEY(Convert.ToInt32(BOOK_DES));
            FRM.ShowDialog();
        }

        private void PIC_MED_REF_Click(object sender, EventArgs e)
        {
            int ccc = id_person;
            this.gET_MEDICAL_HISTORY_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY_P, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_person, typeof(int))))));

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OPERA.FRM_OUT_PERSON FRM = new OPERA.FRM_OUT_PERSON(BOOK_DES, 0, label18.Text);
            FRM.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LAB.FRM_SEND_TO_LABTEST frm = new LAB.FRM_SEND_TO_LABTEST(id_person, Convert.ToInt32(BOOK_DES));
            frm.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            XRAY.FRM_REQUEST_XRAY FRM = new XRAY.FRM_REQUEST_XRAY(id_person, -1, Convert.ToInt32(BOOK_DES));
            FRM.ShowDialog();
        }

        private void BTN_MONEY_Click(object sender, EventArgs e)
        {
            //OPERA.FRM_OPRATION_MONEY FRM = new OPERA.FRM_OPRATION_MONEY(Convert.ToInt32(BOOK_DES));
            //FRM.ShowDialog();
            //SERVICES.FRM_H_OP_MONEY_SERVICE FRM = new SERVICES.FRM_H_OP_MONEY_SERVICE(Convert.ToInt32(BOOK_DES), Convert.ToInt32(id_person));
            //FRM.ShowDialog();
            try
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
                //  BTN_SAVEE_Click(null, null);
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                this.gET_H_INVOICE_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_INVOICE_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_DES, typeof(int))))));
                dt = this.mEDICAL_CLINIC_DBDataSet.GET_H_INVOICE_PRINT;
                this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(6, typeof(int))))));
                dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                LocalReport lr = new LocalReport();
            
                lr.ReportEmbeddedResource = "MEDICALCLINIC.HOSPITAL.PRINT.FINAL_INVOICE.rdlc";
                lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                lr.Print();
                
                Cursor.Current = Cursors.Default;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void BTN_LOGOUT_Click(object sender, EventArgs e)
        {
            //int ID_OP = Convert.ToInt32(gET_H_OPERATION_INFODataGridView.Rows[0].Cells[1].Value);
            OPERA.FRM_OUT_PERSON FRM = new OPERA.FRM_OUT_PERSON(BOOK_DES, CODE_OPE, label18.Text);
            FRM.ShowDialog();
        }

        private void BTN_REQ_RAY_Click(object sender, EventArgs e)
        {
            XRAY.FRM_REQUEST_XRAY FRM = new XRAY.FRM_REQUEST_XRAY(id_person, -1, Convert.ToInt32(BOOK_DES));
            FRM.ShowDialog();
        }

        private void BTN_REQ_LAB_Click(object sender, EventArgs e)
        {
            LAB.FRM_SEND_TO_LABTEST frm = new LAB.FRM_SEND_TO_LABTEST(id_person, Convert.ToInt32(BOOK_DES));
            frm.ShowDialog();
        }
 
        private void FRM_DETAILS_PROCEDURE_Activated(object sender, EventArgs e)
        {
            try
            {
                this.gET_BOOKI_INVOICETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKI_INVOICE, BOOK_DES);

                int ccc = id_person;
                this.gET_MEDICAL_HISTORY_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_MEDICAL_HISTORY_P, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_person, typeof(int))))));
                this.gET_H_OPERATION_INFOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_INFO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_DES, typeof(int))))), 1);
                this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(13, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                {

                    //  LBL_OP_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                    // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                    // LBL_OP_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                    LBL_OP_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                }
                this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(18, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                {
                    //  LBL_M_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                    // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                    //  LBL_M_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                    LBL_M_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();


                }
                this.gET_H_DEBIT_BY_BCODE_ACODE_BILLNOTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOOK_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(17, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                if (this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows.Count > 0)
                {
                    //   LBL_S_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][0].ToString();
                    // TXT_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_BEBIT_BY_BCODE_ACODE_CODE.Rows[0][2].ToString();
                    //   LBL_S_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][1].ToString();
                    LBL_S_B_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACODE_BILLNO.Rows[0][2].ToString();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       


        private void gET_H_OPERATION_INFODataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                HOSPITAL.OPERA.FRM_ADD_OPERATN_INFO frm = new OPERA.FRM_ADD_OPERATN_INFO(Convert.ToInt32(BOOK_DES), Convert.ToInt32(gET_H_OPERATION_INFODataGridView.CurrentRow.Cells[2].Value), 2, id_person);
                frm.ShowDialog();
            }
            else
            if (e.ColumnIndex == 1)
            {
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                this.gET_H_PERSON_BOOKING_IDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERSON_BOOKING_ID, new System.Nullable<int>(((int)(System.Convert.ChangeType( gET_H_OPERATION_INFODataGridView.CurrentRow.Cells[2].Value, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
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
            }
        }

        private void BTN_SHOWLABTEST_Click(object sender, EventArgs e)
        {
            HOSPITAL.OPERA.FRM_L_SHOW_LABTEST_RESULT FRM = new OPERA.FRM_L_SHOW_LABTEST_RESULT(id_person);
            FRM.ShowDialog();
        }

        private void BTN_SHOWXRAY_Click(object sender, EventArgs e)
        {
            HOSPITAL.OPERA.FRM_L_SHOW_XRAY_RESULT FRM = new OPERA.FRM_L_SHOW_XRAY_RESULT(id_person);
            FRM.ShowDialog();
        }

       

        private void BTN_ITEM_OP_Click(object sender, EventArgs e)
        {
            HOSPITAL.OPERA.FRM_ITEM_OPERATION_TOOLS FRM = new OPERA.FRM_ITEM_OPERATION_TOOLS(CODE_OPE);
            FRM.ShowDialog();
        }




    }
}
