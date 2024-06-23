using Prism.Events;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Events;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;
using System;

namespace PrismWPFHoneys.Modules.Contacts.ViewModels
{
    public class ButtonViewModel : ButtonViewModelBase
    {
        IEventAggregator _ea;
        public ButtonViewModel(IApplicationCommands applicationCommands, IEventAggregator ea) : base(applicationCommands)
        {
            _ea = ea;
            _ea.GetEvent<OnModuleInitializedEvent>().Subscribe(ModuleInitialized);
            Initialize();
        }

        public string Caption { get; set; }

        private void Initialize()
        {
            Caption = "Contacts Button";
            ModuleName = AppModuleNames.ContactsModuleName;
        }

        private void ModuleInitialized(string moduleInitialized)
        {
            if (moduleInitialized == AppModuleNames.ContactsModuleName)
            {
                Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
