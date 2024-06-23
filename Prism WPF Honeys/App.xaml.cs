using AutoMapper;
using ControlzEx.Theming;
using Fluent;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism_WPF_Honeys.ShellPrism.CustomRegions;
using Prism_WPF_Honeys.ShellPrism.Dialogs;
using Prism_WPF_Honeys.ShellPrism.Mappings;
using Prism_WPF_Honeys.Views;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Modules.Calendar;
using PrismWPFHoneys.Modules.Contacts;
using PrismWPFHoneys.Modules.Mail;
using PrismWPFHoneys.ShellPrism.CustomRegion;
using System.Windows;
using System.Windows.Controls;

namespace Prism_WPF_Honeys
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void OnInitialized()
        {
            var login = Container.Resolve<Login>();
            var result = login.ShowDialog();

            if ((bool)result)
                base.OnInitialized();
            else
                Application.Current.Shutdown();

            ////TODO: Aplicar estilos.
            ///Dark.Green
            ///ThemeManager.Current.ChangeTheme(this, "Dark.Green");

            base.OnInitialized();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
            containerRegistry.RegisterSingleton<IMyDialogService, MyDialogService>();

            //containerRegistry.RegisterDialog<CustomDetailDialog
           
            // Configurar AutoMapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>(); // Donde MappingProfile es tu clase de perfil de mapeo
                                                  // Configura otras asignaciones si es necesario.
            });

            IMapper mapper = config.CreateMapper();

            // Registra IMapper en el contenedor de Prism para que esté disponible para la inyección de dependencias.
            containerRegistry.RegisterInstance(mapper);
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MailModule>();
            moduleCatalog.AddModule<ContactsModule>();
            moduleCatalog.AddModule<CalendarModule>();
            
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel), Container.Resolve<StackPanelRegionAdapter>());
            regionAdapterMappings.RegisterMapping(typeof(Ribbon), Container.Resolve<RibbonRegionAdapter>());
        }

        protected override void ConfigureDefaultRegionBehaviors(IRegionBehaviorFactory regionBehaviors)
        {
            base.ConfigureDefaultRegionBehaviors(regionBehaviors);
            regionBehaviors.AddIfMissing(DependentViewRegionBehaviour.BehaviourKey, typeof(DependentViewRegionBehaviour));
        }
    }
}
