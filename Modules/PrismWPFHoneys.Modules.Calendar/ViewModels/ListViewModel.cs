using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.Calendar.ViewModels
{
    public class ListViewModel : BindableBase, INavigationAware
    {
        private string _lastSelectedNavigationItem;
        public string Message { get; set; }
        public string TestProperty { get; }

        public ListViewModel()
        {
            Message = "List from calendar module";
            TestProperty = "Calendar TestProperty";
        }

        #region "Commands"
        private DelegateCommand _testCommand;
        public DelegateCommand TestCommand =>
            _testCommand ?? (_testCommand = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {
            System.Windows.MessageBox.Show("Command from Contacts");
        }
        #endregion

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
