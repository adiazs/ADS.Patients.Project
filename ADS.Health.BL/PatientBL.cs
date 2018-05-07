using System.Collections.Generic;
using ADS.Health.DAL;
using ADS.Health.Entities;
using System.Linq;

namespace ADS.Health.BL
{
    public class PatientBL
    {
        /// <summary> 
        /// Get all Patients from database.
        /// </summary> 
        /// <createddate>29-04-18</createddate> 
        /// <creator>Anthony Díaz S.</creator> 
        /// <lastmodificationdate>29-04-18 </lastmodificationdate> 
        /// <lastmodifier>Anthony Díaz</lastmodifier>
        public List<Entities.Patients> GetAllPatients()
        {
            using (dbPatientsDataContext context = new dbPatientsDataContext())
            {
                List<Entities.Patients> listPatients = new List<Entities.Patients>();

                var query = context.sp_Get_Patients();
                Entities.Patients patientEnt = new Entities.Patients();

                foreach (var item in query)
                {
                    patientEnt = new Entities.Patients();
                    patientEnt.ID = item.ID;
                    patientEnt.LastName = item.LastName;
                    patientEnt.BloodTypes = new Entities.BloodTypes {ID = item.idBloodType, Abbreviation = item.BloodType };
                    patientEnt.Countries = new Entities.Countries {ID = item.idCountry, Name = item.Nationality };
                    patientEnt.DateBirth = item.DateBirth;
                    patientEnt.Diseases = item.Diseases;
                    patientEnt.FirstName = item.FirstName;
                    patientEnt.PhoneNumber = item.PhoneNumber;
                    listPatients.Add(patientEnt);
                }
                return listPatients;
            }


        }

        /// <summary> 
        /// Add new patient to database.
        /// </summary> 
        /// <createddate>29-04-18</createddate> 
        /// <creator>Anthony Díaz S.</creator> 
        /// <lastmodificationdate>29-04-18 </lastmodificationdate> 
        /// <lastmodifier>Anthony Díaz</lastmodifier>
        /// <param name="patient" new patient to add></param>
        public int InsertPatient(Entities.Patients patient)
        {
            try
            {
                using (dbPatientsDataContext context = new dbPatientsDataContext())
                {
                    //context.Patients.InsertOnSubmit(nPatient);
                    //context.SubmitChanges();
                    int query = context.sp_Insert_Patients(patient.FirstName, patient.LastName, patient.DateBirth, patient.Nationality,
                        patient.BloodType, patient.Diseases, patient.PhoneNumber);
                    return query;
                }
            }
            catch (System.Exception ex)
            {
                return -1;
                throw ex;
            }
        }
        /// <summary> 
        /// Update a Patient into DataBase
        /// </summary> 
        /// <createddate>29-04-18</createddate> 
        /// <creator>Anthony Díaz S.</creator> 
        /// <lastmodificationdate>29-04-18 </lastmodificationdate> 
        /// <lastmodifier>Anthony Díaz</lastmodifier>
        public int UpdatePatient(Entities.Patients patient)
        {
            try
            {
                using (dbPatientsDataContext context = new dbPatientsDataContext())
                {
                    //nPatient = context.Patients.Single(p => p.ID == patient.ID);
                    //context.SubmitChanges();
                    int query = context.sp_Update_Patient(patient.FirstName, patient.LastName, patient.DateBirth, patient.Nationality,
                        patient.BloodType, patient.Diseases, patient.PhoneNumber, patient.ID);
                    return query;
                }

            }
            catch (System.Exception ex)
            {
                return -1;
                throw ex;
            }
            finally
            {

            }
        }

        /// <summary> 
        /// Delete a Patient from DataBase
        /// </summary> 
        /// <createddate>29-04-18</createddate> 
        /// <creator>Anthony Díaz S.</creator> 
        /// <lastmodificationdate>29-04-18 </lastmodificationdate> 
        /// <lastmodifier>Anthony Díaz</lastmodifier>
        public int DeletePatient(int idPatient)
        {
            try
            {
                using (dbPatientsDataContext context = new dbPatientsDataContext())
                {
                    //var patient = context.Patients.Where(p => p.ID == idPatient).SingleOrDefault();
                    //context.Patients.DeleteAllOnSubmit(patient);
                    //context.SubmitChanges();
                    int query = context.sp_Delete_Patient(idPatient);
                    return query;
                }
            }
            catch (System.Exception ex)
            {
                return -1;
                throw ex;
            }
        }
    }
}
