using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PostClient.TrayPlugin.Properties;
using PostClient.UI;

namespace PostClient.TrayPlugin
{
    internal class TrayPlugin : IPlugin
    {
        private readonly ToolStripMenuItem exitToolStripMenuItem1 = new ToolStripMenuItem();
        private readonly ToolStripMenuItem openEmailMessengerToolStripMenuItem = new ToolStripMenuItem();
        private readonly ContextMenuStrip trayContextMenuStrip = new ContextMenuStrip();
        private readonly NotifyIcon trayIcon = new NotifyIcon();
        private ListView inboxListView;
        private ListView pluginListView;
        private ComponentResourceManager resources;
        private ListView sentListView;
        private Form targetForm;

        public void Dispose()
        {
            targetForm.Resize -= MainWindow_Resize;
            trayIcon.Dispose();
        }

        public void DoActions(Form form, ListView inboxListView, ListView sentListView, ListView pluginListView)
        {
            this.inboxListView = inboxListView;
            this.sentListView = sentListView;
            this.pluginListView = pluginListView;
            targetForm = form;
            InitializeComponents();
            MessageBox.Show("Tray plugin loaded");
            targetForm.Resize += MainWindow_Resize;
        }

        ~TrayPlugin()
        {
            Dispose();
        }

        private void InitializeComponents()
        {
            resources = new ComponentResourceManager(targetForm.GetType());
            // 
            // trayIcon
            // 
            trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            trayIcon.ContextMenuStrip = trayContextMenuStrip;
            trayIcon.Icon = Resources.trayIcon;
            trayIcon.Text = "Email messenger";
            trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;

            // 
            // trayContextMenuStrip
            // 
            trayContextMenuStrip.Items.AddRange(new ToolStripItem[]
            {
                openEmailMessengerToolStripMenuItem,
                exitToolStripMenuItem1
            });
            trayContextMenuStrip.Name = "trayContextMenuStrip";
            trayContextMenuStrip.Size = new Size(196, 48);
            // 
            // openEmailMessengerToolStripMenuItem
            // 
            openEmailMessengerToolStripMenuItem.Name = "openEmailMessengerToolStripMenuItem";
            openEmailMessengerToolStripMenuItem.Size = new Size(195, 22);
            openEmailMessengerToolStripMenuItem.Text = "Open Email messenger";
            openEmailMessengerToolStripMenuItem.Click += openEmailMessengerToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(195, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == targetForm.WindowState)
            {
                trayIcon.Visible = true;
                targetForm.Hide();
            }

            else if (FormWindowState.Normal == targetForm.WindowState)
            {
                trayIcon.Visible = false;
            }
        }

        private void openEmailMessengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            targetForm.Show();
            targetForm.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            targetForm.Close();
            Application.Exit();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var formatString = "{0} Inbox messages\n{1} Sent messages\n{2} Plugins loaded";
            trayIcon.BalloonTipTitle = "Statistics";
            trayIcon.BalloonTipIcon = ToolTipIcon.Info;
            trayIcon.BalloonTipText = String.Format(formatString, inboxListView.Items.Count, sentListView.Items.Count,
                pluginListView.Items.Count);
            trayIcon.ShowBalloonTip(500);
        }
    }
}