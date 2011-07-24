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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var dt = new DataTable();
            dt.Columns.Add("statusIcon", typeof(Image));
            dt.Columns.Add("hostname");
            dt.Columns.Add("status");
            hgwStatusIconColumn.DataPropertyName = "statusIcon";
            hgwHostnameColumn.DataPropertyName = "hostname";
            hgwStatusColumn.DataPropertyName = "status";
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
