using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PuttyManager;
using PuttyManager.Business;
using PuttyManager.Domain;
using PuttyManagerGui.Properties;

namespace PuttyManagerGui
{
    public partial class PuttyManagerForm : TrayForm
    {
        private const string WgwDescriptorColumn = "wgwDescriptorColumn";
        private const string WgwStatusColumn = "wgwStatusColumn";
        private const string WgwHwndColumn = "wgwHwndColumn";
        private const string WgwShowColumn = "wgwShowColumn";
        private const string WgwHideColumn = "wgwHideColumn";
        private const string WgwKillColumn = "wgwKillColumn";

        private DataTable _windowsTable;
        private readonly Color ColorInactiveStatus = Color.FromArgb(165, 0, 0);
        private readonly Color ColorActiveStatus = Color.FromArgb(10, 126, 24);

        public PuttyManagerForm()
        {
            InitializeComponent();

            TrayContextMenuStrip.Items.Add(_hideShowToolStripMenuItem);
            TrayContextMenuStrip.Items.Add("-");
            TrayContextMenuStrip.Items.Add(_exitToolStripMenuItem);

            windowsGridView.AutoGenerateColumns = false;
            wgwDescriptorColumn.DataPropertyName = WgwDescriptorColumn;
            wgwStatusColumn.DataPropertyName = WgwStatusColumn;
            wgwHwndColumn.DataPropertyName = WgwHwndColumn;

            // TreeViewHosts
            var imageList = new ImageList();
            imageList.Images.Add(Resources.server_down);
            imageList.Images.Add(Resources.server_up_warnings);
            imageList.Images.Add(Resources.server_up);
            treeViewHosts.ImageList = imageList;

            treeViewHosts.Sorted = true;

            var menu = new ContextMenuStrip();
            var menuItemAddHost = new ToolStripMenuItem(@"Add new host...", Resources.server__plus, toolStripButtonAddHost_Click);
            var menuItemDeleteHost = new ToolStripMenuItem(@"Delete host", Resources.server__minus, toolStripButtonDeleteHost_Click);
            var menuItemDeleteHostRecursive = new ToolStripMenuItem(@"Delete hosts subtree", Resources.servers__minus, toolStripButtonDeleteHostRecursively_Click);
            //var menuItemConnectToHost = new ToolStripMenuItem(@"Connect to host", Resources.servers__minus, toolStripButtonDeleteHostRecursively_Click);
            menu.Opening += (o, e) =>
                                {
                                    menu.Items.Clear();
                                    menu.Items.AddRange(new[]
                                                            {
                                                                menuItemAddHost, 
                                                                menuItemDeleteHost,
                                                                menuItemDeleteHostRecursive
                                                            });
                                    menu.Items.Add("-");
                                    //menu.Items.
                                    e.Cancel = false;
                                };
            treeViewHosts.ContextMenuStrip = menu;

            fillWindowsTable();
            fillHostsTree();
        }

        private void fillHostsTree()
        {
            treeViewHosts.Nodes.Clear();
            treeViewHosts.Sorted = true;
            var hostToNode = new Dictionary<HostInfo, TreeNode>();
            foreach (var host in EncryptedSettings.Instance.Hosts)
            {
                var node = new TreeNode(host.ToString(), 0, 0) {Tag = host};
                if (host.DependsOn != null)
                {
                    hostToNode[host.DependsOn].Nodes.Add(node);
                } else
                {
                    treeViewHosts.Nodes.Add(node);
                }
                hostToNode[host] = node;
            }
            treeViewHosts.ExpandAll();
        }

