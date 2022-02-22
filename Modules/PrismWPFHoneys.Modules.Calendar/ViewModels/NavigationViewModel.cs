using Prism.Regions;
using PrismWPFHoneys.Business;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Core.Types.Types;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.Calendar.ViewModels
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
            root.Caption = "Root Calendar";
            root.NavigationPath = GetNavigationPath("Default");

            root.Items.Add(new NavigationItem() { Caption = "Weekly", NavigationPath = GetNavigationPath("Weekly") });
            root.Items.Add(new NavigationItem() { Caption = "Monthly", NavigationPath = GetNavigationPath("Monthly") });
            root.Items.Add(new NavigationItem() { Caption = "Annual", NavigationPath = GetNavigationPath("Annual") });

            Items.Add(root);
        }

        protected override string GetNavigationPath(string item)
        {
            return string.Format("{0}{1}{2}", RegisterForNavigation.CalendarListContentRegion, "?id=", item);
        }
    }
}
