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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordDialog));
            System.Windows.Forms.Label label5;
            this.tableLayoutPanelCreate = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.checkBoxSavePass = new System.Windows.Forms.CheckBox();
            this.theLineSeparator = new SSHTunnelManagerGUI.Controls.LineSeparator();
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
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // tableLayoutPanelCreate
            // 
            resources.ApplyResources(this.tableLayoutPanelCreate, "tableLayoutPanelCreate");
            this.tableLayoutPanelCreate.Controls.Add(label4, 0, 1);
            this.tableLayoutPanelCreate.Controls.Add(label5, 0, 2);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewPasswordConfirm, 1, 2);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewPassword, 1, 1);
            this.tableLayoutPanelCreate.Name = "tableLayoutPanelCreate";
            // 
            // textBoxNewPasswordConfirm
            // 
            resources.ApplyResources(this.textBoxNewPasswordConfirm, "textBoxNewPasswordConfirm");
            this.textBoxNewPasswordConfirm.Name = "textBoxNewPasswordConfirm";
            this.textBoxNewPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword
            // 
            resources.ApplyResources(this.textBoxNewPassword, "textBoxNewPassword");
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxSavePass
            // 
            resources.ApplyResources(this.checkBoxSavePass, "checkBoxSavePass");
            this.checkBoxSavePass.Name = "checkBoxSavePass";
            this.checkBoxSavePass.UseVisualStyleBackColor = true;
            // 
            // theLineSeparator
            // 
            resources.ApplyResources(this.theLineSeparator, "theLineSeparator");
            this.theLineSeparator.MaximumSize = new System.Drawing.Size(2000, 2);
            this.theLineSeparator.MinimumSize = new System.Drawing.Size(0, 2);
            this.theLineSeparator.Name = "theLineSeparator";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.buttonCancel);
            this.flowLayoutPanel2.Controls.Add(this.buttonOk);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxSavePass);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelCreate);
            this.flowLayoutPanel1.Controls.Add(this.theLineSeparator);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
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
            // ChangePasswordDialog
            // 
            this.AcceptButton = this.buttonOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordDialog";
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