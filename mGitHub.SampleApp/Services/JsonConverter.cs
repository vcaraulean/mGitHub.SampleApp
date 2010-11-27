using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace mGitHub.SampleApp.Services
{
    public static class JsonConverter
    {
        public static T FromJson<T>(string jsonString)
        {
            if (string.IsNullOrEmpty(jsonString))
                throw new ArgumentNullException("jsonString");

			var serializer = new DataContractJsonSerializer(typeof(T));
			using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(jsonString)))
			{
				var deserializedResult = (T)serializer.ReadObject(ms);
				return deserializedResult;
			}
        }
    }
}