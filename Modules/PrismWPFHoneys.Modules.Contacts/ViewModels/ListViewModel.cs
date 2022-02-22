using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.Contacts.ViewModels
{
    public class ListViewModel : BindableBase, INavigationAware
    {
        private string _currentFolder;
        public string Message { get; set; }
        public string TestProperty { get; }

        public ListViewModel()
        {
            Message = "List from contacts module";
            TestProperty = "Contacts TestProperty";
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

            if (param == AppModuleNames.ContactsModuleName)
                param = _currentFolder;

            Message = string.Format("{0} {1}", "List from contacts module", param);
            _currentFolder = param;

            RaisePropertyChanged("Message");
        }
        #endregion
    }
}
