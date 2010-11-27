using System.Runtime.Serialization;

namespace mGitHub.SampleApp.Model
{
	[DataContract]
	public class Contributor
	{
		[DataMember(Name = "gravatar_id")]
		public string GravatarId { get; set; }

		[DataMember(Name = "type")]
		public string Type { get; set; }

		[DataMember(Name = "login")]
		public string Login { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

		[DataMember(Name = "company")]
		public string Company { get; set; }

		[DataMember(Name = "location")]
		public string Location { get; set; }

		[DataMember(Name = "blog")]
		public string Blog { get; set; }
		
		[DataMember(Name = "email")]
		public string Email { get; set; }
		
		[DataMember(Name = "contributions")]
		public int Contributions { get; set; }

	}
}