using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.Calendar.ViewModels
{
    public class ListViewModel : BindableBase, INavigationAware
    {
        private string _lastSelectedNavigationItem;
        public string Message { get; set; }

        public ListViewModel()
        {
            Message = "List from calendar module";
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

            if (param == AppModuleNames.CalendarModuleName)
                param = _lastSelectedNavigationItem;

            Message = string.Format("{0} {1}", "List from calendar module", param);
            _lastSelectedNavigationItem = param;

            RaisePropertyChanged("Message");
        }
        #endregion
    }
}
