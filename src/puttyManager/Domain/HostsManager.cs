using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PuttyManager.Business;

namespace PuttyManager.Domain
{
    public class HostsManager
    {
        public HostsManager()
        {
            Hosts = EncryptedSettings.Instance.Hosts.Select(h => new Host(h)).ToList();
        }

        public List<Host> Hosts { get; private set; }

        public void Save()
        {
            EncryptedSettings.Instance.Hosts = Hosts.Select(h => h.Info).ToList();
            EncryptedSettings.Instance.Save();
        }
    }
}
