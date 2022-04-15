using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WEBAPI_TASK3.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WEBAPI_TASK3.Repository;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEBAPI_TASK3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        // GET: api/<RegistrationController>
        private RegistrationRepo _repo = new RegistrationRepo();
        [HttpGet]
        public async Task<IEnumerable<Regdetails>> Get()
        {
            return (IEnumerable<Regdetails>)await _repo.getAllDetails();
        }

        // GET api/<RegistrationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Regdetails>> Get(int id)
        {
            return await _repo.getDetailsById(id);
        }

        // POST api/<RegistrationController>
        [HttpPost]
        public async Task<ActionResult<Regdetails>> Post([FromBody] Regdetails rd)
        {
            return await _repo.createNewRegistration(rd);
        }

        // PUT api/<RegistrationController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Regdetails rd)
        {
            if(id == rd.Rid)
            {
                await _repo.updateRegistration(id,rd);
                return NoContent();
            }

            return NoContent();
        }

        // DELETE api/<RegistrationController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var res = await _repo.getDetailsById(id);
            if (res == null)
            {
                return NoContent();
            }
            await _repo.deleteRegistration(id);
            return NoContent();
        }
    }
}
