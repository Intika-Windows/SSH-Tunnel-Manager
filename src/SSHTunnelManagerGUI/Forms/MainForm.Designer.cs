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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Stopped", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Starting", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Waiting", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Started", 3, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("All hosts", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 3);
            label1.Margin = new System.Windows.Forms.Padding(3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 13);
            label1.TabIndex = 0;
            label1.Text = "Unique Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 22);
            label2.Margin = new System.Windows.Forms.Padding(3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 13);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(436, 3);
            label7.Margin = new System.Windows.Forms.Padding(3);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(40, 13);
            label7.TabIndex = 3;
            label7.Text = "Status:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(222, 3);
            label9.Margin = new System.Windows.Forms.Padding(3);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(70, 13);
            label9.TabIndex = 3;
            label9.Text = "Depends On:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(222, 22);
            label5.Margin = new System.Windows.Forms.Padding(3);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(32, 13);
            label5.TabIndex = 3;
            label5.Text = "Host:";
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
            this.hostsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostsGridView.Location = new System.Drawing.Point(0, 0);
            this.hostsGridView.MultiSelect = false;
            this.hostsGridView.Name = "hostsGridView";
            this.hostsGridView.RowHeadersVisible = false;
            this.hostsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hostsGridView.Size = new System.Drawing.Size(632, 213);
            this.hostsGridView.TabIndex = 0;
            this.hostsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.hostsGridView_CellFormatting);
            this.hostsGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.hostsGridView_CellMouseDoubleClick);
            this.hostsGridView.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.hostsGridView_RowContextMenuStripNeeded);
            // 
            // hgwStatusIconColumn
            // 
            this.hgwStatusIconColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hgwStatusIconColumn.FillWeight = 27.62246F;
            this.hgwStatusIconColumn.HeaderText = "*";
            this.hgwStatusIconColumn.MinimumWidth = 20;
            this.hgwStatusIconColumn.Name = "hgwStatusIconColumn";
            this.hgwStatusIconColumn.ReadOnly = true;
            this.hgwStatusIconColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hgwStatusIconColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hgwStatusIconColumn.Width = 25;
            // 
            // hgwNameColumn
            // 
            this.hgwNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hgwNameColumn.FillWeight = 20F;
            this.hgwNameColumn.HeaderText = "Unique Name";
            this.hgwNameColumn.MinimumWidth = 20;
            this.hgwNameColumn.Name = "hgwNameColumn";
            this.hgwNameColumn.ReadOnly = true;
            this.hgwNameColumn.Width = 97;
            // 
            // hgwUsernameColumn
            // 
            this.hgwUsernameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hgwUsernameColumn.HeaderText = "Username";
            this.hgwUsernameColumn.Name = "hgwUsernameColumn";
            this.hgwUsernameColumn.ReadOnly = true;
            this.hgwUsernameColumn.Width = 80;
            // 
            // hgwHostnameColumn
            // 
            this.hgwHostnameColumn.FillWeight = 95.02126F;
            this.hgwHostnameColumn.HeaderText = "Host";
            this.hgwHostnameColumn.Name = "hgwHostnameColumn";
            this.hgwHostnameColumn.ReadOnly = true;
            // 
            // hgwStatusColumn
            // 
            this.hgwStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hgwStatusColumn.FillWeight = 95.02126F;
            this.hgwStatusColumn.HeaderText = "Status";
            this.hgwStatusColumn.Name = "hgwStatusColumn";
            this.hgwStatusColumn.ReadOnly = true;
            this.hgwStatusColumn.Width = 62;
            // 
            // hgwDependsOnColumn
            // 
            this.hgwDependsOnColumn.HeaderText = "Depends On";
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
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(770, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.disk;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.saveToolStripMenuItem.Text = "Sa&ve";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // changeStorageToolStripMenuItem
            // 
            this.changeStorageToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.databases__arrow;
            this.changeStorageToolStripMenuItem.Name = "changeStorageToolStripMenuItem";
            this.changeStorageToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.changeStorageToolStripMenuItem.Text = "&Change Storage...";
            this.changeStorageToolStripMenuItem.Click += new System.EventHandler(this.changeStorageToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.key__arrow;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.changePasswordToolStripMenuItem.Text = "C&hange Password...";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
            // 
            // keepConnectionsExitToolStripMenuItem
            // 
            this.keepConnectionsExitToolStripMenuItem.Name = "keepConnectionsExitToolStripMenuItem";
            this.keepConnectionsExitToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.keepConnectionsExitToolStripMenuItem.Text = "E&xit but keep connections";
            this.keepConnectionsExitToolStripMenuItem.Click += new System.EventHandler(this.keepConnectionsExitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.exitToolStripMenuItem.Text = "Ex&it";
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
            this.hostToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hostToolStripMenuItem.Text = "&Host";
            // 
            // addHostToolStripMenuItem
            // 
            this.addHostToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__plus;
            this.addHostToolStripMenuItem.Name = "addHostToolStripMenuItem";
            this.addHostToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addHostToolStripMenuItem.Text = "&Add host...";
            this.addHostToolStripMenuItem.Click += new System.EventHandler(this.addHostToolStripMenuItem_Click);
            // 
            // editHostToolStripMenuItem
            // 
            this.editHostToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__pencil;
            this.editHostToolStripMenuItem.Name = "editHostToolStripMenuItem";
            this.editHostToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.editHostToolStripMenuItem.Text = "&Edit host...";
            this.editHostToolStripMenuItem.Click += new System.EventHandler(this.editHostToolStripMenuItem_Click);
            // 
            // removeHostToolStripMenuItem
            // 
            this.removeHostToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__minus;
            this.removeHostToolStripMenuItem.Name = "removeHostToolStripMenuItem";
            this.removeHostToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeHostToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.removeHostToolStripMenuItem.Text = "&Remove host";
            this.removeHostToolStripMenuItem.Click += new System.EventHandler(this.removeHostToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.control;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.startToolStripMenuItem.Text = "&Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.control_stop_square;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.stopToolStripMenuItem.Text = "S&top";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(167, 6);
            // 
            // startPuTTYToolStripMenuItem
            // 
            this.startPuTTYToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.icon_16x16_putty;
            this.startPuTTYToolStripMenuItem.Name = "startPuTTYToolStripMenuItem";
            this.startPuTTYToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.startPuTTYToolStripMenuItem.Text = "Start &PuTTY";
            this.startPuTTYToolStripMenuItem.Click += new System.EventHandler(this.startPuTTYToolStripMenuItem_Click);
            // 
            // startPsftpToolStripMenuItem
            // 
            this.startPsftpToolStripMenuItem.Name = "startPsftpToolStripMenuItem";
            this.startPsftpToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.startPsftpToolStripMenuItem.Text = "Start ps&ftp";
            this.startPsftpToolStripMenuItem.Click += new System.EventHandler(this.startPsftpToolStripMenuItem_Click);
            // 
            // startFileZillaSFTPToolStripMenuItem
            // 
            this.startFileZillaSFTPToolStripMenuItem.Image = global::SSHTunnelManagerGUI.Properties.Resources.filezilla;
            this.startFileZillaSFTPToolStripMenuItem.Name = "startFileZillaSFTPToolStripMenuItem";
            this.startFileZillaSFTPToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.startFileZillaSFTPToolStripMenuItem.Text = "Start F&ileZilla SFTP";
            this.startFileZillaSFTPToolStripMenuItem.Click += new System.EventHandler(this.startFileZillaSFTPToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "H&elp";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aboutToolStripMenuItem.Text = "&About SSH Tunnel Manager";
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
            this.theToolStrip.Location = new System.Drawing.Point(0, 24);
            this.theToolStrip.Name = "theToolStrip";
            this.theToolStrip.Size = new System.Drawing.Size(770, 25);
            this.theToolStrip.TabIndex = 2;
            this.theToolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::SSHTunnelManagerGUI.Properties.Resources.disk;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAddHost
            // 
            this.toolStripButtonAddHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__plus;
            this.toolStripButtonAddHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddHost.Name = "toolStripButtonAddHost";
            this.toolStripButtonAddHost.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddHost.Text = "New host...";
            this.toolStripButtonAddHost.Click += new System.EventHandler(this.toolStripButtonAddHost_Click);
            // 
            // toolStripButtonRemoveHost
            // 
            this.toolStripButtonRemoveHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__minus;
            this.toolStripButtonRemoveHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveHost.Name = "toolStripButtonRemoveHost";
            this.toolStripButtonRemoveHost.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemoveHost.Text = "Remove Host";
            this.toolStripButtonRemoveHost.Click += new System.EventHandler(this.toolStripButtonRemoveHost_Click);
            // 
            // toolStripButtonEditHost
            // 
            this.toolStripButtonEditHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__pencil;
            this.toolStripButtonEditHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditHost.Name = "toolStripButtonEditHost";
            this.toolStripButtonEditHost.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditHost.Text = "Edit Host...";
            this.toolStripButtonEditHost.Click += new System.EventHandler(this.toolStripButtonEditHost_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Image = global::SSHTunnelManagerGUI.Properties.Resources.control;
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStart.Text = "Start";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = global::SSHTunnelManagerGUI.Properties.Resources.control_stop_square;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // theStatusStrip
            // 
            this.theStatusStrip.Location = new System.Drawing.Point(0, 447);
            this.theStatusStrip.Name = "theStatusStrip";
            this.theStatusStrip.Size = new System.Drawing.Size(770, 22);
            this.theStatusStrip.TabIndex = 3;
            this.theStatusStrip.Text = "statusStrip1";
            // 
            // splitContainerH1
            // 
            this.splitContainerH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerH1.Location = new System.Drawing.Point(0, 49);
            this.splitContainerH1.Name = "splitContainerH1";
            // 
            // splitContainerH1.Panel1
            // 
            this.splitContainerH1.Panel1.Controls.Add(this.treeViewFilter);
            // 
            // splitContainerH1.Panel2
            // 
            this.splitContainerH1.Panel2.Controls.Add(this.splitContainerV1);
            this.splitContainerH1.Size = new System.Drawing.Size(770, 398);
            this.splitContainerH1.SplitterDistance = 134;
            this.splitContainerH1.TabIndex = 4;
            // 
            // treeViewFilter
            // 
            this.treeViewFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFilter.ImageIndex = 0;
            this.treeViewFilter.ImageList = this.imageListStates;
            this.treeViewFilter.Location = new System.Drawing.Point(0, 0);
            this.treeViewFilter.Name = "treeViewFilter";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "filterStoppedHostsNode";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Tag = "1";
            treeNode1.Text = "Stopped";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "filterUnknownHostsNode";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Tag = "2";
            treeNode2.Text = "Starting";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "filterWaitingHostsNode";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Tag = "3";
            treeNode3.Text = "Waiting";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "filterStartedHostsNode";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Tag = "4";
            treeNode4.Text = "Started";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "filterAllHostsNode";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Tag = "-1";
            treeNode5.Text = "All hosts";
            this.treeViewFilter.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeViewFilter.SelectedImageIndex = 0;
            this.treeViewFilter.Size = new System.Drawing.Size(134, 398);
            this.treeViewFilter.TabIndex = 0;
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
            this.splitContainerV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerV1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerV1.Name = "splitContainerV1";
            this.splitContainerV1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerV1.Panel1
            // 
            this.splitContainerV1.Panel1.Controls.Add(this.hostsGridView);
            // 
            // splitContainerV1.Panel2
            // 
            this.splitContainerV1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainerV1.Size = new System.Drawing.Size(632, 398);
            this.splitContainerV1.SplitterDistance = 213;
            this.splitContainerV1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 181);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.tableLayoutPanel1);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tabPageGeneral.Size = new System.Drawing.Size(624, 155);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(618, 152);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelUniqName
            // 
            this.labelUniqName.AutoSize = true;
            this.labelUniqName.Location = new System.Drawing.Point(84, 3);
            this.labelUniqName.Margin = new System.Windows.Forms.Padding(3);
            this.labelUniqName.Name = "labelUniqName";
            this.labelUniqName.Size = new System.Drawing.Size(33, 13);
            this.labelUniqName.TabIndex = 0;
            this.labelUniqName.Text = "value";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(84, 22);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(3);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(33, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "value";
            // 
            // labelDependsOn
            // 
            this.labelDependsOn.AutoSize = true;
            this.labelDependsOn.Location = new System.Drawing.Point(298, 3);
            this.labelDependsOn.Margin = new System.Windows.Forms.Padding(3);
            this.labelDependsOn.Name = "labelDependsOn";
            this.labelDependsOn.Size = new System.Drawing.Size(33, 13);
            this.labelDependsOn.TabIndex = 2;
            this.labelDependsOn.Text = "value";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(298, 22);
            this.labelHost.Margin = new System.Windows.Forms.Padding(3);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(33, 13);
            this.labelHost.TabIndex = 2;
            this.labelHost.Text = "value";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(482, 3);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(3);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(33, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "value";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tunnelsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tunnelsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tunnelsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tgvNameColumn,
            this.tgvTypeColumn,
            this.tgvSrcPortColumn,
            this.tgvDstHostColumn,
            this.tgvDstPortColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.tunnelsGridView, 6);
            this.tunnelsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tunnelsGridView.EnableHeadersVisualStyles = false;
            this.tunnelsGridView.Location = new System.Drawing.Point(3, 41);
            this.tunnelsGridView.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.tunnelsGridView.MultiSelect = false;
            this.tunnelsGridView.Name = "tunnelsGridView";
            this.tunnelsGridView.ReadOnly = true;
            this.tunnelsGridView.RowHeadersVisible = false;
            this.tunnelsGridView.RowTemplate.Height = 18;
            this.tunnelsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tunnelsGridView.Size = new System.Drawing.Size(615, 111);
            this.tunnelsGridView.TabIndex = 7;
            this.tunnelsGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tunnelsGridView_CellFormatting);
            this.tunnelsGridView.SelectionChanged += new System.EventHandler(this.tunnelsGridView_SelectionChanged);
            // 
            // tgvNameColumn
            // 
            this.tgvNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tgvNameColumn.HeaderText = "Tunnel";
            this.tgvNameColumn.Name = "tgvNameColumn";
            this.tgvNameColumn.ReadOnly = true;
            this.tgvNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tgvTypeColumn
            // 
            this.tgvTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tgvTypeColumn.HeaderText = "Type";
            this.tgvTypeColumn.Name = "tgvTypeColumn";
            this.tgvTypeColumn.ReadOnly = true;
            this.tgvTypeColumn.Width = 56;
            // 
            // tgvSrcPortColumn
            // 
            this.tgvSrcPortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tgvSrcPortColumn.HeaderText = "Src Port";
            this.tgvSrcPortColumn.Name = "tgvSrcPortColumn";
            this.tgvSrcPortColumn.ReadOnly = true;
            this.tgvSrcPortColumn.Width = 70;
            // 
            // tgvDstHostColumn
            // 
            this.tgvDstHostColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tgvDstHostColumn.HeaderText = "Dest Host";
            this.tgvDstHostColumn.Name = "tgvDstHostColumn";
            this.tgvDstHostColumn.ReadOnly = true;
            this.tgvDstHostColumn.Width = 79;
            // 
            // tgvDstPortColumn
            // 
            this.tgvDstPortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tgvDstPortColumn.HeaderText = "Dest Port";
            this.tgvDstPortColumn.Name = "tgvDstPortColumn";
            this.tgvDstPortColumn.ReadOnly = true;
            this.tgvDstPortColumn.Width = 76;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.listViewLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(624, 155);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // listViewLog
            // 
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewLog.Location = new System.Drawing.Point(0, 0);
            this.listViewLog.MultiSelect = false;
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.OwnerDraw = true;
            this.listViewLog.ShowGroups = false;
            this.listViewLog.Size = new System.Drawing.Size(624, 155);
            this.listViewLog.TabIndex = 2;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            this.listViewLog.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewLog_DrawSubItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Message";
            // 
            // contextMenuStripHost
            // 
            this.contextMenuStripHost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditHost,
            this.toolStripMenuItemRemoveHost});
            this.contextMenuStripHost.Name = "contextMenuStripHost";
            this.contextMenuStripHost.Size = new System.Drawing.Size(118, 48);
            // 
            // toolStripMenuItemEditHost
            // 
            this.toolStripMenuItemEditHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__pencil;
            this.toolStripMenuItemEditHost.Name = "toolStripMenuItemEditHost";
            this.toolStripMenuItemEditHost.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemEditHost.Text = "&Edit...";
            this.toolStripMenuItemEditHost.Click += new System.EventHandler(this.toolStripMenuItemEditHost_Click);
            // 
            // toolStripMenuItemRemoveHost
            // 
            this.toolStripMenuItemRemoveHost.Image = global::SSHTunnelManagerGUI.Properties.Resources.server__minus;
            this.toolStripMenuItemRemoveHost.Name = "toolStripMenuItemRemoveHost";
            this.toolStripMenuItemRemoveHost.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemRemoveHost.Text = "&Remove";
            this.toolStripMenuItemRemoveHost.Click += new System.EventHandler(this.toolStripMenuItemRemoveHost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 469);
            this.Controls.Add(this.splitContainerH1);
            this.Controls.Add(this.theStatusStrip);
            this.Controls.Add(this.theToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(620, 440);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSH Tunnel Manager";
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
    }
}