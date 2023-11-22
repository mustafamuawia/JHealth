using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_KSHFIA_TYPE : Form
    {
       // int BIT_STATE = -1;

        public FRM_KSHFIA_TYPE()
        {
            InitializeComponent();
        }
        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.

            try
            {
                this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        int IS_PAY, IS_NO_PAY;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (R_NO_PAID.Checked == false && R_PAID.Checked == false)
                {
                    MessageBox.Show("رجاءا حدد نوع الكشفيه اولا ثم اعد المحاولة");
                    return;
                }
                if ( R_PAID.Checked == true )
                {
                    //LBL_TOTALL.Text = ":مجموع الكشفية";
                    //LBL_PAID.Visible = true;
                    //LBL_PAIDL.Visible = true;
                    //LBL_NO_PAID.Visible = true;
                    //LBL_NO_PAIDL.Visible = true;
                    IS_PAY = 0;
                    IS_NO_PAY = 0;
                    LBL_T_CREDIT.Text = "0.00";
                    dataGridView2.DataSource = null;
                    this.p_GET_BOOKING_BY_KSHFIA_TTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_KSHFIA_T , new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                    dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_KSHFIA_T;
                    
                 
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == true)
                        {
                            LBL_T_CREDIT.Text = (Convert.ToDecimal(dataGridView2.Rows[i].Cells[12].Value) + Convert.ToDecimal(LBL_T_CREDIT.Text)).ToString();

                            IS_PAY++;
                        }
                        else if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == false)
                        {

                            IS_NO_PAY++;
                        }
                    }
                    LBL_PAID.Text = IS_PAY.ToString();
                    LBL_NO_PAID.Text = IS_NO_PAY.ToString();
                    LBL_FIANL_NUMB.Text = (Convert.ToInt32(LBL_PAID.Text) + Convert.ToInt32(LBL_NO_PAID.Text)).ToString();
                }
                else
                    if (R_NO_PAID .Checked == true)
                    {
                        LBL_TOTALL.Text = ":مجموع الكشفية";
                        LBL_PAID.Visible = true;
                        LBL_PAIDL.Visible = true;
                        LBL_NO_PAID.Visible = true;
                        LBL_NO_PAIDL.Visible = true;
                        IS_PAY = 0;
                        IS_NO_PAY = 0;
                        LBL_T_CREDIT.Text = "0.00";
                        dataGridView2.DataSource = null;
                        this.p_GET_BOOKING_BY_KSHFIA_TTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_KSHFIA_T, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
                        dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_KSHFIA_T;
                      
                        for (int i = 0; i < dataGridView2.RowCount; i++)
                        {
                            if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == true)
                            {
                                LBL_T_CREDIT.Text = (Convert.ToDecimal(dataGridView2.Rows[i].Cells[12].Value) + Convert.ToDecimal(LBL_T_CREDIT.Text)).ToString();

                                IS_PAY++;
                            }
                            else if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == false)
                            {

                                IS_NO_PAY++;
                            }
                        }
                        LBL_PAID.Text = IS_PAY.ToString();
                        LBL_NO_PAID.Text = IS_NO_PAY.ToString();
                    }

              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      

       

       
     
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                
                dataGridView2.DataSource = null;
                IS_PAY = 0;
                IS_NO_PAY = 0;
                LBL_T_CREDIT.Text = "0.00";
                this.p_GET_BOOKING_BY_OPERATION_TTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_OPERATION_T, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(true, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))));
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_OPERATION_T;
                
                //LBL_TOTALL.Text = ":مجموع العمليات";
                //LBL_PAID.Visible = false;
                //LBL_PAIDL.Visible = false;
                //LBL_NO_PAID.Visible = false;
                //LBL_NO_PAIDL.Visible = false;
               // LBL_T_CREDIT.Text =
               //(from DataGridViewRow row in dataGridView2.Rows
               // where row.Cells[12].FormattedValue.ToString() != string.Empty
               // select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == true)
                    {
                       LBL_T_CREDIT.Text = (Convert.ToDecimal(dataGridView2.Rows[i].Cells[12].Value) + Convert.ToDecimal(LBL_T_CREDIT.Text)).ToString();

                        IS_PAY++;
                    }
                    else if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == false)
                    {

                        IS_NO_PAY++;
                    }
                }
                LBL_PAID.Text = IS_PAY.ToString();
                LBL_NO_PAID.Text = IS_NO_PAY.ToString();
                LBL_FIANL_NUMB.Text = (Convert.ToInt32(LBL_PAID.Text) + Convert.ToInt32(LBL_NO_PAID.Text)).ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       
       

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (R_NO_PAID.Checked == false && R_PAID.Checked == false)
                {
                    MessageBox.Show("رجاءا حدد نوع الكشفيه اولا ثم اعد المحاولة");
                    return;
                }
                if (R_PAID.Checked == true)
                {
                    //LBL_TOTALL.Text = ":مجموع الكشفية";
                    //LBL_PAID.Visible = true;
                    //LBL_PAIDL.Visible = true;
                    //LBL_NO_PAID.Visible = true;
                    //LBL_NO_PAIDL.Visible = true;
                    IS_PAY = 0;
                    IS_NO_PAY = 0;
                    LBL_T_CREDIT.Text = "0.00";
                    dataGridView2.DataSource = null;
                    this.p_GET_BOOKING_BY_KSHFIA_TOW_DTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_KSHFIA_TOW_D, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE2.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE2.Value, typeof(System.DateTime))))));
                    dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_KSHFIA_TOW_D;
                   
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == true)
                        {
                            LBL_T_CREDIT.Text = (Convert.ToDecimal(dataGridView2.Rows[i].Cells[12].Value) + Convert.ToDecimal(LBL_T_CREDIT.Text)).ToString();

                            IS_PAY++;
                        }
                        else if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == false)
                        {

                            IS_NO_PAY++;
                        }
                    }
                    LBL_PAID.Text = IS_PAY.ToString();
                    LBL_NO_PAID.Text = IS_NO_PAY.ToString();
                    LBL_FIANL_NUMB.Text = (Convert.ToInt32(LBL_PAID.Text) + Convert.ToInt32(LBL_NO_PAID.Text)).ToString();
                }
                else
                    if (R_NO_PAID.Checked == true)
                    {
                        LBL_TOTALL.Text = ":مجموع الكشفية";
                        LBL_PAID.Visible = true;
                        LBL_PAIDL.Visible = true;
                        LBL_NO_PAID.Visible = true;
                        LBL_NO_PAIDL.Visible = true;
                        IS_PAY = 0;
                        IS_NO_PAY = 0;
                        LBL_T_CREDIT.Text = "0.00";
                        dataGridView2.DataSource = null;
                        this.p_GET_BOOKING_BY_KSHFIA_TOW_DTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_KSHFIA_TOW_D, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE2.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE2.Value, typeof(System.DateTime))))));
                        dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_KSHFIA_TOW_D;
                        dataGridView2.Columns[7].Visible = false;
                        dataGridView2.Columns[8].Visible = false;
                        dataGridView2.Columns[9].Visible = false;
                        dataGridView2.Columns[1].Width = 200;
                        for (int i = 0; i < dataGridView2.RowCount; i++)
                        {
                            if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == true)
                            {
                                LBL_T_CREDIT.Text = (Convert.ToDecimal(dataGridView2.Rows[i].Cells[12].Value) + Convert.ToDecimal(LBL_T_CREDIT.Text)).ToString();

                                IS_PAY++;
                            }
                            else if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == false)
                            {

                                IS_NO_PAY++;
                            }
                        }
                        LBL_PAID.Text = IS_PAY.ToString();
                        LBL_NO_PAID.Text = IS_NO_PAY.ToString();
                    }


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView2.DataSource = null;
                IS_PAY = 0;
                IS_NO_PAY = 0;
                LBL_T_CREDIT.Text = "0.00";
                this.p_GET_BOOKING_BY_OPERATION_TOW_DATETableAdapter .Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_OPERATION_TOW_DATE 
                    , new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int)))))
                    , new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int)))))
                    , new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime)))))
                    , new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))));
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_OPERATION_TOW_DATE;

                //LBL_TOTALL.Text = ":مجموع العمليات";
                //LBL_PAID.Visible = false;
                //LBL_PAIDL.Visible = false;
                //LBL_NO_PAID.Visible = false;
                //LBL_NO_PAIDL.Visible = false;
               // LBL_T_CREDIT.Text =
               //(from DataGridViewRow row in dataGridView2.Rows
               // where row.Cells[12].FormattedValue.ToString() != string.Empty
               // select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
               for (int i = 0; i < dataGridView2.RowCount; i++)
               {
                   if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == true)
                   {
                       LBL_T_CREDIT.Text = (Convert.ToDecimal(dataGridView2.Rows[i].Cells[12].Value) + Convert.ToDecimal(LBL_T_CREDIT.Text)).ToString();

                       IS_PAY++;
                   }
                   else if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[13].Value) == false)
                   {

                       IS_NO_PAY++;
                   }
               }
               LBL_PAID.Text = IS_PAY.ToString();
               LBL_NO_PAID.Text = IS_NO_PAY.ToString();
               LBL_FIANL_NUMB.Text = (Convert.ToInt32(LBL_PAID.Text) + Convert.ToInt32(LBL_NO_PAID.Text)).ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    




    }
}
