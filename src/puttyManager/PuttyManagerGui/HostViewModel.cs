using System;
using System.Drawing;
using PuttyManager.Business;
using PuttyManagerGui.Properties;

namespace PuttyManagerGui
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
                    _model.StatusChanged -= onStatusChanged;
                _model = value;
                _model.StatusChanged += onStatusChanged;
            }
        }

        public Bitmap StatusIcon { get { return statusIcon(Model.Status); } }
        public string Name { get { return Model.Info.Name; } }
        public string Username { get { return Model.Info.Username; } }
        public string Hostname { get { return Model.Info.HostAndPort; } }
        public string Status
        {
            get
            {
                return Model.Status != HostStatus.StartedWithWarnings 
                    ? Model.Status.ToString() 
                    : HostStatus.Started.ToString();
            }
        }
        public event EventHandler StatusChanged;
        public string DependsOn { get { return Model.Info.DependsOnStr; } }

        public Color StatusColor
        {
            get
            {
                switch (Model.Status)
                {
                case HostStatus.Stopped:
                    return Color.FromArgb(165, 0, 0);
                case HostStatus.Unknown:
                    return Color.FromArgb(181, 166, 16);
                case HostStatus.StartedWithWarnings:
                    return Color.FromArgb(181, 166, 16);
                case HostStatus.Started:
                    return Color.FromArgb(10, 126, 24);
                default:
                    throw new ArgumentOutOfRangeException();
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

        private static Bitmap statusIcon(HostStatus status)
        {
            switch (status)
            {
                case HostStatus.Stopped:
                    return Resources.control_stop_square_small;
                case HostStatus.Unknown:
                    return Resources.brightness_small;
                case HostStatus.StartedWithWarnings:
                    return Resources.brightness_small;
                case HostStatus.Started:
                    return Resources.tick_small_circle;
                default:
                    throw new ArgumentOutOfRangeException("status");
            }
        }
    }
}