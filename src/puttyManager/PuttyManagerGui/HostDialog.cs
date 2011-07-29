using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PuttyManager.Business;
using PuttyManager.Domain;

namespace PuttyManagerGui
{
    public partial class HostDialog : Form
    {
        private readonly Validator _hostValidator;
        private readonly Validator _tunnelValidator;

        private HostInfo _currentHost;
        private List<HostInfo> _recentlyAddedHosts = new List<HostInfo>();
        private Label _labelRecentlyAdded;

        public HostDialog()
        {
            InitializeComponent();
            _hostValidator = new Validator(theErrorProvider, theGoodProvider);
            _hostValidator.AddControl(textBoxName, validateAlias);
            _hostValidator.AddControl(textBoxHostname, _hostValidator.ValidateHostname);
            _hostValidator.AddControl(textBoxPort, _hostValidator.ValidatePort);
            _hostValidator.AddControl(textBoxLogin, _hostValidator.ValidateUsername);
            _hostValidator.AddControl(textBoxPassword, _hostValidator.ValidateNotNullOrWhitespaces);

            _tunnelValidator = new Validator(theErrorProvider, theGoodProvider);
            _tunnelValidator.AddControl(textBoxSourcePort, validateTunnelSourcePort);
            _tunnelValidator.AddControl(textBoxDestHost, validateTunnelDestinationHost);
            _tunnelValidator.AddControl(textBoxDestPort, validateTunnelDestinationPort);
            _tunnelValidator.AddControl(textBoxTunnelName, validateTunnelAlias);
        }

        #region Validators

        private bool validateAlias(Control control, string text)
        {
            if (_tunnelValidator.ValidateNotNullOrWhitespaces(control, text))
            {
                var alias = text;

                var aliases = EncryptedSettings.Instance.Hosts.Select(h => h.Name).ToList();

                if (aliases.Contains(alias))
                {
                    _tunnelValidator.SetError(control, @"Alias is busy by another host.");
                    return false;
                }
                return true;
            }
            return false;
        }

        private bool validateTunnelAlias(Control control, string text)
        {
            if (_tunnelValidator.ValidateNotNullOrWhitespaces(control, text))
            {
                var alias = text;

                var aliases = EncryptedSettings.Instance.Hosts.SelectMany(h => h.Tunnels).Select(t => t.Name).Concat(
                    _currentHost.Tunnels.Select(t => t.Name)).ToList();

                if (aliases.Contains(alias))
                {
                    _tunnelValidator.SetError(control, @"Alias is busy by another tunnel.");
                    return false;
                }
                return true;
            }
            return false;
        }

        private bool validateTunnelDestinationHost(Control control, string text)
        {
            if (radioButtonLocal.Checked || radioButtonRemote.Checked)
            {
                // local or remote
                return _tunnelValidator.ValidateHostname(control, text);
            }
            // dynamic
            if (!string.IsNullOrWhiteSpace(text))
            {
                theErrorProvider.SetError(control, @"Destination hostname should be empty for dynamic tunnels.");
                theGoodProvider.SetError(control, "");
                return false;
            }
            return true;
        }

        private bool validateTunnelDestinationPort(Control control, string text)
        {
            if (radioButtonLocal.Checked || radioButtonRemote.Checked)
            {
                // local or remote
                return _tunnelValidator.ValidatePort(control, text);
            }
            // dynamic
            if (!string.IsNullOrWhiteSpace(text))
            {
                _tunnelValidator.SetError(control, @"Hostname should be empty for dynamic tunnels.");
                return false;
            }
            return true;
        }

        private bool validateTunnelSourcePort(Control control, string text)
        {
            if (radioButtonLocal.Checked || radioButtonRemote.Checked)
            {
                // local or remote
                if (_tunnelValidator.ValidatePort(control, text))
                {
                    var port = text;
                    var hosts = EncryptedSettings.Instance.Hosts;

                    var ports = hosts.SelectMany(h => h.Tunnels).Select(t => t.LocalPort).Concat(
                                _currentHost.Tunnels.Select(t => t.LocalPort)).ToList();

                    if (ports.Contains(port))
                    {
                        _tunnelValidator.SetError(control, @"Local port is busy by another tunnel.");
                        return false;
                    }
                    return true;
                }
                return false;
            }
            // dynamic
            if (!string.IsNullOrWhiteSpace(text))
            {
                _tunnelValidator.SetError(control, @"Hostname should be empty for dynamic tunnels.");
                return false;
            }
            return true;
        }

        #endregion

        public HostInfo StartupDependsOn { get; set; }

