using Caliburn.Micro;
using mGitHub.SampleApp.Model;
using mGitHub.SampleApp.Services;

namespace mGitHub.SampleApp.ViewModels.Repositories
{
	public class RepositoryDetailsViewModel : Screen
	{
		readonly IGitHubHost github;

		public RepositoryDetailsViewModel(IGitHubHost github)
		{
			this.github = github;
			DisplayName = "details";
		}

		public GitHubLocation Location { get; set; }

		protected override void OnActivate()
		{
			base.OnActivate();

			Repository = null;
			github.GetRepositoryDetails(Location.Username, Location.RepositoryName, r => Repository = r);
		}

		private Repository repository;
		public Repository Repository
		{
			get { return repository; }
			set
			{
				if (repository == value)
					return;

				repository = value;
				NotifyOfPropertyChange(() => Repository);
			}
		}
	}
}