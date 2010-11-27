using System;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.Views.DesignTime
{
	public class UserDetailsDesignData
	{
		public UserDetailsDesignData()
		{
			User = new User()
			{
				Name = "Valeriu Caraulean",
				Blog = "blog.caraulean.com",
				Email = "caraulean@gmail.com",
				Location = "Geneva, Switzerland",
				Company = "authentic solutions",
				CreatedAt = new DateTime(2009, 03, 03),
				PublicRepoCount = 5,
				Following = 10,
				Followers = 2
			};
		}

		public User User { get; set; }
		public string UserDisplayName { get { return User.Name; } }
		public string AvatarSource = "http://gravatar.com/avatar/";
	}
}