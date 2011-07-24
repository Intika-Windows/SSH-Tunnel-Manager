namespace PuttyManagerGui
{
    partial class PuttyManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuttyManagerForm));
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.windowsGridView = new System.Windows.Forms.DataGridView();
            this.wgwDescriptorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wgwStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wgwHwndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wgwShowColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.wgwHideColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.wgwKillColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.theMenuStrip = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killInactivePuttiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killAllPuttiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllPuttiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.autorecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewHosts = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripHosts = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteHostRecursively = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReconnect = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.windowsGridView)).BeginInit();
            this.theMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripHosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // theTimer
            // 
            this.theTimer.Enabled = true;
            this.theTimer.Interval = 500;
            this.theTimer.Tick += new System.EventHandler(this.theTimer_Tick);
            // 
            // windowsGridView
            // 
            this.windowsGridView.AllowUserToAddRows = false;
            this.windowsGridView.AllowUserToDeleteRows = false;
            this.windowsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.windowsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.windowsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.windowsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wgwDescriptorColumn,
            this.wgwStatusColumn,
            this.wgwHwndColumn,
            this.wgwShowColumn,
            this.wgwHideColumn,
            this.wgwKillColumn});
            this.windowsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsGridView.Location = new System.Drawing.Point(0, 0);
            this.windowsGridView.Name = "windowsGridView";
            this.windowsGridView.ReadOnly = true;
            this.windowsGridView.RowHeadersVisible = false;
            this.windowsGridView.Size = new System.Drawing.Size(384, 357);
            this.windowsGridView.TabIndex = 0;
            this.windowsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.windowsGridView_CellClick);
            this.windowsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.windowsGridView_CellFormatting);
            // 
            // wgwDescriptorColumn
            // 
            this.wgwDescriptorColumn.HeaderText = "Descriptor";
            this.wgwDescriptorColumn.Name = "wgwDescriptorColumn";
            this.wgwDescriptorColumn.ReadOnly = true;
            // 
            // wgwStatusColumn
            // 
            this.wgwStatusColumn.HeaderText = "Status";
            this.wgwStatusColumn.Name = "wgwStatusColumn";
            this.wgwStatusColumn.ReadOnly = true;
            // 
            // wgwHwndColumn
            // 
            this.wgwHwndColumn.HeaderText = "Hwnd";
            this.wgwHwndColumn.Name = "wgwHwndColumn";
            this.wgwHwndColumn.ReadOnly = true;
            this.wgwHwndColumn.Visible = false;
            // 
            // wgwShowColumn
            // 
            this.wgwShowColumn.FillWeight = 10F;
            this.wgwShowColumn.HeaderText = "Show";
            this.wgwShowColumn.MinimumWidth = 55;
            this.wgwShowColumn.Name = "wgwShowColumn";
            this.wgwShowColumn.ReadOnly = true;
            this.wgwShowColumn.Text = "Show it!";
            this.wgwShowColumn.UseColumnTextForButtonValue = true;
            // 
            // wgwHideColumn
            // 
            this.wgwHideColumn.FillWeight = 10F;
            this.wgwHideColumn.HeaderText = "Hide";
            this.wgwHideColumn.MinimumWidth = 55;
            this.wgwHideColumn.Name = "wgwHideColumn";
            this.wgwHideColumn.ReadOnly = true;
            this.wgwHideColumn.Text = "Hide it!";
            this.wgwHideColumn.UseColumnTextForButtonValue = true;
            // 
            // wgwKillColumn
            // 
            this.wgwKillColumn.FillWeight = 10F;
            this.wgwKillColumn.HeaderText = "Kill";
            this.wgwKillColumn.MinimumWidth = 55;
            this.wgwKillColumn.Name = "wgwKillColumn";
            this.wgwKillColumn.ReadOnly = true;
            this.wgwKillColumn.Text = "Kill it!";
            this.wgwKillColumn.UseColumnTextForButtonValue = true;
            // 
            // theMenuStrip
            // 
            this.theMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.theMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.theMenuStrip.Name = "theMenuStrip";
            this.theMenuStrip.Size = new System.Drawing.Size(585, 24);
            this.theMenuStrip.TabIndex = 1;
            this.theMenuStrip.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killInactivePuttiesToolStripMenuItem,
            this.killAllPuttiesToolStripMenuItem,
            this.showAllPuttiesToolStripMenuItem,
            this.toolStripSeparator3,
            this.resetPasswordToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator2,
            this.autorecoveryToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // killInactivePuttiesToolStripMenuItem
            // 
            this.killInactivePuttiesToolStripMenuItem.Name = "killInactivePuttiesToolStripMenuItem";
            this.killInactivePuttiesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.killInactivePuttiesToolStripMenuItem.Text = "&Kill inactive putties";
            this.killInactivePuttiesToolStripMenuItem.Click += new System.EventHandler(this.killInactivePuttiesToolStripMenuItem_Click);
            // 
            // killAllPuttiesToolStripMenuItem
            // 
            this.killAllPuttiesToolStripMenuItem.Name = "killAllPuttiesToolStripMenuItem";
            this.killAllPuttiesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.killAllPuttiesToolStripMenuItem.Text = "K&ill all putties";
            this.killAllPuttiesToolStripMenuItem.Click += new System.EventHandler(this.killAllPuttiesToolStripMenuItem_Click);
            // 
            // showAllPuttiesToolStripMenuItem
            // 
            this.showAllPuttiesToolStripMenuItem.Name = "showAllPuttiesToolStripMenuItem";
            this.showAllPuttiesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showAllPuttiesToolStripMenuItem.Text = "&Show all putties";
            this.showAllPuttiesToolStripMenuItem.Click += new System.EventHandler(this.showAllPuttiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(174, 6);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.resetPasswordToolStripMenuItem.Text = "&Reset password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.removePasswordToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.changePasswordToolStripMenuItem.Text = "&Change password...";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(174, 6);
            // 
            // autorecoveryToolStripMenuItem
            // 
            this.autorecoveryToolStripMenuItem.Checked = true;
            this.autorecoveryToolStripMenuItem.CheckOnClick = true;
            this.autorecoveryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autorecoveryToolStripMenuItem.Name = "autorecoveryToolStripMenuItem";
            this.autorecoveryToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.autorecoveryToolStripMenuItem.Text = "Auto Recovery";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // treeViewHosts
            // 
            this.treeViewHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewHosts.Location = new System.Drawing.Point(0, 25);
            this.treeViewHosts.Name = "treeViewHosts";
            this.treeViewHosts.Size = new System.Drawing.Size(195, 332);
            this.treeViewHosts.TabIndex = 2;
            this.treeViewHosts.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewHosts_NodeMouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripHosts);
            this.splitContainer1.Panel1.Controls.Add(this.treeViewHosts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.windowsGridView);
            this.splitContainer1.Size = new System.Drawing.Size(585, 357);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 4;
            // 
            // toolStripHosts
            // 
            this.toolStripHosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddHost,
            this.toolStripButtonDeleteHost,
            this.toolStripButtonDeleteHostRecursively,
            this.toolStripSeparator4,
            this.toolStripButtonConnect,
            this.toolStripButtonDisconnect,
            this.toolStripButtonReconnect});
            this.toolStripHosts.Location = new System.Drawing.Point(0, 0);
            this.toolStripHosts.Name = "toolStripHosts";
            this.toolStripHosts.Size = new System.Drawing.Size(195, 25);
            this.toolStripHosts.TabIndex = 4;
            this.toolStripHosts.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAddHost
            // 
            this.toolStripButtonAddHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddHost.Image = global::PuttyManagerGui.Properties.Resources.server__plus;
            this.toolStripButtonAddHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddHost.Name = "toolStripButtonAddHost";
            this.toolStripButtonAddHost.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddHost.Text = "Add new host...";
            this.toolStripButtonAddHost.Click += new System.EventHandler(this.toolStripButtonAddHost_Click);
            // 
            // toolStripButtonDeleteHost
            // 
            this.toolStripButtonDeleteHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteHost.Image = global::PuttyManagerGui.Properties.Resources.server__minus;
            this.toolStripButtonDeleteHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteHost.Name = "toolStripButtonDeleteHost";
            this.toolStripButtonDeleteHost.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteHost.Text = "Delete selected host";
            this.toolStripButtonDeleteHost.Click += new System.EventHandler(this.toolStripButtonDeleteHost_Click);
            // 
            // toolStripButtonDeleteHostRecursively
            // 
            this.toolStripButtonDeleteHostRecursively.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDeleteHostRecursively.Image = global::PuttyManagerGui.Properties.Resources.servers__minus;
            this.toolStripButtonDeleteHostRecursively.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeleteHostRecursively.Name = "toolStripButtonDeleteHostRecursively";
            this.toolStripButtonDeleteHostRecursively.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDeleteHostRecursively.Text = "Delete selected host and dependent hosts";
            this.toolStripButtonDeleteHostRecursively.Click += new System.EventHandler(this.toolStripButtonDeleteHostRecursively_Click);
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConnect.Image = global::PuttyManagerGui.Properties.Resources.arrow_skip_090;
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonConnect.Text = "Connect to host";
            this.toolStripButtonConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // toolStripButtonDisconnect
            // 
            this.toolStripButtonDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDisconnect.Image = global::PuttyManagerGui.Properties.Resources.arrow_skip_270;
            this.toolStripButtonDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDisconnect.Name = "toolStripButtonDisconnect";
            this.toolStripButtonDisconnect.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDisconnect.Text = "Disconnect from host";
            // 
            // toolStripButtonReconnect
            // 
            this.toolStripButtonReconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReconnect.Image = global::PuttyManagerGui.Properties.Resources.arrow_circle_315;
            this.toolStripButtonReconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReconnect.Name = "toolStripButtonReconnect";
            this.toolStripButtonReconnect.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReconnect.Text = "Reconnect";
            // 
            // PuttyManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 381);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.theMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.theMenuStrip;
            this.Name = "PuttyManagerForm";
            this.Text = "SSH Tunnel Manager";
            ((System.ComponentModel.ISupportInitialize)(this.windowsGridView)).EndInit();
            this.theMenuStrip.ResumeLayout(false);
            this.theMenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStripHosts.ResumeLayout(false);
            this.toolStripHosts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer theTimer;
        private System.Windows.Forms.DataGridView windowsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn wgwDescriptorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wgwStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wgwHwndColumn;
        private System.Windows.Forms.DataGridViewButtonColumn wgwShowColumn;
        private System.Windows.Forms.DataGridViewButtonColumn wgwHideColumn;
        private System.Windows.Forms.DataGridViewButtonColumn wgwKillColumn;
        private System.Windows.Forms.MenuStrip theMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killInactivePuttiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killAllPuttiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllPuttiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem autorecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.TreeView treeViewHosts;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStripHosts;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddHost;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteHost;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteHostRecursively;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisconnect;
        private System.Windows.Forms.ToolStripButton toolStripButtonReconnect;

    }
}

