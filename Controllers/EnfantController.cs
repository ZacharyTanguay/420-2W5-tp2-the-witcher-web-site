using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP1_Partie2_Tanguay_Zachary.Models;

namespace TP1_Partie2_Tanguay_Zachary.Controllers
{
    public class EnfantController : Controller
    {
        private Database DB { get; set; }

        public EnfantController(Database db)
        {
            this.DB = db;
        }

        /// <summary>
        /// Action retournant la vue de la page Recherche
        /// </summary>
        /// <returns>Recherche.cshtml</returns>
        public IActionResult Recherche()
        {
            return View(DB.Enfants);
        }
        /// <summary>
        /// Action retournant la vue de la page détail
        /// </summary>
        /// <returns>Detail.cshtml</returns>
        [Route("Enfant/Détail/{id:int}")]
        [Route("Enfant/{id:int}")]
        [Route("{id:int}/Enfant")]
        [Route("p/{id:int}")]
        public IActionResult Détail(int id)
        {
            var persoRecherché = DB.Enfants.Where(p => p.Id == id).SingleOrDefault();
            if (persoRecherché == null)
            {
                return View("NotFound");
            } else
            {
                return View(persoRecherché);
            }
        }

    }
}
