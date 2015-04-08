using System;
using System.Globalization;
using Xamarin.Forms;

namespace AutomobileTn.Converters
{
	public class IntToPriceConverter : IValueConverter
    {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (!(value is int)) return value;

			var number = (int)value;

			var result = number / 1000 + " k DT";

			return result;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
    }
}
