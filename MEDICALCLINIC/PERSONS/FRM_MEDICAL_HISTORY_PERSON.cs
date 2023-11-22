using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.PERSONS
{
    public partial class FRM_MEDICAL_HISTORY_PERSON : Form
    {
        int F_K=-1, F_H=-1 ,BERSON_CODE;
        public FRM_MEDICAL_HISTORY_PERSON(int ID_PERSON)
        {
            InitializeComponent();
            BERSON_CODE = ID_PERSON;
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {

                if (F_K == -1)
                {
                    MessageBox.Show("يرجى تحديد تحليل الكبد اولا", CLS.TITEL_MESG);
                    return;
                }
                if (F_H == -1)
                {
                    MessageBox.Show("يرجى تحديد تحليل ايدز اولا", CLS.TITEL_MESG);
                    return;
                }

                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                // INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);



              
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED_D = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                //DateTime d = DateTime.Now.AddDays(-31);
              //  Console.WriteLine(d.ToUniversalTime().ToString("hh-MMM-yy hh.mm.ss.ffffff tt"));
                
                  INSERTED.P_INSERT_T_MEDICAL_HISTORY(
                 Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
                , Convert.ToInt32( dOCTOR_NAMEComboBox.SelectedValue)
                ,System.DateTime.Now
                , TimeSpan.FromTicks(DateTime.Now.TimeOfDay.Ticks) 

                , TXT_SUGER.Text
                ,TXT_PERSSUSR.Text
                ,TXT_RESPIRATION.Text
                ,TXT_BODY_TEP.Text
                ,TXT_BLOOD_G.Text
                ,TXT_HEIGHT.Text
                ,TXT_WEIGHT.Text
                ,TXT_NOTES.Text
                ,Convert.ToBoolean( F_K)
                ,Convert.ToBoolean(F_H)

                , ref CLS.SUBMIT_FLAG);
 

                if (CLS.SUBMIT_FLAG == 1)
                {
                    MessageBox.Show("تمت العملية بنجاح", CLS.TITEL_MESG);
                }


            }
            catch
            {

            }
        }

        private void R_K_YES_CheckedChanged(object sender, EventArgs e)
        {
            F_K = 1;

                 R_K_YES.BackColor = Color.Red;
                 R_K_NO.BackColor = Color.Black;
        }

        private void R_K_NO_CheckedChanged(object sender, EventArgs e)
        {
            F_K = 0;
            R_K_YES.BackColor = Color.Black;
            R_K_NO.BackColor = Color.Red;
        }

        private void R_H_YES_CheckedChanged(object sender, EventArgs e)
        {
            F_H = 1;
            R_H_YES.BackColor = Color.Red;
            R_H_NO.BackColor = Color.Black;
        }

        private void R_H_NO_CheckedChanged(object sender, EventArgs e)
        {
            F_H = 0;
            R_H_YES.BackColor = Color.Black;
            R_H_NO.BackColor = Color.Red;
        }

        private void FRM_MEDICAL_HISTORY_PERSON_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
            this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            pERSON_NAMEComboBox.SelectedIndex = BERSON_CODE;
            DataTable dt1 = new DataTable();
            dt1 = this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON;

            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                datasource.Add(dt1.Rows[i][1].ToString());
            }
            this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
            this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
         
            DataTable dtd = new DataTable();
            dtd = this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR;

            AutoCompleteStringCollection datasourced = new AutoCompleteStringCollection();
            for (int i = 0; i < dtd.Rows.Count; i++)
            {
                datasourced.Add(dtd.Rows[i][1].ToString());
            }
            this.dOCTOR_NAMEComboBox.AutoCompleteCustomSource = datasourced;
            this.dOCTOR_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.dOCTOR_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


        }
    }
}
