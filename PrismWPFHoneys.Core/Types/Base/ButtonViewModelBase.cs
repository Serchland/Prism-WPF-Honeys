using Prism.Commands;
using Prism.Mvvm;
using PrismWPFHoneys.Core.Types.Interfaces;
using System.Windows;

namespace PrismWPFHoneys.Core.Types.Base
{
    public class ButtonViewModelBase : BindableBase
    {
        IApplicationCommands _applicationCommands;
        public ButtonViewModelBase(IApplicationCommands applicationCommands)
        {
            _enabled = false; 
            _visibility = Visibility.Visible;
            _applicationCommands = applicationCommands;
        }

        private Visibility _visibility;
        public Visibility Visibility
        {
            get { return _visibility; }
            set { SetProperty(ref _visibility, value); }
        }

        private bool _enabled;
        public bool Enabled
        {
            get { return _enabled; }
            set { SetProperty(ref _enabled, value); }
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
