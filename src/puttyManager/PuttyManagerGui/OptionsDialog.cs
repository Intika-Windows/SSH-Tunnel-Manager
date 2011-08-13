using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PuttyManagerGui.Properties;

namespace PuttyManagerGui
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
            Settings.Default.Config_RestartEnabled = checkGroupBoxAutoRestart.Checked;
            Settings.Default.Config_RestartDelay = (int)numericUpDownRestartDelay.Value;
            Settings.Default.Config_MaxAttemptsCount = (int)numericUpDownMaxAttemptsCount.Value;
            Settings.Default.Config_TraceDebug = checkBoxTraceDebug.Checked;
            Settings.Default.Save();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
