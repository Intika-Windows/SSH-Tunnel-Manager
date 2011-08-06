using System;
using System.Drawing;
using System.Windows.Forms;

namespace PuttyManagerGui
{
    public class TrayForm : Form
    {
        private bool _timeToExit;
        private readonly NotifyIcon _theNotifyIcon = new NotifyIcon();

        // Predefined menu items
        protected readonly ToolStripMenuItem _exitToolStripMenuItem = new ToolStripMenuItem();
        protected readonly ToolStripMenuItem _hideShowToolStripMenuItem = new ToolStripMenuItem();

        public TrayForm()
        {
            //_theNotifyIcon = new NotifyIcon(components);
            _theNotifyIcon.Visible = true;
            _theNotifyIcon.ContextMenuStrip = new ContextMenuStrip();

            FormClosing += TrayForm_FormClosing;
            Resize += TrayForm_Resize;
            TrayMouseClick += theNotifyIcon_MouseClick;

            // 
            // hideShowToolStripMenuItem
            // 
            _hideShowToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _hideShowToolStripMenuItem.Name = "_hideShowToolStripMenuItem";
            _hideShowToolStripMenuItem.Size = new Size(173, 22);
            _hideShowToolStripMenuItem.Text = @"Hide/show";
            _hideShowToolStripMenuItem.Click += hideShowClick;
            // 
            // exitToolStripMenuItem
            // 
            _exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            _exitToolStripMenuItem.Size = new Size(173, 22);
            _exitToolStripMenuItem.Text = @"&Exit";
            _exitToolStripMenuItem.Click += exitClick;

            TrayContextMenuStrip.Items.Add(_hideShowToolStripMenuItem);
            TrayContextMenuStrip.Items.Add("-");
            TrayContextMenuStrip.Items.Add(_exitToolStripMenuItem);
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                _theNotifyIcon.Text = value;
            }
        }
        
        public new Icon Icon
        {
            get { return base.Icon; }
            set
            {
                base.Icon = value;
                _theNotifyIcon.Icon = value;
            }
        }

        public NotifyIcon TrayIcon { get { return _theNotifyIcon; } }

        public event MouseEventHandler TrayMouseClick
        {
            add { _theNotifyIcon.MouseClick += value; }
            remove { _theNotifyIcon.MouseClick -= value; }
        }

        public ContextMenuStrip TrayContextMenuStrip
        {
            get { return _theNotifyIcon.ContextMenuStrip; }
            set { _theNotifyIcon.ContextMenuStrip = value; }
        }

        private void toggleTrayState()
        {
            // Toggle our WindowState to the opposite of what it is now.
            if (WindowState == FormWindowState.Minimized)
            {
                restoreFromTray();
            }
            else
            {
                hideToTray();
            }
        }

        private void hideToTray()
        {
            if (Visible)
                Hide();

            WindowState = FormWindowState.Minimized;
        }

        private void restoreFromTray()
        {
            if (!Visible)
                Show();
            if (!Focused)
                Activate();

            WindowState = FormWindowState.Normal;
        }

        #region Handlers

        private void TrayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_timeToExit && e.CloseReason == CloseReason.UserClosing)
            {
                // Просто спрятать
                _theNotifyIcon.ShowBalloonTip(2000, Util.AssemblyTitle, Text + " has minimized here.", ToolTipIcon.Info);

                hideToTray();

                e.Cancel = true;
            }
            else
            {
                // Сохраниться и закрыть
                Properties.Settings.Default.Save();

                if (_theNotifyIcon.Visible)
                    _theNotifyIcon.Visible = false;
            }
        }

        private void TrayForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                hideToTray();
            } else
            {
                restoreFromTray();
            }
        }

        private void theNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            toggleTrayState();
        }

        private void hideShowClick(object sender, EventArgs e)
        {
            toggleTrayState();
        }

        private void exitClick(object sender, EventArgs e)
        {
            ReallyClose();
        }

        public void ReallyClose()
        {
            // Указать что мы действительно хотим выйти из приложения.
            _timeToExit = true;
            Close();
        }

        #endregion
    }
}