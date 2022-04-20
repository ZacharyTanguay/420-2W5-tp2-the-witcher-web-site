using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP2_Tanguay_Zachary.Controllers
{
    public class FavorisController : Controller
    {
        /// <summary>
        /// Action retournant la vue de l'index
        /// </summary>
        /// <returns>Favoris.cshtlm</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
