using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MEDICALCLINIC.MAIN
{
    public partial class FRM_MAIN_L : Form
    {
        //1, 20, 67
        public FRM_MAIN_L()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            timer1.Start();
            lblname.Text = CLS.USER_NAME;
            if (Properties.Settings.Default.TYPEACTIE == "Trial")
            {
                label2.Visible = true;
                label3.Visible = true;
                lbl_daytaial.Visible = true;
                lbl_daytaial.Text = ((Convert.ToDateTime(Properties.Settings.Default.ENDTRIALVER) - System.DateTime.Now).TotalDays.ToInt()).ToString();

            }
        }

        FRM_MAIN_N frmmain = Application.OpenForms[nameof(MAIN.FRM_MAIN_N)] as MAIN.FRM_MAIN_N;
        public void OpenFrm(string FormName, string FormOpen = null)
        {
            // Check Is Form Open

            var IfOpen = Application.OpenForms[FormName];
            if (IfOpen != null)
            {
                IfOpen.Show();
                IfOpen.BringToFront();
                IfOpen.WindowState = FormWindowState.Normal;
                return;
            }

            var formInst = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == FormName);
            if (formInst != null)
            {
                if (CLS.Permessions != null)
                {


                    var frm = Activator.CreateInstance(formInst) as Form;


                    for (int i = 0; i < CLS.Permessions.Rows.Count; i++)
                    {
                        if (CLS.Permessions.Rows[i][1].ToString() == FormName)
                        {
                            if ((bool)CLS.Permessions.Rows[i][4] == true)
                            {
                                frm.Owner = frmmain;
                                frm.Show();
                                break;

                            }
                            else
                            {
                                MessageBox.Show("عذرا لا تملك صلاحية الدخول");
                            }
                        }
                    }


                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       // lbltyp.Text = DateTime.Now.AddHours(12).ToString("tt", CultureInfo.InvariantCulture);//
                                                                                             // LBLTIME.Text =DateTime.Now.ToString("HH:mm:ss");
            LBLTIME.Text = DateTime.Now.ToString("hh:mm:ss tt");
            
            LBLDATE.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lbldayname.Text = DateTime.Now.DayOfWeek.ToString() ;
        }
        System.Windows.Forms.Timer t = null;
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(timer1_Tick);
            t.Enabled = true;
        }

        private void btn_closetitle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        { 
            //Properties.Settings.Default.F_PROG = 0;
            //Properties.Settings.Default.Save();
            Application.Exit();
           
        }
 
       
       

        private void btntj_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FRM_LOGIN FRM = new FRM_LOGIN();
            Application.OpenForms["FRM_LOGIN"].Show();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CLINIC.Chatter_chat1 FRM = new CLINIC.Chatter_chat1();
            FRM.Show();
        }

        private void BTN_SETTING_Click(object sender, EventArgs e)
        {
            LAB.FRM_SETTING_LAB FRM = new LAB.FRM_SETTING_LAB(); FRM.ShowDialog();

        }

        private void BTN_SANAD_Click(object sender, EventArgs e)
        {
            OpenFrm("FRM_SANAD", null);
        }

        private void BTN_LABTEST_Click(object sender, EventArgs e)
        {
            //OpenFrm("FRM_TESTLAB", null);
            LAB.FRM_TESTLAB frm = new LAB.FRM_TESTLAB();
            frm.ShowDialog();
        }

        private void BTN_RPT_Click(object sender, EventArgs e)
        {
            LAB.REPORT.FRM_RPT_ALL_DAILYTEST frm = new LAB.REPORT.FRM_RPT_ALL_DAILYTEST();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLINIC.Chatter_chat1 FRM = new CLINIC.Chatter_chat1();
            FRM.Show();
        }
    }
}
