﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism_WPF_Honeys.ShellPrism.CustomRegions;
using Prism_WPF_Honeys.Views;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Modules.Calendar;
using PrismWPFHoneys.Modules.Contacts;
using PrismWPFHoneys.Modules.Mail;
using PrismWPFHoneys.ShellPrism.CustomRegion;
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

        protected override void ConfigureDefaultRegionBehaviors(IRegionBehaviorFactory regionBehaviors)
        {
            base.ConfigureDefaultRegionBehaviors(regionBehaviors);
            regionBehaviors.AddIfMissing(DependentViewRegionBehaviour.BehaviourKey, typeof(DependentViewRegionBehaviour));
        }
    }
}
