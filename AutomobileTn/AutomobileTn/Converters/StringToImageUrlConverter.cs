using System;
using System.Globalization;
using Xamarin.Forms;

namespace AutomobileTn.Converters
{
	public class StringToImageUrlConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var str = value as string;

			str = str.Replace(" ", "");

			var imageUrl = "Images/" + str + ".png";	// Images/CarsManifacturers/BMW.png

			return imageUrl;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
