using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MEDICALCLINIC.CR_BUTTONS
{
    public partial class FRM_DES : Form
    {
         
         public Boolean IsClickMouse   = false;
         Point p=new Point ();
       
           void  FILL_MENU(){
        try{
          int i;
            flowLayoutPanel1.Controls.Clear();
            this.gET_DESC_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DESC_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
            DataTable DT=new DataTable ();
            DT = this.mEDICAL_CLINIC_DBDataSet.GET_DESC_BUTTON;
            for (i = 0 ;i < DT.Rows.Count;i++)
            {
               CLS . DESC_CODE = DT.Rows[i][3].ToString();
                CLS . DESC_NAME = DT.Rows[i][1].ToString();
                Button BTN_MENU = new Button();

               BTN_MENU.Click += Click_MENU_ME;
                BTN_MENU.BackColor = System.Drawing.Color.FromArgb(74,74,74);
                BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                BTN_MENU.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
                BTN_MENU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                BTN_MENU.Font = new System .Drawing.Font("STV", (float ) 14.0 , System .Drawing.FontStyle.Bold,System .Drawing.GraphicsUnit.Point,178);
                BTN_MENU.ForeColor = System.Drawing.Color.Yellow;
                BTN_MENU.Size = new System.Drawing.Size(170, 125);
                BTN_MENU.Name = CLS . DESC_CODE;
                BTN_MENU.Text =CLS . DESC_NAME;        
                BTN_MENU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                BTN_MENU.UseVisualStyleBackColor = false;
                flowLayoutPanel1.Controls.Add(BTN_MENU);
            }
        }
        catch (Exception  EX){
       
            MessageBox .Show  (EX .Message);
       
        }
         
           }

           private void Click_MENU_ME(object Sender, EventArgs e)
           {

               try
               {

                   Button BTN_MENU_CLICK = default(Button);
                   BTN_MENU_CLICK = (Button)Sender;
                   ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DESC.Text += BTN_MENU_CLICK.Text + "\r\n";
                //decimal c = Convert.ToDecimal(LBL_OPERTION_PRICE.Text);
                if (((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_TOTAL_OP.Text==String.Empty)
                {
                    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_TOTAL_OP.Text = "0";
                }
                ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_TOTAL_OP.Text  =(Convert.ToDecimal(((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_TOTAL_OP.Text) + Convert.ToDecimal(BTN_MENU_CLICK.Name)).ToString();

                //TXT_DESC.Text = TXT_DESC.Text+BTN_MENU_CLICK.Text + "\r\n";
                //TXT_DESC.Text  =   "\r\n";
                //GROUP_NAME = BTN_MENU_CLICK.Text;
                // GROUP_DATE = BTN_MENU_CLICK.Tag;
                //AIRLINE_CODE = 6000;
                //FLAG_BILL = true;
                //FRM_TICKETS_GROUPS.ShowDialog();

            }
            catch (Exception ex)
               {
                 MessageBox .Show (ex.Message);
               }
           }

        public FRM_DES()
        {
            InitializeComponent();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
           
            try
            {
  CLINIC.FRM_CLINIC FRM = new CLINIC.FRM_CLINIC();
    
         this.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

       

      
        private void FRM_DES_Load(object sender, EventArgs e)
        {
            this.gET_DESC_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DESC_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS .USER_CODE  , typeof(int))))));
            FILL_MENU();
        }

    

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    IsClickMouse = true;
                    p = e.Location;
                }

            }
            catch
            {
                return;
            }

       
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            try {
            if (IsClickMouse = true && e.Y > p.Y)
            {
                flowLayoutPanel1.VerticalScroll.Value -= 10;
                p = e.Location;
            }
            else
                if (IsClickMouse = true && e.Y < p.Y)
                {
                    flowLayoutPanel1.VerticalScroll.Value += 10;
                    p = e.Location;
                }
            }
            catch
            {
                return;
            }
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            try {

         
            if ( e.Button == System.Windows.Forms.MouseButtons.Left )
                IsClickMouse = false;
            }
            catch
            {
                return;
            }
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.gET_DESC_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DESC_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(iD_DOCTORToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
