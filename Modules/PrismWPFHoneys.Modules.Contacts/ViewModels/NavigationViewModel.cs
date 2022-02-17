using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Core.Types.Types;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.Contacts.ViewModels
{
    public class NavigationViewModel : NavigationViewModelBase 
    {
        public NavigationViewModel(IApplicationCommands applicationCommands) : base(applicationCommands)
        {
            GenerateMenu();
        }

        public ObservableCollection<NavigationItem> Items { get; set; }

        private void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();

            NavigationItem root = new NavigationItem();
            root.Caption = "Root Contacts";
            root.NavigationPath = GetNavigationPath("Default");

            root.Items.Add(new NavigationItem() { Caption = "Active contacts", NavigationPath = GetNavigationPath("Active") });
            root.Items.Add(new NavigationItem() { Caption = "Inactive contacts", NavigationPath = GetNavigationPath("Inactive") });
            root.Items.Add(new NavigationItem() { Caption = "Deleted", NavigationPath = GetNavigationPath("Deleted") });

            Items.Add(root);
        }

        protected override string GetNavigationPath(string item)
        {
            return string.Format("{0}{1}{2}", RegisterForNavigation.ContactsListContentRegion, "?id=", item);
        }
    }
}
