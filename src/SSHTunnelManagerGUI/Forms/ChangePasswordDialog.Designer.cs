using SSHTunnelManagerGUI.Controls;

namespace SSHTunnelManagerGUI.Forms
{
    partial class ChangePasswordDialog
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordDialog));
            this.tableLayoutPanelCreate = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxSavePass = new System.Windows.Forms.CheckBox();
            this.textBoxNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.theLineSeparator = new LineSeparator();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.theGoodProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.theErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanelCreate.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelCreate
            // 
            this.tableLayoutPanelCreate.AutoSize = true;
            this.tableLayoutPanelCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelCreate.ColumnCount = 3;
            this.tableLayoutPanelCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanelCreate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCreate.Controls.Add(label4, 0, 1);
            this.tableLayoutPanelCreate.Controls.Add(label5, 0, 2);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewPasswordConfirm, 1, 2);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewPassword, 1, 1);
            this.tableLayoutPanelCreate.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCreate.Name = "tableLayoutPanelCreate";
            this.tableLayoutPanelCreate.RowCount = 4;
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCreate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCreate.Size = new System.Drawing.Size(278, 52);
            this.tableLayoutPanelCreate.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 6);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 13);
            label4.TabIndex = 0;
            label4.Text = "Password:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxSavePass
            // 
            this.checkBoxSavePass.Location = new System.Drawing.Point(6, 6);
            this.checkBoxSavePass.Margin = new System.Windows.Forms.Padding(6, 6, 3, 3);
            this.checkBoxSavePass.Name = "checkBoxSavePass";
            this.checkBoxSavePass.Size = new System.Drawing.Size(110, 17);
            this.checkBoxSavePass.TabIndex = 0;
            this.checkBoxSavePass.Text = "Save password";
            this.checkBoxSavePass.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 32);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 13);
            label5.TabIndex = 2;
            label5.Text = "Confirm Password:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxNewPasswordConfirm
            // 
            this.textBoxNewPasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNewPasswordConfirm.Location = new System.Drawing.Point(103, 29);
            this.textBoxNewPasswordConfirm.Name = "textBoxNewPasswordConfirm";
            this.textBoxNewPasswordConfirm.Size = new System.Drawing.Size(160, 20);
            this.textBoxNewPasswordConfirm.TabIndex = 3;
            this.textBoxNewPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNewPassword.Location = new System.Drawing.Point(103, 3);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(160, 20);
            this.textBoxNewPassword.TabIndex = 1;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // theLineSeparator
            // 
            this.theLineSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theLineSeparator.Location = new System.Drawing.Point(3, 61);
            this.theLineSeparator.MaximumSize = new System.Drawing.Size(2000, 2);
            this.theLineSeparator.MinimumSize = new System.Drawing.Size(0, 2);
            this.theLineSeparator.Name = "theLineSeparator";
            this.theLineSeparator.Size = new System.Drawing.Size(281, 2);
            this.theLineSeparator.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel2.Controls.Add(this.buttonOk);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxSavePass);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 69);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(281, 29);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(203, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(122, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelCreate);
            this.flowLayoutPanel1.Controls.Add(this.theLineSeparator);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(287, 101);
            this.flowLayoutPanel1.TabIndex = 0;
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
            // ChangePasswordDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(368, 172);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password - SSH Tunnel Manager";
            this.tableLayoutPanelCreate.ResumeLayout(false);
            this.tableLayoutPanelCreate.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theGoodProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCreate;
        private System.Windows.Forms.CheckBox checkBoxSavePass;
        private System.Windows.Forms.TextBox textBoxNewPasswordConfirm;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private LineSeparator theLineSeparator;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ErrorProvider theGoodProvider;
        private System.Windows.Forms.ErrorProvider theErrorProvider;
    }
}