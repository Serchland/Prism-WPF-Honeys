using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism_WPF_Honeys.Views;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Modules.Calendar;
using PrismWPFHoneys.Modules.Contacts;
using PrismWPFHoneys.Modules.Mail;
using PrismWPFHoneys.Prism.CustomRegion;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;

namespace Prism_WPF_Honeys
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<CalendarModule>();
            moduleCatalog.AddModule<ContactsModule>();
            moduleCatalog.AddModule<MailModule>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
            regionAdapterMappings.RegisterMapping(typeof(Ribbon), Container.Resolve<RibbonRegionAdapter>());
        }
    }
}
