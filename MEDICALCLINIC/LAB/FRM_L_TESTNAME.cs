
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace MEDICALCLINIC.LAB
{
    public partial class FRM_L_TESTNAME : MEDICALCLINIC.LAB.baselab
    {
        bool FPWD = false;
        byte[] imge1;
        public FRM_L_TESTNAME()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG1' table. You can move, or remove it, as needed.
            this.v_GET_A_L_CATEG1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG1);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_L_UNIT' table. You can move, or remove it, as needed.
            this.v_GET_A_L_UNITTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_L_UNIT);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG' table. You can move, or remove it, as needed.
            this.v_GET_A_L_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG);
           
                this.gET_L_TEST_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAME_CODE, TXTSEARCH.Text, comboBox2.SelectedValue.ToInt(), 1);
           
            TXTNAME_TEST.Focus();
            comboBox1.SelectedIndex = -1;
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

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTSEARCH_TextChanged(object sender, EventArgs e)
        { try
            {
            if (comboBox2.SelectedIndex>-1)
            {
                    this.gET_L_TEST_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAME_CODE, TXTSEARCH.Text, comboBox2.SelectedValue.ToInt(), 2);

            } 
                else
                {
                    this.gET_L_TEST_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAME_CODE, TXTSEARCH.Text, comboBox2.SelectedValue.ToInt(), 1);

                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void nAME_CATEGComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (nAME_CATEGComboBox1.SelectedIndex > -1)
                {
                    this.gET_LAB_TEST_BY_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_TEST_BY_CATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox1.SelectedValue, typeof(int))))));

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void gET_LAB_TEST_BY_CATEGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dgv_new.Rows.Add(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[2].Value.ToString(),
                           gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[3].Value.ToString(),
                           gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[4].Value.ToString(),
                           gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[1].Value.ToString(),
                           nAME_CATEGComboBox1.SelectedValue
                           );
            }
        }

        private void dgv_new_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    dgv_new.Rows.RemoveAt(dgv_new.CurrentRow.Index);

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    TXTCODE.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    TXTNAME_TEST.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    nAME_CATEGComboBox.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    nAME_UNITComboBox.SelectedValue = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    TXT_PRICE.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    TXT_DEF_VALUE.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    TXT_NORMAL.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    TXT_MINI.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    TXT_MAX.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    TXT_NOTE.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    if (dataGridView1.CurrentRow.Cells[14].Value.ToString() != string.Empty)
                    {
                        byte[] imge1 = (byte[])dataGridView1.CurrentRow.Cells[14].Value;
                        MemoryStream ms1 = new MemoryStream(imge1);
                        PIC_TEST.Image = Image.FromStream(ms1);
                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void TXTNAME_TEST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                nAME_CATEGComboBox.Focus();
            }
        }

        private void nAME_CATEGComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nAME_UNITComboBox.Focus();
            }
        }

        private void nAME_UNITComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_DEF_VALUE.Focus();
            }
        }

        private void TXT_DEF_VALUE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_PRICE.Focus();
            }
        }

        private void TXT_PRICE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_NORMAL.Focus();
            }
        }

        private void TXT_NORMAL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_MAX.Focus();
            }
        }

        private void TXT_MAX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_MINI.Focus();
            }
        }

        private void TXT_MINI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXT_NOTE.Focus();
            }
        }

        private void TXT_NOTE_KeyDown(object sender, KeyEventArgs e)
        {
            btn_save_Click_1(null, null);
        }

        private void btn_savegroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_new.Rows.Count < 1)
                {

                    MessageBox.Show("يرجى ملئ الجدول اولا");
                    return;
                }
                {
                    if (comboBox1.SelectedIndex == -1)
                    {

                        MessageBox.Show("يرجى تحديد الفئة الجديدة");
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

                        for (int i = 0; i < dgv_new.Rows.Count; i++)
                        {

                            INSERTED.P_INSERT_T_L_TEST_JOIN(
                                  CLS.CHEECK_CODE
                                , dgv_new.Rows[i].Cells[3].Value.ToInt()
                                , comboBox1.SelectedValue.ToInt()
                                , ref CLS.SUBMIT_FLAG);
                        }



                        if (CLS.SUBMIT_FLAG == 1)
                        {
                            MSG.Msg.Alart(AlartType.Save);
                            dgv_new.Rows.Clear();
                        }
                        else
                        {

                            MSG.Msg.Alart(AlartType.Error);

                        }
                    }
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex > -1)
                {
                    this.gET_L_TEST_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAME_CODE, TXTSEARCH.Text, comboBox2.SelectedValue.ToInt(), 2);

                }
                else
                {
                    this.gET_L_TEST_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAME_CODE, TXTSEARCH.Text, comboBox2.SelectedValue.ToInt(), 1);

                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_NEW_Click_1(object sender, EventArgs e)
        {
            cleartextbox(this.groupBox4);
            nAME_CATEGComboBox.SelectedIndex = -1;
            nAME_UNITComboBox.SelectedIndex = -1;
            TXTNAME_TEST.Focus();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TXTNAME_TEST.Text == "")
                {

                    MessageBox.Show("يرجى ملئ الحقول اولا");
                    return;
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                    INSERTED.P_DELETE_T_L_TEST(Convert.ToInt32(TXTCODE.Text), ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Delete);
                        this.gET_L_TEST_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAME_CODE, "", comboBox2.SelectedValue.ToInt(), 1);

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

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTNAME_TEST.Text == "")
                {

                    MessageBox.Show("يرجى ملى الحقول اولا");
                    return;
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    MemoryStream ms1 = new MemoryStream();
                    pictureBox1.Image.Save(ms1, PIC_TEST.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    INSERTED.P_UPDATE_T_L_TEST(
                          CLS.CHEECK_CODE
                        , Convert.ToInt32(TXTCODE.Text)
                        , TXTNAME_TEST.Text
                        , Convert.ToInt32(nAME_CATEGComboBox.SelectedValue)
                        , 0
                        , nAME_UNITComboBox.SelectedValue.ToString()
                        , TXT_DEF_VALUE.Text
                        , Convert.ToDecimal(TXT_PRICE.Text)
                        , TXT_NORMAL.Text
                        , TXT_MINI.Text
                        , TXT_MAX.Text
                        , TXT_NOTE.Text
                        , imge1
                        , true
                        , ref CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {


                        MSG.Msg.Alart(AlartType.Update);
                        this.gET_L_TEST_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAME_CODE, "", comboBox2.SelectedValue.ToInt(), 2);

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

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TXTNAME_TEST.Text == "")
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
                    if (PIC_TEST.Image != null)
                    {
                        MemoryStream ms1 = new MemoryStream();
                        PIC_TEST.Image.Save(ms1, PIC_TEST.Image.RawFormat);
                        imge1 = ms1.ToArray();
                    }
                    else
                    {
                        imge1 = null;
                    }
                    INSERTED.P_INSERT_T_L_TEST(
                          CLS.CHEECK_CODE
                        , ref CLS.CLIENT_CODE
                        , TXTNAME_TEST.Text
                        , Convert.ToInt32(nAME_CATEGComboBox.SelectedValue)
                        , 0
                        , nAME_UNITComboBox.SelectedValue.ToString()
                        , TXT_DEF_VALUE.Text
                        , Convert.ToDecimal(TXT_PRICE.Text)
                        , TXT_NORMAL.Text
                        , TXT_MINI.Text
                        , TXT_MAX.Text
                        , TXT_NOTE.Text
                        , imge1
                        , true
                        , ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        TXTCODE.Text = CLS.CLIENT_CODE.ToString();
                        //this.gET_L_CATEG_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_CATEG_NAME_CODE, "");
                        this.gET_L_TEST_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAME_CODE, "", comboBox2.SelectedValue.ToInt(), 2);

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
    }
}
