using System;
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
            UpdatePostAsync();
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
            PluginManager.SavePluginList();
            PluginManager.UnloadAllPlugins();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdatePostAsync();
            PluginManager.LoadSavedPlugins(this, inboxListView, sentListView, pluginListView);
            PluginManager.UpdatePluginListView(pluginListView);
        }

        private void UpdatePostAsync()
        {
            var inboxTask = Task.Run(() =>
            {
                this.Invoke(() => { statusLabel.Text = "Loading inbox messages"; });
                PostManager.ReceiveInbox();
                this.Invoke(() => { statusLabel.Text = "Loading sent messages"; });
                PostManager.ReceiveSent();
                PostManager.UpdateListView(inboxListView, sentListView);
                this.Invoke(() => { statusLabel.Text = "Idle"; });
            });
        }

        private void inboxListView_DoubleClick(object sender, EventArgs e)
        {
            if (inboxListView.SelectedIndices.Count != 1)
                return;
            var item = (sender as ListView).SelectedItems[0];
            var msg = PostManager.FindInInbox(item.Text);
            var msgWnd = new EmailWindow(ShowMessageType.View, msg);
            msgWnd.ShowDialog();
        }

        private void sentListView_DoubleClick(object sender, EventArgs e)
        {
            if (sentListView.SelectedIndices.Count != 1)
                return;
            var item = (sender as ListView).SelectedItems[0];
            var msg = PostManager.FindInSent(item.Text);
            var msgWnd = new EmailWindow(ShowMessageType.View, msg, true);
            msgWnd.ShowDialog();
        }

        private void addPluginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = "Plugin assemblies (*.dll) | *.dll";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PluginManager.LoadSinglePlugin(dialog.FileName, this, inboxListView, sentListView, pluginListView);
                    PluginManager.UpdatePluginListView(pluginListView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pluginListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            pluginListView.ContextMenuStrip = pluginListView.SelectedIndices.Count == 1
                ? deletePluginContextMenuStrip
                : null;
        }

        private void unloadPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = pluginListView.SelectedItems[0];
            PluginManager.UnloadSinglePlugin(item.Text);
            PluginManager.UpdatePluginListView(pluginListView);
        }
    }
}