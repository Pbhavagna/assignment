using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>
    {
        new Country { id = 1, Countryname = "Inadia", Capital = "Delhi" },
        new Country { id = 2, Countryname = "Japan", Capital = "Tokyo" },
        new Country { id = 3, Countryname = "Iran", Capital = "Tehran" }
    };
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }
        public IHttpActionResult Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.id == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
        public IHttpActionResult Post([FromBody] Country country)
        {
            country.id = countries.Count + 1;
            countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.id }, country);
        }
        public IHttpActionResult Put(int id, [FromBody] Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.id == id);
            if (country == null)
            {
                return NotFound();
            }
            country.Countryname = updatedCountry.Countryname;
            country.Capital = updatedCountry.Capital;

            return Ok(country);
        }
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.id == id);
            if (country == null)
            {
                return NotFound();
            }
            countries.Remove(country);
            return Ok(country);
        }
    }

}

