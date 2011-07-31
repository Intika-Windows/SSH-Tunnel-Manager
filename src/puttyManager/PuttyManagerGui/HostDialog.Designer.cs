namespace PuttyManagerGui
{
    partial class HostDialog
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostDialog));
            this.tunnelsGridView = new System.Windows.Forms.DataGridView();
            this.tgvNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvSrcPortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvDstHostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgvDstPortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDestHost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButtonDynamic = new System.Windows.Forms.RadioButton();
            this.buttonRemoveTunnel = new System.Windows.Forms.Button();
            this.radioButtonRemote = new System.Windows.Forms.RadioButton();
            this.buttonAddTunnel = new System.Windows.Forms.Button();
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.textBoxTunnelName = new System.Windows.Forms.TextBox();
            this.textBoxDestPort = new System.Windows.Forms.TextBox();
            this.textBoxSourcePort = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxDependsOn = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelAddHost = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAddHost = new System.Windows.Forms.Button();
            this.flowLayoutPanelEditHost = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.theErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.theGoodProvider = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tunnelsGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelAddHost.SuspendLayout();
            this.flowLayoutPanelEditHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 6);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 13);
            label1.TabIndex = 0;
            label1.Text = "Alias:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(0, 32);
            label2.Margin = new System.Windows.Forms.Padding(0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 13);
            label2.TabIndex = 2;
            label2.Text = "Host:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(0, 58);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 13);
            label3.TabIndex = 3;
            label3.Text = "Username:";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(0, 84);
            label5.Margin = new System.Windows.Forms.Padding(0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 13);
            label5.TabIndex = 5;
            label5.Text = "Password:";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(0, 111);
            label7.Margin = new System.Windows.Forms.Padding(0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(93, 13);
            label7.TabIndex = 7;
            label7.Text = "Requires a tunnel:";
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(12, 112);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(84, 13);
            label8.TabIndex = 2;
            label8.Text = "Add new tunnel:";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(12, 158);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(44, 13);
            label9.TabIndex = 5;
            label9.Text = "Source:";
            // 
            // label10
            // 
            label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(12, 184);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(63, 13);
            label10.TabIndex = 9;
            label10.Text = "Destination:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
            groupBox1.Controls.Add(this.tunnelsGridView);
            groupBox1.Controls.Add(this.textBoxDestHost);
            groupBox1.Controls.Add(this.label13);
            groupBox1.Controls.Add(this.label12);
            groupBox1.Controls.Add(this.radioButtonDynamic);
            groupBox1.Controls.Add(this.buttonRemoveTunnel);
            groupBox1.Controls.Add(this.radioButtonRemote);
            groupBox1.Controls.Add(this.buttonAddTunnel);
            groupBox1.Controls.Add(this.radioButtonLocal);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(this.textBoxTunnelName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(this.textBoxDestPort);
            groupBox1.Controls.Add(this.textBoxSourcePort);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new System.Drawing.Point(3, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(318, 231);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tunnels:";
            // 
            // tunnelsGridView
            // 
            this.tunnelsGridView.AllowUserToAddRows = false;
            this.tunnelsGridView.AllowUserToDeleteRows = false;
            this.tunnelsGridView.AllowUserToResizeRows = false;
            this.tunnelsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tunnelsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tunnelsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tunnelsGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tunnelsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tunnelsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tunnelsGridView.ColumnHeadersVisible = false;
            this.tunnelsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tgvNameColumn,
            this.tgvTypeColumn,
            this.tgvSrcPortColumn,
            this.tgvDstHostColumn,
            this.tgvDstPortColumn});
            this.tunnelsGridView.Location = new System.Drawing.Point(8, 40);
            this.tunnelsGridView.MultiSelect = false;
            this.tunnelsGridView.Name = "tunnelsGridView";
            this.tunnelsGridView.ReadOnly = true;
            this.tunnelsGridView.RowHeadersVisible = false;
            this.tunnelsGridView.RowTemplate.Height = 18;
            this.tunnelsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tunnelsGridView.Size = new System.Drawing.Size(304, 69);
            this.tunnelsGridView.TabIndex = 6;
            this.tunnelsGridView.SelectionChanged += new System.EventHandler(this.tunnelsGridView_SelectionChanged);
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
            this.tgvTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tgvTypeColumn.HeaderText = "Type";
            this.tgvTypeColumn.Name = "tgvTypeColumn";
            this.tgvTypeColumn.ReadOnly = true;
            this.tgvTypeColumn.Width = 5;
            // 
            // tgvSrcPortColumn
            // 
            this.tgvSrcPortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tgvSrcPortColumn.HeaderText = "Src Port";
            this.tgvSrcPortColumn.Name = "tgvSrcPortColumn";
            this.tgvSrcPortColumn.ReadOnly = true;
            this.tgvSrcPortColumn.Width = 5;
            // 
            // tgvDstHostColumn
            // 
            this.tgvDstHostColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tgvDstHostColumn.HeaderText = "Dst Host";
            this.tgvDstHostColumn.Name = "tgvDstHostColumn";
            this.tgvDstHostColumn.ReadOnly = true;
            this.tgvDstHostColumn.Width = 5;
            // 
            // tgvDstPortColumn
            // 
            this.tgvDstPortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.tgvDstPortColumn.HeaderText = "Dst Port";
            this.tgvDstPortColumn.Name = "tgvDstPortColumn";
            this.tgvDstPortColumn.ReadOnly = true;
            this.tgvDstPortColumn.Width = 5;
            // 
            // textBoxDestHost
            // 
            this.textBoxDestHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.theGoodProvider.SetIconAlignment(this.textBoxDestHost, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.theErrorProvider.SetIconAlignment(this.textBoxDestHost, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.theGoodProvider.SetIconPadding(this.textBoxDestHost, -20);
            this.theErrorProvider.SetIconPadding(this.textBoxDestHost, -20);
            this.textBoxDestHost.Location = new System.Drawing.Point(93, 181);
            this.textBoxDestHost.MaxLength = 255;
            this.textBoxDestHost.Name = "textBoxDestHost";
            this.textBoxDestHost.Size = new System.Drawing.Size(147, 20);
            this.textBoxDestHost.TabIndex = 10;
            this.textBoxDestHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(243, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = ":";
            // 
            // radioButtonDynamic
            // 
            this.radioButtonDynamic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonDynamic.AutoSize = true;
            this.radioButtonDynamic.Location = new System.Drawing.Point(161, 207);
            this.radioButtonDynamic.Name = "radioButtonDynamic";
            this.radioButtonDynamic.Size = new System.Drawing.Size(66, 17);
            this.radioButtonDynamic.TabIndex = 15;
            this.radioButtonDynamic.Text = "Dynamic";
            this.radioButtonDynamic.UseVisualStyleBackColor = true;
            this.radioButtonDynamic.CheckedChanged += new System.EventHandler(this.radioButtonDynamic_CheckedChanged);
            // 
            // buttonRemoveTunnel
            // 
            this.buttonRemoveTunnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveTunnel.Location = new System.Drawing.Point(237, 15);
            this.buttonRemoveTunnel.Name = "buttonRemoveTunnel";
            this.buttonRemoveTunnel.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveTunnel.TabIndex = 0;
            this.buttonRemoveTunnel.Text = "Remove";
            this.buttonRemoveTunnel.UseVisualStyleBackColor = true;
            this.buttonRemoveTunnel.Click += new System.EventHandler(this.buttonRemoveTunnel_Click);
            // 
            // radioButtonRemote
            // 
            this.radioButtonRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonRemote.AutoSize = true;
            this.radioButtonRemote.Location = new System.Drawing.Point(85, 207);
            this.radioButtonRemote.Name = "radioButtonRemote";
            this.radioButtonRemote.Size = new System.Drawing.Size(62, 17);
            this.radioButtonRemote.TabIndex = 14;
            this.radioButtonRemote.Text = "Remote";
            this.radioButtonRemote.UseVisualStyleBackColor = true;
            // 
            // buttonAddTunnel
            // 
            this.buttonAddTunnel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTunnel.Location = new System.Drawing.Point(238, 204);
            this.buttonAddTunnel.Name = "buttonAddTunnel";
            this.buttonAddTunnel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTunnel.TabIndex = 16;
            this.buttonAddTunnel.Text = "Add";
            this.buttonAddTunnel.UseVisualStyleBackColor = true;
            this.buttonAddTunnel.Click += new System.EventHandler(this.buttonAddTunnel_Click);
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Checked = true;
            this.radioButtonLocal.Location = new System.Drawing.Point(20, 207);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(51, 17);
            this.radioButtonLocal.TabIndex = 13;
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.Text = "Local";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            // 
            // textBoxTunnelName
            // 
            this.textBoxTunnelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.theGoodProvider.SetIconPadding(this.textBoxTunnelName, -20);
            this.theErrorProvider.SetIconPadding(this.textBoxTunnelName, -20);
            this.textBoxTunnelName.Location = new System.Drawing.Point(93, 130);
            this.textBoxTunnelName.MaxLength = 255;
            this.textBoxTunnelName.Name = "textBoxTunnelName";
            this.textBoxTunnelName.Size = new System.Drawing.Size(219, 20);
            this.textBoxTunnelName.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 133);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(32, 13);
            label6.TabIndex = 3;
            label6.Text = "Alias:";
            // 
            // textBoxDestPort
            // 
            this.textBoxDestPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.theGoodProvider.SetIconPadding(this.textBoxDestPort, -20);
            this.theErrorProvider.SetIconPadding(this.textBoxDestPort, -20);
            this.textBoxDestPort.Location = new System.Drawing.Point(256, 181);
            this.textBoxDestPort.MaxLength = 5;
            this.textBoxDestPort.Name = "textBoxDestPort";
            this.textBoxDestPort.Size = new System.Drawing.Size(57, 20);
            this.textBoxDestPort.TabIndex = 12;
            // 
            // textBoxSourcePort
            // 
            this.textBoxSourcePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.theGoodProvider.SetIconPadding(this.textBoxSourcePort, -20);
            this.theErrorProvider.SetIconPadding(this.textBoxSourcePort, -20);
            this.textBoxSourcePort.Location = new System.Drawing.Point(255, 155);
            this.textBoxSourcePort.MaxLength = 5;
            this.textBoxSourcePort.Name = "textBoxSourcePort";
            this.textBoxSourcePort.Size = new System.Drawing.Size(57, 20);
            this.textBoxSourcePort.TabIndex = 8;
            // 
            // label11
            // 
            label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label11.Location = new System.Drawing.Point(173, 158);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(70, 14);
            label11.TabIndex = 6;
            label11.Text = "localhost";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.theErrorProvider.SetIconPadding(this.textBoxName, -20);
            this.theGoodProvider.SetIconPadding(this.textBoxName, -20);
            this.textBoxName.Location = new System.Drawing.Point(96, 3);
            this.textBoxName.MaxLength = 255;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(225, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.theGoodProvider.SetIconPadding(this.textBoxHostname, -20);
            this.theErrorProvider.SetIconPadding(this.textBoxHostname, -20);
            this.textBoxHostname.Location = new System.Drawing.Point(3, 3);
            this.textBoxHostname.MaxLength = 255;
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(152, 20);
            this.textBoxHostname.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = ":";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theErrorProvider.SetIconPadding(this.textBoxLogin, -20);
            this.theGoodProvider.SetIconPadding(this.textBoxLogin, -20);
            this.textBoxLogin.Location = new System.Drawing.Point(96, 55);
            this.textBoxLogin.MaxLength = 255;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(225, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theErrorProvider.SetIconPadding(this.textBoxPassword, -20);
            this.theGoodProvider.SetIconPadding(this.textBoxPassword, -20);
            this.textBoxPassword.Location = new System.Drawing.Point(96, 81);
            this.textBoxPassword.MaxLength = 255;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(225, 20);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLogin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDependsOn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(groupBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(label7, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxDependsOn
            // 
            this.comboBoxDependsOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDependsOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDependsOn.FormattingEnabled = true;
            this.theErrorProvider.SetIconAlignment(this.comboBoxDependsOn, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.comboBoxDependsOn.Location = new System.Drawing.Point(96, 107);
            this.comboBoxDependsOn.Name = "comboBoxDependsOn";
            this.comboBoxDependsOn.Size = new System.Drawing.Size(225, 21);
            this.comboBoxDependsOn.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBoxHostname);
            this.panel1.Controls.Add(this.textBoxPort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(93, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 26);
            this.panel1.TabIndex = 2;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.theGoodProvider.SetIconPadding(this.textBoxPort, -20);
            this.theErrorProvider.SetIconPadding(this.textBoxPort, -20);
            this.textBoxPort.Location = new System.Drawing.Point(171, 3);
            this.textBoxPort.MaxLength = 5;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(57, 20);
            this.textBoxPort.TabIndex = 2;
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoSize = true;
            this.flowLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelMain.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelAddHost);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelEditHost);
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelMain.Margin = new System.Windows.Forms.Padding(12);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(324, 420);
            this.flowLayoutPanelMain.TabIndex = 5;
            // 
            // flowLayoutPanelAddHost
            // 
            this.flowLayoutPanelAddHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelAddHost.AutoSize = true;
            this.flowLayoutPanelAddHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelAddHost.Controls.Add(this.buttonClose);
            this.flowLayoutPanelAddHost.Controls.Add(this.buttonAddHost);
            this.flowLayoutPanelAddHost.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelAddHost.Location = new System.Drawing.Point(0, 368);
            this.flowLayoutPanelAddHost.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelAddHost.Name = "flowLayoutPanelAddHost";
            this.flowLayoutPanelAddHost.Size = new System.Drawing.Size(324, 26);
            this.flowLayoutPanelAddHost.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(249, 3);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Cancel";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAddHost
            // 
            this.buttonAddHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddHost.Location = new System.Drawing.Point(168, 3);
            this.buttonAddHost.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.buttonAddHost.Name = "buttonAddHost";
            this.buttonAddHost.Size = new System.Drawing.Size(75, 23);
            this.buttonAddHost.TabIndex = 0;
            this.buttonAddHost.Text = "Add Host";
            this.buttonAddHost.UseVisualStyleBackColor = true;
            this.buttonAddHost.Click += new System.EventHandler(this.buttonAddHost_Click);
            // 
            // flowLayoutPanelEditHost
            // 
            this.flowLayoutPanelEditHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelEditHost.AutoSize = true;
            this.flowLayoutPanelEditHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelEditHost.Controls.Add(this.buttonApply);
            this.flowLayoutPanelEditHost.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelEditHost.Controls.Add(this.buttonOk);
            this.flowLayoutPanelEditHost.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelEditHost.Location = new System.Drawing.Point(0, 394);
            this.flowLayoutPanelEditHost.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelEditHost.Name = "flowLayoutPanelEditHost";
            this.flowLayoutPanelEditHost.Size = new System.Drawing.Size(324, 26);
            this.flowLayoutPanelEditHost.TabIndex = 6;
            this.flowLayoutPanelEditHost.Visible = false;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(249, 3);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(168, 3);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(87, 3);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // theErrorProvider
            // 
            this.theErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.theErrorProvider.ContainerControl = this;
            this.theErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("theErrorProvider.Icon")));
            // 
            // theGoodProvider
            // 
            this.theGoodProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.theGoodProvider.ContainerControl = this;
            this.theGoodProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("theGoodProvider.Icon")));
            // 
            // HostDialog
            // 
            this.AcceptButton = this.buttonAddHost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(458, 617);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Host - SSH Tunnel Manager";
            this.Load += new System.EventHandler(this.HostDialog_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tunnelsGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelMain.PerformLayout();
            this.flowLayoutPanelAddHost.ResumeLayout(false);
            this.flowLayoutPanelEditHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxDependsOn;
        private System.Windows.Forms.Button buttonRemoveTunnel;
        private System.Windows.Forms.TextBox textBoxSourcePort;
        private System.Windows.Forms.Button buttonAddTunnel;
        private System.Windows.Forms.RadioButton radioButtonDynamic;
        private System.Windows.Forms.RadioButton radioButtonRemote;
        private System.Windows.Forms.RadioButton radioButtonLocal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAddHost;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddHost;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.ErrorProvider theErrorProvider;
        private System.Windows.Forms.ErrorProvider theGoodProvider;
        private System.Windows.Forms.TextBox textBoxDestHost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTunnelName;
        private System.Windows.Forms.TextBox textBoxDestPort;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEditHost;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DataGridView tunnelsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvSrcPortColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvDstHostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgvDstPortColumn;
    }
}