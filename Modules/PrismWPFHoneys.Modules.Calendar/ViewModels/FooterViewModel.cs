using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.Calendar.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        public FooterViewModel()
        {
            Caption = "Calendar footer";
        }

        public string Caption { get; set; }
    }
}
