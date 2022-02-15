using Prism.Regions;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;

namespace PrismWPFHoneys.Modules.Calendar.ViewModels
{
    public class ButtonViewModel : ButtonViewModelBase
    {
        public ButtonViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Initialize();
        }

        public string Caption { get; set; }

        private void Initialize()
        {
            Caption = "Calendar Button";
            ModuleName = AppModuleNames.CalendarModuleName;
        }
    }
}
