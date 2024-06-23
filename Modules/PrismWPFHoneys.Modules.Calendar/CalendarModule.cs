using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Modules.Calendar.ViewModels;
using PrismWPFHoneys.Modules.Calendar.Views;

namespace PrismWPFHoneys.Modules.Calendar
{
    public class CalendarModule : IModule
    {
        IRegionManager _regionManager;
        public CalendarModule(IRegionManager regionManager)
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

            containerRegistry.RegisterForNavigation<AppButton, ButtonViewModel>(RegisterForNavigation.CalendarButtonContentRegion);
            containerRegistry.RegisterForNavigation<AppFooter, FooterViewModel>(RegisterForNavigation.CalendarFooterContentRegion);
            containerRegistry.RegisterForNavigation<AppList, ListViewModel>(RegisterForNavigation.CalendarListContentRegion);
            containerRegistry.RegisterForNavigation<AppNavigation, NavigationViewModel>(RegisterForNavigation.CalendarNavigationContentRegion);
            containerRegistry.RegisterForNavigation<AppRibbonTab, RibbonTabViewModel>(RegisterForNavigation.CalendarRibbonContentRegion);
        }
    }
}