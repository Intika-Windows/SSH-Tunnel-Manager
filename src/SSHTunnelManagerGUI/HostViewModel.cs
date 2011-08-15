using System;
using System.Drawing;
using SSHTunnelManager.Business;
using SSHTunnelManager.Domain;
using SSHTunnelManagerGUI.Properties;

namespace SSHTunnelManagerGUI
{
    public class HostViewModel : IViewModel<Host>
    {
        public HostViewModel(Host model)
        {
            Model = model;
        }

        public HostViewModel()
        {
        }

        private Host _model;
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

        public Bitmap StatusIcon { get { return statusIcon(Model.Link.Status); } }
        public string Name { get { return Model.Info.Name; } }
        public string Username { get { return Model.Info.Username; } }
        public string Hostname { get { return Model.Info.HostAndPort; } }
        public string Status
        {
            get
            {
                return Model.Link.Status != ELinkStatus.StartedWithWarnings
                    ? Model.Link.Status.ToString() 
                    : ELinkStatus.Started.ToString();
            }
        }
        public event EventHandler StatusChanged;
        public string DependsOn { get { return Model.Info.DependsOnStr; } }

        public Color StatusColor
        {
            get
            {
                switch (Model.Link.Status)
                {
                case ELinkStatus.Stopped:
                    return Color.FromArgb(165, 0, 0);
                case ELinkStatus.Starting:
                    return Color.FromArgb(181, 166, 16);
                case ELinkStatus.StartedWithWarnings:
                    return Color.FromArgb(181, 166, 16);
                case ELinkStatus.Started:
                    return Color.FromArgb(10, 126, 24);
                case ELinkStatus.Waiting:
                    return Color.FromArgb(181, 166, 16);
                default:
                    throw new Exception(string.Format("Status {0} not supported.", Model.Link.Status));
                }
            }
        }

        private void onStatusChanged(object o, EventArgs e)
        {
            if (StatusChanged != null)
            {
                StatusChanged(this, EventArgs.Empty);
            }
        }

        private static Bitmap statusIcon(ELinkStatus status)
        {
            switch (status)
            {
                case ELinkStatus.Stopped:
                    return Resources.control_stop_square_small;
                case ELinkStatus.Starting:
                    return Resources.brightness_small;
                case ELinkStatus.StartedWithWarnings:
                    return Resources.brightness_small;
                case ELinkStatus.Waiting:
                    return Resources.brightness_small;
                case ELinkStatus.Started:
                    return Resources.tick_small_circle;
                default:
                    throw new ArgumentOutOfRangeException("status");
            }
        }
    }
}