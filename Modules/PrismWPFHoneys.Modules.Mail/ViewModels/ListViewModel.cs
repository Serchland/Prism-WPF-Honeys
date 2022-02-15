using Prism.Mvvm;
using Prism.Regions;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class ListViewModel : BindableBase, INavigationAware
    {
        public ListViewModel()
        {
            Message = "List from mail module";
        }

        public string Message { get; set; }

        #region "INavigationAware"
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
            Message = string.Format("{0} {1}", "List from mail module", param);

            RaisePropertyChanged("Message");
        }
        #endregion
    }
}
