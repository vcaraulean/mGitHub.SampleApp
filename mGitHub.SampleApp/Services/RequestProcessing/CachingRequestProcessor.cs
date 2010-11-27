using System;

namespace mGitHub.SampleApp.Services.RequestProcessing
{
	public class CachingRequestProcessor : ProgressAwareRequestProcessor
	{
		private readonly ISimpleCache simpleCache;

		public CachingRequestProcessor(ISimpleCache simpleCache, IProgressService progressService) : base(progressService)
		{
			this.simpleCache = simpleCache;
		}

		protected override void OnBeforeQuery<TResult>(string url, Action<TResult> callback)
		{
			if (simpleCache.HasValue(url))
			{
				callback(simpleCache.Get<TResult>(url));
			}
			else
				base.OnBeforeQuery(url, callback);
		}

		protected override void OnQueryCompleted<TResult>(string url, TResult result)
		{
			simpleCache.Add(url, result);
			base.OnQueryCompleted(url, result);
		}
	}
}