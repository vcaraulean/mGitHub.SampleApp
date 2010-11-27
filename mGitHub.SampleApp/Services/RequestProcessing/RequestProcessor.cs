using System;
using System.Net;

namespace mGitHub.SampleApp.Services.RequestProcessing
{
	public class RequestProcessor : IRequestProcessor
	{
		private const string GithubBaseURL = "http://github.com/api/v2/json/";

		private static string GetFormattedUrl(string url)
		{
			var formatedURL = string.Format("{0}{1}",
			                                url.StartsWith("http") ? url : GithubBaseURL,
			                                url.StartsWith("http") ? "" : url);
			return formatedURL;
		}

		public void Query<TResult>(string url, Action<TResult> callback)
		{
			OnBeforeQuery(url, callback);

			var fullUrl = GetFormattedUrl(url);

			var webClient = new WebClient();
			webClient.DownloadStringCompleted += (sender, args) =>
			{
				if (args.Result == null)
					callback(default(TResult));

				var result = JsonConverter.FromJson<TResult>(args.Result);
				
				OnQueryCompleted(url, result);

				callback(result);
			};

			webClient.DownloadStringAsync(new Uri(fullUrl));
		}

		protected virtual void OnQueryCompleted<TResult>(string url, TResult result)
		{
		}

		protected virtual void OnBeforeQuery<TResult>(string url, Action<TResult> callback)
		{
		}
	}
}