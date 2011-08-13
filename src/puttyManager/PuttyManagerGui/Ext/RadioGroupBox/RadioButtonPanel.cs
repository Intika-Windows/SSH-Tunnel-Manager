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
using System.Windows.Forms;


namespace UIToolbox
{
	/// <summary>
	/// This class oversees the checkin/unchecking when mixing RadioButton objects with RadioGroupBox objects within the same container.
	/// </summary>
	public class RadioButtonPanel : Panel
	{
		/// <summary>
		/// RadioButtonPanel public constructor.
		/// </summary>
		public RadioButtonPanel()
		{
		}

		/// <summary>
		/// Hooks Check callback events of RadioButton objects within the panel to the RadioButtonPanel object.
		/// </summary>
		public void AddCheckEventListeners()
		{
			foreach(Control control in this.Controls)
			{
				RadioButton radioButton = control as RadioButton;
				if(radioButton != null)
				{
					radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
				}
				else
				{
					RadioGroupBox radioGroupBox = control as RadioGroupBox;
					if(radioGroupBox != null)
					{
						radioGroupBox.CheckedChanged += new EventHandler(radioGroupBox_CheckedChanged);
					}
				}
			}
		}

		/// <summary>
		/// Event callback called when a RadioButton's Check property is changed.
		/// </summary>
		/// <param name="sender">Object(RadioButton)</param>
		/// <param name="e">EventArgs</param>
		public void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			HandleRadioButtonClick((Control)sender);
		}

		/// <summary>
		/// Event callback called when a RadioGroupBox's Check property is changed.
		/// </summary>
		/// <param name="sender">Object(RadioGroupBox)</param>
		/// <param name="e">EventArgs</param>
		public void radioGroupBox_CheckedChanged(object sender, EventArgs e)
		{
			HandleRadioButtonClick((Control)sender);
		}

		private void HandleRadioButtonClick(Control clickedControl)
		{
			if(clickedControl == null)
				return;

			if(clickedControl.Parent is RadioGroupBox)
			{
				// If a RadioGroupBox is checked, the sender is the RadioButton,
				// not the RadioGroupBox, but we need the RadioGroupBox object.
				clickedControl = clickedControl.Parent;
			}

			RadioButton clickedRadioButton = clickedControl as RadioButton;
			if(clickedRadioButton != null)
			{
				if(clickedRadioButton.Checked != true)
				{
					// Only respond to check events that pertain to the control being checked on
					return;
				}
			}
			else
			{
				RadioGroupBox clickedRadioGroupBox = clickedControl as RadioGroupBox;
				if(clickedRadioGroupBox != null)
				{
					if(clickedRadioGroupBox.Checked != true)
					{
						// Only respond to check events that pertain to the control being checked on
						return;
					}
				}
			}

			foreach(Control control in this.Controls)
			{
				if(control != clickedControl)
				{
					RadioButton radioButton = control as RadioButton;
					if(radioButton != null)
					{
						// Normally .NET and WinForms would take care of this but
						// we need a mechanism that turns off radio buttons if a
						// radio group box is checked.
						if(radioButton.Checked != false)
							radioButton.Checked = false;
					}
					else
					{
						RadioGroupBox radioGroupBox = control as RadioGroupBox;
						if(radioGroupBox != null)
						{
							radioGroupBox.Checked = false;
						}
						else
						{
							// Not expected... must be some other kind of control.
						}
					}
				}
			}
		}
	}
}
