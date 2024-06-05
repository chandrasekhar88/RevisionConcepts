using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ModelBiding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [BindProperty]
        public string name { get; set; }

        [BindProperty]
        public int population { get; set; }
        [BindProperty]
        public int area { get; set; }

        [HttpPost]
        public IActionResult AddCountry()
        {
            return Ok("Name =  " + this.name+ "  Population =  " + this.population+ "  Area =  " + this.area);
        }
    }
}
