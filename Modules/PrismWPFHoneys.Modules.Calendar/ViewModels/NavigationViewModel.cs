using Prism.Mvvm;
using Prism.Regions;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Types;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.Calendar.ViewModels
{
    public class NavigationViewModel : NavigationViewModelBase 
    {
        public NavigationViewModel(IRegionManager regionManager) : base (regionManager)
        {
            GenerateMenu();
        }

        public ObservableCollection<NavigationItem> Items { get; set; }

        private void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();

            NavigationItem root = new NavigationItem();
            root.Caption = "Root Calendar";
            root.NavigationPath = "DefaultNavigationPath";

            root.Items.Add(new NavigationItem() { Caption = "Inbox", NavigationPath = "Inbox" });
            root.Items.Add(new NavigationItem() { Caption = "Outbox", NavigationPath = "Outbox" });
            root.Items.Add(new NavigationItem() { Caption = "Draft", NavigationPath = "Draft" });

            Items.Add(root);
        }
    }
}
