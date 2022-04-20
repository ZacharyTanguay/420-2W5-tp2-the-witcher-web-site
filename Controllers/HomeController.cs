using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP1_Partie2_Tanguay_Zachary.Models;

namespace TP1_Partie2_Tanguay_Zachary.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Action retournant la vue de l'index
        /// </summary>
        /// <returns>Accueil.cshtml</returns>
        public IActionResult Index(Database DB)
        {
            return View(DB.Parents);
        }
    }
}
