using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.Registro.ViewModels
{
    public class ListViewModel : BindableBase, INavigationAware
    {
        private string _currentFolder;
        public string Message { get; set; }
        public string TestProperty { get; }

        public ListViewModel()
        {
            Message = "List from Registro module";
            TestProperty = "Registro TestProperty";
        }

        #region "Commands"
        private DelegateCommand _testCommand;
        public DelegateCommand TestCommand =>
            _testCommand ?? (_testCommand = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {
            System.Windows.MessageBox.Show("Command from Registro");
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

            if (param == AppModuleNames.RegistroModuleName)
                param = _currentFolder;

            Message = string.Format("{0} {1}", "List from Registro module", param);
            _currentFolder = param;

            RaisePropertyChanged("Message");
        }
        #endregion
    }
}
