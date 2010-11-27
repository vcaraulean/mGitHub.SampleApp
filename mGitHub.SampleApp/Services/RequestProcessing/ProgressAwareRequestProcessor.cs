using System;

namespace mGitHub.SampleApp.Services.RequestProcessing
{
	public class ProgressAwareRequestProcessor : RequestProcessor
	{
		private readonly IProgressService progressService;

		public ProgressAwareRequestProcessor(IProgressService progressService)
		{
			this.progressService = progressService;
		}

		protected override void  OnBeforeQuery<TResult>(string url, Action<TResult> callback)
		{
			progressService.Show();
		}

		protected override void OnQueryCompleted<TResult>(string url, TResult result)
		{
			progressService.Hide();
		}
	}
}