using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PuttyManager.Business;
using PuttyManager.Domain;
using PuttyManager.Ext.BLW;
using PuttyManagerGui.Properties;

namespace PuttyManagerGui
{
    public partial class MainForm : Form
    {
        /*private const string HgwStatusIconColumnName = "hgwStatusIconColumn";
        private const string HgwNameColumnName = "hgwNameColumn";
        private const string HgwUsernameColumnName = "hgwUsernameColumn";
        private const string HgwHostnameColumnName = "hgwHostnameColumn";
        private const string HgwStatusColumnName = "hgwStatusColumn";
        private const string HgwDependsOnColumnName = "hgwDependsOnColumn";*/

        private readonly HostsManager<HostViewModel> _hostsManager = new HostsManager<HostViewModel>();
        //private DataTable _dataTableHosts;
        private readonly BindingSource _bindingSource;

        public MainForm()
        {
            InitializeComponent();

            /*hgwStatusIconColumn.DataPropertyName = HgwStatusIconColumnName;
            hgwNameColumn.DataPropertyName = HgwNameColumnName;
            hgwUsernameColumn.DataPropertyName = HgwUsernameColumnName;
            hgwHostnameColumn.DataPropertyName = HgwHostnameColumnName;
            hgwStatusColumn.DataPropertyName = HgwStatusColumnName;
            hgwDependsOnColumn.DataPropertyName = HgwDependsOnColumnName;

            fillHostsTable();
            _hostsManager.Hosts.CollectionChanged += hostsCollectionChanged;*/

            _bindingSource = new BindingSource(_hostsManager, "Hosts");
            
            hostsGridView.AutoGenerateColumns = false;
            hgwStatusIconColumn.DataPropertyName = "StatusIcon";
            hgwNameColumn.DataPropertyName = "Name";
            hgwUsernameColumn.DataPropertyName = "Username";
            hgwHostnameColumn.DataPropertyName = "Hostname";
            hgwStatusColumn.DataPropertyName = "Status";
            hgwDependsOnColumn.DataPropertyName = "DependsOn";
            hostsGridView.DataSource = _bindingSource;
            
            treeViewFilter.ExpandAll();
            treeViewFilter.SelectedNode = treeViewFilter.Nodes[0];
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

        private void hostsGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            hostsGridView.Rows[e.RowIndex].Selected = true;
            e.ContextMenuStrip = contextMenuStripHost;
        }

        private void toolStripButtonAddHost_Click(object sender, EventArgs e)
        {
            addHost();
        }

        private void toolStripMenuItemRemoveHost_Click(object sender, EventArgs e)
        {
            removeHost();
        }

        private void toolStripButtonRemoveHost_Click(object sender, EventArgs e)
        {
            removeHost();
        }

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

        private void addHost()
        {
            var hd = new HostDialog(HostDialog.EMode.AddHost, _hostsManager.HostInfoList)
                         {
                             StartupDependsOn = selectedHostInfo()
                         };
            hd.ShowDialog(this);
            foreach (var host in hd.CreatedHosts)
            {
                _bindingSource.Add(new ObjectView<HostViewModel>(new HostViewModel(new Host(host)), _hostsManager.Hosts));
            }
        }

        private void editHost(HostViewModel host)
        {
            var hd = new HostDialog(HostDialog.EMode.EditHost, _hostsManager.HostInfoList) {Host = host.Model.Info};
            hd.ShowDialog(this);

            var dependentHosts =
                _hostsManager.Hosts.Cast<ObjectView<HostViewModel>>().Select(ov => ov.Object).
                Where(m => m.Model.Info.DependsOn == host.Model.Info);
            foreach (var index in dependentHosts.Select(dependentHost => _bindingSource.IndexOf(dependentHost)))
            {
                _bindingSource.ResetItem(index);
            }

            var index2 = _bindingSource.IndexOf(host);
            _bindingSource.ResetItem(index2);
        }

        private void removeHost()
        {
            var host = selectedHostViewModel();
            var hosts = _hostsManager.DependentHosts(host);

            if (hosts.Count > 0)
            {
                var res1 = MessageBox.Show(this, string.Format(@"Host '{0}' have following dependencies:{1}{1}{2}{1}{1}Are you sure you want to remove the selected host and this dependencies?", 
                    host.Name, Environment.NewLine, string.Join(Environment.NewLine, hosts.Select(h => h.Name))), 
                    Util.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res1 == DialogResult.No)
                    return;

                _bindingSource.Remove(host);
                foreach (var host1 in hosts)
                {
                    _bindingSource.Remove(host1);
                }
            } else
            {
                var res2 = MessageBox.Show(this, string.Format(@"Are you sure you want to remove host '{0}'?", host.Name),
                    Util.AssemblyTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res2 == DialogResult.No)
                    return;

                _bindingSource.Remove(host);
            }
        }

        private void toolStripButtonEditHost_Click(object sender, EventArgs e)
        {
            editHost(selectedHostViewModel());
        }

        private void treeViewFilter_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (int.Parse(e.Node.Tag.ToString()))
            {
            case -1:
                _hostsManager.Hosts.RemoveFilter();
                break;
            case 0:
                _hostsManager.Hosts.ApplyFilter(m => m.Model.Status == HostStatus.Disabled);
                break;
            case 1:
                _hostsManager.Hosts.ApplyFilter(m => m.Model.Status == HostStatus.Stopped);
                break;
            case 2:
                _hostsManager.Hosts.ApplyFilter(m => m.Model.Status == HostStatus.Unknown);
                break;
            case 3:
                _hostsManager.Hosts.ApplyFilter(m => m.Model.Status == HostStatus.Started);
                break;
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

        private void toolStripMenuItemEditHost_Click(object sender, EventArgs e)
        {
            editHost(selectedHostViewModel());
        }
    }
}
