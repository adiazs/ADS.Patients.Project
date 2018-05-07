using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ADS.Health.Entities;
using ADS.Health.WEB.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using ADS.Health.WEB.Libraries;
using System.Text;
using System.Web.Script.Serialization;

namespace ADS.Health.WEB.Controllers
{
    public class PatientsController : AlertsController
    {
        HttpClient httpClient;
        List<Patients> listPatients;
        List<Countries> listCountries;
        List<BloodTypes> listBlood;
        Patients patient;

        // GET: Patients
        public async Task<ActionResult> Index()
        {
            return View(await GetAllPatients());
        }

        // GET: Patients/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            listPatients = new List<Patients>();
            listPatients = await GetAllPatients();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            patient = new Patients();
            patient = listPatients.Where(p => p.ID == id).SingleOrDefault();

            if (patient == null)
            {
                return HttpNotFound();
            }

            return View(patient);
        }

        // GET: Patients/Create
        public async Task<ActionResult> Create()
        {
            /**** ViewBag to Dropdowns *******/
            ViewBag.BloodType = new SelectList(await GetAllBloodTypes(), "ID", "Abbreviation");
            ViewBag.Nationality = new SelectList(await GetAllCountries(), "ID", "Name");
            return View();
        }

        // POST: Patients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Patients patients)
        {
            ViewBag.BloodType = new SelectList(await GetAllBloodTypes(), "ID", "Abbreviation");
            ViewBag.Nationality = new SelectList(await GetAllCountries(), "ID", "Name");

            if (ModelState.IsValid)
            {
                HttpResponseMessage result = await AddPatient(patients);
                if (result.IsSuccessStatusCode)
                {
                    Success(string.Format("<b>{0} {1} {2}</b>", patients.FirstName, patients.LastName, Messages.SuccessMessage), true);
                    return RedirectToAction("Index");
                }
            }
            Error(Messages.ErrorMessage);
            return View(patients);
        }


        // GET: Patients/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            listCountries = new List<Countries>();
            listCountries = await GetAllCountries();

            listPatients = new List<Patients>();
            listPatients = await GetAllPatients();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Patients patient = new Patients();
            patient = listPatients.Where(p => p.ID == id).SingleOrDefault();

            ViewBag.Nationality = new SelectList(listCountries, "ID", "Name", patient.Countries.ID);
            ViewBag.BloodType = new SelectList(await GetAllBloodTypes(), "ID", "Abbreviation", patient.BloodTypes.ID);

            //ViewBag.idNationality = patient.Countries.ID;

            if (patient == null)
            {
                return HttpNotFound();
            } 
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = @"ID,FirstName,LastName,DateBirth,Nationality,
                                                 BloodType,Diseases,PhoneNumber,")] Patients patients)
        {
            ViewBag.BloodType = new SelectList(await GetAllBloodTypes(), "ID", "Abbreviation");
            ViewBag.Nationality = new SelectList(await GetAllCountries(), "ID", "Name");

            if (ModelState.IsValid)
            {
                HttpResponseMessage result = await UpdatePatient(patients);
                if(result.IsSuccessStatusCode)
                    return RedirectToAction("Index");
            }
            return View(patients);
        }

        // GET: Patients/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            listPatients = new List<Patients>();
            listPatients = await GetAllPatients();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            patient = new Patients();
            patient = listPatients.Where(p => p.ID == id).SingleOrDefault();

            if (patient == null)
            {
                return HttpNotFound();
            }

            return View(patient);

        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            HttpResponseMessage result = await DeletePatient(id);

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }

        private async Task<List<Patients>> GetAllPatients()
        {
            httpClient = new HttpClient();
            var patientsInfo = await httpClient.GetStringAsync(Properties.Settings.Default.APIURL + Constants.Patients);
            listPatients = JsonConvert.DeserializeObject<List<Patients>>(patientsInfo);
            return listPatients;
        }

        private Task<HttpResponseMessage> AddPatient(Patients patient)
        {
            httpClient = new HttpClient();
            var json = new JavaScriptSerializer().Serialize(patient);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var result = httpClient.PostAsync(ADS.Health.WEB.Properties.Settings.Default.APIURL + Constants.Patients, content);
            return result;
        }

        private Task<HttpResponseMessage> UpdatePatient(Patients patient)
        {
            httpClient = new HttpClient();
            var json = new JavaScriptSerializer().Serialize(patient);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var result = httpClient.PutAsync(ADS.Health.WEB.Properties.Settings.Default.APIURL + Constants.Patients, content);
            return result;
        }

        private async Task<HttpResponseMessage> DeletePatient(int id)
        {
            httpClient = new HttpClient();
            string uri = ADS.Health.WEB.Properties.Settings.Default.APIURL + Constants.Patients + "/" + id;
            var result = await httpClient.DeleteAsync(uri);
            return result;
        }


        private async Task<List<Countries>> GetAllCountries()
        {
            httpClient = new HttpClient();
            var countryInfo = await httpClient.GetStringAsync(Properties.Settings.Default.APIURL + Constants.Countries);
            listCountries = JsonConvert.DeserializeObject<List<Countries>>(countryInfo);
            return listCountries;
        }

        private async Task<List<BloodTypes>> GetAllBloodTypes()
        {
            httpClient = new HttpClient();
            var bloodInfo = await httpClient.GetStringAsync(Properties.Settings.Default.APIURL + Constants.BloodTypes);
            listBlood = JsonConvert.DeserializeObject<List<BloodTypes>>(bloodInfo);
            return listBlood;
        }
    }
}
