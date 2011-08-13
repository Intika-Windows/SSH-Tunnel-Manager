using System;
using System.Windows.Forms;
using PuttyManagerGui.Validators;

namespace PuttyManagerGui.Forms
{
    public partial class ChangePasswordDialog : Form
    {
        private readonly Validator _validator;

        public ChangePasswordDialog(bool savePasswordChecked = false)
        {
            InitializeComponent();

            checkBoxSavePass.Checked = savePasswordChecked;
            SavePassword = savePasswordChecked;

            _validator = new Validator(theErrorProvider, theGoodProvider);
            NewPasswordValidatorFunctor.Register(_validator, textBoxNewPassword, textBoxNewPasswordConfirm);
        }

        public string Password { get; private set; }
        public bool SavePassword { get; private set; }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!_validator.ValidateControls())
                return;

            Password = textBoxNewPassword.Text;
            SavePassword = checkBoxSavePass.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
