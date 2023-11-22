using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_H_CATEG : MEDICALCLINIC.SETTING.BASEANYFORM
    {

        public FRM_H_CATEG()
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

        private void button1_Click(object sender, EventArgs e)
        {

            SEARCH.FRM_SEARCH_CATEGORIES FRM = new SEARCH.FRM_SEARCH_CATEGORIES();
            FRM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleartextbox(this.groupBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (CATEG_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(CATEG_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (CATEG_CODETextBoxX.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(CATEG_CODETextBoxX.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_H_T_CATEG(Convert.ToInt32(CLS.CHEECK_CODE), ref CLS.CLIENT_CODE, CATEG_NAME_ARTextBoxX.Text, true, ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {   
                    FRM_H_CATEG_Load(null, null);
                        MSG.Msg.Alart(AlartType.Save);
                        CATEG_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
                     
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
                if (CATEG_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(CATEG_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_H_CATEG(Convert.ToInt32(CATEG_CODETextBoxX.Text), CATEG_NAME_ARTextBoxX.Text, true, ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
  
                    FRM_H_CATEG_Load(null, null);
                        CATEG_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
                if (CATEG_NAME_ARTextBoxX.Text == "")
                {

                    errorProvider1.SetError(CATEG_NAME_ARTextBoxX, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_H_CATEG(Convert.ToInt32(CATEG_CODETextBoxX.Text), ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        FRM_H_CATEG_Load(null, null);
                        MSG.Msg.Alart(AlartType.Delete);
                        CATEG_CODETextBoxX.Text = CLS.CLIENT_CODE.ToString();
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
            this.Dispose();
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void gET_CATEG_H_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gET_CATEG_H_NAME_CODEDataGridView.CurrentCell.ColumnIndex == 0)
            {
                CATEG_CODETextBoxX.Text = gET_CATEG_H_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
                CATEG_NAME_ARTextBoxX.Text = gET_CATEG_H_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_CATEG_H_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_CATEG_H_NAME_CODE, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void FRM_H_CATEG_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_CATEG_H_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_CATEG_H_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
