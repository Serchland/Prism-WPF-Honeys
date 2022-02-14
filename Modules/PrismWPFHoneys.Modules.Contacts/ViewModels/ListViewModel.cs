using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.Contacts.ViewModels
{
    public class ListViewModel : BindableBase
    {
        public ListViewModel()
        {
            Message = "List from contacts module";
        }

        public string Message { get; set; }
    }
}
