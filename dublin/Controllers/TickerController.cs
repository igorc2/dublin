﻿using Domain.Models;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dublin.Controllers
{
    [Route("api/[controller]")]
    public class TickerController : Controller
    {
        // GET api/values
        [HttpGet]
        public async Task<Ticker> GetAsync()
        {
            var ticker = await new TickerService().GetProductAsync("oi");
            return ticker;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
