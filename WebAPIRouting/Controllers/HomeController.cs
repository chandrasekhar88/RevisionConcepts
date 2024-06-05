using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace WebAPIRouting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class HomeController : ControllerBase
    {
        [Route("api/getall")]
        public string GetAll()
        {
            return "Get All";
        }
        
        [Route("api/getall-authors")]
        public string GetAllAuthors()
        {
            return "Get All Authors";
        }

        /// <summary>
        /// Variable in Routing
        /// </summary>        
        [Route("books/{id}")]
        public string GetById(int id)
        {
            return "GetId" + id;
        }

        [Route("books/{id}/author/{authorId}")]
        public string GetAuthorById(int id, int authorId)
        {
            return "Get Book Id and Author Id  " + id +" " + authorId ;
        }

        /// <summary>
        /// Query String in Routing
        /// </summary>
        [Route("search")]
        public string SearchBooks(int id, int authorId, string name, int price)
        {
            return "Get Book id ,AuthorId, Name and Price  " + id + " " + authorId + " " + name + " " + price;
        }

        /// <summary>
        /// Setup multi URLS for Single Resource(Action Method)
        /// </summary>
        [Route("api/get-all")]
        [Route("get-all")]
        [Route("getall")]
        [Route("[controller]/[action]")]
        public string GetAllMethod()
        {
            return "Get All Method";
        }

        /// <summary>
        /// Token Replacement in Routing
        /// </summary>
        [Route("[controller]/[action]")]
        public string GetMethod()
        {
            return "Get Method";
        }

        [Route("~/getoverride")]
        public string GetOverride()
        {
            return "Get Override Controller URL";
        }
    }
}
