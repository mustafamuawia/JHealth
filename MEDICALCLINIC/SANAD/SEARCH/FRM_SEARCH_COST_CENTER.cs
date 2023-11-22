using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.SANAD.SEARCH
{
    public partial class FRM_SEARCH_COST_CENTER : Form
    {
        public FRM_SEARCH_COST_CENTER()
        {
            InitializeComponent();
        }

       

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_SEARCH_COST_CENTER_Load(object sender, EventArgs e)
        {
            try
            {
                this.gET_COST_CENTER_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_NAME_CODE, TXT_SEARCH.Text);
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
                this.gET_COST_CENTER_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_COST_CENTER_NAME_CODE, TXT_SEARCH.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gET_COST_CENTER_NAME_CODEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ((SANAD.FRM_COST_CENTER)Application.OpenForms["FRM_COST_CENTER"]).aCCOUNT_FULL_NAMEComboBox.SelectedValue =
              gET_COST_CENTER_NAME_CODEDataGridView.CurrentRow.Cells[4].Value.ToString();
            ((SANAD.FRM_COST_CENTER)Application.OpenForms["FRM_COST_CENTER"]).nAME_COST_CENTERComboBox.SelectedValue =
             gET_COST_CENTER_NAME_CODEDataGridView.CurrentRow.Cells[5].Value.ToString();
            ((SANAD.FRM_COST_CENTER)Application.OpenForms["FRM_COST_CENTER"]).TXT_NAME_COST_CENTER.Text =
             gET_COST_CENTER_NAME_CODEDataGridView.CurrentRow.Cells[1].Value.ToString();
            ((SANAD.FRM_COST_CENTER)Application.OpenForms["FRM_COST_CENTER"]).TXT_CODE_COST_CENTER.Text =
             gET_COST_CENTER_NAME_CODEDataGridView.CurrentRow.Cells[0].Value.ToString();
            ((SANAD.FRM_COST_CENTER)Application.OpenForms["FRM_COST_CENTER"]).aCCOUNT_COST_TYPE_NAMEComboBox.SelectedValue =
            gET_COST_CENTER_NAME_CODEDataGridView.CurrentRow.Cells[8].Value.ToString();
            ((SANAD.FRM_COST_CENTER)Application.OpenForms["FRM_COST_CENTER"]).fLOOR_NAMEComboBox.SelectedValue =
            gET_COST_CENTER_NAME_CODEDataGridView.CurrentRow.Cells[7].Value.ToString();
            this.Dispose();
        }
    }
}
