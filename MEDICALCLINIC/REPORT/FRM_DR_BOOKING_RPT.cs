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
    public partial class FRM_DR_BOOKING_RPT : Form
    {
        DataTable dt = new DataTable();
        public FRM_DR_BOOKING_RPT()
        {
            InitializeComponent();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FRM_DR_BOOKING_RPT_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            this.gET_PERSON_BY_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));

            dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCTOR;
            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                datasource.Add(dt.Rows[i][1].ToString());
            }
            this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
            this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

     

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_BOOKING_REPORTDRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_BOOKING_REPORTDR, pERSON_NAMEComboBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_byname_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_BOOKING_REPORTDRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_BOOKING_REPORTDR, pERSON_NAMEComboBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
    }
    
