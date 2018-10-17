using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetUtilities
{
    public static class Converters
    {
        public static string ToJson<T>(T model, bool ignoreDefault = false)
        {
            return ignoreDefault ? ToJsonWithIgnoreDefault(model) : ToJson(model);
        }
        private static string ToJson<T>(T model)
        {
            return JsonConvert.SerializeObject(model);
        }

        private static string ToJsonWithIgnoreDefault<T>(T model)
        {
            return JsonConvert.SerializeObject(model,
                Newtonsoft.Json.Formatting.Indented,
                new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
        }
        public static List<T> FromJsonToList<T>(string jsonData)
        {
            return JsonConvert.DeserializeObject<List<T>>(jsonData)
                   ?? new List<T>();
        }
        public static T FromJson<T>(string jsonModel, bool ignoreDefaults)
        {
            using (var sr = new StringReader(jsonModel))
            using (var jr = new JsonTextReader(sr))
            {
                var js = new JsonSerializer();
                if (ignoreDefaults)
                    js.DefaultValueHandling = DefaultValueHandling.Ignore;
                var u = js.Deserialize<T>(jr);
                return u;
            }

        }
    }
}
