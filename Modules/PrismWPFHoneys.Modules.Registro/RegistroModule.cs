using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Modules.Registro.ViewModels;
using PrismWPFHoneys.Modules.Registro.Views;

namespace PrismWPFHoneys.Modules.Registro
{
    public class RegistroModule : IModule
    {
        private IRegionManager _regionManager;
        public RegistroModule(IRegionManager regionManager)
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

            containerRegistry.RegisterForNavigation<AppButton, ButtonViewModel>(RegisterForNavigation.RegistroButtonContentRegion);
            containerRegistry.RegisterForNavigation<AppFooter, FooterViewModel>(RegisterForNavigation.RegistroFooterContentRegion);
            containerRegistry.RegisterForNavigation<AppList, ListViewModel>(RegisterForNavigation.RegistroListContentRegion);
            containerRegistry.RegisterForNavigation<AppNavigation, NavigationViewModel>(RegisterForNavigation.RegistroNavigationContentRegion);
            //containerRegistry.RegisterForNavigation<AppRibbonTab, RibbonTabViewModel>(RegisterForNavigation.RegistroRibbonContentRegion);
        }
    }
}