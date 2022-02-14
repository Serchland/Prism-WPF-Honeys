using System.Windows.Controls.Ribbon;

namespace PrismWPFHoneys.Modules.Mail.Views
{
    /// <summary>
    /// Lógica de interacción para AppRibbonTab.xaml
    /// </summary>
    public partial class AppRibbonTab : RibbonTab
    {
        public AppRibbonTab()
        {
            InitializeComponent();
            SetResourceReference(StyleProperty, typeof(RibbonTab));
        }
    }
}
