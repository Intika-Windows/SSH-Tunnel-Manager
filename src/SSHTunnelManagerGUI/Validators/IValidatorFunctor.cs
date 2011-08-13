using System.Windows.Forms;

namespace PuttyManagerGui.Validators
{
    interface IValidatorFunctor
    {
        Validator Validator { get; }
        bool Validate(Control control, string text);
    }
}