using SSHTunnelManagerGUI.Controls;
using SSHTunnelManagerGUI.Ext.CheckGroupBox;

namespace SSHTunnelManagerGUI.Forms
{
    partial class OptionsDialog
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialog));
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxTraceDebug = new System.Windows.Forms.CheckBox();
            this.checkGroupBoxAutoRestart = new SSHTunnelManagerGUI.Ext.CheckGroupBox.CheckGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAfterThat = new System.Windows.Forms.GroupBox();
            this.radioButtonMakeDelay = new System.Windows.Forms.RadioButton();
            this.numericUpDownRestartDelay = new System.Windows.Forms.NumericUpDown();
            this.radioButtonStopTrying = new System.Windows.Forms.RadioButton();
            this.numericUpDownMaxAttemptsCount = new System.Windows.Forms.NumericUpDown();
            this.buttonApply = new System.Windows.Forms.Button();
            this.lineSeparator1 = new SSHTunnelManagerGUI.Controls.LineSeparator();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxPF = new System.Windows.Forms.GroupBox();
            this.checkBoxRemotePortAcceptAll = new System.Windows.Forms.CheckBox();
            this.checkBoxLocalPortAcceptAll = new System.Windows.Forms.CheckBox();
            this.checkGroupBoxProxy = new SSHTunnelManagerGUI.Ext.CheckGroupBox.CheckGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxProxyType = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxAuthReq = new System.Windows.Forms.CheckBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.checkBoxProxyLocalhost = new System.Windows.Forms.CheckBox();
            this.textBoxProxyExcludes = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.theGoodProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.theErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.theTabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPageProxy = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            this.checkGroupBoxAutoRestart.SuspendLayout();
            this.groupBoxAfterThat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAttemptsCount)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxPF.SuspendLayout();
            this.checkGroupBoxProxy.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).BeginInit();
            this.theTabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageProxy.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(0, 110);
            label5.Margin = new System.Windows.Forms.Padding(0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 13);
            label5.TabIndex = 13;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(0, 84);
            label6.Margin = new System.Windows.Forms.Padding(0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 13);
            label6.TabIndex = 11;
            label6.Text = "Username:";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(0, 34);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 13);
            label3.TabIndex = 10;
            label3.Text = "Host:";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(this.textBoxHostname);
            panel1.Controls.Add(this.textBoxPort);
            panel1.Controls.Add(this.label4);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(98, 27);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(183, 28);
            panel1.TabIndex = 15;
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.theGoodProvider.SetIconPadding(this.textBoxHostname, -20);
            this.theErrorProvider.SetIconPadding(this.textBoxHostname, -20);
            this.textBoxHostname.Location = new System.Drawing.Point(3, 5);
            this.textBoxHostname.MaxLength = 255;
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(109, 20);
            this.textBoxHostname.TabIndex = 7;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.theGoodProvider.SetIconPadding(this.textBoxPort, -20);
            this.theErrorProvider.SetIconPadding(this.textBoxPort, -20);
            this.textBoxPort.Location = new System.Drawing.Point(123, 5);
            this.textBoxPort.MaxLength = 5;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(57, 20);
            this.textBoxPort.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = ":";
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(0, 159);
            label7.Margin = new System.Windows.Forms.Padding(0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(98, 13);
            label7.TabIndex = 13;
            label7.Text = "Exclude Hosts/IPs:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 27);
            label1.TabIndex = 1;
            label1.Text = "Proxy server:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxTraceDebug
            // 
            this.checkBoxTraceDebug.AutoSize = true;
            this.checkBoxTraceDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxTraceDebug.Location = new System.Drawing.Point(3, 211);
            this.checkBoxTraceDebug.Name = "checkBoxTraceDebug";
            this.checkBoxTraceDebug.Size = new System.Drawing.Size(287, 17);
            this.checkBoxTraceDebug.TabIndex = 0;
            this.checkBoxTraceDebug.Text = "Trace debug messages in hosts log";
            this.checkBoxTraceDebug.UseVisualStyleBackColor = true;
            // 
            // checkGroupBoxAutoRestart
            // 
            this.checkGroupBoxAutoRestart.Controls.Add(this.label2);
            this.checkGroupBoxAutoRestart.Controls.Add(this.groupBoxAfterThat);
            this.checkGroupBoxAutoRestart.Controls.Add(this.numericUpDownMaxAttemptsCount);
            this.checkGroupBoxAutoRestart.Location = new System.Drawing.Point(3, 78);
            this.checkGroupBoxAutoRestart.Name = "checkGroupBoxAutoRestart";
            this.checkGroupBoxAutoRestart.Size = new System.Drawing.Size(287, 127);
            this.checkGroupBoxAutoRestart.TabIndex = 1;
            this.checkGroupBoxAutoRestart.TabStop = false;
            this.checkGroupBoxAutoRestart.Text = "Restart link on fail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum attempts count:";
            // 
            // groupBoxAfterThat
            // 
            this.groupBoxAfterThat.Controls.Add(this.radioButtonMakeDelay);
            this.groupBoxAfterThat.Controls.Add(this.numericUpDownRestartDelay);
            this.groupBoxAfterThat.Controls.Add(this.radioButtonStopTrying);
            this.groupBoxAfterThat.Location = new System.Drawing.Point(6, 45);
            this.groupBoxAfterThat.Name = "groupBoxAfterThat";
            this.groupBoxAfterThat.Size = new System.Drawing.Size(275, 74);
            this.groupBoxAfterThat.TabIndex = 4;
            this.groupBoxAfterThat.TabStop = false;
            this.groupBoxAfterThat.Text = "After that:";
            // 
            // radioButtonMakeDelay
            // 
            this.radioButtonMakeDelay.AutoSize = true;
            this.radioButtonMakeDelay.Location = new System.Drawing.Point(7, 42);
            this.radioButtonMakeDelay.Name = "radioButtonMakeDelay";
            this.radioButtonMakeDelay.Size = new System.Drawing.Size(198, 17);
            this.radioButtonMakeDelay.TabIndex = 0;
            this.radioButtonMakeDelay.Text = "Delay before next attempt (seconds):";
            this.radioButtonMakeDelay.UseVisualStyleBackColor = true;
            this.radioButtonMakeDelay.CheckedChanged += new System.EventHandler(this.radioButtonMakeDelay_CheckedChanged);
            // 
            // numericUpDownRestartDelay
            // 
            this.numericUpDownRestartDelay.Location = new System.Drawing.Point(211, 42);
            this.numericUpDownRestartDelay.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownRestartDelay.Name = "numericUpDownRestartDelay";
            this.numericUpDownRestartDelay.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRestartDelay.TabIndex = 3;
            this.numericUpDownRestartDelay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // radioButtonStopTrying
            // 
            this.radioButtonStopTrying.AutoSize = true;
            this.radioButtonStopTrying.Checked = true;
            this.radioButtonStopTrying.Location = new System.Drawing.Point(7, 19);
            this.radioButtonStopTrying.Name = "radioButtonStopTrying";
            this.radioButtonStopTrying.Size = new System.Drawing.Size(75, 17);
            this.radioButtonStopTrying.TabIndex = 0;
            this.radioButtonStopTrying.TabStop = true;
            this.radioButtonStopTrying.Text = "Stop trying";
            this.radioButtonStopTrying.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaxAttemptsCount
            // 
            this.numericUpDownMaxAttemptsCount.Location = new System.Drawing.Point(139, 19);
            this.numericUpDownMaxAttemptsCount.Name = "numericUpDownMaxAttemptsCount";
            this.numericUpDownMaxAttemptsCount.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownMaxAttemptsCount.TabIndex = 3;
            this.numericUpDownMaxAttemptsCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Location = new System.Drawing.Point(229, 3);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // lineSeparator1
            // 
            this.lineSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineSeparator1.Location = new System.Drawing.Point(3, 272);
            this.lineSeparator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator1.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator1.Name = "lineSeparator1";
            this.lineSeparator1.Size = new System.Drawing.Size(307, 2);
            this.lineSeparator1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxPF);
            this.flowLayoutPanel1.Controls.Add(this.checkGroupBoxAutoRestart);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTraceDebug);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 231);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // groupBoxPF
            // 
            this.groupBoxPF.Controls.Add(this.checkBoxRemotePortAcceptAll);
            this.groupBoxPF.Controls.Add(this.checkBoxLocalPortAcceptAll);
            this.groupBoxPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPF.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPF.Name = "groupBoxPF";
            this.groupBoxPF.Size = new System.Drawing.Size(287, 69);
            this.groupBoxPF.TabIndex = 4;
            this.groupBoxPF.TabStop = false;
            this.groupBoxPF.Text = "Port forwarding";
            // 
            // checkBoxRemotePortAcceptAll
            // 
            this.checkBoxRemotePortAcceptAll.AutoSize = true;
            this.checkBoxRemotePortAcceptAll.Location = new System.Drawing.Point(9, 43);
            this.checkBoxRemotePortAcceptAll.Name = "checkBoxRemotePortAcceptAll";
            this.checkBoxRemotePortAcceptAll.Size = new System.Drawing.Size(212, 17);
            this.checkBoxRemotePortAcceptAll.TabIndex = 0;
            this.checkBoxRemotePortAcceptAll.Text = "Remote ports do the same (SSH-2 only)";
            this.checkBoxRemotePortAcceptAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxLocalPortAcceptAll
            // 
            this.checkBoxLocalPortAcceptAll.AutoSize = true;
            this.checkBoxLocalPortAcceptAll.Location = new System.Drawing.Point(9, 20);
            this.checkBoxLocalPortAcceptAll.Name = "checkBoxLocalPortAcceptAll";
            this.checkBoxLocalPortAcceptAll.Size = new System.Drawing.Size(253, 17);
            this.checkBoxLocalPortAcceptAll.TabIndex = 0;
            this.checkBoxLocalPortAcceptAll.Text = "Local ports accept connections from other hosts";
            this.checkBoxLocalPortAcceptAll.UseVisualStyleBackColor = true;
            // 
            // checkGroupBoxProxy
            // 
            this.checkGroupBoxProxy.Controls.Add(this.tableLayoutPanel1);
            this.checkGroupBoxProxy.Location = new System.Drawing.Point(6, 6);
            this.checkGroupBoxProxy.Name = "checkGroupBoxProxy";
            this.checkGroupBoxProxy.Size = new System.Drawing.Size(287, 197);
            this.checkGroupBoxProxy.TabIndex = 5;
            this.checkGroupBoxProxy.TabStop = false;
            this.checkGroupBoxProxy.Text = "Proxy";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxProxyType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPassword, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxAuthReq, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUsername, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxProxyLocalhost, 0, 5);
            this.tableLayoutPanel1.Controls.Add(label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProxyExcludes, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 178);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBoxProxyType
            // 
            this.comboBoxProxyType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProxyType.FormattingEnabled = true;
            this.comboBoxProxyType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS 4",
            "SOCKS 5"});
            this.comboBoxProxyType.Location = new System.Drawing.Point(186, 3);
            this.comboBoxProxyType.Name = "comboBoxProxyType";
            this.comboBoxProxyType.Size = new System.Drawing.Size(92, 21);
            this.comboBoxProxyType.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theErrorProvider.SetIconPadding(this.textBoxPassword, -20);
            this.theGoodProvider.SetIconPadding(this.textBoxPassword, -20);
            this.textBoxPassword.Location = new System.Drawing.Point(101, 107);
            this.textBoxPassword.MaxLength = 255;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(177, 20);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxAuthReq
            // 
            this.checkBoxAuthReq.AutoSize = true;
            this.checkBoxAuthReq.Checked = true;
            this.checkBoxAuthReq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxAuthReq, 2);
            this.checkBoxAuthReq.Location = new System.Drawing.Point(3, 58);
            this.checkBoxAuthReq.Name = "checkBoxAuthReq";
            this.checkBoxAuthReq.Size = new System.Drawing.Size(138, 17);
            this.checkBoxAuthReq.TabIndex = 16;
            this.checkBoxAuthReq.Text = "Requires authentication";
            this.checkBoxAuthReq.UseVisualStyleBackColor = true;
            this.checkBoxAuthReq.CheckedChanged += new System.EventHandler(this.checkBoxAuthReq_CheckedChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theErrorProvider.SetIconPadding(this.textBoxUsername, -20);
            this.theGoodProvider.SetIconPadding(this.textBoxUsername, -20);
            this.textBoxUsername.Location = new System.Drawing.Point(101, 81);
            this.textBoxUsername.MaxLength = 255;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(177, 20);
            this.textBoxUsername.TabIndex = 12;
            // 
            // checkBoxProxyLocalhost
            // 
            this.checkBoxProxyLocalhost.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxProxyLocalhost, 2);
            this.checkBoxProxyLocalhost.Location = new System.Drawing.Point(3, 133);
            this.checkBoxProxyLocalhost.Name = "checkBoxProxyLocalhost";
            this.checkBoxProxyLocalhost.Size = new System.Drawing.Size(218, 17);
            this.checkBoxProxyLocalhost.TabIndex = 16;
            this.checkBoxProxyLocalhost.Text = "Consider proxying local host connections";
            this.checkBoxProxyLocalhost.UseVisualStyleBackColor = true;
            // 
            // textBoxProxyExcludes
            // 
            this.textBoxProxyExcludes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theErrorProvider.SetIconPadding(this.textBoxProxyExcludes, -20);
            this.theGoodProvider.SetIconPadding(this.textBoxProxyExcludes, -20);
            this.textBoxProxyExcludes.Location = new System.Drawing.Point(101, 156);
            this.textBoxProxyExcludes.MaxLength = 255;
            this.textBoxProxyExcludes.Name = "textBoxProxyExcludes";
            this.textBoxProxyExcludes.PasswordChar = '*';
            this.textBoxProxyExcludes.Size = new System.Drawing.Size(177, 20);
            this.textBoxProxyExcludes.TabIndex = 14;
            this.textBoxProxyExcludes.UseSystemPasswordChar = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.buttonApply);
            this.flowLayoutPanel2.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel2.Controls.Add(this.buttonOK);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 280);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(307, 27);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(148, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(67, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // theGoodProvider
            // 
            this.theGoodProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.theGoodProvider.ContainerControl = this;
            this.theGoodProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("theGoodProvider.Icon")));
            // 
            // theErrorProvider
            // 
            this.theErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.theErrorProvider.ContainerControl = this;
            this.theErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("theErrorProvider.Icon")));
            // 
            // theTabControl
            // 
            this.theTabControl.Controls.Add(this.tabPageGeneral);
            this.theTabControl.Controls.Add(this.tabPageProxy);
            this.theTabControl.Location = new System.Drawing.Point(3, 3);
            this.theTabControl.Name = "theTabControl";
            this.theTabControl.SelectedIndex = 0;
            this.theTabControl.Size = new System.Drawing.Size(307, 263);
            this.theTabControl.TabIndex = 5;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.BackColor = System.Drawing.Color.White;
            this.tabPageGeneral.Controls.Add(this.flowLayoutPanel1);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(299, 237);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            // 
            // tabPageProxy
            // 
            this.tabPageProxy.BackColor = System.Drawing.Color.White;
            this.tabPageProxy.Controls.Add(this.checkGroupBoxProxy);
            this.tabPageProxy.Location = new System.Drawing.Point(4, 22);
            this.tabPageProxy.Name = "tabPageProxy";
            this.tabPageProxy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProxy.Size = new System.Drawing.Size(299, 237);
            this.tabPageProxy.TabIndex = 1;
            this.tabPageProxy.Text = "Proxy";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.theTabControl);
            this.flowLayoutPanel3.Controls.Add(this.lineSeparator1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(313, 310);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(378, 384);
            this.Controls.Add(this.flowLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.checkGroupBoxAutoRestart.ResumeLayout(false);
            this.checkGroupBoxAutoRestart.PerformLayout();
            this.groupBoxAfterThat.ResumeLayout(false);
            this.groupBoxAfterThat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAttemptsCount)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBoxPF.ResumeLayout(false);
            this.groupBoxPF.PerformLayout();
            this.checkGroupBoxProxy.ResumeLayout(false);
            this.checkGroupBoxProxy.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).EndInit();
            this.theTabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageProxy.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownMaxAttemptsCount;
        private System.Windows.Forms.NumericUpDown numericUpDownRestartDelay;
        private System.Windows.Forms.CheckBox checkBoxTraceDebug;
        private CheckGroupBox checkGroupBoxAutoRestart;
        private System.Windows.Forms.Button buttonApply;
        private LineSeparator lineSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxPF;
        private System.Windows.Forms.CheckBox checkBoxRemotePortAcceptAll;
        private System.Windows.Forms.CheckBox checkBoxLocalPortAcceptAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxAfterThat;
        private System.Windows.Forms.RadioButton radioButtonMakeDelay;
        private System.Windows.Forms.RadioButton radioButtonStopTrying;
        private CheckGroupBox checkGroupBoxProxy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProxyType;
        private System.Windows.Forms.CheckBox checkBoxAuthReq;
        private System.Windows.Forms.CheckBox checkBoxProxyLocalhost;
        private System.Windows.Forms.TextBox textBoxProxyExcludes;
        private System.Windows.Forms.ErrorProvider theGoodProvider;
        private System.Windows.Forms.ErrorProvider theErrorProvider;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TabControl theTabControl;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageProxy;
    }
}