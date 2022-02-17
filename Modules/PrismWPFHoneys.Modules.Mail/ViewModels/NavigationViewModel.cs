﻿using Prism.Regions;
using PrismWPFHoneys.Core.Types.Base;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using PrismWPFHoneys.Core.Types.Types;
using System.Collections.ObjectModel;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
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
            root.Caption = "Root Mail";
            root.NavigationPath = GetNavigationPath("Default");

            root.Items.Add(new NavigationItem() { Caption = "Inbox", NavigationPath = GetNavigationPath("Inbox") });
            root.Items.Add(new NavigationItem() { Caption = "Outbox", NavigationPath = GetNavigationPath("Outbox") });
            root.Items.Add(new NavigationItem() { Caption = "Draft", NavigationPath = GetNavigationPath("Draft") });

            Items.Add(root);
        }

        protected override string GetNavigationPath(string item)
        {
            return string.Format("{0}{1}{2}", RegisterForNavigation.MailListContentRegion, "?id=", item);
        }    
    }
}
