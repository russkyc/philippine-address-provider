using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Russkyc.Addressess.Philippines.Configs;
using Russkyc.Addressess.Philippines.Entities;
using Russkyc.Addressess.Philippines.Utils;

namespace Russkyc.Addressess.Philippines
{
    /// <summary>
    /// Provides access to address information for regions, provinces,
    /// cities/municipalities, barangays,and zip codes in the Philippines.
    /// </summary>
    public static class AddressProvider
    {
        /// <summary>
        /// Gets all regions in the Philippines.
        /// </summary>
        /// <returns>An IEnumerable of Region objects.</returns>
        public static async Task<IEnumerable<Region>> GetRegionsAsync()
        {
            return (await JsonResourceReader.ReadAsync<Region[]>(Resource.Regions))
                .OrderBy(region => region.RegionName);
        }

        /// <summary>
        /// Gets a region by its name, case-insensitive.
        /// </summary>
        /// <param name="name">The name of the region.</param>
        /// <returns>The matching Region object, or null if not found.</returns>
        public static async Task<Region?> GetRegionAsync(string name)
        {
            return (await GetRegionsAsync())
                .FirstOrDefault(region => region.Name.EqualsIgnoreCase(name));
        }

        /// <summary>
        /// Gets a region by its region name, case-insensitive.
        /// </summary>
        /// <param name="regionName">The region name.</param>
        /// <returns>The matching Region object, or null if not found.</returns>
        public static async Task<Region?> GetRegionByNameAsync(string regionName)
        {
            return (await GetRegionsAsync()).FirstOrDefault(region => region.RegionName.EqualsIgnoreCase(regionName));
        }

        /// <summary>
        /// Finds regions whose names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="name">The string to search for in region names.</param>
        /// <returns>An IEnumerable of Region objects matching the search criteria.</returns>
        public static async Task<IEnumerable<Region>> FindRegionAsync(string name)
        {
            return (await GetRegionsAsync()).Where(region => region.Name.ContainsIgnoreCase(name));
        }

        /// <summary>
        /// Finds regions whose region names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="regionName">The string to search for in region names.</param>
        /// <returns>An IEnumerable of Region objects matching the search criteria.</returns>
        public static async Task<IEnumerable<Region>> FindRegionByNameAsync(string regionName)
        {
            return (await GetRegionsAsync()).Where(region => region.RegionName.ContainsIgnoreCase(regionName));
        }

        /// <summary>
        /// Gets all provinces in the Philippines.
        /// </summary>
        /// <returns>An IEnumerable of Province objects.</returns>
        public static async Task<IEnumerable<Province>> GetProvincesAsync()
        {
            return (await JsonResourceReader.ReadAsync<Province[]>(Resource.Provinces))
                .OrderBy(province => province.Name);
        }

        /// <summary>
        /// Gets provinces in the specified region.
        /// </summary>
        /// <param name="region">The Region for which to retrieve provinces.</param>
        /// <returns>An IEnumerable of Province objects in the specified region.</returns>
        public static async Task<IEnumerable<Province>> GetProvincesByRegionAsync(Region region)
        {
            return (await GetProvincesAsync())
                .Where(province => province.RegionCode.EqualsIgnoreCase(region.Code));
        }

        /// <summary>
        /// Gets provinces in the region with the specified region code.
        /// </summary>
        /// <param name="regionCode">The code of the region for which to retrieve provinces.</param>
        /// <returns>An IEnumerable of Province objects in the specified region.</returns>
        public static async Task<IEnumerable<Province>> GetProvincesByRegionCodeAsync(string regionCode)
        {
            return (await GetProvincesAsync())
                .Where(province => province.RegionCode.EqualsIgnoreCase(regionCode));
        }

        /// <summary>
        /// Gets a province by its name, case-insensitive.
        /// </summary>
        /// <param name="provinceName">The name of the province.</param>
        /// <returns>The matching Province object, or null if not found.</returns>
        public static async Task<Province?> GetProvinceByNameAsync(string provinceName)
        {
            return (await GetProvincesAsync())
                .FirstOrDefault(province => province.Name.EqualsIgnoreCase(provinceName));
        }

        /// <summary>
        /// Finds provinces whose names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="provinceName">The string to search for in province names.</param>
        /// <returns>An IEnumerable of Province objects matching the search criteria.</returns>
        public static async Task<IEnumerable<Province>> FindProvinceByNameAsync(string provinceName)
        {
            return (await GetProvincesAsync())
                .Where(province => province.Name.ContainsIgnoreCase(provinceName));
        }

