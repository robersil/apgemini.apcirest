using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace CpageminiApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> listEmployees = new List<Employee>();

        // GET api/values
        [HttpGet]
        public List<Employee> Get()
        {
            return listEmployees;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            listEmployees.Add(new Employee(Convert.ToInt32(employee.Id), employee.Name, employee.LastName, employee.Position));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listEmployees.RemoveAll(x => x.Id == id);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Employee employee)
        {
            var item = listEmployees.FirstOrDefault(x => x.Id == id);

            if (item != null)
            {
                item.Id = employee.Id;
                item.Name = employee.Name;
                item.LastName = employee.LastName;
                item.Position = employee.Position;
            }
        }

        [HttpPatch("{id}")]
        public void Patch(int id, Delta<Employee> employee)
        {
            var item = listEmployees.FirstOrDefault(x => x.Id == id);

            if (item != null)
            {
                employee.Patch(item);
            }
        }














        public void Put(int id, [FromBody] string value)
        {
        }

       
    }
}
