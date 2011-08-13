using System.Windows.Forms;

namespace PuttyManagerGui.Forms
{
    public partial class ProgressDialog : Form
    {
        public ProgressDialog()
        {
            InitializeComponent();
            Text = Util.AssemblyTitle;
        }

        public void Update(int progress, string text)
        {
            progressBar1.Value = progress;
            label1.Text = text;
            Application.DoEvents();
        }

        public void Reset()
        {
            progressBar1.Value = 0;
            label1.Text = "";
            Application.DoEvents();
        }
    }
}
