using ActionMethodReturnTypes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ActionMethodReturnTypes.Controllers
{
    #region Format Response with Status Code    

    [Route("api/[controller]")]
    [ApiController]    
    public class AnimalsController : ControllerBase
    {
        object animals = new List<AnimalModel>()
        {
           new AnimalModel(){id = 1, name = "Cat" },
           new AnimalModel(){id = 2, name = "Dog" }
        };        

        [Route("",Name = "all")]
        public ActionResult GetAnimals()
        {            
            return Ok(animals);
        }

        [Route("test")]
        public ActionResult GetAnimalsTest()
        {
            var animals = new List<AnimalModel>()
            {
                new AnimalModel(){id = 1, name = "Cat" },
                new AnimalModel(){id = 2, name = "Dog" }
            };
            return Accepted("~/api/animals");
        }

        [Route("test-animal")]
        public ActionResult GetAnimalsAcceptedAtAction()
        {
            var animals = new List<AnimalModel>()
            {
                new AnimalModel(){id = 1, name = "lion" },
                new AnimalModel(){id = 2, name = "tiger" }
            };
            return AcceptedAtAction("GetAnimals");
        }

        [Route("test-route")]
        public ActionResult GetAnimalsAcceptedAtRoute()
        {
            var animals = new List<AnimalModel>()
            {
                new AnimalModel(){id = 1, name = "lion" },
                new AnimalModel(){id = 2, name = "tiger" }
            };
            return AcceptedAtRoute("all");
        }

        [Route("{name}")]
        public ActionResult GetAnimalsByName(string name)
        {
           if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }
    }
    #endregion
}
