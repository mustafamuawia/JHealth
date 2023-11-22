using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MEDICALCLINIC.CLINIC
{
    public partial class Chatter_chat1 : Form
    {
        private int? m_UserID = 0;
        private string m_UserName;
        private CHAT.ChatData m_Data = null;
        DataTable dtt = new DataTable();
        /// <summary>
        /// Constructor
        /// </summary>
        public Chatter_chat1()
        {
            InitializeComponent();
            //if (Properties.Settings.Default.TYPEACTIE != "Trial") ;
            //{

                // Make sure client has permissions 
                try
                {
                    SqlClientPermission perm = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                    perm.Demand();
                }
                catch
                {
                    throw new ApplicationException("No permission");
                }
            //}
        }

        /// <summary>
        /// Handler for OnLoad event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chat_Load(object sender, EventArgs e)
        {
             
            
            // Display the dialog to select users
            //Chatter_user1 dlg = new Chatter_user1();

           // if (dlg.ShowDialog() == DialogResult.OK)
          //  {
                // Set the variables and text
                m_UserID = CLS.USER_CODE; //dlg.UserID;
                this.Text = CLS.USER_NAME; //m_UserName = dlg.UserName;
                label2.Text= CLS.USER_NAME;
                // Create a new ChatData object
                m_Data = new CHAT.ChatData();

                // Hook up event
                m_Data.OnNewMessage += new CHAT.ChatData.NewMessage(OnNewMessage);

                // Load existing message
                LoadMessages();
            
        }

        /// <summary>
        /// Handler for send button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSend(object sender, EventArgs e)
        {
            // Add new message to the database
           // ChatterData.ChatData.AddMessage(txtMsg.Text, m_UserID);
            try
            {

                if (txtMsg.Text!=String.Empty)
                {
 
                var INSERTED = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                INSERTED.usp_InsertMessage(txtMsg.Text, m_UserID);
                txtMsg.Clear();
                txtMsg.Focus();
                }

            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, CLS.TITEL_MESG);
            }
        }

        /// <summary>
        /// Handler for NewMessage
        /// </summary>
        void OnNewMessage1()
        {
            

            // If not coming from a seperate thread
            // we can access the Windows form controls
            // LoadMessages();
            this.Invoke((MethodInvoker)delegate () {
                new CHAT.FRM_NOTIF().Start();

            });

        }
     
        void OnNewMessage()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            // Check if the event was generated from another
            // thread and needs invoke instead
            if (i.InvokeRequired)
            {
                CHAT.ChatData.NewMessage tempDelegate = new CHAT.ChatData.NewMessage(OnNewMessage);
                //  tempDelegate += new CHAT.ChatData.NewMessage(OnNewMessage1);
               
                i.BeginInvoke(tempDelegate, null);
                dtt = m_Data.GetLMessages();
                string Msg = string.Format("{0} : {1}", dtt.Rows[0][0], dtt.Rows[0][1]);
                if (!dtt.Rows[0][1].ToString().Equals( CLS.USER_NAME))
                {

               
                var notification = new System.Windows.Forms.NotifyIcon()
                {
               
                    Visible = true,
                    Icon = System.Drawing.SystemIcons.Exclamation,
                    // optional - BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
                    // optional - BalloonTipTitle = "My Title",

                    BalloonTipText = Msg
                };
                // Iterate through the records and add them
                // to the listbox
                // Display for 5 seconds.
                notification.ShowBalloonTip(5000);
                notification.Dispose();
                }
                return;
            }

            // If not coming from a seperate thread
            // we can access the Windows form controls
            LoadMessages();
            
            // frm = new CHAT.FRM_NOTIF();
            // frm.Show();
        }

        /// <summary>
        /// Helper method to populate list box
        /// </summary>
        private void LoadMessages()
        {
            // Clear the listbox
            lstHistory.Items.Clear();

            // Get the messages
            DataTable dt = m_Data.GetMessages();

            // Iterate through the records and add them
            // to the listbox
            foreach (DataRow row in dt.Rows)
            {
                string Msg = string.Format("{0} : {1}", row["USER_NAME"], row["MessagePerson"]);
                lstHistory.Items.Add(Msg);
                int visibleItems = lstHistory.ClientSize.Height / lstHistory.ItemHeight;
                lstHistory.TopIndex = Math.Max(lstHistory.Items.Count - visibleItems + 1, 0);


                var notification = new System.Windows.Forms.NotifyIcon()
                {

                    Visible = true,
                    Icon = System.Drawing.SystemIcons.Shield,
                    // optional - BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
                    // optional - BalloonTipTitle = "My Title",

                    BalloonTipText = Msg
                };
                // Iterate through the records and add them
                // to the listbox
                // Display for 5 seconds.
                notification.ShowBalloonTip(5000);
                notification.Dispose();
            }


             




        }
       
        private void txtMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {

                OnSend(null, null);
            }
        }
    }
}