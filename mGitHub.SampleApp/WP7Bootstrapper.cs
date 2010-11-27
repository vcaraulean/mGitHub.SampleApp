using System;
using System.Collections.Generic;
using Caliburn.Micro;
using mGitHub.SampleApp.Services;
using mGitHub.SampleApp.Services.RequestProcessing;
using mGitHub.SampleApp.ViewModels;
using Microsoft.Phone.Tasks;

namespace mGitHub.SampleApp
{
	public class WP7Bootstrapper : PhoneBootstrapper
	{
		readonly PhoneContainer container;

		public WP7Bootstrapper()
		{
			container = new PhoneContainer();
			container.RegisterSingleton(typeof(MainPageViewModel), "MainPageViewModel", typeof(MainPageViewModel));
			container.RegisterSingleton(typeof(FavoritesViewModel), null, typeof(FavoritesViewModel));
			container.RegisterSingleton(typeof(MostViewedViewModel), null, typeof(MostViewedViewModel));
			container.RegisterSingleton(typeof(UserPivotViewModel), "UserPivotViewModel", typeof(UserPivotViewModel));
			container.RegisterSingleton(typeof(UserDetailsViewModel), null, typeof(UserDetailsViewModel));
			container.RegisterSingleton(typeof(UserRepositoriesViewModel), null, typeof(UserRepositoriesViewModel));
			container.RegisterSingleton(typeof(UserWatchingViewModel), null, typeof(UserWatchingViewModel));
			container.RegisterSingleton(typeof(RepositoryPivotViewModel), "RepositoryPivotViewModel", typeof(RepositoryPivotViewModel));
			container.RegisterSingleton(typeof(RepositoryDetailsViewModel), null, typeof(RepositoryDetailsViewModel));
			container.RegisterSingleton(typeof(RepositoryLinksViewModel), null, typeof(RepositoryLinksViewModel));
			container.RegisterSingleton(typeof(RepositoryContributorsViewModel), null, typeof(RepositoryContributorsViewModel));
			container.RegisterSingleton(typeof(AboutViewModel), null, typeof(AboutViewModel));
			container.RegisterSingleton(typeof(IProgressService), null, typeof(ProgressService));
			container.RegisterSingleton(typeof(ISimpleCache), null, typeof(SimpleCache));
			container.RegisterSingleton(typeof(IRequestProcessor), null, typeof(CachingRequestProcessor));

			container.RegisterPerRequest(typeof(IGitHubHost), null, typeof(GitHubHost));

			container.RegisterInstance(typeof(INavigationService), null, new FrameAdapter(RootFrame));
			container.RegisterInstance(typeof(IPhoneService), null, new PhoneApplicationServiceAdapter(PhoneService));


			container.Activator.InstallLauncher<WebBrowserTask>();
			container.Activator.InstallLauncher<EmailComposeTask>();
		}

		protected override object GetInstance(Type service, string key)
		{
			return container.GetInstance(service, key);
		}

		protected override IEnumerable<object> GetAllInstances(Type service)
		{
			return container.GetAllInstances(service);
		}

		protected override void BuildUp(object instance)
		{
			container.BuildUp(instance);
		}   
	}
}