        ///
        /// Cities and Municipalities
        /// 
        /// <summary>
        /// Gets all cities and municipalities in the Philippines.
        /// </summary>
        /// <returns>An IEnumerable of CityMunicipality objects.</returns>
        public static async Task<IEnumerable<CityMunicipality>> GetCitiesMunicipalitiesAsync()
        {
            return (await JsonResourceReader.ReadAsync<CityMunicipality[]>(Resource.CitiesMunicipalities))
                .OrderBy(cityMunicipality => cityMunicipality.Name);
        }

        /// <summary>
        /// Gets cities and municipalities in the specified region.
        /// </summary>
        /// <param name="region">The Region for which to retrieve cities and municipalities.</param>
        /// <returns>An IEnumerable of CityMunicipality objects in the specified region.</returns>
        public static async Task<IEnumerable<CityMunicipality>> GetCitiesMunicipalitiesByRegionAsync(Region region)
        {
            return (await GetCitiesMunicipalitiesAsync())
                .Where(cityMunicipality => cityMunicipality.RegionCode.EqualsIgnoreCase(region.Code));
        }

        /// <summary>
        /// Gets cities and municipalities in the region with the specified region code.
        /// </summary>
        /// <param name="regionCode">The code of the region for which to retrieve cities and municipalities.</param>
        /// <returns>An IEnumerable of CityMunicipality objects in the specified region.</returns>
        public static async Task<IEnumerable<CityMunicipality>> GetCitiesMunicipalitiesByRegionCodeAsync(string regionCode)
        {
            return (await GetCitiesMunicipalitiesAsync())
                .Where(cityMunicipality => cityMunicipality.RegionCode.EqualsIgnoreCase(regionCode));
        }

        /// <summary>
        /// Gets cities and municipalities in the specified province.
        /// </summary>
        /// <param name="province">The Province for which to retrieve cities and municipalities.</param>
        /// <returns>An IEnumerable of CityMunicipality objects in the specified province.</returns>
        public static async Task<IEnumerable<CityMunicipality>> GetCitiesMunicipalitiesByProvinceAsync(Province province)
        {
            return (await GetCitiesMunicipalitiesAsync())
                .Where(cityMunicipality => cityMunicipality.ProvinceCode.EqualsIgnoreCase(province.Code));
        }

        /// <summary>
        /// Gets cities and municipalities in the province with the specified province code.
        /// </summary>
        /// <param name="provinceCode">The code of the province for which to retrieve cities and municipalities.</param>
        /// <returns>An IEnumerable of CityMunicipality objects in the specified province.</returns>
        public static async Task<IEnumerable<CityMunicipality>> GetCitiesMunicipalitiesByProvinceCodeAsync(string provinceCode)
        {
            return (await GetCitiesMunicipalitiesAsync())
                .Where(cityMunicipality => cityMunicipality.ProvinceCode.EqualsIgnoreCase(provinceCode));
        }

        /// <summary>
        /// Gets a city or municipality by its name, case-insensitive.
        /// </summary>
        /// <param name="cityMunicipalityName">The name of the city or municipality.</param>
        /// <returns>The matching CityMunicipality object, or null if not found.</returns>
        public static async Task<CityMunicipality?> GetCityMunicipalityByNameAsync(string cityMunicipalityName)
        {
            return (await GetCitiesMunicipalitiesAsync())
                .FirstOrDefault(cityMunicipality => cityMunicipality.Name.EqualsIgnoreCase(cityMunicipalityName)
                                                    || cityMunicipality.OldName.EqualsIgnoreCase(cityMunicipalityName));
        }

        /// <summary>
        /// Finds cities and municipalities whose names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="cityMunicipalityName">The string to search for in city and municipality names.</param>
        /// <returns>An IEnumerable of CityMunicipality objects matching the search criteria.</returns>
        public static async Task<IEnumerable<CityMunicipality>> FindCityMunicipalityByNameAsync(string cityMunicipalityName)
        {
            return (await GetCitiesMunicipalitiesAsync())
                .Where(cityMunicipality => cityMunicipality.Name.ContainsIgnoreCase(cityMunicipalityName)
                                           || cityMunicipality.OldName.ContainsIgnoreCase(cityMunicipalityName));
        }

        /// <summary>
        /// Gets all barangays in the Philippines.
        /// </summary>
        /// <returns>An IEnumerable of Barangay objects.</returns>
        public static async Task<IEnumerable<Barangay>> GetBarangaysAsync()
        {
            return (await JsonResourceReader.ReadAsync<Barangay[]>(Resource.Barangays))
                .OrderBy(barangay => barangay.Name);
        }

        /// <summary>
        /// Gets barangays in the specified region.
        /// </summary>
        /// <param name="region">The Region for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified region.</returns>
        public static async Task<IEnumerable<Barangay>> GetBarangaysByRegionAsync(Region region)
        {
            return (await GetBarangaysAsync())
                .Where(barangay => barangay.RegionCode.EqualsIgnoreCase(region.Code));
        }

