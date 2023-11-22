﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_DRAGE_TIME : MEDICALCLINIC.HOSPITAL.BaseHospital
    {
        byte[] imge1;
        public FRM_DRAGE_TIME()
        {
            InitializeComponent();

        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            try
            {

                if (TIME_NAME.Text == "")
                {

                    MSG.Msg.Alart(AlartType.Error, "يرجى ملى الحقول اولا");
                    return;
                }


                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (TIME_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TIME_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    
                    INSERTED.P_INSERT_TIME_DRAGE(
                            CLS.CHEECK_CODE
                           , 0
                           , TIME_NAME.Text
                           , 0
                           , true
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_FLOOR_Load(null, null);
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

       

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_T_TIME_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_TIME_DRAGE_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
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
        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            TIME_CODE.Text = "";
            TIME_NAME.Text = "";

            
            TIME_NAME.Focus();
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (TIME_NAME.Text == "")
                {

                    MSG.Msg.Alart(AlartType.Error, "يرجى ملى الحقول اولا");
                    return;
                }


                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    if (TIME_CODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TIME_CODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    
                    INSERTED.P_UPDATE_T_TIME_DRAGE(
                   
                    Convert.ToInt32(TIME_CODE.Text)
                           , TIME_NAME.Text
                           , 0
                            
                           , true
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Update);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_FLOOR_Load(null, null);
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

                if (TIME_CODE.Text == "")
                {

                    MSG.Msg.Alart(AlartType.Error, "يرجى ملى الحقول اولا");
                    return;
                }



                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {


                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_TIME_DRAGE(

                              Convert.ToInt32(TIME_CODE.Text)
                              ,false
                           , ref CLS.SUBMIT_FLAG

                          );

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        BTN_NEW_Click(null, null);
                        FRM_ADD_FLOOR_Load(null, null);
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

        private void FRM_EMP_Shown(object sender, EventArgs e)
        {
            TIME_NAME.Focus();
        }

        private void gET_EMP_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gET_EMP_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
                {
                    TIME_CODE.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                    TIME_NAME.Text = gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();
                    // COMB_M_DEP.SelectedValue = Convert.ToInt32(gET_EMP_NAME_CODEDataGridView.CurrentRow.Cells[3].Value);

                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

       


        

        private void NOTE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_SAVE_Click(null, null);
            }
        }



       




        private void FRM_ADD_FLOOR_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_T_TIME_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_TIME_DRAGE_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
