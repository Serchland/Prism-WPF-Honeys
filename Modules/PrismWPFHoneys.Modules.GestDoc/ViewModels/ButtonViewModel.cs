using Prism.Events;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Events;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.GestDoc.ViewModels
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
            Caption = "GestDoc Button";
            ModuleName = AppModuleNames.GestDocModuleName;
        }

        private void ModuleInitialized(string moduleInitialized)
        {
            if (moduleInitialized == AppModuleNames.GestDocModuleName)
            {
                Enabled = true;
            }
        }
    }
}
