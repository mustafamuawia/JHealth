using MEDICALCLINIC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static MEDICALCLINIC.Services.BookingDoctorService;

namespace MEDICALCLINIC.DIAGNOSES
{
    public partial class FRM_VIDEO_PLAYER : Form
    {
        static List<MEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_1Row> doc1 = null;
        //DataTable DT_TOOTH = new DataTable();
        //DataTable DT_BUTY = new DataTable();
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;
        private CHAT.ChatData m_Data = null;
        BookingDoctorService srv = null;
        public FRM_VIDEO_PLAYER()
        {
            InitializeComponent();
            timer4.Start();
            try
            {
                this.FormBorderStyle = FormBorderStyle.None;
                //this.DoubleBuffered = true;
                //this.SetStyle(ControlStyles.ResizeRedraw, true);
                SqlClientPermission perm = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                perm.Demand();

            }
            catch
            {
                throw new ApplicationException("No permission");
            }
        }

        public void BookingDoctorService_OnBooking(object sender)
        {

            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // Check if the event was generated from another
            // thread and needs invoke instead
            if (i.InvokeRequired)
            {
                OnBookingCallBack tempDelegate = new OnBookingCallBack(BookingDoctorService_OnBooking);
                i.BeginInvoke(tempDelegate, new object[] { null });
                return;
            }
            //this.gET_DOCTOR_INFO_SHOW_1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_1, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            //this.gET_DOCTOR_INFO_SHOW_2TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_2, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            //this.gET_DOCTOR_INFO_SHOW_3TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_3, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            //this.gET_DOCTOR_INFO_SHOW_4TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_4, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            LoadPatients();

            // 
        }
        void LoadPatients()
        {
            var doc2 = mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_1;
            doc1 = new List<MEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_1Row>();
            foreach (var item in doc2)
            {
                if (!doc1.Contains(item))
                    doc1.Add(item);
            }
            var dt = new DataTable();
            gET_BOOKDOCTOR_INFO_SHOW_1DataGridView.DataSource = null;
            gET_BOOKDOCTOR_INFO_SHOW_2DataGridView.DataSource = null;
            gET_BOOKDOCTOR_INFO_SHOW_3DataGridView.DataSource = null;
            gET_BOOKDOCTOR_INFO_SHOW_4DataGridView.DataSource = null;

            for (int j = 0; j < doc1.Count; j++)
            {
                var item = doc1[j];
                var ls = new BookingDoctorService().GetBookByDoctorId(item.USER_CODE, (int)CLS.BRANCH_ID, Properties.Settings.Default.PROG_ID,CLS.PROCNAME);
                //var ls = Program.bookingDoctorService.GetBookByDoctorId(2112006);



                // var item = (MEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_1Row)item1;

                if (gET_BOOKDOCTOR_INFO_SHOW_1DataGridView.Rows.Count == 0)
                {
                    dOCTOR_NAMEComboBox.SelectedValue = item.USER_CODE;
                    gET_BOOKDOCTOR_INFO_SHOW_1DataGridView.DataSource = ls;

                }
                else if (gET_BOOKDOCTOR_INFO_SHOW_2DataGridView.Rows.Count == 0)
                {
                    dOCTOR_NAMEComboBox1.SelectedValue = item.USER_CODE;
                    gET_BOOKDOCTOR_INFO_SHOW_2DataGridView.DataSource = ls;

                }
                else if (gET_BOOKDOCTOR_INFO_SHOW_3DataGridView.Rows.Count == 0)
                {
                    dOCTOR_NAMEComboBox2.SelectedValue = item.USER_CODE;
                    gET_BOOKDOCTOR_INFO_SHOW_3DataGridView.DataSource = ls;

                }
                else if (gET_BOOKDOCTOR_INFO_SHOW_4DataGridView.Rows.Count == 0)
                {
                    dOCTOR_NAMEComboBox3.SelectedValue = item.USER_CODE;
                    gET_BOOKDOCTOR_INFO_SHOW_4DataGridView.DataSource = ls;

                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "(mp3,wav,mp4,mov,wmv,mpg,avi,3gp,flv)|*.mp3;*.wav;*.mp4;*.3gp;*.avi;*.mov;*.flv;*.wmv;*.mpg|all files|*.*" })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MEDIAFILE> FILES = new List<MEDIAFILE>();
                    foreach (string FILE_NAME in ofd.FileNames)
                    {
                        FileInfo FI = new FileInfo(FILE_NAME);
                        FILES.Add(new MEDIAFILE() { FILE_NAME = Path.GetFileNameWithoutExtension(FI.FullName), PATH = FI.FullName });
                    }
                    listBox1.DataSource = FILES;

                }
        }

