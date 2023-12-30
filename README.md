
<h2 align="center">Russkyc.Addresses.Philippines - Address Information Provider from the Philippine Standard Geographic Code (PSGC)</h2>

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
IEnumerable<Region> allRegions = AddressProvider.GetRegions();
```
Get by Region
```csharp
// Get a specific region by name
Region? specificRegion = AddressProvider.GetRegion("Region V");
```

Get by Region Name
```csharp
// Get a specific region by region name
Region? specificRegionByName = AddressProvider.GetRegionByName("Bicol Region");
```

Find
```csharp
// Find regions whose names contain the specified string
IEnumerable<Region> matchingRegions = AddressProvider.FindRegion("V");
```

Find by Name
```csharp
// Find regions whose region names contain the specified string
IEnumerable<Region> matchingRegionsByName = AddressProvider.FindRegionByName("Bicol");
```

### II. Provinces

Get All
```csharp
// Get all provinces in the Philippines
IEnumerable<Province> allProvinces = AddressProvider.GetProvinces();
```

Get by Region
```csharp
// Get provinces in a specific region
Region? specificRegion = AddressProvider.GetRegionByName("Bicol Region");
IEnumerable<Province> provincesInRegion = AddressProvider.GetProvincesByRegion(specificRegion);
```

Get by Region code
```csharp
// Get provinces in the region with the specified region code
IEnumerable<Province> provincesInRegionCode = AddressProvider.GetProvincesByRegionCode("050000000");
```

Get by Name
```csharp
// Get a specific province by name
Province? specificProvince = AddressProvider.GetProvinceByName("Albay");
```

Find by Name
```csharp
// Find provinces whose names contain the specified string
IEnumerable<Province> matchingProvinces = AddressProvider.FindProvinceByName("Albay");
```
### III. Cities and Municipalities

Get All
```csharp
// Get all cities and municipalities in the Philippines
IEnumerable<CityMunicipality> allCitiesMunicipalities = AddressProvider.GetCitiesMunicipalities();
```

Get by Region
```csharp
// Get cities and municipalities in a specific region
Region? specificRegion = AddressProvider.GetRegion("Region V");
IEnumerable<CityMunicipality> citiesMunicipalitiesInRegion = AddressProvider.GetCitiesMunicipalitiesByRegion(specificRegion);
```

Get by Region code
```csharp
// Get cities and municipalities in the region with the specified region code
IEnumerable<CityMunicipality> citiesMunicipalitiesInRegionCode = AddressProvider.GetCitiesMunicipalitiesByRegionCode("050000000");
```

Get by Province
```csharp
// Get cities and municipalities in a specific province
Province? specificProvince = AddressProvider.GetProvinceByName("Albay");
IEnumerable<CityMunicipality> citiesMunicipalitiesInProvince = AddressProvider.GetCitiesMunicipalitiesByProvince(specificProvince);
```

Get by Province code
```csharp
// Get cities and municipalities in the province with the specified province code
IEnumerable<CityMunicipality> citiesMunicipalitiesInProvinceCode = AddressProvider.GetCitiesMunicipalitiesByProvinceCode("050500000");
```

Get by Name
```csharp
// Get a specific city or municipality by name
CityMunicipality? specificCityMunicipality = AddressProvider.GetCityMunicipalityByName("Legazpi");
```

Find by Name
```csharp
// Find cities and municipalities whose names contain the specified string
IEnumerable<CityMunicipality> matchingCitiesMunicipalities = AddressProvider.FindCityMunicipalityByName("Quezon");
```

### IV. Barangays

#### GetBarangays

Get All
```csharp
// Get all barangays in the Philippines
IEnumerable<Barangay> allBarangays = AddressProvider.GetBarangays();
```

Get by Region
```csharp
// Get barangays in a specific region
Region? specificRegion = AddressProvider.GetRegion("Region V");
IEnumerable<Barangay> barangaysInRegion = AddressProvider.GetBarangaysByRegion(specificRegion);
```

Get by Region code
```csharp
// Get barangays in the region with the specified region code
IEnumerable<Barangay> barangaysInRegionCode = AddressProvider.GetBarangaysByRegionCode("050000000");
```

Get by Province
```csharp
// Get barangays in a specific province
Province? specificProvince = AddressProvider.GetProvinceByName("Albay");
IEnumerable<Barangay> barangaysInProvince = AddressProvider.GetBarangaysByProvince(specificProvince);
```

Get by Province code
```csharp
// Get barangays in the province with the specified province code
IEnumerable<Barangay> barangaysInProvinceCode = AddressProvider.GetBarangaysByProvinceCode("050500000");
```

Get by City/Municipality
```csharp
// Get barangays in the specified city or municipality
CityMunicipality? specificCityMunicipality = AddressProvider.GetCityMunicipalityByName("Legazpi");
IEnumerable<Barangay> barangaysInCityMunicipality = AddressProvider.GetBarangaysByCityMunicipality(specificCityMunicipality);
```

Get by City/Municipality code
```csharp
// Get barangays in the city or municipality with the specified city code
IEnumerable<Barangay> barangaysInCityCode = AddressProvider.GetBarangaysByCityCode("050506000");
```

Get by Name
```csharp
// Get a specific barangay by name
Barangay? specificBarangay = AddressProvider.GetBarangayByName("Mandaragat");
```

Find by Name
```csharp
// Find barangays whose names contain the specified string
IEnumerable<Barangay> matchingBarangays = AddressProvider.FindBarangayByName("Banlas");
```

### V. ZipCode

Get by City/Municipality
```csharp
// Get the zip code for the specified city or municipality
string zipCodeForCityMunicipality = AddressProvider.GetZipCodeByCityMunicipality(specificCityForZipCode);
```

Get by City/Municipality Name
```csharp
// Get the zip code for the specified city or municipality by name
string zipCodeForCityMunicipalityByName = AddressProvider.GetZipCodeByCityMunicipalityName("Quezon City");
```

## :notebook: API Documentation

### AddressProvider Class

The `AddressProvider` class is a static class that provides access to address information for regions, provinces, cities/municipalities, barangays, and zip codes in the Philippines.

| Method                                                               | Description                                                                                 |
|----------------------------------------------------------------------|---------------------------------------------------------------------------------------------|
| `GetRegions()`                                                       | Gets all regions in the Philippines.                                                        |
| `GetRegion(string name)`                                             | Gets a region by its name, case-insensitive.                                                |
| `GetRegionByName(string regionName)`                                 | Gets a region by its region name, case-insensitive.                                         |
| `FindRegion(string name)`                                            | Finds regions whose names contain the specified string, case-insensitive.                   |
| `FindRegionByName(string regionName)`                                | Finds regions whose region names contain the specified string, case-insensitive.            |
| `GetProvinces()`                                                     | Gets all provinces in the Philippines.                                                      |
| `GetProvincesByRegion(Region region)`                                | Gets provinces in the specified region.                                                     |
| `GetProvincesByRegionCode(string regionCode)`                        | Gets provinces in the region with the specified region code.                                |
| `GetProvinceByName(string provinceName)`                             | Gets a province by its name, case-insensitive.                                              |
| `FindProvinceByName(string provinceName)`                            | Finds provinces whose names contain the specified string, case-insensitive.                 |
| `GetCitiesMunicipalities()`                                          | Gets all cities and municipalities in the Philippines.                                      |
| `GetCitiesMunicipalitiesByRegion(Region region)`                     | Gets cities and municipalities in the specified region.                                     |
| `GetCitiesMunicipalitiesByRegionCode(string regionCode)`             | Gets cities and municipalities in the region with the specified region code.                |
| `GetCitiesMunicipalitiesByProvince(Province province)`               | Gets cities and municipalities in the specified province.                                   |
| `GetCitiesMunicipalitiesByProvinceCode(string provinceCode)`         | Gets cities and municipalities in the province with the specified province code.            |
| `GetCityMunicipalityByName(string cityMunicipalityName)`             | Gets a city or municipality by its name, case-insensitive.                                  |
| `FindCityMunicipalityByName(string cityMunicipalityName)`            | Finds cities and municipalities whose names contain the specified string, case-insensitive. |
| `GetBarangays()`                                                     | Gets all barangays in the Philippines.                                                      |
| `GetBarangaysByRegion(Region region)`                                | Gets barangays in the specified region.                                                     |
| `GetBarangaysByRegionCode(string regionCode)`                        | Gets barangays in the region with the specified region code.                                |
| `GetBarangaysByProvince(Province province)`                          | Gets barangays in the specified province.                                                   |
| `GetBarangaysByProvinceCode(string provinceCode)`                    | Gets barangays in the province with the specified province code.                            |
| `GetBarangaysByCityMunicipality(CityMunicipality cityMunicipality)`  | Gets barangays in the specified city or municipality.                                       |
| `GetBarangaysByCityCode(string cityCode)`                            | Gets barangays in the city or municipality with the specified city code.                    |
| `GetBarangayByName(string barangayName)`                             | Gets a barangay by its name, case-insensitive.                                              |
| `FindBarangayByName(string barangayName)`                            | Finds barangays whose names contain the specified string, case-insensitive.                 |
| `GetZipCodeByCityMunicipality(CityMunicipality cityMunicipality)`    | Gets the zip code for the specified city or municipality.                                   |
| `GetZipCodeByCityMunicipalityName(string cityMunicipalityName)`      | Gets the zip code for the specified city or municipality by name, case-insensitive.         |

## :heart: Donate

This is free and available for everyone to use, but still requires time for development
and maintenance. By choosing to donate, you are not only helping develop this project,
but you are also helping me dedicate more time for creating more tools that help the community :heart:

## :tada: Special Thanks

This project is made easier to develop by Jetbrains! They have provided
Licenses to their IDE's to support development of this open-source project.

<a href="https://www.jetbrains.com/community/opensource/#support">
<img width="200px" src="https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.png" alt="JetBrains Logo (Main) logo.">
</a>