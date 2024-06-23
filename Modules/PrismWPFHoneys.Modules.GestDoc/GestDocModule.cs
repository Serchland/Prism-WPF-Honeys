using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Modules.GestDoc.ViewModels;
using PrismWPFHoneys.Modules.GestDoc.ViewModels.Dialogs;
using PrismWPFHoneys.Modules.GestDoc.Views;
using PrismWPFHoneys.Modules.GestDoc.Views.Dialogs;
using PrismWPFHoneys.Services;
using PrismWPFHoneys.Services.Interfaces;

namespace PrismWPFHoneys.Modules.GestDoc
{
    public class GestDocModule : IModule
    {
        private IRegionManager _regionManager;

        public GestDocModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ButtonContentRegion, typeof(AppButton));
            _regionManager.RegisterViewWithRegion(RegionNames.FooterContentRegion, typeof(AppFooter));
            _regionManager.RegisterViewWithRegion(RegionNames.ListContentRegion, typeof(AppList));
            _regionManager.RegisterViewWithRegion(RegionNames.NavigationContentRegion, typeof(AppNavigation));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<AppButton, ButtonViewModel>();
            ViewModelLocationProvider.Register<AppFooter, FooterViewModel>();
            ViewModelLocationProvider.Register<AppList, ListViewModel>();
            ViewModelLocationProvider.Register<AppNavigation, NavigationViewModel>();
            ViewModelLocationProvider.Register<AppRibbonTab, RibbonTabViewModel>();

            containerRegistry.RegisterForNavigation<AppButton, ButtonViewModel>(RegisterForNavigation.GestDocButtonContentRegion);
            containerRegistry.RegisterForNavigation<AppFooter, FooterViewModel>(RegisterForNavigation.GestDocFooterContentRegion);
            containerRegistry.RegisterForNavigation<AppList, ListViewModel>(RegisterForNavigation.GestDocListContentRegion);
            containerRegistry.RegisterForNavigation<AppNavigation, NavigationViewModel>(RegisterForNavigation.GestDocNavigationContentRegion);
            containerRegistry.RegisterForNavigation<AppRibbonTab, RibbonTabViewModel>(RegisterForNavigation.GestDocRibbonContentRegion);
            containerRegistry.RegisterForNavigation<GestDocDetail, GestDocDetailViewModel>("GestDocDetail");

            containerRegistry.RegisterSingleton<IGestDocService, GestDocServices>();
        }
    }
}