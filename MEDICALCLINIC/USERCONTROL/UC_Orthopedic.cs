using DevComponents.DotNetBar;
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
    public partial class UC_Orthopedic : UserControl
    {
        List<string> ListDiag;
        List<string> Diagnosis;
        List<string> Diagnosis1;
        List<string> ListTreat1;
        List<string> ListTreat2;
        List<string> Classification;
        string val;
        string valortho;
        string crdtxt;
        string txtopenbite,txtoverjet;
        string wiretxt,OrthoTypetxt;

        public UC_Orthopedic()
        {
            InitializeComponent();
            Diagnosis = new List<string>();
            Diagnosis1 = new List<string>();
            ListTreat1 = new List<string>();
            ListTreat2 = new List<string>();
            Classification = new List<string>();
            ListDiag = new List<string>();
           
        }



        private void btn_Extraction_Click(object sender, EventArgs e)
        {

          
                USERCONTROL.UC_Extraction uC_Extraction = new USERCONTROL.UC_Extraction();

                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).panel14.Controls.Add(uC_Extraction);
                
                uC_Extraction.Dock = DockStyle.Fill;
                uC_Extraction.BringToFront();
                
           
        }

        private void chCL1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                
                foreach (var x in Classification)
                {
                    var controls = groupBox9.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                Classification.Clear();
                CLS.DiagnosisName.Clear();
                if (Classification.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    Classification.Remove(((Control)sender).Name);
                    CLS.DiagnosisName.Remove(((Control)sender).Text);
                    val = string.Join(" - ", CLS.DiagnosisName);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = val + "-" + crdtxt + "-" + wiretxt;
                }
                else
                {

                    Classification.Add(((Control)sender).Name);
                    CLS.DiagnosisName.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                    val = string.Join(" - ", CLS.DiagnosisName);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = val + "-" + crdtxt + "-" + wiretxt;

                }
            }
            catch
            {

            }


        }

        private void chCLII_CheckedChanged(object sender, EventArgs e)
        {
            if (chCLII.Checked)
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = string.Join(" - ", chCLII.Text);

            }
            else
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "";

            }
        }

        private void chCLIII_CheckedChanged(object sender, EventArgs e)
        {
            if (chCLIII.Checked)
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = string.Join(" - ", chCLIII.Text);

            }
            else
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "";

            }
        }

        private void btn_UpperDenture_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in Diagnosis)
                {
                    var controls = groupBox5.Controls.Find(x, false);
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

                     ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[1].Value = string.Join(" Orthopedic- ", CLS.Treat1);
                }
                else
                {

                    Diagnosis.Add(((Control)sender).Name);
                    CLS.Treat1.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                  
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[1].Value = string.Join(" Orthopedic- ", CLS.Treat1);

                }
            }
            catch
            {

            }
        }

        private void btn_Fixed_typ_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in Diagnosis1)
                {
                    var controls = groupBox11.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.FromArgb(16, 127, 201);
                }
                Diagnosis1.Clear();
                CLS.Treat3.Clear();
                if (Diagnosis1.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.FromArgb(16, 127, 201);
                    Diagnosis1.Remove(((Control)sender).Name);
                    CLS.Treat3.Remove(((Control)sender).Text);
                    valortho = string.Join(" - ", CLS.Treat3);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = valortho + "-" + OrthoTypetxt;
                }
                else
                {

                    Diagnosis1.Add(((Control)sender).Name);
                    CLS.Treat3.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                    valortho = string.Join(" - ", CLS.Treat3);
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = valortho+"-"+ OrthoTypetxt;

                }
            }
            catch
            {

            }
        }

        private void txt_Crowding_TextChanged(object sender, EventArgs e)
         {
            if (txt_Crowding.Text ==String.Empty || txt_Crowding.Text =="")
            {
                crdtxt = "";
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = val + "-" + crdtxt + "-" + wiretxt;

            }
            else
            {
                crdtxt = "Crowding:" + txt_Crowding.Text;
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = val + "-" + crdtxt + "-" + wiretxt;

            }

        }

        private void txt_WireSize_TextChanged(object sender, EventArgs e)
        {
            if (txt_WireSize.Text == String.Empty || txt_WireSize.Text == "")
            {
                 wiretxt = "";
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = val + "-" + crdtxt + "-" + wiretxt;

            }
            else
            {
                wiretxt = "WireSize:" + txt_WireSize.Text;
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = val + "-" + crdtxt + "-" + wiretxt;

            }
        }

        private void txt_Seesion_Action_TextChanged(object sender, EventArgs e)
        {
            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = txt_Seesion_Action.Text;

        }

        private void txt_Overjet_TextChanged(object sender, EventArgs e)
        {
            if (txt_Overjet.Text == String.Empty || txt_Overjet.Text == "")
            {
                txtoverjet = "";
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = txtopenbite + "-" + txtoverjet;

            }
            else
            {
                txtoverjet = "Overet:" + txt_Overjet.Text;
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = txtopenbite + "-" + txtoverjet;

            }
        }

        private void txt_openbite_TextChanged(object sender, EventArgs e)
        {
            if (txt_openbite.Text == String.Empty || txt_openbite.Text == "")
            {
                txtopenbite = "";
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = txtopenbite + "-" + txtoverjet;

            }
            else
            {
                txtopenbite = "Openbite:" + txt_openbite.Text;
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = txtopenbite + "-" + txtoverjet;

            }
        }

        private void txt_Removable_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_Removable_name.Text == String.Empty || txt_Removable_name.Text == "")
            {
                OrthoTypetxt = "";
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", valortho + "-" + OrthoTypetxt);

            }
            else
            {
                OrthoTypetxt = txt_Removable_name.Text;
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", valortho + "-"+ OrthoTypetxt);

            }
        }
    }
}
