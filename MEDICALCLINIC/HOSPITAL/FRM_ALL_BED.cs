using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL
{
    public partial class FRM_ALL_BED : Form
    {
        public FRM_ALL_BED()
        {
            InitializeComponent();
        }

        void FILL_floor()
        {
            try
            {
                int i;
                flowLayoutPanel1.Controls.Clear();
                this.v_A_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR);
                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][1].ToString();
                    Button BTN_MENU = new Button();
                    BTN_MENU.Click += Click_MENU_FLOOR;
                    //  BTN_MENU.BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
                    BTN_MENU.BackColor = System.Drawing.Color.White;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)22.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.Black;
                    BTN_MENU.Size = new System.Drawing.Size((flowLayoutPanel1.Width / DT.Rows.Count) - 10, (flowLayoutPanel1.Height) - 10);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = CLS.DESC_NAME;
                    //byte[] imge1 = (byte[])DT.Rows[i][3];
                    //MemoryStream ms1 = new MemoryStream(imge1);
                   
                    //BTN_MENU.BorderStyle = BorderStyle.FixedSingle;
                    //BTN_MENU.BackgroundImageLayout = ImageLayout.Zoom;
                    //BTN_MENU.BackgroundImage = Image.FromStream(ms1);


                    //Label LBL = new Label();
                    //LBL.Text = DT.Rows[i][1].ToString();
                    //LBL.BackColor = Color.Red;
                    //LBL.Dock = DockStyle.Bottom;
                    //BTN_MENU.Controls.Add(LBL);
                    flowLayoutPanel1.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }
        }

        //---------------

        void FILL_BED()
        {
            try
            {
                int i;
                flowLayoutPanel2.Controls.Clear();
                this.gET_H_ALLBED_TOCHECK_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON, "", new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))),DATE_FROM.Value,DATE_TO.Value);

                //---

                if(FLAGE_SEARCH==0)
                {
                    this.gET_H_ALLBED_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON, CLS.H_FLOOR.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(2, typeof(int))))));

                }
                else
                 
                 if(FLAGE_SEARCH==1)
                {
                    this.gET_H_ALLBED_BUTTONTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON, CLS.H_FLOOR.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

                 
                }



                DataTable DT = new DataTable();
                DT = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON;
                for (i = 0; i < DT.Rows.Count; i++)
                {
                    CLS.DESC_CODE = DT.Rows[i][0].ToString();
                    CLS.DESC_NAME = DT.Rows[i][1].ToString();
                    Button BTN_MENU = new Button();
                    BTN_MENU.Click += Click_MENU_BED;
                    //  BTN_MENU.BackColor = System.Drawing.Color.FromArgb(74, 74, 74);
                    BTN_MENU.BackColor = System.Drawing.Color.White;
                    BTN_MENU.Cursor = System.Windows.Forms.Cursors.Hand;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                    BTN_MENU.ForeColor = System.Drawing.Color.Green;
                    BTN_MENU.Size = new System.Drawing.Size(250, 150);
                    BTN_MENU.Name = CLS.DESC_CODE;
                    BTN_MENU.Text = "";
                    byte[] imge1 = (byte[])DT.Rows[i][4];
                    MemoryStream ms1 = new MemoryStream(imge1);

                   // BTN_MENU.BorderStyle = BorderStyle.FixedSingle;
                    BTN_MENU.BackgroundImageLayout = ImageLayout.Zoom;
                    BTN_MENU.BackgroundImage = Image.FromStream(ms1);

                    
                    
                    BTN_MENU.ImageAlign = ContentAlignment.MiddleCenter;
                    BTN_MENU.TextAlign = ContentAlignment.BottomCenter;
                    BTN_MENU.TextImageRelation = TextImageRelation.Overlay;



                    Label LBLNAME = new Label();
                    for (int J = 0; J < mEDICAL_CLINIC_DBDataSet. GET_H_ALLBED_TOCHECK_BUTTON.Rows.Count; J++)
                    {
                        string B_FLOOR, B_ROOM, B_BED, F_FLOOR, F_ROOM, F_BED,comb_f="",comb_b="";
                        F_FLOOR = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON.Rows[i][2].ToString();
                        F_ROOM = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON.Rows[i][3].ToString();
                        F_BED = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_BUTTON.Rows[i][0].ToString();

                        B_FLOOR = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][10].ToString();
                        B_ROOM = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][11].ToString();
                        B_BED = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][12].ToString();
                        comb_b = B_FLOOR + "" + B_ROOM + "" + B_BED;
                        comb_f = F_FLOOR + "" + F_ROOM + "" + F_BED;
                     if ( comb_f== comb_b)
                    {

                            LBLNAME.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][2].ToString();
                            LBLNAME.BackColor = Color.Red;
                            LBLNAME.Dock = DockStyle.Bottom;
                            LBLNAME.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
                            BTN_MENU.Text = this.mEDICAL_CLINIC_DBDataSet.GET_H_ALLBED_TOCHECK_BUTTON.Rows[J][0].ToString();
                            LBLNAME.ForeColor = System.Drawing.Color.Yellow;
                            LBLNAME.TextAlign = ContentAlignment.MiddleCenter;
                            BTN_MENU.Controls.Add(LBLNAME);
                            break;
                        }

                    else
                    {

                            LBLNAME.Text ="غير محجوزه";
                            LBLNAME.BackColor = Color.WhiteSmoke;
                            LBLNAME.Dock = DockStyle.Bottom;
                            LBLNAME.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);

                            BTN_MENU.ForeColor = System.Drawing.Color.Blue;
                            LBLNAME.TextAlign = ContentAlignment.MiddleCenter;
                            BTN_MENU.Controls.Add(LBLNAME);
                        }
                    }

                    Label LBL = new Label();
                    LBL.Text = DT.Rows[i][11].ToString() + "-" + DT.Rows[i][7].ToString() + "-" + DT.Rows[i][1].ToString();
                    LBL.BackColor = Color.WhiteSmoke;
                    BTN_MENU.Font = new System.Drawing.Font("STV", (float)12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);

                    LBL.Dock = DockStyle.Top;
                    BTN_MENU.ForeColor = System.Drawing.Color.Black;
                    LBL.TextAlign = ContentAlignment.MiddleCenter;
                    BTN_MENU.Controls.Add(LBL);



                    flowLayoutPanel2.AutoScroll = true;
                    flowLayoutPanel2.Controls.Add(BTN_MENU);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);

            }
        }
        int FLAGE_SEARCH = 0;
        private void FRM_ALL_BED_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR' table. You can move, or remove it, as needed.
            this.v_A_H_FLOORTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_A_H_FLOOR);

            FILL_floor();
        }


        private void Click_MENU_FLOOR(object Sender, EventArgs e)
        {

            try
            {

                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                CLS.H_FLOOR =Convert.ToInt32( BTN_MENU_CLICK.Name);
                FILL_BED();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-----
        }

        private void Click_MENU_BED(object Sender, EventArgs e)
        {

            try
            {

                Button BTN_MENU_CLICK = default(Button);
                BTN_MENU_CLICK = (Button)Sender;
                if (BTN_MENU_CLICK.Text !=String.Empty)
                {

                  HOSPITAL.FRM_DETAILS_PROCEDURE frm = new FRM_DETAILS_PROCEDURE(BTN_MENU_CLICK.Text,0);
                   frm.ShowDialog();
                }
                else{
                    MessageBox.Show("عذرا لا يوجد حجز هنا لفتحة");
                }
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //-----
        }

       

         

        private void BTN_ALL_Click(object sender, EventArgs e)
        {
            FLAGE_SEARCH = 1;
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
