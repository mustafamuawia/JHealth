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
    public partial class UC_Extraction : UserControl
    {
        List<string> ListTreat1;
        public UC_Extraction()
        {
            InitializeComponent();
            ListTreat1 = new List<string>();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_NormalExtraction_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in ListTreat1)
                {
                    var controls = groupBox1.Controls.Find(x, false);
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
                    
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Extraction";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);

                }
                else
                {

                    ListTreat1.Add(((Control)sender).Name);
                    CLS.Treat1.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;
                     
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Extraction";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);

                }
            }
            catch
            {

            }
        }
    }
}
