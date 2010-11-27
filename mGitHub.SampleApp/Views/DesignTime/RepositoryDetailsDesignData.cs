using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.Views.DesignTime
{
	public class RepositoryDetailsDesignData
	{
		public RepositoryDetailsDesignData()
		{
			Repository = new Repository()
			{
				Name = "my main repo",
				Description = "this is description of the repository, rather long",
				Homepage = "http://github.com",
				Owner = "vcaraulean",
				Private = false,
				URL = "http://github.com/vcaraulean/repo",
				Watchers = 7,
				OpenIssues = 3,
				Fork = true,
				Forks = 5,
			};
		}

		public Repository Repository { get; set;}
	}
}