using PrismWPFHoneys.Core.Types.CustomAttribute;
using PrismWPFHoneys.Core.Types.Prism;
using System.Windows.Controls;

namespace PrismWPFHoneys.Modules.Calendar.Views
{
    /// <summary>
    /// Lógica de interacción para AppNavigationViewModel.xaml
    /// </summary>
    /// 
    [DependentView(RegionNames.RibbonContentRegion, typeof(AppRibbonTab))]
    public partial class AppNavigation : UserControl
    {
        public AppNavigation()
        {
            InitializeComponent();
        }
    }
}
