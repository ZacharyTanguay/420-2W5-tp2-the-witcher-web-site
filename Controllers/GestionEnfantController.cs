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
        public ActionResult Create(Enfant pEnfant)
        {
            return View();
        }

        // POST: GestionEnfantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: GestionEnfantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
