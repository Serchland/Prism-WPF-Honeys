using Prism.Regions;
using PrismWPFHoneys.Business;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Core.Types.Types;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.GestDoc.ViewModels
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
            root.Caption = "Root GestDoc";
            root.NavigationPath = GetNavigationPath(Folders.GestDoc.Default);

            root.Items.Add(new NavigationItem() { Caption = Folders.GestDoc.Expedientes, NavigationPath = GetNavigationPath(Folders.GestDoc.Expedientes) });
            root.Items.Add(new NavigationItem() { Caption = Folders.GestDoc.Boletines, NavigationPath = GetNavigationPath(Folders.GestDoc.Boletines) });
            root.Items.Add(new NavigationItem() { Caption = Folders.GestDoc.Mayores52, NavigationPath = GetNavigationPath(Folders.GestDoc.Mayores52) });

            Items.Add(root);
        }

        protected override string GetNavigationPath(string item)
        {
            return string.Format("{0}{1}{2}", RegisterForNavigation.GestDocListContentRegion, "?id=", item);
        }    
    }
}
