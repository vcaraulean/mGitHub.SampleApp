using System;
using Caliburn.Micro;
using mGitHub.SampleApp.Model;
using Microsoft.Phone.Tasks;

namespace mGitHub.SampleApp.ViewModels
{
	public class RepositoryLinksViewModel : Screen, ILaunchTask, IConfigureTask<WebBrowserTask>
	{
		public RepositoryLinksViewModel()
		{
			DisplayName = "links";

			Links = new BindableCollection<Link>
			{
				new Link{Name= "watchers", AddressTemplate = "http://github.com/{0}/{1}/watchers"},
				new Link{Name= "forks", AddressTemplate = "http://github.com/{0}/{1}/network/members"},
				new Link{Name= "issues", AddressTemplate = "http://github.com/{0}/{1}/issues"},
				new Link{Name= "wiki", AddressTemplate = "http://wiki.github.com/{0}/{1}"},
			};
		}
		public GitHubLocation Location { get; set; }

		public IObservableCollection<Link> Links { get; private set; }

		public Link CurrentLink { get; set; }

		public void Open(Link link)
		{
			CurrentLink = link;
			TaskLaunchRequested(this, TaskLaunchEventArgs.For<WebBrowserTask>());
		}

		public class Link
		{
			public string Name { get; set; }
			public string AddressTemplate { get; set; }
		}

		public event EventHandler<TaskLaunchEventArgs> TaskLaunchRequested =  delegate {};
		public void ConfigureTask(WebBrowserTask task)
		{
			task.URL = string.Format(CurrentLink.AddressTemplate, Location.Username, Location.RepositoryName);
		}
	}
}