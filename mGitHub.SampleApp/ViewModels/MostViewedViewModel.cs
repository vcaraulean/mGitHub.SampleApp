using Caliburn.Micro;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.ViewModels
{
	public class MostViewedViewModel : PanoramaItemsListViewModel
	{
		public MostViewedViewModel(INavigationService navigationService) : base(navigationService)
		{
			Items.AddRange(new[]
			{
				new GitHubLocation {Name = "git", RelativeAddress = "git/git"},
				new GitHubLocation {Name = "jquery", RelativeAddress = "jquery/jquery"},
				new GitHubLocation {Name = "Ruby on Rails", RelativeAddress = "rails/rails"},
				new GitHubLocation {Name = "Apache Software Foundation", RelativeAddress = "apache"},
				new GitHubLocation {Name = "Facebook", RelativeAddress = "facebook"},
			});
		}
	}
}