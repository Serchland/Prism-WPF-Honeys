using PrismWPFHoneys.Business;
using PrismWPFHoneys.Core.Types.Types;
using System;
using System.Globalization;
using System.Windows.Data;

namespace PrismWPFHoneys.Core.Views.Converters
{
    public class SelectedItemToNavigationPathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var item = value as NavigationItem;
                return item.NavigationPath;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
