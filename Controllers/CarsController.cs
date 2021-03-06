﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SendMyTesla.Models;

namespace SendMyTesla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        // GET api/cars
        [HttpGet]
        public List<Cars> Get()
        {
            var db = new MyTeslaContext();
            return db.Cars.ToList().OrderBy(x => x.Index).Reverse().ToList();
        }

        // GET api/cars/5
        [HttpGet("{id}")]
        public Cars Get(int id)
        {
            var db = new MyTeslaContext();
            return db.Cars.ToList().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/cars
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/cars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/cars/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
