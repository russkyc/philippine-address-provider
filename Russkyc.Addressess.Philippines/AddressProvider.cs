using System.Collections.Generic;
using System.Linq;
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
        public static IEnumerable<Region> GetRegions()
        {
            return JsonResourceReader.Read<Region[]>(Resource.Regions).OrderBy(region => region.RegionName);
        }

        /// <summary>
        /// Gets a region by its name, case-insensitive.
        /// </summary>
        /// <param name="name">The name of the region.</param>
        /// <returns>The matching Region object, or null if not found.</returns>
        public static Region? GetRegion(string name)
        {
            return GetRegions().FirstOrDefault(region => region.Name.EqualsIgnoreCase(name));
        }

        /// <summary>
        /// Gets a region by its region name, case-insensitive.
        /// </summary>
        /// <param name="regionName">The region name.</param>
        /// <returns>The matching Region object, or null if not found.</returns>
        public static Region? GetRegionByName(string regionName)
        {
            return GetRegions().FirstOrDefault(region => region.RegionName.EqualsIgnoreCase(regionName));
        }

        /// <summary>
        /// Finds regions whose names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="name">The string to search for in region names.</param>
        /// <returns>An IEnumerable of Region objects matching the search criteria.</returns>
        public static IEnumerable<Region> FindRegion(string name)
        {
            return GetRegions().Where(region => region.Name.ContainsIgnoreCase(name));
        }

        /// <summary>
        /// Finds regions whose region names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="regionName">The string to search for in region names.</param>
        /// <returns>An IEnumerable of Region objects matching the search criteria.</returns>
        public static IEnumerable<Region> FindRegionByName(string regionName)
        {
            return GetRegions().Where(region => region.RegionName.ContainsIgnoreCase(regionName));
        }

        /// <summary>
        /// Gets all provinces in the Philippines.
        /// </summary>
        /// <returns>An IEnumerable of Province objects.</returns>
        public static IEnumerable<Province> GetProvinces()
        {
            return JsonResourceReader.Read<Province[]>(Resource.Provinces).OrderBy(province => province.Name);
        }

        /// <summary>
        /// Gets provinces in the specified region.
        /// </summary>
        /// <param name="region">The Region for which to retrieve provinces.</param>
        /// <returns>An IEnumerable of Province objects in the specified region.</returns>
        public static IEnumerable<Province> GetProvincesByRegion(Region region)
        {
            return GetProvinces().Where(province => province.RegionCode.EqualsIgnoreCase(region.Code));
        }

        /// <summary>
        /// Gets provinces in the region with the specified region code.
        /// </summary>
        /// <param name="regionCode">The code of the region for which to retrieve provinces.</param>
        /// <returns>An IEnumerable of Province objects in the specified region.</returns>
        public static IEnumerable<Province> GetProvincesByRegionCode(string regionCode)
        {
            return GetProvinces().Where(province => province.RegionCode.EqualsIgnoreCase(regionCode));
        }

        /// <summary>
        /// Gets a province by its name, case-insensitive.
        /// </summary>
        /// <param name="provinceName">The name of the province.</param>
        /// <returns>The matching Province object, or null if not found.</returns>
        public static Province? GetProvinceByName(string provinceName)
        {
            return GetProvinces().FirstOrDefault(province => province.Name.EqualsIgnoreCase(provinceName));
        }

        /// <summary>
        /// Finds provinces whose names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="provinceName">The string to search for in province names.</param>
        /// <returns>An IEnumerable of Province objects matching the search criteria.</returns>
        public static IEnumerable<Province> FindProvinceByName(string provinceName)
        {
            return GetProvinces().Where(province => province.Name.ContainsIgnoreCase(provinceName));
        }

        ///
        /// Cities and Municipalities
        /// 
        /// <summary>
        /// Gets all cities and municipalities in the Philippines.
        /// </summary>
        /// <returns>An IEnumerable of CityMunicipality objects.</returns>
        public static IEnumerable<CityMunicipality> GetCitiesMunicipalities()
        {
            return JsonResourceReader.Read<CityMunicipality[]>(Resource.CitiesMunicipalities).OrderBy(cityMunicipality => cityMunicipality.Name);
        }

        /// <summary>
        /// Gets cities and municipalities in the specified region.
        /// </summary>
        /// <param name="region">The Region for which to retrieve cities and municipalities.</param>
        /// <returns>An IEnumerable of CityMunicipality objects in the specified region.</returns>
        public static IEnumerable<CityMunicipality> GetCitiesMunicipalitiesByRegion(Region region)
        {
            return GetCitiesMunicipalities()
                .Where(cityMunicipality => cityMunicipality.RegionCode.EqualsIgnoreCase(region.Code));
        }

        /// <summary>
        /// Gets cities and municipalities in the region with the specified region code.
        /// </summary>
        /// <param name="regionCode">The code of the region for which to retrieve cities and municipalities.</param>
        /// <returns>An IEnumerable of CityMunicipality objects in the specified region.</returns>
        public static IEnumerable<CityMunicipality> GetCitiesMunicipalitiesByRegionCode(string regionCode)
        {
            return GetCitiesMunicipalities()
                .Where(cityMunicipality => cityMunicipality.RegionCode.EqualsIgnoreCase(regionCode));
        }

        /// <summary>
        /// Gets cities and municipalities in the specified province.
        /// </summary>
        /// <param name="province">The Province for which to retrieve cities and municipalities.</param>
        /// <returns>An IEnumerable of CityMunicipality objects in the specified province.</returns>
        public static IEnumerable<CityMunicipality> GetCitiesMunicipalitiesByProvince(Province province)
        {
            return GetCitiesMunicipalities()
                .Where(cityMunicipality => cityMunicipality.ProvinceCode.EqualsIgnoreCase(province.Code));
        }

        /// <summary>
        /// Gets cities and municipalities in the province with the specified province code.
        /// </summary>
        /// <param name="provinceCode">The code of the province for which to retrieve cities and municipalities.</param>
        /// <returns>An IEnumerable of CityMunicipality objects in the specified province.</returns>
        public static IEnumerable<CityMunicipality> GetCitiesMunicipalitiesByProvinceCode(string provinceCode)
        {
            return GetCitiesMunicipalities()
                .Where(cityMunicipality => cityMunicipality.ProvinceCode.EqualsIgnoreCase(provinceCode));
        }

        /// <summary>
        /// Gets a city or municipality by its name, case-insensitive.
        /// </summary>
        /// <param name="cityMunicipalityName">The name of the city or municipality.</param>
        /// <returns>The matching CityMunicipality object, or null if not found.</returns>
        public static CityMunicipality? GetCityMunicipalityByName(string cityMunicipalityName)
        {
            return GetCitiesMunicipalities().FirstOrDefault(cityMunicipality =>
                cityMunicipality.Name.EqualsIgnoreCase(cityMunicipalityName)
                || cityMunicipality.OldName.EqualsIgnoreCase(cityMunicipalityName));
        }

        /// <summary>
        /// Finds cities and municipalities whose names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="cityMunicipalityName">The string to search for in city and municipality names.</param>
        /// <returns>An IEnumerable of CityMunicipality objects matching the search criteria.</returns>
        public static IEnumerable<CityMunicipality> FindCityMunicipalityByName(string cityMunicipalityName)
        {
            return GetCitiesMunicipalities().Where(cityMunicipality =>
                cityMunicipality.Name.ContainsIgnoreCase(cityMunicipalityName)
                || cityMunicipality.OldName.ContainsIgnoreCase(cityMunicipalityName));
        }

        /// <summary>
        /// Gets all barangays in the Philippines.
        /// </summary>
        /// <returns>An IEnumerable of Barangay objects.</returns>
        public static IEnumerable<Barangay> GetBarangays()
        {
            return JsonResourceReader.Read<Barangay[]>(Resource.Barangays).OrderBy(barangay => barangay.Name);
        }

        /// <summary>
        /// Gets barangays in the specified region.
        /// </summary>
        /// <param name="region">The Region for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified region.</returns>
        public static IEnumerable<Barangay> GetBarangaysByRegion(Region region)
        {
            return GetBarangays().Where(barangay => barangay.RegionCode.EqualsIgnoreCase(region.Code));
        }

        /// <summary>
        /// Gets barangays in the region with the specified region code.
        /// </summary>
        /// <param name="regionCode">The code of the region for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified region.</returns>
        public static IEnumerable<Barangay> GetBarangaysByRegionCode(string regionCode)
        {
            return GetBarangays().Where(barangay => barangay.RegionCode.EqualsIgnoreCase(regionCode));
        }

        /// <summary>
        /// Gets barangays in the specified province.
        /// </summary>
        /// <param name="province">The Province for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified province.</returns>
        public static IEnumerable<Barangay> GetBarangaysByProvince(Province province)
        {
            return GetBarangays().Where(barangay => barangay.ProvinceCode.EqualsIgnoreCase(province.Code));
        }

        /// <summary>
        /// Gets barangays in the province with the specified province code.
        /// </summary>
        /// <param name="provinceCode">The code of the province for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified province.</returns>
        public static IEnumerable<Barangay> GetBarangaysByProvinceCode(string provinceCode)
        {
            return GetBarangays().Where(barangay => barangay.ProvinceCode.EqualsIgnoreCase(provinceCode));
        }

        /// <summary>
        /// Gets barangays in the specified city or municipality.
        /// </summary>
        /// <param name="cityMunicipality">The CityMunicipality for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified city or municipality.</returns>
        public static IEnumerable<Barangay> GetBarangaysByCityMunicipality(CityMunicipality cityMunicipality)
        {
            return GetBarangays()
                .Where(barangay => barangay.CityMunicipalityCode.EqualsIgnoreCase(cityMunicipality.Code));
        }

        /// <summary>
        /// Gets barangays in the city or municipality with the specified city code.
        /// </summary>
        /// <param name="cityCode">The code of the city or municipality for which to retrieve barangays.</param>
        /// <returns>An IEnumerable of Barangay objects in the specified city or municipality.</returns>
        public static IEnumerable<Barangay> GetBarangaysByCityCode(string cityCode)
        {
            return GetBarangays().Where(barangay => barangay.CityMunicipalityCode.EqualsIgnoreCase(cityCode));
        }

        /// <summary>
        /// Gets a barangay by its name, case-insensitive.
        /// </summary>
        /// <param name="barangayName">The name of the barangay.</param>
        /// <returns>The matching Barangay object, or null if not found.</returns>
        public static Barangay? GetBarangayByName(string barangayName)
        {
            return GetBarangays().FirstOrDefault(barangay => barangay.Name.EqualsIgnoreCase(barangayName));
        }

        /// <summary>
        /// Finds barangays whose names contain the specified string, case-insensitive.
        /// </summary>
        /// <param name="barangayName">The string to search for in barangay names.</param>
        /// <returns>An IEnumerable of Barangay objects matching the search criteria.</returns>
        public static IEnumerable<Barangay> FindBarangayByName(string barangayName)
        {
            return GetBarangays().Where(barangay => barangay.Name.ContainsIgnoreCase(barangayName));
        }

        /// <summary>
        /// Gets the zip code for the specified city or municipality by 
        /// </summary>
        /// <param name="cityMunicipality">The CityMunicipality for which to retrieve the zip code.</param>
        /// <returns>The zip code for the specified city or municipality, or null if not found.</returns>
        public static string? GetZipCodeByCityMunicipalityAndProvince(CityMunicipality cityMunicipality)
        {
            return JsonResourceReader.Read<Zip[]>(Resource.ZipCodes).FirstOrDefault(zip =>
                zip.CityMunicipality.ContainsIgnoreCase(cityMunicipality.Name.CleanName()))?.ZipCode;
        }

        /// <summary>
        /// Gets the zip code for the specified city or municipality by name, case-insensitive.
        /// </summary>
        /// <param name="cityMunicipalityName">The name of the city or municipality for which to retrieve the zip code.</param>
        /// <returns>The zip code for the specified city or municipality, or null if not found.</returns>
        public static string? GetZipCodeByCityMunicipalityName(string cityMunicipalityName)
        {
            return JsonResourceReader.Read<Zip[]>(Resource.ZipCodes).FirstOrDefault(zip =>
                zip.CityMunicipality.ContainsIgnoreCase(cityMunicipalityName.CleanName()))?.ZipCode;
        }
    }
}