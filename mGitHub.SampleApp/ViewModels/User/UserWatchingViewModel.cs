using Caliburn.Micro;
using mGitHub.SampleApp.Model;
using mGitHub.SampleApp.Services;

namespace mGitHub.SampleApp.ViewModels.User
{
	public class UserWatchingViewModel : Screen
	{
		private readonly INavigationService navigationService;
		private readonly IGitHubHost gitHubHost;

		public UserWatchingViewModel(INavigationService navigationService, IGitHubHost gitHubHost)
		{
			this.navigationService = navigationService;
			this.gitHubHost = gitHubHost;
			DisplayName = "watching";
		}

		public string UserName { get; set; }

		protected override void OnActivate()
		{
			base.OnActivate();
			gitHubHost.GetWatchedRepositories(UserName,
									 list =>
									 {
										 Repositories = new BindableCollection<Model.Repository>(list);
										 NotifyOfPropertyChange(() => Repositories);
									 });
		}

		public IObservableCollection<Model.Repository> Repositories { get; set; }

		public void Open(Model.Repository repository)
		{
			navigationService.Navigate(new GitHubLocation(repository.Owner, repository.Name));
		}

	}
}