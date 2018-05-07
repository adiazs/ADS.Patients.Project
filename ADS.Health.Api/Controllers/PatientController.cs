using ADS.Health.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ADS.Health.BL;

namespace ADS.Health.Project.Controllers
{
    public class PatientController : ApiController
    {
        PatientBL blPatient = new PatientBL();
        //List<Patients> listPatient = new List<Patients>();
        /*public PatientController()
        {
            //TEST
            listPatient.Add(new Patient
            {
                ID = 1,
                FirstName = "Anthony",
                LastName = "Díaz",
                Nationality = new Country { ID = 1, Name = "Costa Rica" },
                Phone = 89784555,
                Blood = new BloodType { Abbreviation = "A+", Description = "Type A+", ID = 1 },
                DateBirth = "19880706",
                Diseases = "N/A"
            });
            listPatient.Add(new Patient
            {
                ID = 2,
                FirstName = "Javier",
                LastName = "Díaz",
                Nationality = new Country { ID = 1, Name = "Costa Rica" },
                Phone = 87445624,
                Blood = new BloodType { Abbreviation = "A+", Description = "Type A+", ID = 1 },
                DateBirth = "19630530",
                Diseases = "Headache Problems"
            });
            listPatient.Add(new Patient
            {
                ID = 3,
                FirstName = "Carmen",
                LastName = "Sánchez",
                Nationality = new Country { ID = 1, Name = "Costa Rica" },
                Phone = 22356545,
                Blood = new BloodType { Abbreviation = "A+", Description = "Type A+", ID = 1 },
                DateBirth = "19680722",
                Diseases = "Arterial Pressure"
            });

        }*/

        // GET: api/Patient
        public List<Patients> Get()
        {
            return blPatient.GetAllPatients();
           // return listPatient;
        }

        // GET: api/Patient/5
        public Patients Get(int id)
        {
            return null;
            //return listPatient.Where(p => p.ID == id).FirstOrDefault();
        }

        // POST: api/Patient
        public void Post(Patients value)
        {
            blPatient.InsertPatient(value);
            //listPatient.Add(value);
        }

        // PUT: api/Patient/5
        public void Put(Patients value)
        {
            blPatient.UpdatePatient(value);
        }

        // DELETE: api/Patient/5
        public void Delete(int id)
        {
            blPatient.DeletePatient(id);
            //listPatient.Remove(listPatient.Where(p => p.ID == id).FirstOrDefault());
        }
    }
}
