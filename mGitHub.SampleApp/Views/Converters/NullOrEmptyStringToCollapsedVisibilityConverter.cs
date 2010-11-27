using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace mGitHub.SampleApp.Views.Converters
{
	public class NullOrEmptyStringToCollapsedVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
				return Visibility.Collapsed;

			var stringValue = value as string;
			if (string.IsNullOrEmpty(stringValue))
				return Visibility.Collapsed;

			return Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}