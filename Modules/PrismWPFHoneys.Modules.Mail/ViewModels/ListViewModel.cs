using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class ListViewModel : BindableBase
    {
        public ListViewModel()
        {
            Message = "List from mail module";
        }

        public string Message { get; set; }
    }
}
