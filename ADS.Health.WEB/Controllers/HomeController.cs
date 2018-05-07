using ADS.Health.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ADS.Health.WEB.Libraries;

namespace ADS.Health.WEB.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync(ADS.Health.WEB.Properties.Settings.Default.APIURL + Constants.Patients);
            List<Patients> listPatient = JsonConvert.DeserializeObject<List<Patients>>(json);

           // ViewBag.BloodTypes = new SelectList()
            return View(listPatient);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}