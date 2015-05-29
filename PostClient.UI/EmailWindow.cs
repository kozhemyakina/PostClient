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
        public EmailWindow(ShowMessageType type, Message msg = null)
        {
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
            PostManager.Send(fromTextBox.Text, toTextBox.Text, subjectTextBox.Text, bodyTextBox.Text);
            this.Close();
        }

        private void EmailWindow_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case ShowMessageType.New:
                    fromTextBox.ReadOnly = true;
                    fromTextBox.Text = Credentials.Email;
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
                    
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
