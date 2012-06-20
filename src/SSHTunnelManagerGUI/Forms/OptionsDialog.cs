using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using SSHTunnelManager.Domain;
using SSHTunnelManagerGUI.Ext.CheckGroupBox;
using SSHTunnelManagerGUI.Properties;
using SSHTunnelManagerGUI.Validators;
using System.Linq;

namespace SSHTunnelManagerGUI.Forms
{
    public partial class OptionsDialog : Form
    {
        private readonly Validator _validator;

        public OptionsDialog(PuttyProfile puttyProfile)
        {
            InitializeComponent();

            PuttyProfile = puttyProfile;

            buttonApply.Enabled = false;

            checkGroupBoxAutoRestart.Checked = Settings.Default.Config_RestartEnabled;
            numericUpDownRestartDelay.Value = Settings.Default.Config_RestartDelay;
            numericUpDownMaxAttemptsCount.Value = Settings.Default.Config_MaxAttemptsCount;
            radioButtonMakeDelay.Checked = Settings.Default.Config_AfterMaxAttemptsMakeDelay;
            checkBoxTraceDebug.Checked = Settings.Default.Config_TraceDebug;
            checkGroupBoxRestartHostsWithWarns.Checked = Settings.Default.Config_RestartHostsWithWarnings;
            numericUpDownRestartHWWInterval.Value = Settings.Default.Config_RestartHostsWithWarningsInterval;
            chbxRunAtWindowsStartup.Checked = Settings.Default.Config_RunAtWindowsStartup;
            chbxStartHostsBeingActiveLastTime.Checked = Settings.Default.Config_StartHostsBeingActiveLastTime;
            if (PuttyProfile != null)
            {
                checkBoxLocalPortAcceptAll.Checked = PuttyProfile.LocalPortAcceptAll;
                checkBoxRemotePortAcceptAll.Checked = PuttyProfile.RemotePortAcceptAll;
                checkGroupBoxProxy.Checked = PuttyProfile.ProxyMethod != PuttyProfile.ProxyType.None;
                comboBoxProxyType.SelectedIndex = PuttyProfile.ProxyMethod == PuttyProfile.ProxyType.Http ? 0 
                    : PuttyProfile.ProxyMethod == PuttyProfile.ProxyType.Socks4 ? 1
                    : PuttyProfile.ProxyMethod == PuttyProfile.ProxyType.Socks5 ? 2
                    : 0;
                textBoxHostname.Text = PuttyProfile.ProxyHost;
                textBoxPort.Text = PuttyProfile.ProxyPort.ToString();
                textBoxUsername.Text = PuttyProfile.ProxyUsername;
                textBoxPassword.Text = PuttyProfile.ProxyPassword;
                checkBoxAuthReq.Checked = !string.IsNullOrEmpty(PuttyProfile.ProxyUsername);
                checkBoxProxyLocalhost.Checked = PuttyProfile.ProxyLocalhost;
                textBoxProxyExcludes.Text = PuttyProfile.ProxyExcludeList;
            } else
            {
                checkBoxLocalPortAcceptAll.Enabled = false;
                checkBoxRemotePortAcceptAll.Enabled = false;
                checkGroupBoxProxy.Enabled = false;
            }

            _validator = new Validator(theErrorProvider);
            _validator.AddControl(textBoxHostname, validateHostname);
            _validator.AddControl(textBoxPort, validatePort);
            _validator.AddControl(textBoxUsername, validateUsername);
            _validator.AddControl(textBoxPassword, validatePassword);

            var controls = new List<Control>();
            collectControls(Controls, ref controls);
            foreach (var textBox in controls.OfType<TextBox>())
            {
                textBox.TextChanged += controlChanged;
            }
            foreach (var textBox in controls.OfType<CheckBox>())
            {
                textBox.CheckedChanged += controlChanged;
            }
            foreach (var textBox in controls.OfType<RadioButton>())
            {
                textBox.CheckedChanged += controlChanged;
            }
            foreach (var textBox in controls.OfType<ComboBox>())
            {
                textBox.SelectedIndexChanged += controlChanged;
            }
            foreach (var textBox in controls.OfType<CheckGroupBox>())
            {
                textBox.CheckedChanged += controlChanged;
            }
            foreach (var textBox in controls.OfType<NumericUpDown>())
            {
                textBox.ValueChanged += controlChanged;
            }
        }

        private void collectControls(IEnumerable controls, ref List<Control> result)
        {
            foreach (Control control in controls)
            {
                result.Add(control);
                collectControls(control.Controls, ref result);
            }
        }

        private void controlChanged(object sender, EventArgs eventArgs)
        {
            buttonApply.Enabled = true;
        }

        #region Validators

