using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBiding.Models;

namespace ModelBiding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties(SupportsGet = true)]    
    public class CountriesController : ControllerBase
    {
        public CountryModel country { get; set; }

        [HttpPost("country")]
        public IActionResult AddCountry()
        {
            return Ok($"{this.country.name} {this.country.population} {this.country.area}");
        }

        [HttpGet("")]
        public IActionResult GetCountry()
        {
            return Ok($"{this.country.name} {this.country.population} {this.country.area}");
        }

        /// <summary>
        /// Default Data Binding
        /// </summary>
        [HttpGet("{name}/{area}")]
        public IActionResult GetCountries(string name, int area)
        {
            return Ok($"{name}");
        }

        [HttpPost("")]
        public IActionResult AddCountries(CountryModel country)
        {
            return Ok($"Name = {country.name}");
        }
    }
}
