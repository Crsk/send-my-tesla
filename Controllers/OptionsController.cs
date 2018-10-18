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
    public class OptionsController : ControllerBase
    {
        // GET api/options
        [HttpGet]
        public List<Options> Get()
        {
            var db = new MyTeslaContext();
            return db.Options.ToList();
        }

        // GET api/options/5
        [HttpGet("{id}")]
        public Options Get(int id)
        {
            var db = new MyTeslaContext();
            return db.Options.ToList().Where(x => x.Id == id).FirstOrDefault();
        }

        // GET api/options/whe
        [HttpGet("{code}")]
        public List<Options> Get(string code)
        {
            var db = new MyTeslaContext();
            return db.Options.ToList().Where(x => x.Code.Contains(code)).ToList();
        }

        // POST api/options
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/options/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/options/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
