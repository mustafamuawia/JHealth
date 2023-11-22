using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_PROFIT : Form
    {

        public FRM_PROFIT()
        {
            InitializeComponent();
        }
        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_ITEM' table. You can move, or remove it, as needed.
            this.v_GET_A_ITEMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_ITEM);
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
     decimal? PRICEC=0;
         int? NUM=0;
            DataTable DT=new DataTable ();
            var INSERTED_ORDER = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
       
          // INSERTED_ORDER.GET_PP_T_PPURCHES (ref PRICEC, NUM )  ;
         //  textBox1.Text = PRICEC.ToString();

            {
                
            }
            //try
            //{
            //    IS_PAY = 0;
            //    IS_NO_PAY = 0;
            //    this.p_GET_BOOKING_BY_DOC_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DOC_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))));
            //    dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DOC_RPT;
            //    dataGridView2.Columns[7].Visible = false;
            //    dataGridView2.Columns[8].Visible = false;
            //    dataGridView2.Columns[9].Visible = false;
            //    dataGridView2.Columns[1].Width = 200;

            //    for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            //    {
            //        if (Convert.ToInt32(dataGridView2.Rows[i].Cells[13].Value) == 1)
            //        {
            //            //    LBL_T_CREDIT.Text =
            //            //(from DataGridViewRow row in dataGridView2.Rows
            //            // where row.Cells[13].FormattedValue.ToString() != string.Empty
            //            // select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
            //            IS_PAY++;
            //        }
            //        else if (Convert.ToInt32(dataGridView2.Rows[i].Cells[13].Value) == 0)
            //        {

            //            IS_NO_PAY++;
            //        }
            //    }



            //    LBL_PAID.Text = IS_PAY.ToString();
            //    LBL_NO_PAID.Text = IS_NO_PAY.ToString();

            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

       // private void button3_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        IS_PAY = 0;
        //        IS_NO_PAY = 0;
        //        dataGridView2.DataSource = null;
        //        this.p_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DOC_TOW_D_RPT, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))));
        //        dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DOC_TOW_D_RPT;
        //        dataGridView2.Columns[7].Visible = false;
        //        dataGridView2.Columns[8].Visible = false;
        //        dataGridView2.Columns[9].Visible = false;
        //        dataGridView2.Columns[1].Width = 200;
        //        for (int i = 0; i < dataGridView2.RowCount; i++)
        //        {
        //            if (Convert.ToInt32(dataGridView2.Rows[i].Cells[13].Value) == 1)
        //            {
        //                //    LBL_T_CREDIT.Text =
        //                //(from DataGridViewRow row in dataGridView2.Rows
        //                // where row.Cells[13].FormattedValue.ToString() != string.Empty
        //                // select Convert.ToDouble(row.Cells[12].FormattedValue)).Sum().ToString();
        //                IS_PAY++;
        //            }
        //            else if (Convert.ToInt32(dataGridView2.Rows[i].Cells[13].Value) == 0)
        //            {

        //                IS_NO_PAY++;
        //            }
        //        }
        //        LBL_PAID.Text = IS_PAY.ToString();
        //        LBL_NO_PAID.Text = IS_NO_PAY.ToString();
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }
        //}




        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //PRINT.PROFIT.FRM_PROFIT FRM = new PRINT.PROFIT.FRM_PROFIT(F_DATE.Value.Date
            //    , E_DATE.Value.Date,checkBox1.Checked,comboBox1.SelectedValue.ToString());
            //FRM.ShowDialog();
        }
 
         





    }
}
