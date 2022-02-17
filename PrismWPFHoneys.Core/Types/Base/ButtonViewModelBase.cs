using Prism.Commands;
using Prism.Mvvm;
using PrismWPFHoneys.Core.Types.Interfaces;

namespace PrismWPFHoneys.Core.Types.Base
{
    public class ButtonViewModelBase : BindableBase
    {
        IApplicationCommands _applicationCommands;
        public ButtonViewModelBase(IApplicationCommands applicationCommands)
        {
            _applicationCommands = applicationCommands;
        }

        public string ModuleName { get; set; }

        private DelegateCommand<string> _selectedApplicationCommand;
        public DelegateCommand<string> SelectedApplicationCommand =>
            _selectedApplicationCommand ?? (_selectedApplicationCommand = new DelegateCommand<string>(ExecuteNavigateCommand));

        private void ExecuteNavigateCommand(string selectedModule)
        {
            _applicationCommands.SelectedApplicationCommand.Execute(selectedModule);
        }
    }
}
