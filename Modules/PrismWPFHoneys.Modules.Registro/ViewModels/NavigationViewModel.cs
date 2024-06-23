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

            root.Items.Add(new NavigationItem() { Caption = Folders.Registro.Item1, NavigationPath = GetNavigationPath(Folders.Registro.Item1) });
            root.Items.Add(new NavigationItem() { Caption = Folders.Registro.Item2, NavigationPath = GetNavigationPath(Folders.Registro.Item2) });
            root.Items.Add(new NavigationItem() { Caption = Folders.Registro.Item3, NavigationPath = GetNavigationPath(Folders.Registro.Item3) });

            Items.Add(root);
        }

        protected override string GetNavigationPath(string item)
        {
            return string.Format("{0}{1}{2}", RegisterForNavigation.RegistroListContentRegion, "?id=", item);
        }
    }
}
