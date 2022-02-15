using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Prism;

namespace PrismWPFHoneys.Core.Types.Base
{
    public class NavigationViewModelBase :BindableBase
    {
        private IRegionManager _regionManager;
       
        public NavigationViewModelBase(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigationCommand.Execute(null);
        }

        public string DefaultNavigationPath { get => RegisterForNavigation.MailListContentRegion; }

        private DelegateCommand<string> _navigationCommand;
        public DelegateCommand<string> NavigationCommand =>
            _navigationCommand ?? (_navigationCommand = new DelegateCommand<string>(ExecuteNavigateCommand));

        private void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
                navigationPath = DefaultNavigationPath;

            _regionManager.RequestNavigate(RegionNames.ListContentRegion, navigationPath);
        }
    }
}
