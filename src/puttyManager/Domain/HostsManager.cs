using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using PuttyManager.Business;
using PuttyManager.Ext;
using PuttyManager.Ext.BLW;

namespace PuttyManager.Domain
{
    public class HostsManager<THostViewModel> where THostViewModel : IViewModel<Host>, new()
    {
        private readonly string _filename;
        public string Password { get; private set; }
        public EncryptedStorage Storage { get; private set; }

        private THostViewModel _addingNewHost;

        public HostsManager(EncryptedStorage storage, string filename, string password)
        {
            if (storage == null) throw new ArgumentNullException("storage");
            if (filename == null) throw new ArgumentNullException("filename");
            if (password == null) throw new ArgumentNullException("password");

            _filename = filename;
            Password = password;

            Storage = storage;
            var hosts = storage.Data.Hosts.Select(delegate(HostInfo h)
                                                        {
                                                            var viewModel = new THostViewModel();
                                                            viewModel.Model = new Host(h) { ViewModel = viewModel };
                                                            return viewModel;
                                                        }).ToList();
            Hosts = new BindingListView<THostViewModel>(hosts);
            Hosts.AddingNew += (o, e) => { e.NewObject = _addingNewHost; };
        }

        public BindingListView<THostViewModel> Hosts { get; private set; }
        public void AddHost(THostViewModel host)
        {
            _addingNewHost = host;
            Hosts.AddNew();
            Hosts.EndNew(Hosts.Count - 1);
        }

        public List<HostInfo> HostInfoList
        {
            get { return Hosts.Cast<ObjectView<THostViewModel>>().Select(m => m.Object.Model.Info).ToList(); }
        }

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
            Storage.Save(_filename, Password);
        }

        /*private void setViewModel(Type viewModelType)
        {
            Type _viewModelType;
            var iViewModelType = typeof(IViewModel<>).MakeGenericType(typeof(Host));
            if (!iViewModelType.IsAssignableFrom(viewModelType))
            {
                throw new ArgumentException("Type does not implement IViewModel<Host>.");
            }
            if (viewModelType.GetConstructor(new Type[0]) == null)
            {
                throw new ArgumentException("Type does not have parameterless contructor.");
            }
            var viewModel = (IViewModel<Host>)Activator.CreateInstance(_viewModelType);
        }*/
    }
}
