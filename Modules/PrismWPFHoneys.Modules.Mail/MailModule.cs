using PrismWPFHoneys.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismWPFHoneys.Core;

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
            _regionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ViewA));
            _regionManager.RegisterViewWithRegion(RegionNames.StackRegion, typeof(ViewB));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}