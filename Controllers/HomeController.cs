using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2_Tanguay_Zachary.Models;

namespace TP2_Tanguay_Zachary.Controllers
{
    public class HomeController : Controller
    {
        public Database DB;

        public HomeController(Database DB)
        {
            this.DB = DB;
        }

        public IActionResult Index()
        {
            return View(DB.Parents);
        }
    }
}