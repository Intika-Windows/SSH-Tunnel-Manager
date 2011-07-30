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

        public Host Model { get; set; }

        public Bitmap StatusIcon { get { return statusIcon(Model.Status); } }
        public string Name { get { return Model.Info.Name; } }
        public string Username { get { return Model.Info.Username; } }
        public string Hostname { get { return Model.Info.HostAndPort; } }
        public string Status { get { return Model.Status.ToString(); } }
        public string DependsOn { get { return Model.Info.DependsOnStr; } }

        private static Bitmap statusIcon(HostStatus status)
        {
            switch (status)
            {
                case HostStatus.Disabled:
                    throw new NotImplementedException();
                case HostStatus.Stopped:
                    return Resources.control_stop_square_small;
                case HostStatus.Unknown:
                    return Resources.brightness_small;
                case HostStatus.Started:
                    return Resources.control_000_small;
                default:
                    throw new ArgumentOutOfRangeException("status");
            }
        }
    }
}