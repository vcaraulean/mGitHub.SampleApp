using Caliburn.Micro;

namespace mGitHub.SampleApp.ViewModels.User
{
	[SurviveTombstone]
	public class UserPivotViewModel : PivotViewModel
	{
		private readonly UserDetailsViewModel details;
		private readonly UserRepositoriesViewModel repositoriesViewModel;
		private readonly UserWatchingViewModel watchingViewModel;

		public UserPivotViewModel(UserDetailsViewModel details,
		                          UserRepositoriesViewModel repositoriesViewModel,
		                          UserWatchingViewModel watchingViewModel)
		{
			this.details = details;
			this.repositoriesViewModel = repositoriesViewModel;
			this.watchingViewModel = watchingViewModel;
		}

		public string Username { get; set; }

		public string PivotTitle
		{
			get { return string.Format("GITHUB | {0}", Username); }
		}

		protected override void OnInitialize()
		{
			base.OnInitialize();

			Items.Add(details);
			Items.Add(repositoriesViewModel);
			Items.Add(watchingViewModel);

			ActivateItem(details);
		}

		protected override void OnActivate()
		{
			details.UserName = Username;
			repositoriesViewModel.UserName = Username;
			watchingViewModel.UserName = Username;

			base.OnActivate();

			NotifyOfPropertyChange(() => PivotTitle);
		}
	}
}