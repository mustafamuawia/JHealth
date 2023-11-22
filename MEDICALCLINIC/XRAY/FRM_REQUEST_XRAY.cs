using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.XRAY
{
    public partial class FRM_REQUEST_XRAY : Form
    {
        byte[] imge1, imge2, imge3, imge4;
        int PERSON_ID=-1, DOCTOR_ID=-1, BOOK_ID = -1;
        private System.Windows.Forms.ImageList imageList1;
        string V_SIDE = "", H_SIDE = "", COLOR_T="";
        decimal TOTAL_PRICE;
        public static DataTable DTT = new DataTable();
        public static int impotant_val = -1;
        public int panel_cek = 0;
       
        List<string> tooth;
        public FRM_REQUEST_XRAY(int PERSON_CODE,int DOCTOR_CODE,int BOOK_CODE)
        {
            InitializeComponent();
            PERSON_ID = PERSON_CODE;
            DOCTOR_ID = DOCTOR_CODE;
            BOOK_ID = BOOK_CODE;
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_REQUEST_XRAY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
           

            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_ROOMRAY' table. You can move, or remove it, as needed.
            this.v_GET_A_ROOMRAYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_ROOMRAY);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.T_PERSON' table. You can move, or remove it, as needed.
            this.t_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.T_PERSON);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            this.gET_REGION_BODY_CODENAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_REGION_BODY_CODENAME, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
            this.gET_RAY_NAME_CODENAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RAY_NAME_CODENAME, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));
            DataTable DTP = new DataTable();
            DTP = this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON;
            AutoCompleteStringCollection datasource3 = new AutoCompleteStringCollection();
            for (int i = 0; i < DTP.Rows.Count; i++)
            {
                datasource3.Add(DTP.Rows[i][1].ToString());
            }
            this.PERSON_COMB.AutoCompleteCustomSource = datasource3;
            this.PERSON_COMB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.PERSON_COMB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            PERSON_COMB.SelectedIndex = -1;
            DOCTOR_COMB.SelectedIndex = -1;
            PERSON_COMB.SelectedValue = PERSON_ID;
            LBL_RAY_NAME_PERSON.Text = PERSON_COMB.Text;
           
        }

         

        private void BTN_S_R_ALL_Click(object sender, EventArgs e)
        {
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_ID, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(3, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }

        private void BTN_S_R_RAY_Click(object sender, EventArgs e)
        {
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_ID, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }
         

        private void R_LOWER_CheckedChanged(object sender, EventArgs e)
        {
            V_SIDE = "LOWER";
        }

        private void R_LEFT_CheckedChanged(object sender, EventArgs e)
        {
            H_SIDE = "LEFT";
        }

        private void BTN_C_V_Click(object sender, EventArgs e)
        {
            R_UP.Checked = false;
            R_LOWER.Checked = false;
            V_SIDE = "";
        }

        private void R_RIGHT_CheckedChanged(object sender, EventArgs e)
        {
            H_SIDE = "RIGHT";
        }

        private void BTN_C_H_Click(object sender, EventArgs e)
        {
            R_LEFT.Checked = false;
            R_RIGHT.Checked = false;
            H_SIDE = "";
        }

        private void DGV_ALL_RAYS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM1 = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(DGV_ALL_RAYS.CurrentRow.Cells[16].Value.ToInt(), 2);
                FRM1.ShowDialog();
                //if (DGV_ALL_RAYS.CurrentRow.Cells[10].Value == null || DGV_ALL_RAYS.CurrentRow.Cells[10].Value == DBNull.Value)
                //{
                //    imge1 = new byte[0];
                //}
                //else
                //{

                //    imge1 = (byte[])DGV_ALL_RAYS.CurrentRow.Cells[10].Value;
                //}

                //if (DGV_ALL_RAYS.CurrentRow.Cells[11].Value == null || DGV_ALL_RAYS.CurrentRow.Cells[11].Value == DBNull.Value)
                //{
                //    imge2 = new byte[0];
                //}
                //else
                //{

                //    imge2 = (byte[])DGV_ALL_RAYS.CurrentRow.Cells[11].Value;
                //}

                //if (DGV_ALL_RAYS.CurrentRow.Cells[12].Value == null || DGV_ALL_RAYS.CurrentRow.Cells[12].Value == DBNull.Value)
                //{
                //    imge3 = new byte[0];
                //}
                //else
                //{

                //    imge3 = (byte[])DGV_ALL_RAYS.CurrentRow.Cells[12].Value;
                //}
                //if (DGV_ALL_RAYS.CurrentRow.Cells[13].Value == null || DGV_ALL_RAYS.CurrentRow.Cells[13].Value == DBNull.Value)
                //{
                //    imge4 = new byte[0];
                //}
                //else
                //{

                //    imge4 = (byte[])DGV_ALL_RAYS.CurrentRow.Cells[13].Value;
                //}
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            XRAY.FRM_SHOW_RAYS FRM = new XRAY.FRM_SHOW_RAYS(imge1, imge2, imge3, imge4);//imageList1);
            FRM.ShowDialog();
        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            COLOR_T = "COLOR";
        }

        private void RB_NO_CLR_CheckedChanged(object sender, EventArgs e)
        {
            COLOR_T = "NO COLOR";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RB_NO_CLR.Checked = false;
            RB_CLR.Checked = false;
            COLOR_T = "";
        }

        private void BTN_S_R_DATE_Click(object sender, EventArgs e)
        {
            this.gET_ALL_RAY_FOR_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_RAY_FOR_DOCTOR, new System.Nullable<int>(((int)(System.Convert.ChangeType(PERSON_ID, typeof(int))))), nAME_RAYSComboBox1.Text, new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))));

        }

        private void BTN_ADD_RAY_TODGV_Click(object sender, EventArgs e)
        {
            if (nAME_RAYSComboBox.SelectedIndex == -1)

            {
                MessageBox.Show("يرجى اختيار الاشعة ", CLS.TITEL_MESG);
                return;
            }
            else
            {

                DGV_X_SEND.Rows.Add(nAME_RAYSComboBox.Text, comb_toothname.Text, V_SIDE, H_SIDE, "color");
            }
        }

        private void BTN_SEND_Click(object sender, EventArgs e)
        {
            try
            {

                if (DGV_X_SEND.Rows.Count <= 0)
                {
                    MessageBox.Show("يرجى اضافة أشعه اولا", CLS.TITEL_MESG);
                    return;
                } 
                if (nAME_RoomComboBox.SelectedIndex ==-1)
                {
                    MessageBox.Show("يرجى اختيار غرفة ألاشعه اولا", CLS.TITEL_MESG);
                    return;
                } 
                if (DOCTOR_COMB.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى اختيار الطبيب اولا", CLS.TITEL_MESG);
                    return;
                }
                if (nAME_RoomComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى اضافة أشعه اولا", CLS.TITEL_MESG);
                    return;
                }

                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                // INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);
                //byte[] imge1;
                //byte[] imge2;
                //byte[] imge3;
                //byte[] imge4;


                //MemoryStream ms1 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms1, Properties.Resources.NOPIC.RawFormat);
                //imge1 = ms1.ToArray();

                //MemoryStream ms2 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms2, Properties.Resources.NOPIC.RawFormat);
                //imge2 = ms2.ToArray();
                //MemoryStream ms3 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms3, Properties.Resources.NOPIC.RawFormat);
                //imge3 = ms3.ToArray();

                //MemoryStream ms4 = new MemoryStream();
                //Properties.Resources.NOPIC.Save(ms4, Properties.Resources.NOPIC.RawFormat);
                //imge4 = ms4.ToArray();

                int BookId;
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED_D = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                BookId = int.Parse(
                  INSERTED.P_INSERT_T_RESULTRAY(
                 0
                , Convert.ToInt32(DOCTOR_COMB.SelectedValue)
                , Convert.ToInt32(BOOK_ID)
                , System.DateTime.Now
                , Convert.ToDecimal(0.00)
                , Convert.ToInt32(PERSON_ID)
                , false
                , false
                , Convert.ToInt32(nAME_RoomComboBox.SelectedValue)
                , ref CLS.SUBMIT_FLAG).ToString());

                for (int i = 0; i < DGV_X_SEND.Rows.Count; i++)
                {
                    INSERTED_D.P_INSERT_T_RESULTRAY_DETAILS(

                          DGV_X_SEND.Rows[i].Cells[0].Value.ToString()
                       , DGV_X_SEND.Rows[i].Cells[1].Value.ToString()
                       , DGV_X_SEND.Rows[i].Cells[3].Value.ToString()
                       , DGV_X_SEND.Rows[i].Cells[2].Value.ToString()
                       , DGV_X_SEND.Rows[i].Cells[4].Value.ToString()
                       , Convert.ToDecimal(0.00)
                       , ""
                       , false
                       , BookId
                       , null
                       , null
                       , null
                       , null
                        , ref CLS.SUBMIT_FLAG).ToString();

                }


                if (CLS.SUBMIT_FLAG == 1)
                {
                    MessageBox.Show("تمت العملية بنجاح", CLS.TITEL_MESG);

                    DGV_X_SEND.Rows.Clear();
                }


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void R_UP_CheckedChanged(object sender, EventArgs e)
        {
            V_SIDE = "UPPER";
        }
    }
}
