
<h2 align="center">Russkyc.Addresses.Philippines - Address Information Provider from the Philippine Standard Geographic Code Async(PSGC)</h2>

<p align="center">
    <img src="https://img.shields.io/nuget/v/Russkyc.Addressess.Philippines?color=1f72de" alt="Nuget">
    <img src="https://img.shields.io/badge/-.NET%20Standard%202.0-blueviolet?color=1f72de&label=NET" alt="">
    <img src="https://img.shields.io/github/license/russkyc/philippine-address-provider">
    <img src="https://img.shields.io/github/issues/russkyc/philippine-address-provider">
    <img src="https://img.shields.io/nuget/dt/Russkyc.Addressess.Philippines">
</p>


## :arrow_down: Installation

Nuget package installation

```
dotnet add package Russkyc.Addressess.Philippines
```

Imports

```csharp
using Russkyc.Addressess.Philippines;
using Russkyc.Addressess.Philippines.Entities;
```

## :sparkles: Sample Usage

### I. Regions

Get All
```csharp
// Get all regions in the Philippines
IEnumerable<Region> allRegions = await AddressProvider.GetRegionsAsync();
```
Get by Region
```csharp
// Get a specific region by name
Region? specificRegion = await AddressProvider.GetRegionAsync("Region V");
```

Get by Region Name
```csharp
// Get a specific region by region name
Region? specificRegionByName = await AddressProvider.GetRegionByNameAsync("Bicol Region");
```

Find
```csharp
// Find regions whose names contain the specified string
IEnumerable<Region> matchingRegions = await AddressProvider.FindRegionAsync("V");
```

Find by Name
```csharp
// Find regions whose region names contain the specified string
IEnumerable<Region> matchingRegionsByName = await AddressProvider.FindRegionByNameAsync("Bicol");
```

### II. Provinces

Get All
```csharp
// Get all provinces in the Philippines
IEnumerable<Province> allProvinces = await AddressProvider.GetProvincesAsync();
```

Get by Region
```csharp
// Get provinces in a specific region
Region? specificRegion = await AddressProvider.GetRegionByNameAsync("Bicol Region");
IEnumerable<Province> provincesInRegion = await AddressProvider.GetProvincesByRegionAsync(specificRegion);
```

Get by Region code
```csharp
// Get provinces in the region with the specified region code
IEnumerable<Province> provincesInRegionCode = await AddressProvider.GetProvincesByRegionCodeAsync("050000000");
```

Get by Name
```csharp
// Get a specific province by name
Province? specificProvince = await AddressProvider.GetProvinceByNameAsync("Albay");
```

Find by Name
```csharp
// Find provinces whose names contain the specified string
IEnumerable<Province> matchingProvinces = await AddressProvider.FindProvinceByNameAsync("Albay");
```
### III. Cities and Municipalities

Get All
```csharp
// Get all cities and municipalities in the Philippines
IEnumerable<CityMunicipality> allCitiesMunicipalities = await AddressProvider.GetCitiesMunicipalitiesAsync();
```

Get by Region
```csharp
// Get cities and municipalities in a specific region
Region? specificRegion = await AddressProvider.GetRegionAsync("Region V");
IEnumerable<CityMunicipality> citiesMunicipalitiesInRegion = await AddressProvider.GetCitiesMunicipalitiesByRegionAsync(specificRegion);
```

Get by Region code
```csharp
// Get cities and municipalities in the region with the specified region code
IEnumerable<CityMunicipality> citiesMunicipalitiesInRegionCode = await AddressProvider.GetCitiesMunicipalitiesByRegionCodeAsync("050000000");
```

Get by Province
```csharp
// Get cities and municipalities in a specific province
Province? specificProvince = await AddressProvider.GetProvinceByNameAsync("Albay");
IEnumerable<CityMunicipality> citiesMunicipalitiesInProvince = await AddressProvider.GetCitiesMunicipalitiesByProvinceAsync(specificProvince);
```

