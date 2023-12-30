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
        Provinces = new ObservableCollection<Province>(AddressProvider.GetProvinces());
    }

    partial void OnProvinceChanged(Province value)
    {
        CityMunicipalities =
            new ObservableCollection<CityMunicipality>(
                AddressProvider.GetCitiesMunicipalitiesByProvinceCode(value.Code));
    }
    
    partial void OnCityMunicipalityChanged(CityMunicipality value)
    {
        Barangays =
            new ObservableCollection<Barangay>(
                AddressProvider.GetBarangaysByCityCode(value.Code));
        ZipCode = AddressProvider.GetZipCodeByCityMunicipalityName(value.Name);
    }
    
}