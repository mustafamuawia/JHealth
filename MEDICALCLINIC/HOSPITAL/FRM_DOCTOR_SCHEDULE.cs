using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL
{
    public partial class FRM_DOCTOR_SCHEDULE :MEDICALCLINIC.HOSPITAL. BaseHospital
    {
        public FRM_DOCTOR_SCHEDULE()
        {
            InitializeComponent();
        }

        //private void v_H_SCHDUEL_DOCTORBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.v_H_SCHDUEL_DOCTORBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.mEDICAL_CLINIC_DBDataSet);

        //}

        private void FRM_DOCTOR_SCHEDULE_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_H_SUBDEPARTMENT' table. You can move, or remove it, as needed.
                this.v_H_SUBDEPARTMENTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_H_SUBDEPARTMENT);
                // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
                this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);

                this.gET_SCHDUEL_DOCTOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_SCHDUEL_DOCTOR_NAME_CODE, "");
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

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (dOCTOR_NAMEComboBox.SelectedIndex == -1)
                {

                    errorProvider1.SetError(dOCTOR_NAMEComboBox, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_H_SCHDUELDOCTOR(
                   Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue)
                   , Convert.ToInt32(nAME_B_DEPComboBox.SelectedValue)
                   , COMB_DAY.Text
                   , DATE_FROM.Text
                   , DATE_TO.Text,
                   true
                   , ref CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        this.gET_SCHDUEL_DOCTOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_SCHDUEL_DOCTOR_NAME_CODE, "");
                        MSG.Msg.Alart(AlartType.Save);
                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