Get by Province code
```csharp
// Get cities and municipalities in the province with the specified province code
IEnumerable<CityMunicipality> citiesMunicipalitiesInProvinceCode = await AddressProvider.GetCitiesMunicipalitiesByProvinceCodeAsync("050500000");
```

Get by Name
```csharp
// Get a specific city or municipality by name
CityMunicipality? specificCityMunicipality = await AddressProvider.GetCityMunicipalityByNameAsync("Legazpi");
```

Find by Name
```csharp
// Find cities and municipalities whose names contain the specified string
IEnumerable<CityMunicipality> matchingCitiesMunicipalities = await AddressProvider.FindCityMunicipalityByNameAsync("Quezon");
```

### IV. Barangays

#### GetBarangays

Get All
```csharp
// Get all barangays in the Philippines
IEnumerable<Barangay> allBarangays = await AddressProvider.GetBarangaysAsync();
```

Get by Region
```csharp
// Get barangays in a specific region
Region? specificRegion = await AddressProvider.GetRegionAsync("Region V");
IEnumerable<Barangay> barangaysInRegion = await AddressProvider.GetBarangaysByRegionAsync(specificRegion);
```

Get by Region code
```csharp
// Get barangays in the region with the specified region code
IEnumerable<Barangay> barangaysInRegionCode = await AddressProvider.GetBarangaysByRegionCodeAsync("050000000");
```

Get by Province
```csharp
// Get barangays in a specific province
Province? specificProvince = await AddressProvider.GetProvinceByNameAsync("Albay");
IEnumerable<Barangay> barangaysInProvince = await AddressProvider.GetBarangaysByProvinceAsync(specificProvince);
```

Get by Province code
```csharp
// Get barangays in the province with the specified province code
IEnumerable<Barangay> barangaysInProvinceCode = await AddressProvider.GetBarangaysByProvinceCodeAsync("050500000");
```

Get by City/Municipality
```csharp
// Get barangays in the specified city or municipality
CityMunicipality? specificCityMunicipality = await AddressProvider.GetCityMunicipalityByNameAsync("Legazpi");
IEnumerable<Barangay> barangaysInCityMunicipality = await AddressProvider.GetBarangaysByCityMunicipalityAsync(specificCityMunicipality);
```

Get by City/Municipality code
```csharp
// Get barangays in the city or municipality with the specified city code
IEnumerable<Barangay> barangaysInCityCode = await AddressProvider.GetBarangaysByCityCodeAsync("050506000");
```

Get by Name
```csharp
// Get a specific barangay by name
Barangay? specificBarangay = await AddressProvider.GetBarangayByNameAsync("Mandaragat");
```

Find by Name
```csharp
// Find barangays whose names contain the specified string
IEnumerable<Barangay> matchingBarangays = await AddressProvider.FindBarangayByNameAsync("Banlas");
```

### V. ZipCode

Get by City/Municipality
```csharp
// Get the zip code for the specified city or municipality
string zipCodeForCityMunicipality = await AddressProvider.GetZipCodeByCityMunicipalityAsync(specificCityForZipCode);
```

Get by City/Municipality Name
```csharp
// Get the zip code for the specified city or municipality by name
string zipCodeForCityMunicipalityByName = await AddressProvider.GetZipCodeByCityMunicipalityNameAsync("Quezon City");
```

## :notebook: API Documentation

### AddressProvider Class

The `AddressProvider` class is a static class that provides access to address information for regions, provinces, cities/municipalities, barangays, and zip codes in the Philippines.

