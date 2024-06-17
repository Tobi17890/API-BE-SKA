using Microsoft.AspNetCore.Mvc;
using MyApiProject.Models;
using MyApiProject.Services;

namespace MyApiProject.Controllers
{
    // define the class CountryController and its inheritance from ControllerBase
    // SO what is ApiController?
    // ApiController is a class that provides the basic functionality for an MVC controller.
    [ApiController]
    [Route("api")]
    public class CountryController : ControllerBase
    {
        // constructor
        private readonly ICountryService _countryInfo;

        public CountryController(ICountryService countryInfo)
        {
            _countryInfo = countryInfo;
        }

        // define a route for the action method GetCountryInfo
        [HttpGet("GetCountryByName")]
        public async Task<ActionResult<CountryInfo>> GetCountryByName( GetCountryRequest req)
        {
            var countryInfo = await _countryInfo.GetCountryByNameAsync(req);
            return Ok(countryInfo);
        }


        [HttpGet("GetCountryByArea")]
        public async Task<ActionResult<IEnumerable<CountryInfo>>> GetCountryByArea([FromBody] AreaInfo areaInfo)
        {
            var countryInfos = await _countryInfo.GetCountryByAreaAsync(areaInfo.Region, areaInfo.Timezones);
            return Ok(countryInfos);
        }
    }
}