using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_BOOKING_DISEAS : Form
    {

        public FRM_BOOKING_DISEAS()
        {
            InitializeComponent();
        }
        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
            this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_DISEAS' table. You can move, or remove it, as needed.
            this.v_GET_A_DISEASTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_DISEAS);
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
                IS_PAY = 0;
                IS_NO_PAY = 0;
                LBL_T_CREDIT.Text = "0.00";
                dataGridView2.DataSource = null;
                this.p_GET_BOOKING_BY_DISEASETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DISEASE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), dISEASE_NAMEComboBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))));
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DISEASE;
                

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
             //   System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                IS_PAY = 0;
                IS_NO_PAY = 0;
                LBL_T_CREDIT.Text = "0.00";
                dataGridView2.DataSource = null;
                this.p_GET_BOOKING_BY_DISEASE_TOW_DTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DISEASE_TOW_D, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), dISEASE_NAMEComboBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))));
                dataGridView2.DataSource = this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DISEASE_TOW_D;
               
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
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }




        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_BOOKING_BY_DISEASETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DISEASE, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue , typeof(int))))), dISEASE_NAMEComboBox.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE .Value , typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE .Value , typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_BOOKING_BY_DISEASE_TOW_DTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_BOOKING_BY_DISEASE_TOW_D, new System.Nullable<int>(((int)(System.Convert.ChangeType( dOCTOR_NAMEComboBox .SelectedValue , typeof(int))))), dISEASE_NAMEComboBox .Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE .Value  , typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE .Value , typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.v_GET_A_DISEASTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_DISEAS);

        }





    }
}
