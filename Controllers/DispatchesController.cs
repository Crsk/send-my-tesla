using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SendMyTesla.Models;

namespace SendMyTesla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispatchesController : ControllerBase
    {
        // GET api/dispatches
        [HttpGet]
        public List<Dispatches> Get()
        {
            var db = new MyTeslaContext();
            return db.Dispatches.ToList();
        }

        // GET api/dispatches/5
        [HttpGet("{id}")]
        public Dispatches Get(int id)
        {
            var db = new MyTeslaContext();
            return db.Dispatches.ToList().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/dispatches
        [HttpPost]
        public void Post([FromBody] string body)
        {
            var db = new MyTeslaContext();
            // test
            db.Dispatches.Add(new Dispatches() { ClientId = 1, DispatchAddress = "dasd" });
            db.SaveChanges();
        }

        // PUT api/dispatches/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/dispatches/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
