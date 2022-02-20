﻿using PrismWPFHoneys.Core.Types.Interfaces;
using System.Windows.Controls.Ribbon;

namespace PrismWPFHoneys.Modules.Contacts.Views
{
    /// <summary>
    /// Lógica de interacción para AppRibbonTab.xaml
    /// </summary>
    public partial class AppRibbonTab : RibbonTab, ISupportDataContext
    {
        public AppRibbonTab()
        {
            InitializeComponent();
            //SetResourceReference(StyleProperty, typeof(RibbonTab));
        }
    }
}
