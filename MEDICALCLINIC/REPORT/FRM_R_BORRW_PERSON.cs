using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_R_BORRW_PERSON : Form
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
        public FRM_R_BORRW_PERSON()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_BORROWTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BORROW,  "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType( 0, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FRM_R_BORRW_PERSON_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_BORROWTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BORROW, "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
              
                LBL_T_CREDIT.Text = dataGridView2.Rows.Cast<DataGridViewRow>()
                             .Sum(t => Convert.ToDecimal(t.Cells[2].Value)).ToString("N2", culture);


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TXT_NODATE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_BORROWTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BORROW, TXT_NODATE.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));

                LBL_T_CREDIT.Text = dataGridView2.Rows.Cast<DataGridViewRow>()
                               .Sum(t => Convert.ToDecimal(t.Cells[2].Value)).ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                CLS.PERSON_CODE_BORROW = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                FRM_R_PERSON_BORROW_DETAILS FRM = new FRM_R_PERSON_BORROW_DETAILS(CLS.PERSON_CODE_BORROW);FRM.ShowDialog();
            }
        }

        private void TXT_DATE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_BORROWTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BORROW, TXT_DATE.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

                LBL_T_CREDIT.Text = dataGridView2.Rows.Cast<DataGridViewRow>()
                               .Sum(t => Convert.ToDecimal(t.Cells[2].Value)).ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
