using Prism.Mvvm;
using PrismWPFHoneys.Core.Types.Types;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class NavigationViewModel : BindableBase
    {
        public NavigationViewModel()
        {
            GenerateMenu();
        }

        public ObservableCollection<NavigationItem> Items { get; set; }

        private void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();

            NavigationItem root = new NavigationItem();
            root.Caption = "Root Mail";
            root.NavigationPath = "DefaultNavigationPath";

            root.Items.Add(new NavigationItem() { Caption = "Inbox", NavigationPath = "Inbox" });
            root.Items.Add(new NavigationItem() { Caption = "Outbox", NavigationPath = "Outbox" });
            root.Items.Add(new NavigationItem() { Caption = "Draft", NavigationPath = "Draft" });

            Items.Add(root);
        }
    }
}
