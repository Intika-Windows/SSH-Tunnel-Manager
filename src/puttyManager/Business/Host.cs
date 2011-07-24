using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuttyManager.Domain;

namespace PuttyManager.Business
{
    class Host
    {
        public Host(HostInfo info)
        {
            Info = info;
        }
        
        public HostInfo Info { get; private set; }

        private PuttyLink _sshLink;

        public bool IsOpen { get { return (_sshLink != null); } }

        public void Open()
        {
            _sshLink = new PuttyLink(Info);
            _sshLink.AsyncStart();
        }

        public void Close()
        {
            if (IsOpen)
                _sshLink.Stop();
            _sshLink = null;
        }
    }
}
