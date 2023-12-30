namespace Russkyc.Addressess.Philippines.Utils
{
    public static class StringCleaner
    {
        public static string CleanName(this string cityMunicipalityName)
        {
            return cityMunicipalityName.Replace("City of ", "").Replace("Municipality of ", "");
        }
    }
}