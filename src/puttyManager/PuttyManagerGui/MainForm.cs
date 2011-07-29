using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PuttyManager.Business;
using PuttyManager.Domain;
using PuttyManagerGui.Properties;

namespace PuttyManagerGui
{
    public partial class MainForm : Form
    {
        private const string HgwStatusIconColumnName = "hgwStatusIconColumn";
        private const string HgwNameColumnName = "hgwNameColumn";
        private const string HgwUsernameColumnName = "hgwUsernameColumn";
        private const string HgwHostnameColumnName = "hgwHostnameColumn";
        private const string HgwStatusColumnName = "hgwStatusColumn";
        private const string HgwDependsOnColumnName = "hgwDependsOnColumn";

        private readonly HostsManager _hostsManager = new HostsManager();
        private DataTable _dataTableHosts;

        public MainForm()
        {
            InitializeComponent();

            hgwStatusIconColumn.DataPropertyName = HgwStatusIconColumnName;
            hgwNameColumn.DataPropertyName = HgwNameColumnName;
            hgwUsernameColumn.DataPropertyName = HgwUsernameColumnName;
            hgwHostnameColumn.DataPropertyName = HgwHostnameColumnName;
            hgwStatusColumn.DataPropertyName = HgwStatusColumnName;
            hgwDependsOnColumn.DataPropertyName = HgwDependsOnColumnName;

            fillHostsTable();
        }

        private void fillHostsTable()
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

        private static Bitmap statusIcon(HostStatus status)
        {
            switch (status)
            {
            case HostStatus.Disabled:
                throw new NotImplementedException();
            case HostStatus.Stopped:
                return Resources.control_stop_square;
            case HostStatus.Unknown:
                return Resources.brightness_small;
            case HostStatus.Started:
                return Resources.control;
            default:
                throw new ArgumentOutOfRangeException("status");
            }
        }

        private void hostsGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            hostsGridView.Rows[e.RowIndex].Selected = true;
            e.ContextMenuStrip = contextMenuStripHost;
        }
    }
}
