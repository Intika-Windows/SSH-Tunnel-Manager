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
        private const string HgwIdColumnName = "hgwIdColumn";
        private const string HgwStatusIconColumnName = "hgwStatusIconColumn";
        private const string HgwHostnameColumnName = "hgwHostnameColumn";
        private const string HgwStatusColumnName = "hgwStatusColumn";

        public MainForm()
        {
            InitializeComponent();

            hgwIdColumn.DataPropertyName = HgwIdColumnName;
            hgwStatusIconColumn.DataPropertyName = HgwStatusIconColumnName;
            hgwHostnameColumn.DataPropertyName = HgwHostnameColumnName;
            hgwStatusColumn.DataPropertyName = HgwStatusColumnName;

            var hostsManager = new HostsManager();

            var dt = new DataTable();
            dt.Columns.Add(HgwIdColumnName);
            dt.Columns.Add(HgwStatusIconColumnName, typeof(Image));
            dt.Columns.Add(HgwHostnameColumnName);
            dt.Columns.Add(HgwStatusColumnName);
            
            dt.Rows.Add(Resources.tick_circle, "hostname1", "status1");
            dt.Rows.Add(Resources.server_up, "hostname2", "status2");
            dt.Rows.Add(Resources.server_up, "hostname3", "status3");
            hostsGridView.DataSource = dt;
        }

        private void hostsGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            hostsGridView.Rows[e.RowIndex].Selected = true;
            e.ContextMenuStrip = contextMenuStripHost;
        }
    }
}
