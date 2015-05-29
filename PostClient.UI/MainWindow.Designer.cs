namespace PostClient.UI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newMailToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getMailToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.inboxListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sentListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inboxDeleteMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentDeleteMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsGroupBox = new System.Windows.Forms.GroupBox();
            this.addPluginButton = new System.Windows.Forms.Button();
            this.pluginListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deletePluginContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.unloadPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openEmailMessengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.inboxDeleteMenuStrip.SuspendLayout();
            this.sentDeleteMenuStrip.SuspendLayout();
            this.pluginsGroupBox.SuspendLayout();
            this.deletePluginContextMenuStrip.SuspendLayout();
            this.trayContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(717, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(26, 17);
            this.statusLabel.Text = "Idle";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMailToolStripButton,
            this.getMailToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(717, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newMailToolStripButton
            // 
            this.newMailToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newMailToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newMailToolStripButton.Image")));
            this.newMailToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newMailToolStripButton.Name = "newMailToolStripButton";
            this.newMailToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newMailToolStripButton.Text = "New message";
            this.newMailToolStripButton.Click += new System.EventHandler(this.newMailToolStripButton_Click);
            // 
            // getMailToolStripButton
            // 
            this.getMailToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.getMailToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("getMailToolStripButton.Image")));
            this.getMailToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.getMailToolStripButton.Name = "getMailToolStripButton";
            this.getMailToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.getMailToolStripButton.Text = "Get all messages";
            this.getMailToolStripButton.Click += new System.EventHandler(this.getMailToolStripButton_Click);
            // 
            // inboxListView
            // 
            this.inboxListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.inboxListView.FullRowSelect = true;
            this.inboxListView.GridLines = true;
            this.inboxListView.Location = new System.Drawing.Point(6, 19);
            this.inboxListView.MultiSelect = false;
            this.inboxListView.Name = "inboxListView";
            this.inboxListView.Size = new System.Drawing.Size(390, 168);
            this.inboxListView.TabIndex = 3;
            this.inboxListView.UseCompatibleStateImageBehavior = false;
            this.inboxListView.View = System.Windows.Forms.View.Details;
            this.inboxListView.SelectedIndexChanged += new System.EventHandler(this.inboxListView_SelectedIndexChanged);
            this.inboxListView.DoubleClick += new System.EventHandler(this.inboxListView_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            this.columnHeader2.Width = 331;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inboxListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inbox messages";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sentListView);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sent messages";
            // 
            // sentListView
            // 
            this.sentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.sentListView.FullRowSelect = true;
            this.sentListView.GridLines = true;
            this.sentListView.Location = new System.Drawing.Point(6, 19);
            this.sentListView.MultiSelect = false;
            this.sentListView.Name = "sentListView";
            this.sentListView.Size = new System.Drawing.Size(390, 168);
            this.sentListView.TabIndex = 3;
            this.sentListView.UseCompatibleStateImageBehavior = false;
            this.sentListView.View = System.Windows.Forms.View.Details;
            this.sentListView.SelectedIndexChanged += new System.EventHandler(this.sentListView_SelectedIndexChanged);
            this.sentListView.DoubleClick += new System.EventHandler(this.sentListView_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subject";
            this.columnHeader4.Width = 336;
            // 
            // inboxDeleteMenuStrip
            // 
            this.inboxDeleteMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.inboxDeleteMenuStrip.Name = "inboxDeleteMenuStrip";
            this.inboxDeleteMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sentDeleteMenuStrip
            // 
            this.sentDeleteMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1});
            this.sentDeleteMenuStrip.Name = "sentDeleteMenuStrip";
            this.sentDeleteMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // pluginsGroupBox
            // 
            this.pluginsGroupBox.Controls.Add(this.addPluginButton);
            this.pluginsGroupBox.Controls.Add(this.pluginListView);
            this.pluginsGroupBox.Location = new System.Drawing.Point(420, 52);
            this.pluginsGroupBox.Name = "pluginsGroupBox";
            this.pluginsGroupBox.Size = new System.Drawing.Size(285, 404);
            this.pluginsGroupBox.TabIndex = 5;
            this.pluginsGroupBox.TabStop = false;
            this.pluginsGroupBox.Text = "Plugins";
            // 
            // addPluginButton
            // 
            this.addPluginButton.Location = new System.Drawing.Point(6, 375);
            this.addPluginButton.Name = "addPluginButton";
            this.addPluginButton.Size = new System.Drawing.Size(273, 23);
            this.addPluginButton.TabIndex = 1;
            this.addPluginButton.Text = "Add plugin";
            this.addPluginButton.UseVisualStyleBackColor = true;
            this.addPluginButton.Click += new System.EventHandler(this.addPluginButton_Click);
            // 
            // pluginListView
            // 
            this.pluginListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.pluginListView.FullRowSelect = true;
            this.pluginListView.GridLines = true;
            this.pluginListView.Location = new System.Drawing.Point(6, 19);
            this.pluginListView.MultiSelect = false;
            this.pluginListView.Name = "pluginListView";
            this.pluginListView.Size = new System.Drawing.Size(273, 350);
            this.pluginListView.TabIndex = 0;
            this.pluginListView.UseCompatibleStateImageBehavior = false;
            this.pluginListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plugin";
            this.columnHeader1.Width = 243;
            // 
            // deletePluginContextMenuStrip
            // 
            this.deletePluginContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unloadPluginToolStripMenuItem});
            this.deletePluginContextMenuStrip.Name = "deletePluginContextMenuStrip";
            this.deletePluginContextMenuStrip.Size = new System.Drawing.Size(150, 26);
            // 
            // unloadPluginToolStripMenuItem
            // 
            this.unloadPluginToolStripMenuItem.Name = "unloadPluginToolStripMenuItem";
            this.unloadPluginToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.unloadPluginToolStripMenuItem.Text = "Unload plugin";
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "Hello, world!";
            this.trayIcon.BalloonTipTitle = "Email messenger";
            this.trayIcon.ContextMenuStrip = this.trayContextMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Email messenger";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openEmailMessengerToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.trayContextMenuStrip.Name = "trayContextMenuStrip";
            this.trayContextMenuStrip.Size = new System.Drawing.Size(196, 48);
            // 
            // openEmailMessengerToolStripMenuItem
            // 
            this.openEmailMessengerToolStripMenuItem.Name = "openEmailMessengerToolStripMenuItem";
            this.openEmailMessengerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openEmailMessengerToolStripMenuItem.Text = "Open Email messenger";
            this.openEmailMessengerToolStripMenuItem.Click += new System.EventHandler(this.openEmailMessengerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 481);
            this.Controls.Add(this.pluginsGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email messenger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.inboxDeleteMenuStrip.ResumeLayout(false);
            this.sentDeleteMenuStrip.ResumeLayout(false);
            this.pluginsGroupBox.ResumeLayout(false);
            this.deletePluginContextMenuStrip.ResumeLayout(false);
            this.trayContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newMailToolStripButton;
        private System.Windows.Forms.ToolStripButton getMailToolStripButton;
        private System.Windows.Forms.ListView inboxListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView sentListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip inboxDeleteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip sentDeleteMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.GroupBox pluginsGroupBox;
        private System.Windows.Forms.ListView pluginListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button addPluginButton;
        private System.Windows.Forms.ContextMenuStrip deletePluginContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem unloadPluginToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openEmailMessengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

