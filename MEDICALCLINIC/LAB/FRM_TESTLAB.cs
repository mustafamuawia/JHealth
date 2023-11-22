using MEDICALCLINIC.HOSPITAL.PRINT;
using MEDICALCLINIC.Services;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static MEDICALCLINIC.Services.LabService;

namespace MEDICALCLINIC.LAB
{
    public partial class FRM_TESTLAB : MEDICALCLINIC.LAB.baselab

    {
        DataTable dtrpt = new DataTable();
        DataTable dtimg = new DataTable();
        bool ISDELVER;
        int BOX_ID, ID_BOOK=0,ID_MAIN_BOOK=0;
        int DR_CODE=-1, PERSON_CODE = -1,LAB_TYPE=1, ISCOMP = -1;
        bool   ACTIVR_F = false ;
        List<string> tooth;
        int id_res_de=0, id_res=0, FLAG_PAY =0,idperson=0;
        decimal   INCREMENTPRICE, DECREMENTPRICE;
        int FLAGR_EMPTY = -1;
        DataTable dt = new DataTable();
        LabService srv = null;
        public FRM_TESTLAB()
        {
            InitializeComponent();
            //try
            //{
            //    SqlClientPermission perm = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
            //    perm.Demand();
            //}
            //catch
            //{
            //    throw new ApplicationException("No permission");
            //}
          //  InitializeComponent();
            
        }
        public void LabService_OnLabTest(object sender)
        {

            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // Check if the event was generated from another
            // thread and needs invoke instead
            if (i.InvokeRequired)
            {
                OnLabTestCallBack tempDelegate = new OnLabTestCallBack(LabService_OnLabTest);
                i.BeginInvoke(tempDelegate, new object[] { null });
                return;
            }
            //this.gET_DOCTOR_INFO_SHOW_1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_1, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            //this.gET_DOCTOR_INFO_SHOW_2TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_2, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            //this.gET_DOCTOR_INFO_SHOW_3TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_3, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            //this.gET_DOCTOR_INFO_SHOW_4TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_4, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            LoadTests();

            // 
        }
        void LoadTests() {
            if (pERSON_NAMEComboBox.SelectedIndex==-1)
            {
                idperson = 0;
            }
            else{
              idperson=  pERSON_NAMEComboBox.SelectedValue.ToInt();
            }
            this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(idperson, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), dateTimePicker1.Value);
        }
        private void FRM_TESTLAB_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.T_SEX_STATE' table. You can move, or remove it, as needed.
            this.t_SEX_STATETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.T_SEX_STATE);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_L_GET_A_LABNAME' table. You can move, or remove it, as needed.
           // dateTimePicker1.Value = System.DateTime.Now; 
            this.v_L_GET_A_LABNAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_L_GET_A_LABNAME);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
            // this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            // this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG' table. You can move, or remove it, as needed.
            this.gET_LAB_DOCTOR_BY_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_DOCTOR_BY_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), "");
            this.gET_LAB_PERSON_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_PERSON_NAME_CODE, "");
            this.v_GET_A_L_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG);
            if (Properties.Settings.Default.LABTYPE==1)
            {
            LAB_TYPE = 1;
            BTN_GETCASH_CUSTOMER.BackColor = Color.Red;
            BTN_FROM_DR.BackColor = Color.FromArgb(0, 94, 170);
            }
          else
          if (Properties.Settings.Default.LABTYPE == 2)
            {
                LAB_TYPE = 2;
                BTN_FROM_DR .BackColor = Color.Red;
                BTN_GETCASH_CUSTOMER.BackColor = Color.FromArgb(0, 94, 170);
            }
          //  else
          //if (Properties.Settings.Default.LABTYPE == 3)
          //  {
          //      LAB_TYPE = 2;
          //      BTN_FROM_DR.BackColor = Color.FromArgb(0, 94, 170);
          //      BTN_GETCASH_CUSTOMER.BackColor = Color.FromArgb(0, 94, 170);
          //  }
            tooth = new List<string>();
            TXT_NOTE.Clear();
            dt = this.mEDICAL_CLINIC_DBDataSet.GET_LAB_PERSON_NAME_CODE;
            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasource.Add(dt.Rows[i][1].ToString());
            }
            this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
            this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pERSON_NAMEComboBox.SelectedIndex = -1;
            dOCTOR_NAMEComboBox.SelectedIndex = -1;
            nAME_CATEGComboBox.SelectedIndex = -1;
            try
            {
                SqlClientPermission perm = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                perm.Demand();
            }
            catch
            {
                throw new ApplicationException("No permission");
            }

            srv = new LabService();
            srv.OnLabTest += new OnLabTestCallBack(LabService_OnLabTest);
            LoadTests();
        }

        private void nAME_CATEGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_LAB_TEST_BY_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_TEST_BY_CATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox.SelectedValue, typeof(int))))));

                //  gET_LAB_TEST_BY_CATEGDataGridView.Refresh();

                ////new
                for (int i = 0; i < this.mEDICAL_CLINIC_DBDataSet.GET_LAB_TEST_BY_CATEG.Count; i++)
                {
                    gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value = "";
                    gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[10].Value = "";

                }
               
            }
            catch (System.Exception ex)
            {
              //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void PIC_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gET_LAB_TEST_BY_CATEGDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count > 0)
            //{
                //if (FLAGR_EMPTY == 1)
                //{
                //if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == null || 
                //gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == "" || 
                //gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == DBNull.Value || 
                //(String.IsNullOrWhiteSpace(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString())))

                //{
                //    INCREMENTPRICE = 0;
                //    }
                //    else
                //    {
                    /* INCREMENTPRICE = Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value);
                     LBL_TOTAL_PRICE.Text = (Convert.ToDecimal(LBL_TOTAL_PRICE.Text) + 
                     Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value)).ToString();
    //                 */
    //                LBL_TOTAL_PRICE.Text = (from DataGridViewRow row in gET_LAB_TEST_BY_CATEGDataGridView.Rows
    //where row.Cells[4].Value !=string.Empty
    //select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
    //            //}


                //}
                //else
                //if (FLAGR_EMPTY == 2)
                //{
                //    if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == null || gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == DBNull.Value || (String.IsNullOrWhiteSpace(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString())))
                //    {
                //        LBL_TOTAL_PRICE.Text = (Convert.ToDecimal(LBL_TOTAL_PRICE.Text) - Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value)).ToString();

                //    }

                //}


           // }
        }

        private void pERSON_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (pERSON_NAMEComboBox.SelectedIndex != -1)
            //{
            //    this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), dateTimePicker1.Value);


            //    if (pERSON_NAMEComboBox.Text != "CCCCC")
            //    {
            //        TXT_PATIENT.Text = pERSON_NAMEComboBox.Text;
            //    }
            //    else
            //    {
            //        TXT_PATIENT.Text = "";
            //        TXT_PATIENT.Focus();
            //    }
            //}







            //           if (pERSON_NAMEComboBox.SelectedIndex != -1)
            //           {
            //               this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))),dateTimePicker1.Value);




            //           if (pERSON_NAMEComboBox.Text != "CUSTOMERCASH")
            //           {
            //               TXT_PATIENT.Text = pERSON_NAMEComboBox.Text;
            //           }
            //           else
            //           {
            //               TXT_PATIENT.Text = "";
            //               TXT_PATIENT.Focus();
            //           }
            //}
        }

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //if (dOCTOR_NAMEComboBox.Text != "DOCTORCASH")
            //{

            //    TXT_DOCTOR.Text = dOCTOR_NAMEComboBox.Text;
            //}
            //else
            //{
            //    TXT_DOCTOR.Text = "";
            //    TXT_DOCTOR.Focus();
            //}
        }

        

        //private void gET_LAB_TEST_BY_CATEGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 4)
        //    {
        //        if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == null || gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString() == "")
        //        {
        //            DataGridViewCell cellQty = gET_LAB_TEST_BY_CATEGDataGridView.Rows[gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count - 1].Cells[1];
        //            gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell = cellQty;
        //            gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[1].Selected = true;
        //            gET_LAB_TEST_BY_CATEGDataGridView.BeginEdit(true);
        //        }
        //    }
        //}

         

        private void gET_LAB_TEST_BY_CATEGDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    int col = gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell.ColumnIndex;
            //    int row = gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell.RowIndex;

            //    if (col < gET_LAB_TEST_BY_CATEGDataGridView.ColumnCount - 1)
            //    {
            //        col++;
            //    }
            //    else
            //    {
            //        col = 0;
            //        row++;
            //        gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell = gET_LAB_TEST_BY_CATEGDataGridView.Rows[row].Cells[4];

            //    }

            //    //if (row == gET_LAB_TEST_BY_CATEGDataGridView.RowCount)
            //        //  dataGridView1.Rows.Add();

            //        gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell = gET_LAB_TEST_BY_CATEGDataGridView[col, row];
            //    e.Handled = true;

            //    gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Selected = true;
            //    gET_LAB_TEST_BY_CATEGDataGridView.BeginEdit(true);

            //}
        }

        private void BTN_CASH_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_CASH_Click_1(object sender, EventArgs e)
        {
            foreach (var x in tooth)
            {
                var controls = tableLayoutPanel9.Controls.Find(x, false);
                if (controls.Length > 0)
                    controls[0].BackColor = Color.SteelBlue;
            }
            tooth.Clear();

            if (tooth.Any(s => s == ((Control)sender).Name))
            {
                ((Control)sender).BackColor = Color.SteelBlue;
                tooth.Remove(((Control)sender).Name);
                //TOOTHNAMEE.Text = "X";
            }
            else
            {
                tooth.Add(((Control)sender).Name);
                // TOOTHNAMEE.Text = ((Control)sender).Name;

                ((Control)sender).BackColor = Color.Red;
                if (((Control)sender).Name == "BTN_CASH")
                {
                    FLAG_PAY = 1;
                    TXT_PAID.Text= LBL_TOTAL_PRICE.Text;
                    LBL_REMAIN.Text = (LBL_TOTAL_PRICE.Text.ToDecimal() - TXT_PAID.Text.ToDecimal()).ToString();

                }
                else
                if (((Control)sender).Name == "BTN_NO_CASH")
                {
                    FLAG_PAY = 2;
                 
                }
                else
                if (((Control)sender).Name == "BTN_PARTIAL_CASH")
                {
                    FLAG_PAY = 3;


                }
            }
        }

        private void BTN_NO_CASH_Click(object sender, EventArgs e)
        {
            foreach (var x in tooth)
            {
                var controls = tableLayoutPanel9.Controls.Find(x, false);
                if (controls.Length > 0)
                    controls[0].BackColor = Color.SteelBlue;
            }
            tooth.Clear();

            if (tooth.Any(s => s == ((Control)sender).Name))
            {
                ((Control)sender).BackColor = Color.SteelBlue;
                tooth.Remove(((Control)sender).Name);
                //TOOTHNAMEE.Text = "X";
            }
            else
            {
                tooth.Add(((Control)sender).Name);
                // TOOTHNAMEE.Text = ((Control)sender).Name;

                ((Control)sender).BackColor = Color.Red;
                if (((Control)sender).Name == "BTN_CASH")
                {
                    FLAG_PAY = 1;

                }
                else
                if (((Control)sender).Name == "BTN_NO_CASH")
                {
                    FLAG_PAY = 2;
                    // LBL_REMAIN.Text = LBL_TOTAL_PRICE.Text;
                    TXT_PAID.Text = "0";
                    LBL_REMAIN.Text = (LBL_TOTAL_PRICE.Text.ToDecimal() - TXT_PAID.Text.ToDecimal()).ToString();

                }
                else
                if (((Control)sender).Name == "BTN_PARTIAL_CASH")
                {
                    FLAG_PAY = 3;

                }
            }
        }

        private void BTN_PARTIAL_CASH_Click(object sender, EventArgs e)
        {
            
        foreach (var x in tooth)
            {
                var controls = tableLayoutPanel9.Controls.Find(x, false);
                if (controls.Length > 0)
                    controls[0].BackColor = Color.SteelBlue;
            }
            tooth.Clear();

            if (tooth.Any(s => s == ((Control)sender).Name))
            {
                ((Control)sender).BackColor = Color.SteelBlue;
                tooth.Remove(((Control)sender).Name);
                //TOOTHNAMEE.Text = "X";
            }
            else
            {
                tooth.Add(((Control)sender).Name);
                // TOOTHNAMEE.Text = ((Control)sender).Name;

                ((Control)sender).BackColor = Color.Red;
                if (((Control)sender).Name == "BTN_CASH")
                {
                    FLAG_PAY = 1;

                }
                else
                if (((Control)sender).Name == "BTN_NO_CASH")
                {
                    FLAG_PAY = 2;

                }
                else
                if (((Control)sender).Name == "BTN_PARTIAL_CASH")
                {
                    FLAG_PAY = 3;
                    LBL_REMAIN.Text = (LBL_TOTAL_PRICE.Text.ToDecimal() - TXT_PAID.Text.ToDecimal()).ToString();

                }
            }
        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
            {
                MessageBox.Show("حدد الطابعة أولا");
                SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                FRM.ShowDialog();
                return;

            }
          
            this.gET_L_RESULT_TEST_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_RESULT_TEST_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_res, typeof(int))))));
            dtrpt = this.mEDICAL_CLINIC_DBDataSet.GET_L_RESULT_TEST_PRINT;
            this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))));
            dtimg = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
            LocalReport lr = new LocalReport();
        
            lr.ReportEmbeddedResource = "MEDICALCLINIC.LAB.PRINT.RPT_LAB_PRINT.rdlc";
            lr.DataSources.Add(new ReportDataSource("DataSet1", dtrpt));
            lr.DataSources.Add(new ReportDataSource("DataSet2", dtimg));
            lr.Print();
        }

        private void TXT_PAID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                this.TXT_PAID.Text = Convert.ToDecimal(this.TXT_PAID.Text).ToString("N0", new CultureInfo("en-US"));
                this.TXT_PAID.SelectionStart = TXT_PAID.TextLength;
                LBL_REMAIN.Text = (Convert.ToDecimal(LBL_TOTAL_PRICE.Text) - Convert.ToDecimal(TXT_PAID.Text)).ToString();

               
            }
            catch
            {
                return;
            }
        }

        private void TXT_PAID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
                //MessageBox.Show("عذرا قم بادخال ارقام صحيحة او عشرية فقط");
            }
        }
 
 
        private void BTN_ADD_PER_Click(object sender, EventArgs e)
        {
            ACTIVR_F = true;
            HOSPITAL.SETTING_H.FRM_H_PERSON FRM = new HOSPITAL.SETTING_H.FRM_H_PERSON(); FRM.ShowDialog();

        }

        private void FRM_TESTLAB_Activated(object sender, EventArgs e)
        {
            if (ACTIVR_F == true)
            {


              
                this.gET_LAB_PERSON_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_PERSON_NAME_CODE, "");
                dt = this.mEDICAL_CLINIC_DBDataSet.GET_LAB_PERSON_NAME_CODE;
                AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    datasource.Add(dt.Rows[i][1].ToString());
                }
                this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
                this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                
                dOCTOR_NAMEComboBox.SelectedIndex = -1;
                pERSON_NAMEComboBox.SelectedIndex = -1;
               // this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), dateTimePicker1.Value);

                ACTIVR_F = false;
            }
        }

        private void BTN_FROM_DR_Click(object sender, EventArgs e)
        {
            LAB_TYPE =2;
             BTN_FROM_DR.BackColor = Color.Red;
            BTN_GETCASH_CUSTOMER.BackColor = Color.FromArgb(0, 94, 170);
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BTN_GET_TEST_DATE_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_L_ALL_TEST_LAB_NOT_COMPELETE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_GET_TEST_ALL_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_L_ALL_TEST_LAB_NOT_COMPELETE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //private void BTN_COMP_Click(object sender, EventArgs e)
        //{
        //    ISCOMP = 1;
        //    BTN_COMP.BackColor = Color.Red;
        //    BTN_INCOMP.BackColor = Color.FromArgb(0, 94, 170);

        //}

        //private void BTN_INCOMP_Click(object sender, EventArgs e)
        //{
        //    ISCOMP = 2;
        //    BTN_INCOMP.BackColor = Color.Red;
        //     BTN_COMP.BackColor = Color.FromArgb(0, 94, 170);

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
            {
                if (LBL_CODETEST.Text==string.Empty)
                {
                    MessageBox.Show("يرجى تحديد تحليل اولا ");
                    return;
                }
                var UPDTRES = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var UPDTFLAG = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                
                UPDTFLAG.P_UPDATE_L_RESTESTNAME_FLAGONLY(
                LBL_CODETEST.Text.ToInt(),
                true,
                ISDELVER,
                ref CLS.SUBMIT_FLAG);
                for (int i = 0; i < p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.Rows.Count; i++)
                {
                    UPDTRES.P_UPDATE_L_RESTESTNAME_DETAILS_RESULTONLY(
                    p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.Rows[i].Cells[4].Value.ToInt(),
                    p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.Rows[i].Cells[3].Value.ToString()
                    ,0
                    ,""
                    ,ref CLS.SUBMIT_FLAG);


                    if (TXT_PAY_NOW.Text.ToInt() >0)
                    {

                        var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //  string ServiceAccount = "", DoctorAccount = "", PatientAccount = "";



                        int BoXId;
                        // decimal DoctorPrecentage = Convert.ToDecimal(0);
                        //decimal DebitPatient = Convert.ToDecimal(TXT_PAID.Text);
                        //decimal TOTAL_PRICE = 0;
                        // decimal CreditService = 0;
                        // decimal CreditDoctor = 0;
                        //نقداَ
                        BoXId = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                                      LBL_CODETEST.Text.ToInt()
                                                    , System.DateTime.Now
                                                    , "المختبر"
                                                    , 15
                                                    , 0
                                                    , true
                                                    , CLS.USER_CODE
                                                    , ref CLS.SUBMIT_FLAG
                                                    , CLS.BRANCH_ID
                                                    , 11
                                                    ).ToString());
                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                        (
                                         BoXId
                                        , 111
                                        , ""
                                        , 0
                                        , 0
                                        , Convert.ToDecimal(TXT_PAY_NOW.Text)
                                        , 0
                                        , "من حساب الزبون الى حساب الصندوق"
                                        , 1
                                        , 1
                                        , ref CLS.SUBMIT_FLAG
                                         );

                        //TO

                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                        (
                          BoXId
                        , PERSON_CODE
                        , ""
                        , 0
                        , 0
                        , 0
                        , Convert.ToDecimal(TXT_PAY_NOW.Text)
                        , "من حساب الزبون الى حساب الصندوق"
                        , 1
                        , 1
                        , ref CLS.SUBMIT_FLAG
                         );

                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                         (
                           BoXId
                         , PERSON_CODE
                          , ""
                         , 0
                         , 0
                         , Convert.ToDecimal(TXT_PAY_NOW.Text)
                         , 0
                         , "من حساب الزبون الى حساب الصندوق"
                         , 1
                         , 1
                         , ref CLS.SUBMIT_FLAG
                          );

                        INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                      (
                        BoXId
                      , 4007
                      , ""
                      , 0
                      , 0
                      , 0
                      , Convert.ToDecimal(TXT_PAY_NOW.Text)
                      , "من حساب الزبون الى حساب المختبر"
                      , 1
                      , 1
                      , ref CLS.SUBMIT_FLAG
                       );

                    }

                    if (CLS.SUBMIT_FLAG==1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                       
                        LBL_TOTAL_WAIT.Text = "0";
                        LBL_PAID_WAIT.Text = "0";
                        LBL_REMAIN_WAIT.Text = "0";
                        LBL_REMAIN_AFT_WAIT.Text = "0";
                        TXT_PAY_NOW.Text = "0";
                        LBL_CODETEST.ClearText(); 
                        LBL_NAME.ClearText();
                       
                    }

                }

            }
        }
      

        private void BTN_PRINTWAIT_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PRINTER_NAME == string.Empty)
            {
                MessageBox.Show("حدد الطابعة أولا");
                SETTING.FRM_LIST_PRINTER FRM = new SETTING.FRM_LIST_PRINTER();
                FRM.ShowDialog();
                return;

            }

            if (MSG.Msg.MsgBoxResult("هل فعلا تريد الطباعة؟"))
            {
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                this.gET_L_RESULT_TEST_PRINTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_RESULT_TEST_PRINT, new System.Nullable<int>(((int)(System.Convert.ChangeType(LBL_CODETEST.Text, typeof(int))))));
                dt = this.mEDICAL_CLINIC_DBDataSet.GET_L_RESULT_TEST_PRINT;
                this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))));
                dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
                LocalReport lr = new LocalReport();

                lr.ReportEmbeddedResource = "MEDICALCLINIC.LAB.PRINT.RPT_LAB_PRINT.rdlc";
                lr.DataSources.Add(new ReportDataSource("DataSet1", dt));
                lr.DataSources.Add(new ReportDataSource("DataSet2", dt1));
                lr.Print();
                LBL_CODETEST.Text = string.Empty;
                LBL_NAME.Text = string.Empty;
            }
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          try
                {
            if (e.ColumnIndex==0)
            {
                    ID_MAIN_BOOK = dataGridView1.CurrentRow.Cells[6].Value.ToInt();
                    dOCTOR_NAMEComboBox.SelectedValue = dataGridView1.CurrentRow.Cells[7].Value.ToInt();
                    pERSON_NAMEComboBox.SelectedValue = dataGridView1.CurrentRow.Cells[8].Value.ToInt();
                    id_res = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
                    //id_res_de = Convert.ToInt32(dataGridView1.CurrentRow.Cells[9].Value);
                    this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DE, new System.Nullable<int>(((int)(System.Convert.ChangeType(id_res, typeof(int))))), "", new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))));
                    if (this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DE.Rows.Count>0)
                    {
                        BTN_FROM_DR_Click(null, null);
                        DGV_ALL_TEST.Rows.Clear();
                        for (int j = 0; j < this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DE.Rows.Count; j++)
                        {

                            DGV_ALL_TEST.Rows.Add(
                                          this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DE.Rows[j][0].ToString(),
                                          this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DE.Rows[j][1].ToString(),
                                          this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DE.Rows[j][2].ToString(),
                                          this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DE.Rows[j][3].ToString(),
                                          this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DE.Rows[j][7].ToString(),
                                          this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB_DE.Rows[j][8].ToString()
                                          );
                            LBL_TOTAL_PRICE.Text = DGV_ALL_TEST.Rows.Cast<DataGridViewRow>()
                                 .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                            LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
                          


                        }
                    }

            } 
            }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
        }

        private void BTN_GET_FOR_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_L_ALL_TEST_LAB_NOT_COMPELETE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_GETBYDATE_Click(object sender, EventArgs e)
        {
             this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(idperson, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), dateTimePicker1.Value);

        }

        private void gET_LAB_TEST_BY_CATEGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==18)
            {

                int FoodIndex = -1;

                for (int i = 0; i < DGV_ALL_TEST.Rows.Count; i++)
                {
                    if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString().Equals(DGV_ALL_TEST.Rows[i].Cells[0].Value.ToString()))
                        FoodIndex = i;

                }
                if (FoodIndex == -1)
                {
                    DGV_ALL_TEST.Rows.Add(
                                  gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString(),
                                  gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[1].Value.ToString(),
                                  gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[2].Value.ToString(),
                                  gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value.ToString(),""
                                  );
                    LBL_TOTAL_PRICE.Text = DGV_ALL_TEST.Rows.Cast<DataGridViewRow>()
                         .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                    LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
                    LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
                }
                else
                {
                    MessageBox.Show("التحليل موجود مسبقا");
                    return;
                }




              
            }
        }

        private void BTN_ADD_ONETEST_Click(object sender, EventArgs e)
        {
            int FoodIndex = -1;

            for (int i = 0; i < DGV_ALL_TEST.Rows.Count; i++)
            {
                if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString().Equals(DGV_ALL_TEST.Rows[i].Cells[0].Value.ToString()))
                    FoodIndex = i;

            }
            if (FoodIndex == -1)
            {
                DGV_ALL_TEST.Rows.Add(
                              gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString(),
                              gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[1].Value.ToString(),
                              gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[2].Value.ToString(),
                              gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value.ToString(),""
                              );
                LBL_TOTAL_PRICE.Text = DGV_ALL_TEST.Rows.Cast<DataGridViewRow>()
                     .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
                LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show("التحليل موجود مسبقا");
                return;
            }

        }

        private void BTN_ADD_ALLTESTS_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count; j++)
            {
               
               
                    DGV_ALL_TEST.Rows.Add(
                                  gET_LAB_TEST_BY_CATEGDataGridView.Rows[j].Cells[0].Value.ToString(),
                                  gET_LAB_TEST_BY_CATEGDataGridView.Rows[j].Cells[1].Value.ToString(),
                                  gET_LAB_TEST_BY_CATEGDataGridView.Rows[j].Cells[2].Value.ToString(),
                                  gET_LAB_TEST_BY_CATEGDataGridView.Rows[j].Cells[6].Value.ToString(),""
                                  );
                    LBL_TOTAL_PRICE.Text = DGV_ALL_TEST.Rows.Cast<DataGridViewRow>()
                         .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                    LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
                    LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
               

            }
        }

        private void BTN_DELETE_ONE_Click(object sender, EventArgs e)
        {
            

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    DGV_ALL_TEST.Rows.RemoveAt(DGV_ALL_TEST.CurrentRow.Index);
                    LBL_TOTAL_PRICE.Text = DGV_ALL_TEST.Rows.Cast<DataGridViewRow>()
                       .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                    LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
                }
            
        }

        private void DGV_ALL_TEST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    DGV_ALL_TEST.Rows.RemoveAt(DGV_ALL_TEST.CurrentRow.Index);
                    LBL_TOTAL_PRICE.Text = DGV_ALL_TEST.Rows.Cast<DataGridViewRow>()
                       .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                    LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
                }
            }
            else
             if (e.ColumnIndex == 6)
            {
            //حفظ رقم التسللي لجدول التحاليل ك رقم حجز في جدول الصور لكي يكون لكل تحليل صور خاص به ولا تكون عامة لكل الحجز
                if (id_res != 0)
                {
                    CHAT.FRM_SCANNER frm = new CHAT.FRM_SCANNER(id_res, 1);
                    frm.ShowDialog();
                }
            }
            }

        private void BTN_DELETE_ALL_Click(object sender, EventArgs e)
        {
           
             if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                { 
                
                DGV_ALL_TEST.Rows.Clear();
                LBL_TOTAL_PRICE.Text = DGV_ALL_TEST.Rows.Cast<DataGridViewRow>()
                   .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
                // for (int i = 0; i <= DGV_ALL_TEST.Rows.Count; i++)
                //{

                //        DGV_ALL_TEST.Rows.RemoveAt(DGV_ALL_TEST.Rows[i].Index);
                //        LBL_TOTAL_PRICE.Text = DGV_ALL_TEST.Rows.Cast<DataGridViewRow>()
                //           .Sum(t => Convert.ToDecimal(t.Cells[3].Value)).ToString();
                //        LBL_NUMBER_TEST.Text = DGV_ALL_TEST.Rows.Count.ToString();
                //    }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            greenTabList1.Invalidate();
            dateTimePicker2.Invalidate();
            dateTimePicker2.Refresh();
            tableLayoutPanel17.Refresh();
        }

        
        private void p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView_CheckedChanged(object sender, EventArgs e)
        { 
        if (p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.Rows.Count > 0)
                {
            foreach (DataGridViewRow row in p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                if (chk.Selected == true)
                {
                    chk.Selected = false;
                }
                else
                {
                    chk.Selected = true;
                }
               

                    

                        var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERTED.P_UPDATE_LAB_IS_COMPELETE_DET(
                        p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.CurrentRow.Cells[3].Value.ToInt(),
                        Convert.ToBoolean( chk),

                        ref CLS.SUBMIT_FLAG);

                     
                }
            }
        }
        private void p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.Rows.Count>0)
            {
  
            if (e.ColumnIndex == 8)
            {

                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                INSERTED.P_UPDATE_LAB_IS_COMPELETE_DET(
                p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.CurrentRow.Cells[3].Value.ToInt(), 
                !Convert.ToBoolean (p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.CurrentRow.Cells[8].Value),
                
                ref CLS.SUBMIT_FLAG);

            }
            }
          

        }

        private void BTN_COM_NOTDEL_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_L_ALL_TEST_LAB_NOT_COMPELETE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(4, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_DELEVERD_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_L_ALL_TEST_LAB_NOT_COMPELETE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(5, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            greenTabList1.Invalidate();
            greenTabList1.Refresh();
            dateTimePicker2.Invalidate();
            dateTimePicker2.Refresh();
            tableLayoutPanel17.Refresh();
            tableLayoutPanel17.Invalidate();
        }

        private void p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DET, new System.Nullable<int>(((int)(System.Convert.ChangeType(p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[7].Value, typeof(int))))), 1);
                    this.gET_DEBIT_BY_BCODE_ACODTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(15, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[11].Value.ToString(), typeof(int))))), 11, System.DateTime.Now, System.DateTime.Now, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));

                    LBL_TOTAL_WAIT.Text = this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][0].ToString();
                    LBL_PAID_WAIT.Text = this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][1].ToString();
                    LBL_REMAIN_WAIT.Text = this.mEDICAL_CLINIC_DBDataSet.GET_DEBIT_BY_BCODE_ACOD.Rows[0][2].ToString();

                    
                    LBL_NAME.Text = p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[1].Value.ToString();
                    LBL_CODETEST.Text = p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[7].Value.ToString();
                    LBL_PERSONCODE.Text = p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[11].Value.ToString();
                   // ISCOMPLET = Convert.ToBoolean( p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[12].Value);
                    ISDELVER = Convert.ToBoolean( p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[13].Value);
                    ID_BOOK = p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[8].Value.ToInt();
                    //id_res = p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[7].Value.ToInt();
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else
             if (e.ColumnIndex == 16)
            {
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {
                    var DELE = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    DELE.P_DELETE_T_LABTEST(p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[7].Value.ToInt(), 0, ref CLS.SUBMIT_FLAG);
                }
            }
            else
            if (e.ColumnIndex == 13)
            {
                bool ISTATE;
                this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

                if ((bool)this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentCell.Value == true)
                {
                    ISTATE = true;

                }
                else
                {
                    ISTATE = false;

                }

                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                INSERTED.P_UPDATE_LAB_IS_DELEVERD(
                p_GET_L_ALL_TEST_LAB_NOT_COMPELETEDataGridView.CurrentRow.Cells[7].Value.ToInt(),
                true,
                ISTATE,
                0,
                ref CLS.SUBMIT_FLAG);

            }

        }

        

        private void p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15)
            {

                CHAT.FRM_SCANNER frm = new CHAT.FRM_SCANNER(p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.CurrentRow.Cells[7].Value.ToInt(), 1);
                frm.ShowDialog();
            }
            else
            if (e.ColumnIndex == 0)
            {

                p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.CurrentRow.Cells[3].Value = p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.CurrentRow.Cells[10].Value ;


            }
            else
            if (e.ColumnIndex == 9  )
            {
                bool ISTATE;
                this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

            if ((bool)this.p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.CurrentCell.Value == true)
            {
                               ISTATE = true;
               
            }
            else
            {
                                 ISTATE = false;
              
            }
               
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                INSERTED.P_UPDATE_LAB_IS_COMPELETE_DET(
                p_GET_L_ALL_TEST_LAB_NOT_COMPELETE_DETDataGridView.CurrentRow.Cells[4].Value.ToInt(),
                ISTATE,
                ref CLS.SUBMIT_FLAG);

            }


        }

        

        private void gET_LAB_TEST_BY_CATEGDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 16)
            //{
            //    if (ID_MAIN_BOOK != 0)
            //    {
            //        CHAT.FRM_SCANNER frm = new CHAT.FRM_SCANNER(ID_MAIN_BOOK,1);
            //        frm.ShowDialog();
            //    }
            //    else 
            //    {
            //        MessageBox.Show("يرجى اختيار اسم المريض اولا من قائمة التحاليل");
            //        return;
            //    }


            //}

            //else
            //if (e.ColumnIndex==17)
            //{

            //    gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value = gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[5].Value.ToString();

            //}
        }

        
      
      
       
        private void BTN_GETCASH_CUSTOMER_Click(object sender, EventArgs e)
        {
            
                try
                {

                    //this.gET_DR_NAME_CASH_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DR_NAME_CASH_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType("", typeof(int))))), ref CLS.SUBMIT_FLAG);
                    //DR_CODE = this.mEDICAL_CLINIC_DBDataSet.GET_DR_NAME_CASH_FOR_LAB.Rows[0][0].ToInt();
                    //this.gET_PERSON_NAME_CASH_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_NAME_CASH_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType("", typeof(int))))), ref CLS.SUBMIT_FLAG);
                    //PERSON_CODE = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_NAME_CASH_FOR_LAB.Rows[0][0].ToInt();
                LAB_TYPE = 1;
                BTN_GETCASH_CUSTOMER.BackColor = Color.Red;
                BTN_FROM_DR.BackColor = Color.FromArgb(0, 94, 170);

            }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            

          

               
        }

       

        private void BTN_ADD_DOCT_Click(object sender, EventArgs e)
        {
            ACTIVR_F = true;
           DOCTOR.FRM_DOCTOR FRM = new DOCTOR.FRM_DOCTOR(); FRM.ShowDialog();

        }

        private void nAME_CATEGComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (nAME_CATEGComboBox.SelectedIndex>-1)
                {
                    this.gET_L_TEST_NAMECODE_BYCATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAMECODE_BYCATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox.SelectedValue, typeof(int))))));

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_LAB_TEST_BY_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_TEST_BY_CATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType( 2 , typeof(int))))));
            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                int DRCODE, PERSONCODE;
                String strCompare = "";
                if (DGV_ALL_TEST.Rows.Count < 1)
                {
                    MessageBox.Show("يرجى أختيار تحليل اولا", CLS.TITEL_MESG);
                    return;
                }
                if (LBL_TOTAL_PRICE.Text.ToDecimal() > 0)
                {
                    if (FLAG_PAY == 0)
                    {
                        MessageBox.Show("يرجى أختيار نوع الدفع اولا", CLS.TITEL_MESG);
                        return;
                    }
                }
                if (LBL_TOTAL_PRICE.Text==String.Empty)
                {
                    LBL_TOTAL_PRICE.Text = "0";
                }
                if (LBL_PAID_WAIT.Text==String.Empty)
                {
                    LBL_PAID_WAIT.Text = "0";
                }
                if (LBL_REMAIN.Text==String.Empty)
                {
                    LBL_REMAIN.Text = "0";
                }
                 
                var INSERTED_D = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED_PER = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();





                if (LAB_TYPE == 1)
                /*  if (dataGridView1.Rows.Count <= 0)*/
                {

                    if (pERSON_NAMEComboBox.SelectedIndex == -1)
                    {

                        var INSERTEDP = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        INSERTEDP.P_INSERT_T_PERSON
                           (
                             0
                           , ref CLS.CLIENT_CODE_PER
                           , pERSON_NAMEComboBox.Text
                           , 0
                           , Convert.ToInt32(sEX_NAMEComboBox.SelectedValue)
                           , aGETextBox.Text
                           , TXT_PHONE.Text
                           , ""
                           , null
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , ""
                           , 0
                           , ""
                           , false
                           , ref CLS.SUBMIT_FLAG);
                    }
                    else
                    {

                        CLS.CLIENT_CODE_PER = pERSON_NAMEComboBox.SelectedValue.ToInt();
                    }

                    this.gET_DR_NAME_CASH_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DR_NAME_CASH_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), ref CLS.SUBMIT_FLAG);
                    CLS.CLIENT_CODE_DR = 0; //this.mEDICAL_CLINIC_DBDataSet.GET_DR_NAME_CASH_FOR_LAB.Rows[0][0].ToInt();
                    INSERTED.P_INSERT_T_DOCTOR(
                          CLS.CHEECK_CODE
                        , ref CLS.CLIENT_CODE_DR
                        , dOCTOR_NAMEComboBox.Text
                        , ""
                        , ""
                        , ""
                        , ""
                        , ""
                        , ""
                        , 0
                        , 0
                        , 0
                        , 0
                        , 0
                        , 0
                        , false
                        , 0
                        , 2
                        , ref CLS.SUBMIT_FLAG);

                    //if (ISCOMP == 1)
                    //{
                    id_res = int.Parse(INSERTED.P_INSERT_L_RESTESTNAME(
                   CLS.USER_CODE
                 , CLS.CLIENT_CODE_DR
                 , 0
                 , dateTimePicker1.Value
                 , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                 , CLS.CLIENT_CODE_PER
                 , false
                 , false
                 , Convert.ToInt32(iD_LABLabel1.Text)
                 , TXT_NOTE.Text
                 ,1
                 , ref CLS.SUBMIT_FLAG).ToString()
                 );

                    for (int i = 0; i < DGV_ALL_TEST.Rows.Count; i++)
                    {
                        //if (DGV_ALL_TEST.Rows[i].Cells[4].Value.ToString() != "")
                        //{

                        INSERTED_D.P_INSERT_L_RESTESTNAME_DETAILS(
                        Convert.ToInt32(DGV_ALL_TEST.Rows[i].Cells[0].Value)
                      , ""
                      , Convert.ToDecimal(DGV_ALL_TEST.Rows[i].Cells[3].Value)
                      , ""//DGV_ALL_TEST.Rows[i].Cells[4].Value.ToString()
                      , false
                      , id_res
                      , ref CLS.SUBMIT_FLAG
                       );
                        //}
                    }
                    //}
                    //else
                    //if (ISCOMP == 2)
                    //{
                    //   id_res = int.Parse(INSERTED.P_INSERT_L_RESTESTNAME(
                    //   CLS.USER_CODE
                    // , CLS.CLIENT_CODE_DR
                    // , 0
                    // , dateTimePicker1.Value
                    // , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                    // , CLS.CLIENT_CODE_PER
                    // , true
                    // , false
                    // , Convert.ToInt32(iD_LABLabel1.Text)
                    // , TXT_NOTE.Text
                    // , ref CLS.SUBMIT_FLAG).ToString());

                    //    for (int i = 0; i < gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count; i++)
                    //    {
                    //        if (gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value.ToString() != "")
                    //        {

                    //            INSERTED_D.P_INSERT_L_RESTESTNAME_DETAILS(
                    //            Convert.ToInt32(gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[0].Value)
                    //          , gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value.ToString()
                    //          , Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[6].Value)
                    //          , gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[10].Value.ToString()
                    //          , false
                    //          , id_res
                    //          , ref CLS.SUBMIT_FLAG
                    //           );
                    //        }
                    //    }
                    //}




                }
                else
                if (LAB_TYPE == 2)
                {
                    CLS.CLIENT_CODE_PER = pERSON_NAMEComboBox.SelectedValue.ToInt();
                    CLS.CLIENT_CODE_DR = dOCTOR_NAMEComboBox.SelectedValue.ToInt();

                    //    if (ISCOMP == 1)
                    //    {
                    //        for (int i = 0; i < gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count; i++)
                    //        {
                    //            //bool test_empty = true;

                    //            //if (gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value == null)
                    //            //{
                    //            //    test_empty = false;

                    //            //}

                    //            //else

                    //            //  if (string.IsNullOrEmpty(gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value.ToString()))
                    //            //{

                    //            //    test_empty = false;

                    //            //}
                    //            //else
                    //            //  if (gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value.ToString() == "")
                    //            //{
                    //            //    test_empty = false;
                    //            //}

                    //            if (gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value.ToString() != "")

                    //            {
                    //                strCompare = gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[1].Value.ToString();
                    //                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    //                {
                    //                    if (strCompare.Equals(dataGridView1.Rows[j].Cells[3].Value.ToString())&& dataGridView1.Rows[j].Cells[12].Value.ToInt()==pERSON_NAMEComboBox.SelectedValue.ToInt())
                    //                    {
                    //                        id_res = Convert.ToInt32(dataGridView1.Rows[j].Cells[1].Value);
                    //                        id_res_de = Convert.ToInt32(dataGridView1.Rows[j].Cells[9].Value);


                    //                        INSERTED_D.P_UPDATE_L_RESTESTNAME_DETAILS(
                    //                          id_res_de
                    //                        , gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value.ToString()
                    //                        , Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[6].Value)
                    //                        , gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[10].Value.ToString()
                    //                        , true
                    //                        , ref CLS.SUBMIT_FLAG
                    //                         );
                    //                    }
                    //                }
                    //            }


                    //            INSERTED.P_UPDATE_L_RESTESTNAME(
                    //            id_res
                    //          , CLS.USER_CODE
                    //          , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                    //          , false
                    //          , true
                    //          , ref CLS.SUBMIT_FLAG);


                    //        }
                    //    }
                    //    else
                    //      if (ISCOMP == 2)
                    //    {
                    //        for (int i = 0; i < gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count; i++)
                    //        {
                    //            //bool test_empty = true;

                    //            //if (gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value == null)
                    //            //{
                    //            //    test_empty = false;

                    //            //}

                    //            //else

                    //            //  if (string.IsNullOrEmpty(gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value.ToString()))
                    //            //{

                    //            //    test_empty = false;

                    //            //}
                    //            //else
                    //            //  if (gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value.ToString() == "")
                    //            //{
                    //            //    test_empty = false;
                    //            //}

                    //            if (gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[4].Value.ToString() != "")
                    //            {
                    //                strCompare = gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[1].Value.ToString();
                    //                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    //                {
                    //                    if (strCompare.Equals(dataGridView1.Rows[j].Cells[3].Value.ToString()) && dataGridView1.Rows[j].Cells[12].Value.ToInt() == pERSON_NAMEComboBox.SelectedValue.ToInt())
                    //                    {
                    //                        id_res = Convert.ToInt32(dataGridView1.Rows[j].Cells[1].Value);
                    //                        id_res_de = Convert.ToInt32(dataGridView1.Rows[j].Cells[9].Value);



                    //                    }
                    //                }
                    //            }


                    INSERTED.P_UPDATE_L_RESTESTNAME(
                    id_res
                  , CLS.USER_CODE
                  , Convert.ToDecimal(LBL_TOTAL_PRICE.Text)
                  , false
                  , false
                  , ref CLS.SUBMIT_FLAG
                  , 1);

                    for (int i = 0; i < DGV_ALL_TEST.Rows.Count; i++)
                    {
                        INSERTED_D.P_UPDATE_L_RESTESTNAME_DETAILS(
                          DGV_ALL_TEST.Rows[i].Cells[5].Value.ToInt()
                        , ""
                        , Convert.ToDecimal(DGV_ALL_TEST.Rows[i].Cells[3].Value)
                        , DGV_ALL_TEST.Rows[i].Cells[4].Value.ToString()
                        , false
                        , ref CLS.SUBMIT_FLAG
                         );
                    }

                    //        }
                    //    }

                    //}


                }

                    //----------------------------
                    try
                    {

                         


                    if (LBL_TOTAL_PRICE.Text.ToDecimal()>0)
                    {

                  
                        //int? BILL_num = -1;
                        //string SANAD_DISCRIPTION = "\\من ح/ " + pERSON_NAMEComboBox.Text + " الى ح/   العمليات";
                        //var GET_BILL_ID = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //GET_BILL_ID.P_GET_BILL_NUMBER(15, Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), ref BILL_num);

                        var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //  string ServiceAccount = "", DoctorAccount = "", PatientAccount = "";
                        int BookIdS;
                        decimal DoctorPrecentage = 0;
                        decimal DebitPatient = 0;
                        decimal TOTAL_PRICE = Convert.ToDecimal(LBL_TOTAL_PRICE.Text);
                        decimal CreditService = 0;
                        decimal CreditDoctor = 0;

                        if (DoctorPrecentage > 0)
                        {



                            DebitPatient = TOTAL_PRICE;
                            CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                            CreditService = TOTAL_PRICE - CreditDoctor;



                            BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                        id_res
                                      , System.DateTime.Now
                                      , "عن اجور تحليل "
                                      , 15
                                      , 0
                                      , true
                                      , CLS.USER_CODE
                                      , ref CLS.SUBMIT_FLAG
                                      , CLS.BRANCH_ID
                                      , 11
                                      ).ToString());

                            if (FLAG_PAY == 1)
                            {
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , 111
                                                , " اجور تحليل"
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
                                  BookIdS
                                , CLS.CLIENT_CODE_PER
                                , " اجور تحليل"
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
                                   BookIdS
                                 , CLS.CLIENT_CODE_PER
                                  , " اجور تحليل"
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
                                BookIdS
                              , CLS.CLIENT_CODE_DR
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
                                 BookIdS
                               , 4007
                               , " اجور تحليل"
                               , 0
                               , 0
                               , 0
                               , CreditService
                               , "من حساب الزبون الى حساب المختبر"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );











                            }
                            if (FLAG_PAY == 2)
                            {
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , CLS.CLIENT_CODE_PER
                                                , " اجور  عملية"
                                                , 0
                                                , 0
                                                , DebitPatient
                                                , 0
                                                , "من حساب الزبون الى حساب المختبر"
                                                , 1
                                                , 1
                                                , ref CLS.SUBMIT_FLAG
                                                 );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BookIdS
                                , 4007
                                 , " اجور تحليل"
                                , 0
                                , 0
                                , 0
                                , CreditService
                                , "من حساب الزبون الى حساب المختبر"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                           (
                             BookIdS
                           , CLS.CLIENT_CODE_DR
                            , " اجور  مختبر"
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
                            if (FLAG_PAY == 3)
                            {
                                //جزء النقدي من الجزئي
                                DoctorPrecentage = 0;
                                TOTAL_PRICE = Convert.ToDecimal(TXT_PAID.Text);
                                DebitPatient = 0;
                                CreditService = 0;
                                CreditDoctor = 0;

                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditService = TOTAL_PRICE - CreditDoctor;

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , 111
                                                , " اجور تحليل"
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
                                  BookIdS
                                , CLS.CLIENT_CODE_PER
                                 , " اجور تحليل"
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
                                   BookIdS
                                 , CLS.CLIENT_CODE_PER
                                  , " اجور تحليل"
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
                                BookIdS
                              , CLS.CLIENT_CODE_DR
                               , " اجور تحليل"
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
                                 BookIdS
                               , 4007
                               , " اجور  عملية"
                               , 0
                               , 0
                               , 0
                               , CreditService
                               , "من حساب الزبون الى حساب المختبر"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );


                                //الجزء الاجل من الجزئي


                                DoctorPrecentage = 0;
                                TOTAL_PRICE = Convert.ToDecimal(LBL_REMAIN.Text);
                                DebitPatient = 0;
                                CreditService = 0;
                                CreditDoctor = 0;

                                DebitPatient = TOTAL_PRICE;
                                CreditDoctor = TOTAL_PRICE * DoctorPrecentage / 100;
                                CreditService = TOTAL_PRICE - CreditDoctor;

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , CLS.CLIENT_CODE_PER
                                                , " اجور تحليل"
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
                                BookIdS
                              , CLS.CLIENT_CODE_DR
                               , " اجور تحليل"
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
                                 BookIdS
                               , 4007
                               , " اجور  عملية"
                               , 0
                               , 0
                               , 0
                               , CreditService
                               , "من حساب الزبون الى حساب المختبر"
                               , 1
                               , 1
                               , ref CLS.SUBMIT_FLAG
                                );







                            }
                        }
                        else
                        if (DoctorPrecentage == 0)
                        {



                            BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                                        id_res
                                      , System.DateTime.Now
                                      , " اجور المختبر "
                                      , 15
                                      , 0
                                      , true
                                      , CLS.USER_CODE
                                      , ref CLS.SUBMIT_FLAG
                                      , CLS.BRANCH_ID
                                      , 11
                                      ).ToString());

                            if (FLAG_PAY == 1)
                            {
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , 111
                                                , " اجور عملية"
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
                                  BookIdS
                                , CLS.CLIENT_CODE_PER
                                 , " اجور مختبر"
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
                                   BookIdS
                                 , CLS.CLIENT_CODE_PER
                                  , " اجور  مختبر"
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
                                BookIdS
                              , 4007
                              , " اجور مختبر"
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
                            if (FLAG_PAY == 2)
                            {
                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                                (
                                                 BookIdS
                                                , CLS.CLIENT_CODE_PER
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
                             BookIdS
                           , 4007
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
                            if (FLAG_PAY == 3)
                            {



                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                 (
                                   BookIdS
                                 , CLS.CLIENT_CODE_PER
                                  , " اجور مختبر"
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
                                BookIdS
                              , 4007
                               , " اجور مختبر"
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
                                                BookIdS
                                               , 111
                                               , " اجور مختبر"
                                               , 0
                                               , 0
                                               , Convert.ToDecimal(TXT_PAID.Text)
                                               , 0
                                               , "من حساب الزبون الى حساب الصندوق"
                                               , 1
                                               , 1
                                               , ref CLS.SUBMIT_FLAG
                                                );

                                //TO

                                INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                                (
                                  BookIdS
                                , 4007
                                , " اجور مختبر"
                                , 0
                                , 0
                                , 0
                                , Convert.ToDecimal(TXT_PAID.Text)
                                , "من حساب الزبون الى حساب الصندوق"
                                , 1
                                , 1
                                , ref CLS.SUBMIT_FLAG
                                 );






                            }
                        }

  }




                      
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }








                    //-------------





                    //this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(-1, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), dateTimePicker1.Value);

                    //nAME_CATEGComboBox_SelectedIndexChanged(null, null);
                    //nAME_CATEGComboBox.SelectedIndex = -1;
                    //int SEXSTATE = -1;

                    //if (sEX_NAMETextBox.Text == "انثى")
                    //{
                    //    SEXSTATE = 2;
                    //}
                    //else
                    //{
                    //    SEXSTATE = 1;
                    //}

                    //if (dOCTOR_NAMEComboBox.Text == "Dr.Lab.cash" || pERSON_NAMEComboBox.Text == "CCCCC")
                    //{

                    //    INSERTED_PER.P_UPDATE_T_PERSON_DOCTOR_CASH_LABRAY(
                    //       Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue),
                    //       TXT_PATIENT.Text,
                    //       Convert.ToInt32(dOCTOR_CODETextBox.Text),
                    //       TXT_DOCTOR.Text,
                    //       SEXSTATE,
                    //       aGETextBox.Text,
                    //       ref CLS.SUBMIT_FLAG

                    //    );
                    //}

                    if (CLS.SUBMIT_FLAG == 1)
                    {

                         
                         CLS.TIMER_BORROW = 1;
                         pERSON_NAMEComboBox.SelectedIndex = -1;
                         dOCTOR_NAMEComboBox.SelectedIndex = -1;
                         BTN_CASH.BackColor = Color.FromArgb(0, 94, 170);
                         BTN_NO_CASH.BackColor = Color.FromArgb(0, 94, 170);
                         BTN_PARTIAL_CASH.BackColor = Color.FromArgb(0, 94, 170);
                         FLAG_PAY = 0;
                         LBL_REMAIN.Text = "0";
                         LBL_TOTAL_PRICE.Text = "0";
                         TXT_PAID.Text = "0";
                        LBL_NUMBER_TEST.Text = "0";
                        //ISCOMP = -1;
                        //BTN_INCOMP.BackColor = Color.FromArgb(0, 94, 170);
                        //BTN_COMP.BackColor = Color.FromArgb(0, 94, 170);
                        //if (Properties.Settings.Default.LABTYPE == 3)
                        //{
                        DGV_ALL_TEST.Rows.Clear();
                        if (Properties.Settings.Default.LABTYPE == 1)
                        {
                            LAB_TYPE = 1;
                            BTN_GETCASH_CUSTOMER.BackColor = Color.Red;
                            BTN_FROM_DR.BackColor = Color.FromArgb(0, 94, 170);
                        }
                        else
                        if (Properties.Settings.Default.LABTYPE == 2)
                        {
                            LAB_TYPE = 2;
                            BTN_FROM_DR.BackColor = Color.Red;
                            BTN_GETCASH_CUSTOMER.BackColor = Color.FromArgb(0, 94, 170);
                        }
                        //}
                        MSG.Msg.Alart(AlartType.Save);


                        //if (dataGridView1.Rows.Count > 0)
                        //{

                        //    var UPDT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                        //    UPDT.P_UPDATE_T_BOOKING_BACKFROMWAIT(Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value), ref CLS.SUBMIT_FLAG);

                        //}

                        // ((OPERATION_PP.FRM_ALL_OPERTION_PRICE)Application.OpenForms["FRM_ALL_OPERTION_PRICE"]).p_GET_PRICE_OPERTION_BY_GRIDDataGridView.DataSource = this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PRICE_OPERTION_BY_GRID, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.DOCTOR_CODE_ADD_IMG, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(CLS.F_DATE_PRT, typeof(System.DateTime))))));

                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }


          
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }



            private void gET_LAB_TEST_BY_CATEGDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{

            //    //if (gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count > 0)
            //    //{
            //        if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == null ||
            //        gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == ""||
            //        //int. gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value ||
            //        gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value == DBNull.Value || 
            //        (String.IsNullOrWhiteSpace(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString())))

            //        {
                       
            //            gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell = gET_LAB_TEST_BY_CATEGDataGridView.Rows[gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Index].Cells[4];

            //            FLAGR_EMPTY = 1;
            //            //gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Selected = true;
            //           // gET_LAB_TEST_BY_CATEGDataGridView.BeginEdit(true);
            //        }
            //        else
            //        {
            //            FLAGR_EMPTY = 2;
            //            DECREMENTPRICE = Convert.ToDecimal(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[6].Value);

            //            //if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value != null || gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString() != "")
            //            //{
            //            //  DataGridViewCell cellQty = gET_LAB_TEST_BY_CATEGDataGridView.Rows[gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Index].Cells[4];
            //            //  gET_LAB_TEST_BY_CATEGDataGridView.CurrentCell = cellQty;
            //            gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Selected = true;
            //            gET_LAB_TEST_BY_CATEGDataGridView.BeginEdit(true);

            //            //}
            //        }
            //  //  }
            //}
            //catch(Exception EX)
            //{
            //    MessageBox.Show(EX.Message);
            //}

        }


    }
}
