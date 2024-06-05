using ActionMethodReturnTypes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ActionMethodReturnTypes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public string GetEmployees()
        {
            return "Get All Employees";
        }

        [Route("{id}")]
        public EmployeeModel GetEmployee()
        {
            return new EmployeeModel() { id = 1, name = "Ram" };
        }

        [Route("all")]
        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return new List<EmployeeModel>(){
                new EmployeeModel() { id = 1, name = "Ram"},
                new EmployeeModel() { id = 2, name = "Tom"},
                new EmployeeModel() { id = 3, name = "Raj"}
            };
        }

        [Route("{employeeId}")]
        public ActionResult GetEmployees(int employeeId)
        {
            if (employeeId == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(new List<EmployeeModel>()
                {
                new EmployeeModel() { id = 1, name = "Ram"},
                new EmployeeModel() { id = 2, name = "Tom"},
                new EmployeeModel() { id = 3, name = "Raj"}
                });
            }
        }

        [Route("{employeeId}/basic")]
        public ActionResult<EmployeeModel> GetOneEmployee(int employeeId)
        {
            if (employeeId == 0)
            {
                return NotFound();
            }
            else
            {
                return new EmployeeModel { id = 1, name = "Ram" };
            }
        }
    }
}
