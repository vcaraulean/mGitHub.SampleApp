using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.Views.DesignTime
{
	public class RepositoryDetailsDesignData
	{
		public RepositoryDetailsDesignData()
		{
			Repository = new Repository
			{
				Name = "mGitHub.SampleApp",
				Description = "Sample app for Windows Phone 7 using Caliburn.Micro",
				Homepage = "http://mgithub.com",
				Owner = "vcaraulean",
				Private = false,
				URL = "http://github.com/vcaraulean/mGitHub.SampleApp",
				Watchers = 1,
				OpenIssues = 0,
				Fork = true,
				Forks = 5,
			};
		}

		public Repository Repository { get; set;}
	}
}