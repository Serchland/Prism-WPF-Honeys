using Prism.Mvvm;

namespace Prism_WPF_Honeys.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
        }

        public string Title { get; set; }        
    }
}
