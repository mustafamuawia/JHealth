using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_R_PERSON_BORROW_DETAILS : Form
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
        String PERSON_CODE;
        public FRM_R_PERSON_BORROW_DETAILS(String PERSON_CODE_B)
        {
            InitializeComponent();
            PERSON_CODE = PERSON_CODE_B;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_BORROW_DETAILSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BORROW_DETAILS, PERSON_CODE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FRM_R_PERSON_BORROW_DETAILS_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_BORROW_DETAILSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BORROW_DETAILS, PERSON_CODE);
                LBL_NAME.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();

                LBL_DEBIT.Text = dataGridView2.Rows.Cast<DataGridViewRow>()
                          .Sum(t => Convert.ToDecimal(t.Cells[7].Value)).ToString("N2", culture);


                LBL_RECIVE.Text = dataGridView2.Rows.Cast<DataGridViewRow>()
                         .Sum(t => Convert.ToDecimal(t.Cells[8].Value)).ToString("N2", culture);

  
                LBL_REMAIN.Text = (Convert.ToDecimal(LBL_DEBIT.Text) - Convert.ToDecimal(LBL_RECIVE.Text)).ToString("N2", culture) ;
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

         
    }
}
