using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.SANAD
{
    public partial class FRM_COST_CENTER : Form
    {
        public FRM_COST_CENTER()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_COST_CENTER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_ALL_COST_CENTER_TYPE' table. You can move, or remove it, as needed.
            this.v_GET_ALL_COST_CENTER_TYPETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_ALL_COST_CENTER_TYPE);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR' table. You can move, or remove it, as needed.
            this.v_GET_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_FLOOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_ALL_COST_CENTER' table. You can move, or remove it, as needed.
            this.v_GET_ALL_COST_CENTERTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_ALL_COST_CENTER);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_ALL_ACCOUNTS' table. You can move, or remove it, as needed.
            this.v_GET_ALL_ACCOUNTSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_ALL_ACCOUNTS);

        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_NAME_COST_CENTER.Text == "")
                {

                    MessageBox.Show("يرجى ادخال أسم المركز");
                    return;
                }
                if (aCCOUNT_FULL_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد الحساب أولا");
                    return;
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (TXT_CODE_COST_CENTER.Text == String.Empty|| TXT_CODE_COST_CENTER.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TXT_CODE_COST_CENTER.Text);
                    }
                    
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_COST_CENTER(
                          CLS.CHEECK_CODE
                        , ref CLS.CLIENT_CODE
                        , TXT_NAME_COST_CENTER.Text
                        , aCCOUNT_FULL_NAMEComboBox.SelectedValue.ToInt()
                        , nAME_COST_CENTERComboBox.SelectedValue.ToInt()
                        , 2
                        , fLOOR_NAMEComboBox.SelectedIndex.ToInt()
                        , aCCOUNT_COST_TYPE_NAMEComboBox.SelectedValue.ToInt()
                        , true
                        , ref CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        TXT_CODE_COST_CENTER.Text = CLS.CLIENT_CODE.ToString();
                        //button3_Click(null, null);
                        aCCOUNT_FULL_NAMEComboBox.Focus();
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

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            aCCOUNT_FULL_NAMEComboBox.SelectedIndex = -1;
            nAME_COST_CENTERComboBox.SelectedIndex = -1;
            fLOOR_NAMEComboBox.SelectedIndex = -1;
            aCCOUNT_COST_TYPE_NAMEComboBox.SelectedIndex = -1;
            TXT_NAME_COST_CENTER.Clear();
            TXT_CODE_COST_CENTER.Clear() ;

        }

        private void T_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_NAME_COST_CENTER.Text == "")
                {

                    MessageBox.Show("يرجى ادخال أسم المركز");
                    return;
                }
                if (aCCOUNT_FULL_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد الحساب أولا");
                    return;
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    if (TXT_CODE_COST_CENTER.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TXT_CODE_COST_CENTER.Text);
                    }

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_COST_CENTER(
                          
                          TXT_CODE_COST_CENTER.Text.ToInt()
                        , TXT_NAME_COST_CENTER.Text
                        , aCCOUNT_FULL_NAMEComboBox.SelectedValue.ToInt()
                        , nAME_COST_CENTERComboBox.SelectedValue.ToInt()
                        , 1
                        , CLS.BRANCH_ID
                        , aCCOUNT_COST_TYPE_NAMEComboBox.SelectedValue.ToInt()
                        , true
                        , ref CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        TXT_CODE_COST_CENTER.Text = CLS.CLIENT_CODE.ToString();
                        //button3_Click(null, null);
                        aCCOUNT_FULL_NAMEComboBox.Focus();
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
                if (TXT_NAME_COST_CENTER.Text == "")
                {

                    MessageBox.Show("يرجى ادخال أسم المركز");
                    return;
                }
                if (aCCOUNT_FULL_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد الحساب أولا");
                    return;
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    if (TXT_CODE_COST_CENTER.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TXT_CODE_COST_CENTER.Text);
                    }

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_COST_CENTER(

                          TXT_CODE_COST_CENTER.Text.ToInt()
                      
                        , false
                        , ref CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        TXT_CODE_COST_CENTER.Text = CLS.CLIENT_CODE.ToString();
                        //button3_Click(null, null);
                        aCCOUNT_FULL_NAMEComboBox.Focus();
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

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            SEARCH.FRM_SEARCH_COST_CENTER FRM = new SEARCH.FRM_SEARCH_COST_CENTER();
            FRM.ShowDialog();
        }
    }
}
