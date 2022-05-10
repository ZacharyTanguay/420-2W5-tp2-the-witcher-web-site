using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2_Tanguay_Zachary.Models;
using TP2_Tanguay_Zachary.ViewModels;

namespace TP2_Tanguay_Zachary.Controllers
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
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.Rois = true;
            model.Criteres.Magiciennes = true;
            model.Criteres.Sorceleurs = true;
            model.Resultat = DB.Enfants.ToList();
            return View(model);
        }

        /// <summary>
        /// Action retournant la vue de la page détail
        /// </summary>
        /// <returns>Detail.cshtml / NotFound.cshtml</returns>
        [Route("Enfant/Détail/{id:int}")]
        [Route("Enfant/{id:int}")]
        [Route("{id:int}/Enfant")]
        [Route("/{id:int}")]
        public IActionResult DetailParId(int id)
        {
            var persoRecherché = DB.Enfants.Where(p => p.Id == id).SingleOrDefault();
            if (persoRecherché == null)
            {
                return View("NotFound");
            } else
            {
                return View("Détail", persoRecherché);
            }
        }

        /// <summary>
        /// Action retournant la vue de la page détail
        /// </summary>
        /// <param name="nom"></param>
        /// <returns>Detail.cshtml / NotFound.cshtml</returns>
        /// 
        [Route("Enfant/Détail/{nom}")]
        [Route("Enfant/{nom}")]
        [Route("{nom}/Enfant")]
        [Route("/{nom}")]
        public IActionResult DetailParNom(string nom)
        {
            var persoRecherché = DB.Enfants.Where(p => p.Nom.ToUpper() == nom.ToUpper()).SingleOrDefault();
            if (persoRecherché == null)
            {
                return View("NotFound");
            } else
            {
                return View("Détail", persoRecherché);
            }
        }

        public IActionResult Filtrer(CritereRechercheViewModel criteres)
        {
            //Récupérer les données
            IEnumerable<Enfant> donnees = DB.Enfants;

            //Appliquer le filtre #1 sur "donnees" si nécessaire selon les propriétés de l'objet "criteres"
            if (criteres.MotsCles != null)
                donnees = donnees.Where(p => p.Nom.ToUpper().Contains(criteres.MotsCles.ToUpper()) || p.Role.ToUpper().Contains(criteres.MotsCles.ToUpper()) || p.Genre.ToUpper().Contains(criteres.MotsCles.ToUpper()) || p.Surnom.ToUpper().Contains(criteres.MotsCles.ToUpper()));

            //Appliquer le filtre #2 sur "donnees" si nécessaire selon les propriétés de l'objet "criteres"
            if (criteres.AgePersonnageMin != null)
                donnees = donnees.Where(p => p.Age >= criteres.AgePersonnageMin);

            //Appliquer le filtre #3 sur "donnees" si nécessaire selon les propriétés de l'objet "criteres"
            if (criteres.AgePersonnageMax != null)
                donnees = donnees.Where(p => p.Age <= criteres.AgePersonnageMax);

            //Appliquer le filtre #4 sur "donnees" si nécessaire selon les propriétés de l'objet "criteres"
            if (criteres.ChoixPersonnageVedette == "true")
                donnees = donnees.Where(p => p.Vedette == true);
            else if (criteres.ChoixPersonnageVedette == "false")
                donnees = donnees.Where(p => p.Vedette == false);

            //Appliquer le filtre #5 sur "donnees" si nécessaire selon les propriétés de l'objet "criteres"
            if (criteres.Rois == false)
                donnees = donnees.Where(p => p.IdParent == 2 || p.IdParent == 3);

            if (criteres.Magiciennes == false)
                donnees = donnees.Where(p => p.IdParent == 1 || p.IdParent == 3);

            if (criteres.Sorceleurs == false)
                donnees = donnees.Where(p => p.IdParent == 1 || p.IdParent == 2);

            //Créer une instance de "PageRechercheViewModel"
            PageRechercheViewModel model = new PageRechercheViewModel();

            //Assigner à la propriété de l'instance de "PageRechercheViewModel", les critères reçu en paramètre
            model.Criteres = criteres;

            //Assigner à la propriété "Resultat" de "PageRechercheViewModel", les données (qui sont maintenant filtré)
            model.Resultat = donnees.ToList();

            return View("Recherche", model); //<= Modifier moi afin de retourner la vue pour l'affichage de la liste de recherche en passant l'instance de "PageRecherchViewModel"
        }

    }
}
