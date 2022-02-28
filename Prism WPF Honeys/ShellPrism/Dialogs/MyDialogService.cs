using Prism.Ioc;
using Prism.Regions;
using Prism.Services.Dialogs;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Services.Interfaces;
using PrismWPFHoneys.ShellPrism.Dialogs;
using System;
using System.Windows;
using System.Windows.Media;

namespace Prism_WPF_Honeys.ShellPrism.Dialogs
{
    public class MyDialogService : IMyDialogService
    {
        //SERCH00: I am not sure if I am happy with this implementation
        private readonly IRegionManager _regionManager;
        private readonly IMailService _mailService;

        private DetailWindow _window;
        private int _messageId;

        public MyDialogService(IRegionManager regionManager, IMailService mailService)
        {
            _regionManager = regionManager;
            _mailService = mailService;
        }

        public void Show(string name, int messageId)
        {
            //var window = _containerExtension.Resolve<DetailWindow>();
            _window = new DetailWindow();
            var scopedRegionManager = _regionManager.CreateRegionManager();

            RegionManager.SetRegionManager(_window, scopedRegionManager);
            scopedRegionManager.RequestNavigate(RegionNames.RibbonContentRegion, name);

            //window.DataContext = window.RibbonControlContent.Items.GetItemAt(0);
            _window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _window.ShowInTaskbar = true;
            _window.ShowActivated = true;
            _window.Owner = Application.Current.MainWindow;

            _messageId = messageId;
            _window.Loaded += OnWindow_Loaded;
            _window.Show();

            var detailMessage = _mailService.GetDetailMessage(messageId);
        }

        private void OnWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _window.Loaded -= OnWindow_Loaded;
            _window.DataContext = _mailService.GetDetailMessage(_messageId);
        }
    }
}
