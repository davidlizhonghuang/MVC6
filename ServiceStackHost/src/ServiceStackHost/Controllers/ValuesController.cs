using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using EF7forApi.Models;

namespace ServiceStackHost.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        EF7forApi.Repository.IRepository serviceprovider;

        public ValuesController(EF7forApi.Repository.IRepository _serviceprovider)
        {
            serviceprovider = _serviceprovider;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Order> Get()
        {
          // var db= (EF7forApi.Repository.Repository)serviceprovider.GetService(typeof(EF7forApi.Repository.Repository));
            return serviceprovider.getAll();
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
