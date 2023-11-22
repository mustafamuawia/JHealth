using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.REPORTS
{
    public partial class FRM_OP_ACCESSORIES : Form
    {
        int CODE_OP;
        public FRM_OP_ACCESSORIES( int ID_OP)
        {
            InitializeComponent();
            CODE_OP = ID_OP;
        }

        public FRM_OP_ACCESSORIES( )
        {
            InitializeComponent();
            
        }

        private void FRM_OP_ACCESSORIES_Load(object sender, EventArgs e)
        {
            try
            {
              
                this.gET_H_OPERATION_ACCESSORIESTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_ACCESSORIES, new System.Nullable<int>(((int)(System.Convert.ChangeType( CODE_OP, typeof(int))))));
                if (this.mEDICAL_CLINIC_DBDataSet.GET_H_OPERATION_ACCESSORIES.Rows.Count>0)
                {
                    LBL_TOTAL.Text =
                                (from DataGridViewRow row in gET_H_OPERATION_ACCESSORIESDataGridView.Rows
                                 where row.Cells[2].FormattedValue.ToString() != string.Empty
                                 select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString("#,##0.00");
                }

                

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
