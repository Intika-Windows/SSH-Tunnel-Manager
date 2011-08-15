using System;
using System.Windows.Forms;
using SSHTunnelManagerGUI.Properties;

namespace SSHTunnelManagerGUI.Forms
{
    public partial class OptionsDialog : Form
    {
        public OptionsDialog()
        {
            InitializeComponent();

            checkGroupBoxAutoRestart.Checked = Settings.Default.Config_RestartEnabled;
            numericUpDownRestartDelay.Value = Settings.Default.Config_RestartDelay;
            numericUpDownMaxAttemptsCount.Value = Settings.Default.Config_MaxAttemptsCount;
            checkBoxTraceDebug.Checked = Settings.Default.Config_TraceDebug;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OptionsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Config_RestartEnabled = checkGroupBoxAutoRestart.Checked;
            Settings.Default.Config_RestartDelay = (int)numericUpDownRestartDelay.Value;
            Settings.Default.Config_MaxAttemptsCount = (int)numericUpDownMaxAttemptsCount.Value;
            Settings.Default.Config_TraceDebug = checkBoxTraceDebug.Checked;
            Settings.Default.Save();
        }
    }
}
