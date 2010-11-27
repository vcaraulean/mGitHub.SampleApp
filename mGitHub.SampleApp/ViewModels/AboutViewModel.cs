using System;
using Caliburn.Micro;
using Microsoft.Phone.Tasks;

namespace mGitHub.SampleApp.ViewModels
{
	public class AboutViewModel : Screen,
	                                    ILaunchTask,
	                                    IConfigureTask<WebBrowserTask>

	{
		public event EventHandler<TaskLaunchEventArgs> TaskLaunchRequested = delegate { };
		private string navigateToUrl = "";

		public void ConfigureTask(WebBrowserTask task)
		{
			task.URL = navigateToUrl;
		}

		public void OpenBrowserWithProject()
		{
			navigateToUrl = "https://github.com/vcaraulean/mGitHub.SampleApp";
			TaskLaunchRequested(this, TaskLaunchEventArgs.For<WebBrowserTask>());
		}
	}
}