using Caliburn.Micro;
using mGitHub.SampleApp.Model;

namespace mGitHub.SampleApp.Views.DesignTime
{
	public class ContributorsDesignData
	{
		public ContributorsDesignData()
		{
			Contributors = new BindableCollection<Contributor>(new[]
			{
				new Contributor{Contributions = 10, Name = "Valeriu Caraulean", Login = "vcaraulean"}, 
				new Contributor{Contributions = 12, Name ="Bill G.", Login = "bgates"}, 
				new Contributor{Contributions = 125, Name = "steve J.", Login = "steve"}, 
			});
		}

		public IObservableCollection<Contributor> Contributors { get; set; }
	}
}