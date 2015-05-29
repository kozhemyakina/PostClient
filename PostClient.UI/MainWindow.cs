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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getMailToolStripButton_Click(object sender, EventArgs e)
        {
            PostManager.ReceiveInbox();
            PostManager.ReceiveSent();
            PostManager.UpdateListView(inboxListView, sentListView);
        }

        private void newMailToolStripButton_Click(object sender, EventArgs e)
        {
            var msgWnd = new EmailWindow(ShowMessageType.New);
            msgWnd.ShowDialog();
            PostManager.UpdateListView(inboxListView, sentListView);
        }

        private void inboxListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            inboxListView.ContextMenuStrip = inboxListView.SelectedIndices.Count > 0 ? inboxDeleteMenuStrip : null;
        }

        private void sentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            sentListView.ContextMenuStrip = sentListView.SelectedIndices.Count > 0 ? sentDeleteMenuStrip : null;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = inboxListView.SelectedItems[0];
            var subject = item.Text;
            PostManager.DeleteFromInbox(subject);
            PostManager.UpdateListView(inboxListView, sentListView);
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var item = sentListView.SelectedItems[0];
            var subject = item.Text;
            PostManager.DeleteFromSent(subject);
            PostManager.UpdateListView(inboxListView, sentListView);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            PostManager.Save();
        }
    }
}
