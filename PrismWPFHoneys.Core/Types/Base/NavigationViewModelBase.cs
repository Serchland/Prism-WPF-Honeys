using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using System;

namespace PrismWPFHoneys.Core.Types.Base
{
    public abstract class NavigationViewModelBase :BindableBase
    {
        private IApplicationCommands _applicationCommands;
        
        public NavigationViewModelBase(IApplicationCommands applicationCommands)
        {
            _applicationCommands = applicationCommands;
            _applicationCommands.NavigationNavigateCommand.Execute(GetNavigationPath("Default"));
        }

        protected abstract string GetNavigationPath(string item);

        #region "Commands"
        private DelegateCommand<string> _navigationNavigateCommand;
        public DelegateCommand<string> NavigationNavigateCommand =>
            _navigationNavigateCommand ?? (_navigationNavigateCommand = new DelegateCommand<string>(ExecuteNavigateCommand));

        private void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
                throw new ArgumentNullException();

            _applicationCommands.NavigationNavigateCommand.Execute(navigationPath);
        }
        #endregion
    }
}
