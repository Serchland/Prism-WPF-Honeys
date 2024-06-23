using Prism.Events;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Events;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class ButtonViewModel : ButtonViewModelBase
    { 

        private IEventAggregator _ea;
        public ButtonViewModel(IApplicationCommands applicationCommands, IEventAggregator ea) : base(applicationCommands)
        {
            _ea = ea;
            _ea.GetEvent<OnModuleInitializedEvent>().Subscribe(ModuleInitialized);
            Initialize();
        }

        public string Caption { get; set; }

        private void Initialize()
        {
            Caption = "Mail Button";
            ModuleName = AppModuleNames.MailModuleName;
        }

        private void ModuleInitialized(string moduleInitialized)
        {
            if (moduleInitialized == AppModuleNames.MailModuleName)
            {
                Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
