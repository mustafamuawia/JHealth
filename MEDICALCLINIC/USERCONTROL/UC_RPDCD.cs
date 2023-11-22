using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MEDICALCLINIC.USERCONTROL
{
    public partial class UC_RPDCD : UserControl
    {

        List<string> ListDiag;
        List<string> Diagnosis;
        List<string> Diagnosis1;
        List<string> ListTreat1; 
        List<string> ListTreat2;
        public UC_RPDCD()
        {
            InitializeComponent();
            Diagnosis = new List<string>();
            Diagnosis1 = new List<string>();
            ListTreat1 = new List<string>();
            ListTreat2 = new List<string>();
            ListDiag = new List<string>();
        }

        private void btn_Impresion_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in Diagnosis)
                {
                    var controls = tabControl1.SelectedTab.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                Diagnosis.Clear();
                CLS.DiagnosisName.Clear();
                if (Diagnosis.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    Diagnosis.Remove(((Control)sender).Name);
                    CLS.DiagnosisName.Remove(((Control)sender).Text);

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Reomvable Partial Denture";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.DiagnosisName);
                }
                else
                {

                    Diagnosis.Add(((Control)sender).Name);
                    CLS.DiagnosisName.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Reomvable Partial Denture";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.DiagnosisName);

                }
            }
            catch
            {

            }
        }

        private void btn_UpperDenture_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in Diagnosis)
                {
                    var controls = tabControl1.SelectedTab.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                Diagnosis.Clear();
                CLS.Treat1.Clear();
                if (Diagnosis.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    Diagnosis.Remove(((Control)sender).Name);
                    CLS.Treat1.Remove(((Control)sender).Text);

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Complete Denture";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[1].Value = string.Join(" - ", CLS.Treat1);
                }
                else
                {

                    Diagnosis.Add(((Control)sender).Name);
                    CLS.Treat1.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Complete Denture";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[1].Value = string.Join(" - ", CLS.Treat1);

                }
            }
            catch
            {

            }
        }

        private void ch_CL1_CheckedChanged(object sender, EventArgs e)
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
                }

            }
            catch
            {

            }
        }

        private void chPI_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListDiag.Any(s => s == ((Control)sender).Name))
                {
                    //((Control)sender).BackColor = Color.Transparent;

                    ListDiag.Remove(((Control)sender).Name);
                    CLS.Treat2.Remove(((Control)sender).Text);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", CLS.Treat2);



                }
                else
                {

                    ListDiag.Add(((Control)sender).Name);

                    //((Control)sender).BackColor = Color.Red;
                    CLS.Treat2.Add(((Control)sender).Text);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", CLS.Treat2);
                }

            }
            catch
            {

            }
        }

        private void BTN_UPPER_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in Diagnosis1)
                {
                    var controls = tabControl1.SelectedTab.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                Diagnosis1.Clear();
                CLS.Treat1.Clear();
                if (Diagnosis1.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    Diagnosis1.Remove(((Control)sender).Name);
                    CLS.Treat1.Remove(((Control)sender).Text);

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Complete Denture";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[1].Value = string.Join(" - ", CLS.Treat1);
                }
                else
                {

                    Diagnosis1.Add(((Control)sender).Name);
                    CLS.Treat1.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Complete Denture";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[1].Value = string.Join(" - ", CLS.Treat1);

                }
            }
            catch
            {

            }
        }
    }
}
