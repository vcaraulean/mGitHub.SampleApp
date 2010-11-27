using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using mGitHub.SampleApp.Model;
using mGitHub.SampleApp.Services;

namespace mGitHub.SampleApp.ViewModels.Repositories
{
	public class RepositoryContributorsViewModel : Screen
	{
		private readonly INavigationService navigationService;
		private readonly IGitHubHost github;

		public RepositoryContributorsViewModel(INavigationService navigationService, IGitHubHost github)
		{
			this.navigationService = navigationService;
			this.github = github;

			DisplayName = "contributors";
		}

		public GitHubLocation RepositoryLocation { get; set; }

		public IObservableCollection<Contributor> Contributors { get; set; }

		protected override void OnActivate()
		{
			base.OnActivate();
			github.GetRepositoryContributors(RepositoryLocation.Username,
			                                 RepositoryLocation.RepositoryName,
			                                 ContributorsReceived);
		}

		private void ContributorsReceived(IEnumerable<Contributor> r)
		{
			Contributors = new BindableCollection<Contributor>(r);
			Contributors.OrderBy(c => c.Contributions);
			NotifyOfPropertyChange(() => Contributors);
		}

		public void Show(Contributor contributor)
		{
			navigationService.Navigate(new GitHubLocation(contributor.Login, null));
		}
	}
}