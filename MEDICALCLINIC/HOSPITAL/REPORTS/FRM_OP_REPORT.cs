using MEDICALCLINIC.HOSPITAL.PRINT;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.REPORTS
{

    public partial class FRM_OP_REPORT : MEDICALCLINIC.HOSPITAL. BaseHospital
    {
        int F_PRINT = -1;
        DataTable DT = new DataTable();
        public FRM_OP_REPORT()
        {
            InitializeComponent();
        }
        private void FRM_DOCTORS_DEBIT_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
           // this.gET_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))));
            this.gET_H_ALL_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALL_DOCTOR, "");

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




        decimal processmoney, takdermoney;
        private void BTN_ALL_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                F_PRINT =2;
                LBL_TOTAL_ACCES.Text = "0.00";
                LBL_TOTAL_OP.Text = "0.00";
                LBL_TOTAL_CONV.Text = "0.00";
                LBL_TOTAL_BOOK.Text = "0.00";
                LBL_PERCENT_PROCESS.Text = "0.00";
                LBL_PRECENT_TAKDER.Text = "0.00";
                
                this.gET_H_OPEARTION_REPORTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPEARTION_REPORT, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(F_PRINT, typeof(int))))));
                //LBL_PAID.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][0]).ToString("#,##0.00");
                //LBL_TOTAL.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][1]).ToString("#,##0.00");
                //LBL_REMAIN.Text = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet.GET_H_TOTAL_DEBIT_DOCTOR.Rows[0][2]).ToString("#,##0.00");

                LBL_TOTAL_BOOK.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[7].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString("#,##0"); 
                LBL_TOTAL_OP.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[10].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[10].FormattedValue)).Sum().ToString("#,##0");
                LBL_TOTAL_ACCES.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[8].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[8].FormattedValue)).Sum().ToString("#,##0");
                LBL_TOTAL_CONV.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[27].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[27].FormattedValue)).Sum().ToString("#,##0");
                LBL_PERCENT_PROCESS.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[25].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[25].FormattedValue)).Sum().ToString("#,##0");
                LBL_PRECENT_TAKDER.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[26].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[26].FormattedValue)).Sum().ToString("#,##0");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_TOW_DATE_Click(object sender, EventArgs e)
        {
            try
            {
                LBL_TOTAL_ACCES.Text = "0.00";
                LBL_TOTAL_OP.Text = "0.00";
                LBL_TOTAL_CONV.Text = "0.00";
                LBL_TOTAL_BOOK.Text = "0.00";
                LBL_PERCENT_PROCESS.Text = "0.00";
                LBL_PRECENT_TAKDER.Text = "0.00";
                F_PRINT = 1;
                    this.gET_H_OPEARTION_REPORTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPEARTION_REPORT, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(F_PRINT, typeof(int))))));

                LBL_TOTAL_BOOK.Text =
                           (from DataGridViewRow row in DGV_ALLDATA.Rows
                            where row.Cells[7].FormattedValue.ToString() != string.Empty
                            select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString("#,##0");
                LBL_TOTAL_OP.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[10].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[10].FormattedValue)).Sum().ToString("#,##0");
                LBL_TOTAL_ACCES.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[8].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[8].FormattedValue)).Sum().ToString("#,##0");
                LBL_TOTAL_CONV.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[27].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[27].FormattedValue)).Sum().ToString("#,##0");
                LBL_PERCENT_PROCESS.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[25].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[25].FormattedValue)).Sum().ToString("#,##0");
                LBL_PRECENT_TAKDER.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[26].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[26].FormattedValue)).Sum().ToString("#,##0");
            }
            catch (System.Exception ex)
            {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ONEDATE_Click(object sender, EventArgs e)
        {
            try
            {
               
            
            //LBL_TOTA_OP.Text =
            //                (from DataGridViewRow row in gET_H_BOOKING_PRICE_OP_DRPDataGridView.Rows
            //                 where row.Cells[12].FormattedValue.ToString() != string.Empty
            //                 select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
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

      




        private void TXT_PAY_NOW_TextChanged(object sender, EventArgs e)
        {
            try
            {

                //var origText = this.TXT_PAY_NOW.Text;

                //this.TXT_PAY_NOW.Text = Convert.ToDecimal(this.TXT_PAY_NOW.Text).ToString("N0", new CultureInfo("en-US"));
                //this.TXT_PAY_NOW.SelectionStart = TXT_PAY_NOW.TextLength;
                //LBL_REMAIN_AFT.Text = (Convert.ToDecimal(LBL_REMAIN.Text) - Convert.ToDecimal(TXT_PAY_NOW.Text)).ToString();

            }
            catch
            {
                return;
            }

        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
             
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
                
                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("حدد الطابعة أولا");
                    SETTING.FRM_LIST_PRINTER FRM2 = new SETTING.FRM_LIST_PRINTER();
                    FRM2.ShowDialog();
                    return;

                }
                HOSPITAL.PRINT.FRM_SHOW_H_RPT_SANAD FRM = new FRM_SHOW_H_RPT_SANAD(dOCTOR_NAMEComboBox.SelectedValue.ToInt(), DATE_FROM.Value, DATE_TO.Value, F_PRINT);
                FRM.ShowDialog();


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
               ;
                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("حدد الطابعة أولا");
                    SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                    FRM.ShowDialog();
                    return;

                }


 
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

                //if (pERSON_NAMEComboBox1 .SelectedIndex  ==-1)
                //{

                //    errorProvider1.SetError(pERSON_NAMEComboBox1, CLS.TXT_NULL);
                //}
                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("حدد الطابعة أولا");
                    SETTING.FRM_LIST_PRINTER FRM2 = new SETTING.FRM_LIST_PRINTER();
                    FRM2.ShowDialog();
                    return;
                }

                // CLS.ID_BOOK_PRINT = Convert.ToInt32(lblbookcode.Text);
                HOSPITAL.PRINT.FRM_SHOW_H_RPT_SANAD FRM = new FRM_SHOW_H_RPT_SANAD(dOCTOR_NAMEComboBox.SelectedValue.ToInt(),DATE_FROM.Value,DATE_TO.Value,F_PRINT);
                FRM.ShowDialog();
                
                //DataTable dt = new DataTable();
                //DataTable dt1 = new DataTable();
                //this.gET_H_OPEARTION_REPORTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPEARTION_REPORT, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TO.Value, typeof(System.DateTime))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(F_PRINT, typeof(int))))));
                //dt = this.mEDICAL_CLINIC_DBDataSet.GET_H_OPEARTION_REPORT;
                //this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
                //dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                //LocalReport lr = new LocalReport();
                //lr.ReportEmbeddedResource = "MEDICALCLINIC.HOSPITAL.PRINT.Report_op.rdlc";
                //lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                //lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                
                //lr.Print();
            

                Cursor.Current = Cursors.Default;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void gET_H_BOOKING_PRICE_OP_DRPDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_H_OPEARTION_REPORTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPEARTION_REPORT, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_FROM.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType( DATE_TO.Value, typeof(System.DateTime))))),  "", new System.Nullable<int>(((int)(System.Convert.ChangeType( F_PRINT, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void RB_DRTK_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CALC_Click(object sender, EventArgs e)
        {
            totalcal();
            LBL_TOTAL_BOOK.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[7].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString("#,##0");  
            LBL_TOTAL_ACCES.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[8].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[8].FormattedValue)).Sum().ToString("#,##0");
            LBL_TOTAL_OP.Text =
          (from DataGridViewRow row in DGV_ALLDATA.Rows
           where row.Cells[10].FormattedValue.ToString() != string.Empty
           select Convert.ToDouble(row.Cells[10].FormattedValue)).Sum().ToString("#,##0");

            LBL_TOTAL_CONV.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[27].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[27].FormattedValue)).Sum().ToString("#,##0");
            LBL_PERCENT_PROCESS.Text =
          (from DataGridViewRow row in DGV_ALLDATA.Rows
           where row.Cells[25].FormattedValue.ToString() != string.Empty
           select Convert.ToDouble(row.Cells[25].FormattedValue)).Sum().ToString("#,##0");
            LBL_PRECENT_TAKDER.Text =
                            (from DataGridViewRow row in DGV_ALLDATA.Rows
                             where row.Cells[26].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[26].FormattedValue)).Sum().ToString("#,##0");
        }
        decimal PRICE_CONV=0;
        private void totalcal()
        {
            for (int i = 0; i < DGV_ALLDATA.RowCount; i++)
            {
                DGV_ALLDATA.Rows[i].Cells[25].Value = ((DGV_ALLDATA.Rows[i].Cells[10].Value.ToDecimal() * DGV_ALLDATA.Rows[i].Cells[11].Value.ToDecimal()) / 100).ToString();
                DGV_ALLDATA.Rows[i].Cells[26].Value = ((DGV_ALLDATA.Rows[i].Cells[10].Value.ToDecimal() * DGV_ALLDATA.Rows[i].Cells[12].Value.ToDecimal()) / 100).ToString();
                if (DGV_ALLDATA.Rows[i].Cells[18].Value.ToInt() == 1)
                {
                    PRICE_CONV = 100000;
                    DGV_ALLDATA.Rows[i].Cells[27].Value = PRICE_CONV.ToString();
                }
                else
                {
                    PRICE_CONV = 0;
                    DGV_ALLDATA.Rows[i].Cells[27].Value = PRICE_CONV.ToString();
                }
            }

            // is the foreach condition true? Remember my gridview isn't bound to any tbl
            //foreach (DataGridViewRow row in DGV_ALLDATA.Rows)
            //{
            //    decimal A = (Convert.ToDecimal(row.Cells[10].Value ) * Convert.ToDecimal(row.Cells[11].Value ))/100;  // value is null why??
            //    row.Cells[25].Value = A;
            //    decimal B = (Convert.ToDecimal(row.Cells[10].Value ) * Convert.ToDecimal(row.Cells[12].Value )) / 100;  // value is null why??
            //    row.Cells[26].Value = B;
            //    if (row.Cells[18].Value.ToInt()==1)
            //    {
            //        PRICE_CONV = 100000;
            //        row.Cells[27].Value = PRICE_CONV.ToString();
            //    }
            //    else
            //    {
            //        PRICE_CONV = 0;
            //        row.Cells[27].Value = PRICE_CONV.ToString();
            //    }
            //}
        }
    }
}
