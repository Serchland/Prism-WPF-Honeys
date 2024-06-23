using Fluent;
using PrismWPFHoneys.Core.Types.Interfaces;

namespace PrismWPFHoneys.Modules.Notas.Views
{
    /// <summary>
    /// Lógica de interacción para AppRibbonTab.xaml
    /// </summary>
    public partial class AppRibbonTab : RibbonTabItem, ISupportDataContext
    {
        public AppRibbonTab()
        {
            InitializeComponent();
            //SetResourceReference(StyleProperty, typeof(RibbonTab));
        }

        private void RibbonTabItem_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            this.IsSelected = true;
        }
    }
}
