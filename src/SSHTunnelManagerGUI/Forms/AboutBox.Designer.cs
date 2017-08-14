namespace SSHTunnelManagerGUI.Forms
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.linkLabelProjectPage = new System.Windows.Forms.LinkLabel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.linkLabelGpl3 = new System.Windows.Forms.LinkLabel();
            this.linkLabelMit = new System.Windows.Forms.LinkLabel();
            this.linkLabelCCA3 = new System.Windows.Forms.LinkLabel();
            this.linkLabelFugue = new System.Windows.Forms.LinkLabel();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            resources.ApplyResources(this.tableLayoutPanel, "tableLayoutPanel");
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.linkLabelProjectPage, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.linkLabelGpl3, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.linkLabelMit, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.linkLabelCCA3, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.linkLabelFugue, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.okButton, 2, 6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            // 
            // logoPictureBox
            // 
            resources.ApplyResources(this.logoPictureBox, "logoPictureBox");
            this.logoPictureBox.Image = global::SSHTunnelManagerGUI.Properties.Resources.disco;
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 7);
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelProductName, 2);
            resources.ApplyResources(this.labelProductName, "labelProductName");
            this.labelProductName.Name = "labelProductName";
            // 
            // labelVersion
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelVersion, 2);
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.labelVersion.Name = "labelVersion";
            // 
            // linkLabelProjectPage
            // 
            resources.ApplyResources(this.linkLabelProjectPage, "linkLabelProjectPage");
            this.tableLayoutPanel.SetColumnSpan(this.linkLabelProjectPage, 2);
            this.linkLabelProjectPage.Name = "linkLabelProjectPage";
            this.linkLabelProjectPage.TabStop = true;
            this.linkLabelProjectPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // textBoxDescription
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxDescription, 2);
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.TabStop = false;
            // 
            // linkLabelGpl3
            // 
            resources.ApplyResources(this.linkLabelGpl3, "linkLabelGpl3");
            this.linkLabelGpl3.Name = "linkLabelGpl3";
            this.linkLabelGpl3.TabStop = true;
            this.linkLabelGpl3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // linkLabelMit
            // 
            resources.ApplyResources(this.linkLabelMit, "linkLabelMit");
            this.linkLabelMit.Name = "linkLabelMit";
            this.linkLabelMit.TabStop = true;
            this.linkLabelMit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // linkLabelCCA3
            // 
            resources.ApplyResources(this.linkLabelCCA3, "linkLabelCCA3");
            this.linkLabelCCA3.Name = "linkLabelCCA3";
            this.linkLabelCCA3.TabStop = true;
            this.linkLabelCCA3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // linkLabelFugue
            // 
            resources.ApplyResources(this.linkLabelFugue, "linkLabelFugue");
            this.linkLabelFugue.Name = "linkLabelFugue";
            this.linkLabelFugue.TabStop = true;
            this.linkLabelFugue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Name = "okButton";
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.LinkLabel linkLabelProjectPage;
        private System.Windows.Forms.LinkLabel linkLabelMit;
        private System.Windows.Forms.LinkLabel linkLabelGpl3;
        private System.Windows.Forms.LinkLabel linkLabelCCA3;
        private System.Windows.Forms.LinkLabel linkLabelFugue;
    }
}
