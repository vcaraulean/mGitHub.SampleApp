using Caliburn.Micro;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.ViewModels
{
	[SurviveTombstone]
	public class RepositoryPivotViewModel : PivotViewModel
	{
		private readonly RepositoryDetailsViewModel repositoryDetails;
		private readonly RepositoryContributorsViewModel contributors;
		private readonly RepositoryLinksViewModel links;

		public RepositoryPivotViewModel(RepositoryDetailsViewModel repositoryDetails,
		                                RepositoryContributorsViewModel contributors,
		                                RepositoryLinksViewModel links)
		{
			this.repositoryDetails = repositoryDetails;
			this.contributors = contributors;
			this.links = links;
		}

		public string Username { get; set; }
		public string RepositoryName { get; set; }

		public string PivotTitle
		{
			get { return string.Format("GITHUB | {0} / {1}", Username, RepositoryName); }
		}

		protected override void OnInitialize()
		{
			base.OnInitialize();

			Items.Add(repositoryDetails);
			Items.Add(contributors);
			Items.Add(links);

			ActivateItem(repositoryDetails);
		}

		protected override void OnActivate()
		{
			var newLocation = new GitHubLocation(Username, RepositoryName);
			repositoryDetails.Location = newLocation;
			links.Location = newLocation;
			contributors.RepositoryLocation = newLocation;

			base.OnActivate();

			NotifyOfPropertyChange(() => PivotTitle);
		}
	}
}