using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RadarcOnline.App.Services
{
    public static class JsonUtils
    {
        private static readonly Regex WrappJsonRegex = new Regex(@"^\{""\w+Result"":\[", RegexOptions.Compiled);

        public static string BuildJsonEnvelope(string paramName, object data, bool includeWrapping)
        {
            var settings = new JsonSerializerSettings() { DateFormatHandling = DateFormatHandling.MicrosoftDateFormat };
            var json = JsonConvert.SerializeObject(data, settings);
            if (includeWrapping)
            {
                //wrapped envelope
                return "{\"" + paramName + "\":" + json + "}";
            }
            else
            {
                return json; //No envelope			
            }
        }

        public static T GetObjectFromJson<T>(string data)
        {
            string payload = IsDataWrapped(data) ? UnwrappPayload(data) : data;

            if (payload == null)
                return default(T);

            T result = JsonConvert.DeserializeObject<T>(payload);
            return result;
        }

        private static string UnwrappPayload(string data)
        {
            var start = data.IndexOf(':') + 1;
            var end = data.LastIndexOf('}');

            if (start >= end || start <= 0 || end <= 0)
                return null;

            string text = data.Substring(start, end - start);
            return text;
        }

        private static bool IsDataWrapped(string data)
        {
            return WrappJsonRegex.IsMatch(data);
        }
    }

    
    public class ByteArrayConverter : JsonConverter
    {
        public override void WriteJson(
            JsonWriter writer,
            object value,
            JsonSerializer serializer)
        {
            writer.WriteNull();
            return;
        }

        public override object ReadJson(
            JsonReader reader,
            Type objectType,
            object existingValue,
            JsonSerializer serializer)
        {
            
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(byte[]);
        }
    }
}
