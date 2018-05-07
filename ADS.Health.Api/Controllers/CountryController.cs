using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ADS.Health.Entities;
using ADS.Health.BL;

namespace ADS.Health.Api.Controllers
{
    public class CountryController : ApiController
    {
        CountryBL blCountry = new CountryBL();
        // GET: api/Country
        public List<Entities.Countries> Get()
        {
            return blCountry.GetAllCountries();
        }

        // GET: api/Country/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Country
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Country/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Country/5
        public void Delete(int id)
        {
        }
    }
}
