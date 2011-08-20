using SSHTunnelManagerGUI.Controls;

namespace SSHTunnelManagerGUI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpDialog));
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
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
            this.theLineSeparator = new SSHTunnelManagerGUI.Controls.LineSeparator();
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
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
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
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // buttonNewFileBrowse
            // 
            resources.ApplyResources(this.buttonNewFileBrowse, "buttonNewFileBrowse");
            this.buttonNewFileBrowse.Name = "buttonNewFileBrowse";
            this.buttonNewFileBrowse.UseVisualStyleBackColor = true;
            this.buttonNewFileBrowse.Click += new System.EventHandler(this.buttonNewFileBrowse_Click);
            // 
            // textBoxNewPassword
            // 
            resources.ApplyResources(this.textBoxNewPassword, "textBoxNewPassword");
            this.tableLayoutPanelCreate.SetColumnSpan(this.textBoxNewPassword, 2);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewFile
            // 
            resources.ApplyResources(this.textBoxNewFile, "textBoxNewFile");
            this.theGoodProvider.SetIconPadding(this.textBoxNewFile, ((int)(resources.GetObject("textBoxNewFile.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxNewFile, ((int)(resources.GetObject("textBoxNewFile.IconPadding1"))));
            this.textBoxNewFile.Name = "textBoxNewFile";
            // 
            // textBoxNewPasswordConfirm
            // 
            resources.ApplyResources(this.textBoxNewPasswordConfirm, "textBoxNewPasswordConfirm");
            this.tableLayoutPanelCreate.SetColumnSpan(this.textBoxNewPasswordConfirm, 2);
            this.textBoxNewPasswordConfirm.Name = "textBoxNewPasswordConfirm";
            this.textBoxNewPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.radioButtonCreateStorage);
            this.groupBox3.Controls.Add(this.radioButtonOpenStorage);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // radioButtonCreateStorage
            // 
            resources.ApplyResources(this.radioButtonCreateStorage, "radioButtonCreateStorage");
            this.radioButtonCreateStorage.Checked = true;
            this.radioButtonCreateStorage.Name = "radioButtonCreateStorage";
            this.radioButtonCreateStorage.TabStop = true;
            this.radioButtonCreateStorage.UseVisualStyleBackColor = true;
            this.radioButtonCreateStorage.CheckedChanged += new System.EventHandler(this.radioButtonCreateStorage_CheckedChanged);
            // 
            // radioButtonOpenStorage
            // 
            resources.ApplyResources(this.radioButtonOpenStorage, "radioButtonOpenStorage");
            this.radioButtonOpenStorage.Name = "radioButtonOpenStorage";
            this.radioButtonOpenStorage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCreate
            // 
            resources.ApplyResources(this.tableLayoutPanelCreate, "tableLayoutPanelCreate");
            this.tableLayoutPanelCreate.Controls.Add(label3, 0, 0);
            this.tableLayoutPanelCreate.Controls.Add(label4, 0, 1);
            this.tableLayoutPanelCreate.Controls.Add(this.buttonNewFileBrowse, 2, 0);
            this.tableLayoutPanelCreate.Controls.Add(this.checkBoxSavePassNew, 0, 3);
            this.tableLayoutPanelCreate.Controls.Add(label5, 0, 2);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewPasswordConfirm, 1, 2);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewPassword, 1, 1);
            this.tableLayoutPanelCreate.Controls.Add(this.textBoxNewFile, 1, 0);
            this.tableLayoutPanelCreate.Name = "tableLayoutPanelCreate";
            // 
            // checkBoxSavePassNew
            // 
            resources.ApplyResources(this.checkBoxSavePassNew, "checkBoxSavePassNew");
            this.checkBoxSavePassNew.Name = "checkBoxSavePassNew";
            this.checkBoxSavePassNew.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelOpen
            // 
            resources.ApplyResources(this.tableLayoutPanelOpen, "tableLayoutPanelOpen");
            this.tableLayoutPanelOpen.Controls.Add(label6, 0, 0);
            this.tableLayoutPanelOpen.Controls.Add(label7, 0, 1);
            this.tableLayoutPanelOpen.Controls.Add(this.buttonExistingFileBrowse, 2, 0);
            this.tableLayoutPanelOpen.Controls.Add(this.checkBoxSavePassOpen, 0, 2);
            this.tableLayoutPanelOpen.Controls.Add(this.textBoxOpenPassword, 1, 1);
            this.tableLayoutPanelOpen.Controls.Add(this.textBoxExistingFile, 1, 0);
            this.tableLayoutPanelOpen.Name = "tableLayoutPanelOpen";
            // 
            // buttonExistingFileBrowse
            // 
            resources.ApplyResources(this.buttonExistingFileBrowse, "buttonExistingFileBrowse");
            this.buttonExistingFileBrowse.Name = "buttonExistingFileBrowse";
            this.buttonExistingFileBrowse.UseVisualStyleBackColor = true;
            this.buttonExistingFileBrowse.Click += new System.EventHandler(this.buttonExistingFileBrowse_Click);
            // 
            // checkBoxSavePassOpen
            // 
            resources.ApplyResources(this.checkBoxSavePassOpen, "checkBoxSavePassOpen");
            this.checkBoxSavePassOpen.Name = "checkBoxSavePassOpen";
            this.checkBoxSavePassOpen.UseVisualStyleBackColor = true;
            // 
            // textBoxOpenPassword
            // 
            resources.ApplyResources(this.textBoxOpenPassword, "textBoxOpenPassword");
            this.tableLayoutPanelOpen.SetColumnSpan(this.textBoxOpenPassword, 2);
            this.textBoxOpenPassword.Name = "textBoxOpenPassword";
            this.textBoxOpenPassword.UseSystemPasswordChar = true;
            // 
            // textBoxExistingFile
            // 
            resources.ApplyResources(this.textBoxExistingFile, "textBoxExistingFile");
            this.theGoodProvider.SetIconPadding(this.textBoxExistingFile, ((int)(resources.GetObject("textBoxExistingFile.IconPadding"))));
            this.theErrorProvider.SetIconPadding(this.textBoxExistingFile, ((int)(resources.GetObject("textBoxExistingFile.IconPadding1"))));
            this.textBoxExistingFile.Name = "textBoxExistingFile";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelCreate);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanelOpen);
            this.flowLayoutPanel1.Controls.Add(this.theLineSeparator);
            this.flowLayoutPanel1.Controls.Add(this.labelError);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // labelError
            // 
            resources.ApplyResources(this.labelError, "labelError");
            this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelError.Name = "labelError";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.buttonExit);
            this.flowLayoutPanel2.Controls.Add(this.buttonCreate);
            this.flowLayoutPanel2.Controls.Add(this.buttonOpen);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            resources.ApplyResources(this.buttonCreate, "buttonCreate");
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonOpen
            // 
            resources.ApplyResources(this.buttonOpen, "buttonOpen");
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // theOpenFileDialog
            // 
            this.theOpenFileDialog.DefaultExt = "*.xstg";
            resources.ApplyResources(this.theOpenFileDialog, "theOpenFileDialog");
            // 
            // theSaveFileDialog
            // 
            this.theSaveFileDialog.DefaultExt = "*.xstg";
            resources.ApplyResources(this.theSaveFileDialog, "theSaveFileDialog");
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
            // theLineSeparator
            // 
            resources.ApplyResources(this.theLineSeparator, "theLineSeparator");
            this.theLineSeparator.MaximumSize = new System.Drawing.Size(2000, 2);
            this.theLineSeparator.MinimumSize = new System.Drawing.Size(0, 2);
            this.theLineSeparator.Name = "theLineSeparator";
            // 
            // StartUpDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartUpDialog";
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