| Method                                                               | Description                                                                                 |
|----------------------------------------------------------------------|---------------------------------------------------------------------------------------------|
| `GetRegionsAsync()`                                                       | Gets all regions in the Philippines.                                                        |
| `GetRegionAsync(string name)`                                             | Gets a region by its name, case-insensitive.                                                |
| `GetRegionByNameAsync(string regionName)`                                 | Gets a region by its region name, case-insensitive.                                         |
| `FindRegionAsync(string name)`                                            | Finds regions whose names contain the specified string, case-insensitive.                   |
| `FindRegionByNameAsync(string regionName)`                                | Finds regions whose region names contain the specified string, case-insensitive.            |
| `GetProvincesAsync()`                                                     | Gets all provinces in the Philippines.                                                      |
| `GetProvincesByRegionAsync(Region region)`                                | Gets provinces in the specified region.                                                     |
| `GetProvincesByRegionCodeAsync(string regionCode)`                        | Gets provinces in the region with the specified region code.                                |
| `GetProvinceByNameAsync(string provinceName)`                             | Gets a province by its name, case-insensitive.                                              |
| `FindProvinceByNameAsync(string provinceName)`                            | Finds provinces whose names contain the specified string, case-insensitive.                 |
| `GetCitiesMunicipalitiesAsync()`                                          | Gets all cities and municipalities in the Philippines.                                      |
| `GetCitiesMunicipalitiesByRegionAsync(Region region)`                     | Gets cities and municipalities in the specified region.                                     |
| `GetCitiesMunicipalitiesByRegionCodeAsync(string regionCode)`             | Gets cities and municipalities in the region with the specified region code.                |
| `GetCitiesMunicipalitiesByProvinceAsync(Province province)`               | Gets cities and municipalities in the specified province.                                   |
| `GetCitiesMunicipalitiesByProvinceCodeAsync(string provinceCode)`         | Gets cities and municipalities in the province with the specified province code.            |
| `GetCityMunicipalityByNameAsync(string cityMunicipalityName)`             | Gets a city or municipality by its name, case-insensitive.                                  |
| `FindCityMunicipalityByNameAsync(string cityMunicipalityName)`            | Finds cities and municipalities whose names contain the specified string, case-insensitive. |
| `GetBarangaysAsync()`                                                     | Gets all barangays in the Philippines.                                                      |
| `GetBarangaysByRegionAsync(Region region)`                                | Gets barangays in the specified region.                                                     |
| `GetBarangaysByRegionCodeAsync(string regionCode)`                        | Gets barangays in the region with the specified region code.                                |
| `GetBarangaysByProvinceAsync(Province province)`                          | Gets barangays in the specified province.                                                   |
| `GetBarangaysByProvinceCodeAsync(string provinceCode)`                    | Gets barangays in the province with the specified province code.                            |
| `GetBarangaysByCityMunicipalityAsync(CityMunicipality cityMunicipality)`  | Gets barangays in the specified city or municipality.                                       |
| `GetBarangaysByCityCodeAsync(string cityCode)`                            | Gets barangays in the city or municipality with the specified city code.                    |
| `GetBarangayByNameAsync(string barangayName)`                             | Gets a barangay by its name, case-insensitive.                                              |
| `FindBarangayByNameAsync(string barangayName)`                            | Finds barangays whose names contain the specified string, case-insensitive.                 |
| `GetZipCodeByCityMunicipalityAsync(CityMunicipality cityMunicipality)`    | Gets the zip code for the specified city or municipality.                                   |
| `GetZipCodeByCityMunicipalityNameAsync(string cityMunicipalityName)`      | Gets the zip code for the specified city or municipality by name, case-insensitive.         |

## :heart: Donate

This is free and available for everyone to use, but still requires time for development
and maintenance. By choosing to donate, you are not only helping develop this project,
but you are also helping me dedicate more time for creating more tools that help the community :heart:

## :tada: Special Thanks

This project is made easier to develop by Jetbrains! They have provided
Licenses to their IDE's to support development of this open-source project.

<a href="https://www.jetbrains.com/community/opensource/#support">
<img width="200px" src="https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.png" alt="JetBrains Logo Async(Main) logo.">
</a>