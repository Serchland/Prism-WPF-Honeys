using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Modules.Mail.ViewModels;
using PrismWPFHoneys.Modules.Mail.Views;

namespace PrismWPFHoneys.Modules.Mail
{
    public class MailModule : IModule
    {
        private IRegionManager _regionManager;

        public MailModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ButtonContentRegion, typeof(AppButton));
            _regionManager.RegisterViewWithRegion(RegionNames.FooterContentRegion, typeof(AppFooter));
            //_regionManager.RegisterViewWithRegion(RegionNames.ListContentRegion, typeof(AppList));
            _regionManager.RegisterViewWithRegion(RegionNames.NavigationContentRegion, typeof(AppNavigation));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<AppButton, ButtonViewModel>();
            ViewModelLocationProvider.Register<AppFooter, FooterViewModel>();
            ViewModelLocationProvider.Register<AppList, ListViewModel>();
            ViewModelLocationProvider.Register<AppNavigation, NavigationViewModel>();
            ViewModelLocationProvider.Register<AppRibbonTab, RibbonTabViewModel>();

            containerRegistry.RegisterForNavigation<AppButton, ButtonViewModel>(RegisterForNavigation.MailButtonContentRegion);
            containerRegistry.RegisterForNavigation<AppFooter, FooterViewModel>(RegisterForNavigation.MailFooterContentRegion);
            containerRegistry.RegisterForNavigation<AppList, ListViewModel>(RegisterForNavigation.MailListContentRegion);
            containerRegistry.RegisterForNavigation<AppNavigation, NavigationViewModel>(RegisterForNavigation.MailNavigationContentRegion);
            containerRegistry.RegisterForNavigation<AppRibbonTab, RibbonTabViewModel>(RegisterForNavigation.MailRibbonContentRegion);
        }
    }
}