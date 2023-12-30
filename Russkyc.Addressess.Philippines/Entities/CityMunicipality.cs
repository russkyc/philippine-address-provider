#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace Russkyc.Addressess.Philippines.Entities
{
    public class CityMunicipality
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string OldName { get; set; }
        public bool IsCity { get; set; }
        public bool IsMunicipality { get; set; }
        public string ProvinceCode { get; set; }
        public string RegionCode { get; set; }
    }
}