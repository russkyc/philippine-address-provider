using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;

#pragma warning disable CS8603 // Possible null reference return.
namespace Russkyc.Addressess.Philippines.Utils
{
    public static class JsonResourceReader
    {
        public static async Task<T> ReadAsync<T>(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resource = $"Russkyc.Addressess.Philippines.Resources.{resourceName}";
            using var stream = assembly.GetManifestResourceStream(resource);
            using var reader = new StreamReader(stream);
            var jsonContent = await reader.ReadToEndAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(jsonContent);
        }
    }
}