        /// <summary>
        /// Gets barangays in the region with the specified region code.
        /// </summary>
        /// <param name="regionCode">The code of the region for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified region.</returns>
        public static async Task<IEnumerable<Barangay>> GetBarangaysByRegionCodeAsync(string regionCode)
        {
            return (await GetBarangaysAsync())
                .Where(barangay => barangay.RegionCode.EqualsIgnoreCase(regionCode));
        }

        /// <summary>
        /// Gets barangays in the specified province.
        /// </summary>
        /// <param name="province">The Province for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified province.</returns>
        public static async Task<IEnumerable<Barangay>> GetBarangaysByProvinceAsync(Province province)
        {
            return (await GetBarangaysAsync())
                .Where(barangay => barangay.ProvinceCode.EqualsIgnoreCase(province.Code));
        }

        /// <summary>
        /// Gets barangays in the province with the specified province code.
        /// </summary>
        /// <param name="provinceCode">The code of the province for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified province.</returns>
        public static async Task<IEnumerable<Barangay>> GetBarangaysByProvinceCodeAsync(string provinceCode)
        {
            return (await GetBarangaysAsync())
                .Where(barangay => barangay.ProvinceCode.EqualsIgnoreCase(provinceCode));
        }

        /// <summary>
        /// Gets barangays in the specified city or municipality.
        /// </summary>
        /// <param name="cityMunicipality">The CityMunicipality for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified city or municipality.</returns>
        public static async Task<IEnumerable<Barangay>> GetBarangaysByCityMunicipalityAsync(CityMunicipality cityMunicipality)
        {
            return (await GetBarangaysAsync())
                .Where(barangay => barangay.CityMunicipalityCode.EqualsIgnoreCase(cityMunicipality.Code));
        }

        /// <summary>
        /// Gets barangays in the city or municipality with the specified city code.
        /// </summary>
        /// <param name="cityCode">The code of the city or municipality for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified city or municipality.</returns>
        public static async Task<IEnumerable<Barangay>> GetBarangaysByCityMunicipalityCodeAsync(string cityCode)
        {
            return (await GetBarangaysAsync())
                .Where(barangay => barangay.CityMunicipalityCode.EqualsIgnoreCase(cityCode));
        }

        /// <summary>
        /// Gets a barangay by its name, case-insensitive.
        /// </summary>
        /// <param name="barangayName">The name of the barangay.</param>
        /// <returns>The matching Barangay object, or null if not found.</returns>
        public static async Task<Barangay?> GetBarangayByNameAsync(string barangayName)
        {
            return (await GetBarangaysAsync())
                .FirstOrDefault(barangay => barangay.Name.EqualsIgnoreCase(barangayName));
        }

        /// <summary>
        /// Finds barangays whose names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="barangayName">The string to search for in barangay names.</param>
        /// <returns>An IEnumerable of Barangay objects matching the search criteria.</returns>
        public static async Task<IEnumerable<Barangay>> FindBarangayByNameAsync(string barangayName)
        {
            return (await GetBarangaysAsync())
                .Where(barangay => barangay.Name.ContainsIgnoreCase(barangayName));
        }

        /// <summary>
        /// Gets the zip code for the specified city or municipality by 
        /// </summary>
        /// <param name="cityMunicipality">The CityMunicipality for which to retrieve the zip code.</param>
        /// <returns>The zip code for the specified city or municipality, or null if not found.</returns>
        public static async Task<string?> GetZipCodeByCityMunicipalityAndProvinceAsync(CityMunicipality cityMunicipality)
        {
            return (await JsonResourceReader.ReadAsync<Zip[]>(Resource.ZipCodes))
                .FirstOrDefault(zip => zip.CityMunicipality.ContainsIgnoreCase(cityMunicipality.Name.CleanName()))?.ZipCode;
        }

        /// <summary>
        /// Gets the zip code for the specified city or municipality by name, case-insensitive.
        /// </summary>
        /// <param name="cityMunicipalityName">The name of the city or municipality for which to retrieve the zip code.</param>
        /// <returns>The zip code for the specified city or municipality, or null if not found.</returns>
        public static async Task<string?> GetZipCodeByCityMunicipalityNameAsync(string cityMunicipalityName)
        {
            return (await JsonResourceReader.ReadAsync<Zip[]>(Resource.ZipCodes))
                .FirstOrDefault(zip => zip.CityMunicipality.ContainsIgnoreCase(cityMunicipalityName.CleanName()))?.ZipCode;
        }
    }
}