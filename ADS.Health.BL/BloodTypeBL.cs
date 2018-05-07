using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADS.Health.Entities;
using ADS.Health.DAL;

namespace ADS.Health.BL
{
    public class BloodTypeBL
    {
        public List<Entities.BloodTypes> GetAllBloodTypes()
        {
            using (dbPatientsDataContext context = new dbPatientsDataContext())
            {
                List<Entities.BloodTypes> listBloodTypes = new List<Entities.BloodTypes>();

                var query = context.sp_Get_BloodTypes();
                Entities.BloodTypes bloodType = new Entities.BloodTypes();

                foreach (var item in query)
                {
                    bloodType = new Entities.BloodTypes();
                    bloodType.ID = item.ID;
                    bloodType.Description = item.Description;
                    bloodType.Abbreviation = item.Abbreviation;
                    listBloodTypes.Add(bloodType);
                }
                return listBloodTypes;
            }
        }
    }
}
