using Newtonsoft.Json;

namespace Shared.CrossCutting.Tools
{
    public class ObjectExtensions
    {
        public static T Clone<T>(T objeto) where T : class
        {
            var json = JsonConvert.SerializeObject(objeto, new JsonSerializerSettings() {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
