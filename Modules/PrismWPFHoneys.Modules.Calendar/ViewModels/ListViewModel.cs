using Prism.Mvvm;

namespace PrismWPFHoneys.Modules.Calendar.ViewModels
{
    public class ListViewModel : BindableBase
    {
        public ListViewModel()
        {
            Message = "List from calendar module";
        }

        public string Message { get; set; }
    }
}
