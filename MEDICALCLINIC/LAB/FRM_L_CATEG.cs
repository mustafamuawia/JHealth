using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.LAB
{
    public partial class FRM_L_CATEG :MEDICALCLINIC.LAB. baselab
    {
        bool FPWD = false;
       


        public FRM_L_CATEG()
        {
            InitializeComponent();
        }

      

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            if (e.ColumnIndex == 0)
            {
                TXTCODE.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TXTNAME_CATEG.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTNAME_CATEG.Text == "")
                {

                    MessageBox.Show("يرجى ملى الحقول اولا");
                    return;
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (TXTCODE.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TXTCODE.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_L_CATEG(
                          CLS.CHEECK_CODE
                        , ref CLS.CLIENT_CODE
                        ,TXTNAME_CATEG.Text
                        ,true
                        , ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        TXTCODE.Text = CLS.CLIENT_CODE.ToString();
                        this.gET_L_CATEG_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_CATEG_NAME_CODE, "");

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTNAME_CATEG.Text == "")
                {

                    MessageBox.Show("يرجى ملى الحقول اولا");
                    return;
                }
if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_L_CATEG(Convert.ToInt32(TXTCODE.Text), TXTNAME_CATEG.Text , true, ref CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        TXTCODE.Text = CLS.CLIENT_CODE.ToString();
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

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var lst = this.mEDICAL_CLINIC_DBDataSet.GET_L_CATEG_NAME_CODE.AsEnumerable().Select(x => new {Id =x.Field<int>("ID_CATEG") }).ToList();
             
                this.gET_L_CATEG_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_CATEG_NAME_CODE, TXTSEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void FRM_L_CATEG_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_L_CATEG_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_CATEG_NAME_CODE,"");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTNAME_CATEG.Text == "")
                {

                    MessageBox.Show("يرجى ملئ الحقول اولا");
                    return;
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_DELETE_T_L_CATEG(Convert.ToInt32(TXTCODE.Text), ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        TXTCODE.Text = CLS.CLIENT_CODE.ToString();
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

        private void PIC_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
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
            cleartextbox(this.groupBox4);
            TXTNAME_CATEG.Focus();
        }

        private void FRM_L_CATEG_Shown(object sender, EventArgs e)
        {
            TXTNAME_CATEG.Focus();
        }
    }
}
