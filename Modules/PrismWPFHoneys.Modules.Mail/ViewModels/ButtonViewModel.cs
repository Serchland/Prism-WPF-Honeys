using Prism.Regions;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class ButtonViewModel : ButtonViewModelBase
    { 
        public ButtonViewModel(IRegionManager regionManager, IApplicationCommands applicationCommands) : base(regionManager, applicationCommands)
        {
            Initialize();
        }

        public string Caption { get; set; }

        private void Initialize()
        {
            Caption = "Mail Button";
            ModuleName = AppModuleNames.MailModuleName;
        }
    }
}
