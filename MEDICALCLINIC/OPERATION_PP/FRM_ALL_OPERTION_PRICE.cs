using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.OPERATION_PP
{
    public partial class FRM_ALL_OPERTION_PRICE : Form
    {
        string GETPRESTNAGE ;

        public FRM_ALL_OPERTION_PRICE()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void FRM_ALL_OPERTION_PRICE_Load(object sender, EventArgs e)
        {
            CLS.TIMER_BORROW = 0;
            DATE_TIME.Value = System.DateTime.Now;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
              DataTable dt = new DataTable();
                dt = this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR;
            dOCTOR_NAMEComboBox.SelectedIndex = -1;
              AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    datasource.Add(dt.Rows[i][1].ToString());
                }
                this.dOCTOR_NAMEComboBox .AutoCompleteCustomSource = datasource;
                this.dOCTOR_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.dOCTOR_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

        System.Windows.Forms.Timer t = null;
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(timer1_Tick);
            t.Enabled = true;
        }

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
              
                 GETPRESTNAGE = this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR.Rows[dOCTOR_NAMEComboBox.SelectedIndex][5].ToString();
                this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PRICE_OPERTION_BY_GRID, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TIME.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
              //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PRICE_OPERTION_BY_GRID, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TIME.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
              //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {

        }

        private void p_GET_PRICE_OPERTION_BY_GRIDDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               // if (p_GET_PRICE_OPERTION_BY_GRIDDataGridView.Rows.Count > 0) { 
                if (e.ColumnIndex == 0)
                {
                 
                         int DOCTOR_CODE    = Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue);
                         int PERSON_CODE    = Convert.ToInt32(p_GET_PRICE_OPERTION_BY_GRIDDataGridView.CurrentRow.Cells[8].Value);
                         int BOOKING_CODE   = Convert.ToInt32(p_GET_PRICE_OPERTION_BY_GRIDDataGridView.CurrentRow.Cells[1].Value);
                     String  PERSON_NAME    = p_GET_PRICE_OPERTION_BY_GRIDDataGridView.CurrentRow.Cells[2].Value.ToString();
                     String  OPERTION_PRICE = p_GET_PRICE_OPERTION_BY_GRIDDataGridView.CurrentRow.Cells[7].Value.ToString();
                     String  F_DATE_PRT     = DATE_TIME.Text;
                               GETPRESTNAGE = p_GET_PRICE_OPERTION_BY_GRIDDataGridView.CurrentRow.Cells[10].Value.ToString();

                    OPERATION_PP.FRM_PAY_OPERTION_PRICE FRM = new FRM_PAY_OPERTION_PRICE(DOCTOR_CODE, PERSON_CODE , BOOKING_CODE, PERSON_NAME, OPERTION_PRICE, F_DATE_PRT, GETPRESTNAGE);
                   
                    FRM.ShowDialog();
              //  }
            }}
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PRICE_OPERTION_BY_GRID, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TIME.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
             //   System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CLS.TIMER_BORROW == 1)
            {
                try
                {
                    this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_PRICE_OPERTION_BY_GRID, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DATE_TIME.Value, typeof(System.DateTime))))));
                      CLS.TIMER_BORROW = 0;
                }
                catch (System.Exception ex)
                {
                    //   System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
