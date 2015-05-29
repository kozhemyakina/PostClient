using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PostClient.UI
{
    public class Message
    {
        public Message()
        {
            
        }

        public Message(MailMessage msg)
        {
            _convertToMyMessage(msg);
        }

        private void _convertToMyMessage(MailMessage msg)
        {
            this.Subject = msg.Subject;
            Body = msg.Body;
            From = msg.From.Address;
            To = msg.To.First().Address;
        }

        public String Subject { get; set; }
        public String Body { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }
}
