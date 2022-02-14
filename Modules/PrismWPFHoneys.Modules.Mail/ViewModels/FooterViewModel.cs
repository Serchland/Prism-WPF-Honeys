using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        public FooterViewModel()
        {
            Caption = "Mail footer";
        }

        public string Caption { get; set; }
    }
}
