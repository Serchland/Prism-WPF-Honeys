using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.Contacts.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        public FooterViewModel()
        {
            Caption = "Contacts footer";
        }

        public string Caption { get; set; }
    }
}
