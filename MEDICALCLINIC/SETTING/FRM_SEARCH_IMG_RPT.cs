using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING
{
    public partial class FRM_SEARCH_IMG_RPT : Form
    {
      
        public FRM_SEARCH_IMG_RPT( )
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

        private void FRM_ADD_OPERATN_INFO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.GET_RPT_IMG_NAME_CODE' table. You can move, or remove it, as needed.
            this.gET_RPT_IMG_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMG_NAME_CODE);
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.GET_RPT_IMG_NAME_CODE' table. You can move, or remove it, as needed.
            this.gET_RPT_IMG_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMG_NAME_CODE);
             
        }
 

       

        private void gET_RPT_IMG_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex==7)
            {
                ((REPORT.FRM_ADD_RPT_IMG_TBL)Application.OpenForms["FRM_ADD_RPT_IMG_TBL"]).rPT_NAMEComboBox.SelectedValue = gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[0].Value.ToString();
                //((REPORT.FRM_ADD_RPT_IMG_TBL)Application.OpenForms["FRM_ADD_RPT_IMG_TBL"]).rPT_NAMEComboBox.Text = gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[6].Value.ToString();
                if (gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString() != string.Empty)
                {
                    byte[] imge1 = (byte[])gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[1].Value;
                    MemoryStream ms1 = new MemoryStream(imge1);
                    ((REPORT.FRM_ADD_RPT_IMG_TBL)Application.OpenForms["FRM_ADD_RPT_IMG_TBL"]).IMG_HEADER.Image = Image.FromStream(ms1);
                }
                if (gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[2].Value.ToString() != string.Empty)
                {
                    byte[] imge2 = (byte[])gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[2].Value;
                    MemoryStream ms2 = new MemoryStream(imge2);
                    ((REPORT.FRM_ADD_RPT_IMG_TBL)Application.OpenForms["FRM_ADD_RPT_IMG_TBL"]).IMG_BODY.Image = Image.FromStream(ms2);
                }
                if (gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[3].Value.ToString() != string.Empty)
                {
                    byte[] imge3 = (byte[])gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[3].Value;
                    MemoryStream ms3 = new MemoryStream(imge3);
                    ((REPORT.FRM_ADD_RPT_IMG_TBL)Application.OpenForms["FRM_ADD_RPT_IMG_TBL"]).IMG_FOOTER.Image = Image.FromStream(ms3);
                    if (gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[4].Value.ToString() != string.Empty)
                    {
                        byte[] imge4 = (byte[])gET_RPT_IMG_NAME_CODEDataGridView.CurrentRow.Cells[4].Value;
                        MemoryStream ms4 = new MemoryStream(imge4);
                        ((REPORT.FRM_ADD_RPT_IMG_TBL)Application.OpenForms["FRM_ADD_RPT_IMG_TBL"]).IMG_LOGO.Image = Image.FromStream(ms4);
                   
                        
                        }
                    this.Close();
                }
            }
      
        }

        private void BTN_DETAILS_Click(object sender, EventArgs e)
        {

        }
    }
}
