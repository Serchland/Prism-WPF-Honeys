using PrismWPFHoneys.Business;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.Notas.ViewModels
{
    public class NavigationViewModel : NavigationViewModelBase 
    {
        public NavigationViewModel(IApplicationCommands applicationCommands) : base (applicationCommands)
        {
            GenerateMenu();
        }

        public ObservableCollection<NavigationItem> Items { get; set; }

        private void GenerateMenu()
        {
            Items = new ObservableCollection<NavigationItem>();

            NavigationItem root = new NavigationItem();
            root.Caption = "Root Notas";
            root.NavigationPath = GetNavigationPath("Default");

            root.Items.Add(new NavigationItem() { Caption = "item 1", NavigationPath = GetNavigationPath("item 1") });
            root.Items.Add(new NavigationItem() { Caption = "item 2", NavigationPath = GetNavigationPath("item 2") });
            root.Items.Add(new NavigationItem() { Caption = "item 3", NavigationPath = GetNavigationPath("item 3") });

            Items.Add(root);
        }

        protected override string GetNavigationPath(string item)
        {
            return string.Format("{0}{1}{2}", RegisterForNavigation.NotasListContentRegion, "?id=", item);
        }
    }
}
