using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace TP2_Tanguay_Zachary.ViewModels
{
    public class CritereRechercheViewModel
    {
        /// <summary>
        /// Get si le personnage est un personnage vedette
        /// </summary>
        public string ChoixPersonnageVedette { get; set; }

        /// <summary>
        /// Get si le personnage est un roi / reine
        /// </summary>
        public bool Rois { get; set; }

        /// <summary>
        /// get si le personnage est un magicien / magicienne
        /// </summary>
        public bool Magiciennes { get; set; }

        /// <summary>
        /// Get si le personnage est un sorceleur / sorceleuse
        /// </summary>
        public bool Sorceleurs { get; set; }

        /// <summary>
        /// Get l'age maximum du personnage
        /// </summary>
        public int? AgePersonnageMax { get; set; }

        /// <summary>
        /// Get l'age minimum du personnage
        /// </summary>
        public int? AgePersonnageMin { get; set; }

        /// <summary>
        /// Get le mot cle saisi
        /// </summary>
        public string MotsCles { get; set; } 
    }
}
