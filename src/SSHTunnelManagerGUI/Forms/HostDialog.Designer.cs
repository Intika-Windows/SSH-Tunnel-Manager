namespace SSHTunnelManagerGUI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostDialog));
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
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
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
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // tunnelsGridView
            // 
            this.tunnelsGridView.AllowUserToAddRows = false;
            this.tunnelsGridView.AllowUserToDeleteRows = false;
            this.tunnelsGridView.AllowUserToResizeRows = false;
            resources.ApplyResources(this.tunnelsGridView, "tunnelsGridView");
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
            this.tunnelsGridView.MultiSelect = false;
            this.tunnelsGridView.Name = "tunnelsGridView";
            this.tunnelsGridView.ReadOnly = true;
            this.tunnelsGridView.RowHeadersVisible = false;
            this.tunnelsGridView.RowTemplate.Height = 18;
            this.tunnelsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tunnelsGridView.SelectionChanged += new System.EventHandler(this.tunnelsGridView_SelectionChanged);
            // 
            // tgvNameColumn
            // 
            this.tgvNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.tgvNameColumn, "tgvNameColumn");
            this.tgvNameColumn.Name = "tgvNameColumn";
            this.tgvNameColumn.ReadOnly = true;
            // 
            // tgvTypeColumn
            // 
            this.tgvTypeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.tgvTypeColumn, "tgvTypeColumn");
            this.tgvTypeColumn.Name = "tgvTypeColumn";
            this.tgvTypeColumn.ReadOnly = true;
            // 
            // tgvSrcPortColumn
            // 
            this.tgvSrcPortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.tgvSrcPortColumn, "tgvSrcPortColumn");
            this.tgvSrcPortColumn.Name = "tgvSrcPortColumn";
            this.tgvSrcPortColumn.ReadOnly = true;
            // 
            // tgvDstHostColumn
            // 
            this.tgvDstHostColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.tgvDstHostColumn, "tgvDstHostColumn");
            this.tgvDstHostColumn.Name = "tgvDstHostColumn";
            this.tgvDstHostColumn.ReadOnly = true;
            // 
            // tgvDstPortColumn
            // 
            this.tgvDstPortColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            resources.ApplyResources(this.tgvDstPortColumn, "tgvDstPortColumn");
            this.tgvDstPortColumn.Name = "tgvDstPortColumn";
            this.tgvDstPortColumn.ReadOnly = true;
            // 
            // textBoxDestHost
            // 
            resources.ApplyResources(this.textBoxDestHost, "textBoxDestHost");
            this.theGoodProvider.SetIconAlignment(this.textBoxDestHost, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBoxDestHost.IconAlignment"))));
            this.theErrorProvider.SetIconAlignment(this.textBoxDestHost, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBoxDestHost.IconAlignment1"))));
            this.theGoodProvider.SetIconPadding(this.textBoxDestHost, ((int)(resources.GetObject("textBoxDestHost.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxDestHost, ((int)(resources.GetObject("textBoxDestHost.IconPadding1"))));
            this.textBoxDestHost.Name = "textBoxDestHost";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // radioButtonDynamic
            // 
            resources.ApplyResources(this.radioButtonDynamic, "radioButtonDynamic");
            this.radioButtonDynamic.Name = "radioButtonDynamic";
            this.radioButtonDynamic.UseVisualStyleBackColor = true;
            this.radioButtonDynamic.CheckedChanged += new System.EventHandler(this.radioButtonDynamic_CheckedChanged);
            // 
            // buttonRemoveTunnel
            // 
            resources.ApplyResources(this.buttonRemoveTunnel, "buttonRemoveTunnel");
            this.buttonRemoveTunnel.Name = "buttonRemoveTunnel";
            this.buttonRemoveTunnel.UseVisualStyleBackColor = true;
            this.buttonRemoveTunnel.Click += new System.EventHandler(this.buttonRemoveTunnel_Click);
            // 
            // radioButtonRemote
            // 
            resources.ApplyResources(this.radioButtonRemote, "radioButtonRemote");
            this.radioButtonRemote.Name = "radioButtonRemote";
            this.radioButtonRemote.UseVisualStyleBackColor = true;
            // 
            // buttonAddTunnel
            // 
            resources.ApplyResources(this.buttonAddTunnel, "buttonAddTunnel");
            this.buttonAddTunnel.Name = "buttonAddTunnel";
            this.buttonAddTunnel.UseVisualStyleBackColor = true;
            this.buttonAddTunnel.Click += new System.EventHandler(this.buttonAddTunnel_Click);
            // 
            // radioButtonLocal
            // 
            resources.ApplyResources(this.radioButtonLocal, "radioButtonLocal");
            this.radioButtonLocal.Checked = true;
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            // 
            // textBoxTunnelName
            // 
            resources.ApplyResources(this.textBoxTunnelName, "textBoxTunnelName");
            this.theGoodProvider.SetIconPadding(this.textBoxTunnelName, ((int)(resources.GetObject("textBoxTunnelName.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxTunnelName, ((int)(resources.GetObject("textBoxTunnelName.IconPadding1"))));
            this.textBoxTunnelName.Name = "textBoxTunnelName";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // textBoxDestPort
            // 
            resources.ApplyResources(this.textBoxDestPort, "textBoxDestPort");
            this.theGoodProvider.SetIconPadding(this.textBoxDestPort, ((int)(resources.GetObject("textBoxDestPort.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxDestPort, ((int)(resources.GetObject("textBoxDestPort.IconPadding1"))));
            this.textBoxDestPort.Name = "textBoxDestPort";
            // 
            // textBoxSourcePort
            // 
            resources.ApplyResources(this.textBoxSourcePort, "textBoxSourcePort");
            this.theGoodProvider.SetIconPadding(this.textBoxSourcePort, ((int)(resources.GetObject("textBoxSourcePort.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxSourcePort, ((int)(resources.GetObject("textBoxSourcePort.IconPadding1"))));
            this.textBoxSourcePort.Name = "textBoxSourcePort";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.theErrorProvider.SetIconPadding(this.textBoxName, ((int)(resources.GetObject("textBoxName.IconPadding"))));
            this.theGoodProvider.SetIconPadding(this.textBoxName, ((int)(resources.GetObject("textBoxName.IconPadding1"))));
            this.textBoxName.Name = "textBoxName";
            // 
            // textBoxHostname
            // 
            resources.ApplyResources(this.textBoxHostname, "textBoxHostname");
            this.theGoodProvider.SetIconPadding(this.textBoxHostname, ((int)(resources.GetObject("textBoxHostname.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxHostname, ((int)(resources.GetObject("textBoxHostname.IconPadding1"))));
            this.textBoxHostname.Name = "textBoxHostname";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxLogin
            // 
            resources.ApplyResources(this.textBoxLogin, "textBoxLogin");
            this.theErrorProvider.SetIconPadding(this.textBoxLogin, ((int)(resources.GetObject("textBoxLogin.IconPadding"))));
            this.theGoodProvider.SetIconPadding(this.textBoxLogin, ((int)(resources.GetObject("textBoxLogin.IconPadding1"))));
            this.textBoxLogin.Name = "textBoxLogin";
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.theErrorProvider.SetIconPadding(this.textBoxPassword, ((int)(resources.GetObject("textBoxPassword.IconPadding"))));
            this.theGoodProvider.SetIconPadding(this.textBoxPassword, ((int)(resources.GetObject("textBoxPassword.IconPadding1"))));
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // comboBoxDependsOn
            // 
            resources.ApplyResources(this.comboBoxDependsOn, "comboBoxDependsOn");
            this.comboBoxDependsOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDependsOn.FormattingEnabled = true;
            this.theErrorProvider.SetIconAlignment(this.comboBoxDependsOn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBoxDependsOn.IconAlignment"))));
            this.comboBoxDependsOn.Name = "comboBoxDependsOn";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.textBoxHostname);
            this.panel1.Controls.Add(this.textBoxPort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Name = "panel1";
            // 
            // textBoxPort
            // 
            resources.ApplyResources(this.textBoxPort, "textBoxPort");
            this.theGoodProvider.SetIconPadding(this.textBoxPort, ((int)(resources.GetObject("textBoxPort.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxPort, ((int)(resources.GetObject("textBoxPort.IconPadding1"))));
            this.textBoxPort.Name = "textBoxPort";
            // 
            // flowLayoutPanelMain
            // 
            resources.ApplyResources(this.flowLayoutPanelMain, "flowLayoutPanelMain");
            this.flowLayoutPanelMain.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelAddHost);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelEditHost);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            // 
            // flowLayoutPanelAddHost
            // 
            resources.ApplyResources(this.flowLayoutPanelAddHost, "flowLayoutPanelAddHost");
            this.flowLayoutPanelAddHost.Controls.Add(this.buttonClose);
            this.flowLayoutPanelAddHost.Controls.Add(this.buttonAddHost);
            this.flowLayoutPanelAddHost.Name = "flowLayoutPanelAddHost";
            // 
            // buttonClose
            // 
            resources.ApplyResources(this.buttonClose, "buttonClose");
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAddHost
            // 
            resources.ApplyResources(this.buttonAddHost, "buttonAddHost");
            this.buttonAddHost.Name = "buttonAddHost";
            this.buttonAddHost.UseVisualStyleBackColor = true;
            this.buttonAddHost.Click += new System.EventHandler(this.buttonAddHost_Click);
            // 
            // flowLayoutPanelEditHost
            // 
            resources.ApplyResources(this.flowLayoutPanelEditHost, "flowLayoutPanelEditHost");
            this.flowLayoutPanelEditHost.Controls.Add(this.buttonApply);
            this.flowLayoutPanelEditHost.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelEditHost.Controls.Add(this.buttonOk);
            this.flowLayoutPanelEditHost.Name = "flowLayoutPanelEditHost";
            // 
            // buttonApply
            // 
            resources.ApplyResources(this.buttonApply, "buttonApply");
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // theErrorProvider
            // 
            this.theErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.theErrorProvider.ContainerControl = this;
            resources.ApplyResources(this.theErrorProvider, "theErrorProvider");
            // 
            // theGoodProvider
            // 
            this.theGoodProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.theGoodProvider.ContainerControl = this;
            resources.ApplyResources(this.theGoodProvider, "theGoodProvider");
            // 
            // HostDialog
            // 
            this.AcceptButton = this.buttonAddHost;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.Controls.Add(this.flowLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostDialog";
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