using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneStoreBackEnd.Data.Contexts;
using PhoneStoreBackEnd.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhoneStoreBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhonesController : ControllerBase
    {
        private PhoneStoreContext context;
        public PhonesController(PhoneStoreContext context)
        {
            this.context = context;
        }
        // GET: api/<PhonesController>
        [HttpGet]
        public IEnumerable<Phone> Get()
        {

            return context.Phones.ToList();
        }

        // GET api/<PhonesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PhonesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PhonesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PhonesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
