using Caliburn.Micro;
using mGitHub.SampleApp.Model;
using mGitHub.SampleApp.Services;

namespace mGitHub.SampleApp.ViewModels.Users
{
	public class UserRepositoriesViewModel : Screen
	{
		private readonly INavigationService navigationService;
		private readonly IGitHubHost gitHubHost;

		public UserRepositoriesViewModel(INavigationService navigationService, IGitHubHost gitHubHost)
		{
			this.navigationService = navigationService;
			this.gitHubHost = gitHubHost;
			DisplayName = "repositories";
		}

		public string UserName { get; set; }

		protected override void OnActivate()
		{
			base.OnActivate();
			gitHubHost.GetUserRepositories(UserName,
									 list =>
									 {
									 	Repositories = new BindableCollection<Repository>(list);
										NotifyOfPropertyChange(() => Repositories);
									 });
		}

		public IObservableCollection<Repository> Repositories { get; set; }

		public void Open(Repository repository)
		{
			navigationService.Navigate(new GitHubLocation(repository.Owner, repository.Name));
		}
	}
}