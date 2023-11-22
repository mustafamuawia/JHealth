using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
//using DevExpress.XtraGrid.Controls;

namespace MEDICALCLINIC.TOOTH_OP
{
    public partial class UC_UL123 : UserControl
    {
        
        List<string> CANALUPPER;
        List<string> CANALLOWER;
        public UC_UL123()
        {
            InitializeComponent();
            CANALUPPER = new List<string>();
            CANALLOWER = new List<string>();
        }

        private void B_MB_U_Click(object sender, EventArgs e)
        {
            try
            {

               
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
           
        }

        private void TXT_UPPER_TextChanged(object sender, EventArgs e)
        {
            CLS.CANAL_UPPER_S = TXT_UPPER.Text;
        }
    }
}
