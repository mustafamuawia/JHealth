using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.LAB
{

    public partial class FRM_SEND_TO_LABTEST : MEDICALCLINIC.LAB.baselab
    {


        int book_id = -1, person_id = -1, doctor_id = -1;
        public FRM_SEND_TO_LABTEST(int person_code,int book_code)
        {
            InitializeComponent();
            person_id = person_code;
            book_id = book_code;
        }
        public FRM_SEND_TO_LABTEST()
        {
            InitializeComponent();
           
        }
        private void FRM_SEND_TO_LABTEST_Load(object sender, EventArgs e)
        {

            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR' table. You can move, or remove it, as needed.
            this.v_A_DOCTORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_DOCTOR);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_PERSON' table. You can move, or remove it, as needed.
            this.v_A_PERSONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_L_GET_A_LABNAME' table. You can move, or remove it, as needed.
            this.v_L_GET_A_LABNAMETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_L_GET_A_LABNAME);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG' table. You can move, or remove it, as needed.
            this.v_GET_A_L_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_A_L_CATEG);
            //  pERSON_NAMEComboBox.SelectedIndex = -1;
          

            DataTable DTP = new DataTable();
            DTP = this.mEDICAL_CLINIC_DBDataSet.V_A_PERSON;
            AutoCompleteStringCollection datasource3 = new AutoCompleteStringCollection();
            for (int i = 0; i < DTP.Rows.Count; i++)
            {
                datasource3.Add(DTP.Rows[i][1].ToString());
            }
            this.pERSON_NAMEComboBox.AutoCompleteCustomSource = datasource3;
            this.pERSON_NAMEComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.pERSON_NAMEComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            pERSON_NAMEComboBox.SelectedValue = person_id;
            dOCTOR_NAMEComboBox.SelectedIndex = doctor_id;
            lbl_l_paitent_name.Text = pERSON_NAMEComboBox.Text;
        }



        private void nAME_CATEGComboBox_SelectedIndexChanged(object sender, EventArgs e)
         {
            //    try
            //    {
            //        this.gET_L_TEST_NAMECODE_BYCATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAMECODE_BYCATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox.SelectedValue, typeof(int))))));
            //    }
            //    catch (System.Exception ex)
            //    {
            //        System.Windows.Forms.MessageBox.Show(ex.Message);
            //    }

            try
            {
                this.gET_LAB_TEST_BY_CATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_LAB_TEST_BY_CATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //test
        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //             gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter
        //        this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTESTPERSON_FOR_DOCTORY, person_id, new System.Nullable<int>(((int)(System.Convert.ChangeType(iD_TESTToolStripTextBox.Text, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(fLAG_COMPToolStripTextBox.Text, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(fLAG_ALLToolStripTextBox.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(datenowToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void BTN_SEARCH_ALL_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTESTPERSON_FOR_DOCTORY, person_id.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_SEARCH_TESTNAME_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTESTPERSON_FOR_DOCTORY,person_id.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_TESTComboBox1.SelectedValue, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("يرجى تحديد اسم التحليل اولا");
            }
        }

        private void BTN_SEARCH_DATE_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_LABTESTPERSON_FOR_DOCTORYTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTESTPERSON_FOR_DOCTORY, person_id.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_ADD_GRD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gET_LAB_TEST_BY_CATEGDataGridView.Rows.Count; i++)
            {

                DGV_TEST_SENT.Rows.Add(
                gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[0].Value.ToString(),
                gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[1].Value.ToString(),
                gET_LAB_TEST_BY_CATEGDataGridView.Rows[i].Cells[5].Value.ToString(),
                "");

            }
            //if (nAME_TESTComboBox.SelectedIndex != -1 && nAME_CATEGComboBox.SelectedIndex != -1)
            //{

            //    int FoodIndex = -1;

            //        for (int i = 0; i < DGV_TEST_SENT.Rows.Count; i++)
            //        {
            //            if (nAME_TESTComboBox.SelectedText.ToString().Equals(DGV_TEST_SENT.Rows[i].Cells[1].Value.ToString()))
            //                FoodIndex = i;

            //        }
            //        if (FoodIndex == -1)
            //        {
            //            DGV_TEST_SENT.Rows.Add(nAME_TESTComboBox.SelectedValue, nAME_TESTComboBox.Text, "");
            //            nAME_TESTComboBox.SelectedIndex = -1;
            //        }
            //        else
            //        {
            //            MessageBox.Show("التحليل موجود مسبقا");
            //            return;
            //        }












            //}
            //else
            //{
            //    MessageBox.Show("اختار التحليل اولا ", CLS.TITEL_MESG);
            //    return;
            //}

        }

        private void pERSON_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            person_id =Convert.ToInt32( pERSON_NAMEComboBox.SelectedValue);
            lbl_l_paitent_name.Text = pERSON_NAMEComboBox.Text;
        }

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           doctor_id = Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue);
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void nAME_CATEGComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                this.gET_L_TEST_NAMECODE_BYCATEGTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_L_TEST_NAMECODE_BYCATEG, new System.Nullable<int>(((int)(System.Convert.ChangeType(nAME_CATEGComboBox1.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void DGV_TEST_SENT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    DGV_TEST_SENT.Rows.RemoveAt(DGV_TEST_SENT.CurrentRow.Index);

                }
            }
        }

        private void gET_LAB_TEST_BY_CATEGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 16)
            {
                if (nAME_CATEGComboBox.SelectedIndex != -1)
                {
                    int FoodIndex = -1;

                    for (int i = 0; i < DGV_TEST_SENT.Rows.Count; i++)
                    {
                        if (gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString().Equals(DGV_TEST_SENT.Rows[i].Cells[0].Value.ToString()))
                            FoodIndex = i;

                    }
                    if (FoodIndex == -1)
                    {
                        DGV_TEST_SENT.Rows.Add(gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[0].Value.ToString(), gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[1].Value.ToString(), gET_LAB_TEST_BY_CATEGDataGridView.CurrentRow.Cells[5].Value.ToString(), "");

                    }
                    else
                    {
                        MessageBox.Show("التحليل موجود مسبقا");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("اختار التحليل اولا ", CLS.TITEL_MESG);
                    return;
                }
            }
        }

        private void DGV_ALL_TEST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                ADDPICT_GENE.FRM_IMG_BOOKING_SHOW FRM = new ADDPICT_GENE.FRM_IMG_BOOKING_SHOW(Convert.ToInt32(DGV_ALL_TEST.CurrentRow.Cells[19].Value), 1);
                FRM.ShowDialog();
           
        }

        private void BTN_SAVESENTTEST_Click(object sender, EventArgs e)
        {
            try
            {

                if (DGV_TEST_SENT.Rows.Count <= 0)
                {
                    MessageBox.Show("يرجى اضافة تحليل اولا", CLS.TITEL_MESG);
                    return;
                }
                if (pERSON_NAMEComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى تحديد اسم المريض اولا", CLS.TITEL_MESG);
                    return;
                }

                if (dOCTOR_NAMEComboBox.SelectedIndex==-1)
                {
                    MessageBox.Show("يرجى تحديد اسم الدكتوراولا", CLS.TITEL_MESG);
                    return;
                }
                if (nAME_LABComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("يرجى اضافة تحليل اولا", CLS.TITEL_MESG);
                    return;
                }

                var INSERTED_IS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                // INSERTED_IS.P_CHECK_IS_BOOKING(Convert.ToInt32(LBL_NAMEPERSON.SelectedValue), Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue), Convert.ToDateTime(DATE_BOOKING.Value), ref CLS.SUBMIT_IS_BOOK);



                int BookId;
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                var INSERTED_D = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

                BookId = int.Parse(
                  INSERTED.P_INSERT_L_RESTESTNAME(
                 0
                , doctor_id
                , Convert.ToInt32(book_id)
                , System.DateTime.Now
                , Convert.ToDecimal(0.00)
                , Convert.ToInt32(person_id)
                , false
                , false
                , Convert.ToInt32(nAME_LABComboBox.SelectedValue)
                ,""
                ,0
                , ref CLS.SUBMIT_FLAG).ToString());

                for (int i = 0; i < DGV_TEST_SENT.Rows.Count; i++)
                {
                    INSERTED_D.P_INSERT_L_RESTESTNAME_DETAILS(
                        Convert.ToInt32(DGV_TEST_SENT.Rows[i].Cells[0].Value)
                        , ""
                        , Convert.ToDecimal(DGV_TEST_SENT.Rows[i].Cells[2].Value)
                        , DGV_TEST_SENT.Rows[i].Cells[3].Value.ToString()
                        , false
                        , BookId
                        , ref CLS.SUBMIT_FLAG);
                }


                if (CLS.SUBMIT_FLAG == 1)
                {
                    MSG.Msg.Alart(AlartType.Save);
                    DGV_TEST_SENT.Rows.Clear();
                }


            }
            catch
            {

            }
        }

        private void BTN_REFESH_Click(object sender, EventArgs e)
        {
            try
            {
                this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(person_id.ToString(), typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(true, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(false, typeof(bool))))), System.DateTime.Now);


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //private void fillToolStripButton_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //            
        //        this.gET_ALL_LABTEST_DOTCOTUSER_FOR_LABTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB, new System.Nullable<int>(((int)(System.Convert.ChangeType(iD_VARToolStripTextBox.Text, typeof(int))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(fLAG_COMPToolStripTextBox.Text, typeof(bool))))), new System.Nullable<bool>(((bool)(System.Convert.ChangeType(fLAG_ALLToolStripTextBox.Text, typeof(bool))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(datenowToolStripTextBox.Text, typeof(System.DateTime))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
