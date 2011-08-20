namespace SSHTunnelManagerGUI.Forms
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hostsGridView = new System.Windows.Forms.DataGridView();
            this.hgwStatusIconColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.hgwNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgwUsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgwHostnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgwStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgwDependsOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changeStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.keepConnectionsExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.startPuTTYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startPsftpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startFileZillaSFTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.theStatusStrip = new System.Windows.Forms.StatusStrip();
            this.splitContainerH1 = new System.Windows.Forms.SplitContainer();
            this.treeViewFilter = new System.Windows.Forms.TreeView();
            this.imageListStates = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerV1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelUniqName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelDependsOn = new System.Windows.Forms.Label();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tunnelsGridView = new System.Windows.Forms.DataGridView();
            this.tgvNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvSrcPortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvDstHostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvDstPortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripHost = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditHost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveHost = new System.Windows.Forms.ToolStripMenuItem();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hostsGridView)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.theToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerH1)).BeginInit();
            this.splitContainerH1.Panel1.SuspendLayout();
            this.splitContainerH1.Panel2.SuspendLayout();
            this.splitContainerH1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerV1)).BeginInit();
            this.splitContainerV1.Panel1.SuspendLayout();
            this.splitContainerV1.Panel2.SuspendLayout();
            this.splitContainerV1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tunnelsGridView)).BeginInit();
            this.tabPageLog.SuspendLayout();
            this.contextMenuStripHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // hostsGridView
            // 
            this.hostsGridView.AllowUserToAddRows = false;
            this.hostsGridView.AllowUserToDeleteRows = false;
            this.hostsGridView.AllowUserToResizeRows = false;
            this.hostsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hostsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.hostsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.hostsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hostsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hgwStatusIconColumn,
            this.hgwNameColumn,
            this.hgwUsernameColumn,
            this.hgwHostnameColumn,
            this.hgwStatusColumn,
            this.hgwDependsOnColumn});
            resources.ApplyResources(this.hostsGridView, "hostsGridView");
            this.hostsGridView.MultiSelect = false;
            this.hostsGridView.Name = "hostsGridView";
            this.hostsGridView.RowHeadersVisible = false;
            this.hostsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hostsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.hostsGridView_CellFormatting);
            this.hostsGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.hostsGridView_CellMouseDoubleClick);
            this.hostsGridView.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.hostsGridView_RowContextMenuStripNeeded);
            // 
            // hgwStatusIconColumn
            // 
            this.hgwStatusIconColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hgwStatusIconColumn.FillWeight = 27.62246F;
            resources.ApplyResources(this.hgwStatusIconColumn, "hgwStatusIconColumn");
            this.hgwStatusIconColumn.Name = "hgwStatusIconColumn";
            this.hgwStatusIconColumn.ReadOnly = true;
            this.hgwStatusIconColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hgwStatusIconColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // hgwNameColumn
            // 
            this.hgwNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hgwNameColumn.FillWeight = 20F;
            resources.ApplyResources(this.hgwNameColumn, "hgwNameColumn");
            this.hgwNameColumn.Name = "hgwNameColumn";
            this.hgwNameColumn.ReadOnly = true;
            // 
            // hgwUsernameColumn
            // 
            this.hgwUsernameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.hgwUsernameColumn, "hgwUsernameColumn");
            this.hgwUsernameColumn.Name = "hgwUsernameColumn";
            this.hgwUsernameColumn.ReadOnly = true;
            // 
            // hgwHostnameColumn
            // 
            this.hgwHostnameColumn.FillWeight = 95.02126F;
            resources.ApplyResources(this.hgwHostnameColumn, "hgwHostnameColumn");
            this.hgwHostnameColumn.Name = "hgwHostnameColumn";
            this.hgwHostnameColumn.ReadOnly = true;
            // 
            // hgwStatusColumn
            // 
            this.hgwStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hgwStatusColumn.FillWeight = 95.02126F;
            resources.ApplyResources(this.hgwStatusColumn, "hgwStatusColumn");
            this.hgwStatusColumn.Name = "hgwStatusColumn";
            this.hgwStatusColumn.ReadOnly = true;
            // 
            // hgwDependsOnColumn
            // 
            resources.ApplyResources(this.hgwDependsOnColumn, "hgwDependsOnColumn");
            this.hgwDependsOnColumn.Name = "hgwDependsOnColumn";
            this.hgwDependsOnColumn.ReadOnly = true;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hostToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.Name = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.changeStorageToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator4,
            this.keepConnectionsExitToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.disk;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // changeStorageToolStripMenuItem
            // 
            this.changeStorageToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.databases__arrow;
            this.changeStorageToolStripMenuItem.Name = "changeStorageToolStripMenuItem";
            resources.ApplyResources(this.changeStorageToolStripMenuItem, "changeStorageToolStripMenuItem");
            this.changeStorageToolStripMenuItem.Click += new System.EventHandler(this.changeStorageToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.key__arrow;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            resources.ApplyResources(this.changePasswordToolStripMenuItem, "changePasswordToolStripMenuItem");
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // keepConnectionsExitToolStripMenuItem
            // 
            this.keepConnectionsExitToolStripMenuItem.Name = "keepConnectionsExitToolStripMenuItem";
            resources.ApplyResources(this.keepConnectionsExitToolStripMenuItem, "keepConnectionsExitToolStripMenuItem");
            this.keepConnectionsExitToolStripMenuItem.Click += new System.EventHandler(this.keepConnectionsExitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hostToolStripMenuItem
            // 
            this.hostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHostToolStripMenuItem,
            this.editHostToolStripMenuItem,
            this.removeHostToolStripMenuItem,
            this.toolStripSeparator2,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator7,
            this.startPuTTYToolStripMenuItem,
            this.startPsftpToolStripMenuItem,
            this.startFileZillaSFTPToolStripMenuItem});
            this.hostToolStripMenuItem.Name = "hostToolStripMenuItem";
            resources.ApplyResources(this.hostToolStripMenuItem, "hostToolStripMenuItem");
            // 
            // addHostToolStripMenuItem
            // 
            this.addHostToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__plus;
            this.addHostToolStripMenuItem.Name = "addHostToolStripMenuItem";
            resources.ApplyResources(this.addHostToolStripMenuItem, "addHostToolStripMenuItem");
            this.addHostToolStripMenuItem.Click += new System.EventHandler(this.addHostToolStripMenuItem_Click);
            // 
            // editHostToolStripMenuItem
            // 
            this.editHostToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__pencil;
            this.editHostToolStripMenuItem.Name = "editHostToolStripMenuItem";
            resources.ApplyResources(this.editHostToolStripMenuItem, "editHostToolStripMenuItem");
            this.editHostToolStripMenuItem.Click += new System.EventHandler(this.editHostToolStripMenuItem_Click);
            // 
            // removeHostToolStripMenuItem
            // 
            this.removeHostToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__minus;
            this.removeHostToolStripMenuItem.Name = "removeHostToolStripMenuItem";
            resources.ApplyResources(this.removeHostToolStripMenuItem, "removeHostToolStripMenuItem");
            this.removeHostToolStripMenuItem.Click += new System.EventHandler(this.removeHostToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.control;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.control_stop_square;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // startPuTTYToolStripMenuItem
            // 
            this.startPuTTYToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.icon_16x16_putty;
            this.startPuTTYToolStripMenuItem.Name = "startPuTTYToolStripMenuItem";
            resources.ApplyResources(this.startPuTTYToolStripMenuItem, "startPuTTYToolStripMenuItem");
            this.startPuTTYToolStripMenuItem.Click += new System.EventHandler(this.startPuTTYToolStripMenuItem_Click);
            // 
            // startPsftpToolStripMenuItem
            // 
            this.startPsftpToolStripMenuItem.Name = "startPsftpToolStripMenuItem";
            resources.ApplyResources(this.startPsftpToolStripMenuItem, "startPsftpToolStripMenuItem");
            this.startPsftpToolStripMenuItem.Click += new System.EventHandler(this.startPsftpToolStripMenuItem_Click);
            // 
            // startFileZillaSFTPToolStripMenuItem
            // 
            this.startFileZillaSFTPToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.filezilla;
            this.startFileZillaSFTPToolStripMenuItem.Name = "startFileZillaSFTPToolStripMenuItem";
            resources.ApplyResources(this.startFileZillaSFTPToolStripMenuItem, "startFileZillaSFTPToolStripMenuItem");
            this.startFileZillaSFTPToolStripMenuItem.Click += new System.EventHandler(this.startFileZillaSFTPToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.Gear;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // theToolStrip
            // 
            this.theToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripSeparator5,
            this.toolStripButtonAddHost,
            this.toolStripButtonRemoveHost,
            this.toolStripButtonEditHost,
            this.toolStripSeparator3,
            this.toolStripButtonStart,
            this.toolStripButtonStop});
            resources.ApplyResources(this.theToolStrip, "theToolStrip");
            this.theToolStrip.Name = "theToolStrip";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::SSHTunnelManagerGUI.Properties.Resources.disk;
            resources.ApplyResources(this.toolStripButtonSave, "toolStripButtonSave");
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // toolStripButtonAddHost
            // 
            this.toolStripButtonAddHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__plus;
            resources.ApplyResources(this.toolStripButtonAddHost, "toolStripButtonAddHost");
            this.toolStripButtonAddHost.Name = "toolStripButtonAddHost";
            this.toolStripButtonAddHost.Click += new System.EventHandler(this.toolStripButtonAddHost_Click);
            // 
            // toolStripButtonRemoveHost
            // 
            this.toolStripButtonRemoveHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__minus;
            resources.ApplyResources(this.toolStripButtonRemoveHost, "toolStripButtonRemoveHost");
            this.toolStripButtonRemoveHost.Name = "toolStripButtonRemoveHost";
            this.toolStripButtonRemoveHost.Click += new System.EventHandler(this.toolStripButtonRemoveHost_Click);
            // 
            // toolStripButtonEditHost
            // 
            this.toolStripButtonEditHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__pencil;
            resources.ApplyResources(this.toolStripButtonEditHost, "toolStripButtonEditHost");
            this.toolStripButtonEditHost.Name = "toolStripButtonEditHost";
            this.toolStripButtonEditHost.Click += new System.EventHandler(this.toolStripButtonEditHost_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Image = global::SSHTunnelManagerGUI.Properties.Resources.control;
            resources.ApplyResources(this.toolStripButtonStart, "toolStripButtonStart");
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = global::SSHTunnelManagerGUI.Properties.Resources.control_stop_square;
            resources.ApplyResources(this.toolStripButtonStop, "toolStripButtonStop");
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // theStatusStrip
            // 
            resources.ApplyResources(this.theStatusStrip, "theStatusStrip");
            this.theStatusStrip.Name = "theStatusStrip";
            // 
            // splitContainerH1
            // 
            resources.ApplyResources(this.splitContainerH1, "splitContainerH1");
            this.splitContainerH1.Name = "splitContainerH1";
            // 
            // splitContainerH1.Panel1
            // 
            this.splitContainerH1.Panel1.Controls.Add(this.treeViewFilter);
            // 
            // splitContainerH1.Panel2
            // 
            this.splitContainerH1.Panel2.Controls.Add(this.splitContainerV1);
            // 
            // treeViewFilter
            // 
            resources.ApplyResources(this.treeViewFilter, "treeViewFilter");
            this.treeViewFilter.ImageList = this.imageListStates;
            this.treeViewFilter.Name = "treeViewFilter";
            this.treeViewFilter.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewFilter.Nodes")))});
            this.treeViewFilter.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFilter_AfterSelect);
            // 
            // imageListStates
            // 
            this.imageListStates.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStates.ImageStream")));
            this.imageListStates.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStates.Images.SetKeyName(0, "control_stop_square_small.png");
            this.imageListStates.Images.SetKeyName(1, "control_stop_square_small.png");
            this.imageListStates.Images.SetKeyName(2, "brightness_small.png");
            this.imageListStates.Images.SetKeyName(3, "tick_small_circle.png");
            this.imageListStates.Images.SetKeyName(4, "servers.png");
            // 
            // splitContainerV1
            // 
            resources.ApplyResources(this.splitContainerV1, "splitContainerV1");
            this.splitContainerV1.Name = "splitContainerV1";
            // 
            // splitContainerV1.Panel1
            // 
            this.splitContainerV1.Panel1.Controls.Add(this.hostsGridView);
            // 
            // splitContainerV1.Panel2
            // 
            this.splitContainerV1.Panel2.Controls.Add(this.tabControl1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageLog);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.tabPageGeneral, "tabPageGeneral");
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelUniqName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelUsername, 1, 1);
            this.tableLayoutPanel1.Controls.Add(label9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDependsOn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelHost, 3, 1);
            this.tableLayoutPanel1.Controls.Add(label7, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.tunnelsGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label5, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // labelUniqName
            // 
            resources.ApplyResources(this.labelUniqName, "labelUniqName");
            this.labelUniqName.Name = "labelUniqName";
            // 
            // labelUsername
            // 
            resources.ApplyResources(this.labelUsername, "labelUsername");
            this.labelUsername.Name = "labelUsername";
            // 
            // labelDependsOn
            // 
            resources.ApplyResources(this.labelDependsOn, "labelDependsOn");
            this.labelDependsOn.Name = "labelDependsOn";
            // 
            // labelHost
            // 
            resources.ApplyResources(this.labelHost, "labelHost");
            this.labelHost.Name = "labelHost";
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            // 
            // tunnelsGridView
            // 
            this.tunnelsGridView.AllowUserToAddRows = false;
            this.tunnelsGridView.AllowUserToDeleteRows = false;
            this.tunnelsGridView.AllowUserToResizeRows = false;
            this.tunnelsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tunnelsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tunnelsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tunnelsGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tunnelsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tunnelsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tunnelsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tunnelsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tgvNameColumn,
            this.tgvTypeColumn,
            this.tgvSrcPortColumn,
            this.tgvDstHostColumn,
            this.tgvDstPortColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.tunnelsGridView, 6);
            resources.ApplyResources(this.tunnelsGridView, "tunnelsGridView");
            this.tunnelsGridView.EnableHeadersVisualStyles = false;
            this.tunnelsGridView.MultiSelect = false;
            this.tunnelsGridView.Name = "tunnelsGridView";
            this.tunnelsGridView.ReadOnly = true;
            this.tunnelsGridView.RowHeadersVisible = false;
            this.tunnelsGridView.RowTemplate.Height = 18;
            this.tunnelsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tunnelsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tunnelsGridView_CellFormatting);
            this.tunnelsGridView.SelectionChanged += new System.EventHandler(this.tunnelsGridView_SelectionChanged);
            // 
            // tgvNameColumn
            // 
            this.tgvNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.tgvNameColumn, "tgvNameColumn");
            this.tgvNameColumn.Name = "tgvNameColumn";
            this.tgvNameColumn.ReadOnly = true;
            this.tgvNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tgvTypeColumn
            // 
            this.tgvTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.tgvTypeColumn, "tgvTypeColumn");
            this.tgvTypeColumn.Name = "tgvTypeColumn";
            this.tgvTypeColumn.ReadOnly = true;
            // 
            // tgvSrcPortColumn
            // 
            this.tgvSrcPortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.tgvSrcPortColumn, "tgvSrcPortColumn");
            this.tgvSrcPortColumn.Name = "tgvSrcPortColumn";
            this.tgvSrcPortColumn.ReadOnly = true;
            // 
            // tgvDstHostColumn
            // 
            this.tgvDstHostColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.tgvDstHostColumn, "tgvDstHostColumn");
            this.tgvDstHostColumn.Name = "tgvDstHostColumn";
            this.tgvDstHostColumn.ReadOnly = true;
            // 
            // tgvDstPortColumn
            // 
            this.tgvDstPortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.tgvDstPortColumn, "tgvDstPortColumn");
            this.tgvDstPortColumn.Name = "tgvDstPortColumn";
            this.tgvDstPortColumn.ReadOnly = true;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.listViewLog);
            resources.ApplyResources(this.tabPageLog, "tabPageLog");
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // listViewLog
            // 
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            resources.ApplyResources(this.listViewLog, "listViewLog");
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewLog.MultiSelect = false;
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.OwnerDraw = true;
            this.listViewLog.ShowGroups = false;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            this.listViewLog.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewLog_DrawSubItem);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // contextMenuStripHost
            // 
            this.contextMenuStripHost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditHost,
            this.toolStripMenuItemRemoveHost});
            this.contextMenuStripHost.Name = "contextMenuStripHost";
            resources.ApplyResources(this.contextMenuStripHost, "contextMenuStripHost");
            // 
            // toolStripMenuItemEditHost
            // 
            this.toolStripMenuItemEditHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__pencil;
            this.toolStripMenuItemEditHost.Name = "toolStripMenuItemEditHost";
            resources.ApplyResources(this.toolStripMenuItemEditHost, "toolStripMenuItemEditHost");
            this.toolStripMenuItemEditHost.Click += new System.EventHandler(this.toolStripMenuItemEditHost_Click);
            // 
            // toolStripMenuItemRemoveHost
            // 
            this.toolStripMenuItemRemoveHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__minus;
            this.toolStripMenuItemRemoveHost.Name = "toolStripMenuItemRemoveHost";
            resources.ApplyResources(this.toolStripMenuItemRemoveHost, "toolStripMenuItemRemoveHost");
            this.toolStripMenuItemRemoveHost.Click += new System.EventHandler(this.toolStripMenuItemRemoveHost_Click);
            // 
            // theTimer
            // 
            this.theTimer.Interval = 10000;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerH1);
            this.Controls.Add(this.theStatusStrip);
            this.Controls.Add(this.theToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.hostsGridView)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.theToolStrip.ResumeLayout(false);
            this.theToolStrip.PerformLayout();
            this.splitContainerH1.Panel1.ResumeLayout(false);
            this.splitContainerH1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerH1)).EndInit();
            this.splitContainerH1.ResumeLayout(false);
            this.splitContainerV1.Panel1.ResumeLayout(false);
            this.splitContainerV1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerV1)).EndInit();
            this.splitContainerV1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tunnelsGridView)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            this.contextMenuStripHost.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hostsGridView;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keepConnectionsExitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip theToolStrip;
        private System.Windows.Forms.StatusStrip theStatusStrip;
        private System.Windows.Forms.SplitContainer splitContainerH1;
        private System.Windows.Forms.SplitContainer splitContainerV1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddHost;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHost;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditHost;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveHost;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveHost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditHost;
        private System.Windows.Forms.DataGridViewImageColumn hgwStatusIconColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hgwNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hgwUsernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hgwHostnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hgwStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hgwDependsOnColumn;
        private System.Windows.Forms.TreeView treeViewFilter;
        private System.Windows.Forms.ImageList imageListStates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUniqName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDependsOn;
        private System.Windows.Forms.DataGridView tunnelsGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvSrcPortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvDstHostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvDstPortColumn;
        private System.Windows.Forms.ToolStripMenuItem editHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ListView listViewLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem startPuTTYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startPsftpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startFileZillaSFTPToolStripMenuItem;
        private System.Windows.Forms.Timer theTimer;
    }
}