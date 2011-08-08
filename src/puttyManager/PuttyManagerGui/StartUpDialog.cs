using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PuttyManagerGui
{
    public partial class StartUpDialog : Form
    {
        private readonly Validator _validatorCreate;
        private readonly Validator _validatorOpen;

        public StartUpDialog()
        {
            InitializeComponent();

            _validatorCreate = new Validator(theErrorProvider, theGoodProvider);
            _validatorCreate.AddControl(textBoxNewFile, validateNewFile);
            _validatorCreate.AddControl(textBoxNewPassword, validateNewPassword);
            _validatorCreate.AddControl(textBoxNewPasswordConfirm, validateNewPassword);

            _validatorOpen = new Validator(theErrorProvider, theGoodProvider);
            _validatorOpen.AddControl(textBoxExistingFile, validateOpenFile);
            _validatorOpen.AddControl(textBoxOpenPassword, validateOpenPassword);

            Error = null;
        }

        #region Validators

        private bool validateOpenFile(Control control, string text)
        {
            if (!_validatorOpen.ValidateNotNullOrWhitespaces(control, text))
                return false;
            if (!File.Exists(text))
            {
                _validatorOpen.SetError(control, @"File does not exist.");
                return false;
            }
            try
            {
                using (File.OpenRead(text))
                {
                }
            }
            catch (Exception e)
            {
                _validatorOpen.SetError(control, e.Message);
            }
            _validatorOpen.SetGood(control);
            return true;
        }

        private bool validateNewFile(Control control, string text)
        {
            if (!_validatorCreate.ValidateNotNullOrWhitespaces(control, text))
                return false;
            
            _validatorCreate.SetGood(control);
            return true;
        }

        private bool validateOpenPassword(Control control, string text)
        {
            if (!_validatorCreate.ValidateNotNullOrWhitespaces(control, text))
                return false;
            if (!_validatorCreate.ValidateOnlyOneWord(control, text))
                return false;
            _validatorCreate.SetGood(control);
            return true;
        }

        private bool validateNewPassword(Control control, string text)
        {
            if (!_validatorCreate.ValidateNotNullOrWhitespaces(control, text))
                return false;
            if (!_validatorCreate.ValidateOnlyOneWord(control, text))
                return false;
            if (textBoxNewPassword.Text != textBoxNewPasswordConfirm.Text)
            {
                _validatorCreate.SetError(textBoxNewPassword, @"Password and confirmation does not match.");
                _validatorCreate.SetError(textBoxNewPasswordConfirm, @"Password and confirmation does not match.");
                return false;
            }
            _validatorCreate.SetGood(textBoxNewPassword);
            _validatorCreate.SetGood(textBoxNewPasswordConfirm);
            return true;
        }

        #endregion

        private void radioButtonCreateStorage_CheckedChanged(object sender, EventArgs e)
        {
            var source = radioButtonCreateStorage.Checked ? StorageSource.NewStorage : StorageSource.OpenStorage;
            applySource(source);
        }

        private void applySource(StorageSource source)
        {
            switch (source)
            {
            case StorageSource.NewStorage:
                tableLayoutPanelCreate.Visible = true;
                tableLayoutPanelOpen.Visible = false;
                buttonCreate.Visible = true;
                buttonOpen.Visible = false;
                break;
            case StorageSource.OpenStorage:
                tableLayoutPanelCreate.Visible = false;
                tableLayoutPanelOpen.Visible = true;
                buttonCreate.Visible = false;
                buttonOpen.Visible = true;
                break;
            default:
                throw new ArgumentOutOfRangeException();
            }
        }

        public enum StorageSource
        {
            NewStorage,
            OpenStorage
        }

        /// <summary>
        /// Global error (error after all validations).
        /// </summary>
        private string Error
        {
            get { return labelError.Text; }
            set
            {
                labelError.Visible = !string.IsNullOrWhiteSpace(value);
                labelError.Text = value;
            }
        }

        private void buttonNewFileBrowse_Click(object sender, EventArgs e)
        {
            var result = theSaveFileDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            textBoxNewFile.Text = theSaveFileDialog.FileName;
        }

        private void buttonExistingFileBrowse_Click(object sender, EventArgs e)
        {
            var result = theOpenFileDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            textBoxExistingFile.Text = theOpenFileDialog.FileName;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!_validatorCreate.ValidateControls())
                return;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (!_validatorOpen.ValidateControls())
                return;

            Error = "Test";
        }
    }
}
