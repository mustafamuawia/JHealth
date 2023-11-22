using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.ACCOUNT
{
    public partial class FRM_DOCTORT_DEBIT_CLINIC :MEDICALCLINIC.SETTING.baseclinicanddental
    {
        DataTable dt = new DataTable();

        public FRM_DOCTORT_DEBIT_CLINIC()
        {
            InitializeComponent();
        }



        private void FRM_CUSTOMER_DEBIT_Load(object sender, EventArgs e)
        {  var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
             this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
             dt = this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR;
            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasource.Add(dt.Rows[i][1].ToString());
            }
            this.dOCTOR_NAMEComboBox.AutoCompleteCustomSource = datasource;
            this.dOCTOR_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.dOCTOR_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void TXT_PAY_NOW_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var origText = this.TXT_PAY_NOW.Text;

                this.TXT_PAY_NOW.Text = Convert.ToDecimal(this.TXT_PAY_NOW.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PAY_NOW.SelectionStart = TXT_PAY_NOW.TextLength;
                LBL_REMAIN_AFT.Text = (Convert.ToDecimal(LBL_REMAIN.Text) - Convert.ToDecimal(TXT_PAY_NOW.Text)).ToString();

            }
            catch
            {
                return;
            }
        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {

            SANAD.FRM_SANAD frm = new SANAD.FRM_SANAD();
            frm.ShowDialog();
            //     if (TXT_PAY_NOW.Text==String.Empty)
            //     {
            //         MessageBox.Show("يرجى ادخال المبلغ المستلم اولا");
            //         return;
            //     }
            //     var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            //     var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            //     int BOXID;
            //     //int rowno = dgvalldata.Rows.Count ;
            //     //int idbook = Convert.ToInt32(dgvalldata.Rows[0].Cells[0].Value);
            //     var GET_BILL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            //     GET_BILL.P_GET_BILL_NUMBER(B_CODE, CLS.DOCTOR_CODE_GENE, ref BILL_SANAD);
            //     BOXID = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
            //            idbook
            //          , System.DateTime.Now
            //          ,""
            //          , 8
            //          , 0
            //          , true
            //          , CLS.USER_CODE
            //          , ref CLS.SUBMIT_FLAG
            //          ).ToString()); ; ;
            //     INSERTBOXDET.P_INSERT_T_BOX_DETAILS
            //                     (
            //                      BOXID
            //                     , 111
            //                     , "الصندوق"
            //                     , 0
            //                     , 0
            //                     , Convert.ToDecimal(TXT_PAY_NOW.Text)
            //                     , 0
            //                     , "من حساب الصندوق الى حساب الزبون"
            //                     , 1
            //                     , 1
            //                     , ref CLS.SUBMIT_FLAG
            //                      );

            //     INSERTBOXDET.P_INSERT_T_BOX_DETAILS
            //(
            // BOXID
            //, Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
            //, "المريض"
            //, 0
            //, 0
            //, 0
            //, Convert.ToDecimal(TXT_PAY_NOW.Text)
            //, "من حساب الزبون الى حساب الصندوق "
            //, 1
            //, 1
            //, ref CLS.SUBMIT_FLAG
            // );
            //     TXT_PAY_NOW.Text = String.Empty;
            //     pERSON_NAMEComboBox_SelectedIndexChanged(null, null);
            //     Cursor.Current = Cursors.WaitCursor;
            //     // CLS.ID_BOOK_PRINT = Convert.ToInt32(TXT_ID_BOOK.Text);

            //     if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
            //     {
            //         MessageBox.Show("حدد الطابعة أولا");
            //         SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
            //         FRM.ShowDialog();
            //         return;

            //     }

            //     DataTable dt = new DataTable();
            //     DataTable dt1 = new DataTable();
            //     this.gET_SANAD_TO_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType(BOXID, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), 19);
            //     dt = this.mEDICAL_CLINIC_DBDataSet.GET_SANAD_TO_PRINT;
            //     this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            //     dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
            //     LocalReport lr = new LocalReport();
            //     lr.ReportEmbeddedResource = "MEDICALCLINIC.SANAD.PRINT.RPT_SANAD_QBD.rdlc";
            //     lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
            //     lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
            //     lr.Print();


        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_DEBIT_BY_BCODE_ACOD_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD_DET, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))),0,dateTimePicker1.Value,dateTimePicker2.Value, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

                //this.gET_H_DEBIT_BY_BCODE_ACOD_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DEBIT_BY_BCODE_ACOD_DET, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType( 12, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                // gET_H_DEBIT_BY_BCODE_ACOD_DETDataGridView.Rows.RemoveAt(gET_H_DEBIT_BY_BCODE_ACOD_DETDataGridView.CurrentRow.Index);
                LBL_TOTAL.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                LBL_PAID.Text = dgvalldata.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[4].Value)).ToString();
                LBL_REMAIN.Text = (Convert.ToDecimal(LBL_TOTAL.Text) - Convert.ToDecimal(LBL_PAID.Text)).ToString();
            }
            catch (System.Exception ex)
            {
                  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
