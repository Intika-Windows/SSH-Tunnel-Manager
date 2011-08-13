namespace UIToolbox
{
	partial class RadioGroupBox
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_radioButton = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// m_radioButton
			// 
			this.m_radioButton.AutoSize = true;
			this.m_radioButton.Location = new System.Drawing.Point(0, 0);
			this.m_radioButton.Name = "m_radioButton";
			this.m_radioButton.Size = new System.Drawing.Size(104, 24);
			this.m_radioButton.TabIndex = 0;
			this.m_radioButton.TabStop = true;
			this.m_radioButton.Text = "radioButton";
			this.m_radioButton.UseVisualStyleBackColor = true;
			this.m_radioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// RadioGroupBox
			// 
			this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.CheckGroupBox_ControlAdded);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.RadioButton m_radioButton;
	}
}
