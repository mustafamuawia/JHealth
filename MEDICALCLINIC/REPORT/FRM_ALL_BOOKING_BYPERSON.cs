using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.REPORT
{
    public partial class FRM_ALL_BOOKING_BYPERSON : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        DataTable dt = new DataTable();
        public FRM_ALL_BOOKING_BYPERSON()
        {
            InitializeComponent();
        }

        private void BTN_DEBIT_Click(object sender, EventArgs e)
        {
            ACCOUNT.FRM_CUSTOMER_DEBIT FRM = new ACCOUNT.FRM_CUSTOMER_DEBIT();
            FRM.ShowDialog();
        }

        private void FRM_ALL_BOOKING_BYPERSON_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
            
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
            this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
            dt = this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON;
            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasource.Add(dt.Rows[i][1].ToString());
            }
            this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
            this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }


        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        try{ 
            if (pERSON_NAMEComboBox.SelectedIndex > -1)
            {
               this.gET_ALL_BOOKING_BY_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_BOOKING_BY_PERSON, new System.Nullable<int>(((int)(System.Convert.ChangeType( pERSON_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))),1);
                    if (dgvalldata.Rows.Count>0)
                    {
             lbl_kishfia.Text = dgvalldata.Rows.Cast<DataGridViewRow>()
                   .Sum(t => Convert.ToDecimal(t.Cells[12].Value)).ToString();
               
                
                lbl_total_op.Text = dgvalldata.Rows.Cast<DataGridViewRow>()
                   .Sum(t => Convert.ToDecimal(t.Cells[13].Value)).ToString();

                    }
              
            }
            }
            catch (System.Exception ex)
            {
                //   System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
    }
}
