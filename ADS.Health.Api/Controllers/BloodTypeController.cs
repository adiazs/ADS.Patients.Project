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
    public class BloodTypeController : ApiController
    {
        BloodTypeBL blBloodType = new BloodTypeBL();
        
        // GET: api/BloodType
        public List<BloodTypes> Get()
        {
            return blBloodType.GetAllBloodTypes();
        }

        // GET: api/BloodType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BloodType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BloodType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BloodType/5
        public void Delete(int id)
        {
        }
    }
}
