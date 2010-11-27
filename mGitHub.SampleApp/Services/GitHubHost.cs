using System;
using System.Collections.Generic;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.Services
{
	public class GitHubHost :  IGitHubHost
    {
		private readonly IRequestProcessor requestProcessor;

		public GitHubHost(IRequestProcessor requestProcessor)
		{
			this.requestProcessor = requestProcessor;
		}

		public void GetUserDetails(string userName, Action<User> resultCallback)
		{
            var url = string.Format("{0}{1}",
               "user/show/",
               userName);

			requestProcessor.Query(url, new Action<UserContainer>(container => resultCallback(container.User)));
		}

        public void GetUserRepositories(string userName, Action<IEnumerable<Repository>> resultCallback)
        {
            var url = string.Format("{0}{1}",
                "repos/show/",
                userName);

        	requestProcessor.Query(url, new Action<RepositoryCollection>(c => resultCallback(c.Repositories)));
        }

		public void GetRepositoryDetails(string ownerName, string repositoryName, Action<Repository> resultCallback)
        {
            var url = string.Format("{0}{1}/{2}",
                "repos/show/",
                ownerName,
                repositoryName);

			requestProcessor.Query(url, new Action<RepositoryContainer>(container => resultCallback(container.Repository)));
		}

		public void GetRepositoryContributors(string ownerName, string repositoryName, Action<IEnumerable<Contributor>> resultCallback)
		{
			var url = string.Format("repos/show/{0}/{1}/contributors", 
				ownerName, 
				repositoryName);
			requestProcessor.Query(url, new Action<ContributorCollection>(c => resultCallback(c.Contributors)));
		}
    }
}