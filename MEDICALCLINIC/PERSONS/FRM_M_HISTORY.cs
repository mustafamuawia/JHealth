using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.PERSONS
{
    public partial class FRM_M_HISTORY : Form
    {
        int personcode = -1, CLINIC_VISIT_PREV = 0, CH_ABDOMINAL = 0, CH_BREATH = 0, CH_NEUROLOGICAL = 0, CH_HEART = 0, CH_NO = 0, TAKE_MEDICATIONS = 0, ALLERGIES_STUFF = 0, SMOKE = 0, COHOL = 0, BREASTFEEDER=0, PREGNANT=0;
        DataTable dt1 = new DataTable();
        public FRM_M_HISTORY(int personid)
        {
            InitializeComponent();
            personcode= personid;
        }
        private void FRM_M_HISTORY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
            this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);


            dt1 = this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON;
            AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                datasource.Add(dt1.Rows[i][1].ToString());
            }
            this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource;
            this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            pERSON_NAMEComboBox.SelectedValue = personcode;
        }

        private void b_Breath_Click(object sender, EventArgs e)
        {
            if (b_Breath.BackColor == Color.RoyalBlue)
            {
                CH_BREATH = 1;
                b_Breath.BackColor = Color.Red;
                CH_NO = 0;
                b_deasis_no.BackColor = Color.RoyalBlue;
            }
            else
               if (b_Breath.BackColor == Color.Red)
            {
                CH_BREATH = 0;
                b_Breath.BackColor = Color.RoyalBlue;
            }
        }

        private void b_Abdomi_Click(object sender, EventArgs e)
        {
            if (b_Abdomi.BackColor == Color.RoyalBlue)
            {
                CH_ABDOMINAL = 1;
                b_Abdomi.BackColor = Color.Red;
                CH_NO = 0;
                b_deasis_no.BackColor = Color.RoyalBlue;
            }
            else
              if (b_Abdomi.BackColor == Color.Red)
            {
                CH_ABDOMINAL = 0;
                b_Abdomi.BackColor = Color.RoyalBlue;
            }
        }

        private void b_heart_Click(object sender, EventArgs e)
        {
            if (b_heart.BackColor == Color.RoyalBlue)
            {
                CH_HEART = 1;
                b_heart.BackColor = Color.Red;
                CH_NO = 0;
                b_deasis_no.BackColor = Color.RoyalBlue;
            }
            else
            if (b_heart.BackColor == Color.Red)
            {
                CH_HEART = 0;
                b_heart.BackColor = Color.RoyalBlue;
            }
        }

        private void b_deasis_no_Click(object sender, EventArgs e)
        {
            if (b_deasis_no.BackColor == Color.RoyalBlue)
            {
                CH_NO = 1;
                b_deasis_no.BackColor = Color.Red;

                CH_ABDOMINAL = 0;
                b_Abdomi.BackColor = Color.RoyalBlue;
                CH_BREATH = 0;
                b_Breath.BackColor = Color.RoyalBlue;
                CH_NEUROLOGICAL = 0;
                b_Neurolo.BackColor = Color.RoyalBlue;
                CH_HEART = 0;
                b_heart.BackColor = Color.RoyalBlue;
            }
         
            else
           if (b_deasis_no.BackColor == Color.Red)
            {
                CH_NO = 0;
                b_deasis_no.BackColor = Color.RoyalBlue;
               





            }
        }

        private void BTN_DRAGE_YES_Click(object sender, EventArgs e)
        {
            TAKE_MEDICATIONS = 1;
            BTN_DRAGE_YES.BackColor = Color.Red;
            BTN_DRAGE_NO.BackColor = Color.RoyalBlue;
        }

        private void BTN_DRAGE_NO_Click(object sender, EventArgs e)
        {

            TAKE_MEDICATIONS = 0;
            BTN_DRAGE_YES.BackColor = Color.RoyalBlue;
            BTN_DRAGE_NO.BackColor = Color.Red;
        }

        private void BTN_alle_YES_Click(object sender, EventArgs e)
        {
            ALLERGIES_STUFF = 1;
            BTN_alle_YES.BackColor = Color.Red;
            BTN_alle_NO.BackColor = Color.RoyalBlue;
        }
 private void BTN_alle_NO_Click(object sender, EventArgs e)
        {
            ALLERGIES_STUFF =0;
            BTN_alle_YES.BackColor = Color.RoyalBlue;
            BTN_alle_NO.BackColor = Color.Red;
        }
        private void B_SMOKE_YES_Click(object sender, EventArgs e)
        {
            SMOKE = 1;
            B_SMOKE_YES.BackColor = Color.Red;
            B_SMOKE_NO.BackColor = Color.RoyalBlue;
        }

        private void B_SMOKE_NO_Click(object sender, EventArgs e)
        {
            SMOKE = 0;
            B_SMOKE_YES.BackColor = Color.RoyalBlue;
            B_SMOKE_NO.BackColor = Color.Red;
        }

        private void B_COHOL_YES_Click(object sender, EventArgs e)
        {
            COHOL = 1;
            B_COHOL_YES.BackColor = Color.Red;
            B_COHOL_NO.BackColor = Color.RoyalBlue;
        }

        private void B_COHOL_NO_Click(object sender, EventArgs e)
        {
            COHOL = 0;
            B_COHOL_YES.BackColor = Color.RoyalBlue;
            B_COHOL_NO.BackColor = Color.Red;
        }

        private void B_pregnant_Y_Click(object sender, EventArgs e)
        {
            PREGNANT = 1;
            B_pregnant_Y.BackColor = Color.Red;
            B_pregnant_N.BackColor = Color.RoyalBlue;
        }

        private void B_pregnant_N_Click(object sender, EventArgs e)
        {
            PREGNANT = 0;
            B_pregnant_Y.BackColor = Color.RoyalBlue;
            B_pregnant_N.BackColor = Color.Red;
        }

        private void B_breastfeeder_YES_Click(object sender, EventArgs e)
        {

            BREASTFEEDER = 1;
            B_breastfeeder_YES.BackColor = Color.Red;
            B_breastfeeder_NO.BackColor = Color.RoyalBlue;
        }

        
        private void B_breastfeeder_NO_Click(object sender, EventArgs e)
        {
            BREASTFEEDER = 0;
            B_breastfeeder_YES.BackColor = Color.RoyalBlue;
            B_breastfeeder_NO.BackColor = Color.Red;
        }

        private void b_Neurolo_Click(object sender, EventArgs e)
        {
            if (b_Neurolo.BackColor==Color.RoyalBlue)
            {
                CH_NEUROLOGICAL = 1;
                b_Neurolo.BackColor = Color.Red;
                CH_NO = 0;
                b_deasis_no.BackColor = Color.RoyalBlue;
            }
            else
                 if (b_Neurolo.BackColor == Color.Red)
            {
                CH_NEUROLOGICAL = 0;
                b_Neurolo.BackColor = Color.RoyalBlue;
            }
        }
       

        private void B_PREV_VIST_NO_Click(object sender, EventArgs e)
        {
            CLINIC_VISIT_PREV = 0;
            B_PREV_VIST_YES.BackColor = Color.RoyalBlue;
            B_PREV_VIST_NO.BackColor = Color.Red;
        }

        private void B_PREV_VIST_YES_Click(object sender, EventArgs e)
        {
            CLINIC_VISIT_PREV = 1;
            B_PREV_VIST_YES.BackColor = Color.Red;
            B_PREV_VIST_NO.BackColor = Color.RoyalBlue;

        }
       

       
        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            PERSONS.FRM_MEDICAL_HISTORY_PERSON FRM = new FRM_MEDICAL_HISTORY_PERSON(-1);FRM.ShowDialog();
        }

        private void B_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {

                if (CLINIC_VISIT_PREV == -1)
                {
                    MessageBox.Show("يرجى تحديد هل لديك زيارات سابقة", CLS.TITEL_MESG);
                    return;
                }
                if (CH_NEUROLOGICAL == -1 && CH_BREATH == -1 && CH_ABDOMINAL == -1 && CH_HEART == -1 && CH_NO == -1)
                {
                    MessageBox.Show("يرجى تحديد الامراض المزمنة اولا", CLS.TITEL_MESG);
                    return;
                }

                if (TAKE_MEDICATIONS == -1)
                {
                    MessageBox.Show("يرجى تحديد هل تتناول أدوية معينةاولا", CLS.TITEL_MESG);
                    return;
                }

                if (ALLERGIES_STUFF == -1)
                {
                    MessageBox.Show("يرجى تحديد هل لديك حساسية من أدوية معينةاولا", CLS.TITEL_MESG);
                    return;
                }

                if (SMOKE == -1)
                {
                    MessageBox.Show("يرجى تحديد هل تدخن اولا", CLS.TITEL_MESG);
                    return;
                }
                if (COHOL == -1)
                {
                    MessageBox.Show("يرجى تحديد هل تتناول الكحول اولا", CLS.TITEL_MESG);
                    return;
                }
                if (PREGNANT == -1)
                {
                    MessageBox.Show("يرجى تحديد هل انتي حامل اولا", CLS.TITEL_MESG);
                    return;
                }

                if (BREASTFEEDER == -1)
                {
                    MessageBox.Show("يرجى تحديد هل انتي مرضع اولا", CLS.TITEL_MESG);
                    return;
                }
                //if ((CH_NEUROLOGICAL == -1 && CH_BREATH == -1 && CH_ABDOMINAL == -1 && CH_HEART == -1 || CH_NEUROLOGICAL == 0 && CH_BREATH == 0 && CH_ABDOMINAL == 0 && CH_HEART == 0) && CH_NO == 1)
                //{
                //    CH_NEUROLOGICAL = 0;
                //    CH_BREATH = 0;
                //    CH_ABDOMINAL = 0;
                //    CH_HEART = 0;
                //}
                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
 


                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
        
                INSERTED.P_INSERT_T_MEDICAL_QUESTION(
                 Convert.ToInt32(pERSON_NAMEComboBox.SelectedValue)
               , 0
               , Convert.ToBoolean(CLINIC_VISIT_PREV)
               , Convert.ToBoolean(CH_ABDOMINAL)
               , Convert.ToBoolean(CH_BREATH)
               , Convert.ToBoolean(CH_NEUROLOGICAL)
               , Convert.ToBoolean(CH_HEART)
               , Convert.ToBoolean(CH_NO)
               , TXT_CHRONIC_NAME.Text
               , Convert.ToBoolean(TAKE_MEDICATIONS)
               , TXT_DRAGE_NAME.Text
               , Convert.ToBoolean(ALLERGIES_STUFF)
               , TXT_ALLEG_STUFF.Text
               , Convert.ToBoolean(SMOKE)
               , Convert.ToBoolean(COHOL)
               , Convert.ToBoolean(BREASTFEEDER)
               , Convert.ToBoolean(PREGNANT)
               , TXT_COME_REASON.Text
              , ref CLS.SUBMIT_FLAG) ;


                if (CLS.SUBMIT_FLAG == 1)
                {
                    MessageBox.Show("تمت العملية بنجاح", CLS.TITEL_MESG);
                }


            }
            catch
            {

            }
        }
    }
}
