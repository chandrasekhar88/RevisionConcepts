using Microsoft.AspNetCore.Mvc;

namespace WebAPIRouting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        ///<summary>
        ///Routing Constraints        
        ///</summary> 

        [Route("{id:int:min(10):max(100)}")]
        public string GetById(int id)
        {
            return "Get by Int id  = " + id;
        }

        [Route("{id:minlength(5):alpha}")]
        public string GetByIdString(string id)
        {
            return "Get by String id  = " + id;
        }

        [Route("{id:regex(a(b|c))}")]
        public string GetByIdRegex(string id)
        {
            return "Get by Regex   = " + id;
        }
    }
}
