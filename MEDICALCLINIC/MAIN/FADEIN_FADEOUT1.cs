using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.MAIN
{
    public partial class FADEIN_FADEOUT1 : Form
    {
        DataTable DT = new DataTable();

        int HOSPITAID = -1,LABID=-1,CLINICID=-1,DENTALID=-1, XRAYID = -1;

        public FADEIN_FADEOUT1()
        {
            InitializeComponent();
          //  this.v_GET_TBL_TABLETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_TBL_TABLE);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_TBL_TABLE' table. You can move, or remove it, as needed.
            //this.v_GET_TBL_TABLETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_TBL_TABLE);
            //DT = this.mEDICAL_CLINIC_DBDataSet.V_GET_TBL_TABLE;
            //HOSPITAID =Convert.ToInt32( DT.Rows[0][1]);
            //CLINICID = Convert.ToInt32(DT.Rows[0][2]);
            //LABID = Convert.ToInt32(DT.Rows[0][3]);
            //XRAYID = Convert.ToInt32(DT.Rows[0][4]);
            //DENTALID = Convert.ToInt32(DT.Rows[0][5]);

            if (HOSPITAID==0 && CLINICID==0&&LABID==0&&XRAYID==0)
            {

            }



            TransparencyKey = BackColor;
           

        }

        private void OUTFADE_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                OUTFADE.Enabled = false;
                timer1.Enabled = true;
                return;

            }
            this.Opacity += 0.05;
        }
        int COUNT = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (COUNT == 0)
            {
                INFADE.Enabled = true;
                timer1.Enabled = false;
                return;
            }
            COUNT -= 1;

        }

        private void INFADE_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                INFADE.Enabled = false;
                MAIN.FRM_LOGIN FRM = new FRM_LOGIN();
                FRM.ShowDialog();
                this.Hide();
                return;
            }
            this.Opacity -= 0.05;
        }
    }
}
