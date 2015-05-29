using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Xml.Serialization;
using OpenPop.Pop3;

namespace PostClient.UI
{
    public static class PostManager
    {
        private static readonly string sentMsgPath = @"sent.xml";
        private static readonly string inboxMsgPath = @"inbox.xml";

        static PostManager()
        {
            InboxMessages = new List<Message>();
            SentMessages = new List<Message>();
        }

        public static List<Message> InboxMessages { get; set; }
        public static List<Message> SentMessages { get; set; }

        public static List<OpenPop.Mime.Message> FetchAllMessages(string hostname, int port, bool useSsl,
            string username, string password)
        {
            // The client disconnects from the server when being disposed
            using (var client = new Pop3Client())
            {
                // Connect to the server
                client.Connect(hostname, port, useSsl);

                // Authenticate ourselves towards the server
                client.Authenticate(username, password);

                // Get the number of messages in the inbox
                var messageCount = client.GetMessageCount();

                // We want to download all messages
                var allMessages = new List<OpenPop.Mime.Message>(messageCount);

                // Messages are numbered in the interval: [1, messageCount]
                // Ergo: message numbers are 1-based.
                // Most servers give the latest message the highest number
                for (var i = messageCount; i > 0; i--)
                {
                    allMessages.Add(client.GetMessage(i));
                }

                // Now return the fetched messages
                return allMessages;
            }
        }

        public static void ReceiveInbox()
        {
            if (File.Exists(inboxMsgPath))
                using (var f = new FileStream(inboxMsgPath, FileMode.Open))
                {
                    var ser = new XmlSerializer(typeof (List<Message>));
                    var sent = ser.Deserialize(f) as List<Message>;
                    if (sent != null)
                    {
                        InboxMessages.Clear();
                        InboxMessages.AddRange(sent);
                    }
                }
            var msgList = FetchAllMessages("pop.gmail.com", 995, true, Credentials.Email, Credentials.Password);
            if (msgList.Count == 0)
                return;
            var normalMsgList = (from m in msgList
                select new Message(m.ToMailMessage()){Date = m.Headers.DateSent}).ToList();
            InboxMessages.AddRange(normalMsgList);
            Save();
        }

        public static void ReceiveSent()
        {
            if (File.Exists(sentMsgPath))
                using (var f = new FileStream(sentMsgPath, FileMode.Open))
                {
                    var ser = new XmlSerializer(typeof (List<Message>));
                    var sent = ser.Deserialize(f) as List<Message>;
                    if (sent != null)
                    {
                        SentMessages.Clear();
                        SentMessages.AddRange(sent);
                    }
                }
        }

        public static void Save()
        {
            using (var f = new FileStream(sentMsgPath, FileMode.Create))
            {
                var ser = new XmlSerializer(typeof (List<Message>));
                ser.Serialize(f, SentMessages);
            }
            using (var f = new FileStream(inboxMsgPath, FileMode.Create))
            {
                var ser = new XmlSerializer(typeof (List<Message>));
                ser.Serialize(f, InboxMessages);
            }
        }

        public static void UpdateListView(ListView inboxListView, ListView sentListView)
        {
            inboxListView.Invoke(() => inboxListView.Items.Clear());
            foreach (var msg in InboxMessages)
            {
                var item = new ListViewItem(msg.Subject);
                item.SubItems.Add(msg.Date.ToString());
                inboxListView.Invoke(() => { inboxListView.Items.Add(item); });
            }
            sentListView.Invoke(() => sentListView.Items.Clear());
            foreach (var msg in SentMessages)
            {
                var item = new ListViewItem(msg.Subject);
                item.SubItems.Add(msg.Date.ToString());
                sentListView.Invoke(() => sentListView.Items.Add(item));
            }
        }

        public static void Send(string from, string to, string subj, string body)
        {
            var msg = new MailMessage(from, to);
            msg.Subject = subj;
            msg.Body = body;

            var client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(Credentials.Email, Credentials.Password);

            client.Send(msg);
            SentMessages.Add(new Message(msg){Date = DateTime.Now});
            Save();
        }

        public static void DeleteFromInbox(string subject)
        {
            var item = InboxMessages.First(m => m.Subject == subject);
            InboxMessages.Remove(item);
            Save();
        }

        public static void DeleteFromSent(string subject)
        {
            var item = SentMessages.First(m => m.Subject == subject);
            SentMessages.Remove(item);
            Save();
        }

        public static Message FindInInbox(string subject)
        {
            return InboxMessages.First(m => m.Subject == subject);
        }

        public static Message FindInSent(string subject)
        {
            return SentMessages.First(m => m.Subject == subject);
        }
    }
}