using System.Windows;
using System.Windows.Controls;

namespace PrismWPFHoneys.Core.Views
{
    /// <summary>
    /// Lógica de interacción para Navigation.xaml
    /// </summary>
    public partial class NavigationView : TreeView
    {
        public NavigationView()
        {
            InitializeComponent();
        }

        private void TreeView_Loaded(object sender, RoutedEventArgs e)
        {

            this.Loaded -= TreeView_Loaded;
            var treeViewItem = ItemContainerGenerator.ContainerFromItem(this.Items[0]) as TreeViewItem;
            treeViewItem.Focus();
            treeViewItem.IsSelected = true;
            treeViewItem.IsExpanded = true;
        }
    }
}
