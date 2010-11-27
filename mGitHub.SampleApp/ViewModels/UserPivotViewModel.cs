using Caliburn.Micro;

namespace mGitHub.SampleApp.ViewModels
{
	[SurviveTombstone]
	public class UserPivotViewModel : PivotViewModel
	{
		private readonly UserDetailsViewModel userDetails;
		private readonly UserRepositoriesViewModel userRepositories;

		public UserPivotViewModel(UserDetailsViewModel userDetails, UserRepositoriesViewModel userRepositories)
		{
			this.userDetails = userDetails;
			this.userRepositories = userRepositories;
		}

		public string Username { get; set; }

		public string PivotTitle
		{
			get { return string.Format("GITHUB | {0}", Username); }
		}

		protected override void OnInitialize()
		{
			base.OnInitialize();

			Items.Add(userDetails);
			Items.Add(userRepositories);

			ActivateItem(userDetails);
		}

		protected override void OnActivate()
		{
			userDetails.UserName = Username;
			userRepositories.UserName = Username;

			base.OnActivate();

			NotifyOfPropertyChange(() => PivotTitle);
		}
	}
}