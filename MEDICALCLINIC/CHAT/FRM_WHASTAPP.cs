using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio.Rest.Api.V2010.Account;

namespace MEDICALCLINIC.CHAT
{
    public partial class FRM_WHASTAPP : Form
    {
        public FRM_WHASTAPP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string accountSid = "ACc394da3906fb9a80cea6979daa201884";
            string authToken = "d45dca36c30570b37e57a0bae5127004";
            Twilio.TwilioClient.Init(accountSid, authToken);

            var Message = MessageResource.Create(from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"), to: new Twilio.Types.PhoneNumber("whatsapp:" + textBox1.Text),body: "Test Message From Basem Twilio");
            Console.WriteLine(Message.Sid);
        }
    }
}
