using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_BOOK_TYPE : BASEANYFORM
    {

        public FRM_BOOK_TYPE()
        {
            InitializeComponent();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {

            try
            {
                if (BOOK_TYPE_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(BOOK_TYPE_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (BOOK_TYPE_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(BOOK_TYPE_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_BOOK_TYPE(CLS.CHEECK_CODE, ref  CLS.CLIENT_CODE, BOOK_TYPE_NAME_ARTextBoxX.Text,Convert .ToInt32 ( DOCTOR_COMB.SelectedValue) , true, ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        BOOK_TYPE_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

      
       
        public void cleartextbox(Control root)
        {
            foreach (Control ct in root.Controls)
            {
                if (ct is TextBox)
                    ((TextBox)ct).Clear();

                //' افراغ لتيكست بوكس 
            }
        }
       

      

      
        private void FRM_BOOK_TYPE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEARCH_BOOKING_T FRM = new SEARCH.FRM_SEARCH_BOOKING_T();
            FRM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleartextbox(this.groupBox2);
            DOCTOR_COMB.SelectedValue = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                if (BOOK_TYPE_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(BOOK_TYPE_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (BOOK_TYPE_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(BOOK_TYPE_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_BOOK_TYPE(CLS.CHEECK_CODE, ref  CLS.CLIENT_CODE, BOOK_TYPE_NAME_ARTextBoxX.Text, Convert.ToInt32(DOCTOR_COMB.SelectedValue), true, ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        BOOK_TYPE_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (BOOK_TYPE_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(BOOK_TYPE_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_BOOK_TYPE(Convert.ToInt32(BOOK_TYPE_CODETextBoxX.Text), BOOK_TYPE_NAME_ARTextBoxX.Text, Convert.ToInt32(DOCTOR_COMB.SelectedValue), true, ref  CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        BOOK_TYPE_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                        MSG.Msg.Alart(AlartType.Update);

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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (BOOK_TYPE_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(BOOK_TYPE_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_DELETE_T_BOOK_TYPE(Convert.ToInt32(BOOK_TYPE_CODETextBoxX.Text), ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        BOOK_TYPE_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
