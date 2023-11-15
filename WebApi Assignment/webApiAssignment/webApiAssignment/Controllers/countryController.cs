using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webApiAssignment.Models;

namespace webApiAssignment.Controllers
{
    [RoutePrefix("api/user")]
    public class countryController : ApiController
    {
        static List<country> countrylist = new List<country>()
        {
            new country{ID=1, countryname="India",capital="NewDelhi"},
            new country{ID=2,countryname="Uk", capital="London"},
            new country{ID=3,countryname="France", capital="Paris"},
            new country{ID=4,countryname="Japan",capital="Tokyo"}

        };
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(countrylist);
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var country = countrylist.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody] country country)
        {
            if (country == null)
            {
                return BadRequest("Country cannot be null");
            }

            country.ID = countrylist.Count + 1;
            countrylist.Add(country);

            return CreatedAtRoute("DefaultApi", new { id = country.ID }, country);
        }
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] country country)
        {
            if (country == null)
            {
                return BadRequest("Country cannot be null");
            }

            var existingCountry = countrylist.FirstOrDefault(c => c.ID == id);
            if (existingCountry == null)
            {
                return NotFound();
            }

            existingCountry.countryname = country.countryname;
            existingCountry.capital = country.capital;

            return Ok(existingCountry);
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var country = countrylist.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }

            countrylist.Remove(country);

            return Ok(country);
        }



    }


}
