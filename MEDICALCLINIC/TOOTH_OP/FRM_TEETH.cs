using MEDICALCLINIC.HOSPITAL.PRINT;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.TOOTH_OP
{

    public partial class FRM_TEETH : MEDICALCLINIC.SETTING.baseclinicanddental

    {
        int cost_center_code;
        int BookId, F_PAY = -1;
        Decimal DR_OPPERCENT;
        byte[] imge1, imge2, imge3, imge4;
        private System.Windows.Forms.ImageList imageList1;
        string V_SIDE = "", H_SIDE = "", COLOR_T = "";

        public static DataTable DTT = new DataTable();
        public static int impotant_val = -1;
        public int panel_cek = 0;
        public int myuc = 0;
        public int CHK_DRAG = -1;
        //List<string> tooth;
        List<string> toothToGDR;
        List<string> PayList;
        List<string> ListMain;
        public FRM_TEETH()
        {
            InitializeComponent();
            imageList1 = new ImageList();
            ListMain = new List<string>();

        }

        private void FRM_TEETH_Load(object sender, EventArgs e)
        {
            try
            {
                var workingArea = Screen.FromHandle(Handle).WorkingArea;
                MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
                WindowState = FormWindowState.Maximized;
                this.v_GET_ALL_CASE_IS_COMPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.V_GET_ALL_CASE_IS_COMP);
                 this.v_GET_ALL_CASE_IS_COMPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.V_GET_ALL_CASE_IS_COMP);
                var row = dt.NewRow();
                dt.Rows.Add(row);
                DGV_ALL_Tooth.DataSource = dt;


                this.v_GET_A_RAY_NAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.V_GET_A_RAY_NAME);
                this.v_GET_A_ROOMRAYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.V_GET_A_ROOMRAY);
                this.v_GET_A_L_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.V_GET_A_L_CATEG);
                this.v_L_GET_A_LABNAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.V_L_GET_A_LABNAME);

                DGV_ALL_Tooth.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGV_ALL_Tooth.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGV_ALL_Tooth.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                DGV_ALL_Tooth.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                nAME_CATEGComboBox.SelectedValue = -1;
                nAME_LABComboBox.SelectedValue = -1;
                cLASS_NAMEComboBox1.SelectedIndex = -1;
                tREATMENT_NAMEComboBox1.SelectedIndex = -1;

                toothToGDR = new List<string>();
                PayList = new List<string>();
                this.p_GET_BOOK_TOTOTH_NAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.P_GET_BOOK_TOTOTH_NAME, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System.DateTime.Now, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                this.v_A_PERSONTableAdapter1.Fill(this.mEDICAL_CLINIC_DBDataSet1.V_A_PERSON);
                this.v_GET_A_TREATMENTTableAdapter1.Fill(this.mEDICAL_CLINIC_DBDataSet1.V_GET_A_TREATMENT);
                this.v_GET_A_CLASSTableAdapter1.Fill(this.mEDICAL_CLINIC_DBDataSet1.V_GET_A_CLASS);
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                dt1 = this.mEDICAL_CLINIC_DBDataSet1.P_GET_BOOK_TOTOTH_NAME;
                AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    datasource.Add(dt1.Rows[i][1].ToString());
                }

                ///////////////////////////////
                dt2 = this.mEDICAL_CLINIC_DBDataSet1.V_GET_A_TREATMENT;
                AutoCompleteStringCollection datasource2 = new AutoCompleteStringCollection();
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    datasource2.Add(dt2.Rows[i][1].ToString());
                }
                this.tREATMENT_NAMEComboBox1.AutoCompleteCustomSource = datasource2;
                this.tREATMENT_NAMEComboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.tREATMENT_NAMEComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ///////////////////////////////
                dt3 = this.mEDICAL_CLINIC_DBDataSet1.V_GET_A_CLASS;
                AutoCompleteStringCollection datasource3 = new AutoCompleteStringCollection();
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    datasource3.Add(dt3.Rows[i][1].ToString());
                }
                this.cLASS_NAMEComboBox1.AutoCompleteCustomSource = datasource3;
                this.cLASS_NAMEComboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.cLASS_NAMEComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                //pERSON_NAMEComboBox1.SelectedIndex = -1;
                lblbookcode.Text = "";
                aGELabel2.Text = "";
                sEX_NAMELabel2.Text = "";
                pICTURE_PERSONPictureBox1.Image = null;
                panel_cek = 0;
                //   pICTURE_PERSONPictureBox.Image = null;
                this.gET_REGION_BODY_CODENAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_REGION_BODY_CODENAME, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
                this.gET_RAY_NAME_CODENAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_RAY_NAME_CODENAME, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                setParentPic();
                // ResetLblColor();




                if (Properties.Settings.Default.COST_CENTER_TYPE == 0)
                {
                    cost_center_code = 110001;
                }
                else
                {
                    cost_center_code = CLS.Cost_Center_WARD_DR;
                }
                //label8.Text = cost_center_code.ToString();
            }

            catch (Exception EX)
            {
                //  MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
            //  circlable3.BackColor = System.Drawing.Color.Transparent;
        }


        DataTable dt = new DataTable();
        private void button5_Click(object sender, EventArgs e)
        {
            var row = dt.NewRow();
            dt.Rows.Add(row);
            DGV_ALL_Tooth.DataSource = dt;


            TXT_NOTE.Clear();
            textBoxX1.Clear();
            // Cealr_UCFilling();

            panel14.Controls.Clear();
            ResetLblColor();
            ResetMainButtonColor();
            CLS.DiagnosisName.Clear();
            CLS.Treat1.Clear();
            CLS.Treat2.Clear();
            CLS.Treat3.Clear();
            toothToGDR.Clear();
            //try
            //{
            //    if (LBL_NAMEPERSON.Text == "")
            //    {
            //        MessageBox.Show("رجاءا حدد أسم المريض اولا", CLS.TITEL_MESG);
            //        return;
            //    }
            //    if (cLASS_NAMEComboBox1.Text == "")
            //    {
            //        MessageBox.Show("رجاءاحدد الحالة اولا", CLS.TITEL_MESG);
            //        return;
            //    }
            //    if (tREATMENT_NAMEComboBox1.Text == "")
            //    {
            //        MessageBox.Show("رجاءاحدد الحشوة اولا", CLS.TITEL_MESG);
            //        return;
            //    }
            //    if (TOOTHNAMEE.Text == "X")
            //    {
            //        MessageBox.Show("رجاءاحدد السن اولا", CLS.TITEL_MESG);
            //        return;
            //    }

            //    dataGridView3.Rows.Add(TOOTHNAMEE.Text, cLASS_NAMEComboBox1.Text, tREATMENT_NAMEComboBox1.Text, pRICE_TREATMENTTextBox.Text, lblbookcode.Text, TXT_NOTE.Text);
            //    LBL_TOTAL_PRICE.Text = dataGridView3.Rows.Cast<DataGridViewRow>()
            //         .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString("#,##0.00");
            //    TOOTHNAMEE.Text = "X";
            //    // pERSON_NAMEComboBox.SelectedValue = -1;
            //    cLASS_NAMEComboBox1.SelectedValue = -1;
            //    tREATMENT_NAMEComboBox1.SelectedValue = -1;
            //    ResetLblColor();
            //    TXT_NOTE.Clear();
            //    toothToGDR.Clear();
            //    //for (int i = 0; i < toothToGDR.Count; i++)
            //    //{
            //    //    //Button btn = (Button)this.Controls.Find(toothToGDR[i].ToString(),true);
            //    //    //btn.Name = toothToGDR[i].ToString();
            //    //    //btn.ForeColor = Color.Red;
            //    //   string thname = toothToGDR[i].ToString();
            //    //    Button btn = this.Controls.Find(thname, true).FirstOrDefault() as Button;
            //    //    btn.Name = thname;
            //    //    btn.BackColor = Color.Transparent;
            //    //}

            //    //foreach (Control c in this.Controls)
            //    //{
            //    //    pictureBox1 btn = c as pictureBox1;
            //    //    if (btn != null) // if c is another type, btn will be null
            //    //    {
            //    //        for (int i = 0; i < toothToGDR.Count; i++)
            //    //        {
            //    //            if (btn.Text.Equals(toothToGDR[i]))
            //    //            {
            //    //                btn.BackColor = Color.Transparent;
            //    //            }

            //    //        }
            //    //    }
            //    //}




            //}
            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message);
            //}

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        UC_U78 UCU78 = new UC_U78();
        UC_L78 UCL78 = new UC_L78();
        UC_UL45 UCUL45 = new UC_UL45();
        UC_UL123 UCUL123 = new UC_UL123();
        private void UL8_Click(object sender, EventArgs e)
        {
            try
            {
                //if (myuc==100)
                //{
                //    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount-1].Cells[0].Value += ((Control)sender).Name;
                //    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[1].Value += CLS.DiagnosisName;

                //}

                //foreach (var x in tooth)
                //{
                //    var controls = pictureBox1.Controls.Find(x, false);
                //    if (controls.Length > 0)
                //        controls[0].BackColor = Color.Transparent;
                //}
                //tooth.Clear();

                if (toothToGDR.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.Transparent;
                    //tooth.Remove(((Control)sender).Name);
                    toothToGDR.Remove(((Control)sender).Name);

                    string mytooth = string.Join(" - ", toothToGDR);
                    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[1].Value = mytooth.Replace(System.Environment.NewLine, " - ");
                    // DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[2].Value = string.Join(" - ", CLS.DiagnosisName);
                    //DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);
                    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[4].Value = string.Join(" - ", CLS.Treat2);
                    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[5].Value = string.Join(" - ", CLS.Treat3);
                    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[8].Value = TXT_NOTE.Text;
                    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[6].Value = textBoxX1.Text;

                }
                else
                {
                    // tooth.Add(((Control)sender).Name);
                    toothToGDR.Add(((Control)sender).Name);

                    //TOOTHNAMEE.Text = ((Control)sender).Name;
                    //TOOTHNAMEE.Text = string.Join(",", toothToGDR); ;
                    ((Control)sender).BackColor = Color.Black;


                    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[1].Value = string.Join("\n", toothToGDR);
                    //DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[2].Value = string.Join(" - ", CLS.DiagnosisName);
                    //DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);
                    //DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[4].Value = string.Join(" - ", CLS.Treat2);
                    //DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[5].Value = string.Join(" - ", CLS.Treat3);
                    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[8].Value = TXT_NOTE.Text;
                    DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[6].Value = textBoxX1.Text;
                }
                if (CLS.MainListTooth.Count > 0)
                {
                    if (CLS.MainListTooth.First() == "btn_RCT")
                    {

                        USERCONTROL.UC_RCT uC_RCT = new USERCONTROL.UC_RCT();
                        if (((Control)sender).Name == "UL1" || ((Control)sender).Name == "UL2" || ((Control)sender).Name == "UL3" ||
                            ((Control)sender).Name == "UR1" || ((Control)sender).Name == "UR2" || ((Control)sender).Name == "UR3" ||
                            ((Control)sender).Name == "LR1" || ((Control)sender).Name == "LR2" || ((Control)sender).Name == "LR3" || ((Control)sender).Name == "LL4" || ((Control)sender).Name == "LL5"||
                            ((Control)sender).Name == "LL1" || ((Control)sender).Name == "LL2" || ((Control)sender).Name == "LL3" || ((Control)sender).Name == "LL4" || ((Control)sender).Name == "LL5")
                        {
                            panel14.Controls.Add(uC_RCT);
                            uC_RCT.Dock = DockStyle.Fill;
                            uC_RCT.BringToFront();
                            uC_RCT.chSCanal.Enabled = true;
                           
                        }
                        
                        if (((Control)sender).Name == "UL4" || ((Control)sender).Name == "UL5" || ((Control)sender).Name == "UL6" ||  ((Control)sender).Name == "UL7" || ((Control)sender).Name == "UL8" ||
                            ((Control)sender).Name == "UR4" || ((Control)sender).Name == "UR5" || ((Control)sender).Name == "UR6" || ((Control)sender).Name == "UR7" || ((Control)sender).Name == "UR8" ||
                            ((Control)sender).Name == "LR6" || ((Control)sender).Name == "LR7" ||
                            ((Control)sender).Name == "LL6" || ((Control)sender).Name == "LL7"  )
                        {
                            panel14.Controls.Add(uC_RCT);
                            uC_RCT.Dock = DockStyle.Fill;
                            uC_RCT.BringToFront();
                            uC_RCT.chPCanal.Enabled = true;

                        }

                        if ( 
                           ((Control)sender).Name == "UR6" || ((Control)sender).Name == "UR7" || ((Control)sender).Name == "UL6" || ((Control)sender).Name == "UL7" ||
                           ((Control)sender).Name == "LR6" || ((Control)sender).Name == "LR7"  || ((Control)sender).Name == "LL6" || ((Control)sender).Name == "LL7")
                           
                        {
                            panel14.Controls.Add(uC_RCT);
                            uC_RCT.Dock = DockStyle.Fill;
                            uC_RCT.BringToFront();
                            uC_RCT.chDBCanal.Enabled = true;

                        }
                        if (
                            ((Control)sender).Name == "LR6" || ((Control)sender).Name == "LR7" || ((Control)sender).Name == "LL6" || ((Control)sender).Name == "LL7")

                        {
                            panel14.Controls.Add(uC_RCT);
                            uC_RCT.Dock = DockStyle.Fill;
                            uC_RCT.BringToFront();
                            uC_RCT.chMLCanal.Enabled = true;
                            uC_RCT.chDLCanal.Enabled = true;

                        }
                          if( ((Control)sender).Name == "LR6" || ((Control)sender).Name == "LR7" || ((Control)sender).Name == "LL6" || ((Control)sender).Name == "LL7"||
                              ((Control)sender).Name == "UR6" || ((Control)sender).Name == "UR7" || ((Control)sender).Name == "UL6" || ((Control)sender).Name == "UL7")

                          {
                            panel14.Controls.Add(uC_RCT);
                            uC_RCT.Dock = DockStyle.Fill;
                            uC_RCT.BringToFront();
                            uC_RCT.chMBCanal.Enabled = true;
                            uC_RCT.chDBCanal.Enabled = true;

                        }
                        if (((Control)sender).Name == "LL8" || ((Control)sender).Name == "LR8" || ((Control)sender).Name == "UL8" || ((Control)sender).Name == "UR8" || ((Control)sender).Name == "LL7" || ((Control)sender).Name == "LR7" || ((Control)sender).Name == "UL7" || ((Control)sender).Name == "UR7")
                        {
                            panel14.Controls.Add(uC_RCT);
                            uC_RCT.Dock = DockStyle.Fill;
                            uC_RCT.BringToFront();
                            uC_RCT.chDLCanal.Enabled = true;
                            uC_RCT.chDBCanal.Enabled = true;
                            uC_RCT.chMBCanal.Enabled = true;
                            uC_RCT.chMLCanal.Enabled = true;

                            uC_RCT.wlchDLCanal.Enabled = true;
                            uC_RCT.wlchDBCanal.Enabled = true;
                            uC_RCT.wlchMBCanal.Enabled = true;
                            uC_RCT.wlchMLCanal.Enabled = true;

                            uC_RCT.MchDLCanal.Enabled = true;
                            uC_RCT.MchDBCanal.Enabled = true;
                            uC_RCT.MchMBCanal.Enabled = true;
                            uC_RCT.MchMLCanal.Enabled = true;
                        }
                        else
                        if (((Control)sender).Name == "LL4" || ((Control)sender).Name == "LL3" || ((Control)sender).Name == "LL2" || ((Control)sender).Name == "LL1" || ((Control)sender).Name == "LR4" || ((Control)sender).Name == "LR3" || ((Control)sender).Name == "LR2" || ((Control)sender).Name == "LR1" || ((Control)sender).Name == "UL4" || ((Control)sender).Name == "UL3" || ((Control)sender).Name == "UL2" || ((Control)sender).Name == "UL1" || ((Control)sender).Name == "UR4" || ((Control)sender).Name == "UR3" || ((Control)sender).Name == "UR2" || ((Control)sender).Name == "UR1")
                        {
                            panel14.Controls.Add(uC_RCT);
                            uC_RCT.Dock = DockStyle.Fill;
                            uC_RCT.BringToFront();
                            uC_RCT.chSCanal.Enabled = true;
                            uC_RCT.wlscanal.Enabled = true;
                            uC_RCT.MchSCanal.Enabled = true;
                        }
                    }

                }

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void UR8_MouseHover(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Color.Black)
            {
                ((Control)sender).BackColor = Color.Transparent;
            }
        }

        private void UR8_MouseMove(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Color.Black)
            {
                ((Control)sender).BackColor = Color.Transparent;
            }
        }



        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            try
            {
                if (LBL_NAMEPERSON.Text == "..........")
                {
                    MessageBox.Show("فضلا قم بأختيار مريض اولا");
                    return;
                }
                if (F_PAY == -1)
                {
                    MessageBox.Show("فضلا قم بأختيار نوع الدفع اولا");
                    return;
                }


                Cursor.Current = Cursors.WaitCursor;

                //if (pERSON_NAMEComboBox1 .SelectedIndex  ==-1)
                //{

                //    errorProvider1.SetError(pERSON_NAMEComboBox1, CLS.TXT_NULL);
                //}
                if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
                {
                    MessageBox.Show("حدد الطابعة أولا");
                    SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                    FRM.ShowDialog();
                    return;
                }

                CLS.ID_BOOK_PRINT = Convert.ToInt32(lblbookcode.Text);

                BTN_SAVE_Click(null, null);
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                this.p_PRINT_TOOOTH_BOOKINGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.P_PRINT_TOOOTH_BOOKING, new System.Nullable<int>(((int)(System.Convert.ChangeType(lblbookcode.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                dt = this.mEDICAL_CLINIC_DBDataSet1.P_PRINT_TOOOTH_BOOKING;
                this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
                dt1 = this.mEDICAL_CLINIC_DBDataSet1.GET_RPT_IMAGEE;
                LocalReport lr = new LocalReport();
                lr.ReportEmbeddedResource = "MEDICALCLINIC.PRINT.TOOTHPRINT.RPT_DENTAL_BOOKING.rdlc";
                lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));

                lr.Print();
                //PRINT.FRM_TOOTH_PRINT myfrrm = new PRINT.FRM_TOOTH_PRINT();
                //PRINT.TOOTHPRINT.TOOTH_BOOKING_PRINT mmprt = new PRINT.TOOTHPRINT.TOOTH_BOOKING_PRINT();
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

                //mmprt.SetParameterValue("@ID_BOOK", Convert.ToInt32(CLS.ID_BOOK_PRINT));
                //mmprt.SetParameterValue("@DOCT_CODE", CLS.USER_CODE);
                //mmprt.PrintOptions.PrinterName = Properties.Settings.Default.PRINTER_NAME;
                //myfrrm.crystalReportViewer1.ReportSource = mmprt;

                //mmprt.PrintToPrinter(1, false, 0, 0);
                Cursor.Current = Cursors.Default;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {



                if (LBL_NAMEPERSON.Text == "..........")
                {
                    MessageBox.Show("فضلا قم بأختيار مريض اولا");
                    return;
                }
                if (Convert.ToDecimal(LBL_TOTAL_PRICE.Text) > 0)
                {
                    if (F_PAY == -1)
                    {
                        MessageBox.Show("فضلا قم بأختيار نوع الدفع اولا");
                        return;
                    }
                }


                this.gET_CLIENT_PRECTENAGE_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_CLIENT_PRECTENAGE_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                decimal GET_PRECNTEGAE = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet1.GET_CLIENT_PRECTENAGE_DOCTOR.Rows[0][2]);

                var INSERTED_TOOTH = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var UPDATE_DRAG = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERT_BOX = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var UPDATE_DSAISE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var UPD = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                for (int i = 0; i < DGV_ALL_Tooth.Rows.Count; i++)
                {
                    INSERTED_TOOTH.P_INSERT_T_TOOTH_BOOKING_(

                        Convert.ToInt32(lblbookcode.Text)
                        , DGV_ALL_Tooth.Rows[i].Cells[1].Value.ToString()
                        , DGV_ALL_Tooth.Rows[i].Cells[2].Value.ToString()
                        , DGV_ALL_Tooth.Rows[i].Cells[3].Value.ToString()
                        , DGV_ALL_Tooth.Rows[i].Cells[4].Value.ToString()
                        , DGV_ALL_Tooth.Rows[i].Cells[5].Value.ToString()
                        , ""
                        , Convert.ToDecimal(DGV_ALL_Tooth.Rows[i].Cells[6].Value)
                        , DGV_ALL_Tooth.Rows[i].Cells[5].Value.ToString()
                        , ref CLS.SUBMIT_FLAG);

                    // TOTAL_PRICE = (Convert.ToDecimal(dataGridView3.Rows[i].Cells[3].Value) + Convert.ToDecimal(TOTAL_PRICE));

                }

                LBL_TOTAL_PRICE.Text = DGV_ALL_Tooth.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                //  TOTAL_PRICE = Convert.ToDecimal(LBL_TOTAL_PRICE.Text);
                var UPDATE_OPE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                UPDATE_OPE.P_UPDATE_T_BOOKING_OPERTIONS(Convert.ToInt32(lblbookcode.Text),
                    Convert.ToInt32(lblpersoncode.Text),
                    LBL_TOTAL_PRICE.Text,
                    false,
                    nAME_IS_COMPComboBox.SelectedValue.ToInt(),
                    ref CLS.SUBMIT_FLAG);
                var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                this.gET_DOCTOR_BY_USERCODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_DOCTOR_BY_USERCODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                DR_OPPERCENT = Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet1.GET_DOCTOR_BY_USERCODE.Rows[0][10].ToString());

                this.gET_H_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_H_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(20, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                LBL_PAST_DEBIT.Text = this.mEDICAL_CLINIC_DBDataSet1.GET_H_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();




                if (LBL_TOTAL_PRICE.Text.ToDecimal() > 0)
                {
                    Decimal DoctorPrecentage = DR_OPPERCENT;
                    decimal TOTAL_PRICE = Convert.ToDecimal(LBL_TOTAL_PRICE.Text);
                    decimal DebitPatient = 0;
                    decimal CreditService = 0;
                    decimal CreditDoctor = 0;
                    var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();



                    if (DR_OPPERCENT > 0)
                    {



                        DebitPatient = TOTAL_PRICE;
                        CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                        CreditService = TOTAL_PRICE - CreditDoctor;



                        BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                    Convert.ToInt32(lblbookcode.Text)
                                  , System.DateTime.Now
                                  , "عن اجور حشوات وعمليات الاسنان "
                                  , 19
                                  , 0
                                  , true
                                  , CLS.USER_CODE
                                  , ref CLS.SUBMIT_FLAG
                                  , CLS.BRANCH_ID
                                  , cost_center_code
                                  ).ToString());

                        if (F_PAY == 1)
                        {
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                            (
                                             BookId
                                            , 111
                                            , " اجور  عملية"
                                            , 0
                                            , 0
                                            , DebitPatient
                                            , 0
                                            , "من حساب الزبون الى حساب الصندوق"
                                            , 1
                                            , 1
                                            , ref CLS.SUBMIT_FLAG
                                             );

                            //TO

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , Convert.ToInt32(lblpersoncode.Text)
                             , " اجور  عملية"
                            , 0
                            , 0
                            , 0
                            , DebitPatient
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                             (
                               BookId
                             , Convert.ToInt32(lblpersoncode.Text)
                              , " اجور  عملية"
                             , 0
                             , 0
                             , DebitPatient
                             , 0
                             , "من حساب الزبون الى حساب الصندوق"
                             , 1
                             , 1
                             , ref CLS.SUBMIT_FLAG
                              );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                          (
                            BookId
                          , Convert.ToInt32(CLS.USER_CODE)
                           , " اجور  عملية"
                          , 0
                          , 0
                          , 0
                          , CreditDoctor
                          , "من حساب الزبون الى حساب الدكتور"
                          , 1
                          , 1
                          , ref CLS.SUBMIT_FLAG
                           );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                           (
                             BookId
                           , 4005
                           , " اجور  عملية"
                           , 0
                           , 0
                           , 0
                           , CreditService
                           , "من حساب الزبون الى حساب العمليات"
                           , 1
                           , 1
                           , ref CLS.SUBMIT_FLAG
                            );











                        }
                        if (F_PAY == 2)
                        {
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                            (
                                             BookId
                                            , Convert.ToInt32(lblpersoncode.Text)
                                            , " اجور  عملية"
                                            , 0
                                            , 0
                                            , DebitPatient
                                            , 0
                                            , "من حساب الزبون الى حساب الصندوق"
                                            , 1
                                            , 1
                                            , ref CLS.SUBMIT_FLAG
                                             );

                            //TO

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , 4005
                             , " اجور  عملية"
                            , 0
                            , 0
                            , 0
                            , CreditService
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                       (
                         BookId
                       , Convert.ToInt32(CLS.USER_CODE)
                        , " اجور  عملية"
                       , 0
                       , 0
                       , 0
                       , CreditDoctor
                       , "من حساب الزبون الى حساب الدكتور"
                       , 1
                       , 1
                       , ref CLS.SUBMIT_FLAG
                        );
                        }
                        if (F_PAY == 3)
                        {
                            //جزء النقدي من الجزئي
                            DoctorPrecentage = DR_OPPERCENT;
                            TOTAL_PRICE = Convert.ToDecimal(LBL_PAID.Text);
                            DebitPatient = 0;
                            CreditService = 0;
                            CreditDoctor = 0;

                            DebitPatient = TOTAL_PRICE;
                            CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                            CreditService = TOTAL_PRICE - CreditDoctor;

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                            (
                                             BookId
                                            , 111
                                            , " اجور  عملية"
                                            , 0
                                            , 0
                                            , DebitPatient
                                            , 0
                                            , "من حساب الزبون الى حساب الصندوق"
                                            , 1
                                            , 1
                                            , ref CLS.SUBMIT_FLAG
                                             );

                            //TO

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , Convert.ToInt32(lblpersoncode.Text)
                             , " اجور  عملية"
                            , 0
                            , 0
                            , 0
                            , DebitPatient
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                             (
                               BookId
                             , Convert.ToInt32(lblpersoncode.Text)
                              , " اجور  عملية"
                             , 0
                             , 0
                             , DebitPatient
                             , 0
                             , "من حساب الزبون الى حساب الصندوق"
                             , 1
                             , 1
                             , ref CLS.SUBMIT_FLAG
                              );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                          (
                            BookId
                          , Convert.ToInt32(CLS.USER_CODE)
                           , " اجور  عملية"
                          , 0
                          , 0
                          , 0
                          , CreditDoctor
                          , "من حساب الزبون الى حساب الدكتور"
                          , 1
                          , 1
                          , ref CLS.SUBMIT_FLAG
                           );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                           (
                             BookId
                           , 4005
                           , " اجور  عملية"
                           , 0
                           , 0
                           , 0
                           , CreditService
                           , "من حساب الزبون الى حساب العمليات"
                           , 1
                           , 1
                           , ref CLS.SUBMIT_FLAG
                            );


                            //الجزء الاجل من الجزئي


                            DoctorPrecentage = DR_OPPERCENT;
                            TOTAL_PRICE = Convert.ToDecimal(LBL_REMAIN.Text);
                            DebitPatient = 0;
                            CreditService = 0;
                            CreditDoctor = 0;

                            DebitPatient = TOTAL_PRICE;
                            CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                            CreditService = TOTAL_PRICE - CreditDoctor;

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                            (
                                             BookId
                                            , Convert.ToInt32(lblpersoncode.Text)
                                            , " اجور  عملية"
                                            , 0
                                            , 0
                                            , DebitPatient
                                            , 0
                                            , "من حساب الزبون الى حساب الصندوق"
                                            , 1
                                            , 1
                                            , ref CLS.SUBMIT_FLAG
                                             );

                            //TO




                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                          (
                            BookId
                          , Convert.ToInt32(CLS.USER_CODE)
                           , " اجور  عملية"
                          , 0
                          , 0
                          , 0
                          , CreditDoctor
                          , "من حساب الزبون الى حساب الدكتور"
                          , 1
                          , 1
                          , ref CLS.SUBMIT_FLAG
                           );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                           (
                             BookId
                           , 4005
                           , " اجور  عملية"
                           , 0
                           , 0
                           , 0
                           , CreditService
                           , "من حساب الزبون الى حساب العمليات"
                           , 1
                           , 1
                           , ref CLS.SUBMIT_FLAG
                            );







                        }
                    }

                    else

                    if (DR_OPPERCENT == 0)
                    {



                        BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                    Convert.ToInt32(lblbookcode.Text)
                                  , System.DateTime.Now
                                  , "عن اجور حشوات وعمليات الاسنان "
                                  , 19
                                  , 0
                                  , true
                                  , CLS.USER_CODE
                                  , ref CLS.SUBMIT_FLAG
                                  , CLS.BRANCH_ID
                                  , cost_center_code
                                  ).ToString());

                        if (F_PAY == 1)
                        {
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                            (
                                             BookId
                                            , 111
                                            , " اجور  عملية"
                                            , 0
                                            , 0
                                            , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                                            , 0
                                            , "من حساب الزبون الى حساب الصندوق"
                                            , 1
                                            , 1
                                            , ref CLS.SUBMIT_FLAG
                                             );

                            //TO

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , Convert.ToInt32(lblpersoncode.Text)
                             , " اجور  عملية"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                             (
                               BookId
                             , Convert.ToInt32(lblpersoncode.Text)
                              , " اجور  عملية"
                             , 0
                             , 0
                             , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                             , 0
                             , "من حساب الزبون الى حساب الصندوق"
                             , 1
                             , 1
                             , ref CLS.SUBMIT_FLAG
                              );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                          (
                            BookId
                          , Convert.ToInt32(CLS.USER_CODE)
                           , " اجور  عملية"
                          , 0
                          , 0
                          , 0
                          , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                          , "من حساب الزبون الى حساب الدكتور"
                          , 1
                          , 1
                          , ref CLS.SUBMIT_FLAG
                           );












                        }
                        if (F_PAY == 2)
                        {
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                            (
                                             BookId
                                            , Convert.ToInt32(lblpersoncode.Text)
                                            , " اجور  عملية"
                                            , 0
                                            , 0
                                            , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                                            , 0
                                            , "من حساب الزبون الى حساب الصندوق"
                                            , 1
                                            , 1
                                            , ref CLS.SUBMIT_FLAG
                                             );

                            //TO

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                       (
                         BookId
                       , Convert.ToInt32(CLS.USER_CODE)
                        , " اجور  عملية"
                       , 0
                       , 0
                       , 0
                       , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                       , "من حساب الزبون الى حساب الدكتور"
                       , 1
                       , 1
                       , ref CLS.SUBMIT_FLAG
                        );
                        }


                        if (F_PAY == 3)
                        {



                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                             (
                               BookId
                             , Convert.ToInt32(lblpersoncode.Text)
                              , " اجور  عملية"
                             , 0
                             , 0
                             , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                             , 0
                             , "من حساب الزبون الى حساب الصندوق"
                             , 1
                             , 1
                             , ref CLS.SUBMIT_FLAG
                              );

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                          (
                            BookId
                          , Convert.ToInt32(CLS.USER_CODE)
                           , " اجور  عملية"
                          , 0
                          , 0
                          , 0
                          , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                          , "من حساب الزبون الى حساب الدكتور"
                          , 1
                          , 1
                          , ref CLS.SUBMIT_FLAG
                           );





                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                           (
                                            BookId
                                           , 111
                                           , " اجور  عملية"
                                           , 0
                                           , 0
                                           , Convert.ToDecimal(LBL_PAID.Text)
                                           , 0
                                           , "من حساب الزبون الى حساب الصندوق"
                                           , 1
                                           , 1
                                           , ref CLS.SUBMIT_FLAG
                                            );

                            //TO

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , Convert.ToInt32(lblpersoncode.Text)
                             , " اجور  عملية"
                            , 0
                            , 0
                            , 0
                            , Convert.ToDecimal(LBL_PAID.Text)
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );






                        }
                    }
                }





                UPDATE_DRAG.P_UDATE_T_BOOKING_DRAGE(Convert.ToInt32(lblbookcode.Text), CLS.USER_CODE, DRAGE_NAME_ARTextBoxX.Text);
                //  UPDATE_DSAISE.P_UPDATE_T_DISEAS(Convert.ToInt32(bOOKING_CODELabel1.Text), DRAGE_NAME_ARTextBoxX.Text, ref CLS.SUBMIT_FLAG);
                UPD.P_UDATE_T_BOOKING_T_PERSON(Convert.ToInt32(lblbookcode.Text), CLS.USER_CODE, true, true);
                var UPD_ADV = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                UPD_ADV.P_UDATE_T_BOOKING_T_ADS(Convert.ToInt32(lblbookcode.Text), true);



                cLASS_NAMEComboBox1.SelectedIndex = -1;
                tREATMENT_NAMEComboBox1.SelectedIndex = -1;
                TOOTHNAMEE.Text = "X";
                DRAGE_NAME_ARTextBoxX.Clear();
                DGV_ALL_Tooth.Rows.Clear();
                LBL_NAMEPERSON.Text = "..........";
                //aGELabel2.Text = "..........";
                sEX_NAMELabel2.Text = "..........";

                LBL_TOTAL_PRICE.Text = "0.00";
                toothToGDR.Clear();
                lblpersoncode.Text = "00";
                //lblbookcode.Text = "00";
                this.p_GET_BOOK_TOTOTH_NAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.P_GET_BOOK_TOTOTH_NAME, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System.DateTime.Now, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                MSG.Msg.Alart(AlartType.Save);
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DIAGNOSES.UC_TOOTH_BOOK_NO_DETAILS us_new = new DIAGNOSES.UC_TOOTH_BOOK_NO_DETAILS(lblpersoncode.Text.ToInt());
            try
            {
                if (lblpersoncode.Text == "00")
                {
                    MessageBox.Show("قم بأختيار المريض فضلا");
                    return;
                }
                else
                {

                    if (panel_cek == 1)
                    {

                        //panel15.Controls.Remove(us_new);
                        panel_cek = 0;
                        button2.Text = "Prev.Booking";
                        foreach (Control c in panel15.Controls)
                        {
                            if (c.Name == "UC_TOOTH_BOOK_NO_DETAILS")
                            {
                                panel15.Controls.Remove(c);
                                c.Dispose();
                                break;
                            }
                        }
                    }
                    else
                    {
                        us_new = new DIAGNOSES.UC_TOOTH_BOOK_NO_DETAILS(Convert.ToInt32(lblpersoncode.Text));
                        impotant_val = Convert.ToInt32(lblpersoncode.Text);
                        panel15.Controls.Add(us_new);
                        // us_new.Location = new Point(3, 371);
                        us_new.Dock = DockStyle.Fill;
                        us_new.BringToFront();
                        panel_cek = 1;
                        button2.Text = "All Booking";
                    }

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_MONEY_Click(object sender, EventArgs e)
        {
            if (LBL_NAMEPERSON.Text == "..........")
            {
                MessageBox.Show("فضلا قم بأختيار مريض اولا");
                return;
            }
            else
            {
                CLS.ID_BOOKING_IMG = Convert.ToInt32(lblbookcode.Text);
                CLS.ID_PERSON_IMG = Convert.ToInt32(lblpersoncode.Text);
                CLS.PERSON_NAME_IMGE = LBL_NAMEPERSON.Text;
                OPERATION_PP.FRM_ALL_OPERTION_PRICE FRM = new OPERATION_PP.FRM_ALL_OPERTION_PRICE();
                FRM.ShowDialog();
            }
        }

        private void BTN_XRAY_Click(object sender, EventArgs e)
        {
            if (LBL_NAMEPERSON.Text == "..........")
            {
                MessageBox.Show("رجاءا حدد المريض اولا", CLS.TITEL_MESG);
                return;
            }
            else
            {

                CLS.PERSON_NAME_IMGE = LBL_NAMEPERSON.Text;
                CLS.CODE_PER_IMG = Convert.ToInt32(lblpersoncode.Text);
                CLS.CODE_BOOK_IMG = Convert.ToInt32(lblbookcode.Text);

                TOOTH_OP.FRM_X_RAY FRM = new TOOTH_OP.FRM_X_RAY();
                FRM.ShowDialog();
            }



        }



        private void label8_Click(object sender, EventArgs e)
        {
            OPERATION_PP.FRM_BOOK_TOOTH FRM = new OPERATION_PP.FRM_BOOK_TOOTH();
            FRM.ShowDialog();
        }

        private void BTN_ADD_CANAL_Click(object sender, EventArgs e)
        {
            try
            {
                if (LBL_NAMEPERSON.Text == "..........")
                {
                    MessageBox.Show("رجاءا حدد أسم المريض اولا", CLS.TITEL_MESG);
                    return;
                }
                //if (cLASS_NAMEComboBox1.Text == "")
                //{
                //    MessageBox.Show("رجاءا حدد الحالة اولا", CLS.TITEL_MESG);
                //    return;
                //}
                //if (tREATMENT_NAMEComboBox1.Text == "")
                //{
                //    MessageBox.Show("رجاءا حدد الحشوة اولا", CLS.TITEL_MESG);
                //    return;
                //}
                if (TOOTHNAMEE.Text == "X")
                {
                    MessageBox.Show("رجاءا حدد السن اولا", CLS.TITEL_MESG);
                    return;
                }

                if (CLS.CANAL_UPPER_N == String.Empty || CLS.CANAL_LOWER_N == String.Empty)
                {
                    MessageBox.Show("رجاءا حدد نوع الحشوة الجذرية اولا", CLS.TITEL_MESG);
                    return;
                }
                if (CLS.CANAL_UPPER_S == "" || CLS.CANAL_LOWER_S == "")
                {
                    MessageBox.Show("رجاءا أدخل الحجم اولا", CLS.TITEL_MESG);
                    return;
                }

                DGV_ALL_Tooth.Rows.Add(TOOTHNAMEE.Text, CLS.CANAL_UPPER_N + "-" + CLS.CANAL_UPPER_S, CLS.CANAL_LOWER_N + "-" + CLS.CANAL_LOWER_S, pRICE_TREATMENTTextBox.Text, lblbookcode.Text, TXT_NOTE.Text);
                LBL_TOTAL_PRICE.Text = DGV_ALL_Tooth.Rows.Cast<DataGridViewRow>()
                      .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString("#,##0.00");

                TOOTHNAMEE.Text = "X";
                // pERSON_NAMEComboBox.SelectedValue = -1;
                cLASS_NAMEComboBox1.SelectedValue = -1;
                tREATMENT_NAMEComboBox1.SelectedValue = -1;
                ResetLblColor();
                TXT_NOTE.Clear();
                toothToGDR.Clear();
                CLS.CANAL_UPPER_N = "";
                CLS.CANAL_UPPER_S = "";

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CR_BUTTONS.FRM_TOOTH_DRAG FRM = new CR_BUTTONS.FRM_TOOTH_DRAG();
            FRM.ShowDialog();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    decimal myResult = 0;
                    decimal myRow = 0;

                    DGV_ALL_Tooth.Rows.RemoveAt(DGV_ALL_Tooth.CurrentRow.Index);
                    //LBL_TOTAL_PRICE.Text = DGV_ALL_Tooth.Rows.Cast<DataGridViewRow>()
                    //   .Sum(t => Convert.ToDecimal(t.Cells[6].Value)).ToString();
                    sumtotal();
                }
            }
        }
        void sumtotal()
        {
            Double result = 0;
            foreach (DataGridViewRow row in this.DGV_ALL_Tooth.Rows)
            {

                if (row.Cells[6].Value != null)
                {
                    try
                    {
                        result += Convert.ToDouble(row.Cells[6].Value);
                    }
                    catch { }
                }
            }

            this.LBL_TOTAL_PRICE.Text = result.ToString("N0");
        }
        private void BTN_CONVERT_PERS_Click(object sender, EventArgs e)
        {
            PERSONS.FRM_CONVERT_TO_DOCT FRM = new PERSONS.FRM_CONVERT_TO_DOCT(CLS.USER_CODE.ToInt(), lblpersoncode.Text.ToInt(), lblbookcode.Text.ToInt());
            FRM.ShowDialog();
        }

        private void BTN_MedicalHistory_Click(object sender, EventArgs e)
        {
            if (lblpersoncode.Text == "label1")
            {
                MessageBox.Show("قم بأختيار المريض فضلا");
                return;
            }
            else
            {
                //PERSONS.FRM_MEDICAL_HISTORY frm = new PERSONS.FRM_MEDICAL_HISTORY(Convert.ToInt32(lblpersoncode.Text)); frm.ShowDialog();
                PERSONS.FRM_MEDICAL_HISTORY_PERSON FRM = new PERSONS.FRM_MEDICAL_HISTORY_PERSON(-1); FRM.ShowDialog();

            }
        }

        private void BTN_OPEN_PERSON_Click(object sender, EventArgs e)
        {
            OPERATION_PP.FRM_BOOK_TOOTH FRM = new OPERATION_PP.FRM_BOOK_TOOTH();
            FRM.ShowDialog();
        }




        private void nAME_CATEGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_LAB_TEST_BY_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_LAB_TEST_BY_CATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ADD_GRD_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count; i++)
            {

                DGV_TEST_SENT.Rows.Add(
                gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[0].Value.ToString(),
                gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[1].Value.ToString(),
                gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[5].Value.ToString(),
                "");

            }

            //if (   nAME_CATEGComboBox.SelectedIndex != -1)
            //{
            //    int FoodIndex = -1;

            //    for (int i = 0; i < DGV_TEST_SENT.Rows.Count; i++)
            //    {
            //        if (nAME_TESTComboBox.SelectedText.ToString().Equals(DGV_TEST_SENT.Rows[i].Cells[1].Value.ToString()))
            //            FoodIndex = i;

            //    }
            //    if (FoodIndex == -1)
            //    {
            //        DGV_TEST_SENT.Rows.Add(nAME_TESTComboBox.SelectedValue, nAME_TESTComboBox.Text,TXT_NOTEF.Text);
            //        nAME_TESTComboBox.SelectedIndex = -1;
            //    }
            //    else
            //    {
            //        MessageBox.Show("التحليل موجود مسبقا");
            //        return;
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("اختار التحليل اولا ", CLS.TITEL_MESG);
            //    return;
            //}


        }

        private void BTN_SAVESENTTEST_Click(object sender, EventArgs e)
        {
            try
            {

                if (DGV_TEST_SENT.Rows.Count <= 0)
                {
                    MessageBox.Show("يرجى اضافة تحليل اولا", CLS.TITEL_MESG);
                    return;
                }
                if (nAME_LABComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى اضافة تحليل اولا", CLS.TITEL_MESG);
                    return;
                }

                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                // INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);



                int BookId;
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED_D = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                BookId = int.Parse(
                  INSERTED.P_INSERT_L_RESTESTNAME(
                 0
                , CLS.USER_CODE
                , Convert.ToInt32(lblbookcode.Text)
                , System.DateTime.Now
                , Convert.ToDecimal(0.00)
                , Convert.ToInt32(lblpersoncode.Text)
                , false
                , false
                , Convert.ToInt32(nAME_LABComboBox.SelectedValue)
                , ""
                , 0
                , ref CLS.SUBMIT_FLAG).ToString());

                for (int i = 0; i < DGV_TEST_SENT.Rows.Count; i++)
                {
                    INSERTED_D.P_INSERT_L_RESTESTNAME_DETAILS(
                        Convert.ToInt32(DGV_TEST_SENT.Rows[i].Cells[0].Value)
                        , ""
                        , Convert.ToDecimal(DGV_TEST_SENT.Rows[i].Cells[2].Value)
                        , DGV_TEST_SENT.Rows[i].Cells[3].Value.ToString()
                        , false
                        , BookId
                        , ref CLS.SUBMIT_FLAG);
                }


                if (CLS.SUBMIT_FLAG == 1)
                {
                    MessageBox.Show("تمت العملية بنجاح", CLS.TITEL_MESG);
                    DGV_TEST_SENT.Rows.Clear();
                }


            }
            catch
            {

            }
        }



        private void BTN_REFESH_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), System.DateTime.Now);


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void DGV_TEST_SENT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    DGV_TEST_SENT.Rows.RemoveAt(DGV_TEST_SENT.CurrentRow.Index);

                }
            }
        }


        private void BTN_SEARCH_ALL_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_H_ALL_TESTS_FOR_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.P_GET_H_ALL_TESTS_FOR_PERSON, "1", new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATET1.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_ALL_LABTESTPERSON_FOR_DOCTORY, lblpersoncode.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void BTN_SEARCH_TESTNAME_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_H_ALL_TESTS_FOR_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.P_GET_H_ALL_TESTS_FOR_PERSON, "2", new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATET1.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //try
            //{
            //    this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_ALL_LABTESTPERSON_FOR_DOCTORY, lblpersoncode.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_TESTComboBox1.SelectedValue, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show("يرجى تحديد اسم التحليل اولا");
            //}
        }

        private void BTN_SEARCH_DATE_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_ALL_LABTESTPERSON_FOR_DOCTORY, lblpersoncode.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATET1.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }





        private void BTN_C_V_Click(object sender, EventArgs e)
        {
            R_UP.Checked = false;
            R_LOWER.Checked = false;
            V_SIDE = "";
        }

        private void BTN_C_H_Click(object sender, EventArgs e)
        {
            R_LEFT.Checked = false;
            R_RIGHT.Checked = false;
        }



        private void R_UP_CheckedChanged(object sender, EventArgs e)
        {
            V_SIDE = "UPPER";
        }

        private void R_LOWER_CheckedChanged(object sender, EventArgs e)
        {
            V_SIDE = "LOWER";
        }

        private void R_LEFT_CheckedChanged(object sender, EventArgs e)
        {
            H_SIDE = "LEFT";
        }

        private void R_RIGHT_CheckedChanged(object sender, EventArgs e)
        {
            H_SIDE = "RIGHT";
        }

        private void BTN_SEND_Click(object sender, EventArgs e)
        {
            try
            {

                if (DGV_X_SEND.Rows.Count <= 0)
                {
                    MessageBox.Show("يرجى اضافة أشعه اولا", CLS.TITEL_MESG);
                    return;
                }
                if (nAME_RAYComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى اضافة أشعه اولا", CLS.TITEL_MESG);
                    return;
                }

                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                // INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);
                //byte[] imge1;
                //byte[] imge2;
                //byte[] imge3;
                //byte[] imge4;


                //MemoryStream ms1 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms1, Properties.Resources.NOPIC.RawFormat);
                //imge1 = ms1.ToArray();

                //MemoryStream ms2 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms2, Properties.Resources.NOPIC.RawFormat);
                //imge2 = ms2.ToArray();
                //MemoryStream ms3 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms3, Properties.Resources.NOPIC.RawFormat);
                //imge3 = ms3.ToArray();

                //MemoryStream ms4 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms4, Properties.Resources.NOPIC.RawFormat);
                //imge4 = ms4.ToArray();

                int BookId;
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED_D = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                BookId = int.Parse(
                  INSERTED.P_INSERT_T_RESULTRAY(
                 0
                , CLS.USER_CODE
                , Convert.ToInt32(lblbookcode.Text)
                , System.DateTime.Now
                , 0
                , Convert.ToInt32(lblpersoncode.Text)
                , false
                , false
                , Convert.ToInt32(nAME_RAYComboBox.SelectedValue)
                , ref CLS.SUBMIT_FLAG).ToString());

                for (int i = 0; i < DGV_X_SEND.Rows.Count; i++)
                {
                    INSERTED_D.P_INSERT_T_RESULTRAY_DETAILS(

                          DGV_X_SEND.Rows[i].Cells[0].Value.ToString()
                        , DGV_X_SEND.Rows[i].Cells[1].Value.ToString()
                        , DGV_X_SEND.Rows[i].Cells[3].Value.ToString()
                        , DGV_X_SEND.Rows[i].Cells[2].Value.ToString()
                        , DGV_X_SEND.Rows[i].Cells[4].Value.ToString()
                        , 0
                        , ""
                        , false
                        , BookId
                        , null
                        , null
                        , null
                        , null
                        , ref CLS.SUBMIT_FLAG).ToString();

                }


                if (CLS.SUBMIT_FLAG == 1)
                {
                    MessageBox.Show("تمت العملية بنجاح", CLS.TITEL_MESG);

                    DGV_X_SEND.Rows.Clear();
                }


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ADD_RAY_TODGV_Click(object sender, EventArgs e)
        {
            if (nAME_RAYSComboBox.SelectedIndex == -1)

            {
                MessageBox.Show("يرجى اختيار الاشعة ", CLS.TITEL_MESG);
                return;
            }
            else
            {

                DGV_X_SEND.Rows.Add(nAME_RAYSComboBox.Text, comb_toothname.Text, V_SIDE, H_SIDE, "color");
            }

        }

        private void DGV_X_SEND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    DGV_X_SEND.Rows.RemoveAt(DGV_X_SEND.CurrentRow.Index);

                }
            }
        }



        private void BTN_S_R_DATE_Click(object sender, EventArgs e)
        {
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }

        private void label32_Click(object sender, EventArgs e)
        {
            PERSONS.FRM_M_HISTORY FRM = new PERSONS.FRM_M_HISTORY(  lblpersoncode.Text.ToInt());
            FRM.ShowDialog();
        }


        DataTable DT = new DataTable();
        private void btn_getdata_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_MEDICAL_HISTORY_PTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_MEDICAL_HISTORY_P, new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))));
                this.gET_MEDICAL_HISTORY_QUESTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_MEDICAL_HISTORY_QUES, new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))));


                DT = this.mEDICAL_CLINIC_DBDataSet1.GET_MEDICAL_HISTORY_QUES;
                if ((bool)DT.Rows[0][0] == true)
                {
                    LBL_P_VISIT_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_P_VISIT_NO.BackColor = Color.Yellow;
                }
                if ((bool)DT.Rows[0][1] == true)
                {
                    LBL_Digestiv.BackColor = Color.Yellow;
                }
                if ((bool)DT.Rows[0][2] == true)
                {
                    LBL_Breath.BackColor = Color.Yellow;
                }

                if ((bool)DT.Rows[0][3] == true)
                {
                    LBL_Neurolo.BackColor = Color.Yellow;
                }
                if ((bool)DT.Rows[0][4] == true)
                {
                    LBL_Heart.BackColor = Color.Yellow;
                }

                if ((bool)DT.Rows[0][5] == true)
                {
                    LBL_NO.BackColor = Color.Yellow;
                }
                TXT_CHRONIC.Text = DT.Rows[0][6].ToString();

                if ((bool)DT.Rows[0][7] == true)
                {
                    LBL_medica_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_medica_YES.BackColor = Color.Yellow;
                }


                TXT_medications.Text = DT.Rows[0][8].ToString();

                if ((bool)DT.Rows[0][9] == true)
                {
                    LBL_allergies_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_allergies_NO.BackColor = Color.Yellow;
                }
                TXT_allergies.Text = DT.Rows[0][10].ToString();

                if ((bool)DT.Rows[0][11] == true)
                {
                    LBL_SOMKE_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_SMOKE_NO.BackColor = Color.Yellow;
                }
                if ((bool)DT.Rows[0][12] == true)
                {
                    LBL_COHOL_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_COHOL_NO.BackColor = Color.Yellow;
                }

                if ((bool)DT.Rows[0][13] == true)
                {
                    LBL_breastf_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_breastf_NO.BackColor = Color.Yellow;
                }

                if ((bool)DT.Rows[0][14] == true)
                {
                    LBL_pregnant_YES.BackColor = Color.Yellow;
                }
                else
                {
                    LBL_pregnant_YES.BackColor = Color.Yellow;
                }
                LBL_REASON_VISIT.Text = DT.Rows[0][15].ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 17)
            {
                LBL_SUGER.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                LBL_PRESSURE.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                LBL_PRESCRIPTION.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                LBL_TEMP.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                LBL_BLOOD.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                LBL_HEIGHT.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                LBL_WEIGHT.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                LBLNOTE.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                if ((bool)dataGridView1.CurrentRow.Cells[11].Value == true)
                {
                    LBL_HEP.Text = "Positive";
                }
                else
                {
                    LBL_HEP.Text = "Negative";
                }

                if ((bool)dataGridView1.CurrentRow.Cells[12].Value == true)
                {
                    LBL_HIV.Text = "Positive";
                }
                else
                {
                    LBL_HIV.Text = "Negative";
                }

            }

        }




        private void btn_xray_refresh_Click(object sender, EventArgs e)
        {
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            COLOR_T = "COLOR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            COLOR_T = "";
        }

        private void BTN_CASH_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in PayList)
                {
                    var controls = tableLayoutPanel64.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                PayList.Clear();
                if (PayList.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    PayList.Remove(((Control)sender).Name);
                    F_PAY = 0;
                }
                else
                {

                    PayList.Add(((Control)sender).Name);
                    // CLS.CANAL_UPPER_N = ((Control)sender).Text;
                    ((Control)sender).BackColor = Color.Red;
                    if (((Control)sender).Name == "BTN_CASH")
                    {
                        F_PAY = 1;
                    }
                    if (((Control)sender).Name == "BTN_NO_CASH")
                    {
                        F_PAY = 2;
                    }
                    else
                     if (((Control)sender).Name == "BTN_PARTIAL_CASH")
                    {
                        F_PAY = 3;
                    }
                }


            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }

        }

        private void BTN_NO_CASH_Click(object sender, EventArgs e)
        {
            F_PAY = 2;

        }

        private void BTN_PARTIAL_CASH_Click(object sender, EventArgs e)
        {
            F_PAY = 3;
        }

        private void BTN_GOWAITREPORT_Click(object sender, EventArgs e)
        {
            try
            {
                if (bOOKING_CODELabel1.Text != "..........")
                {
                    var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    UPDT.P_UPDATE_T_BOOKING_GOWAIT(Convert.ToInt32(lblbookcode.Text), ref CLS.SUBMIT_FLAG);
                    MessageBox.Show("تمت العملية بنجاح");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("يرجى اختيار مريض اولا");
            }
        }

        private void BTN_GOWAIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (bOOKING_CODELabel1.Text != "..........")
                {
                    var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    UPDT.P_UPDATE_T_BOOKING_BACKQEUE_DOCT(Convert.ToInt32(lblbookcode.Text), ref CLS.SUBMIT_FLAG);
                    MessageBox.Show("تمت العملية بنجاح");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("يرجى اختيار مريض اولا");
            }
        }

        private void BTN_IMG_Click(object sender, EventArgs e)
        {
            try
            {
                if (bOOKING_CODELabel1.Text != "..........")
                {
                    ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(Convert.ToInt32(lblbookcode.Text), 1);
                    FRM.ShowDialog();
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("يرجى اختيار مريض اولا");
            }

        }



        private void LBL_GET_DEBT_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(19, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))), CLS.Cost_Center_WARD_DR, DateTime.Now, DateTime.Now, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                LBL_PAST_DEBIT.Text = (Convert.ToDecimal(this.mEDICAL_CLINIC_DBDataSet1.GET_DEBIT_BY_BCODE_ACOD.Rows[0][2]).ToString("N0")).ToString();



            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("يرجى اختيار مريض اولا");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            PERSONS.FRM_MEDICAL_HISTORY_PERSON FRM = new PERSONS.FRM_MEDICAL_HISTORY_PERSON(lblpersoncode.Text.ToInt()); FRM.ShowDialog();
        }

        private void btn_Allboking_Click(object sender, EventArgs e)
        {
            REPORT.FRM_DR_BOOKING_RPT fRM = new REPORT.FRM_DR_BOOKING_RPT();
            fRM.ShowDialog();
        }

        private void gET_LAB_TEST_BY_CATEGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 16)
            {
                if (nAME_CATEGComboBox.SelectedIndex != -1)
                {
                    int FoodIndex = -1;

                    for (int i = 0; i < DGV_TEST_SENT.Rows.Count; i++)
                    {
                        if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString().Equals(DGV_TEST_SENT.Rows[i].Cells[0].Value.ToString()))
                            FoodIndex = i;

                    }
                    if (FoodIndex == -1)
                    {
                        DGV_TEST_SENT.Rows.Add(
                        gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString(),
                        gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[1].Value.ToString(),
                        gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[5].Value.ToString(),
                        "");

                    }
                    else
                    {
                        MessageBox.Show("التحليل موجود مسبقا");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("اختار التحليل اولا ", CLS.TITEL_MESG);
                    return;
                }
            }
        }
        int idres = 0;
        private void DGV_ALL_TEST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {

                    this.p_GET_H_ALL_TESTS_FOR_PERSON_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.P_GET_H_ALL_TESTS_FOR_PERSON_DET, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(DGV_ALL_TEST.CurrentRow.Cells[12].Value, typeof(int))))));
                    idres = DGV_ALL_TEST.CurrentRow.Cells[12].Value.ToInt();
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }



            //ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(Convert.ToInt32(DGV_ALL_TEST.CurrentRow.Cells[19].Value), 1);
            //FRM.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(idres, 1);
                FRM.ShowDialog();
            }
        }



        private void LBL_PAID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var origText = this.LBL_PAID.Text;

                this.LBL_PAID.Text = Convert.ToDecimal(this.LBL_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.LBL_PAID.SelectionStart = LBL_PAID.TextLength;
                LBL_REMAIN.Text = (Convert.ToDecimal(LBL_TOTAL_PRICE.Text) - Convert.ToDecimal(LBL_PAID.Text)).ToString("N0");

            }
            catch (System.Exception ex)
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_TO_ACCOUNT_Click(object sender, EventArgs e)
        {
            if (LBL_NAMEPERSON.Text == "..........")
            {
                MessageBox.Show("فضلا قم بأختيار مريض اولا");
                return;

                if (LBL_TOTAL_PRICE.Text.ToDecimal() > 0)
                {
                    Decimal DoctorPrecentage = DR_OPPERCENT;
                    decimal TOTAL_PRICE = Convert.ToDecimal(LBL_TOTAL_PRICE.Text);
                    decimal DebitPatient = 0;
                    decimal CreditService = 0;
                    decimal CreditDoctor = 0;
                    var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();



                    if (DR_OPPERCENT > 0)
                    {



                        DebitPatient = TOTAL_PRICE;
                        CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                        CreditService = TOTAL_PRICE - CreditDoctor;



                        BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                    Convert.ToInt32(lblbookcode.Text)
                                  , System.DateTime.Now
                                  , "عن اجور حشوات وعمليات الاسنان "
                                  , 19
                                  , 0
                                  , true
                                  , CLS.USER_CODE
                                  , ref CLS.SUBMIT_FLAG
                                  , CLS.BRANCH_ID
                                  , cost_center_code
                                  ).ToString());


                        if (F_PAY == 2)
                        {
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                            (
                                             BookId
                                            , Convert.ToInt32(lblpersoncode.Text)
                                            , " اجور  عملية"
                                            , 0
                                            , 0
                                            , DebitPatient
                                            , 0
                                            , "من حساب الزبون الى حساب الصندوق"
                                            , 1
                                            , 1
                                            , ref CLS.SUBMIT_FLAG
                                             );

                            //TO

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                              BookId
                            , 4005
                             , " اجور  عملية"
                            , 0
                            , 0
                            , 0
                            , CreditService
                            , "من حساب الزبون الى حساب العمليات"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                       (
                         BookId
                       , Convert.ToInt32(CLS.USER_CODE)
                        , " اجور  عملية"
                       , 0
                       , 0
                       , 0
                       , CreditDoctor
                       , "من حساب الزبون الى حساب الدكتور"
                       , 1
                       , 1
                       , ref CLS.SUBMIT_FLAG
                        );
                        }

                    }

                    else

                    if (DR_OPPERCENT == 0)
                    {



                        BookId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                    Convert.ToInt32(lblbookcode.Text)
                                  , System.DateTime.Now
                                  , "عن اجور حشوات وعمليات الاسنان "
                                  , 19
                                  , 0
                                  , true
                                  , CLS.USER_CODE
                                  , ref CLS.SUBMIT_FLAG
                                  , CLS.BRANCH_ID
                                  , cost_center_code
                                  ).ToString());


                        if (F_PAY == 2)
                        {
                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                            (
                                             BookId
                                            , Convert.ToInt32(lblpersoncode.Text)
                                            , " اجور  عملية"
                                            , 0
                                            , 0
                                            , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                                            , 0
                                            , "من حساب الزبون الى حساب الصندوق"
                                            , 1
                                            , 1
                                            , ref CLS.SUBMIT_FLAG
                                             );

                            //TO

                            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                       (
                         BookId
                       , Convert.ToInt32(CLS.USER_CODE)
                        , " اجور  عملية"
                       , 0
                       , 0
                       , 0
                       , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                       , "من حساب الزبون الى حساب الدكتور"
                       , 1
                       , 1
                       , ref CLS.SUBMIT_FLAG
                        );
                        }



                    }
                }
                LBL_TOTAL_PRICE.Text = "0";
                LBL_PAID.Text = "0";
                LBL_REMAIN.Text = "0";
                MSG.Msg.MsgBoxResult("Sent Seccessfully");

            }
        }


        //public void Cealr_UCFilling()
        //{
        //    uC_Filling.chCL1.Checked = false;
        //    uC_Filling.chCLIIMQ.Checked=false; 
        //    uC_Filling.ch_CLIIDO.Checked=false; 
        //    uC_Filling.ch_CLIIMQD.Checked=false; 
        //    uC_Filling.ch_CLIIIM.Checked=false; 
        //    uC_Filling.ch_CLIIID.Checked=false; 
        //    uC_Filling.ch_CLIV.Checked=false; 
        //    uC_Filling.ch_CLV.Checked=false;
        //    uC_Filling.btn_Amalgam.BackColor = Color.FromArgb(16, 127, 201);
        //    uC_Filling.btn_Compsite.BackColor = Color.FromArgb(16, 127, 201);
        //    uC_Filling.btn_TemprorayFilling.BackColor = Color.FromArgb(16, 127, 201);
        //    uC_Filling.btn_GlassIonomerCement.BackColor = Color.FromArgb(16, 127, 201);
        //}
        //private void btn_filling_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        USERCONTROL.UC_Filling uC_Filling = new USERCONTROL.UC_Filling();

        //        panel14.Controls.Add(uC_Filling);
        //        var sss = uC_Filling.Size;
        //        uC_Filling.Size = panel14.Size;
        //        //uC_Filling.Location = new Point(0, 250);
        //        uC_Filling.Dock = DockStyle.Fill;
        //        uC_Filling.BringToFront();
        //        myuc = 100;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}
        //private void btn_extraction_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        USERCONTROL.UC_Extraction uC_Extraction = new USERCONTROL.UC_Extraction();

        //        panel14.Controls.Add(uC_Extraction);
        //        uC_Extraction.Size = panel14.Size;
        //        //uC_Filling.Location = new Point(0, 250);
        //        uC_Extraction.Dock = DockStyle.Fill;
        //        uC_Extraction.BringToFront();
        //        myuc = 1;

        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}
        //private void btn_RPD_CD_Click(object sender, EventArgs e)
        //{
        //USERCONTROL.UC_RPDCD uC_RPD = new USERCONTROL.UC_RPDCD();
        //    panel14.Controls.Add(uC_RPD);
        //    uC_RPD.Dock = DockStyle.Fill;
        //    uC_RPD.BringToFront();
        //    myuc = 1;
        //}
        //private void btn_SP_Click(object sender, EventArgs e)
        //{
        //USERCONTROL.UC_SP uC_sp = new USERCONTROL.UC_SP();
        //    panel14.Controls.Add(uC_sp);
        //    uC_sp.Dock = DockStyle.Fill;
        //    uC_sp.BringToFront();
        //    myuc = 1;
        //}
        //private void btn_RCT_Click(object sender, EventArgs e)
        //{
        //USERCONTROL.UC_RCT uC_RCT = new USERCONTROL.UC_RCT();
        //    panel14.Controls.Add(uC_RCT);
        //    uC_RCT.Dock = DockStyle.Fill;
        //    uC_RCT.BringToFront();

        //}
        //private void btn_CrownBrodge_Click(object sender, EventArgs e)
        //{
        //USERCONTROL.UC_CrownBridge uC_CrownBrdge = new USERCONTROL.UC_CrownBridge();
        //    panel14.Controls.Add(uC_CrownBrdge);
        //    uC_CrownBrdge.Dock = DockStyle.Fill;
        //    uC_CrownBrdge.BringToFront();

        //}
        //private void btn_Implant_Click(object sender, EventArgs e)
        //{
        //USERCONTROL.UC_Implant uC_Implant = new USERCONTROL.UC_Implant();
        //    panel14.Controls.Add(uC_Implant);
        //    uC_Implant.Dock = DockStyle.Fill;
        //    uC_Implant.BringToFront();
        //}

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var origText = this.textBoxX1.Text;

                this.textBoxX1.Text = Convert.ToDecimal(this.textBoxX1.Text).ToString("N0", new CultureInfo("en-US"));
                this.textBoxX1.SelectionStart = textBoxX1.TextLength;

                DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[6].Value = textBoxX1.Text;
                sumtotal();

                // }
            }
            catch
            {
                return;
            }

        }

        private void TXT_NOTE_TextChanged(object sender, EventArgs e)
        {
            DGV_ALL_Tooth.Rows[DGV_ALL_Tooth.RowCount - 1].Cells[8].Value = TXT_NOTE.Text;
        }

        private void btn_filling_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in ListMain)
                {
                    var controls = tableLayoutPanel10.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                ListMain.Clear();
                CLS.MainListTooth.Clear();
                if (ListMain.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    ListMain.Remove(((Control)sender).Name);
                    CLS.MainListTooth.Remove(((Control)sender).Text);
                    panel14.Controls.Clear();
                }
                else
                {

                    ListMain.Add(((Control)sender).Name);
                    CLS.MainListTooth.Add(((Control)sender).Name);
                    ((Control)sender).BackColor = Color.Red;

                    if (((Control)sender).Name == "btn_filling")
                    {

                        USERCONTROL.UC_Filling uC_Filling = new USERCONTROL.UC_Filling();

                        panel14.Controls.Add(uC_Filling);
                        var sss = uC_Filling.Size;
                        uC_Filling.Size = panel14.Size;
                        uC_Filling.Dock = DockStyle.Fill;
                        uC_Filling.BringToFront();

                    }
                    else
                         if (((Control)sender).Name == "btn_extraction")
                    {

                        USERCONTROL.UC_Extraction uC_Extraction = new USERCONTROL.UC_Extraction();

                        panel14.Controls.Add(uC_Extraction);
                        uC_Extraction.Size = panel14.Size;
                        uC_Extraction.Dock = DockStyle.Fill;
                        uC_Extraction.BringToFront();
                        myuc = 1;
                    }
                    else
                         if (((Control)sender).Name == "btn_RPD_CD")
                    {

                        USERCONTROL.UC_RPDCD uC_RPD = new USERCONTROL.UC_RPDCD();
                        panel14.Controls.Add(uC_RPD);
                        uC_RPD.Dock = DockStyle.Fill;
                        uC_RPD.BringToFront();
                    }
                    else
                         if (((Control)sender).Name == "btn_SP")
                    {

                        USERCONTROL.UC_SP uC_sp = new USERCONTROL.UC_SP();
                        panel14.Controls.Add(uC_sp);
                        uC_sp.Dock = DockStyle.Fill;
                        uC_sp.BringToFront();
                    }
                    else
                         if (((Control)sender).Name == "btn_RCT")
                    {
                        panel14.Controls.Clear();
                        //USERCONTROL.UC_RCT uC_RCT = new USERCONTROL.UC_RCT();
                        //panel14.Controls.Add(uC_RCT);
                        //uC_RCT.Dock = DockStyle.Fill;
                        //uC_RCT.BringToFront();
                    }
                    else
                         if (((Control)sender).Name == "btn_CrownBrodge")
                    {

                        USERCONTROL.UC_CrownBridge uC_CrownBrdge = new USERCONTROL.UC_CrownBridge();
                        panel14.Controls.Add(uC_CrownBrdge);
                        uC_CrownBrdge.Dock = DockStyle.Fill;
                        uC_CrownBrdge.BringToFront();
                    }
                    else
                         if (((Control)sender).Name == "btn_Implant")
                    {

                        USERCONTROL.UC_Implant uC_Implant = new USERCONTROL.UC_Implant();
                        panel14.Controls.Add(uC_Implant);
                        uC_Implant.Dock = DockStyle.Fill;
                        uC_Implant.BringToFront();
                    }
                    else
                         if (((Control)sender).Name == "btn_Orthopedic")
                    {

                        USERCONTROL.UC_Orthopedic uC_Implant = new USERCONTROL.UC_Orthopedic();
                        panel14.Controls.Add(uC_Implant);
                        uC_Implant.Dock = DockStyle.Fill;
                        uC_Implant.BringToFront();
                    }

                }
            }
            catch
            {

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            COLOR_T = "NO COLOR";
        }

      
        private void BTN_S_R_RAY_Click(object sender, EventArgs e)
        {
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }

        private void BTN_S_R_ALL_Click(object sender, EventArgs e)
        {
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet1.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(lblpersoncode.Text, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }

        private void DGV_ALL_RAYS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(DGV_ALL_RAYS.CurrentRow.Cells[16].Value.ToInt(), 2);
                FRM.ShowDialog();
            }

            //for (int i = 10; i < 14; i++)
            //{
            //    if (DGV_ALL_RAYS.CurrentRow.Cells[i].Value.ToString()!= string.Empty)

            //    {
            //         imge1 = (byte[])DGV_ALL_RAYS.CurrentRow.Cells[i].Value;
            //        MemoryStream ms1 = new MemoryStream(imge1);
            //       // pictureBox3.Image = Image.FromStream(ms1);
            //            imageList1.Images.Add(Image.FromStream(ms1));



            //    }


            //}
            //try
            //{
            //    if (DGV_ALL_RAYS.CurrentRow.Cells[10].Value == null || DGV_ALL_RAYS.CurrentRow.Cells[10].Value == DBNull.Value)
            //    {
            //        imge1 = new byte[0];
            //    }
            //    else
            //    {

            //        imge1 = (byte[])DGV_ALL_RAYS.CurrentRow.Cells[10].Value;
            //    }

            //    if (DGV_ALL_RAYS.CurrentRow.Cells[11].Value == null || DGV_ALL_RAYS.CurrentRow.Cells[11].Value == DBNull.Value)
            //    {
            //        imge2 = new byte[0];
            //    }
            //    else
            //    {

            //        imge2 = (byte[])DGV_ALL_RAYS.CurrentRow.Cells[11].Value;
            //    }

            //    if (DGV_ALL_RAYS.CurrentRow.Cells[12].Value == null || DGV_ALL_RAYS.CurrentRow.Cells[12].Value == DBNull.Value)
            //    {
            //        imge3 = new byte[0];
            //    }
            //    else
            //    {

            //        imge3 = (byte[])DGV_ALL_RAYS.CurrentRow.Cells[12].Value;
            //    }
            //    if (DGV_ALL_RAYS.CurrentRow.Cells[13].Value == null || DGV_ALL_RAYS.CurrentRow.Cells[13].Value == DBNull.Value)
            //    {
            //        imge4 = new byte[0];
            //    }
            //    else
            //    {

            //        imge4 = (byte[])DGV_ALL_RAYS.CurrentRow.Cells[13].Value;
            //    }
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

            //XRAY.FRM_SHOW_RAYS FRM = new XRAY.FRM_SHOW_RAYS(imge1, imge2, imge3, imge4);//imageList1);
            //FRM.ShowDialog();
        }

        void ResetLblColor()
        {

            UR8.BackColor = Color.Transparent;

            UR7.BackColor = Color.Transparent;

            UR6.BackColor = Color.Transparent;

            UR5.BackColor = Color.Transparent;

            UR4.BackColor = Color.Transparent;

            UR3.BackColor = Color.Transparent;

            UR2.BackColor = Color.Transparent;

            UR1.BackColor = Color.Transparent;
            //LEFT

            UL8.BackColor = Color.Transparent;

            UL7.BackColor = Color.Transparent;

            UL6.BackColor = Color.Transparent;

            UL5.BackColor = Color.Transparent;

            UL4.BackColor = Color.Transparent;

            UL3.BackColor = Color.Transparent;

            UL2.BackColor = Color.Transparent;

            UL1.BackColor = Color.Transparent;
            //LPWER


            LR8.BackColor = Color.Transparent;

            LR7.BackColor = Color.Transparent;

            LR6.BackColor = Color.Transparent;

            LR5.BackColor = Color.Transparent;

            LR4.BackColor = Color.Transparent;

            LR3.BackColor = Color.Transparent;

            LR2.BackColor = Color.Transparent;

            LR1.BackColor = Color.Transparent;
            //LEFT

            LL8.BackColor = Color.Transparent;

            LL7.BackColor = Color.Transparent;

            LL6.BackColor = Color.Transparent;

            LL5.BackColor = Color.Transparent;

            LL4.BackColor = Color.Transparent;

            LL3.BackColor = Color.Transparent;

            LL2.BackColor = Color.Transparent;

            LL1.BackColor = Color.Transparent;
        }
        void setParentPic()
        {
            UR8.Parent = pictureBox1;

            UR7.Parent = pictureBox1;

            UR6.Parent = pictureBox1;

            UR5.Parent = pictureBox1;

            UR4.Parent = pictureBox1;

            UR3.Parent = pictureBox1;

            UR2.Parent = pictureBox1;

            UR1.Parent = pictureBox1;

            //LEFT
            UL8.Parent = pictureBox1;

            UL7.Parent = pictureBox1;

            UL6.Parent = pictureBox1;

            UL5.Parent = pictureBox1;

            UL4.Parent = pictureBox1;

            UL3.Parent = pictureBox1;

            UL2.Parent = pictureBox1;

            UL1.Parent = pictureBox1;

            //LPWER

            LR8.Parent = pictureBox1;

            LR7.Parent = pictureBox1;

            LR6.Parent = pictureBox1;

            LR5.Parent = pictureBox1;

            LR4.Parent = pictureBox1;

            LR3.Parent = pictureBox1;

            LR2.Parent = pictureBox1;

            LR1.Parent = pictureBox1;

            //LEFT
            LL8.Parent = pictureBox1;

            LL7.Parent = pictureBox1;

            LL6.Parent = pictureBox1;

            LL5.Parent = pictureBox1;

            LL4.Parent = pictureBox1;

            LL3.Parent = pictureBox1;

            LL2.Parent = pictureBox1;

            LL1.Parent = pictureBox1;
        }
        void ResetMainButtonColor()
        {
            btn_Implant.BackColor = Color.FromArgb(16, 127, 201);
            btn_filling.BackColor = Color.FromArgb(16, 127, 201);
            btn_RCT.BackColor = Color.FromArgb(16, 127, 201);
            btn_SP.BackColor = Color.FromArgb(16, 127, 201);
            btn_RPD_CD.BackColor = Color.FromArgb(16, 127, 201);
            btn_extraction.BackColor = Color.FromArgb(16, 127, 201);
            btn_CrownBrodge.BackColor = Color.FromArgb(16, 127, 201);
        }

    }
}
