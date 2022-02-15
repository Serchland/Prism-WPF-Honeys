using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Core.Types.Types;
using System;

namespace PrismWPFHoneys.Core.Types.Base
{
    public class ButtonViewModelBase : BindableBase
    {
        private IRegionManager _regionManager;
        public ButtonViewModelBase(IRegionManager regionManager)
        {
            //applicationCommands.SelectedApplicationCommand.RegisterCommand(SelectedCommand);
            _regionManager = regionManager;
        }

        private DelegateCommand<string> _selectedCommand;
        public DelegateCommand<string> SelectedCommand =>
            _selectedCommand ?? (_selectedCommand = new DelegateCommand<string>(ExecuteNavigateCommand));

        public string ModuleName { get; set; }

        private void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
                throw new ArgumentNullException();

            switch (navigationPath)
            {
                case AppModuleNames.CalendarModuleName:
                    _regionManager.RequestNavigate(RegionNames.FooterContentRegion, RegisterForNavigation.CalendarFooterContentRegion);
                    //_regionManager.RequestNavigate(RegionNames.ListContentRegion, RegisterForNavigation.CalendarListContentRegion);
                    _regionManager.RequestNavigate(RegionNames.NavigationContentRegion, RegisterForNavigation.CalendarNavigationContentRegion);
                    _regionManager.RequestNavigate(RegionNames.RibbonContentRegion, RegisterForNavigation.CalendarRibbonContentRegion);               
                     
                    break;

                case AppModuleNames.ContactsModuleName:
                    _regionManager.RequestNavigate(RegionNames.FooterContentRegion, RegisterForNavigation.ContactsFooterContentRegion);
                    //_regionManager.RequestNavigate(RegionNames.ListContentRegion, RegisterForNavigation.ContactsListContentRegion);
                    _regionManager.RequestNavigate(RegionNames.NavigationContentRegion, RegisterForNavigation.ContactsNavigationContentRegion);
                    _regionManager.RequestNavigate(RegionNames.RibbonContentRegion, RegisterForNavigation.ContactsRibbonContentRegion);

                    break;

                case AppModuleNames.MailModuleName:
                    _regionManager.RequestNavigate(RegionNames.FooterContentRegion, RegisterForNavigation.MailFooterContentRegion);
                    //_regionManager.RequestNavigate(RegionNames.ListContentRegion, RegisterForNavigation.MailListContentRegion);
                    _regionManager.RequestNavigate(RegionNames.NavigationContentRegion, RegisterForNavigation.MailNavigationContentRegion);
                    _regionManager.RequestNavigate(RegionNames.RibbonContentRegion, RegisterForNavigation.MailRibbonContentRegion);

                    break;
            }

            
        }
    }
}
