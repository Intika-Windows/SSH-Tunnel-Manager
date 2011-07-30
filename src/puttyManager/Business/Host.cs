using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuttyManager.Domain;

namespace PuttyManager.Business
{
    public class Host
    {
        public Host(HostInfo info)
        {
            Info = info;
            _puttyLink = new PuttyLink(Info);
        }
        
        public HostInfo Info { get; private set; }
        public IPuttyLink Link { get { return _puttyLink; } }
        public HostStatus Status
        {
            get
            {
                switch (Link.ConnectionState)
                {
                case EConnectionState.Inactive:
                    return HostStatus.Stopped;
                case EConnectionState.Intermediate:
                    return HostStatus.Unknown;
                case EConnectionState.Active:
                    return HostStatus.Started;
                default:
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private IViewModel<Host> _viewModel;
        public IViewModel<Host> ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                _viewModel.Model = this;
            }
        }

        private readonly PuttyLink _puttyLink;

        //public bool IsOpen { get { return (_sshLink != null); } }

        /*public void Open()
        {
            _puttyLink = new PuttyLink(Info);
            _puttyLink.AsyncStart();
        }

        public void Close()
        {
            if (_puttyLink.ConnectionState != EConnectionState.Inactive)
                _puttyLink.Stop();
            _puttyLink = null;
        }*/
    }
}
