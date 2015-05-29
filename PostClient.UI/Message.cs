using System;
using System.Linq;
using System.Net.Mail;

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

        public String Subject { get; set; }
        public String Body { get; set; }
        public String From { get; set; }
        public String To { get; set; }

        private void _convertToMyMessage(MailMessage msg)
        {
            Subject = msg.Subject;
            Body = msg.Body;
            From = msg.From.Address;
            To = msg.To.First().Address;
        }
    }
}