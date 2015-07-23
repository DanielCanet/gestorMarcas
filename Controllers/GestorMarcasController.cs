using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.WebPages;
using gestorMarcas.Models;

namespace gestorMarcas.Controllers
{
    [RoutePrefix("api/GestorMarcas")]
    public class GestorMarcasController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("category/{bornDate}/{sex}")]
        public string GetCategory(string bornDate, string sex)
        {
            Athlete athlete = new Athlete();
            athlete.BornDate = DateTime.Parse(bornDate);
            athlete.Sex = Person.eSex.M;

            return athlete.GetCategory();
        }

        [HttpGet]
        [Route("years/{bornDate}/{sex}")]
        public string GetYearCategory(string bornDate, string sex)
        {
            Athlete athlete = new Athlete();
            athlete.BornDate = DateTime.Parse(bornDate);
            athlete.Sex = Person.eSex.M;

            return athlete.GetYearCategory();
        }

        [HttpGet]
        [Route("percentage/{bornDate}/{personalBest}")]
        public string GetPercentage(string bornDate, string personalBest)
        {
            AthleticEvent athleticEvent = new AthleticEvent("~/App_Data/BestMarks.xml");
            Athlete athlete = new Athlete();
            athlete.BornDate = DateTime.Parse(bornDate);
            athlete.Sex = Person.eSex.M;

            VelocityRace velocityRaceEvent = new VelocityRace();
            velocityRaceEvent.VelocityRaceType = eVelocityRaceType.m60ll;
            //Action
            decimal result = athleticEvent.GetVelocityRacePercentage(athlete, velocityRaceEvent, personalBest.AsDecimal());
            return result.ToString();
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