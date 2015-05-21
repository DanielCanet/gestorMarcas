using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using gestorMarcas.Models;

namespace gestorMarcas.Controllers
{
    public class GestorMarcasController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string GetCategory(string bornDate, string sex)
        {
            Athlete athlete = new Athlete();
            athlete.BornDate = DateTime.Parse(bornDate);

            return athlete.GetCategory();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}