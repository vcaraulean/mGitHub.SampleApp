using System.Collections.Generic;

namespace mGitHub.SampleApp.Services
{
	public interface ISimpleCache
	{
		void Add(string key, object value);
		T Get<T>(string key);
		bool HasValue(string key);
	}

	public class SimpleCache : ISimpleCache
	{
		private readonly IDictionary<string, object> cache;
		public SimpleCache()
		{
			cache = new Dictionary<string, object>();
		}

		public void Add(string key, object value)
		{
			cache[key] = value;
		}

		public T Get<T>(string key)
		{
			return (T) cache[key];
		}

		public bool HasValue(string key)
		{
			return cache.ContainsKey(key);
		}
	}
}