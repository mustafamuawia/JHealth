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
    public partial class UC_CrownBridge : UserControl
    {
        List<string> Diagnosis;
        List<string> ListTreat1;
        List<string> ListTreat2;
        List<string> ListTreat3;
        public UC_CrownBridge()
        {
            InitializeComponent();
            Diagnosis = new List<string>();
            ListTreat1 = new List<string>();
            ListTreat2 = new List<string>();
            ListTreat3 = new List<string>();
        }

        private void btn_Crown_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in Diagnosis)
                {
                    var controls = groupBox2.Controls.Find(x, false);
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
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = string.Join(" - ", CLS.DiagnosisName);
                }
                else
                {
                    Diagnosis.Add(((Control)sender).Name);
                    CLS.DiagnosisName.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = string.Join(" - ", CLS.DiagnosisName);
                    grSessionName.Enabled = true;
                }
            }
            catch
            {

            }
        }

        private void btn_Prepration_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in ListTreat1)
                {
                    var controls = grSessionName.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                ListTreat1.Clear();
                CLS.Treat1.Clear();
                if (ListTreat1.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    ListTreat1.Remove(((Control)sender).Name);
                    CLS.Treat1.Remove(((Control)sender).Text);

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);
                }
                else
                {

                    ListTreat1.Add(((Control)sender).Name);
                    CLS.Treat1.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);
                    grFixProsthesisType.Enabled = true;
                }
            }
            catch
            {

            }
        }

        private void btn_PFM_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in ListTreat2)
                {
                    var controls = grFixProsthesisType.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                ListTreat2.Clear();
                CLS.Treat2.Clear();
                if (ListTreat2.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    ListTreat2.Remove(((Control)sender).Name);
                    CLS.Treat2.Remove(((Control)sender).Text);

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", CLS.Treat2);
                }
                else
                {

                    ListTreat2.Add(((Control)sender).Name);
                    CLS.Treat2.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", CLS.Treat2);

                }
                //grFixProsthesisType.Enabled = true;
                //if (((Control)sender).Name=="btn_EMax")
                //{
                //    grEMaxTypes.Enabled = true;
                //}
            }
            catch
            {

            }
        }

        private void btn_Veneer_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in ListTreat3)
                {
                    var controls = grEMaxTypes.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                ListTreat3.Clear();
                CLS.Treat3.Clear();
                if (ListTreat3.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    ListTreat3.Remove(((Control)sender).Name);
                    CLS.Treat3.Remove(((Control)sender).Text);

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = string.Join(" - ", CLS.Treat3);
                }
                else
                {

                    ListTreat3.Add(((Control)sender).Name);
                    CLS.Treat3.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = string.Join(" - ", CLS.Treat3);
                   
                }
            }
            catch
            {

            }
        }
    }
}
