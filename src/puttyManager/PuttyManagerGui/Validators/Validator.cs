using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PuttyManagerGui.Validators
{
    class Validator
    {
        private const string ValidIpAddressRegex = @"(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])";
        private const string ValidHostnameRegex = @"(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])";
        private const string ValidPortRegex = @"0*(6553[0-6]|655[0-2][0-9]|65[0-4][0-9][0-9]|6[0-4][0-9][0-9][0-9]|[1-5][0-9]{4}|[1-9][0-9]{0,3})"; // нули и 1-65536
        public const string GoodValidationText = "ok!";

        private static readonly string _validHostnameOnly = string.Format(@"^(?:{0}|{1})$", ValidHostnameRegex, ValidIpAddressRegex);
        private static readonly string _validPort = string.Format(@"^{0}$", ValidPortRegex);
        private static readonly string _validHostnameAndPort = string.Format(@"^(?:{0}|{1}):{2}$", ValidHostnameRegex, ValidIpAddressRegex, ValidPortRegex);

        private static readonly Regex _regexHostnameOnly = new Regex(_validHostnameOnly, RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static readonly Regex _regexHostnameAndPort = new Regex(_validHostnameAndPort, RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static readonly Regex _regexPort = new Regex(_validPort, RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public Validator(ErrorProvider errorProvider, ErrorProvider goodProvider = null)
        {
            ErrorProvider = errorProvider;
            GoodProvider = goodProvider;
        }

        public ErrorProvider ErrorProvider { get; private set; }
        public ErrorProvider GoodProvider { get; private set; }

        // Контрол, функция селектор, функция валидатор
        private readonly Dictionary<Control, Tuple<Func<Control, string>, Func<Control, string, bool>>> _controls =
            new Dictionary<Control, Tuple<Func<Control, string>, Func<Control, string, bool>>>();

        private bool _afterValidateControls = false;

        public void AddControl(Control control, Func<Control,string> textSelector, Func<Control, string, bool> validatorMethod)
        {
            _controls[control] = Tuple.Create(textSelector, validatorMethod);
            control.Validating += onValidating;
        }

        public void AddControl(TextBox textBox, Func<Control, string, bool> validatorMethod, bool textChangedValidate = false)
        {
            AddControl(textBox, c => c.Text, validatorMethod);
            textBox.TextChanged += delegate { if (_afterValidateControls) ValidateControl(textBox); };
        }

        public bool ValidateControl(Control control)
        {
            if (control == null) throw new ArgumentNullException("control");
            if (!_controls.ContainsKey(control)) throw new FormatException("Control has not been set.");
            var tuple = _controls[control];
            var textSelector = tuple.Item1;
            var validate = tuple.Item2;
            return validate(control, textSelector(control));
        }

        public bool ValidateControls(bool showErrors = true)
        {
            bool good = true;
            foreach (var pair in _controls)
            {
                var control = pair.Key;
                var textSelector = pair.Value.Item1;
                var validate = pair.Value.Item2;
                good = validate(control, textSelector(control)) && good;
            }
            _afterValidateControls = true;
            if (!showErrors)
            {
                foreach (var control in _controls.Keys)
                {
                    ErrorProvider.SetError(control, "");
                    GoodProvider.SetError(control, "");
                }
            }
            return good;
        }

        public void Reset()
        {
            foreach (var control in _controls.Keys)
            {
                ErrorProvider.SetError(control, "");
                GoodProvider.SetError(control, "");
            }
            _afterValidateControls = false;
        }

        public bool ValidateUsername(Control control, string text)
        {
            return ValidateNotNullOrWhitespaces(control, text) && ValidateOnlyOneWord(control, text);
        }

        public bool ValidateNotNullOrWhitespaces(Control control, string text)
        {
            if (control == null) throw new ArgumentNullException("control");
            if (string.IsNullOrWhiteSpace(text))
            {
                SetError(control, @"You need to specify this value.");
                return false;
            }
            SetGood(control);
            return true;
        }

        public bool ValidateOnlyOneWord(Control control, string text)
        {
            if (control == null) throw new ArgumentNullException("control");
            if (text == null) throw new ArgumentNullException("text");
            if (Regex.IsMatch(text.Trim(), @"\s"))
            {
                SetError(control, @"The value should be a word without spaces.");
                return false;
            }
            SetGood(control);
            return true;
        }

        public bool ValidateHostname(Control control, string hostname)
        {
            return validateWithRegex(control, hostname, _regexHostnameOnly, @"Invalid hostname");
        }

        public bool ValidatePort(Control control, string port)
        {
            return validateWithRegex(control, port, _regexPort,
                @"You need to specify port number as number in range 1-65536");
        }

        public bool ValidateHostnameAndPort(Control control, string hostname)
        {
            return validateWithRegex(control, hostname, _regexHostnameAndPort, 
                @"You need to specify hostname in the form 'hostname:port'");
        }

        private bool validateWithRegex(Control control, string text, Regex regex, string errorMsg)
        {
            if (control == null) throw new ArgumentNullException("control");
            if (text == null) throw new ArgumentNullException("text");
            if (regex == null) throw new ArgumentNullException("regex");
            if (regex.IsMatch(text))
            {
                SetGood(control);
                return true;
            }
            SetError(control, errorMsg);
            return false;
        }

        public void SetError(Control control, string text)
        {
            if (ErrorProvider != null)
                ErrorProvider.SetError(control, text);
            if (GoodProvider != null)
                GoodProvider.SetError(control, "");
        }

        public void SetGood(Control control, string text = GoodValidationText)
        {
            if (GoodProvider != null)
                GoodProvider.SetError(control, text);
            if (ErrorProvider != null)
                ErrorProvider.SetError(control, "");
        }

        private void onValidating(object o, CancelEventArgs a)
        {
            if (_afterValidateControls)
                ValidateControl((Control) o);
        }
    }
}
