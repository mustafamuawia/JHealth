using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.REPORTS
{

    public partial class FRM_DOCTORS_DEBIT :MEDICALCLINIC.HOSPITAL. BaseHospital
    {
        int F_PRINT = -1;
        DataTable DT = new DataTable();
        public FRM_DOCTORS_DEBIT()
        {
            InitializeComponent();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void RB_DRP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //this.gET_H_ALL_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALL_DOCTOR, "");

                //this.gET_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void RB_DRTK_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //this.gET_H_DOCTOR_TAKDEERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_DOCTOR_TAKDEER, "");

                //this.gET_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }





        private void BTN_ALL_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                F_PRINT = 1;
                LBL_PAID.Text = "0.00";
                LBL_TOTAL.Text = "0.00";
                LBL_REMAIN.Text = "0.00";
                LBL_TOTA_OP.Text = "0.00";
                this.gET_H_BOOKING_PRICE_OP_DRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                this.gET_H_TOTAL_DEBIT_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_FROM.Value, DATE_TO.Value, 1);
                LBL_PAID.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][0]).ToString("#,##0.00");
                LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][1]).ToString("#,##0.00");
                LBL_REMAIN.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][2]).ToString("#,##0.00");

                LBL_TOTA_OP.Text =
                            (from DataGridViewRow row in gET_H_BOOKING_PRICE_OP_DRPDataGridView.Rows
                             where row.Cells[12].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString("#,##0.00");
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_TOW_DATE_Click(object sender, EventArgs e)
        {
            try
            {
                F_PRINT = 3;
                LBL_PAID.Text = "0.00";
                LBL_TOTAL.Text = "0.00";
                LBL_REMAIN.Text = "0.00";
                LBL_TOTA_OP.Text = "0.00";
                this.gET_H_BOOKING_PRICE_OP_DRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
                this.gET_H_TOTAL_DEBIT_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_FROM.Value, DATE_TO.Value, 3);
                LBL_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][0].ToString();
                LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][1].ToString();
                LBL_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][2].ToString();

                LBL_TOTA_OP.Text =
                            (from DataGridViewRow row in gET_H_BOOKING_PRICE_OP_DRPDataGridView.Rows
                             where row.Cells[12].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ONEDATE_Click(object sender, EventArgs e)
        {
            try
            {
                F_PRINT = 2;
                LBL_PAID.Text = "0.00";
                LBL_TOTAL.Text = "0.00";
                LBL_REMAIN.Text = "0.00";
                LBL_TOTA_OP.Text = "0.00";
                this.gET_H_BOOKING_PRICE_OP_DRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                this.gET_H_TOTAL_DEBIT_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), DATE_FROM.Value, DATE_TO.Value, 2);
                LBL_PAID.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][0].ToString();
                LBL_TOTAL.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][1].ToString();
                LBL_REMAIN.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][2].ToString();
                LBL_TOTA_OP.Text =
                            (from DataGridViewRow row in gET_H_BOOKING_PRICE_OP_DRPDataGridView.Rows
                             where row.Cells[12].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
            }
            catch (System.Exception ex)
            {
                //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_DOCTORS_DEBIT_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            this.gET_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

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

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {


            ////int  B_CODE = Convert.ToInt32(B_NAMEComboBox.SelectedValue);
            //  var GET_BILL = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            //  //GET_BILL.P_GET_BILL_NUMBER(B_CODE, CLS.DOCTOR_CODE_GENE, ref BILL_SANAD);
            // // BILL_NUMBERTextBoxX.Text = BILL_SANAD.ToString();
            //string  SANAD_DISCRIPTION = "\\من ح/  الصندوق   الى ح/ " +  dOCTOR_NAMEComboBox.SelectedText;
            ////  ACCOUNT_FROM_CODE = Convert.ToInt32(ACCOUNT_FROMCODETextBoxX.Text);
            //  var INSERT_SALES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            //  var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            //  var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            //  int BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
            //               int.Parse( gET_H_BOOKING_PRICE_OP_DRPDataGridView.Rows[0].Cells[0].Value.ToString())
            //              , System.DateTime.Now
            //              , 10
            //              , 0
            //              , true
            //              , CLS.USER_CODE
            //              , ref CLS.SUBMIT_FLAG
            //              ).ToString());

            //  INSERTBOXDET.P_INSERT_T_BOX_DETAILS
            //                      (
            //                       int.Parse(gET_H_BOOKING_PRICE_OP_DRPDataGridView.Rows[0].Cells[0].Value.ToString())
            //                      , Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
            //                      , SANAD_DISCRIPTION
            //                      , 0
            //                      , 0
            //                      , Convert.ToDecimal(TXT_PAY_NOW.Text)
            //                      , 0
            //                      , ""
            //                      , 1
            //                      , 1
            //                      , ref CLS.SUBMIT_FLAG
            //                       );

            //  //TO

            //  INSERTBOXDET.P_INSERT_T_BOX_DETAILS
            //  (
            //    int.Parse(gET_H_BOOKING_PRICE_OP_DRPDataGridView.Rows[0].Cells[0].Value.ToString())
            //  , 111
            //   , SANAD_DISCRIPTION
            //  , 0
            //  , 0
            //  , 0
            //  , Convert.ToDecimal(TXT_PAY_NOW.Text)
            //  , ""
            //  , 1
            //  , 1
            //  , ref CLS.SUBMIT_FLAG
            //   );
            SANAD.FRM_SANAD FRM = new SANAD.FRM_SANAD(); FRM.ShowDialog();


        }
        bool ACTIVR_F = false;
        private void FRM_DOCTORS_DEBIT_Activated(object sender, EventArgs e)
        {
            if (ACTIVR_F == true)
            {
                BTN_ALL_SEARCH_Click(null, null);
                BTN_ONEDATE_Click(null, null);
                BTN_TOW_DATE_Click(null, null);
                ACTIVR_F = false;
            }


        }

        //private void gET_H_BOOKING_PRICE_OP_DRPDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex==0)
        //    {
        //        FRM_OP_ACCESSORIES FRM = new FRM_OP_ACCESSORIES(Convert.ToInt32(gET_H_BOOKING_PRICE_OP_DRPDataGridView.CurrentRow.Cells[2].Value));
        //        FRM.ShowDialog();
        //        }
        //}

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
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
                if (F_PRINT == -1)
                {
                    MessageBox.Show("يرجى ظغط زر بحث اولا");
                }
                //  BTN_SAVEE_Click(null, null);

                //HOSPITAL.PRINT.FRM_PRINT_DEBIT_DOCT myfrrm = new HOSPITAL.PRINT.FRM_PRINT_DEBIT_DOCT();
                //HOSPITAL.PRINT.RPT_DR_ALL_OPERATION mmprt = new HOSPITAL.PRINT.RPT_DR_ALL_OPERATION();
                //PrinterSettings settings = new PrinterSettings();
                //SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString);
                //string ServerName = SqlConnectionStringBuilder.DataSource;
                //string DatabaseName = SqlConnectionStringBuilder.InitialCatalog;
                //Boolean IntegratedSecurity = SqlConnectionStringBuilder.IntegratedSecurity;
                //string UserID = SqlConnectionStringBuilder.UserID;
                //string Password = SqlConnectionStringBuilder.Password;

                //foreach (CrystalDecisions.CrystalReports.Engine.Table Table in mmprt.Database.Tables)
                //{
                //    CrystalDecisions.Shared.TableLogOnInfo TableLogOnInfo = Table.LogOnInfo;
                //    TableLogOnInfo.ConnectionInfo.ServerName = ServerName;
                //    TableLogOnInfo.ConnectionInfo.DatabaseName = DatabaseName;
                //    TableLogOnInfo.ConnectionInfo.IntegratedSecurity = IntegratedSecurity;

                //    if (IntegratedSecurity != true)
                //    {
                //        TableLogOnInfo.ConnectionInfo.UserID = UserID;
                //        TableLogOnInfo.ConnectionInfo.Password = Password;
                //    }
                //    Table.ApplyLogOnInfo(TableLogOnInfo);
                //}
                ////  mmprt.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DataBase, Properties.Settings.Default.ID, Properties.Settings.Default.Password);
                //mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                //DataTable DTDATA = new DataTable();
                //DataTable DTHDR = new DataTable();
                if (F_PRINT == 1)
                {
                    this.gET_H_BOOKING_PRICE_OP_DRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

                }
                else
  if (F_PRINT == 2)
                {
                    this.gET_H_BOOKING_PRICE_OP_DRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                }
                else
  if (F_PRINT == 3)
                {
                    this.gET_H_BOOKING_PRICE_OP_DRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));

                }



                //DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP;
                //this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 1);
                //DTHDR = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                ////lصدر بيانات الصورة
                //mmprt.Subreports[0].SetDataSource(DTHDR);//lصدر بيانات الجدول الاخر
                //mmprt.SetDataSource(DTDATA);
                //myfrrm.crystalReportViewer1.ReportSource = mmprt;
                //myfrrm.ShowDialog();
                //mmprt.PrintToPrinter(1, false, 0, 0);
                Cursor.Current = Cursors.Default;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ALL_PRINT_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // CLS.ID_BOOK_PRINT = Convert.ToInt32(TXT_ID_BOOK.Text);
                BTN_ALL_SEARCH_Click(null, null);
                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("حدد الطابعة أولا");
                    SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                    FRM.ShowDialog();
                    return;

                }



                //HOSPITAL.PRINT.FRM_PRINT_DEBIT_DOCT myfrrm = new HOSPITAL.PRINT.FRM_PRINT_DEBIT_DOCT();
                //HOSPITAL.PRINT.RPT_DR_ALL_OPERATION mmprt = new HOSPITAL.PRINT.RPT_DR_ALL_OPERATION();
                //PrinterSettings settings = new PrinterSettings();
                //SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString);
                //string ServerName = SqlConnectionStringBuilder.DataSource;
                //string DatabaseName = SqlConnectionStringBuilder.InitialCatalog;
                //Boolean IntegratedSecurity = SqlConnectionStringBuilder.IntegratedSecurity;
                //string UserID = SqlConnectionStringBuilder.UserID;
                //string Password = SqlConnectionStringBuilder.Password;

                //foreach (CrystalDecisions.CrystalReports.Engine.Table Table in mmprt.Database.Tables)
                //{
                //    CrystalDecisions.Shared.TableLogOnInfo TableLogOnInfo = Table.LogOnInfo;
                //    TableLogOnInfo.ConnectionInfo.ServerName = ServerName;
                //    TableLogOnInfo.ConnectionInfo.DatabaseName = DatabaseName;
                //    TableLogOnInfo.ConnectionInfo.IntegratedSecurity = IntegratedSecurity;

                //    if (IntegratedSecurity != true)
                //    {
                //        TableLogOnInfo.ConnectionInfo.UserID = UserID;
                //        TableLogOnInfo.ConnectionInfo.Password = Password;
                //    }
                //    Table.ApplyLogOnInfo(TableLogOnInfo);
                //}
                ////  mmprt.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DataBase, Properties.Settings.Default.ID, Properties.Settings.Default.Password);
                //mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                //DataTable DTDATA = new DataTable();
                //DataTable DTHDR = new DataTable();

                //    this.gET_H_BOOKING_PRICE_OP_DRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));





                //DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP;
                //this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 1);
                //DTHDR = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                ////lصدر بيانات الصورة
                //mmprt.Subreports[0].SetDataSource(DTHDR);//lصدر بيانات الجدول الاخر
                //mmprt.SetDataSource(DTDATA);
                //myfrrm.crystalReportViewer1.ReportSource = mmprt;
                //myfrrm.ShowDialog();
                //mmprt.PrintToPrinter(1, false, 0, 0);
                Cursor.Current = Cursors.Default;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ONEDATE_PRINT_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // CLS.ID_BOOK_PRINT = Convert.ToInt32(TXT_ID_BOOK.Text);
                BTN_ONEDATE_Click(null, null);
                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("حدد الطابعة أولا");
                    SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                    FRM.ShowDialog();
                    return;

                }



                //HOSPITAL.PRINT.FRM_PRINT_DEBIT_DOCT myfrrm = new HOSPITAL.PRINT.FRM_PRINT_DEBIT_DOCT();
                //HOSPITAL.PRINT.RPT_DR_ALL_OPERATION mmprt = new HOSPITAL.PRINT.RPT_DR_ALL_OPERATION();
                //PrinterSettings settings = new PrinterSettings();
                //SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString);
                //string ServerName = SqlConnectionStringBuilder.DataSource;
                //string DatabaseName = SqlConnectionStringBuilder.InitialCatalog;
                //Boolean IntegratedSecurity = SqlConnectionStringBuilder.IntegratedSecurity;
                //string UserID = SqlConnectionStringBuilder.UserID;
                //string Password = SqlConnectionStringBuilder.Password;

                //foreach (CrystalDecisions.CrystalReports.Engine.Table Table in mmprt.Database.Tables)
                //{
                //    CrystalDecisions.Shared.TableLogOnInfo TableLogOnInfo = Table.LogOnInfo;
                //    TableLogOnInfo.ConnectionInfo.ServerName = ServerName;
                //    TableLogOnInfo.ConnectionInfo.DatabaseName = DatabaseName;
                //    TableLogOnInfo.ConnectionInfo.IntegratedSecurity = IntegratedSecurity;

                //    if (IntegratedSecurity != true)
                //    {
                //        TableLogOnInfo.ConnectionInfo.UserID = UserID;
                //        TableLogOnInfo.ConnectionInfo.Password = Password;
                //    }
                //    Table.ApplyLogOnInfo(TableLogOnInfo);
                //}
                ////  mmprt.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DataBase, Properties.Settings.Default.ID, Properties.Settings.Default.Password);
                //mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                //DataTable DTDATA = new DataTable();
                //DataTable DTHDR = new DataTable();

                //this.gET_H_BOOKING_PRICE_OP_DRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));





                //DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP;
                //this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 1);
                //DTHDR = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                ////lصدر بيانات الصورة
                //mmprt.Subreports[0].SetDataSource(DTHDR);//lصدر بيانات الجدول الاخر
                //mmprt.SetDataSource(DTDATA);
                //myfrrm.crystalReportViewer1.ReportSource = mmprt;
                //myfrrm.ShowDialog();
                //mmprt.PrintToPrinter(1, false, 0, 0);
                Cursor.Current = Cursors.Default;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_TOW_DATE_PRINT_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // CLS.ID_BOOK_PRINT = Convert.ToInt32(TXT_ID_BOOK.Text);
                BTN_TOW_DATE_Click(null, null);
                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("حدد الطابعة أولا");
                    SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                    FRM.ShowDialog();
                    return;

                }



                //HOSPITAL.PRINT.FRM_PRINT_DEBIT_DOCT myfrrm = new HOSPITAL.PRINT.FRM_PRINT_DEBIT_DOCT();
                //HOSPITAL.PRINT.RPT_DR_ALL_OPERATION mmprt = new HOSPITAL.PRINT.RPT_DR_ALL_OPERATION();
                //PrinterSettings settings = new PrinterSettings();
                //SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.MEDICAL_CLINIC_DBConnectionString);
                //string ServerName = SqlConnectionStringBuilder.DataSource;
                //string DatabaseName = SqlConnectionStringBuilder.InitialCatalog;
                //Boolean IntegratedSecurity = SqlConnectionStringBuilder.IntegratedSecurity;
                //string UserID = SqlConnectionStringBuilder.UserID;
                //string Password = SqlConnectionStringBuilder.Password;

                //foreach (CrystalDecisions.CrystalReports.Engine.Table Table in mmprt.Database.Tables)
                //{
                //    CrystalDecisions.Shared.TableLogOnInfo TableLogOnInfo = Table.LogOnInfo;
                //    TableLogOnInfo.ConnectionInfo.ServerName = ServerName;
                //    TableLogOnInfo.ConnectionInfo.DatabaseName = DatabaseName;
                //    TableLogOnInfo.ConnectionInfo.IntegratedSecurity = IntegratedSecurity;

                //    if (IntegratedSecurity != true)
                //    {
                //        TableLogOnInfo.ConnectionInfo.UserID = UserID;
                //        TableLogOnInfo.ConnectionInfo.Password = Password;
                //    }
                //    Table.ApplyLogOnInfo(TableLogOnInfo);
                //}
                ////  mmprt.DataSourceConnections[0].SetConnection(Properties.Settings.Default.Server, Properties.Settings.Default.DataBase, Properties.Settings.Default.ID, Properties.Settings.Default.Password);
                //mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                //DataTable DTDATA = new DataTable();
                //DataTable DTHDR = new DataTable();
                //this.gET_H_BOOKING_PRICE_OP_DRPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
                //DTDATA = this.mEDICAL_CLINIC_DBDataSet.GET_H_BOOKING_PRICE_OP_DRP;
                //this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, 1);
                //DTHDR = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                ////lصدر بيانات الصورة
                //mmprt.Subreports[0].SetDataSource(DTHDR);//lصدر بيانات الجدول الاخر
                //mmprt.SetDataSource(DTDATA);
                //myfrrm.crystalReportViewer1.ReportSource = mmprt;
                //myfrrm.ShowDialog();
                //mmprt.PrintToPrinter(1, false, 0, 0);
                Cursor.Current = Cursors.Default;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void gET_H_BOOKING_PRICE_OP_DRPDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                FRM_OP_ACCESSORIES FRM = new FRM_OP_ACCESSORIES(Convert.ToInt32(gET_H_BOOKING_PRICE_OP_DRPDataGridView.CurrentRow.Cells[2].Value));
                FRM.ShowDialog();
            }
        }


    }
}
