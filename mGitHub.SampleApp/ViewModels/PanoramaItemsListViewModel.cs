using Caliburn.Micro;
using mGitHub.SampleApp.Model;
using mGitHub.SampleApp.Services;

namespace mGitHub.SampleApp.ViewModels
{
	public class PanoramaItemsListViewModel : Screen
	{
		private readonly INavigationService navigationService;

		public PanoramaItemsListViewModel(INavigationService navigationService)
		{
			this.navigationService = navigationService;
			Items = new BindableCollection<GitHubLocation>();
		}

		public IObservableCollection<GitHubLocation> Items { get; private set; }

		public void OpenLocation(GitHubLocation location)
		{
			navigationService.Navigate(location);
		}
	}
}