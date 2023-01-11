namespace SmartCompany.Models
{
    public class CountryInfo
    {
        public int Id { get; set; } = 0;
        public string? Name { get; set; }
        public int TotalCases { get; set; } = 0;
        public int TotalDeatch { get; set; } = 0;
        public string DeatchPercentage => (this.TotalDeatch * 100) / this.TotalCases + "%";

        public List<CountryInfo> GetCountryInfos()
        {
            var countryInfos = new List<CountryInfo>();

            countryInfos.Add(new CountryInfo() { Id = 1, Name = "USA", TotalCases = 2137113, TotalDeatch = 3374 });
            countryInfos.Add(new CountryInfo() { Id = 2, Name = "Italy", TotalCases = 56466, TotalDeatch = 34244 });
            countryInfos.Add(new CountryInfo() { Id = 3, Name = "China", TotalCases = 78678, TotalDeatch = 4455 });
            countryInfos.Add(new CountryInfo() { Id = 4, Name = "Spain", TotalCases = 32324, TotalDeatch = 2345 });
            countryInfos.Add(new CountryInfo() { Id = 5, Name = "Gemarny", TotalCases = 23232, TotalDeatch = 8677 });
            countryInfos.Add(new CountryInfo() { Id = 6, Name = "France", TotalCases = 34554, TotalDeatch = 4333 });
            countryInfos.Add(new CountryInfo() { Id = 7, Name = "Iran", TotalCases = 12345, TotalDeatch = 2222 });

            return countryInfos;
        }
    }
}
