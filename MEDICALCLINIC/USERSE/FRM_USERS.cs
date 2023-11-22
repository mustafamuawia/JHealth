using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.USERSE
{
    public partial class FRM_USERS :MEDICALCLINIC. USERSE.masterfrm
    {
    int FLAGER;
        public FRM_USERS()
        {
            InitializeComponent();
        }

      

        private void FRM_USERS_Load(object sender, EventArgs e)
        {// TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR' table. You can move, or remove it, as needed.
            this.v_GET_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_GROUP_ROLE' table. You can move, or remove it, as needed.
            this.v_GET_GROUP_ROLETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_GROUP_ROLE);
            try
            {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_GRP_DOCTOR' table. You can move, or remove it, as needed.
            this.v_GET_A_GRP_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_GRP_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_DOCT_FOR_USER' table. You can move, or remove it, as needed.
            this.v_GET_DOCT_FOR_USERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_DOCT_FOR_USER);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.T_USER_LEVEL' table. You can move, or remove it, as needed.
          //  this.t_USER_LEVELTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.T_USER_LEVEL);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
                this.gET_EMP_TYPE_BY_IDJOBTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_EMP_TYPE_BY_IDJOB, new System.Nullable<int>(((int)(System.Convert.ChangeType(5, typeof(int))))));

                this.p_GET_DOCT_FOR_USERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_DOCT_FOR_USER, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));
                LEVL_COMB.SelectedIndex = -1;
                COMB_EMP.SelectedIndex = -1;
            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            USERSE.FRM_SEARCH_USERS FRM = new FRM_SEARCH_USERS();
            FRM.ShowDialog();

        }

        private void RE_PWD_TXT_Validated(object sender, EventArgs e)
        {
            if (PWD_TXT.Text != RE_PWD_TXT.Text)
            {
                RE_PWD_TXT.Clear();
                RE_PWD_TXT.Focus();
            }
        }
        
        private void LEVL_COMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LEVL_COMB.SelectedIndex>-1)
            {

           
            if (LEVL_COMB.Text == "الاطباء")
            {

                // gROUP_NAMEComboBox.Visible = true;
                DataTable dtD = new DataTable();
                dtD = this.mEDICAL_CLINIC_DBDataSet.P_GET_DOCT_FOR_USER;
                COMB_EMP.DataSource = dtD;
                AutoCompleteStringCollection datasourceD = new AutoCompleteStringCollection();
                for (int i = 0; i < dtD.Rows.Count; i++)
                {
                    datasourceD.Add(dtD.Rows[i][1].ToString());
                }
                this.COMB_EMP.AutoCompleteCustomSource = datasourceD;
                this.COMB_EMP.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.COMB_EMP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.COMB_EMP.ValueMember = "DOCTOR_CODE";
                this.COMB_EMP.DisplayMember = "DOCTOR_NAME";
            }
            else
             //  if (LEVL_COMB.SelectedIndex != -1 && LEVL_COMB.SelectedIndex != 0)
            {
                this.gET_EMP_TYPE_BY_IDJOBTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_EMP_TYPE_BY_IDJOB, new System.Nullable<int>(((int)(System.Convert.ChangeType(LEVL_COMB.SelectedValue, typeof(int))))));

                DataTable dtE = new DataTable();
                dtE = this.mEDICAL_CLINIC_DBDataSet.GET_EMP_TYPE_BY_IDJOB;
                this.COMB_EMP.DataSource = dtE;
                AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
                for (int i = 0; i < dtE.Rows.Count; i++)
                {
                    datasource.Add(dtE.Rows[i][1].ToString());
                }

                this.COMB_EMP.AutoCompleteCustomSource = datasource;
                this.COMB_EMP.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.COMB_EMP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.COMB_EMP.ValueMember = "ID_EMP";
                this.COMB_EMP.DisplayMember = "NAME_EMP";
            }
 }



            //else
            //{
            //    dOCTOR_NAMEComboBox.Visible = false;
            //  //  gROUP_NAMEComboBox.Visible = false ;
            //}

            //if (LEVL_COMB.SelectedIndex == 0)
            //{

            // // gROUP_NAMEComboBox.Visible = true;
            //    DataTable dtD = new DataTable();
            //    dtD = this.mEDICAL_CLINIC_DBDataSet.P_GET_DOCT_FOR_USER;
            //    comboBox1.DataSource = dtD;
            //    AutoCompleteStringCollection datasourceD = new AutoCompleteStringCollection();
            //    for (int i = 0; i < dtD.Rows.Count; i++)
            //    {
            //        datasourceD.Add(dtD.Rows[i][1].ToString());
            //    }
            //    this.comboBox1.AutoCompleteCustomSource = datasourceD;
            //    this.comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    this.comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    this.comboBox1.ValueMember = "DOCTOR_CODE";
            //    this.comboBox1.DisplayMember = "DOCTOR_NAME";
            //}
            //else
            //if (LEVL_COMB.SelectedIndex!=-1 && LEVL_COMB.SelectedIndex != 0)
            //{
            //    this.gET_EMP_TYPE_BY_IDJOBTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_EMP_TYPE_BY_IDJOB, new System.Nullable<int>(((int)(System.Convert.ChangeType(LEVL_COMB.SelectedIndex, typeof(int))))));

            //    DataTable dtE = new DataTable();
            //    dtE = this.mEDICAL_CLINIC_DBDataSet.GET_EMP_TYPE_BY_IDJOB;
            //    this.comboBox1.DataSource = dtE;
            //    AutoCompleteStringCollection datasource = new AutoCompleteStringCollection();
            //    for (int i = 0; i < dtE.Rows.Count; i++)
            //    {
            //        datasource.Add(dtE.Rows[i][1].ToString());
            //    }

            //    this.comboBox1.AutoCompleteCustomSource = datasource;
            //    this.comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //    this.comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    this.comboBox1.ValueMember = "ID_EMP";
            //    this.comboBox1.DisplayMember = "NAME_EMP";
            //}




            ////else
            ////{
            ////    dOCTOR_NAMEComboBox.Visible = false;
            ////  //  gROUP_NAMEComboBox.Visible = false ;
            ////}
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
       
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                PWD_TXT.UseSystemPasswordChar = false;
                RE_PWD_TXT.UseSystemPasswordChar = false;
            }
            else
            {
                PWD_TXT.UseSystemPasswordChar = true;
                RE_PWD_TXT.UseSystemPasswordChar = true ;

            }
        }

       
       

        private void gROUP_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.p_GET_DOCT_FOR_USERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_DOCT_FOR_USER, new System.Nullable<int>(((int)(System.Convert.ChangeType( 0, typeof(int))))));
            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

         

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {


            try
            {
                if (TXT_USER_NAEME.Text == "")
                {

                    errorProvider1.SetError(TXT_USER_NAEME, CLS.TXT_NULL);
                    return;
                }
                if (comb_floor.SelectedIndex == -1 || COMB_EMP.SelectedIndex == -1||LEVL_COMB.SelectedIndex==-1|| TXT_USER_NAEME.Text == string.Empty || RE_PWD_TXT.Text == string.Empty || PWD_TXT.Text == string.Empty)
                {

                    MessageBox.Show("يرجى ادخال البيانات بصورة صحيحة");
                    return;
                }

                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (TXT_USER_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TXT_USER_CODE.Text);
                    }
                    
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    if (LEVL_COMB.Text == "الاطباء")
                    {
                        //   INSERTED.P_INSERT_USER()
                        INSERTED.P_INSERT_USER(
                              CLS.CHEECK_CODE
                            , ref CLS.CLIENT_CODE
                            , TXT_USER_NAEME.Text
                            , Convert.ToInt32(LEVL_COMB.SelectedValue)
                            , PWD_TXT.Text
                            , Convert.ToInt32(COMB_EMP.SelectedValue)
                            , Convert.ToInt32(COMB_EMP.SelectedValue)
                            , 0
                            , 0
                            , Convert.ToInt32(comb_floor.SelectedValue)
                            , ref CLS.SUBMIT_FLAG);
                    }
                    else
                    {
                        INSERTED.P_INSERT_USER(
                               CLS.CHEECK_CODE
                             , ref CLS.CLIENT_CODE
                             , TXT_USER_NAEME.Text
                             , Convert.ToInt32(LEVL_COMB.SelectedValue)
                             , PWD_TXT.Text
                             , Convert.ToInt32(COMB_EMP.SelectedValue)
                             , 0
                             , 1
                             , 0
                           , Convert.ToInt32(comb_floor.SelectedValue)
                             , ref CLS.SUBMIT_FLAG);
                    }

                   


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        TXT_USER_CODE.Text = CLS.CLIENT_CODE.ToString();
                        COMB_EMP.SelectedIndex = -1;
                        LEVL_COMB.SelectedIndex = -1;
                      
                       
                       
                        BTN_NEW_Click(null, null);
                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }
                }
            }

            catch (Exception EX)
            {
             //   MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_USER_CODE.Text == "")
                {

                    errorProvider1.SetError(TXT_USER_CODE, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_USER(Convert.ToInt32(TXT_USER_CODE.Text), false, ref  CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);

                    }
                    else
                    {

                        MSG.Msg.Alart(AlartType.Error);

                    }

                }
            }
            catch
            {
                return;
            }
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            { 
                if (TXT_USER_CODE.Text == "")
                {

                    errorProvider1.SetError(TXT_USER_CODE, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    if (LEVL_COMB.SelectedIndex == 0)
                    {

                        INSERTED.P_UPDATE_T_USER(Convert.ToInt32(TXT_USER_CODE.Text)
                            , TXT_USER_NAEME.Text
                            , PWD_TXT.Text
                            , Convert.ToInt32(COMB_EMP.SelectedValue)
                            , Convert.ToInt32(LEVL_COMB.SelectedValue)
                            , Convert.ToInt32(COMB_EMP.SelectedValue)
                            , true
                            , 0
                           , Convert.ToInt32(comb_floor.SelectedValue)
                            , ref CLS.SUBMIT_FLAG);
                    }
                    else
                        if (LEVL_COMB.SelectedIndex != 0)
                    {
                        INSERTED.P_UPDATE_T_USER(Convert.ToInt32(TXT_USER_CODE.Text)
                              , TXT_USER_NAEME.Text
                              , PWD_TXT.Text
                              , 0
                              , Convert.ToInt32(LEVL_COMB.SelectedValue)
                              , Convert.ToInt32(COMB_EMP.SelectedValue)
                              , true
                              , 0
                          , Convert.ToInt32(comb_floor.SelectedValue)
                              , ref CLS.SUBMIT_FLAG);

                    }

                    if (CLS.SUBMIT_FLAG == 1)
                    {
BTN_NEW_Click(null, null);
                        TXT_USER_CODE.Text = CLS.CLIENT_CODE.ToString();
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

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
      try{ 
           //ExtentionMethod. ClearText(  );
            cleartextbox(groupBox2);
            LEVL_COMB.SelectedIndex = -1;
            COMB_EMP.SelectedIndex = -1;
                comb_floor.SelectedIndex = -1;
        }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
}

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            FRM_SEARCH_USERS frmm = new FRM_SEARCH_USERS(); frmm.ShowDialog();
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXT_USER_NAEME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PWD_TXT.Focus();
            }
        }

        private void PWD_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RE_PWD_TXT.Focus();
            }
        }

        private void RE_PWD_TXT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LEVL_COMB.Focus();
            }
        }

        private void LEVL_COMB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                COMB_EMP.Focus();
            }
        }

        private void COMB_EMP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comb_floor.Focus();
            }
        }
    }
}
