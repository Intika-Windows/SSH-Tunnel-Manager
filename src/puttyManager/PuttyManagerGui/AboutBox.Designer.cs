namespace PuttyManagerGui
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
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(499, 350);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::PuttyManagerGui.Properties.Resources.oie_1220044U5H48MJA__1_;
            this.logoPictureBox.InitialImage = null;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 7);
            this.logoPictureBox.Size = new System.Drawing.Size(165, 344);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelProductName, 2);
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(177, 2);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(319, 17);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVersion
            // 
            this.tableLayoutPanel.SetColumnSpan(this.labelVersion, 2);
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(177, 23);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(319, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelProjectPage
            // 
            this.linkLabelProjectPage.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.linkLabelProjectPage, 2);
            this.linkLabelProjectPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabelProjectPage.Location = new System.Drawing.Point(177, 44);
            this.linkLabelProjectPage.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.linkLabelProjectPage.Name = "linkLabelProjectPage";
            this.linkLabelProjectPage.Size = new System.Drawing.Size(319, 13);
            this.linkLabelProjectPage.TabIndex = 25;
            this.linkLabelProjectPage.TabStop = true;
            this.linkLabelProjectPage.Text = "Project page on Google Code";
            this.linkLabelProjectPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelProjectPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // textBoxDescription
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxDescription, 2);
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(177, 62);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(319, 227);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // linkLabelGpl3
            // 
            this.linkLabelGpl3.AutoSize = true;
            this.linkLabelGpl3.Location = new System.Drawing.Point(174, 292);
            this.linkLabelGpl3.Name = "linkLabelGpl3";
            this.linkLabelGpl3.Size = new System.Drawing.Size(110, 13);
            this.linkLabelGpl3.TabIndex = 25;
            this.linkLabelGpl3.TabStop = true;
            this.linkLabelGpl3.Text = "GNU GPL v3 License";
            this.linkLabelGpl3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // linkLabelMit
            // 
            this.linkLabelMit.AutoSize = true;
            this.linkLabelMit.Location = new System.Drawing.Point(174, 305);
            this.linkLabelMit.Name = "linkLabelMit";
            this.linkLabelMit.Size = new System.Drawing.Size(103, 13);
            this.linkLabelMit.TabIndex = 25;
            this.linkLabelMit.TabStop = true;
            this.linkLabelMit.Text = "PuTTY MIT License";
            this.linkLabelMit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // linkLabelCCA3
            // 
            this.linkLabelCCA3.AutoSize = true;
            this.linkLabelCCA3.Location = new System.Drawing.Point(290, 292);
            this.linkLabelCCA3.Name = "linkLabelCCA3";
            this.linkLabelCCA3.Size = new System.Drawing.Size(194, 13);
            this.linkLabelCCA3.TabIndex = 25;
            this.linkLabelCCA3.TabStop = true;
            this.linkLabelCCA3.Text = "Creative Common Attribution 3.0 license";
            this.linkLabelCCA3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // linkLabelFugue
            // 
            this.linkLabelFugue.AutoSize = true;
            this.linkLabelFugue.Location = new System.Drawing.Point(290, 305);
            this.linkLabelFugue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.linkLabelFugue.Name = "linkLabelFugue";
            this.linkLabelFugue.Size = new System.Drawing.Size(168, 13);
            this.linkLabelFugue.TabIndex = 25;
            this.linkLabelFugue.TabStop = true;
            this.linkLabelFugue.Text = "Yusuke Kamiyamane Fugue Icons";
            this.linkLabelFugue.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClickedHandler);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(421, 324);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 368);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About SSH Tunnel Manager";
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
