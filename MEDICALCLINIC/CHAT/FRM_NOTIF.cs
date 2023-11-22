using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MEDICALCLINIC.CHAT
{
    public partial class FRM_NOTIF : Form
    {
        //alter database MEDICAL_CLINIC_DB set enable_broker with rollback immediate
        private int? m_UserID = 0;
        private string m_UserName;
        private CHAT.ChatData m_Data = null;
        protected override bool ShowWithoutActivation { get { return true; } }
        protected override CreateParams CreateParams
        {
            get
            {
                //make sure Top Most property on form is set to false
                //otherwise this doesn't work
                int WS_EX_TOPMOST = 0x00000008;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TOPMOST;
                return cp;
            }
        }
        public GraphicsPath RoundedRectangl(Rectangle r, int curve)
        {
            GraphicsPath g;
            curve = (curve >= r.Height) ? r.Height : curve;
            g = new GraphicsPath(FillMode.Winding);
            g.AddArc(r.X, r.Y, curve, curve, 180f, 90f);
            g.AddArc(r.Right - curve, r.Y, curve, curve, 270f, 90f);
            g.AddArc(r.Right - curve, r.Bottom - curve, curve, curve, 0f, 90f);
            g.AddArc(r.X, r.Bottom - curve, curve, curve, 90f, 90f);
            g.CloseFigure();
            return g;

        }
        int x = 0, y = 0;
        public FRM_NOTIF()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;

        }
        public void Start()
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                this.Show();
            });
        }

        public void Stop()
        {
            BeginInvoke((Action)delegate { this.Close(); });
        }

        private void FRM_NOTIF_Shown(object sender, EventArgs e)
        {
            while (y >= Screen.PrimaryScreen.WorkingArea.Height - this.Height / 2)
            {
                y -= 10;
                this.Location = new Point(x, y);

                Refresh();
            }
            while (y >= Screen.PrimaryScreen.WorkingArea.Height - this.Height)
            {
                y -= 3;
                this.Location = new Point(x, y);

                Refresh();
            }
            timer1.Start();
        }

        private void FRM_NOTIF_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (y <= Screen.PrimaryScreen.WorkingArea.Height - this.Height)
            {
                y += 3;
                this.Location = new Point(x, y);
                Refresh();
            }
            while (y <= Screen.PrimaryScreen.WorkingArea.Height - this.Height + 100)
            {
                y += 25;
                this.Location = new Point(x, y);

                Refresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (index == 1)
            //{
               this.Close();
            //}
            //index = 1;
        }

        private void FRM_NOTIF_Load(object sender, EventArgs e)
        {
            x = Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2;
            y = Screen.PrimaryScreen.WorkingArea.Height + this.Height - 30;
            this.Location = new Point(x, y);
            m_Data = new CHAT.ChatData();

            // Hook up event
            m_Data.OnNewMessage += new CHAT.ChatData.NewMessage(OnNewMessage);
            LoadMessages();
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
        }
        private void BTN_OPEN_Click(object sender, EventArgs e)
        {
            CLINIC.Chatter_chat1 FRM = new CLINIC.Chatter_chat1();
            FRM.Show();
        }

        private void LoadMessages()
        {
            // Clear the listbox
            label1.Text="";

            // Get the messages
            DataTable dt = m_Data.GetLMessages();

            // Iterate through the records and add them
            // to the listbox
            foreach (DataRow row in dt.Rows)
            {
                string Msg = string.Format("{0} : {1}", row["USER_NAME"], row["Message"]);
                label1.Text=Msg;
                 
                }
        }
    }
}
