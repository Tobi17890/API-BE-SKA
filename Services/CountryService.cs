using System.Net.Http;
using System.Text.Json;
using MyApiProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApiProject.Services
{
    public class CountryService : ICountryService
    {
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CountryInfo?> GetCountryByNameAsync(GetCountryRequest req)
        {
            var response = await _httpClient.GetAsync($"https://restcountries.com/v2/name/{req.CountyName}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var content = await response.Content.ReadAsStringAsync();
            var countryInfos = JsonSerializer.Deserialize<CountryInfo[]>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return countryInfos?.FirstOrDefault();
        }

        public async Task<IEnumerable<CountryInfo>> GetCountryByAreaAsync(string region, string timezone)
        {
            var response = await _httpClient.GetAsync($"https://restcountries.com/v2/region/{region}");
            if (!response.IsSuccessStatusCode)
            {
                return Enumerable.Empty<CountryInfo>();
            }

            var content = await response.Content.ReadAsStringAsync();
            var countryInfos = JsonSerializer.Deserialize<IEnumerable<CountryInfo>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return countryInfos?.Where(c => c.Timezones.Contains(timezone)) ?? Enumerable.Empty<CountryInfo>();
        }
    }
}