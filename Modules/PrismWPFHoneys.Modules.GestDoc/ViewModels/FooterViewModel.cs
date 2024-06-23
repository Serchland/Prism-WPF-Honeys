using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.GestDoc.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        public FooterViewModel()
        {
            Caption = "GestDoc footer";
        }

        public string Caption { get; set; }
    }
}
