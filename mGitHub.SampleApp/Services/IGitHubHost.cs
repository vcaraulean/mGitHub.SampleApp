using System;
using System.Collections.Generic;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.Services
{
	public interface IGitHubHost
	{
		void GetUserDetails(string userName, Action<User> resultCallback);
		void GetRepositoryDetails(string ownerName, string repositoryName, Action<Repository> resultCallback);
	    void GetUserRepositories(string userName, Action<IEnumerable<Repository>> resultCallback);
		void GetRepositoryContributors(string ownerName, string RepositoryName, Action<IEnumerable<Contributor>> resultCallback);
		void GetWatchedRepositories(string userName, Action<IEnumerable<Repository>> callback);
	}
}