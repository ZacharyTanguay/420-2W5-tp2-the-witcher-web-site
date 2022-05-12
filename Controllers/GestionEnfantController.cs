using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2_Tanguay_Zachary.Models;

namespace TP2_Tanguay_Zachary.Controllers
{
    public class GestionEnfantController : Controller
    {
        private Database DB { get; set; }

        public GestionEnfantController(Database db)
        {
            this.DB = db;
        }

        // GET: GestionEnfantController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GestionEnfantController/Details
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GestionEnfantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GestionEnfantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Enfant pEnfant)
        {
            if (pEnfant == null)
            {
                pEnfant = new Enfant();
            }
            int idMax = DB.Enfants.Max(e => e.Id) + 1;
            Parent parent = DB.Parents.Where(p => p.Id == pEnfant.IdParent).SingleOrDefault();
            pEnfant.Id = idMax;
            pEnfant.Parent = parent;
            parent.Enfants.Add(pEnfant);
            DB.Enfants.Add(pEnfant);
            return RedirectToAction("Index", "Home");
        }

        // GET: GestionEnfantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GestionEnfantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        // GET: GestionEnfantController/Delete
        public ActionResult Delete(int id)
        {
            Enfant enfant = DB.Enfants.Where(p => p.Id == id).SingleOrDefault();

            if (enfant == null)
            {
                return View("NotFound");
            }

            return View(enfant);
        }

        // POST: GestionEnfantController/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Enfant pEnfant)
        {
            Enfant enfant = DB.Enfants.Where(e => e.Id == pEnfant.Id).SingleOrDefault();
            if (enfant == null)
            {
                return View("NotFound");
            }
            Parent parent = DB.Parents.Where(p => p.Id == enfant.IdParent).SingleOrDefault();
            enfant.Parent = parent;
            parent.Enfants.Remove(enfant);
            DB.Enfants.Remove(enfant);

            return RedirectToAction("Index", "Home");
        }
    }
}