        private void BTN_PLAY_Click(object sender, EventArgs e)
        {
            MEDIAFILE FILEEEE = listBox1.SelectedItem as MEDIAFILE;

            if (listBox1.Items.Count <= 0)
            { return; }

            if (FILEEEE != null)
            {

                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.URL = FILEEEE.PATH;
                axWindowsMediaPlayer1.Ctlcontrols.next();
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        public void FRM_VIDEO_PLAYER_Load(object sender, EventArgs e)
        {
            this.gET_ORGANIZATION_INFO_TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ORGANIZATION_INFO_, "1");

            if (this.mEDICAL_CLINIC_DBDataSet.GET_ORGANIZATION_INFO_.Rows.Count>0)
            {
                lbl_maintitle.Text = this.mEDICAL_CLINIC_DBDataSet.GET_ORGANIZATION_INFO_.Rows[0][1].ToString();
                lbl_subtitle.Text = this.mEDICAL_CLINIC_DBDataSet.GET_ORGANIZATION_INFO_.Rows[0][2].ToString();
            }
            //var workingArea = Screen.FromHandle(Handle).WorkingArea;
            //MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            //WindowState = FormWindowState.Maximized;
            srv = new BookingDoctorService();
            srv.OnBooking += new OnBookingCallBack(BookingDoctorService_OnBooking);

            //try
            //{
            //timer3.Start();
            this.gET_DOCTOR_INFO_SHOW_1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_1, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))), CLS.BRANCH_ID);
            this.gET_DOCTOR_INFO_SHOW_2TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_2, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            this.gET_DOCTOR_INFO_SHOW_3TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_3, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));
            this.gET_DOCTOR_INFO_SHOW_4TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_DOCTOR_INFO_SHOW_4, new System.Nullable<int>(((int)(System.Convert.ChangeType(0, typeof(int))))));

            dOCTOR_NAMEComboBox.SelectedIndex  = -1;
            dOCTOR_NAMEComboBox1.SelectedIndex = -1;
            dOCTOR_NAMEComboBox2.SelectedIndex = -1;
            dOCTOR_NAMEComboBox3.SelectedIndex = -1;
            BookingDoctorService_OnBooking(null);
            LoadPatients();
            //// Create a new ChatData object
            //m_Data = new CHAT.ChatData();

            //// Hook up event
            //m_Data.OnNewMessage += new CHAT.ChatData.NewMessage(OnNewMessage);
            //DataTable dt = m_Data.GetWAITNAMES();
            //LoadMessages();
            //}
            //catch (System.Exception ex)
            //{
            // //   System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }



        //System.Windows.Forms.Timer t = null;
        //private void StartTimer()
        //{
        //    t = new System.Windows.Forms.Timer();
        //    t.Interval = 5000;
        //    t.Tick += new EventHandler(timer3_Tick);
        //    t.Enabled = true;
        //}

        private void BTN_STOP_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void BTN_PAUSE_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {


            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {

                timer1.Interval = 100;
                timer1.Start();
                timer1.Enabled = true;
                timer1.Tick += timer1_Tick;
                if (listBox1.Items.Count > 1)
                {
                    listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    listBox1.ValueMember = "PATH";
                    listBox1.DisplayMember = "FILE_NAME";
                }
            }




        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            BTN_PLAY_Click(null, null);
            timer1.Enabled = false;
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\DEVELOPER\Downloads\solemn.wav");
                player.Play();
                var enter_doc = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                /////  enter_doc.P_UPDATE_T_BOOKING_ENTER_DOCT(Convert .ToInt32 (DGV_TOOTH .CurrentRow .Cells [0].Value ),ref CLS.SUBMIT_FLAG );
                /////  int ID_NUM = DGV_TOOTH.CurrentRow.Index;


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private static void PaintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dOCTOR_NAMEComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_BOOKDOCTOR_INFO_SHOW_1TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKDOCTOR_INFO_SHOW_1, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox.SelectedValue, typeof(int))))), (int)CLS.BRANCH_ID);
                // gET_BOOKDOCTOR_INFO_SHOW_1DataGridView.DataSource= CHAT.ChatData.
                // CLS. DR_WAIT_NAME = Convert.ToInt32(dOCTOR_NAMEComboBox.SelectedValue);
            }
            catch (System.Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dOCTOR_NAMEComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_BOOKDOCTOR_INFO_SHOW_2TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKDOCTOR_INFO_SHOW_2, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox1.SelectedValue, typeof(int))))), (int)CLS.BRANCH_ID);
                //LoadPatients();
            }
            catch (System.Exception ex)
            {
                //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dOCTOR_NAMEComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_BOOKDOCTOR_INFO_SHOW_3TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKDOCTOR_INFO_SHOW_3, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox2.SelectedValue, typeof(int))))), (int)CLS.BRANCH_ID);
            }
            catch (System.Exception ex)
            {
                //  System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dOCTOR_NAMEComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.gET_BOOKDOCTOR_INFO_SHOW_4TableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_BOOKDOCTOR_INFO_SHOW_4, new System.Nullable<int>(((int)(System.Convert.ChangeType(dOCTOR_NAMEComboBox3.SelectedValue, typeof(int))))), (int)CLS.BRANCH_ID);
            }
            catch (System.Exception ex)
            {
                //    System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        void OnNewMessage()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // Check if the event was generated from another
            // thread and needs invoke instead
            if (i.InvokeRequired)
            {
                CHAT.ChatData.NewMessage tempDelegate = new CHAT.ChatData.NewMessage(OnNewMessage);


                i.BeginInvoke(tempDelegate, null);



                return;
            }

            // If not coming from a seperate thread
            // we can access the Windows form controls
            LoadMessages();

            // frm = new CHAT.FRM_NOTIF();
            // frm.Show();
        }
        private void LoadMessages()
        {
            // Clear the listbox


            // Get the messages
            DataTable dt = m_Data.GetWAITNAMES();

            // Iterate through the records and add them
            // to the listbox
            dataGridView1.DataSource = dt;







        }


        private Point _mouseLoc;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            LBLTIME.Text = DateTime.Now.ToString("hh:mm:ss tt");
            LBLDATE.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
        }

        private void panel3_Click(object sender, EventArgs e)

        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
