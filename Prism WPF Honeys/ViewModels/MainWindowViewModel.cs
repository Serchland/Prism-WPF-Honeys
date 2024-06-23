using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Core.Types.Types;
using System;

namespace Prism_WPF_Honeys.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager, IApplicationCommands applicationCommands)
        {
            applicationCommands.SelectedApplicationCommand.RegisterCommand(SelectedApplicationCommand);
            applicationCommands.NavigationNavigateCommand.RegisterCommand(NavigationNavigateCommand);
            _regionManager = regionManager;
        }

        public string Title { get; set; }

        #region "Commands"

        #region "NavigationNavigateCommand"
        private DelegateCommand<string> _navigationNavigateCommand;
        public DelegateCommand<string> NavigationNavigateCommand =>
            _navigationNavigateCommand ?? (_navigationNavigateCommand = new DelegateCommand<string>(ExecuteNavigationNavigateCommand));

        private void ExecuteNavigationNavigateCommand(string navigationPath)
        {
            _regionManager.RequestNavigate(RegionNames.ListContentRegion, navigationPath);
        }
        #endregion

        #region "SelectedApplicationCommand"
        private DelegateCommand<string> _selectedApplicationCommand;
        public DelegateCommand<string> SelectedApplicationCommand =>
            _selectedApplicationCommand ?? (_selectedApplicationCommand = new DelegateCommand<string>(ExecuteApplicationNavigateCommand));

        private void ExecuteApplicationNavigateCommand(string navigationPath)
        {
            NavigationParameters listNavigationParameters = new NavigationParameters();

            if (string.IsNullOrEmpty(navigationPath))
                throw new ArgumentNullException(nameof(navigationPath));

            switch (navigationPath)
            {
                case AppModuleNames.NotasModuleName:
                    listNavigationParameters.Add("id", AppModuleNames.NotasModuleName);

                    _regionManager.RequestNavigate(RegionNames.FooterContentRegion, RegisterForNavigation.NotasFooterContentRegion);
                    _regionManager.RequestNavigate(RegionNames.ListContentRegion, RegisterForNavigation.NotasListContentRegion, listNavigationParameters);
                    _regionManager.RequestNavigate(RegionNames.NavigationContentRegion, RegisterForNavigation.NotasNavigationContentRegion);
                    //_regionManager.RequestNavigate(RegionNames.RibbonContentRegion, RegisterForNavigation.NotasRibbonContentRegion);

                    break;

                case AppModuleNames.RegistroModuleName:
                    listNavigationParameters.Add("id", AppModuleNames.RegistroModuleName);

                    _regionManager.RequestNavigate(RegionNames.FooterContentRegion, RegisterForNavigation.RegistroFooterContentRegion);
                    _regionManager.RequestNavigate(RegionNames.ListContentRegion, RegisterForNavigation.RegistroListContentRegion, listNavigationParameters);
                    _regionManager.RequestNavigate(RegionNames.NavigationContentRegion, RegisterForNavigation.RegistroNavigationContentRegion);
                    //_regionManager.RequestNavigate(RegionNames.RibbonContentRegion, RegisterForNavigation.RegistroRibbonContentRegion);

                    break;

                case AppModuleNames.MailModuleName:
                    listNavigationParameters.Add("id", AppModuleNames.MailModuleName);

                    _regionManager.RequestNavigate(RegionNames.FooterContentRegion, RegisterForNavigation.MailFooterContentRegion);
                    _regionManager.RequestNavigate(RegionNames.ListContentRegion, RegisterForNavigation.MailListContentRegion, listNavigationParameters);
                    _regionManager.RequestNavigate(RegionNames.NavigationContentRegion, RegisterForNavigation.MailNavigationContentRegion);
                    //_regionManager.RequestNavigate(RegionNames.RibbonContentRegion, RegisterForNavigation.MailRibbonContentRegion);

                    break;
            }
        }
        #endregion

        #endregion
    }
}
