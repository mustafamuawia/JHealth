using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.USERSE
{
    public partial class FRM_ALLUSERS_DEBIT_FOR_DR : MEDICALCLINIC.SETTING.baseclinicanddental
    {
        int dr_cost = 0,FLAGS=0;
        
        public FRM_ALLUSERS_DEBIT_FOR_DR()
        {
            InitializeComponent();
          
        }

        

        

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            try
            {
                if (DR_NAMEComboBox.SelectedIndex!=-1)
                {
                    FLAGS = 1;
                    if (Properties.Settings.Default.COST_CENTER_TYPE == 0)
                    {
                        dr_cost = 110001;
                    }
                    else
                    {
                        dr_cost = iD_COST_CENTERLabel1.Text.ToInt();
                    }
                    this.gET_ALL_PERSON_DEBIT_FOR_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_PERSON_DEBIT_FOR_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(DR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dr_cost, typeof(int))))), dateTimePicker1.Value, dateTimePicker2.Value, FLAGS);

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        

        private void FRM_ALLUSERS_DEBIT_FOR_DR_Load(object sender, EventArgs e)
        {
            try
            {
                var workingArea = Screen.FromHandle(Handle).WorkingArea;
                MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
                WindowState = FormWindowState.Maximized;
                if (Properties.Settings.Default.COST_CENTER_TYPE==0)
                {
                      //dr_cost = 110001;
                    this.gET_DOCTOR_WITH_COST_CENTER_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_WITH_COST_CENTER_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), 2);
                    
                    }
                else
                 
                {
                    this.gET_DOCTOR_WITH_COST_CENTER_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_WITH_COST_CENTER_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), 1);
                }
                DR_NAMEComboBox.SelectedIndex = -1;
            }
            catch (System.Exception ex)
            {
               System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            SANAD.FRM_SANAD frm = new SANAD.FRM_SANAD();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DR_NAMEComboBox.SelectedIndex != -1)
                {
                    FLAGS = 2;
                    if (Properties.Settings.Default.COST_CENTER_TYPE == 0)
                    {
                        dr_cost = 110001;
                    }
                    else
                    {
                        dr_cost = iD_COST_CENTERLabel1.Text.ToInt();
                    }
                    this.gET_ALL_PERSON_DEBIT_FOR_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_PERSON_DEBIT_FOR_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(DR_NAMEComboBox.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(dr_cost, typeof(int))))), dateTimePicker1.Value, dateTimePicker2.Value, FLAGS);
                }
                }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
          
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            //string filter = "مريض";
            ((BindingSource)dgvalldata.DataSource).Filter = string.Format("accountname like '%{0}%'", textsearch.Text);
        }

        private void dgvalldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==0)
            {
                ACCOUNT.FRM_SHOW_ALLDEBIT_DETAILS FRM = new ACCOUNT.FRM_SHOW_ALLDEBIT_DETAILS(dgvalldata.CurrentRow.Cells[2].Value.ToInt(),
               dr_cost,dateTimePicker1.Value,dateTimePicker2.Value,FLAGS);
                FRM.ShowDialog();
            }
        }
    }
}
