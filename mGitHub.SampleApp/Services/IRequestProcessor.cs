using System;

namespace mGitHub.SampleApp.Services
{
	public interface IRequestProcessor
	{
		void Query<TResult>(string url, Action<TResult> callback);
	}
}