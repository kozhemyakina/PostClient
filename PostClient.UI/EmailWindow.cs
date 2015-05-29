using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostClient.UI
{
    public partial class EmailWindow : Form
    {
        private ShowMessageType type;
        private Message currentMessage;
        private bool msgFromSent;
        public EmailWindow(ShowMessageType type, Message msg = null, bool msgFromSent = false)
        {
            this.msgFromSent = msgFromSent;
            currentMessage = msg;
            this.type = type;
            InitializeComponent();
        }

        private void sendButtonClick_Click(object sender, EventArgs e)
        {
            if (toTextBox.Text.Length < 1 || subjectTextBox.Text.Length < 1 || bodyTextBox.Text.Length < 1)
            {
                MessageBox.Show("Please, fill all fields");
                return;
            }
            var fromArr = fromTextBox.Text.ToCharArray();
            var toArr = toTextBox.Text.ToCharArray();
            var subjArr = subjectTextBox.Text.ToCharArray();
            var bodyArr = bodyTextBox.Text.ToCharArray();
            Task.Run(() =>
            {
                PostManager.Send(new string(fromArr), new string(toArr), new string(subjArr), new string(bodyArr));
            });
            this.Close();
        }

        private void EmailWindow_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case ShowMessageType.New:
                    fromTextBox.ReadOnly = true;
                    fromTextBox.Text = Credentials.Email;
                    replyButton.Enabled = false;

                    if (currentMessage != null)
                    {
                        fromTextBox.Text = currentMessage.From;
                        toTextBox.Text = currentMessage.To;
                        subjectTextBox.Text = currentMessage.Subject;
                    }
                    break;
                case ShowMessageType.View:
                    fromTextBox.ReadOnly = true;
                    toTextBox.ReadOnly = true;
                    subjectTextBox.ReadOnly = true;
                    bodyTextBox.ReadOnly = true;

                    fromTextBox.Text = currentMessage.From; 
                    toTextBox.Text= currentMessage.To; 
                    subjectTextBox.Text = currentMessage.Subject; 
                    bodyTextBox.Text= currentMessage.Body;
                    sendButton.Enabled = false;

                    if (msgFromSent)
                        replyButton.Enabled = false;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void replyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var emailWindow = new EmailWindow(ShowMessageType.New, new Message()
            {
                From = Credentials.Email,
                Subject = "RE: " + currentMessage.Subject,
                To = currentMessage.From
            });
            emailWindow.Closed += (s, args) => this.Close();
            emailWindow.ShowDialog();
        }
    }
}
