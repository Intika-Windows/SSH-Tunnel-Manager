using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using SSHTunnelManager.Business;
using SSHTunnelManager.Domain;
using SSHTunnelManager.Ext.BLW;
using SSHTunnelManager.Util;
using SSHTunnelManagerGUI.Properties;
using log4net.Core;

namespace SSHTunnelManagerGUI.Forms
{
    public partial class MainForm : TrayForm
    {
        private readonly HostsManager<HostViewModel> _hostsManager;
        private readonly BindingSource _bindingSource;
        private static readonly Color _darkRedColor = Color.FromArgb(165, 0, 0);
        private readonly string _titleFilename;
        private bool _savePasswordRequested = false;
        private bool _saveNewPassword;

        private bool _modified;

        public MainForm(HostsManager<HostViewModel> manager)
        {
            if (manager == null) throw new ArgumentNullException("manager");
            InitializeComponent();
            centerMe();

            _titleFilename = Path.GetFileName(manager.Filename);
            Modified = false;

            _hostsManager = manager;
            foreach (var host in _hostsManager.Hosts.Cast<ObjectView<HostViewModel>>().Select(o => o.Object))
            {
                host.StatusChanged += onHostStatusChanged;
            }
            _bindingSource = new BindingSource(_hostsManager, "Hosts");
            
            hostsGridView.AutoGenerateColumns = false;
            hgwStatusIconColumn.DataPropertyName = "StatusIcon";
            hgwNameColumn.DataPropertyName = "Name";
            hgwUsernameColumn.DataPropertyName = "Username";
            hgwHostnameColumn.DataPropertyName = "Hostname";
            hgwStatusColumn.DataPropertyName = "Status";
            hgwDependsOnColumn.DataPropertyName = "DependsOn";
            hostsGridView.DataSource = _bindingSource;
            _bindingSource.CurrentItemChanged += delegate { updateCurrentHostDetails(); };
            updateCurrentHostDetails();
            
            treeViewFilter.ExpandAll();
            treeViewFilter.SelectedNode = treeViewFilter.Nodes[0];
            ActiveControl = hostsGridView;

            DelegateAppender.SyncObject = this;
            DelegateAppender.OnAppend += onLogAppended;
        }

        public bool ChangeSourceRequested { get; private set; }

        private bool Modified
        {
            get { return _modified; }
            set
            {
                var star = value ? "*" : "";
                Text = string.Concat(_titleFilename, star, @" - ", Util.AssemblyTitle);
                toolStripButtonSave.Enabled = value;
                saveToolStripMenuItem.Enabled = value;

                _modified = value;
            }
        }

        private void centerMe()
        {
            int boundWidth = Screen.PrimaryScreen.Bounds.Width;
            int boundHeight = Screen.PrimaryScreen.Bounds.Height;
            int x = boundWidth - Width;
            int y = boundHeight - Height;
            Location = new Point(x / 2, y / 2);
        }

