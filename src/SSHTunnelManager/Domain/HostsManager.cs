using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSHTunnelManager.Business;
using SSHTunnelManager.Ext.BLW;
using SSHTunnelManager.Properties;
using SSHTunnelManager.Util;

namespace SSHTunnelManager.Domain
{
    public class HostsManager<THostViewModel> where THostViewModel : IViewModel<Host>, new()
    {
        private const string PuttyProfileName = "_stm_preset_";

        public string Filename { get; private set; }
        public string Password { get; set; }
        public EncryptedStorage Storage { get; private set; }
        public Config Config { get; private set; }
        public BindingListView<THostViewModel> Hosts { get; private set; }
        public PuttyProfile PuttyProfile { get; private set; }

        private THostViewModel _addingNewHost;

        public HostsManager(Config config, EncryptedStorage storage, string filename, string password)
        {
            if (config == null) throw new ArgumentNullException("config");
            if (storage == null) throw new ArgumentNullException("storage");
            if (filename == null) throw new ArgumentNullException("filename");
            if (password == null) throw new ArgumentNullException("password");

            Filename = filename;
            Password = password;
            Config = config;
            Storage = storage;

            try
            {
                PuttyProfile = PuttyProfile.ReadOrCreate(PuttyProfileName);
            }
            catch (SSHTunnelManagerException e)
            {
                Logger.Log.Error(Helper.JoinExceptionMessages(e.Message, Resources.HostsManager_Error_LoadPuttyProfileError));
            }

            var hosts = storage.Data.Hosts.Select(delegate(HostInfo h)
                                                        {
                                                            var viewModel = new THostViewModel();
                                                            viewModel.Model = new Host(h, Config, PuttyProfile) { ViewModel = viewModel };
                                                            return viewModel;
                                                        }).ToList();
            Hosts = new BindingListView<THostViewModel>(hosts);
            Hosts.AddingNew += (o, e) => { e.NewObject = _addingNewHost; };
        }

        public THostViewModel AddHost(HostInfo host)
        {
            var hvm = new THostViewModel { Model = new Host(host, Config, PuttyProfile) };
            _addingNewHost = hvm;
            Hosts.AddNew();
            Hosts.EndNew(Hosts.Count - 1);
            return hvm;
        }

        public List<HostInfo> HostInfoList
        {
            get { return Hosts.Cast<ObjectView<THostViewModel>>().Select(m => m.Object.Model.Info).ToList(); }
        }

        public List<Host> HostsList
        {
            get { return Hosts.Cast<ObjectView<THostViewModel>>().Select(m => m.Object.Model).ToList(); }
        }

        // Children of host in parameter. Ordered from parent to child (A <= B <= C, - C depends on B etc).
        public List<THostViewModel> DependentHosts(THostViewModel host, bool deep)
        {
            var result = new List<THostViewModel>();
            var thisTier = Hosts.Cast<ObjectView<THostViewModel>>().Where(m => m.Object.Model.Info.DependsOn == host.Model.Info).Select(h => h.Object).ToList();
            result.AddRange(thisTier);
            if (deep)
                foreach (var htt in thisTier)
                {
                    result.AddRange(DependentHosts(htt, true));
                }
            return result;
        }

        public void Save()
        {
            Storage.Data.Hosts = Hosts.Cast<ObjectView<THostViewModel>>().Select(h => h.Object.Model.Info).ToList();
            Storage.Save(Filename, Password);
        }
    }
}
