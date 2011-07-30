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
        private HostInfo _startupDependsOn;
        private readonly List<HostInfo> _createdHosts = new List<HostInfo>();
        private Label _labelRecentlyAdded;
        private bool _modified;
        private List<HostInfo> _committedHosts;

        public enum EMode
        {
            AddHost,
            EditHost
        }

        public HostDialog(EMode mode, List<HostInfo> committedHosts)
        {
            if (committedHosts == null) throw new ArgumentNullException("committedHosts");

            InitializeComponent();
            _committedHosts = committedHosts;
            Mode = mode;

            // validators
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
            // style for selected mode
            if (mode == EMode.AddHost)
            {
                flowLayoutPanelAddHost.Visible = true;
                flowLayoutPanelEditHost.Visible = false;
                AcceptButton = buttonAddHost;
                CancelButton = buttonClose;
            }
            else
            {
                flowLayoutPanelAddHost.Visible = false;
                flowLayoutPanelEditHost.Visible = true;
                AcceptButton = buttonOk;
                CancelButton = buttonCancel;
            }
            // modified check
            textBoxName.TextChanged += delegate { Modified = true; };
            textBoxHostname.TextChanged += delegate { Modified = true; };
            textBoxPort.TextChanged += delegate { Modified = true; };
            textBoxLogin.TextChanged += delegate { Modified = true; };
            textBoxPassword.TextChanged += delegate { Modified = true; };
            comboBoxDependsOn.SelectedIndexChanged += delegate { Modified = true; };
        }

        #region Validators

        private bool validateAlias(Control control, string text)
        {
            if (_tunnelValidator.ValidateNotNullOrWhitespaces(control, text))
            {
                var alias = text;

                var aliases = _committedHosts.Where(h => h != _currentHost).Select(h => h.Name).ToList();

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

                var aliases = _committedHosts.Where(h => h != _currentHost).SelectMany(h => h.Tunnels).Select(t => t.Name).Concat(
                    tunnels().Select(t => t.Name)).ToList();

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

                    var ports = _committedHosts.Where(h => h != _currentHost).SelectMany(h => h.Tunnels).Select(t => t.LocalPort).Concat(
                                tunnels().Select(t => t.LocalPort)).ToList();

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

        public EMode Mode { get; private set; }

        public HostInfo StartupDependsOn
        {
            get { return _startupDependsOn; }
            set
            {
                if (Mode != EMode.AddHost)
                    throw new InvalidOperationException("Only allowed in AddHost mode.");
                _startupDependsOn = value;
            }
        }

        public HostInfo Host
        {
            get { return _currentHost; }
            set
            {
                if (Mode != EMode.EditHost)
                    throw new InvalidOperationException("Only allowed in EditHost mode.");
                _currentHost = value;
            }
        }

        public HostInfo[] CreatedHosts
        {
            get { return _createdHosts.ToArray(); }
        }

        private bool Modified
        {
            get { return _modified; }
            set
            {
                _modified = value;
                buttonApply.Enabled = _modified;
            }
        }

        private void HostDialog_Load(object sender, EventArgs e)
        {
            reset();
            _createdHosts.Clear();
            Modified = false;
        }

        #region Add host

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
            formToHost();

            /*EncryptedSettings.Instance.Hosts.Add(_currentHost);
            EncryptedSettings.Instance.Save();*/
            _createdHosts.Add(_currentHost);

            // Update gui and reset
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

        #endregion

        private void reset()
        {
            if (Mode == EMode.AddHost)
            {
                _currentHost = new HostInfo();

                textBoxName.Text = "";
                textBoxHostname.Text = "";
                textBoxPort.Text = "";
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";

                comboBoxDependsOn.Items.Clear();
                var hosts = _committedHosts.Where(h => h != _currentHost && !h.DeepDependsOn(_currentHost)).OrderBy(h => h.Name);
                comboBoxDependsOn.Items.AddRange(new[] { "None" }.Concat<object>(hosts).ToArray());
                if (StartupDependsOn != null)
                    comboBoxDependsOn.SelectedItem = StartupDependsOn;
                else
                    comboBoxDependsOn.SelectedIndex = 0;

                tunnelsGridView.Rows.Clear();
                buttonRemoveTunnel.Enabled = tunnelsGridView.SelectedRows.Count > 0;

                _hostValidator.Reset();
                resetAddTunnelGroup();
                Text = @"Add New Host - SSH Tunnel Manager";
            }
            else // Edit mode
            {
                hostToForm();
                Text = @"Edit Host - SSH Tunnel Manager";
            }
        }

        private void hostToForm()
        {
            if (_currentHost == null)
                throw new FormatException(@"Host has not been set correctly.");

            textBoxName.Text = _currentHost.Name;
            textBoxHostname.Text = _currentHost.Hostname;
            textBoxPort.Text = _currentHost.Port;
            textBoxLogin.Text = _currentHost.Username;
            textBoxPassword.Text = _currentHost.Password;

            comboBoxDependsOn.Items.Clear();
            var hosts = _committedHosts.Where(h => h != _currentHost && !h.DeepDependsOn(_currentHost)).OrderBy(h => h.Name);
            comboBoxDependsOn.Items.AddRange(new[] { "None" }.Concat<object>(hosts).ToArray());
            if (_currentHost.DependsOn == null)
            {
                comboBoxDependsOn.SelectedIndex = 0;
            }
            else
            {
                comboBoxDependsOn.SelectedItem = _currentHost.DependsOn;
            }

            tunnelsGridView.Rows.Clear();
            foreach (var tunnel in _currentHost.Tunnels)
            {
                addTunnel(tunnel);
            }
            buttonRemoveTunnel.Enabled = tunnelsGridView.SelectedRows.Count > 0;

            _hostValidator.Reset();
            resetAddTunnelGroup();
        }

        private void formToHost()
        {
            _currentHost.Name = textBoxName.Text.Trim();
            _currentHost.Hostname = textBoxHostname.Text.Trim();
            _currentHost.Port = textBoxPort.Text.Trim();
            _currentHost.Username = textBoxLogin.Text.Trim();
            _currentHost.Password = textBoxPassword.Text.Trim();
            var dependsOnHost = comboBoxDependsOn.SelectedItem as HostInfo;
            if (dependsOnHost != null)
            {
                _currentHost.DependsOn = dependsOnHost;
            }

            _currentHost.Tunnels.Clear();
            //_currentHost.Tunnels.AddRange(listBoxTunnels.Items.Cast<TunnelInfo>());
            _currentHost.Tunnels.AddRange(tunnels());
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

        private void addTunnel(TunnelInfo tunnel)
        {
            var row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell {Value = tunnel.Name});
            row.Cells.Add(new DataGridViewTextBoxCell {Value = tunnel.Type.ToString()[0]});
            row.Cells.Add(new DataGridViewTextBoxCell {Value = tunnel.LocalPort});
            row.Cells.Add(new DataGridViewTextBoxCell {Value = tunnel.RemoteHostname});
            row.Cells.Add(new DataGridViewTextBoxCell {Value = tunnel.RemotePort});
            row.Tag = tunnel;
            tunnelsGridView.Rows.Add(row);
        }

        private TunnelInfo selectedTunnel()
        {
            var tunnel = tunnelsGridView.SelectedRows.Cast<DataGridViewRow>().Select(r => r.Tag as TunnelInfo).FirstOrDefault();
            return tunnel;
        }

        private List<TunnelInfo> tunnels()
        {
            return tunnelsGridView.Rows.Cast<DataGridViewRow>().Select(r => (TunnelInfo) r.Tag).ToList();
        }

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

            addTunnel(tunnel);
            Modified = true;
            resetAddTunnelGroup();
        }

        private void buttonRemoveTunnel_Click(object sender, EventArgs e)
        {
            var row = tunnelsGridView.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (row == null) return;
            var tunnel = row.Tag as TunnelInfo;
            if (tunnel == null) return;

            //listBoxTunnels.Items.Remove(tunnel);
            tunnelsGridView.Rows.Remove(row);
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
            Modified = true;
        }

        private void tunnelsGridView_SelectionChanged(object sender, EventArgs e)
        {
            buttonRemoveTunnel.Enabled = selectedTunnel() != null;
        }

        #endregion

        #region Edit host

        private void buttonApply_Click(object sender, EventArgs e)
        {
            formToHost();
            Modified = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            formToHost();
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion
    }
}