        private void fillWindowsTable()
        {
            _windowsTable = new DataTable();
            _windowsTable.Columns.Add(WgwDescriptorColumn, typeof(string));
            _windowsTable.Columns.Add(WgwStatusColumn, typeof(string));
            _windowsTable.Columns.Add(WgwHwndColumn, typeof(string));

            foreach (var window in PuttyWindowsManager.GetPuttyWindows())
            {
                var p = window.Process;
                var cl = window.ProcessCommandLine;
                var row = _windowsTable.NewRow();
                row[WgwDescriptorColumn] = window.ToString();
                row[WgwStatusColumn] = window.StatusText;
                row[WgwHwndColumn] = window.Hwnd.ToString();
                _windowsTable.Rows.Add(row);
            }

            windowsGridView.DataSource = _windowsTable;
        }

        private void updateWindowsTable()
        {
            var puttyWindows = PuttyWindowsManager.GetPuttyWindows();

            // Обновление имеющихся строк, добавление новых
            foreach (var window in puttyWindows)
            {
                var hwnd = window.Hwnd.ToString();
                var row = _windowsTable.Rows.Cast<DataRow>().FirstOrDefault(dr => dr[WgwHwndColumn].ToString() == hwnd);
                if (row == null)
                {
                    row = _windowsTable.NewRow();
                    row[WgwDescriptorColumn] = window.ToString();
                    row[WgwStatusColumn] = window.StatusText;
                    row[WgwHwndColumn] = window.Hwnd.ToString();
                    _windowsTable.Rows.Add(row);
                } else
                {
                    row[WgwDescriptorColumn] = window.ToString();
                    row[WgwStatusColumn] = window.StatusText;
                }
            }
            // Удаление отсутствующих
            var deletedRows = _windowsTable.Rows.Cast<DataRow>().Where(dr => !puttyWindows.Any(pw => pw.Hwnd.ToString() == dr[WgwHwndColumn].ToString())).ToArray();
            foreach (var dataRow in deletedRows)
            {
                _windowsTable.Rows.Remove(dataRow);
            }
        }

        private void theTimer_Tick(object sender, EventArgs e)
        {
            updateHostsTree(treeViewHosts.Nodes);

            //if (!autorecoveryToolStripMenuItem.Checked) return;

            /*PuttyWindowsManager.KillInactivePuttyWindows();
            PuttyWindowsManager.AutoRecovery();
            updateWindowsTable();*/
        }

        private void updateHostsTree(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                var host = node.Tag as HostInfo;
                if (host == null)
                    continue;
                switch (host.Link.ConnectionState)
                {
                case PuttyLink.EConnectionState.Inactive:
                    if (node.ImageIndex == 0) return;
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    break;
                case PuttyLink.EConnectionState.Intermediate:
                    if (node.ImageIndex == 1) return;
                    node.ImageIndex = 1;
                    node.SelectedImageIndex = 1;
                    break;
                case PuttyLink.EConnectionState.Active:
                    if (node.ImageIndex == 2) return;
                    node.ImageIndex = 2;
                    node.SelectedImageIndex = 2;
                    break;
                }
                updateHostsTree(node.Nodes);
            }
        }

