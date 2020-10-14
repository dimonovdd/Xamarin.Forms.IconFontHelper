using System;
using System.Globalization;
using Xamarin.Forms;

namespace IconFontHelper
{
    public class IconToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            => Helper.IconToString(value);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}
