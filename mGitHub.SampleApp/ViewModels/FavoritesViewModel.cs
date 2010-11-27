using Caliburn.Micro;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.ViewModels
{
	public class FavoritesViewModel : PanoramaItemsListViewModel
	{
		public FavoritesViewModel(INavigationService navigationService) : base(navigationService)
		{
			Items.AddRange(new[]
			{
				new GitHubLocation{Name = "mGitHub.SampleApp", RelativeAddress = "vcaraulean/mGitHub.SampleApp"},
				new GitHubLocation{Name = "Jeff Wilcox/wp-essentials", RelativeAddress = "jeffwilcox/wpessentials"},
				new GitHubLocation{Name = "Castle Project", RelativeAddress = "Castleproject"},
				new GitHubLocation{Name = "NServiceBus", RelativeAddress= "NServiceBus/NServiceBus"},
				new GitHubLocation{Name = "Fluent NHibernate", RelativeAddress= "jagregory/fluent-nhibernate"},
				new GitHubLocation{Name = "AutoMapper", RelativeAddress= "jbogard/AutoMapper"},
				new GitHubLocation{Name = "Mono Project", RelativeAddress= "mono"},
				new GitHubLocation{Name = "RavenDb", RelativeAddress= "ravendb"},
			});
		}
	}
}