using PrismWPFHoneys.Core.Types.Interfaces;
using System.Windows.Controls.Ribbon;

namespace PrismWPFHoneys.Modules.Mail.Views
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