        private void updateCurrentHostDetails()
        {
            var ov = _bindingSource.Current as ObjectView<HostViewModel>;
            if (ov == null)
            {
                splitContainerV1.Panel2Collapsed = true;
                toolStripButtonStart.Enabled = false;
                startToolStripMenuItem.Enabled = false;
                toolStripButtonStop.Enabled = false;
                stopToolStripMenuItem.Enabled = false;
                toolStripMenuItemEditHost.Enabled = false;
                toolStripButtonEditHost.Enabled = false;
                editHostToolStripMenuItem.Enabled = false;
                toolStripButtonRemoveHost.Enabled = false;
                removeHostToolStripMenuItem.Enabled = false;
                return;
            }

            var h = ov.Object;
            // bottom split panel
            // general
            splitContainerV1.Panel2Collapsed = false;
            labelUniqName.Text = h.Name;
            labelUsername.Text = h.Username;
            labelHost.Text = h.Hostname;
            labelStatus.Text = h.Status;
            labelStatus.ForeColor = h.StatusColor;
            labelDependsOn.Text = string.IsNullOrWhiteSpace(h.DependsOn) ? "-" : h.DependsOn;
            tunnelsGridView.Rows.Clear();
            foreach (var tunnel in h.Model.Info.Tunnels)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = tunnel.Name });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = tunnel.Type.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = tunnel.LocalPort });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = tunnel.RemoteHostname });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = tunnel.RemotePort });
                row.Tag = tunnel;
                tunnelsGridView.Rows.Add(row);
            }
            // log
            listViewLog.Items.Clear();
            listViewLog.Items.AddRange(h.Model.Info.EventLog.Select(e => new ListViewItem(e)).ToArray());
            listViewLog.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            if (listViewLog.Items.Count > 0)
                listViewLog.TopItem = listViewLog.Items[listViewLog.Items.Count - 1];
            // menus
            bool hostStopped = h.Model.Link.Status == ELinkStatus.Stopped;
            toolStripButtonStart.Enabled = hostStopped;
            toolStripButtonStop.Enabled = !hostStopped;
            startToolStripMenuItem.Enabled = hostStopped;
            stopToolStripMenuItem.Enabled = !hostStopped;
            // edit buttons
            bool canEdit = hostStopped;
            toolStripMenuItemEditHost.Enabled = canEdit;
            toolStripButtonEditHost.Enabled = canEdit;
            editHostToolStripMenuItem.Enabled = canEdit;
            // remove buttons
            toolStripButtonRemoveHost.Enabled = true;
            removeHostToolStripMenuItem.Enabled = true;
        }

        /*private void fillHostsTable()
        {
            _dataTableHosts = new DataTable();
            _dataTableHosts.Columns.Add(HgwStatusIconColumnName, typeof(Image));
            _dataTableHosts.Columns.Add(HgwNameColumnName);
            _dataTableHosts.Columns.Add(HgwUsernameColumnName);
            _dataTableHosts.Columns.Add(HgwHostnameColumnName);
            _dataTableHosts.Columns.Add(HgwStatusColumnName);
            _dataTableHosts.Columns.Add(HgwDependsOnColumnName);
            hostsGridView.DataSource = _dataTableHosts;

            foreach (var host in _hostsManager.Hosts)
            {
                var row = _dataTableHosts.NewRow();
                row[HgwStatusIconColumnName] = statusIcon(host.Status);
                row[HgwNameColumnName] = host.Info.Name;
                row[HgwUsernameColumnName] = host.Info.Username;
                row[HgwHostnameColumnName] = host.Info.HostAndPort;
                row[HgwStatusColumnName] = host.Status;
                row[HgwDependsOnColumnName] = host.Info.DependsOnStr;
                _dataTableHosts.Rows.Add(row);
            }
        }

        private void hostsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (_dataTableHosts == null)
                return;

            switch (e.Action)
            {
            case NotifyCollectionChangedAction.Add:
                var newHosts = e.NewItems.Cast<Host>();
                foreach (var host in newHosts)
                {
                    var row = _dataTableHosts.NewRow();
                    row[HgwStatusIconColumnName] = statusIcon(host.Status);
                    row[HgwNameColumnName] = host.Info.Name;
                    row[HgwUsernameColumnName] = host.Info.Username;
                    row[HgwHostnameColumnName] = host.Info.HostAndPort;
                    row[HgwStatusColumnName] = host.Status;
                    row[HgwDependsOnColumnName] = host.Info.DependsOnStr;
                    _dataTableHosts.Rows.Add(row);
                }
                break;
            case NotifyCollectionChangedAction.Remove:
                break;
            case NotifyCollectionChangedAction.Replace:
                break;
            case NotifyCollectionChangedAction.Move:
                break;
            case NotifyCollectionChangedAction.Reset:
                break;
            default:
                throw new ArgumentOutOfRangeException();
            }
        }*/

        private HostInfo selectedHostInfo()
        {
            var hostvm = selectedHostViewModel();
            return hostvm != null ? hostvm.Model.Info : null;
        }

        private HostViewModel selectedHostViewModel()
        {
            var row = hostsGridView.SelectedRows.Cast<DataGridViewRow>().FirstOrDefault();
            if (row != null)
            {
                var hname = row.Cells[hgwNameColumn.Name].Value.ToString();
                var selectedHost = _hostsManager.Hosts.Cast<ObjectView<HostViewModel>>().Select(h => h.Object).First(m => m.Name == hname);
                return selectedHost;
            }
            return null;
        }

        private HostViewModel currentHostViewModel()
        {
            if (_bindingSource.Current == null)
                return null;
            return ((ObjectView<HostViewModel>) _bindingSource.Current).Object;
        }

        private void updateHost(HostViewModel host)
        {
            var index2 = _bindingSource.IndexOf(host);
            _bindingSource.ResetItem(index2);
        }

        private bool askForSave()
        {
            if (!Modified)
                return true;

            DialogResult res = MessageBox.Show(this, @"Storage was modified, save before closing?",
                                               Util.AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (res)
            {
            case DialogResult.Yes:
                save();
                break;
            case DialogResult.No:
                // exit without save
                break;
            case DialogResult.Cancel:
                // cancel exit
                return false;
            }
            return true;
        }

        private static void startHostAndParentHosts(HostViewModel viewmodel, List<Host> depList)
        {
            foreach (var h1 in depList)
            {
                if (h1.Link.Status == ELinkStatus.Starting)
                {
                    h1.Link.Stop();
                    if (!h1.Link.WaitForStop())
                    {
                        MessageBox.Show(
                            string.Format(
                                "STOP action for host '{0}' timed out. Terminating actions chain.",
                                h1.Info.Name),
                            Util.AssemblyTitle, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
                if (h1.Link.Status == ELinkStatus.Stopped)
                {
                    h1.Link.AsyncStart();
                    if (!h1.Link.WaitForStart())
                    {
                        MessageBox.Show(
                            string.Format(
                                "START action for host '{0}' timed out. Terminating actions chain.",
                                h1.Info.Name),
                            Util.AssemblyTitle, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            viewmodel.Model.Link.AsyncStart();
        }

        private void updateFilter(TreeNode node)
        {
            switch (int.Parse(node.Tag.ToString()))
            {
            case -1:
                _hostsManager.Hosts.RemoveFilter();
                break;
            case 1:
                _hostsManager.Hosts.ApplyFilter(m => m.Model.Link.Status == ELinkStatus.Stopped);
                break;
            case 2:
                _hostsManager.Hosts.ApplyFilter(m => m.Model.Link.Status == ELinkStatus.Starting);
                break;
            case 3:
                _hostsManager.Hosts.ApplyFilter(m => m.Model.Link.Status == ELinkStatus.Waiting);
                break;
            case 4:
                _hostsManager.Hosts.ApplyFilter(m => m.Model.Link.Status == ELinkStatus.Started || m.Model.Link.Status == ELinkStatus.StartedWithWarnings);
                break;
            }
        }

        #region Commands

        private void addHost()
        {
            var hd = new HostDialog(HostDialog.EMode.AddHost, _hostsManager.HostInfoList)
                         {
                             StartupDependsOn = selectedHostInfo()
                         };
            hd.ShowDialog(this);
            foreach (var host in hd.CreatedHosts)
            {
                var hvm = _hostsManager.AddHost(host);
                hvm.StatusChanged += onHostStatusChanged;
            }
            if (hd.CreatedHosts.Length > 0)
            {
                Modified = true;
            }
        }

        private void editHost(HostViewModel host)
        {
            if (host.Model.Link.Status != ELinkStatus.Stopped)
                return;

            var hd = new HostDialog(HostDialog.EMode.EditHost, _hostsManager.HostInfoList) {Host = host.Model.Info};
            hd.ShowDialog(this);

            var dependentHosts =
                _hostsManager.Hosts.Cast<ObjectView<HostViewModel>>().Select(ov => ov.Object).
                Where(m => m.Model.Info.DependsOn == host.Model.Info);
            foreach (var index in dependentHosts.Select(dependentHost => _bindingSource.IndexOf(dependentHost)))
            {
                _bindingSource.ResetItem(index);
            }

            updateHost(host);
            Modified = true;
        }

        private void removeHost()
        {
            var host = selectedHostViewModel();
            if (host == null)
                return;
            var depHostsDeep = _hostsManager.DependentHosts(host, true);
            var depHosts = _hostsManager.DependentHosts(host, false);

            if (depHosts.Count > 0)
            {
                var res1 = MessageBox.Show(this, string.Format(@"Following hosts depends on host '{0}':{1}{1}{2}{1}{1}Are you sure you want to remove the selected host?", 
                    host.Name, Environment.NewLine, string.Join(Environment.NewLine, depHostsDeep.Select(h => h.Name))), 
                    Util.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res1 == DialogResult.No)
                    return;

                new Thread(delegate()
                               {
                                   host.Model.Link.Stop();
                                   host.Model.Link.WaitForStop();
                               }).Start();

                _bindingSource.Remove(host);
                host.StatusChanged -= onHostStatusChanged;

                foreach (var host1 in depHosts)
                {
                    host1.Model.Info.DependsOn = null;
                    /*_bindingSource.Remove(host1);
                    host1.StatusChanged -= onHostStatusChanged;*/
                }
            } else
            {
                var res2 = MessageBox.Show(this, string.Format(@"Are you sure you want to remove host '{0}'?", host.Name),
                    Util.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res2 == DialogResult.No)
                    return;

                new Thread(delegate()
                               {
                                   host.Model.Link.Stop();
                                   host.Model.Link.WaitForStop();
                               }).Start();

                _bindingSource.Remove(host);
                host.StatusChanged -= onHostStatusChanged;
            }
            Modified = true;
        }

        private void startHost()
        {
            var viewmodel = ((ObjectView<HostViewModel>) _bindingSource.Current).Object;
            var host = viewmodel.Model.Info;

            if (viewmodel.Model.Link.Status != ELinkStatus.Stopped)
                return;

            // building dependency list
            var depList = new List<Host>();
            for (var parent = host.DependsOn; parent != null; parent = parent.DependsOn)
            {
                var h =
                    _hostsManager.Hosts.Cast<ObjectView<HostViewModel>>().Select(v => v.Object.Model).First(
                        m => m.Info == parent);
                depList.Insert(0, h);
            }

            if (depList.All(h => h.Link.Status == ELinkStatus.Started || h.Link.Status == ELinkStatus.StartedWithWarnings))
            {
                // All hosts is started or started with warnings
                viewmodel.Model.Link.AsyncStart();
            }
            else
            {
                var result = MessageBox.Show(this, string.Format(
                    "Some hosts what host '{0}' depends on are down. Start recursively?",
                    host.Name), Util.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                Thread t = new Thread(() => startHostAndParentHosts(viewmodel, depList));
                t.Start();
            }
        }

        private void stopHost()
        {
            ((ObjectView<HostViewModel>) _bindingSource.Current).Object.Model.Link.Stop();
        }

        private void startPutty()
        {
            var viewmodel = ((ObjectView<HostViewModel>)_bindingSource.Current).Object;
            var host = viewmodel.Model.Info;

            Process.Start(Path.Combine(Application.StartupPath, "putty.exe"), PuttyLink.PuttyArguments(host, true));
        }

        private void exit()
        {
            if (!askForSave())
                return;

            var activeHosts = _hostsManager.Hosts.Cast<ObjectView<HostViewModel>>().Where(
                o => o.Object.Model.Link.Status != ELinkStatus.Stopped).Select(o => o.Object.Model).ToList();
            foreach (var host in activeHosts)
            {
                host.Link.Stop();
            }
            ReallyClose();
        }

        private void exitKeepLinks()
        {
            if (!askForSave())
                return;

            ReallyClose();
        }

        private void save()
        {
            if (!Modified)
                return;
            _hostsManager.Save();
            if (_savePasswordRequested)
            {
                Settings.Default.EncryptedStoragePassword = _saveNewPassword ? _hostsManager.Password : null;
                Settings.Default.Save();
                _savePasswordRequested = false;
            }
            Modified = false;
        }

        #endregion

        #region My Events

        private void onLogAppended(object sender, LogAppendedEventArgs e)
        {
            object o;
            if (!e.Properties.TryGetValue("Host", out o))
            {
                return;
            }

            var h = (HostInfo) o;
            h.AddEventToLog(e.AppendedData);
            if (_bindingSource.Current != null && 
                ((ObjectView<HostViewModel>)_bindingSource.Current).Object.Model.Info == h)
            {
                // this is current Host
                if (listViewLog.Items.Count >= HostInfo.EventLogMaxSize)
                {
                    listViewLog.Items.RemoveAt(0);
                }
                listViewLog.Items.Add(e.AppendedData);
                listViewLog.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewLog.TopItem = listViewLog.Items[listViewLog.Items.Count - 1];
            }
        }

        private void onHostStatusChanged(object sender, EventArgs e)
        {
            // This handler executing not in UI thread.
            Invoke((Action)delegate
                               {
                                   var hvm = (HostViewModel)sender;
                                   updateHost(hvm);
                                   if (_bindingSource.Current == hvm)
                                   {
                                       updateCurrentHostDetails();
                                   }
                                   updateFilter(treeViewFilter.SelectedNode);
                                   if (hvm.Model.Link.Status == ELinkStatus.Stopped && !string.IsNullOrEmpty(hvm.Model.Link.LastStartError))
                                   {
                                       // host stopped with error
                                       TrayIcon.ShowBalloonTip(2000, Util.AssemblyTitle, string.Format("[{0}] {1}", hvm.Name, hvm.Model.Link.LastStartError), ToolTipIcon.Error);
                                   }
                               });
        }

        #endregion

        #region Hosts Context Menu Events

        private void toolStripMenuItemEditHost_Click(object sender, EventArgs e)
        {
            editHost(selectedHostViewModel());
        }

        private void toolStripMenuItemRemoveHost_Click(object sender, EventArgs e)
        {
            removeHost();
        }

        #endregion

        #region ToolBar Events

        private void toolStripButtonAddHost_Click(object sender, EventArgs e)
        {
            addHost();
        }

        private void toolStripButtonRemoveHost_Click(object sender, EventArgs e)
        {
            removeHost();
        }

        private void toolStripButtonEditHost_Click(object sender, EventArgs e)
        {
            editHost(selectedHostViewModel());
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            startHost();
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            stopHost();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            save();
        }

        #endregion

        #region Main Menu Events

        private void addHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addHost();
        }

        private void editHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editHost(selectedHostViewModel());
        }

        private void removeHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeHost();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startHost();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopHost();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void keepConnectionsExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitKeepLinks();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var savePass = !string.IsNullOrEmpty(Settings.Default.EncryptedStoragePassword);
            var pwdDlg = new ChangePasswordDialog(savePass);
            var res = pwdDlg.ShowDialog(this);
            if (res == DialogResult.Cancel)
                return;

            _savePasswordRequested = true;
            _hostsManager.Password = pwdDlg.Password;
            savePass = pwdDlg.SavePassword;
            _saveNewPassword = savePass;
            Modified = true;
        }

        private void changeStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSourceRequested = true;
            exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog(this);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OptionsDialog().ShowDialog(this);
            // update config
            _hostsManager.Config.RestartEnabled = Settings.Default.Config_RestartEnabled;
            _hostsManager.Config.RestartDelay = Settings.Default.Config_RestartDelay;
            _hostsManager.Config.MaxAttemptsCount = Settings.Default.Config_MaxAttemptsCount;
            Logger.SetThresholdForAppender("DelegateAppender", Settings.Default.Config_TraceDebug ? Level.Debug : Level.Info);
        }

        #endregion

        #region Events

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // two options: remove dangerous events what can be triggered after disposing or check 'IsDisposed' inside them. 
            // First option selected, but careful with racing problem.
            // In both events racing problem solving via handling pending events in DoEvents().
            // It processing already running methods (which was started before this code) before start disposing.
            DelegateAppender.OnAppend -= onLogAppended;
            foreach (var host in _hostsManager.Hosts.Cast<ObjectView<HostViewModel>>().Select(o => o.Object))
            {
                host.StatusChanged -= onHostStatusChanged;
            }
            Application.DoEvents();
        }

        private void hostsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (hostsGridView.Columns[e.ColumnIndex].Name == hgwStatusColumn.Name)
            {
                HostViewModel host;
                //if ((host = hostsGridView.Rows[e.RowIndex].Tag as HostViewModel) == null) // buffering
                {
                    var name = hostsGridView.Rows[e.RowIndex].Cells[hgwNameColumn.Name].Value.ToString();
                    host = _hostsManager.Hosts.Cast<ObjectView<HostViewModel>>().Select(v => v.Object).First(m => m.Name == name);
                    hostsGridView.Rows[e.RowIndex].Tag = host;
                }
                e.CellStyle.ForeColor = host.StatusColor;
            }
        }

        private void hostsGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var name = hostsGridView.Rows[e.RowIndex].Cells[hgwNameColumn.Name].Value.ToString();
            var host = _hostsManager.Hosts.Cast<ObjectView<HostViewModel>>().Select(m => m.Object).First(m => m.Name == name);
            
            editHost(host);
        }

        private void hostsGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            _bindingSource.Position = _bindingSource.Find("Name", hostsGridView.Rows[e.RowIndex].Cells[hgwNameColumn.Name].Value.ToString());
            var host = currentHostViewModel();

            var strip = new ContextMenuStrip();
            if (host.Model.Link.Status == ELinkStatus.Stopped)
                strip.Items.Add("Start", Resources.control, delegate { startHost(); });
            else
                strip.Items.Add("Stop", Resources.control_stop_square, delegate { stopHost(); });
            strip.Items.Add("-");
            strip.Items.Add("Start PuTTY...", Resources.icon_16x16_putty, delegate { startPutty(); });
            //strip.Items.Add("Start Windows RDP (mstsc)...", Resources.Remote_desktop_connection_icon16, delegate { startMstsc(); });
            strip.Items.Add("-");
            strip.Items.Add("&Edit...", Resources.server__pencil, toolStripMenuItemEditHost_Click);
            strip.Items.Add("&Remove", Resources.server__minus, toolStripMenuItemRemoveHost_Click);
            e.ContextMenuStrip = strip;
        }

        private void tunnelsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (tunnelsGridView.SelectedRows.Count > 0)
            {
                tunnelsGridView.ClearSelection();
            }
        }

        private void tunnelsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var host = ((ObjectView<HostViewModel>) _bindingSource.Current).Object.Model;
            if (host.Link.Status != ELinkStatus.StartedWithWarnings)
                return;
            var tname = tunnelsGridView.Rows[e.RowIndex].Cells[tgvNameColumn.Name].Value.ToString();
            var result = host.Link.ForwardingResults.FirstOrDefault(p => p.Key.Name == tname);
            if (result.Value == null)
                return;
            if (!result.Value.Success)
            {
                e.CellStyle.ForeColor = _darkRedColor;
            }
        }

        private void treeViewFilter_AfterSelect(object sender, TreeViewEventArgs e)
        {
            updateFilter(e.Node);
        }

        private void listViewLog_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            var item = e.Item.SubItems[e.ColumnIndex];

            e.DrawBackground();
            var text = item.Text;

            Color forecolor;
            if (text.StartsWith("ERROR", StringComparison.CurrentCultureIgnoreCase) ||
                text.StartsWith("FATAL", StringComparison.CurrentCultureIgnoreCase))
            {
                forecolor = _darkRedColor;
            }
            else if (text.StartsWith("WARN", StringComparison.CurrentCultureIgnoreCase))
            {
                forecolor = Color.FromArgb(181, 166, 16);
            }
            else if (text.StartsWith("DEBUG"))
            {
                forecolor = Color.Black;
            }
            else
            {
                forecolor = Color.DarkBlue;
            }
            TextRenderer.DrawText(e.Graphics, item.Text, listViewLog.Font, e.Bounds, forecolor, TextFormatFlags.Left);
            e.DrawFocusRectangle(e.Bounds);
        }

        #endregion
    }
}