        private void windowsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (windowsGridView.Columns[e.ColumnIndex].DataPropertyName == WgwStatusColumn)
            {
                var value = windowsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                var hwnd = new IntPtr (int.Parse(windowsGridView.Rows[e.RowIndex].Cells[WgwHwndColumn].Value.ToString()));
                var window = new PuttyWindow(hwnd);
                e.CellStyle.ForeColor = window.Inactive ? ColorInactiveStatus : ColorActiveStatus;
            }
        }

        private void windowsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var hwnd = int.Parse(windowsGridView.Rows[e.RowIndex].Cells[WgwHwndColumn].Value.ToString());
            var window = new PuttyWindow(new IntPtr(hwnd));

            if (e.ColumnIndex == windowsGridView.Columns[WgwShowColumn].Index)
            {
                window.Show();
            } else if (e.ColumnIndex == windowsGridView.Columns[WgwHideColumn].Index)
            {
                window.Hide();
            }
            else if (e.ColumnIndex == windowsGridView.Columns[WgwKillColumn].Index)
            {
                window.Kill();
                updateWindowsTable();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReallyClose();
        }

        private void killInactivePuttiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuttyWindowsManager.KillInactivePuttyWindows();
            updateWindowsTable();
        }

        private void killAllPuttiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuttyWindowsManager.KillAllPutties();
            updateWindowsTable();
        }

        private void showAllPuttiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuttyWindowsManager.ShowAllPutties();
        }

        private void removePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.EncryptedSettingsPassword = "";
            Settings.Default.Save();
            MessageBox.Show(this, @"Password has been removed.", @"PuTTY Manager");
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pwdDlg = new PasswordDialog();
            pwdDlg.Setup(PasswordDialog.EMode.CreatePassword);
            var res = pwdDlg.ShowDialog();
            if (res != DialogResult.OK)
                return;

            Settings.Default.EncryptedSettingsPassword = pwdDlg.SavePassword ? pwdDlg.Password : "";
            Settings.Default.Save();

            EncryptedSettings.Instance.ChangePassword(pwdDlg.Password);
        }

        private void toolStripButtonAddHost_Click(object sender, EventArgs e)
        {
            addHost();
        }

        private void addHost()
        {
            var hd = new HostDialog();
            HostInfo hiParent;
            if (treeViewHosts.SelectedNode != null && (hiParent = treeViewHosts.SelectedNode.Tag as HostInfo) != null)
            {
                hd.StartupDependsOn = hiParent;
            }
            hd.ShowDialog(this);
            fillHostsTree();
        }

        private void toolStripButtonDeleteHost_Click(object sender, EventArgs e)
        {
            deleteHost(false);
        }

        private void toolStripButtonDeleteHostRecursively_Click(object sender, EventArgs e)
        {
            deleteHost(true);
        }

        private void deleteHost(bool recursive)
        {
            TreeNode node;
            HostInfo hostInfo;
            if ((node = treeViewHosts.SelectedNode) == null || (hostInfo = node.Tag as HostInfo) == null)
                return;

            var message = string.Format(recursive
                        ? @"Host '{0}' and it`s dependents will be removed permanently."
                        : @"Host '{0}' will be removed permanently.", hostInfo.Name);

            if (MessageBox.Show(this, string.Format(message, hostInfo.Name), 
                Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                return;
            }

            deleteHostImpl(node, recursive);
            EncryptedSettings.Instance.Save();
        }

        private void deleteHostImpl(TreeNode hostNode, bool recursive)
        {
            HostInfo hostInfo;
            if ((hostInfo = hostNode.Tag as HostInfo) == null) 
                return;

            if (recursive)
            {
                // delete child nodes recursively
                foreach (TreeNode child in hostNode.Nodes.Cast<TreeNode>().ToArray())
                {
                    deleteHostImpl(child, true);
                }
            } else
            {
                // move child nodes to root
                var treeNodes = hostNode.Nodes.Cast<TreeNode>().ToArray();
                hostNode.Nodes.Clear();
                treeViewHosts.Nodes.AddRange(treeNodes);

                var hosts = from t in treeNodes let hi = t.Tag as HostInfo where hi != null select hi;
                foreach (var host in hosts)
                {
                    host.DependsOn = null;
                }
            }
            EncryptedSettings.Instance.Hosts.Remove(hostInfo);
            hostNode.Remove();
        }

        private void treeViewHosts_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewHosts.SelectedNode = e.Node;
        }

        private HostInfo selectedHost()
        {
            TreeNode node;
            if ((node = treeViewHosts.SelectedNode) == null)
                return null;

            return node.Tag as HostInfo;
        }

        private void toolStripButtonConnect_Click(object sender, EventArgs e)
        {
            var host = selectedHost();
            var node = treeViewHosts.SelectedNode;

            if (host == null || node == null) return;

            if (host.Link.ConnectionState == PuttyLink.EConnectionState.Inactive)
            {
                host.Link.AsyncStart();
                
            }
        }
    }
}
