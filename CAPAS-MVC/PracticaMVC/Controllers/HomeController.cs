using Microsoft.Graph;
using Newtonsoft.Json;
using PracticaMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace PracticaMVC.Controllers
{
    public class HomeController : Controller
    {

        public async Task<ActionResult> Index()
        {

            //Web Service de Clima 
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://api.weatherunlocked.com/api/current/ar.B2900FBA?lang=es&app_id=2650ce01&app_key=2f9148d1195b186df908b035a22b7f31");
            Clima climaList = JsonConvert.DeserializeObject<Clima>(json);

            return View(climaList);

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