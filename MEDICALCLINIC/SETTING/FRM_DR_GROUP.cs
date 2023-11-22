using System;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_DR_GROUP : BASEANYFORM
    {
       
       


        public FRM_DR_GROUP()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {  try
            {
            TXTGRPNAME.Focus();
          
                this.gET_DR_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DR_BUTTON,"");
            }
            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        

         

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TXTID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TXTGRPNAME.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               
            }
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_DR_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DR_BUTTON, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
            TXTID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TXTGRPNAME.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTGRPNAME.Text == "")
                {

                    MessageBox.Show("يرجى اختيار مجموعة اولا");
                }
 if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {

                    if (TXTID.Text == "")
                    {
                        CLS.CHEECK_CODE = 0;

                    }
                    else
                    {
                        CLS.CHEECK_CODE = Convert.ToInt32(TXTID.Text);
                    }
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_DR_GROUP(
                        CLS.CHEECK_CODE
                        , ref CLS.CLIENT_CODE
                        , TXTGRPNAME.Text                       
                        , true
                        , ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        TXTID.Text = CLS.CLIENT_CODE.ToString();
                        main_form_Load(null, null);
                        ClearTextBoxes();
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
                TXTGRPNAME.IsEmpty();
                
        if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_DR_GROUP(
                    Convert.ToInt32(TXTID.Text)
                    , TXTGRPNAME.Text
                    
                    , true
                    , ref CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        TXTID.Text = CLS.CLIENT_CODE.ToString();
                        MSG.Msg.Alart(AlartType.Update);
                        main_form_Load(null, null);
                        ClearTextBoxes();
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
               TXTGRPNAME.IsEmpty(); 
               
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_DELETE))
                {

                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_DR_GROUP(
                    Convert.ToInt32(TXTID.Text)
                    , TXTGRPNAME.Text

                    , true
                    , ref CLS.SUBMIT_FLAG);



                    if (CLS.SUBMIT_FLAG == 1)
                    {

                        TXTID.Text = CLS.CLIENT_CODE.ToString();
                        MSG.Msg.Alart(AlartType.Delete);
                        main_form_Load(null, null);
                        ClearTextBoxes();
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
