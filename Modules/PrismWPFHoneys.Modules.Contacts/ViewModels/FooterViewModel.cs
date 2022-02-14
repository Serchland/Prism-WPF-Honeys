using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.Contacts.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        public FooterViewModel()
        {
            Caption = "Footer footer";
        }

        public string Caption { get; set; }
    }
}
