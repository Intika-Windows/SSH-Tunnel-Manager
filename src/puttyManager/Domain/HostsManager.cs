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

        public HostsManager()
        {
            var hosts = EncryptedSettings.Instance.Hosts.Select(delegate(HostInfo h)
                                                        {
                                                            var viewModel = new THostViewModel();
                                                            viewModel.Model = new Host(h) { ViewModel = viewModel };
                                                            return viewModel;
                                                        }).ToList();
            Hosts = new BindingListView<THostViewModel>(hosts);
        }

        public BindingListView<THostViewModel> Hosts { get; private set; }

        public List<HostInfo> HostInfoList
        {
            get { return Hosts.Cast<ObjectView<THostViewModel>>().Select(m => m.Object.Model.Info).ToList(); }
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

        public List<THostViewModel> DependentHosts(THostViewModel host)
        {
            var result = new List<THostViewModel>();
            var thisTier = Hosts.Cast<ObjectView<THostViewModel>>().Where(m => m.Object.Model.Info.DependsOn == host.Model.Info).Select(h => h.Object).ToList();
            result.AddRange(thisTier);
            foreach (var htt in thisTier)
            {
                result.AddRange(DependentHosts(htt));
            }
            return result;
        }

        public void Save()
        {
            EncryptedSettings.Instance.Hosts = Hosts.Cast<ObjectView<THostViewModel>>().Select(h => h.Object.Model.Info).ToList();
            EncryptedSettings.Instance.Save();
        }
    }
}
