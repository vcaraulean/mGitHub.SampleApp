using System.Collections.Generic;
using System.Runtime.Serialization;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.Services
{
	[DataContract]
	public class UserContainer
	{
		[DataMember(Name = "user")]
		public User User { get; set; }
	}

	[DataContract]
	public class RepositoryContainer
	{
		[DataMember(Name = "repository")]
		public Repository Repository { get; set; }
	}

	[DataContract]
    public class RepositoryCollection
    {
        [DataMember(Name = "repositories")]
        public IEnumerable<Repository> Repositories { get; set; }
    }

	[DataContract]
	public class ContributorCollection
	{
		[DataMember(Name = "contributors")]
		public IEnumerable<Contributor> Contributors { get; set; }
	}
}