        private bool validateHostname(Control control, string text)
        {
            return !checkGroupBoxProxy.Checked || _validator.ValidateHostname(control, text);
        }

        private bool validatePort(Control control, string text)
        {
            return !checkGroupBoxProxy.Checked || _validator.ValidateHostname(control, text);
        }

        private bool validateUsername(Control control, string text)
        {
            return !checkGroupBoxProxy.Checked || !checkBoxAuthReq.Checked || _validator.ValidateHostname(control, text);
        }

        private bool validatePassword(Control control, string text)
        {
            return !checkGroupBoxProxy.Checked || !checkBoxAuthReq.Checked || _validator.ValidateHostname(control, text);
        }

        #endregion

        public PuttyProfile PuttyProfile { get; private set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!apply())
                return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (!apply())
                return;
            buttonApply.Enabled = false;
        }

        private bool apply()
        {
            if (!_validator.ValidateControls())
                return false;
            Settings.Default.Config_RestartEnabled = checkGroupBoxAutoRestart.Checked;
            Settings.Default.Config_RestartDelay = (int) numericUpDownRestartDelay.Value;
            Settings.Default.Config_MaxAttemptsCount = (int) numericUpDownMaxAttemptsCount.Value;
            Settings.Default.Config_AfterMaxAttemptsMakeDelay = radioButtonMakeDelay.Checked;
            Settings.Default.Config_TraceDebug = checkBoxTraceDebug.Checked;
            Settings.Default.Config_RestartHostsWithWarnings = checkGroupBoxRestartHostsWithWarns.Checked;
            Settings.Default.Config_RestartHostsWithWarningsInterval = (int) numericUpDownRestartHWWInterval.Value;
            Settings.Default.Config_RunAtWindowsStartup = chbxRunAtWindowsStartup.Checked;
            Settings.Default.Config_StartHostsBeingActiveLastTime = chbxStartHostsBeingActiveLastTime.Checked;
            Settings.Default.Save();
            if (PuttyProfile != null)
            {
                updatePuttyProfile();
            }
            updateWindowsStartup(chbxRunAtWindowsStartup.Checked);
            return true;
        }

        private void updateWindowsStartup(bool runAtWinStartup)
        {
            var rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rk == null)
            {
                MessageBox.Show(
                    this,
                    "Cannot open the registry key 'SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run'.",
                    Util.AssemblyTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (runAtWinStartup)
            {
                var command = string.Format("\"{0}\" /minimized", Application.ExecutablePath);
                rk.SetValue(Util.AssemblyTitle, command);
            }
            else
            {
                rk.DeleteValue(Util.AssemblyTitle, false);
            }  
        }

        private void updatePuttyProfile()
        {
            PuttyProfile.LocalPortAcceptAll = checkBoxLocalPortAcceptAll.Checked;
            PuttyProfile.RemotePortAcceptAll = checkBoxRemotePortAcceptAll.Checked;
            if (checkGroupBoxProxy.Checked)
            {
                switch (comboBoxProxyType.SelectedIndex)
                {
                case 0:
                    PuttyProfile.ProxyMethod = PuttyProfile.ProxyType.Http;
                    break;
                case 1:
                    PuttyProfile.ProxyMethod = PuttyProfile.ProxyType.Socks4;
                    break;
                case 2:
                    PuttyProfile.ProxyMethod = PuttyProfile.ProxyType.Socks5;
                    break;
                default:
                    PuttyProfile.ProxyMethod = PuttyProfile.ProxyType.None;
                    break;
                }
            }
            else
            {
                PuttyProfile.ProxyMethod = PuttyProfile.ProxyType.None;
            }
            PuttyProfile.ProxyHost = textBoxHostname.Text;
            PuttyProfile.ProxyPort = int.Parse(textBoxPort.Text);
            if (checkBoxAuthReq.Checked)
            {
                PuttyProfile.ProxyUsername = textBoxUsername.Text;
                PuttyProfile.ProxyPassword = textBoxPassword.Text;
            }
            else
            {
                PuttyProfile.ProxyUsername = "";
                PuttyProfile.ProxyPassword = "";
            }
            PuttyProfile.ProxyLocalhost = checkBoxProxyLocalhost.Checked;
            PuttyProfile.ProxyExcludeList = textBoxProxyExcludes.Text.Trim();

            PuttyProfile.Save();
        }

        private void radioButtonMakeDelay_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownRestartDelay.Enabled = radioButtonMakeDelay.Enabled;
        }

        private void checkBoxAuthReq_CheckedChanged(object sender, EventArgs e)
        {
            var enabled = checkBoxAuthReq.Checked;
            textBoxUsername.Enabled = enabled;
            textBoxPassword.Enabled = enabled;
            if (!enabled)
            {
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }
    }
}
