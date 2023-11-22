using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING.HOSPITALSETTING
{
    public partial class FRM_ADD_BEDS : MEDICALCLINIC.HOSPITAL.BaseHospital
    {
        byte[] imge1;
        bool FPWD = false;



        public FRM_ADD_BEDS()
        {
            InitializeComponent();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR' table. You can move, or remove it, as needed.
            this.v_A_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_H_TYPBED' table. You can move, or remove it, as needed.
            this.v_A_H_TYPBEDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_TYPBED);
            TXTBEDNAME.Focus();
            //dataGridView1.AutoGenerateColumns = false;
            fLOOR_NAMEComboBox.SelectedIndex = -1;
            nAME_ROOMComboBox.SelectedIndex = -1;
            try
            {
                this.gET_H_BED_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_NAME_CODE, "");

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTBEDNAME.Text == "")
                {

                    errorProvider1.SetError(TXTBEDNAME, CLS.TXT_NULL);
                }
                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_SAVE))
                {


                    MemoryStream ms1 = new MemoryStream();
                    PIC_BED.Image.Save(ms1, PIC_BED.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_INSERT_T_H_BED(

                    TXTBEDNAME.Text
                    , Convert.ToInt32(nAME_ROOMComboBox.SelectedValue)
                    , Convert.ToInt32(fLOOR_NAMEComboBox.SelectedValue)
                    , imge1
                    , 0
                    , Convert.ToInt32(nAME_TYPE_BEDComboBox.SelectedValue)
                    , 1
                    , ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Save);
                        this.gET_H_BED_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_NAME_CODE, "");

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
                TXTBEDNAME.IsEmpty();

                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {


                    MemoryStream ms1 = new MemoryStream();
                    PIC_BED.Image.Save(ms1, PIC_BED.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_UPDATE_T_H_BED(
                   Convert.ToInt32(TXTID.Text)
                    , TXTBEDNAME.Text
                    , Convert.ToInt32(nAME_ROOMComboBox.SelectedValue)
                    , Convert.ToInt32(fLOOR_NAMEComboBox.SelectedValue)
                    , imge1
                    , 0
                    , Convert.ToInt32(nAME_TYPE_BEDComboBox.SelectedValue)
                    , 1
                    , ref CLS.SUBMIT_FLAG);


                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Update);
                        this.gET_H_BED_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_NAME_CODE, "");

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

            ClearTextBoxes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TXTBEDNAME.IsEmpty();

                if (MSG.Msg.MsgBoxResult(CLS.Q_MSG_UPDATE))
                {


                    MemoryStream ms1 = new MemoryStream();
                    PIC_BED.Image.Save(ms1, PIC_BED.Image.RawFormat);
                    imge1 = ms1.ToArray();
                    var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                    INSERTED.P_DELETE_T_H_bed(
                      Convert.ToInt32(TXTID.Text)
                    , 0
                    , ref CLS.SUBMIT_FLAG);

                    if (CLS.SUBMIT_FLAG == 1)
                    {
                        MSG.Msg.Alart(AlartType.Update);
                        this.gET_H_BED_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_NAME_CODE, "");

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


        bool Edit = false;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                TXTID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TXTBEDNAME.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                fLOOR_NAMEComboBox.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                nAME_ROOMComboBox.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
                if (dataGridView1.CurrentRow.Cells[5].Value.ToString() != string.Empty)
                {
                    byte[] imge1 = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                    MemoryStream ms1 = new MemoryStream(imge1);
                    PIC_BED.Image = Image.FromStream(ms1);
                }
                nAME_TYPE_BEDComboBox.SelectedValue = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);


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
                this.gET_H_BED_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_BED_NAME_CODE, textBox1.Text);
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



        private void PIC_BED_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "ملفات الصور|*.JPG;*.JPEG;*.PNG;*.GIF;*.BMP";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                PIC_BED.Image = Image.FromFile(ofd1.FileName);
            }
        }

        private void fLOOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fLOOR_NAMEComboBox.SelectedIndex != -1)
            {
                this.gET_H_ROOM_BYFLOOR_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ROOM_BYFLOOR_NAME_CODE, new System.Nullable<int>(((int)(System.Convert.ChangeType(fLOOR_NAMEComboBox.SelectedValue, typeof(int))))));

            }

        }



        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
   

       

