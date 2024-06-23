using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.Registro.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        public FooterViewModel()
        {
            Caption = "Registro footer";
        }

        public string Caption { get; set; }
    }
}
