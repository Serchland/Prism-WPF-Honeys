using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Modules.Notas.ViewModels;
using PrismWPFHoneys.Modules.Notas.Views;

namespace PrismWPFHoneys.Modules.Notas
{
    public class NotasModule : IModule
    {
        IRegionManager _regionManager;
        public NotasModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.ButtonContentRegion, typeof(AppButton));
            //_regionManager.RegisterViewWithRegion(RegionNames.FooterContentRegion, typeof(AppFooter));
            //_regionManager.RegisterViewWithRegion(RegionNames.ListContentRegion, typeof(AppList));
            //_regionManager.RegisterViewWithRegion(RegionNames.NavigationContentRegion, typeof(AppNavigation));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<AppButton, ButtonViewModel>();
            ViewModelLocationProvider.Register<AppFooter, FooterViewModel>();
            ViewModelLocationProvider.Register<AppList, ListViewModel>();
            ViewModelLocationProvider.Register<AppNavigation, NavigationViewModel>();
            //ViewModelLocationProvider.Register<AppRibbonTab, RibbonTabViewModel>();

            containerRegistry.RegisterForNavigation<AppButton, ButtonViewModel>(RegisterForNavigation.NotasButtonContentRegion);
            containerRegistry.RegisterForNavigation<AppFooter, FooterViewModel>(RegisterForNavigation.NotasFooterContentRegion);
            containerRegistry.RegisterForNavigation<AppList, ListViewModel>(RegisterForNavigation.NotasListContentRegion);
            containerRegistry.RegisterForNavigation<AppNavigation, NavigationViewModel>(RegisterForNavigation.NotasNavigationContentRegion);
            //containerRegistry.RegisterForNavigation<AppRibbonTab, RibbonTabViewModel>(RegisterForNavigation.NotasRibbonContentRegion);
        }
    }
}