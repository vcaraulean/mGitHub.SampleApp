using Caliburn.Micro;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.ViewModels
{
	public class MostViewedViewModel : PanoramaItemsListViewModel
	{
		public MostViewedViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			DisplayName = "most viewed";

			Items.AddRange(new[]
			{
				new GitHubLocation {Name = "Rails", RelativeAddress = "rails/rails"},
				new GitHubLocation {Name = "jquery", RelativeAddress = "jquery/jquery"},
				new GitHubLocation {Name = "node", RelativeAddress = "ry/node"},
			});
		}
	}
}