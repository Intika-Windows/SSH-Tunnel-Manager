using System;
using System.Drawing;
using SSHTunnelManager.Business;
using SSHTunnelManager.Domain;
using SSHTunnelManagerGUI.Properties;

namespace SSHTunnelManagerGUI
{
    public class HostViewModel : IViewModel<Host>
    {
        private Host _model;

        public HostViewModel(Host model)
        {
            Model = model;
        }

        public HostViewModel()
        {
        }

        #region Properties

        public Host Model
        {
            get { return _model; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                if (_model == value) return;
                if(_model != null)
                    _model.Link.LinkStatusChanged -= onStatusChanged;
                _model = value;
                _model.Link.LinkStatusChanged += onStatusChanged;
                _model.ViewModel = this;
            }
        }

        public Bitmap StatusIcon { get { return GetStatusIcon(Model.Link.Status); } }
        public string Name { get { return Model.Info.Name; } }
        public string Username { get { return Model.Info.Username; } }
        public string Hostname { get { return Model.Info.HostAndPort; } }
        public string Status { get { return GetStatusText(Model.Link.Status); } }

        public string DependsOn { get { return Model.Info.DependsOnStr; } }

        public Color StatusColor { get { return GetStatusColor(Model.Link.Status); } }

        #endregion

        #region Methods

        public static string GetStatusText(ELinkStatus status)
        {
            switch (status)
            {
            case ELinkStatus.Stopped:
            case ELinkStatus.Waiting:
            case ELinkStatus.Starting:
                return status.ToString();
            case ELinkStatus.Started:
            case ELinkStatus.StartedWithWarnings:
                return ELinkStatus.Started.ToString();
            default:
                throw new Exception(string.Format(Resources.HostViewModel_StatusNotSupported, status));
            }
        }

        public static Color GetStatusColor(ELinkStatus status)
        {
            switch (status)
            {
            case ELinkStatus.Stopped:
                return Color.FromArgb(165, 0, 0);
            case ELinkStatus.Starting:
            case ELinkStatus.StartedWithWarnings:
            case ELinkStatus.Waiting:
                return Color.FromArgb(181, 166, 16);
            case ELinkStatus.Started:
                return Color.FromArgb(10, 126, 24);
            default:
                throw new Exception(string.Format(Resources.HostViewModel_StatusNotSupported, status));
            }
        }

        public static Bitmap GetStatusIcon(ELinkStatus status)
        {
            switch (status)
            {
            case ELinkStatus.Stopped:
                return Resources.redCircle;
            case ELinkStatus.Starting:
            case ELinkStatus.StartedWithWarnings:
            case ELinkStatus.Waiting:
                return Resources.yellowCircle;
            case ELinkStatus.Started:
                return Resources.greenCircle;
            default:
                throw new Exception(string.Format(Resources.HostViewModel_StatusNotSupported, status));
            }
        }

        #endregion

        #region Events

        public event EventHandler StatusChanged;

        private void onStatusChanged(object o, EventArgs e)
        {
            if (StatusChanged != null)
            {
                StatusChanged(this, EventArgs.Empty);
            }
        }

        #endregion
    }
}