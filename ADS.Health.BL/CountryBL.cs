using ADS.Health.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS.Health.Entities;

namespace ADS.Health.BL
{
    public class CountryBL
    {
        public List<Entities.Countries> GetAllCountries()
        {
            using (dbPatientsDataContext context = new dbPatientsDataContext())
            {
                List<Entities.Countries> listCountries = new List<Entities.Countries>();

                var query = context.sp_Get_Countries();
                Entities.Countries country = new Entities.Countries();

                foreach (var item in query)
                {
                    country = new Entities.Countries();
                    country.ID = item.ID;
                    country.Name = item.Name;
                    listCountries.Add(country);
                }
                return listCountries;
            }
        }
    }
}
