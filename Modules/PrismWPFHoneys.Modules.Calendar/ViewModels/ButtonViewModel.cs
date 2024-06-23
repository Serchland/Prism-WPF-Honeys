using Prism.Events;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Events;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.Calendar.ViewModels
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
            Caption = "Calendar Button";
            ModuleName = AppModuleNames.CalendarModuleName;
        }

        private void ModuleInitialized(string moduleInitialized)
        {
            if (moduleInitialized == AppModuleNames.CalendarModuleName)
            {
                Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
