namespace PuttyManagerGui
{
    partial class StartUpDialog
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpDialog));
            this.buttonNewFileBrowse = new System.Windows.Forms.Button();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewFile = new System.Windows.Forms.TextBox();
            this.textBoxNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonCreateStorage = new System.Windows.Forms.RadioButton();
            this.radioButtonOpenStorage = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelCreate = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxSavePassNew = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelOpen = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExistingFileBrowse = new System.Windows.Forms.Button();
            this.checkBoxSavePassOpen = new System.Windows.Forms.CheckBox();
            this.textBoxOpenPassword = new System.Windows.Forms.TextBox();
            this.textBoxExistingFile = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelError = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.theOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.theSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.theGoodProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.theErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.theLineSeparator = new PuttyManagerGui.LineSeparator();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanelCreate.SuspendLayout();
            this.tableLayoutPanelOpen.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 6);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 13);
            label3.TabIndex = 0;
            label3.Text = "Encrypted Storage File:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 32);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 13);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 13);
            label5.TabIndex = 5;
            label5.Text = "Confirm Password:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 6);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(117, 13);
            label6.TabIndex = 0;
            label6.Text = "Encrypted Storage File:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(3, 32);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 13);
            label7.TabIndex = 3;
            label7.Text = "Password:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonNewFileBrowse
            // 
            this.buttonNewFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewFileBrowse.Location = new System.Drawing.Point(301, 3);
            this.buttonNewFileBrowse.Name = "buttonNewFileBrowse";
            this.buttonNewFileBrowse.Size = new System.Drawing.Size(28, 20);
            this.buttonNewFileBrowse.TabIndex = 2;
            this.buttonNewFileBrowse.Text = "...";
            this.buttonNewFileBrowse.UseVisualStyleBackColor = true;
            this.buttonNewFileBrowse.Click += new System.EventHandler(this.buttonNewFileBrowse_Click);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelCreate.SetColumnSpan(this.textBoxNewPassword, 2);
            this.textBoxNewPassword.Location = new System.Drawing.Point(126, 29);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(203, 20);
            this.textBoxNewPassword.TabIndex = 4;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewFile
            // 
            this.textBoxNewFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.theGoodProvider.SetIconPadding(this.textBoxNewFile, 34);
            this.theErrorProvider.SetIconPadding(this.textBoxNewFile, 34);
            this.textBoxNewFile.Location = new System.Drawing.Point(126, 3);
            this.textBoxNewFile.Name = "textBoxNewFile";
            this.textBoxNewFile.Size = new System.Drawing.Size(169, 20);
            this.textBoxNewFile.TabIndex = 1;
            // 
            // textBoxNewPasswordConfirm
            // 
            this.textBoxNewPasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelCreate.SetColumnSpan(this.textBoxNewPasswordConfirm, 2);
            this.textBoxNewPasswordConfirm.Location = new System.Drawing.Point(126, 55);
            this.textBoxNewPasswordConfirm.Name = "textBoxNewPasswordConfirm";
            this.textBoxNewPasswordConfirm.Size = new System.Drawing.Size(203, 20);
            this.textBoxNewPasswordConfirm.TabIndex = 6;
            this.textBoxNewPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.radioButtonCreateStorage);
            this.groupBox3.Controls.Add(this.radioButtonOpenStorage);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 65);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Source:";
            // 
            // radioButtonCreateStorage
            // 
            this.radioButtonCreateStorage.AutoSize = true;
            this.radioButtonCreateStorage.Checked = true;
            this.radioButtonCreateStorage.Location = new System.Drawing.Point(12, 15);
            this.radioButtonCreateStorage.Name = "radioButtonCreateStorage";
            this.radioButtonCreateStorage.Size = new System.Drawing.Size(117, 17);
            this.radioButtonCreateStorage.TabIndex = 0;
            this.radioButtonCreateStorage.TabStop = true;
            this.radioButtonCreateStorage.Text = "Create new storage";
            this.radioButtonCreateStorage.UseVisualStyleBackColor = true;
            this.radioButtonCreateStorage.CheckedChanged += new System.EventHandler(this.radioButtonCreateStorage_CheckedChanged);
            // 
            // radioButtonOpenStorage
            // 
            this.radioButtonOpenStorage.AutoSize = true;
            this.radioButtonOpenStorage.Location = new System.Drawing.Point(12, 38);
            this.radioButtonOpenStorage.Name = "radioButtonOpenStorage";
            this.radioButtonOpenStorage.Size = new System.Drawing.Size(142, 17);
            this.radioButtonOpenStorage.TabIndex = 1;
            this.radioButtonOpenStorage.Text = "Open an existing storage";
            this.radioButtonOpenStorage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCreate
            // 
            this.tableLayoutPanelCreate.AutoSize = true;
            this.tableLayoutPanelCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelCreate.ColumnCount = 4;
            this.tableLayoutPanelCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanelCreate.Controls.Add(label3, 0, 0);
            this.tableLayoutPanelCreate.Controls.Add(label4, 0, 1);
            this.tableLayoutPanelCreate.Controls.Add(this.buttonNewFileBrowse, 2, 0);
            this.tableLayoutPanelCreate.Controls.Add(this.checkBoxSavePassNew, 0, 3);
            this.tableLayoutPanelCreate.Controls.Add(label5, 0, 2);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewPasswordConfirm, 1, 2);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewPassword, 1, 1);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewFile, 1, 0);
            this.tableLayoutPanelCreate.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanelCreate.Name = "tableLayoutPanelCreate";
            this.tableLayoutPanelCreate.RowCount = 4;
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCreate.Size = new System.Drawing.Size(344, 104);
            this.tableLayoutPanelCreate.TabIndex = 1;
            // 
            // checkBoxSavePassNew
            // 
            this.checkBoxSavePassNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxSavePassNew.AutoSize = true;
            this.checkBoxSavePassNew.Location = new System.Drawing.Point(6, 84);
            this.checkBoxSavePassNew.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            this.checkBoxSavePassNew.Name = "checkBoxSavePassNew";
            this.checkBoxSavePassNew.Size = new System.Drawing.Size(99, 17);
            this.checkBoxSavePassNew.TabIndex = 7;
            this.checkBoxSavePassNew.Text = "Save password";
            this.checkBoxSavePassNew.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelOpen
            // 
            this.tableLayoutPanelOpen.AutoSize = true;
            this.tableLayoutPanelOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelOpen.ColumnCount = 4;
            this.tableLayoutPanelOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanelOpen.Controls.Add(label6, 0, 0);
            this.tableLayoutPanelOpen.Controls.Add(label7, 0, 1);
            this.tableLayoutPanelOpen.Controls.Add(this.buttonExistingFileBrowse, 2, 0);
            this.tableLayoutPanelOpen.Controls.Add(this.checkBoxSavePassOpen, 0, 2);
            this.tableLayoutPanelOpen.Controls.Add(this.textBoxOpenPassword, 1, 1);
            this.tableLayoutPanelOpen.Controls.Add(this.textBoxExistingFile, 1, 0);
            this.tableLayoutPanelOpen.Location = new System.Drawing.Point(3, 184);
            this.tableLayoutPanelOpen.Name = "tableLayoutPanelOpen";
            this.tableLayoutPanelOpen.RowCount = 3;
            this.tableLayoutPanelOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelOpen.Size = new System.Drawing.Size(344, 78);
            this.tableLayoutPanelOpen.TabIndex = 2;
            // 
            // buttonExistingFileBrowse
            // 
            this.buttonExistingFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExistingFileBrowse.Location = new System.Drawing.Point(301, 3);
            this.buttonExistingFileBrowse.Name = "buttonExistingFileBrowse";
            this.buttonExistingFileBrowse.Size = new System.Drawing.Size(28, 20);
            this.buttonExistingFileBrowse.TabIndex = 2;
            this.buttonExistingFileBrowse.Text = "...";
            this.buttonExistingFileBrowse.UseVisualStyleBackColor = true;
            this.buttonExistingFileBrowse.Click += new System.EventHandler(this.buttonExistingFileBrowse_Click);
            // 
            // checkBoxSavePassOpen
            // 
            this.checkBoxSavePassOpen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxSavePassOpen.AutoSize = true;
            this.checkBoxSavePassOpen.Location = new System.Drawing.Point(6, 58);
            this.checkBoxSavePassOpen.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            this.checkBoxSavePassOpen.Name = "checkBoxSavePassOpen";
            this.checkBoxSavePassOpen.Size = new System.Drawing.Size(99, 17);
            this.checkBoxSavePassOpen.TabIndex = 5;
            this.checkBoxSavePassOpen.Text = "Save password";
            this.checkBoxSavePassOpen.UseVisualStyleBackColor = true;
            // 
            // textBoxOpenPassword
            // 
            this.textBoxOpenPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelOpen.SetColumnSpan(this.textBoxOpenPassword, 2);
            this.textBoxOpenPassword.Location = new System.Drawing.Point(126, 29);
            this.textBoxOpenPassword.Name = "textBoxOpenPassword";
            this.textBoxOpenPassword.Size = new System.Drawing.Size(203, 20);
            this.textBoxOpenPassword.TabIndex = 4;
            this.textBoxOpenPassword.UseSystemPasswordChar = true;
            // 
            // textBoxExistingFile
            // 
            this.textBoxExistingFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.theGoodProvider.SetIconPadding(this.textBoxExistingFile, 34);
            this.theErrorProvider.SetIconPadding(this.textBoxExistingFile, 34);
            this.textBoxExistingFile.Location = new System.Drawing.Point(126, 3);
            this.textBoxExistingFile.Name = "textBoxExistingFile";
            this.textBoxExistingFile.Size = new System.Drawing.Size(169, 20);
            this.textBoxExistingFile.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelCreate);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelOpen);
            this.flowLayoutPanel1.Controls.Add(this.theLineSeparator);
            this.flowLayoutPanel1.Controls.Add(this.labelError);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 321);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelError.Location = new System.Drawing.Point(3, 273);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(53, 13);
            this.labelError.TabIndex = 11;
            this.labelError.Text = "Error Text";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.buttonExit);
            this.flowLayoutPanel2.Controls.Add(this.buttonCreate);
            this.flowLayoutPanel2.Controls.Add(this.buttonOpen);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 289);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(344, 29);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(266, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Location = new System.Drawing.Point(185, 3);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen.Location = new System.Drawing.Point(104, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // theOpenFileDialog
            // 
            this.theOpenFileDialog.DefaultExt = "*.est";
            this.theOpenFileDialog.Filter = "Storage files|*.est|All files|*.*";
            // 
            // theSaveFileDialog
            // 
            this.theSaveFileDialog.DefaultExt = "*.est";
            this.theSaveFileDialog.Filter = "Storage files|*.est|All files|*.*";
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
            // theLineSeparator
            // 
            this.theLineSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theLineSeparator.Location = new System.Drawing.Point(3, 268);
            this.theLineSeparator.MaximumSize = new System.Drawing.Size(2000, 2);
            this.theLineSeparator.MinimumSize = new System.Drawing.Size(0, 2);
            this.theLineSeparator.Name = "theLineSeparator";
            this.theLineSeparator.Size = new System.Drawing.Size(344, 2);
            this.theLineSeparator.TabIndex = 3;
            // 
            // StartUpDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(452, 411);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartUpDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storage Selection - SSH Tunnel Manager";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanelCreate.ResumeLayout(false);
            this.tableLayoutPanelCreate.PerformLayout();
            this.tableLayoutPanelOpen.ResumeLayout(false);
            this.tableLayoutPanelOpen.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewFileBrowse;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewFile;
        private System.Windows.Forms.TextBox textBoxNewPasswordConfirm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonCreateStorage;
        private System.Windows.Forms.RadioButton radioButtonOpenStorage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOpen;
        private System.Windows.Forms.Button buttonExistingFileBrowse;
        private System.Windows.Forms.TextBox textBoxOpenPassword;
        private System.Windows.Forms.TextBox textBoxExistingFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private LineSeparator theLineSeparator;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog theOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog theSaveFileDialog;
        private System.Windows.Forms.ErrorProvider theGoodProvider;
        private System.Windows.Forms.ErrorProvider theErrorProvider;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckBox checkBoxSavePassNew;
        private System.Windows.Forms.CheckBox checkBoxSavePassOpen;
    }
}