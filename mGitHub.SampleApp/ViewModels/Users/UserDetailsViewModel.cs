using System;
using Caliburn.Micro;
using mGitHub.SampleApp.Model;
using mGitHub.SampleApp.Services;
using Microsoft.Phone.Tasks;

namespace mGitHub.SampleApp.ViewModels.Users
{
	public class UserDetailsViewModel : Screen,
	                                    ILaunchTask,
	                                    IConfigureTask<WebBrowserTask>,
	                                    IConfigureTask<EmailComposeTask>
	{
		private readonly IGitHubHost gitHubHost;
		private User user;

		public UserDetailsViewModel(IGitHubHost gitHubHost)
		{
			this.gitHubHost = gitHubHost;
			DisplayName = "details";
		}

		public string UserName { get; set; }

		protected override void OnActivate()
		{
			base.OnActivate();

			gitHubHost.GetUserDetails(UserName, u => User = u);
		}

		public User User
		{
			get { return user; }
			set
			{
				if (user == value)
					return;

				user = value;
				NotifyOfPropertyChange(() => User);
				NotifyOfPropertyChange(() => UserDisplayName);
			}
		}

		public string UserDisplayName
		{
			get
			{
				if (User == null)
					return string.Empty;
				return string.IsNullOrEmpty(User.Name) ? UserName : User.Name;
			}
		}

		public void OpenUsersHomepage()
		{
			TaskLaunchRequested(this, TaskLaunchEventArgs.For<WebBrowserTask>());
		}

		public void SendEmail()
		{
			TaskLaunchRequested(this, TaskLaunchEventArgs.For<EmailComposeTask>());
		}

		public event EventHandler<TaskLaunchEventArgs> TaskLaunchRequested = delegate { };

		public void ConfigureTask(WebBrowserTask task)
		{
			task.URL = User.Blog;
		}

		public void ConfigureTask(EmailComposeTask task)
		{
			task.To = User.Email;
		}
	}
}