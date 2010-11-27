using Caliburn.Micro;
using mGitHub.SampleApp.ViewModels;

namespace mGitHub.SampleApp
{
	public class MainPageViewModel : Screen
	{
		public MainPageViewModel(MostViewedViewModel mostViewed,
		                         FavoritesViewModel favorites,
		                         AboutViewModel about)
		{
			MostViewed = mostViewed;
			Favorites = favorites;
			About = about;
		}

		public FavoritesViewModel Favorites { get; protected set; }
		public MostViewedViewModel MostViewed { get; protected set; }
		public AboutViewModel About { get; protected set; }
	}
}