using System;
using System.Globalization;
using Xamarin.Forms;

namespace TipCalculator.Converters
{
    public class DecimalToMoney : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var decimalValue = (decimal) value;
            return decimalValue.ToString("C");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var stringValue = (string) value;
            return stringValue.Remove(0);
        }
    }
}