using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.PERSONS
{
    public partial class FRM_SEARCH_PERSON : Form
    {
        int F_SEARCH;

        public FRM_SEARCH_PERSON(int FLAGES)
        {
            InitializeComponent();
            F_SEARCH = FLAGES;
        }

        

        
     

       

        
       

        private void FRM_SEARCH_SANAD_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_NAME_CODE, "");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TXT_SEARCH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_PERSON_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_PERSON_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] imge1 = null;
            if (F_SEARCH==0)
            {
                ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).flges =
                Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) ;
                ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).pERSON_NAMEComboBox.SelectedValue =
                   Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).getidpersonforedit =
             Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                
             //((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).pERSON_NAMEComboBox.SelectedIndex =
             //  dataGridView2.CurrentRow.Cells[1].Value.ToString();
             ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).SEX_COMB.SelectedValue =
                 Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).AGE_TextBoxX.Text =
                   dataGridView2.CurrentRow.Cells[4].Value.ToString();
                ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).TXT_PHONE.Text =
                   dataGridView2.CurrentRow.Cells[5].Value.ToString();
                ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).dOCTOR_NAMEComboBox.SelectedValue =
             Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());

                ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).TXT_ADDRESS.Text =
                      dataGridView2.CurrentRow.Cells[6].Value.ToString();
               
                if (dataGridView2.CurrentRow.Cells[7].Value.ToString() != string.Empty)
                {
                    imge1 = (byte[])dataGridView2.CurrentRow.Cells[7].Value;
                    MemoryStream ms1 = new MemoryStream(imge1);
                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).pictureBox1.Image = Image.FromStream(ms1);
                }
                else{
                    imge1 = null;
                }
                    ((PERSONS.FRM_PERSON)Application.OpenForms["FRM_PERSON"]).TXT_NOTE.Text =
                          dataGridView2.CurrentRow.Cells[8].Value.ToString();
               
            }
            else
            if (F_SEARCH==1)
            {


                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).PERSON_CODETextBoxX.Text =
                   dataGridView2.CurrentRow.Cells[0].Value.ToString();
                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).PERSON_NAME_ARTextBoxX.Text =
                   dataGridView2.CurrentRow.Cells[1].Value.ToString();
                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).SEX_COMB.SelectedValue =
                 Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).AGE_TextBoxX.Text =
                   dataGridView2.CurrentRow.Cells[4].Value.ToString();
                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_PHONE.Text =
                   dataGridView2.CurrentRow.Cells[5].Value.ToString();
          //      ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).dOCTOR_NAMEComboBox.SelectedValue =
          //Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());

                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_ADDRESS.Text =
                      dataGridView2.CurrentRow.Cells[6].Value.ToString();

               
                //((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).dOCTOR_NAMEComboBox.SelectedValue =
                //  Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value.ToString());
                if (dataGridView2.CurrentRow.Cells[7].Value.ToString() != string.Empty)
                {
                      imge1 = (byte[])dataGridView2.CurrentRow.Cells[7].Value;
                    MemoryStream ms1 = new MemoryStream(imge1);
                    ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).pictureBox1.Image = Image.FromStream(ms1);
                }
                else
                {
                    imge1 = null;
                }
                    ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_NOTE.Text =
                          dataGridView2.CurrentRow.Cells[8].Value.ToString();

                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_JOB.Text =
               dataGridView2.CurrentRow.Cells[10].Value.ToString();

                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_ID_NUM.Text =
                          dataGridView2.CurrentRow.Cells[11].Value.ToString();
                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_ID_REC.Text =
               dataGridView2.CurrentRow.Cells[12].Value.ToString();
                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_ID_PAGE.Text =
                          dataGridView2.CurrentRow.Cells[13].Value.ToString();

                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_ID_NUMF.Text =
               dataGridView2.CurrentRow.Cells[14].Value.ToString();
                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_ID_RECF.Text =
               dataGridView2.CurrentRow.Cells[15].Value.ToString();
                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_ID_PAGEF.Text =
                          dataGridView2.CurrentRow.Cells[16].Value.ToString();
                
                ((HOSPITAL.FRM_H_GETBOOK)Application.OpenForms["FRM_H_GETBOOK"]).TXT_FATHER.Text =
               dataGridView2.CurrentRow.Cells[18].Value.ToString();

            }
            else
            if (F_SEARCH ==2)
            {

                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).PERSON_CODETextBoxX.Text =
                   dataGridView2.CurrentRow.Cells[0].Value.ToString();
                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).PERSON_NAME_ARTextBoxX.Text =
                   dataGridView2.CurrentRow.Cells[1].Value.ToString();
                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).SEX_COMB.SelectedValue =
                 Convert.ToInt32(dataGridView2.CurrentRow.Cells[3].Value.ToString());
                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).AGE_TextBoxX.Text =
                   dataGridView2.CurrentRow.Cells[4].Value.ToString();
                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_PHONE.Text =
                   dataGridView2.CurrentRow.Cells[5].Value.ToString();
              
                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_ADDRESS.Text =
                      dataGridView2.CurrentRow.Cells[6].Value.ToString();

                 if (dataGridView2.CurrentRow.Cells[7].Value.ToString() != string.Empty)
                {
                    imge1 = (byte[])dataGridView2.CurrentRow.Cells[7].Value;
                    MemoryStream ms1 = new MemoryStream(imge1);
                    ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).pictureBox1.Image = Image.FromStream(ms1);
                }
                    ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_NOTE.Text =
                          dataGridView2.CurrentRow.Cells[8].Value.ToString();

                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_JOB.Text =
               dataGridView2.CurrentRow.Cells[10].Value.ToString();

                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_ID_NUM.Text =
                          dataGridView2.CurrentRow.Cells[11].Value.ToString();
                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_ID_REC.Text =
               dataGridView2.CurrentRow.Cells[12].Value.ToString();
                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_ID_PAGE.Text =
                          dataGridView2.CurrentRow.Cells[13].Value.ToString();

                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_ID_NUMF.Text =
               dataGridView2.CurrentRow.Cells[14].Value.ToString();
                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_ID_RECF.Text =
               dataGridView2.CurrentRow.Cells[15].Value.ToString();
                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_ID_PAGEF.Text =
                          dataGridView2.CurrentRow.Cells[16].Value.ToString();

                ((HOSPITAL.SETTING_H.FRM_H_PERSON)Application.OpenForms["FRM_H_PERSON"]).TXT_FATHER.Text =
               dataGridView2.CurrentRow.Cells[18].Value.ToString();

            }
            //FRM_H_PERSON

            this.Close();
             

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {
            dataGridView2_CellContentClick(null, null);
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
 
    }
}
