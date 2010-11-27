using Caliburn.Micro;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.ViewModels
{
	public class FavoritesViewModel : PanoramaItemsListViewModel
	{
		public FavoritesViewModel(INavigationService navigationService) : base(navigationService)
		{
			DisplayName = "favorites";

			Items.AddRange(new[]
			{
				new GitHubLocation{Name = "Castle Project", RelativeAddress = "Castleproject"},
				new GitHubLocation{Name = "NServiceBus", RelativeAddress= "NServiceBus/NServiceBus"},
				new GitHubLocation{Name = "RavenDb", RelativeAddress= "ravendb"},
				new GitHubLocation{Name = "Rails", RelativeAddress= "rails/rails"},
			});
		}
	}
}