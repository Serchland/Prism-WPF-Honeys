using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class ListViewModel : BindableBase, INavigationAware
    {
        private string _lastSelectedNavigationItem;
        public string Message { get; set; }

        public ListViewModel()
        {
            Message = "List from mail module";
        }

        

        #region "INavigationAware implementation"
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            string param = navigationContext.Parameters.GetValue<string>("id");

            if (param == AppModuleNames.MailModuleName)
                param = _lastSelectedNavigationItem;

            Message = string.Format("{0} {1}", "List from mail module", param);
            _lastSelectedNavigationItem = param;

            RaisePropertyChanged("Message");
        }
        #endregion
    }
}
