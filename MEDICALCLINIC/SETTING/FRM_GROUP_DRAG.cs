using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_GROUP_DRAG : BASEANYFORM
    {

        public FRM_GROUP_DRAG()
        {
            InitializeComponent();
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
     

         

        
       
        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEARCH_GRP_DRAG FRM = new SEARCH.FRM_SEARCH_GRP_DRAG();
            FRM.ShowDialog();
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            cleartextbox(this.groupBox2);
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_GRP_GRP_NAME.Text == "")
                {

                    errorProvider1.SetError(TXT_GRP_GRP_NAME, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (TXT_GRP_DRAG_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TXT_GRP_DRAG_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_DRAGE_GROUP (CLS.CHEECK_CODE, ref CLS.CLIENT_CODE, TXT_GRP_GRP_NAME.Text, true, ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        TXT_GRP_DRAG_CODE.Text = CLS.CLIENT_CODE.ToString();
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

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_GRP_GRP_NAME.Text == "")
                {

                    errorProvider1.SetError(TXT_GRP_GRP_NAME, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                   INSERTED.P_UPDATE_T_DRAGE_GROUP(Convert.ToInt32(TXT_GRP_DRAG_CODE.Text), TXT_GRP_GRP_NAME.Text, true, ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        TXT_GRP_DRAG_CODE.Text = CLS.CLIENT_CODE.ToString();
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

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_GRP_GRP_NAME.Text == "")
                {

                    errorProvider1.SetError(TXT_GRP_GRP_NAME, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                   INSERTED.P_DELETE_T_DRAGE_GROUP(Convert.ToInt32(TXT_GRP_DRAG_CODE.Text), "",false ,ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        TXT_GRP_DRAG_CODE.Text = CLS.CLIENT_CODE.ToString();
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

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
