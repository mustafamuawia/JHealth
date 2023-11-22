using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace MEDICALCLINIC.TOOTH_OP
{
    public partial class UC_UL45 : UserControl
    {
        string getname = "no";
        List<string> CANALUPPER;
        List<string> CANALLOWER;
        public UC_UL45()
        {
            InitializeComponent();
            CANALUPPER = new List<string>();
            CANALLOWER = new List<string>();
        }

        private void B_MB_U_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in CANALUPPER)
                {
                    var controls = tableLayoutPanel2.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.SteelBlue;
                }
                CANALUPPER.Clear();
                if (CANALUPPER.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.SteelBlue;
                    CANALUPPER.Remove(((Control)sender).Name);




                }
                else
                {

                    CANALUPPER.Add(((Control)sender).Name);
                    CLS.CANAL_UPPER_N = ((Control)sender).Text;
                


                    ((Control)sender).BackColor = Color.Red;





                }


            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void B_MB_L_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var x in CANALLOWER)
                {
                    var controls = tableLayoutPanel3.Controls.Find(x, false);
                    if (controls.Length > 0)
                        controls[0].BackColor = Color.SteelBlue;
                }
                CANALLOWER.Clear();
                if (CANALLOWER.Any(s => s == ((Control)sender).Name))
                {
                    ((Control)sender).BackColor = Color.SteelBlue;
                    CANALLOWER.Remove(((Control)sender).Name);




                }
                else
                {

                    CANALLOWER.Add(((Control)sender).Name);
                    CLS.CANAL_LOWER_N = ((Control)sender).Text;
                 
                  


                    ((Control)sender).BackColor = Color.Red;





                }


            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void TXT_UPPER_TextChanged(object sender, EventArgs e)
        {
            CLS.CANAL_UPPER_S = TXT_UPPER.Text;
        }

        private void TXT_LOWER_TextChanged(object sender, EventArgs e)
        {
            CLS.CANAL_LOWER_S= TXT_LOWER.Text;
        }
    }
}
