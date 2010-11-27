namespace mGitHub.SampleApp.Model
{
	public class GitHubLocation
	{
		public GitHubLocation()
		{
		}

		public GitHubLocation(string userName, string repositoryName)
		{
			Username = userName;
			RepositoryName = repositoryName;
		}

		public string Name { get; set; }
		public string Username { get; private set; }
		public string RepositoryName { get; private set; }

		public string Address
		{
			get
			{
				return "https://github.com/" + RelativeAddress;
			}
		}

		public string RelativeAddress
		{
			get
			{
				if (IsRepository)
					return string.Format("{0}/{1}", Username, RepositoryName);
				return Username;
			}
			set
			{
				var values = value.Split('/');

				if (values.Length >= 1)
					Username = values[0];
				if (values.Length == 2)
					RepositoryName = values[1];
			}
		}

		public bool IsRepository
		{
			get { return !string.IsNullOrEmpty(RepositoryName); }
		}
	}
}