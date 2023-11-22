using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.CR_BUTTONS
{
    public partial class FRM_DRAGE : Form
    {
        int idgrp,idf;


        private void FRM_DES_Load(object sender, EventArgs e)
        {
            // this.gET_DRAGE_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(-1, typeof(int))))), greenTextBox1.Text, CLS.USER_CODE);
            this.gET_T_USE_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_USE_DRAGE_NAME_CODE, "");
            this.gET_T_QNTY_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_QNTY_DRAGE_NAME_CODE, "");
            this.gET_T_TIME_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_TIME_DRAGE_NAME_CODE, "");

            FILL_MENUGRP();

            //FILL_MENU();
        }
        public FRM_DRAGE(int idfo)
        {
            InitializeComponent();
            idf = idfo;
        }

        void FILL_MENUGRP()
        {
            try
            {
                int i;
                FLGRUOPDRAG.Controls.Clear();
                this.gET_DRAGE_BUTTON_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_BUTTON_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(00000000, typeof(int))))));
                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_BUTTON_GROUP;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODEGRB = DT.Rows[i][0].ToString();
                   CLS.DESC_NAMEGRB  = DT.Rows[i][1].ToString();

                    Button BTN_MENUGRB = new Button();
                    BTN_MENUGRB.Click += Click_MENU_MEE;


                    BTN_MENUGRB.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                    BTN_MENUGRB.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENUGRB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    BTN_MENUGRB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
                    BTN_MENUGRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    BTN_MENUGRB.Font = new System.Drawing.Font("STV", (float)12.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENUGRB.ForeColor = System.Drawing.Color.Yellow;
                    BTN_MENUGRB.Size = new System.Drawing.Size(120, 90);
                    BTN_MENUGRB.Name = CLS.DESC_CODEGRB;
                    BTN_MENUGRB.Text = CLS.DESC_NAMEGRB;

                    BTN_MENUGRB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    BTN_MENUGRB.UseVisualStyleBackColor = false;



                    FLGRUOPDRAG.Controls.Add(BTN_MENUGRB);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }

        }
        //----/-////
        private void Click_MENU_MEE(object Sender, EventArgs e)
        {

            try
            {

                Button BTN_MENUGRP_CLICK = default(Button);
                BTN_MENUGRP_CLICK = (Button)Sender;
               // ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DRAGE.Text += BTN_MENUGRP_CLICK.Text + "\r\n";
                   this.gET_DRAGE_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_BUTTON,   Convert .ToInt32 (BTN_MENUGRP_CLICK.Name ), greenTextBox1.Text,CLS.USER_CODE);
                FILL_MENU(Convert.ToInt32(BTN_MENUGRP_CLICK.Name),greenTextBox1.Text);
                idgrp = Convert.ToInt32(BTN_MENUGRP_CLICK.Name);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //-ADD DRAGE 
        void FILL_MENU(int GRPNUM, string txtsrch)
        {
            try
            {
                int i;
                flowLayoutPanel1.Controls.Clear();
                this.gET_DRAGE_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_BUTTON,    GRPNUM, txtsrch, CLS.USER_CODE);
                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_BUTTON;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][1].ToString();
                   
                    Button BTN_MENU = new Button();
                    BTN_MENU.Click += Click_MENU_ME;

                   
                    BTN_MENU.BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    BTN_MENU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
                    BTN_MENU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)12.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.Yellow;
                    BTN_MENU.Size = new System.Drawing.Size(100, 70);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = CLS.DESC_NAME;
                 
                    BTN_MENU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    BTN_MENU.UseVisualStyleBackColor = false;



                    flowLayoutPanel1.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }

        }

        private void Click_MENU_ME(object Sender, EventArgs e)
        {

            try
            {
                if (idf==1)
                {
                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DRAGE .Text += BTN_MENU_CLICK.Text + "\r\n";
                ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DRAGE .Text += nAME_DRAGE_QNTYComboBox.Text + "-"+ nAME_USE_DRAGEComboBox.Text + "-" + nAME_TIME_DRAGEComboBox.Text + "\r\n";

                }

            else
                     if (idf == 2)
                {
                    Button BTN_MENU_CLICK = default(Button);
                    BTN_MENU_CLICK = (Button)Sender;
                    ((HOSPITAL.OPERA.FRM_ADD_OPERATN_INFO)Application.OpenForms["FRM_ADD_OPERATN_INFO"]).TXT_DRAG.Text += BTN_MENU_CLICK.Text + "\r\n";
                    (( HOSPITAL.OPERA.FRM_ADD_OPERATN_INFO)Application.OpenForms["FRM_ADD_OPERATN_INFO"]).TXT_DRAG.Text += nAME_DRAGE_QNTYComboBox.Text + "-" + nAME_USE_DRAGEComboBox.Text + "-" + nAME_TIME_DRAGEComboBox.Text + "\r\n";

                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

     
 
       

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_USE_Click(object sender, EventArgs e)
        {
            SETTING.FRM_DRAG_USE FRM = new SETTING.FRM_DRAG_USE();
            FRM.ShowDialog();
        }

        private void FRM_DRAGE_Activated(object sender, EventArgs e)
        {
             this.gET_T_USE_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_USE_DRAGE_NAME_CODE, "");
            this.gET_T_QNTY_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_QNTY_DRAGE_NAME_CODE, "");
            this.gET_T_TIME_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_TIME_DRAGE_NAME_CODE, "");

        }

        private void BTN_TIME_Click(object sender, EventArgs e)
        {
            SETTING.FRM_DRAGE_TIME FRM = new SETTING.FRM_DRAGE_TIME();
            FRM.ShowDialog();
        }

        private void greenTextBox1_TextChanged(object sender, EventArgs e)
        {
            FILL_MENU(idgrp, greenTextBox1.Text);
        }

        private void BTN_QNTY_Click(object sender, EventArgs e)
        {
            SETTING.FRM_DRAGE_QNY FRM = new SETTING.FRM_DRAGE_QNY();
            FRM.ShowDialog();
        }
    }
}
