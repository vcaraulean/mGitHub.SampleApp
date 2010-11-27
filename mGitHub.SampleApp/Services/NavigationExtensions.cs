using System;
using Caliburn.Micro;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.Services
{
	public static class NavigationExtensions
	{
		public static bool Navigate(this INavigationService navigationService, GitHubLocation location)
		{
			return navigationService.Navigate(To(location));
		}

		private const string RepositoryPivot = "/Views/RepositoryPivotView.xaml?Username={0}&RepositoryName={1}";
		private const string UserPivot = "/Views/UserPivotView.xaml?Username={0}";

		private static Uri To(GitHubLocation location)
		{
			var path = location.IsRepository ? RepositoryPivot : UserPivot;
			return FormatUri(path, location);
		}

		private static Uri FormatUri(string path, GitHubLocation location)
		{
			var parameters = location.RelativeAddress.Split('/');
			return new Uri(string.Format(path, parameters), UriKind.RelativeOrAbsolute);
		}
	}
}