using System.Windows.Forms;

namespace SSHTunnelManagerGUI.Validators
{
    interface IValidatorFunctor
    {
        Validator Validator { get; }
        bool Validate(Control control, string text);
    }
}