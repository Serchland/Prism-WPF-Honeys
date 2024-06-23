using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.Notas.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        public FooterViewModel()
        {
            Caption = "Notas footer";
        }

        public string Caption { get; set; }
    }
}
