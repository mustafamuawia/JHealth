using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.PERSONS
{
    public partial class FRM_CONVERT_TO_DOCT : Form
    {
        int drid=0, prid=0,bkid=0;
        public FRM_CONVERT_TO_DOCT(int drcode,int personcode,int bookid)
        {
            InitializeComponent();
            drid = drcode;
            prid = personcode;
            bkid = bookid;
        }

        private void FRM_CONVERT_TO_DOCT_Load(object sender, EventArgs e)
        {  try
            {
            dateTimePicker1.Value = System.DateTime.Now;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR_1' table. You can move, or remove it, as needed.
            this.v_A_DOCTOR_1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR_1);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
          
                this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(COMB_FROM_DOCT.SelectedValue, typeof(int))))));

                DataTable dt = new DataTable();
                dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE;
                AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    datasource.Add(dt.Rows[i][1].ToString());
                }
                this.LBL_NAMEPERSON.AutoCompleteCustomSource = datasource;
                this.LBL_NAMEPERSON.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.LBL_NAMEPERSON.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
              
                DataTable dt2 = new DataTable();
                dt2 = this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR_1;
                AutoCompleteStringCollection datasource2 = new AutoCompleteStringCollection();
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    datasource2.Add(dt2.Rows[i][1].ToString());
                }
                this.COMB_TO_DOCT.AutoCompleteCustomSource = datasource2;
                this.COMB_TO_DOCT.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.COMB_TO_DOCT.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                COMB_FROM_DOCT.SelectedValue = drid;
                LBL_NAMEPERSON.SelectedValue = prid;


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(COMB_FROM_DOCT .SelectedValue , typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
           
        }

        private void COMB_FROM_DOCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(COMB_FROM_DOCT.SelectedValue, typeof(int))))));
                DataTable dt = new DataTable();
                dt = this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE;
                AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    datasource.Add(dt.Rows[i][1].ToString());
                }
                this.LBL_NAMEPERSON.AutoCompleteCustomSource = datasource;
                this.LBL_NAMEPERSON.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.LBL_NAMEPERSON.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_ID_BOOK_BY_PER_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ID_BOOK_BY_PER_CODE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(System .DateTime .Now , typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType( LBL_NAMEPERSON .SelectedValue , typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(COMB_FROM_DOCT .SelectedValue , typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMB_FROM_DOCT.SelectedIndex == COMB_TO_DOCT.SelectedIndex)
                {
                    MessageBox.Show("عذرا لايمكنك التحويل لنفس الدكتور" + COMB_TO_DOCT.Text);
                    return;
                }
                var CONVER_TODOCT = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var EDIT_TBOX = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                this.p_GET_ID_BOOK_BY_PER_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ID_BOOK_BY_PER_CODE, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(LBL_NAMEPERSON.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(COMB_FROM_DOCT.SelectedValue, typeof(int))))));

                if (this.mEDICAL_CLINIC_DBDataSet.P_GET_ID_BOOK_BY_PER_CODE.Rows.Count > 0)
                {
                    EDIT_TBOX.P_CAHNGE_DOCT_CODE_TBOX(Convert.ToInt32(this.mEDICAL_CLINIC_DBDataSet.P_GET_ID_BOOK_BY_PER_CODE.Rows[0][0]), Convert.ToInt32(COMB_TO_DOCT.SelectedValue));
                }
                CONVER_TODOCT.P_TRANSLATE_TO_ANOTHER_DOCT(Convert.ToInt32(COMB_TO_DOCT.SelectedValue), bkid);

                this.gET_PERSON_BY_DOCT_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_BY_DOCT_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(COMB_FROM_DOCT.SelectedValue, typeof(int))))));

                MessageBox.Show("تم تحويل الزبون الى الدكتور" + COMB_TO_DOCT.Text);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       

    }
}
