using PrismWPFHoneys.Core.Types.CustomAttribute;
using PrismWPFHoneys.Core.Types.Interfaces;
using PrismWPFHoneys.Core.Types.Prism;
using System.Windows.Controls;

namespace PrismWPFHoneys.Modules.Contacts.Views
{
    /// <summary>
    /// Lógica de interacción para AppList.xaml
    /// </summary>
    /// 
    [DependentView(RegionNames.RibbonContentRegion, typeof(AppRibbonTab))]
    public partial class AppList : UserControl, ISupportDataContext
    {
        public AppList()
        {
            InitializeComponent();
        }
    }
}
