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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsDialog));
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label1;
            this.checkBoxTraceDebug = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxPF = new System.Windows.Forms.GroupBox();
            this.checkBoxRemotePortAcceptAll = new System.Windows.Forms.CheckBox();
            this.checkBoxLocalPortAcceptAll = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.theGoodProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.theErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.theTabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tabPageProxy = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.chbxRunAtWindowsStartup = new System.Windows.Forms.CheckBox();
            this.chbxStartHostsBeingActiveLastTime = new System.Windows.Forms.CheckBox();
            this.checkGroupBoxAutoRestart = new SSHTunnelManagerGUI.Ext.CheckGroupBox.CheckGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAfterThat = new System.Windows.Forms.GroupBox();
            this.radioButtonMakeDelay = new System.Windows.Forms.RadioButton();
            this.numericUpDownRestartDelay = new System.Windows.Forms.NumericUpDown();
            this.radioButtonStopTrying = new System.Windows.Forms.RadioButton();
            this.numericUpDownMaxAttemptsCount = new System.Windows.Forms.NumericUpDown();
            this.checkGroupBoxRestartHostsWithWarns = new SSHTunnelManagerGUI.Ext.CheckGroupBox.CheckGroupBox();
            this.numericUpDownRestartHWWInterval = new System.Windows.Forms.NumericUpDown();
            this.checkGroupBoxProxy = new SSHTunnelManagerGUI.Ext.CheckGroupBox.CheckGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxProxyType = new System.Windows.Forms.ComboBox();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxProxyExcludes = new System.Windows.Forms.TextBox();
            this.checkBoxAuthReq = new System.Windows.Forms.CheckBox();
            this.checkBoxProxyLocalhost = new System.Windows.Forms.CheckBox();
            this.lineSeparator1 = new SSHTunnelManagerGUI.Controls.LineSeparator();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxPF.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).BeginInit();
            this.theTabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageProxy.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.checkGroupBoxAutoRestart.SuspendLayout();
            this.groupBoxAfterThat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAttemptsCount)).BeginInit();
            this.checkGroupBoxRestartHostsWithWarns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartHWWInterval)).BeginInit();
            this.checkGroupBoxProxy.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxTraceDebug
            // 
            resources.ApplyResources(this.checkBoxTraceDebug, "checkBoxTraceDebug");
            this.checkBoxTraceDebug.Name = "checkBoxTraceDebug";
            this.checkBoxTraceDebug.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            resources.ApplyResources(this.buttonApply, "buttonApply");
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.groupBoxPF);
            this.flowLayoutPanel1.Controls.Add(this.checkGroupBoxAutoRestart);
            this.flowLayoutPanel1.Controls.Add(this.checkGroupBoxRestartHostsWithWarns);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTraceDebug);
            this.flowLayoutPanel1.Controls.Add(this.chbxRunAtWindowsStartup);
            this.flowLayoutPanel1.Controls.Add(this.chbxStartHostsBeingActiveLastTime);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // groupBoxPF
            // 
            this.groupBoxPF.Controls.Add(this.checkBoxRemotePortAcceptAll);
            this.groupBoxPF.Controls.Add(this.checkBoxLocalPortAcceptAll);
            resources.ApplyResources(this.groupBoxPF, "groupBoxPF");
            this.groupBoxPF.Name = "groupBoxPF";
            this.groupBoxPF.TabStop = false;
            // 
            // checkBoxRemotePortAcceptAll
            // 
            resources.ApplyResources(this.checkBoxRemotePortAcceptAll, "checkBoxRemotePortAcceptAll");
            this.checkBoxRemotePortAcceptAll.Name = "checkBoxRemotePortAcceptAll";
            this.checkBoxRemotePortAcceptAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxLocalPortAcceptAll
            // 
            resources.ApplyResources(this.checkBoxLocalPortAcceptAll, "checkBoxLocalPortAcceptAll");
            this.checkBoxLocalPortAcceptAll.Name = "checkBoxLocalPortAcceptAll";
            this.checkBoxLocalPortAcceptAll.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.buttonApply);
            this.flowLayoutPanel2.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel2.Controls.Add(this.buttonOK);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // theGoodProvider
            // 
            this.theGoodProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.theGoodProvider.ContainerControl = this;
            resources.ApplyResources(this.theGoodProvider, "theGoodProvider");
            // 
            // theErrorProvider
            // 
            this.theErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.theErrorProvider.ContainerControl = this;
            resources.ApplyResources(this.theErrorProvider, "theErrorProvider");
            // 
            // theTabControl
            // 
            this.theTabControl.Controls.Add(this.tabPageGeneral);
            this.theTabControl.Controls.Add(this.tabPageProxy);
            resources.ApplyResources(this.theTabControl, "theTabControl");
            this.theTabControl.Name = "theTabControl";
            this.theTabControl.SelectedIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.BackColor = System.Drawing.Color.White;
            this.tabPageGeneral.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.tabPageGeneral, "tabPageGeneral");
            this.tabPageGeneral.Name = "tabPageGeneral";
            // 
            // tabPageProxy
            // 
            this.tabPageProxy.BackColor = System.Drawing.Color.White;
            this.tabPageProxy.Controls.Add(this.checkGroupBoxProxy);
            resources.ApplyResources(this.tabPageProxy, "tabPageProxy");
            this.tabPageProxy.Name = "tabPageProxy";
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Controls.Add(this.theTabControl);
            this.flowLayoutPanel3.Controls.Add(this.lineSeparator1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // chbxRunAtWindowsStartup
            // 
            resources.ApplyResources(this.chbxRunAtWindowsStartup, "chbxRunAtWindowsStartup");
            this.chbxRunAtWindowsStartup.Name = "chbxRunAtWindowsStartup";
            this.chbxRunAtWindowsStartup.UseVisualStyleBackColor = true;
            // 
            // chbxStartHostsBeingActiveLastTime
            // 
            resources.ApplyResources(this.chbxStartHostsBeingActiveLastTime, "chbxStartHostsBeingActiveLastTime");
            this.chbxStartHostsBeingActiveLastTime.Name = "chbxStartHostsBeingActiveLastTime";
            this.chbxStartHostsBeingActiveLastTime.UseVisualStyleBackColor = true;
            // 
            // checkGroupBoxAutoRestart
            // 
            this.checkGroupBoxAutoRestart.Controls.Add(this.label2);
            this.checkGroupBoxAutoRestart.Controls.Add(this.groupBoxAfterThat);
            this.checkGroupBoxAutoRestart.Controls.Add(this.numericUpDownMaxAttemptsCount);
            resources.ApplyResources(this.checkGroupBoxAutoRestart, "checkGroupBoxAutoRestart");
            this.checkGroupBoxAutoRestart.Name = "checkGroupBoxAutoRestart";
            this.checkGroupBoxAutoRestart.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBoxAfterThat
            // 
            this.groupBoxAfterThat.Controls.Add(this.radioButtonMakeDelay);
            this.groupBoxAfterThat.Controls.Add(this.numericUpDownRestartDelay);
            this.groupBoxAfterThat.Controls.Add(this.radioButtonStopTrying);
            resources.ApplyResources(this.groupBoxAfterThat, "groupBoxAfterThat");
            this.groupBoxAfterThat.Name = "groupBoxAfterThat";
            this.groupBoxAfterThat.TabStop = false;
            // 
            // radioButtonMakeDelay
            // 
            resources.ApplyResources(this.radioButtonMakeDelay, "radioButtonMakeDelay");
            this.radioButtonMakeDelay.Name = "radioButtonMakeDelay";
            this.radioButtonMakeDelay.UseVisualStyleBackColor = true;
            this.radioButtonMakeDelay.CheckedChanged += new System.EventHandler(this.radioButtonMakeDelay_CheckedChanged);
            // 
            // numericUpDownRestartDelay
            // 
            resources.ApplyResources(this.numericUpDownRestartDelay, "numericUpDownRestartDelay");
            this.numericUpDownRestartDelay.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownRestartDelay.Name = "numericUpDownRestartDelay";
            this.numericUpDownRestartDelay.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // radioButtonStopTrying
            // 
            resources.ApplyResources(this.radioButtonStopTrying, "radioButtonStopTrying");
            this.radioButtonStopTrying.Checked = true;
            this.radioButtonStopTrying.Name = "radioButtonStopTrying";
            this.radioButtonStopTrying.TabStop = true;
            this.radioButtonStopTrying.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaxAttemptsCount
            // 
            resources.ApplyResources(this.numericUpDownMaxAttemptsCount, "numericUpDownMaxAttemptsCount");
            this.numericUpDownMaxAttemptsCount.Name = "numericUpDownMaxAttemptsCount";
            this.numericUpDownMaxAttemptsCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // checkGroupBoxRestartHostsWithWarns
            // 
            this.checkGroupBoxRestartHostsWithWarns.Controls.Add(label8);
            this.checkGroupBoxRestartHostsWithWarns.Controls.Add(this.numericUpDownRestartHWWInterval);
            resources.ApplyResources(this.checkGroupBoxRestartHostsWithWarns, "checkGroupBoxRestartHostsWithWarns");
            this.checkGroupBoxRestartHostsWithWarns.Name = "checkGroupBoxRestartHostsWithWarns";
            this.checkGroupBoxRestartHostsWithWarns.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // numericUpDownRestartHWWInterval
            // 
            resources.ApplyResources(this.numericUpDownRestartHWWInterval, "numericUpDownRestartHWWInterval");
            this.numericUpDownRestartHWWInterval.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownRestartHWWInterval.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownRestartHWWInterval.Name = "numericUpDownRestartHWWInterval";
            this.numericUpDownRestartHWWInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // checkGroupBoxProxy
            // 
            this.checkGroupBoxProxy.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.checkGroupBoxProxy, "checkGroupBoxProxy");
            this.checkGroupBoxProxy.Name = "checkGroupBoxProxy";
            this.checkGroupBoxProxy.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // comboBoxProxyType
            // 
            resources.ApplyResources(this.comboBoxProxyType, "comboBoxProxyType");
            this.comboBoxProxyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProxyType.FormattingEnabled = true;
            this.comboBoxProxyType.Items.AddRange(new object[] {
            resources.GetString("comboBoxProxyType.Items"),
            resources.GetString("comboBoxProxyType.Items1"),
            resources.GetString("comboBoxProxyType.Items2")});
            this.comboBoxProxyType.Name = "comboBoxProxyType";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(this.textBoxHostname);
            panel1.Controls.Add(this.textBoxPort);
            panel1.Controls.Add(this.label4);
            panel1.Name = "panel1";
            // 
            // textBoxHostname
            // 
            resources.ApplyResources(this.textBoxHostname, "textBoxHostname");
            this.theErrorProvider.SetIconPadding(this.textBoxHostname, ((int)(resources.GetObject("textBoxHostname.IconPadding"))));
            this.theGoodProvider.SetIconPadding(this.textBoxHostname, ((int)(resources.GetObject("textBoxHostname.IconPadding1"))));
            this.textBoxHostname.Name = "textBoxHostname";
            // 
            // textBoxPort
            // 
            resources.ApplyResources(this.textBoxPort, "textBoxPort");
            this.theErrorProvider.SetIconPadding(this.textBoxPort, ((int)(resources.GetObject("textBoxPort.IconPadding"))));
            this.theGoodProvider.SetIconPadding(this.textBoxPort, ((int)(resources.GetObject("textBoxPort.IconPadding1"))));
            this.textBoxPort.Name = "textBoxPort";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.theGoodProvider.SetIconPadding(this.textBoxPassword, ((int)(resources.GetObject("textBoxPassword.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxPassword, ((int)(resources.GetObject("textBoxPassword.IconPadding1"))));
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            resources.ApplyResources(this.textBoxUsername, "textBoxUsername");
            this.theGoodProvider.SetIconPadding(this.textBoxUsername, ((int)(resources.GetObject("textBoxUsername.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxUsername, ((int)(resources.GetObject("textBoxUsername.IconPadding1"))));
            this.textBoxUsername.Name = "textBoxUsername";
            // 
            // textBoxProxyExcludes
            // 
            resources.ApplyResources(this.textBoxProxyExcludes, "textBoxProxyExcludes");
            this.theGoodProvider.SetIconPadding(this.textBoxProxyExcludes, ((int)(resources.GetObject("textBoxProxyExcludes.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxProxyExcludes, ((int)(resources.GetObject("textBoxProxyExcludes.IconPadding1"))));
            this.textBoxProxyExcludes.Name = "textBoxProxyExcludes";
            // 
            // checkBoxAuthReq
            // 
            resources.ApplyResources(this.checkBoxAuthReq, "checkBoxAuthReq");
            this.checkBoxAuthReq.Checked = true;
            this.checkBoxAuthReq.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxAuthReq, 2);
            this.checkBoxAuthReq.Name = "checkBoxAuthReq";
            this.checkBoxAuthReq.UseVisualStyleBackColor = true;
            this.checkBoxAuthReq.CheckedChanged += new System.EventHandler(this.checkBoxAuthReq_CheckedChanged);
            // 
            // checkBoxProxyLocalhost
            // 
            resources.ApplyResources(this.checkBoxProxyLocalhost, "checkBoxProxyLocalhost");
            this.tableLayoutPanel1.SetColumnSpan(this.checkBoxProxyLocalhost, 2);
            this.checkBoxProxyLocalhost.Name = "checkBoxProxyLocalhost";
            this.checkBoxProxyLocalhost.UseVisualStyleBackColor = true;
            // 
            // lineSeparator1
            // 
            resources.ApplyResources(this.lineSeparator1, "lineSeparator1");
            this.lineSeparator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator1.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator1.Name = "lineSeparator1";
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.buttonOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.flowLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBoxPF.ResumeLayout(false);
            this.groupBoxPF.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).EndInit();
            this.theTabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageProxy.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.checkGroupBoxAutoRestart.ResumeLayout(false);
            this.checkGroupBoxAutoRestart.PerformLayout();
            this.groupBoxAfterThat.ResumeLayout(false);
            this.groupBoxAfterThat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAttemptsCount)).EndInit();
            this.checkGroupBoxRestartHostsWithWarns.ResumeLayout(false);
            this.checkGroupBoxRestartHostsWithWarns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartHWWInterval)).EndInit();
            this.checkGroupBoxProxy.ResumeLayout(false);
            this.checkGroupBoxProxy.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private CheckGroupBox checkGroupBoxRestartHostsWithWarns;
        private System.Windows.Forms.NumericUpDown numericUpDownRestartHWWInterval;
        private System.Windows.Forms.CheckBox chbxRunAtWindowsStartup;
        private System.Windows.Forms.CheckBox chbxStartHostsBeingActiveLastTime;
    }
}