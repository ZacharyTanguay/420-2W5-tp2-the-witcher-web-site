using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TP2_Tanguay_Zachary.Models;
using TP2_Tanguay_Zachary.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace TP2_Tanguay_Zachary.Controllers
{
    public class FavorisController : Controller
    {
        private Database DB { get; set; }

        public FavorisController(Database db)
        {
            this.DB = db;
        }

        [HttpPost]
        public IActionResult Index()
        {
            List<int> enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }
            var enfantsDeLaBD = DB.Enfants.Where(e => enfantIDs.Contains(e.Id)).ToList();
            return View(enfantsDeLaBD);
        }

        public IActionResult AjouterUnEnfant(int id)
        {
            List<int> enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs");

            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            if (!enfantIDs.Contains(id))
            {
                enfantIDs.Add(id);
            }


            HttpContext.Session.Set<List<int>>("enfantsIDs", enfantIDs);

            var enfantsDeLaBD = DB.Enfants.Where(e => enfantIDs.Contains(e.Id)).ToList();

            return View("Index", enfantsDeLaBD);
        }

        [HttpPost]
        public IActionResult SupprimerUnEnfant(int id)
        {
            List<int> enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs");

            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            if (enfantIDs.Contains(id))
            {
                enfantIDs.Remove(id);
            }


            HttpContext.Session.Set<List<int>>("enfantsIDs", enfantIDs);

            var enfantsDeLaBD = DB.Enfants.Where(e => enfantIDs.Contains(e.Id)).ToList();
            return View("Index", enfantsDeLaBD);
        }
    }
}
