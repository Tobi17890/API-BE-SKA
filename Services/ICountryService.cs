using MyApiProject.Models;

namespace MyApiProject.Services
{
    public interface ICountryService
    {
        Task<CountryInfo> GetCountryByNameAsync(GetCountryRequest req);
        Task<IEnumerable<CountryInfo>> GetCountryByAreaAsync(string region, string timezone);
    }
}