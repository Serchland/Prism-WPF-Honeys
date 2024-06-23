using PrismWPFHoneys.Business;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Core.Types.Types;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.Registro.ViewModels
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
            root.Caption = "Root Registro";
            root.NavigationPath = GetNavigationPath("Default");

            root.Items.Add(new NavigationItem() { Caption = "Item 1", NavigationPath = GetNavigationPath("Item 1") });
            root.Items.Add(new NavigationItem() { Caption = "Item 2", NavigationPath = GetNavigationPath("Item 2") });
            root.Items.Add(new NavigationItem() { Caption = "Item 3", NavigationPath = GetNavigationPath("Item 3") });

            Items.Add(root);
        }

        protected override string GetNavigationPath(string item)
        {
            return string.Format("{0}{1}{2}", RegisterForNavigation.RegistroListContentRegion, "?id=", item);
        }
    }
}
