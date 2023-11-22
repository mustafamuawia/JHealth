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
    public partial class UC_Implant : UserControl
    {
        List<string> ListTreat1;
        public UC_Implant()
        {
            InitializeComponent();
            ListTreat1 = new List<string>();
        }

        private void btn_FixturePlacement_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in ListTreat1)
                {
                    var controls = tabControl1.SelectedTab.Controls.Find(x, false);
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

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Implant";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);

                }
                else
                {

                    ListTreat1.Add(((Control)sender).Name);
                    CLS.Treat1.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Implant";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);

                }
            }
            catch
            {

            }
        }

        private void btn_CrownBrdige_Click(object sender, EventArgs e)
        {
            USERCONTROL.UC_CrownBridge uC_CrownBrdge = new USERCONTROL.UC_CrownBridge();
            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).panel14.Controls.Add(uC_CrownBrdge);
            uC_CrownBrdge.Dock = DockStyle.Fill;
            uC_CrownBrdge.BringToFront();
        }

        private void btn_t_Crown_bridge_Click(object sender, EventArgs e)
        {
            USERCONTROL.UC_CrownBridge uC_CrownBrdge = new USERCONTROL.UC_CrownBridge();
            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).panel14.Controls.Add(uC_CrownBrdge);
            uC_CrownBrdge.Dock = DockStyle.Fill;
            uC_CrownBrdge.BringToFront();
        }

        private void btn_t_Fixture_Placement_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in ListTreat1)
                {
                    var controls = tabControl1.SelectedTab.Controls.Find(x, false);
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

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Implant";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);

                }
                else
                {

                    ListTreat1.Add(((Control)sender).Name);
                    CLS.Treat1.Add(((Control)sender).Text);
                    ((Control)sender).BackColor = Color.Red;

                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[2].Value = "Implant";
                    ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[3].Value = string.Join(" - ", CLS.Treat1);

                }
            }
            catch
            {

            }
        }


      
        private void txt_Diameter_TextChanged(object sender, EventArgs e)
        {
            string x="";
            if (chSinuslifting1.Checked)
            {
                x = chSinuslifting1.Text;
            }
            else
                if (chBonegraft1.Checked)
            {
                x = chBonegraft1.Text;
            }

            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = x+" - "+txt_Diameter.Text;

        }

        private void txt_MadeIn_TextChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Mode = rbSql.Checked == true ? "SQL" : "WIND";
            if (((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value ==null)
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = "";
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = txt_MadeIn.Text + "-";
            }
            else
            {
            string madein = (((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value.ToString()) == null ? "" : (((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value.ToString());
            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = "";

            ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = txt_MadeIn.Text + "-" +textBox1.Text;

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Mode = rbSql.Checked == true ? "SQL" : "WIND";
            if (((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value == null)
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = "";

            }
            else
            {
                string madein = (((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value.ToString()) == null ? "" : (((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value.ToString());
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = "";

                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = txt_MadeIn.Text+"-"+textBox1.Text ;

            }
        }

        private void chSinuslifting1_CheckedChanged(object sender, EventArgs e)
        {
            if (chSinuslifting1.Checked)
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", chSinuslifting1.Text+"-"+txt_Diameter.Text);

            }
            else
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = "";

            }
        }

        private void chBonegraft1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBonegraft1.Checked)
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", chBonegraft1.Text + "-" + txt_Diameter.Text);

            }
            else
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = "";

            }
        }

        private void chBasal1_CheckedChanged(object sender, EventArgs e)
        {
            if (chBasal1.Checked)
            {
                groupBox3.Enabled = false;
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", chBasal1.Text);

            }
            else
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = "";

            }
        }

        private void chComprsive1_CheckedChanged(object sender, EventArgs e)
        {
            if (chComprsive1.Checked)
            {
                groupBox3.Enabled = true;
              //  chonepice1.Enabled = true;
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = string.Join(" - ", chComprsive1.Text);

            }
            else
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[4].Value = "";
                groupBox3.Enabled = false;
            }
        }

        private void chonepice1_CheckedChanged(object sender, EventArgs e)
        {
            if (chonepice1.Checked)
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = string.Join(" - ", chonepice1.Text);

            }
            else
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = "";

            }
        }

        private void chtowpice1_CheckedChanged(object sender, EventArgs e)
        {
            if (chtowpice1.Checked)
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = string.Join(" - ", chtowpice1.Text);

            }
            else
            {
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows[((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DGV_ALL_Tooth.Rows.Count - 1].Cells[5].Value = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
