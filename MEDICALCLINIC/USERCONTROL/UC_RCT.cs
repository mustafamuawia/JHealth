using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.USERCONTROL
{
    public partial class UC_RCT : UserControl
    {
        List<string> ListDiag;
        
        public UC_RCT()
        {
            InitializeComponent();
            ListDiag = new List<string>();
            
        }

        private void btn_DoneAccessOpenings_Click(object sender, EventArgs e)
        {
            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "R.C.T";
            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = btn_DoneAccessOpenings.Text;

        }

        private void btn_CompleteObturation_Click(object sender, EventArgs e)
        {
            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "R.C.T";
            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = btn_CompleteObturation.Text;

        }

        private void chSCanal_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListDiag.Any(s => s == ((Control)sender).Name))
                {
                    //((Control)sender).BackColor = Color.Transparent;

                    ListDiag.Remove(((Control)sender).Name);
                    CLS.DiagnosisName.Remove(((Control)sender).Text);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.DiagnosisName);



                }
                else
                {

                    ListDiag.Add(((Control)sender).Name);

                    //((Control)sender).BackColor = Color.Red;
                    CLS.DiagnosisName.Add(((Control)sender).Text);
                      ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.DiagnosisName);
                      ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "R.C.T";
              
                }

            }
            catch
            {

            }
        }

        private void wlscanal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListDiag.Any(s => s == ((Control)sender).Name))
                {
                    //((Control)sender).BackColor = Color.Transparent;

                    ListDiag.Remove(((Control)sender).Name);
                    CLS.Treat1.Remove(((Control)sender).Text);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = ((Control)sender).Text;



                }
                else
                {

                    ListDiag.Add(((Control)sender).Name);

                    //((Control)sender).BackColor = Color.Red;
                    CLS.Treat1.Add(((Control)sender).Text);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = ((Control)sender).Text;
                }

            }
            catch
            {

            }
        }

        private void MchSCanal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListDiag.Any(s => s == ((Control)sender).Name))
                {
                    //((Control)sender).BackColor = Color.Transparent;

                    ListDiag.Remove(((Control)sender).Name);
                    CLS.Treat2.Remove(((Control)sender).Text);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = ((Control)sender).Text;



                }
                else
                {

                    ListDiag.Add(((Control)sender).Name);

                    //((Control)sender).BackColor = Color.Red;
                    CLS.Treat2.Add(((Control)sender).Text);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = ((Control)sender).Text;
                }

            }
            catch
            {

            }
        }
    }
}
