using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.ACCOUNT
{
    public partial class FRM_SHOW_ALLDEBIT_DETAILS : Form
    {
        int PER_CODE, ID_COSTCENTER, ID_FLAG;
        DateTime F_DATE, E_DATE;

      

        public FRM_SHOW_ALLDEBIT_DETAILS(int PERCODE,int IDCOSTCENTER,DateTime FDATE, DateTime TODATE,int IDFLAG)
        {
            InitializeComponent();
            PER_CODE = PERCODE;
            ID_COSTCENTER = IDCOSTCENTER;
            F_DATE = FDATE;
            E_DATE = TODATE;
            ID_FLAG = IDFLAG;
        }

       
        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_SHOW_ALLDEBIT_DETAILS_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            try
            {
                this.gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_PERSON_DEBIT_DETAILS_FOR_DR, new System.Nullable<int>(((int)(System.Convert.ChangeType(PER_CODE, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(ID_COSTCENTER, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(F_DATE, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(E_DATE, typeof(System.DateTime))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(ID_FLAG, typeof(int))))));
            }
            catch (System.Exception ex)
            {
              //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
    }
}
