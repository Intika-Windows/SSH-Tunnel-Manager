using PuttyManagerGui.Controls;

namespace PuttyManagerGui.Forms
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
            this.checkBoxTraceDebug = new System.Windows.Forms.CheckBox();
            this.checkGroupBoxAutoRestart = new UIToolbox.CheckGroupBox();
            this.numericUpDownMaxAttemptsCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRestartDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.lineSeparator1 = new LineSeparator();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkGroupBoxAutoRestart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAttemptsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartDelay)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxTraceDebug
            // 
            this.checkBoxTraceDebug.AutoSize = true;
            this.checkBoxTraceDebug.Location = new System.Drawing.Point(3, 88);
            this.checkBoxTraceDebug.Name = "checkBoxTraceDebug";
            this.checkBoxTraceDebug.Size = new System.Drawing.Size(193, 17);
            this.checkBoxTraceDebug.TabIndex = 0;
            this.checkBoxTraceDebug.Text = "Trace debug messages in hosts log";
            this.checkBoxTraceDebug.UseVisualStyleBackColor = true;
            // 
            // checkGroupBoxAutoRestart
            // 
            this.checkGroupBoxAutoRestart.Controls.Add(this.numericUpDownMaxAttemptsCount);
            this.checkGroupBoxAutoRestart.Controls.Add(this.numericUpDownRestartDelay);
            this.checkGroupBoxAutoRestart.Controls.Add(this.label1);
            this.checkGroupBoxAutoRestart.Controls.Add(this.label2);
            this.checkGroupBoxAutoRestart.Location = new System.Drawing.Point(3, 3);
            this.checkGroupBoxAutoRestart.Name = "checkGroupBoxAutoRestart";
            this.checkGroupBoxAutoRestart.Size = new System.Drawing.Size(226, 79);
            this.checkGroupBoxAutoRestart.TabIndex = 1;
            this.checkGroupBoxAutoRestart.TabStop = false;
            this.checkGroupBoxAutoRestart.Text = "Restart link on fail";
            // 
            // numericUpDownMaxAttemptsCount
            // 
            this.numericUpDownMaxAttemptsCount.Location = new System.Drawing.Point(163, 46);
            this.numericUpDownMaxAttemptsCount.Name = "numericUpDownMaxAttemptsCount";
            this.numericUpDownMaxAttemptsCount.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownMaxAttemptsCount.TabIndex = 3;
            this.numericUpDownMaxAttemptsCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownRestartDelay
            // 
            this.numericUpDownRestartDelay.Location = new System.Drawing.Point(163, 20);
            this.numericUpDownRestartDelay.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownRestartDelay.Name = "numericUpDownRestartDelay";
            this.numericUpDownRestartDelay.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownRestartDelay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delay before restart (seconds):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Maximum attempts count:";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(154, 119);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // lineSeparator1
            // 
            this.lineSeparator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineSeparator1.Location = new System.Drawing.Point(3, 111);
            this.lineSeparator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.lineSeparator1.MinimumSize = new System.Drawing.Size(0, 2);
            this.lineSeparator1.Name = "lineSeparator1";
            this.lineSeparator1.Size = new System.Drawing.Size(226, 2);
            this.lineSeparator1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.checkGroupBoxAutoRestart);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTraceDebug);
            this.flowLayoutPanel1.Controls.Add(this.lineSeparator1);
            this.flowLayoutPanel1.Controls.Add(this.buttonClose);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 145);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // OptionsDialog
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(381, 294);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsDialog_FormClosing);
            this.checkGroupBoxAutoRestart.ResumeLayout(false);
            this.checkGroupBoxAutoRestart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAttemptsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRestartDelay)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownMaxAttemptsCount;
        private System.Windows.Forms.NumericUpDown numericUpDownRestartDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTraceDebug;
        private UIToolbox.CheckGroupBox checkGroupBoxAutoRestart;
        private System.Windows.Forms.Button buttonClose;
        private LineSeparator lineSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}