using System.IO;
using System.Reflection;
using Newtonsoft.Json;

#pragma warning disable CS8603 // Possible null reference return.
namespace Russkyc.Addressess.Philippines.Utils
{
    public static class JsonResourceReader
    {
        public static T Read<T>(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resource = $"Russkyc.Addressess.Philippines.Resources.{resourceName}";
            using var stream = assembly.GetManifestResourceStream(resource);
            using var reader = new StreamReader(stream);
            return JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
        }
    }
}