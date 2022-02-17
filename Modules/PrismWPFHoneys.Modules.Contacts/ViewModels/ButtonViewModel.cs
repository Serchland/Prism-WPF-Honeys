using Prism.Regions;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;
using System;

namespace PrismWPFHoneys.Modules.Contacts.ViewModels
{
    public class ButtonViewModel : ButtonViewModelBase
    {
        public ButtonViewModel(IApplicationCommands applicationCommands) : base(applicationCommands)
        {
            Initialize();
        }

        public string Caption { get; set; }

        private void Initialize()
        {
            Caption = "Contacts Button";
            ModuleName = AppModuleNames.ContactsModuleName;
        }
    }
}
