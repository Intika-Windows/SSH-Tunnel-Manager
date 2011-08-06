namespace PuttyManagerGui
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Unknown", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Started", 3, 3);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("All hosts", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.hostsGridView = new System.Windows.Forms.DataGridView();
            this.hgwStatusIconColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.hgwNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgwUsernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgwHostnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgwStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgwDependsOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newHostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killConnectionsExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditHost = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainerH1 = new System.Windows.Forms.SplitContainer();
            this.treeViewFilter = new System.Windows.Forms.TreeView();
            this.imageListStates = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerV1 = new System.Windows.Forms.SplitContainer();
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
            this.contextMenuStripHost = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemEditHost = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemoveHost = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hostsGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerH1)).BeginInit();
            this.splitContainerH1.Panel1.SuspendLayout();
            this.splitContainerH1.Panel2.SuspendLayout();
            this.splitContainerH1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerV1)).BeginInit();
            this.splitContainerV1.Panel1.SuspendLayout();
            this.splitContainerV1.Panel2.SuspendLayout();
            this.splitContainerV1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tunnelsGridView)).BeginInit();
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
            label7.Location = new System.Drawing.Point(444, 3);
            label7.Margin = new System.Windows.Forms.Padding(3);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(40, 13);
            label7.TabIndex = 3;
            label7.Text = "Status:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(226, 3);
            label9.Margin = new System.Windows.Forms.Padding(3);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(70, 13);
            label9.TabIndex = 3;
            label9.Text = "Depends On:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(226, 22);
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
            this.hostsGridView.Size = new System.Drawing.Size(630, 213);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newHostToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.killConnectionsExitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // newHostToolStripMenuItem
            // 
            this.newHostToolStripMenuItem.Image = global::PuttyManagerGui.Properties.Resources.server__plus;
            this.newHostToolStripMenuItem.Name = "newHostToolStripMenuItem";
            this.newHostToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.newHostToolStripMenuItem.Text = "&New host...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // killConnectionsExitToolStripMenuItem
            // 
            this.killConnectionsExitToolStripMenuItem.Name = "killConnectionsExitToolStripMenuItem";
            this.killConnectionsExitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.killConnectionsExitToolStripMenuItem.Text = "&Kill connections && Exit";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddHost,
            this.toolStripButtonRemoveHost,
            this.toolStripButtonEditHost,
            this.toolStripSeparator3,
            this.toolStripButtonStart,
            this.toolStripButtonStop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddHost
            // 
            this.toolStripButtonAddHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddHost.Image = global::PuttyManagerGui.Properties.Resources.server__plus;
            this.toolStripButtonAddHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddHost.Name = "toolStripButtonAddHost";
            this.toolStripButtonAddHost.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddHost.Text = "New host...";
            this.toolStripButtonAddHost.Click += new System.EventHandler(this.toolStripButtonAddHost_Click);
            // 
            // toolStripButtonRemoveHost
            // 
            this.toolStripButtonRemoveHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveHost.Image = global::PuttyManagerGui.Properties.Resources.server__minus;
            this.toolStripButtonRemoveHost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveHost.Name = "toolStripButtonRemoveHost";
            this.toolStripButtonRemoveHost.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRemoveHost.Text = "Remove Host";
            this.toolStripButtonRemoveHost.Click += new System.EventHandler(this.toolStripButtonRemoveHost_Click);
            // 
            // toolStripButtonEditHost
            // 
            this.toolStripButtonEditHost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditHost.Image = global::PuttyManagerGui.Properties.Resources.server__pencil;
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
            this.toolStripButtonStart.Image = global::PuttyManagerGui.Properties.Resources.control;
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStart.Text = "Start";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = global::PuttyManagerGui.Properties.Resources.control_stop_square;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
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
            this.splitContainerH1.SplitterWidth = 6;
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
            treeNode2.Text = "Unknown";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "filterStartedHostsNode";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Tag = "3";
            treeNode3.Text = "Started";
            treeNode4.Name = "filterAllHostsNode";
            treeNode4.Tag = "-1";
            treeNode4.Text = "All hosts";
            this.treeViewFilter.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
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
            this.splitContainerV1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerV1.Size = new System.Drawing.Size(630, 398);
            this.splitContainerV1.SplitterDistance = 213;
            this.splitContainerV1.SplitterWidth = 6;
            this.splitContainerV1.TabIndex = 1;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(630, 179);
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
            this.labelDependsOn.Location = new System.Drawing.Point(302, 3);
            this.labelDependsOn.Margin = new System.Windows.Forms.Padding(3);
            this.labelDependsOn.Name = "labelDependsOn";
            this.labelDependsOn.Size = new System.Drawing.Size(33, 13);
            this.labelDependsOn.TabIndex = 2;
            this.labelDependsOn.Text = "value";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(302, 22);
            this.labelHost.Margin = new System.Windows.Forms.Padding(3);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(33, 13);
            this.labelHost.TabIndex = 2;
            this.labelHost.Text = "value";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(490, 3);
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
            this.tunnelsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tunnelsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tunnelsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tgvNameColumn,
            this.tgvTypeColumn,
            this.tgvSrcPortColumn,
            this.tgvDstHostColumn,
            this.tgvDstPortColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.tunnelsGridView, 6);
            this.tunnelsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tunnelsGridView.Location = new System.Drawing.Point(0, 41);
            this.tunnelsGridView.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tunnelsGridView.MultiSelect = false;
            this.tunnelsGridView.Name = "tunnelsGridView";
            this.tunnelsGridView.ReadOnly = true;
            this.tunnelsGridView.RowHeadersVisible = false;
            this.tunnelsGridView.RowTemplate.Height = 18;
            this.tunnelsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tunnelsGridView.Size = new System.Drawing.Size(630, 138);
            this.tunnelsGridView.TabIndex = 7;
            // 
            // tgvNameColumn
            // 
            this.tgvNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tgvNameColumn.HeaderText = "Alias";
            this.tgvNameColumn.Name = "tgvNameColumn";
            this.tgvNameColumn.ReadOnly = true;
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
            this.toolStripMenuItemEditHost.Image = global::PuttyManagerGui.Properties.Resources.server__pencil;
            this.toolStripMenuItemEditHost.Name = "toolStripMenuItemEditHost";
            this.toolStripMenuItemEditHost.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemEditHost.Text = "&Edit...";
            this.toolStripMenuItemEditHost.Click += new System.EventHandler(this.toolStripMenuItemEditHost_Click);
            // 
            // toolStripMenuItemRemoveHost
            // 
            this.toolStripMenuItemRemoveHost.Image = global::PuttyManagerGui.Properties.Resources.server__minus;
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
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(620, 440);
            this.Name = "MainForm";
            this.Text = "SSH Tunnel Manager";
            ((System.ComponentModel.ISupportInitialize)(this.hostsGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainerH1.Panel1.ResumeLayout(false);
            this.splitContainerH1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerH1)).EndInit();
            this.splitContainerH1.ResumeLayout(false);
            this.splitContainerV1.Panel1.ResumeLayout(false);
            this.splitContainerV1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerV1)).EndInit();
            this.splitContainerV1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tunnelsGridView)).EndInit();
            this.contextMenuStripHost.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView hostsGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newHostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killConnectionsExitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvSrcPortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvDstHostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvDstPortColumn;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
    }
}