using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Russkyc.Addressess.Philippines;
using Russkyc.Addressess.Philippines.Entities;

namespace WpfSample.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Province> _provinces;
    
    [ObservableProperty]
    private ObservableCollection<CityMunicipality> _cityMunicipalities;
    
    [ObservableProperty]
    private ObservableCollection<Barangay> _barangays;
    
    [ObservableProperty]
    private Province _province;
    
    [ObservableProperty]
    private CityMunicipality _cityMunicipality;
    
    [ObservableProperty]
    private Barangay _barangay;
    
    [ObservableProperty]
    private string? _zipCode;

    public MainWindowViewModel()
    {
        Provinces = new ObservableCollection<Province>(AddressProvider.GetProvincesAsync().Result);
    }

    async partial void OnProvinceChanged(Province? value)
    {
        if (value == null)
        {
            return;
        }
        var citiesMunicipalities = await AddressProvider.GetCitiesMunicipalitiesByProvinceCodeAsync(value.Code);
        CityMunicipalities = new ObservableCollection<CityMunicipality>(citiesMunicipalities);
    }
    
    async partial void OnCityMunicipalityChanged(CityMunicipality? value)
    {
        if (value == null)
        {
            return;
        }
        var barangays = await AddressProvider.GetBarangaysByCityMunicipalityCodeAsync(value.Code);
        Barangays = new ObservableCollection<Barangay>(barangays);
        ZipCode = await AddressProvider.GetZipCodeByCityMunicipalityNameAsync(value.Name);
    }
    
}