        private void HostDialog_Load(object sender, EventArgs e)
        {
            reset();
            if (StartupDependsOn != null)
                comboBoxDependsOn.SelectedItem = StartupDependsOn;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonAddHost_Click(object sender, EventArgs e)
        {
            if (!_hostValidator.ValidateControls()) return;

            if (_tunnelValidator.ValidateControls(false))
            {
                switch (MessageBox.Show(this, @"You may forget to press 'Add' button, add new tunnel into list before continue?", 
                                        @"SSH Tunnel Manager", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                case DialogResult.Yes:
                    // Adding last tunnel
                    buttonAddTunnel_Click(null, EventArgs.Empty);
                    break;
                case DialogResult.No:   
                    resetAddTunnelGroup();
                    break;
                case DialogResult.Cancel:
                    // Go back and change something
                    return;
                }
            }

            // Adding host
            _currentHost.Name = textBoxName.Text.Trim();
            _currentHost.Hostname = textBoxHostname.Text.Trim();
            _currentHost.Port = textBoxPort.Text.Trim();
            _currentHost.Username = textBoxLogin.Text;
            _currentHost.Password = textBoxPassword.Text;
            var dependsOnHost = comboBoxDependsOn.SelectedItem as HostInfo;
            if (dependsOnHost != null)
            {
                _currentHost.DependsOn = dependsOnHost;
            }

            EncryptedSettings.Instance.Hosts.Add(_currentHost);
            EncryptedSettings.Instance.Save();

            // Update gui and reset
            _recentlyAddedHosts.Add(_currentHost);
            if (_labelRecentlyAdded == null)
            {
                _labelRecentlyAdded = new Label {ForeColor = Color.FromArgb(20,146,20), Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom, Margin = new Padding(3,3,3,0)};
                flowLayoutPanelMain.Controls.Add(_labelRecentlyAdded);
            }
            _labelRecentlyAdded.Text = @"Recently added: " + _currentHost; // string.Join(", ", _recentlyAddedHosts.Select(h => h.ToString()));
            var rowCount = (int)Math.Ceiling((double)_labelRecentlyAdded.PreferredWidth / _labelRecentlyAdded.Size.Width);
            _labelRecentlyAdded.Size = new Size(_labelRecentlyAdded.Size.Width, rowCount * _labelRecentlyAdded.PreferredHeight);

            buttonClose.Text = @"Close";
            reset();
        }

        private void reset()
        {
            _currentHost = new HostInfo();

            textBoxName.Text = "";
            textBoxHostname.Text = "";
            textBoxPort.Text = "";
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            listBoxTunnels.Items.Clear();
            buttonRemoveTunnel.Enabled = false;
            _hostValidator.Reset();
            comboBoxDependsOn.Items.Clear();
            comboBoxDependsOn.Items.AddRange(new[] { "None"}.Concat<object>(EncryptedSettings.Instance.Hosts.OrderBy(h => h.Name)).ToArray());
            comboBoxDependsOn.SelectedIndex = 0;
            
            resetAddTunnelGroup();
        }

        private void resetAddTunnelGroup()
        {
            textBoxTunnelName.Text = "";
            textBoxSourcePort.Text = "";
            textBoxDestHost.Text = "";
            textBoxDestPort.Text = "";
            radioButtonLocal.Checked = true;
            _tunnelValidator.Reset();
        }

        #region Tunnels

        private void radioButtonDynamic_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDynamic.Checked)
            {
                textBoxDestHost.Text = "";
                textBoxDestPort.Text = "";
                textBoxDestHost.Enabled = false;
                textBoxDestPort.Enabled = false;
            } else
            {
                textBoxDestHost.Enabled = true;
                textBoxDestPort.Enabled = true;
            }
        }

        private void buttonAddTunnel_Click(object sender, EventArgs e)
        {
            if (!_tunnelValidator.ValidateControls()) return;

            var name = textBoxTunnelName.Text;
            var srcPort = textBoxSourcePort.Text;
            var dstHost = textBoxDestHost.Text;
            var dstPort = textBoxDestPort.Text;
            var tunnelType = radioButtonLocal.Checked
                                 ? TunnelType.Local
                                 : (radioButtonRemote.Checked ? TunnelType.Remote : TunnelType.Dynamic);

            var tunnel = new TunnelInfo {Name = name, LocalPort = srcPort, RemoteHostname = dstHost, RemotePort = dstPort, Type = tunnelType};

            listBoxTunnels.Items.Add(tunnel);
            _currentHost.Tunnels.Add(tunnel);
            resetAddTunnelGroup();
        }

        private void buttonRemoveTunnel_Click(object sender, EventArgs e)
        {
            var tunnel = listBoxTunnels.SelectedItem as TunnelInfo;
            if (tunnel == null) return;

            _currentHost.Tunnels.Remove(tunnel);
            listBoxTunnels.Items.Remove(tunnel);
            textBoxTunnelName.Text = tunnel.Name;
            textBoxSourcePort.Text = tunnel.LocalPort;
            textBoxDestHost.Text = tunnel.RemoteHostname;
            textBoxDestPort.Text = tunnel.RemotePort;
            switch (tunnel.Type)
            {
            case TunnelType.Local:
                radioButtonLocal.Checked = true;
                break;
            case TunnelType.Remote:
                radioButtonRemote.Checked = true;
                break;
            case TunnelType.Dynamic:
                radioButtonDynamic.Checked = true;
                break;
            }
        }

        private void listBoxTunnels_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tunnel = listBoxTunnels.SelectedItem as TunnelInfo;
            buttonRemoveTunnel.Enabled = tunnel != null;
        }

        private void listBoxTunnels_DrawItem(object sender, DrawItemEventArgs e)
        {
            var text = listBoxTunnels.Items[e.Index].ToString();

            e.DrawBackground();

            // Draw the current item text based on the current Font and the custom brush settings.
            var rect = e.Bounds;
            rect.Inflate(-5, 0);
            e.Graphics.DrawString(text, e.Font, new SolidBrush(e.ForeColor), rect,
                                  new StringFormat {Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Far});

            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        #endregion
    }
}
