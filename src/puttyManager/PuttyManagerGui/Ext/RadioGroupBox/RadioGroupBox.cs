// Copyright (c) 2009 Jeff Beeghly
// mailto:jeffb42@hotmail.com
// Originally published at http://www.codeproject.com/KB/miscctrl/CheckGBAndRadioGB.aspx
// under the title, "CheckGroupBox and RadioGroupBox"
//
// This file and the accompanying files of this project may be freely used provided the following
// conditions are met:
//        * This copyright statement is not removed or modified.
//        * The code is not sold in uncompiled form.  (Release as a compiled binary which is part
//          of an application is fine)
//        * The design, code, or compiled binaries are not "Re-branded".
//
// Optional:
//        * I receive credit in the about box of the released product (something along the lines of
//          "RadioGroupBox Copyright (c) 2009 Jeff Beeghly").
//        * I receive a fully licensed copy of the product (regardless of whether the product is
//          is free, shrinkwrap, or commercial).  This is optional, though if you release products
//          which use code I've contributed to, I would appreciate a fully licensed copy.
//
// In addition, you may not:
//        * Publicly release modified versions of the code or publicly release works derived from
//          the code without express written authorization.

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace UIToolbox
{
	/// <summary>
	/// RadioGroupBox is a GroupBox with an embeded RadioButton.
	/// </summary>
	[ToolboxBitmap(typeof(RadioGroupBox), "RadioGroupBox.bmp")]
	public partial class RadioGroupBox : GroupBox
	{
		// Constants
		private const int RADIOBUTTON_X_OFFSET = 10;
		private const int RADIOBUTTON_Y_OFFSET = -2;

		// Members
		private bool m_bDisableChildrenIfUnchecked;

		/// <summary>
		/// RadioGroupBox public constructor.
		/// </summary>
		public RadioGroupBox()
		{
			this.InitializeComponent();
			this.m_bDisableChildrenIfUnchecked = false;
			this.m_radioButton.Parent = this;
			this.m_radioButton.Location = new System.Drawing.Point(RADIOBUTTON_X_OFFSET, RADIOBUTTON_Y_OFFSET);
			this.Checked = false;

			// Set the color of the RadioButon's text to the color of the label in a standard groupbox control.
			VisualStyleRenderer vsr = new VisualStyleRenderer(VisualStyleElement.Button.GroupBox.Normal);
			Color groupBoxTextColor = vsr.GetColor(ColorProperty.TextColor);
			this.m_radioButton.ForeColor = groupBoxTextColor;
		}

		#region Properties
		/// <summary>
		/// The text associated with the control.
		/// </summary>
		public override string Text
		{
			get
			{
				if(this.Site != null && this.Site.DesignMode == true)
				{
					// Design-time mode
					return this.m_radioButton.Text;
				}
				else
				{
					// Run-time
					return " "; // Set the text of the GroupBox to a space, so the gap appears before the RadioButton.
				}
			}
			set
			{
				base.Text = " "; // Set the text of the GroupBox to a space, so the gap appears before the RadioButton.
				this.m_radioButton.Text = value;
			}
		}

		/// <summary>
		/// Indicates whether the radio button is checked or not.
		/// </summary>
		[Description("Indicates whether the radio button is checked or not.")]
		[Category("Appearance")]
		[DefaultValue(false)]
		public bool Checked
		{
			get
			{
				return this.m_radioButton.Checked;
			}
			set
			{
				if(this.m_radioButton.Checked != value)
				{
					this.m_radioButton.Checked = value;
				}
			}
		}

		/// <summary>
		/// Determines if child controls of the GroupBox are disabled when the CheckBox is unchecked.
		/// </summary>
		[Description("Determines if child controls of the GroupBox are disabled when the RadioButton is unchecked.")]
		[Category("Appearance")]
		[DefaultValue(false)]
		public bool DisableChildrenIfUnchecked
		{
			get
			{
				return this.m_bDisableChildrenIfUnchecked;
			}
			set
			{
				if(this.m_bDisableChildrenIfUnchecked != value)
				{
					this.m_bDisableChildrenIfUnchecked = value;
				}
			}
		}
		#endregion Properties

		#region Event Handlers
		/// <summary>
		/// Occurs when the 'checked' property changes value.
		/// </summary>
		[Description("Occurs when the 'checked' property changes value.")]
		public event EventHandler CheckedChanged;

		//
		// Summary:
		//     Raises the System.Windows.Forms.RadioButton.checkBox_CheckedChanged event.
		/// <summary>
		/// Raises the System.Windows.Forms.
		/// </summary>
		/// <param name="e">An System.EventArgs that contains the event data.</param>
		protected virtual void OnCheckedChanged(EventArgs e)
		{
		}
		#endregion Event Handlers

		#region Events
		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = sender as RadioButton;
			if(radioButton == null)
				return;

			RadioGroupBox target = radioButton.Parent as RadioGroupBox;
			if(target == null)
				return;

			if(this.m_bDisableChildrenIfUnchecked == true)
			{
				bool bEnabled = this.m_radioButton.Checked;
				foreach(Control control in this.Controls)
				{
					if(control != this.m_radioButton)
					{
						control.Enabled = bEnabled;
					}
				}
			}

			if(target.Checked == false)
				return;

			Control parentControl = target.Parent;
			if(parentControl == null)
				return;

			foreach(Control childControl in parentControl.Controls)
			{
				if(childControl is RadioGroupBox)
				{
					if(childControl != this)
					{
						(childControl as RadioGroupBox).Checked = false;
					}
				}
			}

			if(CheckedChanged != null)
			{
				CheckedChanged(sender, e);
			}
		}

		private void CheckGroupBox_ControlAdded(object sender, ControlEventArgs e)
		{
			if(this.m_bDisableChildrenIfUnchecked == true)
			{
				e.Control.Enabled = this.Checked;
			}
		}
		#endregion Events
	}
}
