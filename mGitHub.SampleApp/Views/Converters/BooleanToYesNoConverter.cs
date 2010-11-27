using System;
using System.Globalization;
using System.Windows.Data;

namespace mGitHub.SampleApp.Views.Converters
{
	public class BooleanToYesNoConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{

			if (value is Boolean)
			{
				var boolValue = (bool)value;
				return boolValue ? "Yes" : "No";
			}

			throw new ArgumentException("Boolean expected");
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}