using Prism_WPF_Honeys.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using PrismWPFHoneys.Modules.Calendar;
using PrismWPFHoneys.Modules.Contacts;
using PrismWPFHoneys.Modules.Mail;

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

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<CalendarModule>();
            moduleCatalog.AddModule<ContactsModule>();
            moduleCatalog.AddModule<MailModule>();
        }
    }
}
