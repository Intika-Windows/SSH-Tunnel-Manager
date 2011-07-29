using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using PuttyManager.Business;

namespace PuttyManager.Domain
{
    public class HostsManager
    {
        public HostsManager()
        {
            Hosts = new ObservableCollection<Host>(EncryptedSettings.Instance.Hosts.Select(h => new Host(h)));
        }

        public ObservableCollection<Host> Hosts { get; private set; }

        public void Save()
        {
            EncryptedSettings.Instance.Hosts = Hosts.Select(h => h.Info).ToList();
            EncryptedSettings.Instance.Save();
        }
    }
}
