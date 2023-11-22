using System;
using System.Data;
using System.Windows.Forms;

namespace MEDICALCLINIC.CR_BUTTONS
{
    public partial class FRM_TOOTH_DRAG : Form
    {
        int idgrp;
        void FILL_MENU(int GRP, string txtsrch)
        {
            try
            {
                int i;
                flowLayoutPanel1.Controls.Clear();
                this.gET_DRAGE_TOOTH_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_TOOTH_BUTTON, GRP, txtsrch, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_TOOTH_BUTTON;
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
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)14.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.Yellow;
                    BTN_MENU.Size = new System.Drawing.Size(170, 125);
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

                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DRAGE_NAME_ARTextBoxX.Text += BTN_MENU_CLICK.Text + "\r\n";
                ((TOOTH_OP.FRM_TEETH)Application.OpenForms["FRM_TEETH"]).DRAGE_NAME_ARTextBoxX.Text += nAME_DRAGE_QNTYComboBox.Text + "-" + nAME_USE_DRAGEComboBox.Text + "-" + nAME_TIME_DRAGEComboBox.Text + "\r\n";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FRM_TOOTH_DRAG()
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
            this.gET_T_QNTY_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_QNTY_DRAGE_NAME_CODE, "");
            this.gET_T_USE_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_USE_DRAGE_NAME_CODE, "");
            this.gET_T_TIME_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_TIME_DRAGE_NAME_CODE, "");

           // this.gET_DRAGE_BUTTON_GROUPTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_BUTTON_GROUP, new System.Nullable<int>(((int)(System.Convert.ChangeType(00000000, typeof(int))))));
            FILL_MENUGRP();
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    CLS.DESC_NAMEGRB = DT.Rows[i][1].ToString();

                    Button BTN_MENUGRB = new Button();
                    BTN_MENUGRB.Click += Click_MENU_MEEG;


                    BTN_MENUGRB.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                    BTN_MENUGRB.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENUGRB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                    BTN_MENUGRB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
                    BTN_MENUGRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    BTN_MENUGRB.Font = new System.Drawing.Font("STV", (float)14.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENUGRB.ForeColor = System.Drawing.Color.Yellow;
                    BTN_MENUGRB.Size = new System.Drawing.Size(170, 125);
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
        private void Click_MENU_MEEG(object Sender, EventArgs e)
        {

            try
            {

                Button BTN_MENUGRP_CLICK = default(Button);
                BTN_MENUGRP_CLICK = (Button)Sender;
                // ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_DRAGE.Text += BTN_MENUGRP_CLICK.Text + "\r\n";
                this.gET_DRAGE_TOOTH_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DRAGE_TOOTH_BUTTON, new System.Nullable<int>(((int)(System.Convert.ChangeType(Convert.ToInt32(BTN_MENUGRP_CLICK.Name), typeof(int))))), greenTextBox1 .Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(CLS.USER_CODE, typeof(int))))));
                FILL_MENU(Convert.ToInt32(BTN_MENUGRP_CLICK.Name),greenTextBox1.Text);
                idgrp = Convert.ToInt32(BTN_MENUGRP_CLICK.Name);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
               FILL_MENU(idgrp,greenTextBox1.Text);
        }

        private void greenTextBox1_TextChanged(object sender, EventArgs e)
        {
            FILL_MENU(idgrp, greenTextBox1.Text);
        }

        private void BTN_EXIT_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

   
 
 
        private void FRM_TOOTH_DRAG_Validated(object sender, EventArgs e)
        {
             this.gET_T_USE_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_USE_DRAGE_NAME_CODE, "");
            this.gET_T_QNTY_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_QNTY_DRAGE_NAME_CODE, "");
            this.gET_T_TIME_DRAGE_NAME_CODETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_T_TIME_DRAGE_NAME_CODE, "");

        }

        private void BTN_QNTY_Click(object sender, EventArgs e)
        {
            SETTING.FRM_DRAGE_QNY FRM = new SETTING.FRM_DRAGE_QNY();
            FRM.ShowDialog();
        }

        private void BTN_USE_Click(object sender, EventArgs e)
        {

            SETTING.FRM_DRAG_USE FRM = new SETTING.FRM_DRAG_USE();
            FRM.ShowDialog();
        }

        private void BTN_TIME_Click(object sender, EventArgs e)
        {
            SETTING.FRM_DRAGE_TIME FRM = new SETTING.FRM_DRAGE_TIME();
            FRM.ShowDialog();
        }
    }
}

       

       

     