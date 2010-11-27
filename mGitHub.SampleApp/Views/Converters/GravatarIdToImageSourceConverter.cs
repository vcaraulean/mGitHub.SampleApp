using System;
using System.Globalization;
using System.Windows.Data;

namespace mGitHub.SampleApp.Views.Converters
{
	public class GravatarIdToImageSourceConverter : IValueConverter
	{
		private const string gravatarAddress = "http://gravatar.com/avatar/";
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
				return gravatarAddress;
			var gravatarId = value as string;
			if (string.IsNullOrEmpty(gravatarId))
				return gravatarAddress;
			return gravatarAddress + gravatarId;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}