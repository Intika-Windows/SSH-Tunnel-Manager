using System;
using System.Windows.Forms;
using SSHTunnelManagerGUI.Properties;

namespace SSHTunnelManagerGUI.Validators
{
    class NewPasswordValidatorFunctor : IValidatorFunctor
    {
        private readonly Control _control1;
        private readonly Control _control2;

        public NewPasswordValidatorFunctor(Validator validator, Control control1, Control control2)
        {
            if (validator == null) throw new ArgumentNullException("validator");
            if (control1 == null) throw new ArgumentNullException("control1");
            if (control2 == null) throw new ArgumentNullException("control2");
            Validator = validator;
            _control1 = control1;
            _control2 = control2;
        }

        public static void Register(Validator validator, TextBox control1, TextBox control2)
        {
            if (validator == null) throw new ArgumentNullException("validator");
            if (control1 == null) throw new ArgumentNullException("control1");
            if (control2 == null) throw new ArgumentNullException("control2");
            validator.AddControl(control1, new NewPasswordValidatorFunctor(validator, control1, control2).Validate);
            validator.AddControl(control2, new NewPasswordValidatorFunctor(validator, control1, control2).Validate);
        }

        public Validator Validator { get; private set; }

        public bool Validate(Control control, string text)
        {
            if (_control1 != control && _control2 != control)
                throw new FormatException(Resources.NewPasswordValidatorFunctor_Validate_InvalidControl);
            if (!Validator.ValidateNotNullOrWhitespaces(control, text))
                return false;
            if (!Validator.ValidateOnlyOneWord(control, text))
                return false;
            if (_control1.Text != _control2.Text)
            {
                Validator.SetError(_control1, Resources.ValidatorError_NewPassword);
                Validator.SetError(_control2, Resources.ValidatorError_NewPassword);
                return false;
            }
            Validator.SetGood(_control1);
            Validator.SetGood(_control2);
            return true;
        }
    }
}