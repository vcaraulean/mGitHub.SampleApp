using System;
using System.Runtime.Serialization;

namespace mGitHub.SampleApp.Model
{
	[DataContract(Name = "user")]
    public class User
    {
		[DataMember(Name = "gravatar_id")]
		public string GravatarId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

		[DataMember(Name = "company")]
		public string Company { get; set; }

		[DataMember(Name = "location")]
		public string Location { get; set; }

		[DataMember(Name = "created_at")]
		public string CreatedAtRawString
		{
		    get { return CreatedAt.ToString(); }
		    set { CreatedAt = DateTime.Parse(value); }
		}

		public DateTime CreatedAt { get; set; }
		public string CreatedAtFormattedString
		{
			get { return CreatedAt.ToShortDateString(); }
		}

		[DataMember(Name = "public_gist_count")]
		public int PublicGistCount { get; set; }

		[DataMember(Name = "public_repo_count")]
		public int PublicRepoCount { get; set; }

		[DataMember(Name = "blog")]
		public string Blog { get; set; }

		[DataMember(Name = "following")]
		public int Following { get; set; }

		[DataMember(Name = "followers_count")]
		public int Followers { get; set; }

		[DataMember(Name = "id")]
		public int Id { get; set; }

		[DataMember(Name = "login")]
		public string Login { get; set; }

		[DataMember(Name = "email")]
		public string Email { get; set; }
    }
}
